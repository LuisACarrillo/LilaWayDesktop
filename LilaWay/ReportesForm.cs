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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
