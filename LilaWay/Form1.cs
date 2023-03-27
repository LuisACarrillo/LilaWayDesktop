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
                database = FirestoreDb.Create("lilawaybase");

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
                                MessageBox.Show("Bienvenido " + txtbUser.Text);
                                Home hm = new Home();
                                this.Hide();
                                hm.ShowDialog();
                            
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
