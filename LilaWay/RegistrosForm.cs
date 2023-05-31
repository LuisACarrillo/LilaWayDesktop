using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LilaWay
{
    public partial class RegistrosForm : Form
    {
        FirestoreDb db;

        public RegistrosForm()
        {
            InitializeComponent();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"lilawaybase.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("lilaway-aca5b");
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void RegistrosForm_Load(object sender, EventArgs e)
        {


            QuerySnapshot snapshot = await db.Collection("Users").WhereEqualTo("typeUser", "Driver").GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Dictionary<string, object> data = document.ToDictionary();

                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow newRow = dataGridView1.Rows[rowIndex];

                newRow.Cells["dataGridViewTextBoxColumn1"].Value = document.Id;
                newRow.Cells["userName"].Value = data["userName"].ToString();
                newRow.Cells["name"].Value = data["name"].ToString();
                newRow.Cells["lastName"].Value = data["lastName"].ToString();
                newRow.Cells["dataGridViewTextBoxColumn2"].Value = data["curp"].ToString();
                newRow.Cells["carModel"].Value = data["carModel"].ToString();
                newRow.Cells["dataGridViewTextBoxColumn3"].Value = data["email"].ToString();
                newRow.Cells["places"].Value = data["places"].ToString();
                newRow.Cells["phone"].Value = data["phone"].ToString();
                newRow.Cells["typeService"].Value = data["typeService"].ToString();
                newRow.Cells["typeUser"].Value = data["typeUser"].ToString();
                if (data.ContainsKey("status"))
                {
                    bool status = data["status"].ToString().Equals("approved");
                    newRow.Cells["status"].Value = status;
                }
            }

            QuerySnapshot snapshot2 = await db.Collection("Users").WhereEqualTo("typeUser", "Client").GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshot2.Documents)
            {
                Dictionary<string, object> data = document.ToDictionary();

                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow newRow = dataGridView1.Rows[rowIndex];

                newRow.Cells["dataGridViewTextBoxColumn1"].Value = document.Id;
                newRow.Cells["userName"].Value = data["userName"].ToString();
                newRow.Cells["name"].Value = data["name"].ToString();
                newRow.Cells["lastName"].Value = data["lastName"].ToString();
                newRow.Cells["dataGridViewTextBoxColumn2"].Value = data["curp"].ToString();
                newRow.Cells["dataGridViewTextBoxColumn3"].Value = data["email"].ToString();
                newRow.Cells["phone"].Value = data["phone"].ToString();
                newRow.Cells["typeUser"].Value = data["typeUser"].ToString();
                if (data.ContainsKey("status"))
                {
                    bool status = data["status"].ToString().Equals("approved");
                    newRow.Cells["status"].Value = status;
                }
            }
        }

        private async void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "status")
            {
                try
                {
                    // Obtiene el ID del usuario correspondiente a la fila donde se hizo clic
                    string userId = dataGridView1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();

                    // Obtiene la referencia al documento correspondiente al usuario
                    DocumentReference docRef = db.Collection("Users").Document(userId);

                    // Obtiene el documento desde la base de datos
                    DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                    // Obtiene el valor actual de la propiedad "status"
                    string status = snapshot.GetValue<string>("status");


                    // Verifica el valor actual de "status" para actualizarlo
                    if (status == "pending")
                    {
                        Dictionary<string, object> data = new Dictionary<string, object>
                {
                    { "status", "approved" },
                };
                        DialogResult result = MessageBox.Show("¿Estás seguro que quiere hacer estas modificaciones?", "Confirmación de modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            await docRef.UpdateAsync(data);
                            MessageBox.Show("Registro modificado correctamente.");
                        }
                        dataGridView1.Columns[e.ColumnIndex].ReadOnly = true;   
                    }
                    else if (status == "approved")
                    {
                        Dictionary<string, object> data = new Dictionary<string, object>
                {
                    { "status", "pending" },
                };
                        DialogResult result = MessageBox.Show("¿Estás seguro que quiere hacer estas modificaciones?", "Confirmación de modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            await docRef.UpdateAsync(data);
                            MessageBox.Show("Registro modificado correctamente.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



    }
}
