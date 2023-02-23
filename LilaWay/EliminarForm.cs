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
    public partial class EliminarForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "FfzdXJdmfk7iNZWFej8oQIMsoXmvPo2VSEWHvCdT",
            BasePath = "https://lilawaybd-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public EliminarForm()
        {
            InitializeComponent();
        }

        private void EliminarForm_Load(object sender, EventArgs e)
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

        private async void btnDelDriver_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteAsync("conductora/" + txtbIDdriver.Text + "/");
            RegisterDriver res = response.ResultAs<RegisterDriver>();
        }

        private async void btnDelUser_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteAsync("usuarios/" + txtbIDuser.Text + "/");
            RegisterDriver res = response.ResultAs<RegisterDriver>();
        }
    }
}
