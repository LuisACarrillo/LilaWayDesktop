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
            ModificarForm_Load(null, null); // Llamar a ModificarForm_Load en el constructor
        }


        public async void ModificarForm_Load(object sender, EventArgs e)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"lilawaybase.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                db = FirestoreDb.Create("lilawaybase");

                try
                {
                    if (db == null)
                    {
                        throw new Exception("La variable database es nula");
                    }

                    dataGridView1.Rows.Clear(); // Limpiar las filas existentes antes de agregar los nuevos datos

                    Query docref = db.Collection("Users");
                    QuerySnapshot snap = await docref.GetSnapshotAsync();
                    foreach (DocumentSnapshot documentSnapshot in snap.Documents)
                    {
                        register data = documentSnapshot.ConvertTo<register>();
                        if (data.userType == "Conductora")
                        {
                            dataGridView1.Rows.Add(data.id, data.userName, data.password, data.name, data.lastName, data.curp, data.carModel, data.email, data.places, data.phone);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar la base de datos: " + ex.Message);
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    // Verificar si la fila ha sido modificada
                    if (row.Cells["id"].Value != null && row.Cells["id"].Value.ToString() != "" && row.Cells["Modified"].Value.ToString() == "true")
                    {
                        string id = row.Cells["id"].Value.ToString();

                        // Obtener la entrada correspondiente en la base de datos
                        DocumentReference docRef = db.Collection("Users").Document(id);
                        DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                        if (snapshot.Exists)
                        {
                            // Actualizar la entrada con los nuevos valores de la fila
                            Dictionary<string, object> data = new Dictionary<string, object>
                    {
                        { "userName", row.Cells["userName"].Value.ToString() },
                        { "password", row.Cells["password"].Value.ToString() },
                        { "name", row.Cells["name"].Value.ToString() },
                        { "lastName", row.Cells["lastName"].Value.ToString() },
                        { "curp", row.Cells["curp"].Value.ToString() },
                        { "carModel", row.Cells["carModel"].Value.ToString() },
                        { "email", row.Cells["email"].Value.ToString() },
                        { "places", row.Cells["places"].Value.ToString() },
                        { "phone", row.Cells["phone"].Value.ToString() },
                        { "userType", "Conductora" },
                        { "id", id },
                    };

                            await docRef.SetAsync(data);

                            // Marcar la fila como no modificada
                            row.Cells["Modified"].Value = "false";
                        }
                    }
                }

                MessageBox.Show("Cambios guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message);
            }


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModificarForm_Load_1(object sender, EventArgs e)
        {

        }

        private async void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (db == null)
                {
                    throw new Exception("La variable database es nula");
                }

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString(); // Obtener el ID del documento a actualizar
                string field = dataGridView1.Columns[e.ColumnIndex].Name; // Obtener el nombre del campo modificado
                string value = row.Cells[e.ColumnIndex].Value.ToString(); // Obtener el valor modificado

                // Actualizar el campo correspondiente en la base de datos
                DocumentReference docRef = db.Collection("Users").Document(id);
                Dictionary<string, object> updates = new Dictionary<string, object>
        {
            { field, value }
        };
                await docRef.UpdateAsync(updates);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
