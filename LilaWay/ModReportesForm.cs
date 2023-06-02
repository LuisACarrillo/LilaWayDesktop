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
        List<string> cmbidClientOriginalItems = new List<string>();
        List<string> cmbidDriverOriginalItems = new List<string>();
        public ModReportesForm(string id, string idClient, string idDriver, string status, string description, string type, string victim, string urgency)
        {
            InitializeComponent();

            

            txtbID.Text = id;
            if (idClient != null && idDriver != null)
            {
                cmbidClient.Items.Add(idClient);
                cmbidDriver.Items.Add(idDriver);
                cmbidClient.SelectedItem = idClient;
                cmbidDriver.SelectedItem = idDriver;
                cmbType.Items.Add(type);
                cmbidClient.Enabled = true;
                cmbidDriver.Enabled = false;
                cmbVictim.Enabled = false;

                btnMod.Text = "Modificar";
                

            }
            else
            {
                btnDel.Enabled = true;
                btnDel.Visible = false;
                label3.Text = "Agregar Soporte";


            }

            
            txtbdescription.Text = description;
            cmbstatus.Text = status;
            cmbType.Text = type;
            cmbVictim.Text = victim;
            cmbUrgency.Text = urgency;



        }


        private async void btnMod_Click_1(object sender, EventArgs e)
        {
            if(cmbidClient.SelectedItem == null || cmbidDriver.SelectedItem==null || cmbstatus.SelectedItem==null || cmbType.SelectedItem==null || cmbUrgency.SelectedItem== null || cmbVictim.SelectedItem == null || txtbdescription.Text == null)
            {
                MessageBox.Show("Por favor llene todos los campos con valores válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DocumentReference aggressorRef = null;
            DocumentReference assaultedRef = null;
            string idClient = "";
            string idDriver = "";
            string Status = "";
            string Victim = "";
            String Urgency = "";



            CollectionReference usersRef = db.Collection("Users");
            QuerySnapshot querySnapshot = await usersRef.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                if (documentSnapshot.ContainsField("userName"))
                {
                    string email = documentSnapshot.GetValue<string>("userName");
                    string id = documentSnapshot.Id;
                    if (email == cmbidClient.Text)
                    {
                        idClient = id;
                        aggressorRef = documentSnapshot.Reference;
                    }
                    if (email == cmbidDriver.Text)
                    {
                        idDriver = id;
                        assaultedRef = documentSnapshot.Reference;
                    }
                }
            }

            


            if (cmbstatus.Text == "abierto")
            {
                Status = "open";
            }
            else if (cmbstatus.Text == "cerrado")
            {
                Status = "closed";
            }

            if (cmbVictim.Text == "conductora")
            {
                Victim = "Driver";
            }
            else
            {
                Victim = "Client";
            }

            if (cmbUrgency.Text == "urgente")
            {
                Urgency = "urgent";
            }
            else  if(cmbUrgency.Text == "menor")
            {
                Urgency = "minor";
            }

            if (cmbType.SelectedItem == "Falta de pago")
            {
                Urgency = "urgent";
                DocumentReference updateReference = db.Collection("Users").Document(idClient);
                DocumentSnapshot updateSnapshot = await updateReference.GetSnapshotAsync();
                string status = updateSnapshot.GetValue<string>("status");

                Dictionary<string, object> blockData = new Dictionary<string, object>
                {
                { "status", "blocked"}
                };
                await updateReference.UpdateAsync(blockData);

            }


            Dictionary<string, object> data = new Dictionary<string, object>
    {
        {"idClient", idClient},
        {"idDriver", idDriver},
        {"description", txtbdescription.Text},
        {"status", Status},
        {"type", cmbType.Text},
        {"victim", Victim},
        {"urgency", Urgency},
        {"date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffffff")}
    };

            

            DialogResult result;
            string message;
            if (string.IsNullOrEmpty(txtbID.Text))
            {
                // Create a new document
                DocumentReference docRef = db.Collection("Reports").Document();
                if(Urgency=="urgent")
                {
                    cmbType.Text = "urgent";
                }
                await docRef.SetAsync(data);
                result = DialogResult.Yes;
                message = "Registro creado correctamente.";
            }
            else
            {
                // Update an existing document
                DocumentReference docRef = db.Collection("Reports").Document(txtbID.Text);
                if (Urgency == "urgent")
                {
                    cmbType.Text = "urgent";
                }
                await docRef.UpdateAsync(data);
                result = MessageBox.Show("¿Estás seguro que quiere hacer estas modificaciones?", "Confirmación de modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                message = "Registro modificado correctamente.";
                if(Status== "closed")

                {
                    await docRef.DeleteAsync();

                }
            }

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(message);
            }
        }

        private async void btnDel_Click_1(object sender, EventArgs e)
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

        private async void ModReportesForm_Load_1(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"lilawaybase.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("lilaway-aca5b");
            string Status = "";
            string Victim = "";
            String Urgency = "";

            Status = cmbstatus.Text;

            
            if (cmbstatus.SelectedItem == "open")
            {
                cmbstatus.Items.Add("abierto");
                cmbstatus.Items.Add("cerrado");
                cmbstatus.Items.Remove("open");
                cmbstatus.Items.Remove("closed");
                cmbstatus.SelectedItem = "abierto";
            }
            else if (cmbstatus.SelectedItem == "closed")
            {

                cmbstatus.Items.Add("abierto");
                cmbstatus.Items.Add("cerrado");
                cmbstatus.Items.Remove("open");
                cmbstatus.Items.Remove("closed");
                cmbstatus.SelectedItem = "cerrado";
            }


            cmbVictim.Enabled = true;
            if (cmbVictim.SelectedItem == "driver")
            {
                cmbVictim.Items.Add("cliente");
                cmbVictim.Items.Add("conductora");
                cmbVictim.Items.Remove("client");
                cmbVictim.Items.Remove("driver");
                cmbVictim.SelectedItem = "conductora";
            }
            else if (cmbVictim.SelectedItem == "client")
            {
                cmbVictim.Items.Add("cliente");
                cmbVictim.Items.Add("conductora");
                cmbVictim.Items.Remove("client");
                cmbVictim.Items.Remove("driver");
                cmbVictim.SelectedItem = "cliente";
            }

            if (cmbUrgency.SelectedItem == "urgent")
            {
                cmbUrgency.Items.Add("urgente");
                cmbUrgency.Items.Add("menor");
                cmbUrgency.Items.Remove("urgent");
                cmbUrgency.Items.Remove("minor");
                cmbUrgency.SelectedItem = "urgente";
            }
            else if (cmbUrgency.SelectedItem == "minor")
            {
                cmbUrgency.Items.Add("urgente");
                cmbUrgency.Items.Add("menor");
                cmbUrgency.Items.Remove("urgent");
                cmbUrgency.Items.Remove("minor");
                cmbUrgency.SelectedItem = "menor";
            }

            if (txtbID.Text != "")
            {


                LoadImageFromDatabase(txtbID.Text);
                return;
            }
            else
            {
                cmbidClient.Items.AddRange(cmbidClientOriginalItems.ToArray());
                cmbidDriver.Items.AddRange(cmbidDriverOriginalItems.ToArray());
                cmbstatus.Items.Add("abierto");
                cmbstatus.Items.Add("cerrado");
                cmbstatus.Items.Remove("open");
                cmbstatus.Items.Remove("closed");

                cmbVictim.Items.Add("cliente");
                cmbVictim.Items.Add("conductora");
                cmbVictim.Items.Remove("client");
                cmbVictim.Items.Remove("driver");

                cmbUrgency.Items.Add("urgente");
                cmbUrgency.Items.Add("menor");
                cmbUrgency.Items.Remove("urgent");
                cmbUrgency.Items.Remove("minor");
            }

            CollectionReference usersRef = db.Collection("Users");
            
            QuerySnapshot querySnapshot = await usersRef.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                if (documentSnapshot.ContainsField("userName") && documentSnapshot.ContainsField("email"))
                {
                    string email = documentSnapshot.GetValue<string>("userName");
                    string typeUser = documentSnapshot.GetValue<string>("typeUser");
                    if (email != null && typeUser == "Client")
                    {
                        cmbidClient.Items.Add(email);


                    }
                    if (email != null && typeUser == "Driver")
                    {
                        cmbidDriver.Items.Add(email);


                    }

                }
            }

            // Guardar los valores originales del ComboBox cmbidClient
            foreach (var item in cmbidClient.Items)
            {
                cmbidClientOriginalItems.Add(item.ToString());
            }

            // Guardar los valores originales del ComboBox cmbidDriver
            foreach (var item in cmbidDriver.Items)
            {
                cmbidDriverOriginalItems.Add(item.ToString());
            }



        }

        private void ModReportesForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            ReportesForm reportes = new ReportesForm();
            reportes.ShowDialog();
        }

        private async void LoadImageFromDatabase(string reportId)
        {
            if (txtbID.Text != "")
            {
                DocumentReference reportRef = db.Collection("Reports").Document(reportId);
                DocumentSnapshot snapshot = await reportRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    if (snapshot.ContainsField("image"))
                    {
                        string imageUrl = snapshot.GetValue<string>("image");

                        if (!string.IsNullOrEmpty(imageUrl))
                        {
                            try
                            {
                                using (HttpClient httpClient = new HttpClient())
                                {
                                    byte[] imageData = await httpClient.GetByteArrayAsync(imageUrl);
                                    MemoryStream memoryStream = new MemoryStream(imageData);
                                    pictureBox1.Image = Image.FromStream(memoryStream);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La imagen no está disponible en la base de datos.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo de imagen no existe en el documento.");
                    }
                }
                else
                {
                    MessageBox.Show("El informe con el ID proporcionado no existe en la base de datos.");
                }
            }
        }

        private void cmbidClient_TextChanged(object sender, EventArgs e)
        {
            if (txtbID.Text == "") {
                string filtro = cmbidClient.Text.ToLower();

                cmbidClient.Items.Clear();

                foreach (var item in cmbidClientOriginalItems)
                {
                    if (item.ToLower().Contains(filtro))
                    {
                        cmbidClient.Items.Add(item);
                    }
                }

                cmbidClient.DroppedDown = true;

                cmbidClient.SelectionStart = cmbidClient.Text.Length;
                cmbidClient.SelectionLength = 0;
            }
        }

        private void cmbidDriver_TextChanged(object sender, EventArgs e)
        {
            if (txtbID.Text == "")
            {
                string filtro = cmbidDriver.Text.ToLower();

                cmbidDriver.Items.Clear();

                foreach (var item in cmbidDriverOriginalItems)
                {
                    if (item.ToLower().Contains(filtro))
                    {
                        cmbidDriver.Items.Add(item);
                    }
                }

                cmbidDriver.DroppedDown = true;
                cmbidDriver.SelectionStart = cmbidDriver.Text.Length;
                cmbidDriver.SelectionLength = 0;

            }

            }
    }
}
