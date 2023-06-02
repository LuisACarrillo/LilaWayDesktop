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
    public partial class ReportesForm : Form
    {
        FirestoreDb db;
        string idD;
        string idC;
        private int currentRowIndex;

        public ReportesForm()
        {
            InitializeComponent();

            string path = AppDomain.CurrentDomain.BaseDirectory + @"lilawaybase.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("lilaway-aca5b");

        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }


        private async void ReportesForm_Load(object sender, EventArgs e)
        {
            QuerySnapshot snapshot = await db.Collection("Reports").GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Dictionary<string, object> data = document.ToDictionary();
                int rowIndex = dataGridView1.Rows.Add();
                currentRowIndex = rowIndex;
                DataGridViewRow newRow = dataGridView1.Rows[rowIndex];

                

                newRow.Cells["id"].Value = document.Id;
                newRow.Cells["idClient"].Value = data["idClient"].ToString();
                newRow.Cells["idDriver"].Value = data["idDriver"].ToString();
                newRow.Cells["status"].Value = data["status"].ToString();
                newRow.Cells["type"].Value = data["type"].ToString();
                newRow.Cells["description"].Value = data["description"].ToString();
                newRow.Cells["victim"].Value = data["victim"].ToString();
                newRow.Cells["urgency"].Value = data["urgency"].ToString();
                newRow.Cells["Fecha"].Value = data["date"].ToString();
                DateTime date = DateTime.Parse(data["date"].ToString());
                idC = newRow.Cells["idClient"].Value.ToString();
                idD = newRow.Cells["idDriver"].Value.ToString();

                DocumentReference driverref = db.Collection("Users").Document(data["idDriver"].ToString());
                DocumentSnapshot snapshotdriver = await driverref.GetSnapshotAsync();

                DocumentReference clientref = db.Collection("Users").Document(data["idClient"].ToString());
                DocumentSnapshot snapshotclient = await clientref.GetSnapshotAsync();

                string driveremail = snapshotdriver.GetValue<string>("userName");
                string clientemail = snapshotclient.GetValue<string>("userName");

                newRow.Cells["idClient"].Value = clientemail;
                newRow.Cells["idDriver"].Value = driveremail;

                if (DateTime.Now - date >= TimeSpan.FromHours(24) && data["urgency"].ToString()=="urgent")
                {
                    QuerySnapshot snapshotUser = await db.Collection("Users").GetSnapshotAsync();
                    foreach (DocumentSnapshot documentUser in snapshotUser.Documents)
                    {
                        if (documentUser.Id.Length==20)
                        {
                            string typeUser = documentUser.GetValue<string>("userType");

                            if (typeUser == "Soporte")
                            {
                                int penalizations = documentUser.GetValue<int>("penalizations");
                                penalizations++;

                                // Actualizar el valor del campo "penalizations" en la base de datos
                                DocumentReference userRef = db.Collection("Users").Document(documentUser.Id);
                                await userRef.UpdateAsync("penalizations", penalizations);

                                
                            }

                        }
                    }

                    DialogResult result = MessageBox.Show("Ya pasaron más de 24 hrs para uno de los reportes urgentes, usted ha sido penalizado, por favor complete el reporte en la inmediatez", "Retardo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    string id = newRow.Cells["id"].Value.ToString();
                    string idClient = newRow.Cells["idClient"].Value.ToString(); 
                    string idDriver = newRow.Cells["idDriver"].Value.ToString();
                    string status = newRow.Cells["status"].Value.ToString();
                    string type = newRow.Cells["type"].Value.ToString();
                    string description = newRow.Cells["description"].Value.ToString();
                    string victim = newRow.Cells["victim"].Value.ToString();
                    string urgency = newRow.Cells["urgency"].Value.ToString();

                    if (result == DialogResult.OK)
                    {
                        ModReportesForm modificarForm = new ModReportesForm(id, idClient, idDriver, status, description, type, victim, urgency);
                        modificarForm.ShowDialog();
                        this.Hide();
                    }
                }

                else if (DateTime.Now - date >= TimeSpan.FromDays(7) && data["urgency"].ToString() == "minor")
                {
                    QuerySnapshot snapshotUser = await db.Collection("Users").GetSnapshotAsync();
                    foreach (DocumentSnapshot documentUser in snapshotUser.Documents)
                    {
                        if (documentUser.Id.Length == 20)
                        {
                            string typeUser = documentUser.GetValue<string>("userType");

                            if (typeUser == "Soporte")
                            {
                                int penalizations = documentUser.GetValue<int>("penalizations");
                                penalizations++;

                                // Actualizar el valor del campo "penalizations" en la base de datos
                                DocumentReference userRef = db.Collection("Users").Document(documentUser.Id);
                                await userRef.UpdateAsync("penalizations", penalizations);
                            }

                        }
                    }

                    DialogResult result = MessageBox.Show("Han pasado más de 7 días para uno de los reportes de menor urgencia", "Retardo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    string id = newRow.Cells["id"].Value.ToString();
                    string idClient = newRow.Cells["idClient"].Value.ToString();
                    string idDriver = newRow.Cells["idDriver"].Value.ToString();
                    string status = newRow.Cells["status"].Value.ToString();
                    string type = newRow.Cells["type"].Value.ToString();
                    string description = newRow.Cells["description"].Value.ToString();
                    string victim = newRow.Cells["victim"].Value.ToString();
                    string urgency = newRow.Cells["urgency"].Value.ToString();

                    if (result == DialogResult.OK)
                    {
                        ModReportesForm modificarForm = new ModReportesForm(id, idClient, idDriver, status, description, type, victim, urgency);
                        modificarForm.ShowDialog();
                        this.Hide();
                    }

                    
                }
                






                //DocumentReference driverref = db.Collection("Users").Document(data["idDriver"].ToString());
                //DocumentSnapshot snapshotdriver = await driverref.GetSnapshotAsync();
                //DocumentReference clientref = db.Collection("Users").Document(data["idClient"].ToString());

                

                //DocumentSnapshot snapshotclient = await clientref.GetSnapshotAsync();
                //string driveremail = snapshotdriver.GetValue<string>("userName");
                //string clientemail = snapshotclient.GetValue<string>("userName");

                //newRow.Cells["idClient"].Value = clientemail;
                //newRow.Cells["idDriver"].Value = driveremail;


            }

        }




        private async void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentRowIndex >= 0 && currentRowIndex < dataGridView1.Rows.Count)
            {
                
            

            // Obtener los datos de la fila seleccionada
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string idClient = row.Cells["idClient"].Value.ToString();
                string idDriver = row.Cells["idDriver"].Value.ToString();
                string status = row.Cells["status"].Value.ToString();
                string type = row.Cells["type"].Value.ToString();
                string description = row.Cells["description"].Value.ToString();
                string victim = row.Cells["victim"].Value.ToString();
                string urgency = row.Cells["urgency"].Value.ToString();
                this.Hide();

                ModReportesForm modificarForm = new ModReportesForm(id, idClient, idDriver, status, description, type, victim, urgency);

                modificarForm.ShowDialog();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModReportesForm modificarForm = new ModReportesForm(null, null, null, null, null, null, null, null);
            modificarForm.ShowDialog();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.ToLower();
            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();

            // Iterar a través de las filas originales y comparar cada celda con el valor buscado
            foreach (DataGridViewRow originalRow in dataGridView1.Rows)
            {
                bool rowMatch = false;
                foreach (DataGridViewCell cell in originalRow.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
                    {
                        rowMatch = true;
                        break;
                    }
                }

                if (rowMatch)
                {
                    DataGridViewRow filteredRow = (DataGridViewRow)originalRow.Clone();
                    foreach (DataGridViewCell cell in originalRow.Cells)
                    {
                        filteredRow.Cells[cell.ColumnIndex].Value = cell.Value;
                    }
                    filteredRows.Add(filteredRow);
                }
            }

            // Eliminar las filas actuales y agregar las filas filtradas
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.AddRange(filteredRows.ToArray());


        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dataGridView1.Rows.Clear();
                QuerySnapshot snapshot = await db.Collection("Reports").GetSnapshotAsync();
                foreach (DocumentSnapshot document in snapshot.Documents)
                {
                    Dictionary<string, object> data = document.ToDictionary();
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow newRow = dataGridView1.Rows[rowIndex];

                    newRow.Cells["id"].Value = document.Id;
                    newRow.Cells["idClient"].Value = idC;
                    newRow.Cells["idDriver"].Value = idD;
                    newRow.Cells["status"].Value = data["status"].ToString();
                    newRow.Cells["type"].Value = data["type"].ToString();
                    newRow.Cells["description"].Value = data["description"].ToString();
                    newRow.Cells["victim"].Value = data["victim"].ToString();
                    newRow.Cells["urgency"].Value = data["urgency"].ToString();
                }
            }
        }
    }
}
