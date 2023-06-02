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
                    string status = data["status"].ToString();
                    newRow.Cells["status"].Value = status.Equals("approved");
                    newRow.Cells["status2"].Value = status.Equals("rejected");
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
                    string status = data["status"].ToString();
                    newRow.Cells["status"].Value = status.Equals("approved");
                    newRow.Cells["status2"].Value = status.Equals("rejected");
                }
            }
            // Desasociar el controlador de eventos para evitar duplicaciones
            dataGridView1.CellContentClick -= dataGridView1_CellContentClick_1;

            // Asociar el controlador de eventos al evento CellContentClick
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
        }

        private async void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "status")
            {
                try
                {
                    dataGridView1.EndEdit(); // Finaliza cualquier edición pendiente en el DataGridView

                    string userId = dataGridView1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                    DocumentReference docRef = db.Collection("Users").Document(userId);
                    DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
                    string status = snapshot.GetValue<string>("status");

                    if (status == "rejected")
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["status2"].Value = false;
                        Dictionary<string, object> data = new Dictionary<string, object>
                        {
                            { "status", "approved" }
                        };
                        DialogResult result = MessageBox.Show("¿Estás seguro que quiere hacer esta modificación?", "Confirmación de modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            await docRef.UpdateAsync(data);
                            MessageBox.Show("Registro modificado correctamente.");
                        }
                    }

                    if (status == "pending")
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["status2"].Value = false; // Desactiva la columna "status2" (rejected)

                        Dictionary<string, object> data = new Dictionary<string, object>
                        {
                            { "status", "approved" }
                        };

                        DialogResult result = MessageBox.Show("¿Estás seguro que quiere hacer esta modificación?", "Confirmación de modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            await docRef.UpdateAsync(data);
                            MessageBox.Show("Registro modificado correctamente.");
                        }

                        dataGridView1.Columns[e.ColumnIndex].ReadOnly = true; // Hace que la columna "status" sea de solo lectura
                    }
                    else if (status == "approved")
                    {
                        dataGridView1.Columns[e.ColumnIndex].ReadOnly = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "status2")
            {
                try
                {
                    dataGridView1.EndEdit(); // Finaliza cualquier edición pendiente en el DataGridView

                    string userId = dataGridView1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                    DocumentReference docRef = db.Collection("Users").Document(userId);
                    DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
                    string status = snapshot.GetValue<string>("status");

                    if (status == "approved")
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["status"].Value = false;
                        Dictionary<string, object> data = new Dictionary<string, object>
                        {
                            { "status", "rejected" }
                        };
                        DialogResult result = MessageBox.Show("¿Estás seguro que quiere hacer esta modificación?", "Confirmación de modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            await docRef.UpdateAsync(data);
                            MessageBox.Show("Registro modificado correctamente.");
                        }
                    }

                    if (status == "pending")
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["status"].Value = false; // Desactiva la columna "status" (approved)

                        Dictionary<string, object> data = new Dictionary<string, object>
                        {
                            { "status", "rejected" }
                        };

                        DialogResult result = MessageBox.Show("¿Estás seguro que quiere hacer esta modificación?", "Confirmación de modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            await docRef.UpdateAsync(data);
                            MessageBox.Show("Registro modificado correctamente.");
                        }

                    }
                    else if (status == "rejected")
                    {
                        dataGridView1.Columns[e.ColumnIndex].ReadOnly = false;
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

