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
    public partial class ReportesForm : Form
    {
        FirestoreDb db;
        public ReportesForm()
        {
            InitializeComponent();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"lilawaybase.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("lilawaybase");

        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private async void ReportesForm_Load(object sender, EventArgs e)
        {
            QuerySnapshot snapshot = await db.Collection("Reports").GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Dictionary<string, object> data = document.ToDictionary();

                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow newRow = dataGridView1.Rows[rowIndex];

                newRow.Cells["id"].Value = document.Id;

                // Obtener el documento del agresor y recuperar su nombre
                DocumentReference aggressorRef = (DocumentReference)data["Aggressor"];
                DocumentSnapshot aggressorDoc = await aggressorRef.GetSnapshotAsync();
                string aggressorName = aggressorDoc.GetValue<string>("email");

                // Obtener el documento del agredido y recuperar su nombre
                DocumentReference assaultedRef = (DocumentReference)data["Assaulted"];
                DocumentSnapshot assaultedDoc = await assaultedRef.GetSnapshotAsync();
                string assaultedName = assaultedDoc.GetValue<string>("email");

                // Establecer los valores de las celdas con la información del informe
                newRow.Cells["Aggressor"].Value = aggressorName;
                newRow.Cells["Assaulted"].Value = assaultedName;
                newRow.Cells["Severity"].Value = data["Severity"].ToString();
                newRow.Cells["Reason"].Value = data["Reason"].ToString();
                newRow.Cells["State"].Value = data["State"].ToString();
            }
        }


        

        private async void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string aggressor = row.Cells["aggressor"].Value.ToString();
                string assaulted = row.Cells["assaulted"].Value.ToString();
                string severity = row.Cells["severity"].Value.ToString();
                string reason = row.Cells["reason"].Value.ToString();
                string state = row.Cells["state"].Value.ToString();
                this.Hide();

                ModReportesForm modificarForm = new ModReportesForm(id, aggressor, assaulted, severity, reason, state);

                modificarForm.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModReportesForm modificarForm = new ModReportesForm(null, null, null, null, null, null);
            modificarForm.ShowDialog();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string emailBuscado = textBox1.Text;

            // Query the Users collection to get the document ID for the email address
            QuerySnapshot userSnapshot = await db.Collection("Users").WhereEqualTo("email", emailBuscado).GetSnapshotAsync();
            string userId = null;
            if (userSnapshot.Documents.Count > 0)
            {
                DocumentSnapshot userDocument = userSnapshot.Documents[0];
                userId = userDocument.Id;
            }

            if (userId != null)
            {
                // Create a reference to the user's document
                DocumentReference userRef = db.Collection("Users").Document(userId);

                QuerySnapshot snapshot = await db.Collection("Reports").WhereEqualTo("Aggressor", userRef).WhereNotEqualTo("Assaulted", userRef).GetSnapshotAsync();
                QuerySnapshot snapshot2 = await db.Collection("Reports").WhereEqualTo("Assaulted", userRef).WhereNotEqualTo("Aggressor", userRef).GetSnapshotAsync();

                foreach (DocumentSnapshot document in snapshot.Documents)
                {
                    Dictionary<string, object> data = document.ToDictionary();

                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow newRow = dataGridView1.Rows[rowIndex];

                    newRow.Cells["id"].Value = document.Id;
                    // Obtener el documento del agresor y recuperar su nombre
                    DocumentReference aggressorRef = (DocumentReference)data["Aggressor"];
                    DocumentSnapshot aggressorDoc = await aggressorRef.GetSnapshotAsync();
                    string aggressorName = aggressorDoc.GetValue<string>("email");

                    // Obtener el documento del agredido y recuperar su nombre
                    DocumentReference assaultedRef = (DocumentReference)data["Assaulted"];
                    DocumentSnapshot assaultedDoc = await assaultedRef.GetSnapshotAsync();
                    string assaultedName = assaultedDoc.GetValue<string>("email");

                    // Establecer los valores de las celdas con la información del informe
                    newRow.Cells["Aggressor"].Value = aggressorName;
                    newRow.Cells["Assaulted"].Value = assaultedName;
                    newRow.Cells["Severity"].Value = data["Severity"].ToString();
                    newRow.Cells["Reason"].Value = data["Reason"].ToString();
                    newRow.Cells["State"].Value = data["State"].ToString();
                }
                foreach (DocumentSnapshot document in snapshot2.Documents)
                {
                    Dictionary<string, object> data = document.ToDictionary();

                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow newRow = dataGridView1.Rows[rowIndex];
                    newRow.Cells["id"].Value = document.Id;
                    // Obtener el documento del agresor y recuperar su nombre
                    DocumentReference aggressorRef = (DocumentReference)data["Aggressor"];
                    DocumentSnapshot aggressorDoc = await aggressorRef.GetSnapshotAsync();
                    string aggressorName = aggressorDoc.GetValue<string>("email");

                    // Obtener el documento del agredido y recuperar su nombre
                    DocumentReference assaultedRef = (DocumentReference)data["Assaulted"];
                    DocumentSnapshot assaultedDoc = await assaultedRef.GetSnapshotAsync();
                    string assaultedName = assaultedDoc.GetValue<string>("email");

                    // Establecer los valores de las celdas con la información del informe
                    newRow.Cells["Aggressor"].Value = aggressorName;
                    newRow.Cells["Assaulted"].Value = assaultedName;
                    newRow.Cells["Severity"].Value = data["Severity"].ToString();
                    newRow.Cells["Reason"].Value = data["Reason"].ToString();
                    newRow.Cells["State"].Value = data["State"].ToString();
                }
                dataGridView1.Update();
            }
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                QuerySnapshot snapshot = await db.Collection("Reports").GetSnapshotAsync();
                foreach (DocumentSnapshot document in snapshot.Documents)
                {
                    Dictionary<string, object> data = document.ToDictionary();

                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow newRow = dataGridView1.Rows[rowIndex];

                    newRow.Cells["id"].Value = document.Id;

                    // Obtener el documento del agresor y recuperar su nombre
                    DocumentReference aggressorRef = (DocumentReference)data["Aggressor"];
                    DocumentSnapshot aggressorDoc = await aggressorRef.GetSnapshotAsync();
                    string aggressorName = aggressorDoc.GetValue<string>("email");

                    // Obtener el documento del agredido y recuperar su nombre
                    DocumentReference assaultedRef = (DocumentReference)data["Assaulted"];
                    DocumentSnapshot assaultedDoc = await assaultedRef.GetSnapshotAsync();
                    string assaultedName = assaultedDoc.GetValue<string>("email");

                    // Establecer los valores de las celdas con la información del informe
                    newRow.Cells["Aggressor"].Value = aggressorName;
                    newRow.Cells["Assaulted"].Value = assaultedName;
                    newRow.Cells["Severity"].Value = data["Severity"].ToString();
                    newRow.Cells["Reason"].Value = data["Reason"].ToString();
                    newRow.Cells["State"].Value = data["State"].ToString();
                }
            }
        }
    }
}
