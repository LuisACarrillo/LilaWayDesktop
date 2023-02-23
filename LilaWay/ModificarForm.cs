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
    }
}
