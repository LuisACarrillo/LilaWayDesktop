using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

using LilaWay;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace LilaWay
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "FfzdXJdmfk7iNZWFej8oQIMsoXmvPo2VSEWHvCdT",
            BasePath = "https://lilawaybd-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }catch
            {
                MessageBox.Show("Succesful Connnection");
            }
        }

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtbUser.Text) || string.IsNullOrEmpty(txtbPassword.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {

                FirebaseResponse response = client.Get("usuarios/");
                Dictionary<string, register> result = response.ResultAs<Dictionary<string, register>>();
                foreach(var get in result)
                {
                    string usernameres = get.Value.usuario;
                    string passwordres = get.Value.contrasena;

                    if (txtbUser.Text == usernameres && txtbPassword.Text==passwordres)
                    {
                        MessageBox.Show("Bienvenido " + txtbUser.Text);
                        Home hm  = new Home();
                        this.Hide();
                        hm.ShowDialog();
                    }

                }
            }
        } 
    }
}