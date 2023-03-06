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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                row.Cells["Modified"].Value = true;
            }
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
                newRow.Cells["Aggressor"].Value = data["Aggressor"].ToString();
                newRow.Cells["Assaulted"].Value = data["Assaulted"].ToString();
                newRow.Cells["Severity"].Value = data["Severity"].ToString();
                newRow.Cells["Reason"].Value = data["Reason"].ToString();
            }
        }


        

        private async void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Obtener la fila que se ha editado
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string id = row.Cells["id"].Value?.ToString();
                // Verificar si es una nueva fila
                if (string.IsNullOrEmpty(id))
                {
                    // Crear una nueva entrada en la base de datos con los valores de la fila
                    Dictionary<string, object> data = new Dictionary<string, object>
                    {
                        { "Aggressor", row.Cells["Aggressor"]?.Value?.ToString() },
                            { "Assaulted", row.Cells["Assaulted"]?.Value?.ToString() },
                            { "Severity", row.Cells["Severity"]?.Value?.ToString() },
                            { "Reason", row.Cells["Reason"]?.Value?.ToString() },

                    };

                    DocumentReference docRef = db.Collection("Reports").Document();
                    await docRef.SetAsync(data);

                    // Actualizar el valor de la columna "id" con el ID generado por Firestore
                    row.Cells["id"].Value = docRef.Id;

                    MessageBox.Show("Nuevo reporte agregado correctamente.");
                }
                else
                {
                    // Obtener el ID de la fila editada


                    // Actualizar la entrada en la base de datos con los valores de la fila
                    DocumentReference docRef = db.Collection("Reports").Document(id);
                    Dictionary<string, object> data = new Dictionary<string, object>
                        {
                        { "Aggressor", row.Cells["Aggressor"]?.Value?.ToString() },
                            { "Assaulted", row.Cells["Assaulted"]?.Value?.ToString() },
                            { "Severity", row.Cells["Severity"]?.Value?.ToString() },
                            { "Reason", row.Cells["Reason"]?.Value?.ToString() },
                        };

                    await docRef.UpdateAsync(data);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                try
                {
                    // Obtener el ID del registro que se va a eliminar
                    string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();

                    // Mostrar mensaje de confirmación
                    DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este registro?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Si el usuario confirmó la eliminación, eliminar el registro de la base de datos y del DataGridView
                    if (result == DialogResult.Yes)
                    {
                        DocumentReference docRef = db.Collection("Reports").Document(id);
                        await docRef.DeleteAsync();

                        dataGridView1.Rows.RemoveAt(e.RowIndex);

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
}
