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
    public partial class ModConductoraForm : Form
    {
        FirestoreDb db;

        public ModConductoraForm()
        {
            InitializeComponent();
        }

        private void ModConductoraForm_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"lilawaybase.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("lilawaybase");
        }

        private async void btnMod_Click(object sender, EventArgs e)
        {
            string id = txtbID.Text;
            
            if(txtbID.Text!="")
            {
                DocumentReference docRef = db.Collection("Users").Document(txtbID.Text);
                Dictionary<string, object> data = new Dictionary<string, object>
            {

                            { "userName", txtbUserName.Text },
                            { "password", txtbPassword.Text },
                             {"name", txtbName.Text },
                            { "lastName", txtbLastName.Text },
                            { "curp", txtbCurp.Text },
                            { "carModel", txtbCarModel.Text },
                            { "email", txtbEmail.Text },
                            { "places", txtbPlaces.Text },
                            { "phone", txtbPhone.Text },
                            { "userType", "Conductora" },
            };
                await docRef.UpdateAsync(data);
            }
            else
            {
                Dictionary<string, object> data = new Dictionary<string, object>
                    {
                       { "userName", txtbUserName.Text },
                            { "password", txtbPassword.Text },
                             {"name", txtbName.Text },
                            { "lastName", txtbLastName.Text },
                            { "curp", txtbCurp.Text },
                            { "carModel", txtbCarModel.Text },
                            { "email", txtbEmail.Text },
                            { "places", txtbPlaces.Text },
                            { "phone", txtbPhone.Text },
                            { "userType", "Conductora" },

                    };
                DocumentReference docRef = db.Collection("Users").Document();
                await docRef.SetAsync(data);
            }
            

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
                    DocumentReference docRef = db.Collection("Users").Document(txtbID.Text);
                    await docRef.DeleteAsync();


                    MessageBox.Show("Registro eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
