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
        FirestoreDb database;
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
                database = FirestoreDb.Create("lilawaybase");
            }
            catch
            {
                MessageBox.Show("Eror");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectionReference coll = database.Collection("Users");
            Dictionary<string, register> data1 = new Dictionary<string, register>();
            if (string.IsNullOrEmpty(txtbUser.Text) || string.IsNullOrEmpty(txtbPassword.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                var register = new register
                {
                    userName = txtbUser.Text,
                    password = txtbPassword.Text,
                    userType = "Soporte"
                };
                coll.AddAsync(register);
            }
        }
    }
}
