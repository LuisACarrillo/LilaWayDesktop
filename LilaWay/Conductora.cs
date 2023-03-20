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


using LilaWay;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace LilaWay
{
    public partial class Conductora : Form
    {
        FirestoreDb db;
        public Conductora()
        {
            InitializeComponent();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"lilawaybase.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("lilawaybase");
            ModificarForm_Load(null, null); // Llamar a ModificarForm_Load en el constructor
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                row.Cells["Modified"].Value = true;
            }
        }

        public async void ModificarForm_Load(object sender, EventArgs e)
        {
            QuerySnapshot snapshot = await db.Collection("Users").WhereEqualTo("userType", "Conductora").GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Dictionary<string, object> data = document.ToDictionary();

                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow newRow = dataGridView1.Rows[rowIndex];

                newRow.Cells["id"].Value = document.Id;
                newRow.Cells["userName"].Value = data["userName"].ToString();
                newRow.Cells["password"].Value = data["password"].ToString();
                newRow.Cells["name"].Value = data["name"].ToString();
                newRow.Cells["lastName"].Value = data["lastName"].ToString();
                newRow.Cells["curp"].Value = data["curp"].ToString();
                newRow.Cells["carModel"].Value = data["carModel"].ToString();
                newRow.Cells["email"].Value = data["email"].ToString();
                newRow.Cells["places"].Value = data["places"].ToString();
                newRow.Cells["phone"].Value = data["phone"].ToString();
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {


        }




        private async void btnModDriver_Click(object sender, EventArgs e)
        {

        }
        private async void btnModifyDriver_Click(object sender, EventArgs e)
        {

        }

        private async void btnModUser_Click(object sender, EventArgs e)
        {


        }

        private async void btnRetUser_Click(object sender, EventArgs e)
        {

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
                        DocumentReference docRef = db.Collection("Users").Document(id);
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

        private void ModificarForm_Load_1(object sender, EventArgs e)
        {

        }

        private async void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
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
                        { "userName", row.Cells["userName"]?.Value?.ToString() },
                            { "password", row.Cells["password"]?.Value?.ToString() },
                            { "name", row.Cells["name"]?.Value?.ToString() },
                            { "lastName", row.Cells["lastName"]?.Value?.ToString() },
                            { "curp", row.Cells["curp"]?.Value?.ToString() },
                            { "carModel", row.Cells["carModel"]?.Value?.ToString() },
                            { "email", row.Cells["email"]?.Value?.ToString() },
                            { "places", row.Cells["places"]?.Value?.ToString() },
                            { "phone", row.Cells["phone"]?.Value?.ToString() },
                            { "userType", "Conductora" },

                    };

                    DocumentReference docRef = db.Collection("Users").Document();
                    await docRef.SetAsync(data);

                    // Actualizar el valor de la columna "id" con el ID generado por Firestore
                    row.Cells["id"].Value = docRef.Id;

                    MessageBox.Show("Nueva conductora agregada correctamente.");
                }
                else
                {
                    // Obtener el ID de la fila editada


                    // Actualizar la entrada en la base de datos con los valores de la fila
                    DocumentReference docRef = db.Collection("Users").Document(id);
                    Dictionary<string, object> data = new Dictionary<string, object>
                        {
                        { "userName", row.Cells["userName"]?.Value?.ToString() },
                            { "password", row.Cells["password"]?.Value?.ToString() },
                            { "name", row.Cells["name"]?.Value?.ToString() },
                            { "lastName", row.Cells["lastName"]?.Value?.ToString() },
                            { "curp", row.Cells["curp"]?.Value?.ToString() },
                            { "carModel", row.Cells["carModel"]?.Value?.ToString() },
                            { "email", row.Cells["email"]?.Value?.ToString() },
                            { "places", row.Cells["places"]?.Value?.ToString() },
                            { "phone", row.Cells["phone"]?.Value?.ToString() },
                        };

                    await docRef.UpdateAsync(data);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string userName = row.Cells["userName"].Value.ToString();
                string password = row.Cells["password"].Value.ToString();
                string name = row.Cells["name"].Value.ToString();
                string lastName = row.Cells["lastName"].Value.ToString();
                string curp = row.Cells["curp"].Value.ToString();
                string carModel = row.Cells["carModel"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();
                string places = row.Cells["places"].Value.ToString();
                string phone = row.Cells["phone"].Value.ToString();

                this.Hide();

                ModConductoraForm modificarForm = new ModConductoraForm(id, userName, password, name, lastName, curp, carModel, email, places, phone);

                modificarForm.ShowDialog();


            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModConductoraForm modificarForm = new ModConductoraForm(null, null, null, null, null, null, null, null, null, null);
            modificarForm.ShowDialog();

        }



        private async void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string emailBuscado = textBox1.Text;

            QuerySnapshot snapshot = await db.Collection("Users").WhereEqualTo("userType", "Conductora").WhereEqualTo("email", emailBuscado).GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Dictionary<string, object> data = document.ToDictionary();

                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow newRow = dataGridView1.Rows[rowIndex];

                newRow.Cells["id"].Value = document.Id;
                newRow.Cells["userName"].Value = data["userName"].ToString();
                newRow.Cells["password"].Value = data["password"].ToString();
                newRow.Cells["name"].Value = data["name"].ToString();
                newRow.Cells["lastName"].Value = data["lastName"].ToString();
                newRow.Cells["curp"].Value = data["curp"].ToString();
                newRow.Cells["carModel"].Value = data["carModel"].ToString();
                newRow.Cells["email"].Value = data["email"].ToString();
                newRow.Cells["places"].Value = data["places"].ToString();
                newRow.Cells["phone"].Value = data["phone"].ToString();
            }
            dataGridView1.Update();

        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                QuerySnapshot snapshot = await db.Collection("Users").WhereEqualTo("userType", "Conductora").GetSnapshotAsync();
                foreach (DocumentSnapshot document in snapshot.Documents)
                {
                    Dictionary<string, object> data = document.ToDictionary();

                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow newRow = dataGridView1.Rows[rowIndex];

                    newRow.Cells["id"].Value = document.Id;
                    newRow.Cells["userName"].Value = data["userName"].ToString();
                    newRow.Cells["password"].Value = data["password"].ToString();
                    newRow.Cells["name"].Value = data["name"].ToString();
                    newRow.Cells["lastName"].Value = data["lastName"].ToString();
                    newRow.Cells["curp"].Value = data["curp"].ToString();
                    newRow.Cells["carModel"].Value = data["carModel"].ToString();
                    newRow.Cells["email"].Value = data["email"].ToString();
                    newRow.Cells["places"].Value = data["places"].ToString();
                    newRow.Cells["phone"].Value = data["phone"].ToString();
                }
            }
        }
    }
}
