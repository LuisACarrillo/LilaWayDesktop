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
    public partial class Form1 : Form
    {

        FirestoreDb database;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"lilawaybase.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                database = FirestoreDb.Create("lilaway-aca5b");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar la base de datos: " + ex.Message);
            }

        }

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtbUser.Text) )
            {
                MessageBox.Show("Por favor ingrese el usuario");
            }
            else if( string.IsNullOrEmpty(txtbPassword.Text))
            {
                MessageBox.Show("Por favor ingrese la contraseña");
            }
            else
            {
                Query docref = database.Collection("Users");
                QuerySnapshot snap = await docref.GetSnapshotAsync();
                foreach(DocumentSnapshot documentSnapshot in snap.Documents)
                {
                    
                    register data = documentSnapshot.ConvertTo<register>();
                    if (data.userType == "Soporte")
                    {

                        string usernameres = data.userName;
                        string passwordres = data.password;
                        
                        
                        if (txtbUser.Text == usernameres && txtbPassword.Text == passwordres)
                        {
                            int penalizations = documentSnapshot.GetValue<int>("penalizations");
                            if (penalizations < 5)
                            {
                                DocumentReference updateReference = database.Collection("UpdateDate").Document("D8uUuq7o5LEt7Qbd11Jh");
                                DocumentSnapshot updateSnapshot = await updateReference.GetSnapshotAsync();
                                Timestamp timestamp = updateSnapshot.GetValue<Timestamp>("date");

                                // Convierte el timestamp a DateTime
                                DateTime timestampDate = timestamp.ToDateTime().ToUniversalTime();

                                // Obtiene la fecha y hora UTC actual
                                DateTime currentDate = DateTime.UtcNow;

                                // Verifica si han pasado 6 meses
                                TimeSpan elapsedTime = currentDate - timestampDate;
                                if (elapsedTime.TotalDays >= 6 * 30) // 6 meses * 30 días por mes (aproximadamente)
                                {
                                    MessageBox.Show("Han pasado 6 meses desde la última actualización de precios, por favor actualízalo.");

                                    // Actualiza el campo "date" en la colección "UpdateDate" con la fecha actual
                                    Dictionary<string, object> dataDate = new Dictionary<string, object>
                                    {
                                        { "date", Timestamp.FromDateTime(DateTime.UtcNow) }
                                    };
                                    await updateReference.SetAsync(dataDate, SetOptions.MergeFields("date"));

                                    MessageBox.Show("El campo 'date' se ha actualizado correctamente.");
                                }

                                MessageBox.Show("Bienvenido " + txtbUser.Text + "\nRecuerde por favor que actualmente cuenta con " + penalizations + " penalizaciones");
                                Home hm = new Home();
                                this.Hide();
                                hm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("El usuario llegó al límite de penalizaciones y ha sido bloqueado");

                                return; 
                            }
                            
                        }              
                    }
                     if(data.userType=="admin")
                    {
                        string usernameres = data.userName;
                        string passwordres = data.password;
                        
                        if ((txtbUser.Text == usernameres && txtbPassword.Text == passwordres))
                            {
                            MessageBox.Show("Administrador " + txtbUser.Text);
                            HomeADMIN hm = new HomeADMIN();
                            this.Hide();
                            hm.ShowDialog();
                        }          
                    }             
                }
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

            }
        } 
 }
