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
        string aggressora;
        string assaulteda;
        public ModReportesForm(string id, string aggressor, string assaulted, string severity, string reason, string state)
        {
            InitializeComponent();
            txtbID.Text = id;
            cmbAggressor.SelectedItem = aggressor;
            cmbAssaulted.SelectedItem = assaulted;
            txtbReason.Text = reason;
            cmbSeverity.Text = severity;
            cmbState.Text = state;
            aggressora = aggressor;
            assaulteda = assaulted;
        }


        private async void ModReportesForm_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"lilawaybase.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("lilawaybase");

            

            CollectionReference usersRef = db.Collection("Users");
            QuerySnapshot querySnapshot = await usersRef.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                if (documentSnapshot.ContainsField("email"))
                {
                    string email = documentSnapshot.GetValue<string>("email");
                    if (email != null)
                    {
                        cmbAggressor.Items.Add(email);
                        cmbAssaulted.Items.Add(email);

                    }
                }
            }

            cmbAggressor.SelectedItem = aggressora;
            cmbAssaulted.SelectedItem = assaulteda;

        }

        private async void btnMod_Click(object sender, EventArgs e)
        {
            string id = txtbID.Text;
           

            if (txtbID.Text != "")
            {
                DocumentReference aggressorRef = null;
                DocumentReference assaultedRef = null;

                CollectionReference usersRef = db.Collection("Users");
                QuerySnapshot querySnapshot = await usersRef.GetSnapshotAsync();
                foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
                {
                    if (documentSnapshot.ContainsField("email"))
                    {
                        string email = documentSnapshot.GetValue<string>("email");
                        if (email == cmbAggressor.Text)
                        {
                            aggressorRef = documentSnapshot.Reference;
                        }
                        if (email == cmbAssaulted.Text)
                        {
                            assaultedRef = documentSnapshot.Reference;
                        }
                    }
                }

                DocumentReference docRef = db.Collection("Reports").Document(id);

                Dictionary<string, object> data = new Dictionary<string, object>
                {
                    { "Aggressor", aggressorRef },
                    { "Assaulted", assaultedRef },
                    { "Reason", txtbReason.Text },
                    { "Severity", cmbSeverity.Text },
                    { "State", cmbState.Text },
                };

                DialogResult result = MessageBox.Show("¿Estás seguro que quiere hacer estas modificaciones?", "Confirmación de modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await docRef.UpdateAsync(data);
                    MessageBox.Show("Registro modificado correctamente.");
                }
            }
            else
            {
                DocumentReference aggressorRef = null;
                DocumentReference assaultedRef = null;

                CollectionReference usersRef = db.Collection("Users");
                QuerySnapshot querySnapshot = await usersRef.GetSnapshotAsync();
                foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
                {
                    if (documentSnapshot.ContainsField("email"))
                    {
                        string email = documentSnapshot.GetValue<string>("email");
                        if (email == cmbAggressor.Text)
                        {
                            aggressorRef = documentSnapshot.Reference;
                        }
                        if (email == cmbAssaulted.Text)
                        {
                            assaultedRef = documentSnapshot.Reference;
                        }
                    }
                }


                Dictionary<string, object> data = new Dictionary<string, object>
                    {
                       { "Aggressor", aggressorRef },
                            { "Assaulted", assaultedRef },
                             {"Reason", txtbReason.Text },
                            { "Severity", cmbSeverity.Text },
                            { "State", cmbState.Text },

                    };

                DialogResult result = MessageBox.Show("¿Estás seguro que quiere crear este registro?", "Confirmación de creacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    DocumentReference docRef = db.Collection("Reports").Document();
                    await docRef.SetAsync(data);


                    MessageBox.Show("Registro creado correctamente.");
                }
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
                // Obtener el ID del registro que se va a eliminar
                string id = txtbID.Text;

                // Mostrar mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este registro?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si el usuario confirmó la eliminación, eliminar el registro de la base de datos y del DataGridView
                if (result == DialogResult.Yes)
                {
                    DocumentReference docRef = db.Collection("Reports").Document(id);
                    await docRef.DeleteAsync();


                    MessageBox.Show("Registro eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro: " + ex.Message);
            }
        }
    }
}
