using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using LilaWay;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LilaWay
{
    public partial class EliminarForm : Form
    {


        public EliminarForm()
        {
            InitializeComponent();
        }

        private void EliminarForm_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Succesful Connnection");
            }
        }

        private async void btnDelDriver_Click(object sender, EventArgs e)
        {

        }

        private async void btnDelUser_Click(object sender, EventArgs e)
        {

        }
    }
}
