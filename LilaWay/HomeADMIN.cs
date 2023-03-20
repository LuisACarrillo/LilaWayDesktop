using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LilaWay
{
    public partial class HomeADMIN : Form
    {
        public HomeADMIN()
        {
            InitializeComponent();
        }

        private void HomeADMIN_Load(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ReportesForm reporte = new ReportesForm();
            reporte.ShowDialog();
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
            //RegistrosForm registros = new RegistrosForm();
            //registros.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoSoporte agregarSoporte = new NuevoSoporte();
            agregarSoporte.ShowDialog();
        }
    }
}
