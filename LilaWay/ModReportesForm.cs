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
    public partial class ModReportesForm : Form
    {
        FirestoreDb db;

        public ModReportesForm(string id, string aggressor, string assaulted, string severity, string reason)
        {
            InitializeComponent();
            txtbID.Text = id;
            txtbAgressor.Text = aggressor;
            txtbAssaulted.Text = assaulted;
            txtbReason.Text = reason;
            cmbSeverity.Text = severity;
        }


        private void ModReportesForm_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"lilawaybase.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("lilawaybase");
        }


    }
}
