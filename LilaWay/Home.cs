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
    public partial class Home : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "FfzdXJdmfk7iNZWFej8oQIMsoXmvPo2VSEWHvCdT",
            BasePath = "https://lilawaybd-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
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

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ReportesForm reporte = new ReportesForm();
            reporte.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarForm agregar = new AgregarForm();
            agregar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarForm modificar = new ModificarForm();
            modificar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarForm eliminar = new EliminarForm();
            eliminar.ShowDialog();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            RegistrosForm registros = new RegistrosForm();
            registros.ShowDialog();
        }
    }
}
