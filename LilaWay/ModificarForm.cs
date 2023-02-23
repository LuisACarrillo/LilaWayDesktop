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
using FireSharp.Extensions;
using FireSharp.EventStreaming;
using FireSharp.Exceptions;

using LilaWay;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace LilaWay
{
    public partial class ModificarForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "FfzdXJdmfk7iNZWFej8oQIMsoXmvPo2VSEWHvCdT",
            BasePath = "https://lilawaybd-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public ModificarForm()
        {
            InitializeComponent();
        }

        private void ModificarForm_Load(object sender, EventArgs e)
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

        private async void btnModDriver_Click(object sender, EventArgs e)
        {
            var register = new RegisterDriver
            {
                apellido = txtbApellido.Text,
                nombre = txtbNombre.Text,
                curp = txtbCURP.Text
            };
            FirebaseResponse response = await client.UpdateAsync("conductora/" + txtbIDdriver.Text + "/", register);
            RegisterDriver res = response.ResultAs<RegisterDriver>();
        }

        private async void btnModifyDriver_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetAsync("conductora/"+txtbIDdriver.Text+"/");
            RegisterDriver res = response.ResultAs<RegisterDriver>();
            txtbNombre.Text = res.nombre;
            txtbApellido.Text = res.apellido;
            txtbCURP.Text = res.curp;
        }

        private async void btnModUser_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetAsync("usuarios/" + txtbIDuser.Text + "/");
            register res = response.ResultAs<register>();
            txtbUser.Text = res.usuario;
            txtbPassword.Text = res.contrasena;
        }

        private async void btnRetUser_Click(object sender, EventArgs e)
        {
            var register = new register
            {
                usuario = txtbUser.Text,
                contrasena = txtbPassword.Text,
            };
            FirebaseResponse response = await client.UpdateAsync("usuarios/" + txtbIDuser.Text + "/", register);
            RegisterDriver res = response.ResultAs<RegisterDriver>();
        }
    }
}
