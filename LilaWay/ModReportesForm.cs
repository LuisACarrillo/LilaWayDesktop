using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace LilaWay
{
    public partial class ModReportesForm : Form
    {
        FirestoreDb db;

        public ModReportesForm(string id, string idClient, string idDriver, string status, string description, string type, string victim, string urgency)
        {
            InitializeComponent();
            txtbID.Text = id;
            if(idClient!=null && idDriver!=null)
            {
                cmbidClient.Items.Add(idClient);
                cmbidDriver.Items.Add(idDriver);
            }
            
            cmbidClient.SelectedItem = idClient;
            
            cmbidDriver.SelectedItem = idDriver;
            txtbdescription.Text = description;
            cmbstatus.Text = status;
            cmbType.Text = type;
            cmbVictim.Text = victim;
            cmbUrgency.Text = urgency;

        }


        private async void ModReportesForm_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"lilawaybase.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("lilaway-aca5b");

            

            CollectionReference usersRef = db.Collection("Users");
            QuerySnapshot querySnapshot = await usersRef.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                if (documentSnapshot.ContainsField("id"))
                {
                    string email = documentSnapshot.GetValue<string>("id");
                    string typeUser = documentSnapshot.GetValue<string>("typeUser");
                    if (email != null && typeUser=="Client")
                    {
                        cmbidClient.Items.Add(email);
                        

                    }
                    if (email != null && typeUser == "Driver")
                    {
                        cmbidDriver.Items.Add(email);


                    }
                    
                }
            }


        }

        private async void btnMod_Click(object sender, EventArgs e)
        {



            DocumentReference aggressorRef = null;
            DocumentReference assaultedRef = null;
            String idClient;
            String idDriver;

            CollectionReference usersRef = db.Collection("Users");
            QuerySnapshot querySnapshot = await usersRef.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                if (documentSnapshot.ContainsField("id"))
                {
                    string email = documentSnapshot.GetValue<string>("id");
                    if (email == cmbidClient.Text)
                    {
                        aggressorRef = documentSnapshot.Reference;
                    }
                    if (email == cmbidDriver.Text)
                    {
                        assaultedRef = documentSnapshot.Reference;
                    }
                }
            }

            Dictionary<string, object> data = new Dictionary<string, object>
    {
        {"idClient", cmbidClient.Text},
        {"idDriver", cmbidDriver.Text},
        {"description", txtbdescription.Text},
        {"status", cmbstatus.Text},
        {"type", cmbType.Text},
        {"victim", cmbVictim.Text},
        {"urgency", cmbUrgency.Text},
    };

            DialogResult result;
            string message;
            if (string.IsNullOrEmpty(txtbID.Text))
            {
                // Create a new document
                DocumentReference docRef = db.Collection("Reports").Document();
                await docRef.SetAsync(data);
                result = DialogResult.Yes;
                message = "Registro creado correctamente.";
            }
            else
            {
                // Update an existing document
                DocumentReference docRef = db.Collection("Reports").Document(txtbID.Text);
                await docRef.UpdateAsync(data);
                result = MessageBox.Show("¿Estás seguro que quiere hacer estas modificaciones?", "Confirmación de modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                message = "Registro modificado correctamente.";
            }

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(message);
            }
        }

        private void ModReportesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            ReportesForm reportes = new ReportesForm();
            reportes.ShowDialog();
        }

        private async void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbID.Text != "")
                {
                    string id = txtbID.Text;

                    DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este registro?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DocumentReference docRef = db.Collection("Reports").Document(id);
                        await docRef.DeleteAsync();

                        MessageBox.Show("Registro eliminado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro: " + ex.Message);
            }
        }
    }
}
