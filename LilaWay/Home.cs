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
    public partial class Home : Form
    {


        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }


        private void btnReportes_Click(object sender, EventArgs e)
        {
            ReportesForm reportesForm = new ReportesForm();
            reportesForm.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoSoporte agregar = new NuevoSoporte();
            agregar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conductora modificar = new Conductora();
            modificar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            RegistrosForm registros = new RegistrosForm();
            registros.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
