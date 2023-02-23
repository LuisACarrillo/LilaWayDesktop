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
    public partial class AgregarForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "FfzdXJdmfk7iNZWFej8oQIMsoXmvPo2VSEWHvCdT",
            BasePath = "https://lilawaybd-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public AgregarForm()
        {
            InitializeComponent();
        }

        private void AgregarForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("Succesful Connnection");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            FirebaseResponse responsea = client.Get("usuarios/");
            Dictionary<string, register> resultb = responsea.ResultAs<Dictionary<string, register>>();
            foreach (var get in resultb)
            {
                id++;
            }
            if (string.IsNullOrEmpty(txtbUser.Text) || string.IsNullOrEmpty(txtbPassword.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                var register = new register
                {
                    usuario = txtbUser.Text,
                    contrasena = txtbPassword.Text,
                };
                FirebaseResponse response = client.Set("usuarios/" + id, register);
                register res =response.ResultAs<register>();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbCURP.Text) || string.IsNullOrEmpty(txtbLastName.Text) || string.IsNullOrEmpty(txtbCURP.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                int id = 0;
                FirebaseResponse responsea = client.Get("conductora/");
                Dictionary<string, register> resultb = responsea.ResultAs<Dictionary<string, register>>();
                foreach (var get in resultb)
                {
                    id++;
                }
                var register = new RegisterDriver
                {
                    apellido = txtbLastName.Text,
                    nombre = txtbName.Text,
                    curp = txtbCURP.Text
                };
                FirebaseResponse response = client.Set("conductora/" + id  , register);
                register res = response.ResultAs<register>();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbOffendercurp.Text) || string.IsNullOrEmpty(txtbVictimCurp.Text) || string.IsNullOrEmpty(txtbReason.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {

                int id = 0;
                FirebaseResponse responsea = client.Get("Reporte/");
                Dictionary<string, register> resultb = responsea.ResultAs<Dictionary<string, register>>();
                foreach (var get in resultb)
                {
                    id++;
                }

                    var register = new RegisterReport
                {
                    agresor = txtbOffendercurp.Text,
                    gravedad = cmbbSeverity.Text,
                    razon = txtbReason.Text,
                    tipodeagresor = cmbbOffType.Text,
                    victima = txtbVictimCurp.Text
                };
                FirebaseResponse response = client.Set("Reporte/" + id, register);
                register res = response.ResultAs<register>();
            }
        }
    }

}
