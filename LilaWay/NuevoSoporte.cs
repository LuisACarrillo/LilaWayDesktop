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
    public partial class NuevoSoporte : Form
    {
        FirestoreDb db;
        public NuevoSoporte()
        {
            InitializeComponent();
            NuevoSoporte_Load(null, null);
        }

        private void NuevoSoporte_Load(object sender, EventArgs e)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"lilawaybase.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                db = FirestoreDb.Create("lilaway-aca5b");
            }
            catch
            {
                MessageBox.Show("Eror");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            CollectionReference coll = db.Collection("Users");
            Dictionary<string, register> data1 = new Dictionary<string, register>();
            if (string.IsNullOrEmpty(txtbUser.Text) || string.IsNullOrEmpty(txtbPassword.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                Dictionary<string, object> data = new Dictionary<string, object>
                    {
                       { "userName", txtbUser.Text },
                            { "password", txtbPassword.Text },
                            { "userType", "Soporte" },

                    };
                DialogResult result = MessageBox.Show("¿Estás seguro que quiere crear este registro?", "Confirmación de creacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si el usuario confirmó la eliminación, eliminar el registro de la base de datos y del DataGridView
                if (result == DialogResult.Yes)
                {

                    DocumentReference docRef = db.Collection("Users").Document();
                    await docRef.SetAsync(data);


                    MessageBox.Show("Registro creado correctamente.");
                }
            }
        }
    }
}
