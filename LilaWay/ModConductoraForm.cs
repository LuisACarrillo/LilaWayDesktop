using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace LilaWay
{
    public partial class ModConductoraForm : Form
    {
        FirestoreDb db;

        public ModConductoraForm(string id, string userName, string password, string name, string lastName, string curp, string carModel, string email, string places, string phone)
        {
            InitializeComponent();
            txtbID.Text = id;
            txtbUserName.Text = userName;
            txtbPassword.Text = password;
            txtbName.Text = name;
            txtbLastName.Text = lastName;
            txtbCurp.Text = curp;
            txtbCarModel.Text = carModel;
            txtbEmail.Text = email;
            txtbPlaces.Text = places;
            txtbPhone.Text = phone;

            if (txtbID.Text != "")
            {

                btnMod.Text = "Modificar";

            }
            else
            {
                btnDel.Enabled = true;
                btnDel.Visible = false;
            }
        }

        private void ModConductoraForm_Load(object sender, EventArgs e)
        {


            string path = AppDomain.CurrentDomain.BaseDirectory + @"lilawaybase.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("lilaway-aca5b");
        }

        private async void btnMod_Click(object sender, EventArgs e)
        {
            string id = txtbID.Text;
            if (Regex.IsMatch(txtbUserName.Text, @"[^a-zA-Z0-9]"))
            {
                MessageBox.Show("El nombre de usuario no puede contener caracteres especiales.");
                return;
            }

            if (txtbPassword.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                return;
            }


            if (!Regex.IsMatch(txtbName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El nombre sólo puede contener letras y espacios.");
                return;
            }


            if (!Regex.IsMatch(txtbLastName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El apellido sólo puede contener letras y espacios.");
                return;
            }


            if (txtbCurp.Text.Length != 18 ||
            txtbCurp.Text.Substring(0, 2) != txtbLastName.Text.Substring(0, 2).ToUpper() ||
            txtbCurp.Text[2] != txtbLastName.Text.Substring(txtbLastName.Text.IndexOf(" ") + 1, 1)[0] ||
            txtbCurp.Text[3] != txtbName.Text[0])
            {
                MessageBox.Show("El formato del CURP es incorrecto.");
                return;
            }

            if (!Regex.IsMatch(txtbCurp.Text, "^.{10}M.*$"))
            {
                MessageBox.Show("Ese CURP es incorrecto o pertenece a un hombre.");
                return;
            }

            string curp = txtbCurp.Text.ToUpper();


            if (!Regex.IsMatch(curp.Substring(4, 2), @"^(0[0-5]|[2-9]\d)$"))
            {
                MessageBox.Show("La persona contratada no puede ser menor de edad");
                return;
            }



            if (!txtbEmail.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo válido");
                return;
            }

            if (!Regex.IsMatch(txtbPhone.Text, @"^\d{10}$"))
            {
                MessageBox.Show("El número de teléfono debe tener 10 dígitos.");
                return;
            }


            if (!Regex.IsMatch(txtbPhone.Text, @"^\(?\d{3}\)?[\s-]?\d{3}[\s-]?\d{4}$"))
            {
                MessageBox.Show("El número de teléfono no es válido.");
                return;
            }

            CollectionReference usersCollection = db.Collection("Users");






            if (txtbID.Text != "")
            {



                DocumentReference docRef = db.Collection("Users").Document(id);
                Dictionary<string, object> data = new Dictionary<string, object>
            {

                            { "userName", txtbUserName.Text },
                            { "password", txtbPassword.Text },
                             {"name", txtbName.Text },
                            { "lastName", txtbLastName.Text },
                            { "curp", txtbCurp.Text },
                            { "carModel", txtbCarModel.Text },
                            { "email", txtbEmail.Text },
                            { "places", txtbPlaces.Text },
                            { "phone", txtbPhone.Text },
                            { "userType", "Conductora" },
            };

                DialogResult result = MessageBox.Show("¿Estás seguro que quiere hacer estas modificaciones?", "Confirmación de modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    await docRef.UpdateAsync(data);


                    MessageBox.Show("Registro modificado correctamente.");
                }
            }
            else
            {

                var queryUserName = usersCollection.WhereEqualTo("userName", txtbUserName.Text);
                var userNameSnapshot = await queryUserName.GetSnapshotAsync();
                if (userNameSnapshot.Documents.Count > 0)
                {
                    MessageBox.Show("El nombre de usuario ya existe en la base de datos.");
                    return;
                }

                var queryCurp = usersCollection.WhereEqualTo("curp", txtbCurp.Text);
                var curpSnapshot = await queryCurp.GetSnapshotAsync();
                if (curpSnapshot.Documents.Count > 0)
                {
                    MessageBox.Show("El CURP ya existe en la base de datos.");
                    return;
                }

                var queryPhone = usersCollection.WhereEqualTo("phone", txtbPhone.Text);
                var phoneSnapshot = await queryPhone.GetSnapshotAsync();
                if (phoneSnapshot.Documents.Count > 0)
                {
                    MessageBox.Show("El número de teléfono ya existe en la base de datos.");
                    return;
                }

                Dictionary<string, object> data = new Dictionary<string, object>
                    {
                       { "userName", txtbUserName.Text },
                            { "password", txtbPassword.Text },
                             {"name", txtbName.Text },
                            { "lastName", txtbLastName.Text },
                            { "curp", txtbCurp.Text },
                            { "carModel", txtbCarModel.Text },
                            { "email", txtbEmail.Text },
                            { "places", txtbPlaces.Text },
                            { "phone", txtbPhone.Text },
                            { "userType", "Conductora" },

                    };

                DialogResult result = MessageBox.Show("¿Estás seguro que quiere crear este registro?", "Confirmación de creacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si el usuario confirmó la eliminación, eliminar el registro de la base de datos y del DataGridView
                if (result == DialogResult.Yes)
                {

                    DocumentReference docRef = db.Collection("Users").Document();
                    await docRef.SetAsync(data);


                    MessageBox.Show("Registro creado correctamente.");
                }
            }


        }

        private async void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del registro que se va a eliminar
                string id = txtbID.Text;

                // Mostrar mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este registro?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si el usuario confirmó la eliminación, eliminar el registro de la base de datos y del DataGridView
                if (result == DialogResult.Yes)
                {
                    DocumentReference docRef = db.Collection("Users").Document(id);
                    await docRef.DeleteAsync();


                    MessageBox.Show("Registro eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void ModConductoraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Conductora modificar = new Conductora();
            modificar.ShowDialog();
        }

        private async void btnMod_Click_1(object sender, EventArgs e)
        {
            string id = txtbID.Text;

            if (string.IsNullOrEmpty(txtbUserName.Text) ||
                string.IsNullOrEmpty(txtbPassword.Text) ||
                string.IsNullOrEmpty(txtbName.Text) ||
                string.IsNullOrEmpty(txtbLastName.Text) ||
                string.IsNullOrEmpty(txtbCurp.Text) ||
                string.IsNullOrEmpty(txtbCarModel.Text) ||
                string.IsNullOrEmpty(txtbEmail.Text) ||
                string.IsNullOrEmpty(txtbPlaces.Text) ||
                string.IsNullOrEmpty(txtbPhone.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.");
                    return; // Detener la ejecución si hay algún campo vacío
                }


            if (Regex.IsMatch(txtbUserName.Text, @"[^a-zA-Z0-9]"))
            {
                MessageBox.Show("El nombre de usuario no puede contener caracteres especiales.");
                return;
            }

            if (txtbPassword.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                return;
            }

            if (!Regex.IsMatch(txtbPassword.Text, @"^(?=.*[A-Z])(?=.*[!@#$%^&*()_+=\[{\]};:<>|./?,-])[a-zA-Z0-9!@#$%^&*()_+=\[{\]};:<>|./?,-]+$"))
            {
                MessageBox.Show("La contraseña debe contener al menos una mayúscula y un carácter especial.");
                return;
            }

            if (!Regex.IsMatch(txtbName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El nombre sólo puede contener letras y espacios.");
                return;
            }


            if (!Regex.IsMatch(txtbLastName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El apellido sólo puede contener letras y espacios.");
                return;
            }

            

            if (txtbCurp.Text.Length != 18 ||
            txtbCurp.Text.Substring(0, 2) != txtbLastName.Text.Substring(0, 2).ToUpper() ||
            txtbCurp.Text[2] != txtbLastName.Text.Substring(txtbLastName.Text.IndexOf(" ") + 1, 1)[0] ||
            txtbCurp.Text[3] != txtbName.Text[0])
            {
                MessageBox.Show("El formato del CURP es incorrecto.");
                return;
            }

            if (!Regex.IsMatch(txtbCurp.Text, "^.{10}M.*$"))
            {
                MessageBox.Show("Ese CURP es incorrecto o pertenece a un hombre.");
                return;
            }

            string curp = txtbCurp.Text.ToUpper();


            if (!Regex.IsMatch(curp.Substring(4, 2), @"^(0[0-5]|[2-9]\d)$"))
            {
                MessageBox.Show("La persona contratada no puede ser menor de edad");
                return;
            }



            if (!txtbEmail.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo válido");
                return;
            }

            if (!Regex.IsMatch(txtbPhone.Text, @"^\d{13}$"))
            {
                MessageBox.Show("El número de teléfono debe tener 13 dígitos.");
                return;
            }




            CollectionReference usersCollection = db.Collection("Users");






            if (txtbID.Text != "")
            {



                DocumentReference docRef = db.Collection("Users").Document(id);
                Dictionary<string, object> data = new Dictionary<string, object>
            {

                            { "userName", txtbUserName.Text },
                            { "password", txtbPassword.Text },
                             {"name", txtbName.Text },
                            { "lastName", txtbLastName.Text },
                            { "curp", txtbCurp.Text },
                            { "carModel", txtbCarModel.Text },
                            { "email", txtbEmail.Text },
                            { "places", txtbPlaces.Text },
                            { "phone", txtbPhone.Text },
                            { "userType", "Conductora" },
            };

                DialogResult result = MessageBox.Show("¿Estás seguro que quiere hacer estas modificaciones?", "Confirmación de modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    await docRef.UpdateAsync(data);


                    MessageBox.Show("Registro modificado correctamente.");
                }
            }
            else
            {

                var queryUserName = usersCollection.WhereEqualTo("userName", txtbUserName.Text);
                var userNameSnapshot = await queryUserName.GetSnapshotAsync();
                if (userNameSnapshot.Documents.Count > 0)
                {
                    MessageBox.Show("El nombre de usuario ya existe en la base de datos.");
                    return;
                }

                var queryCurp = usersCollection.WhereEqualTo("curp", txtbCurp.Text);
                var curpSnapshot = await queryCurp.GetSnapshotAsync();
                if (curpSnapshot.Documents.Count > 0)
                {
                    MessageBox.Show("El CURP ya existe en la base de datos.");
                    return;
                }

                var queryPhone = usersCollection.WhereEqualTo("phone", txtbPhone.Text);
                var phoneSnapshot = await queryPhone.GetSnapshotAsync();
                if (phoneSnapshot.Documents.Count > 0)
                {
                    MessageBox.Show("El número de teléfono ya existe en la base de datos.");
                    return;
                }

                Dictionary<string, object> data = new Dictionary<string, object>
                    {
                       { "userName", txtbUserName.Text },
                            { "password", txtbPassword.Text },
                             {"name", txtbName.Text },
                            { "lastName", txtbLastName.Text },
                            { "curp", txtbCurp.Text },
                            { "carModel", txtbCarModel.Text },
                            { "email", txtbEmail.Text },
                            { "places", txtbPlaces.Text },
                            { "phone", txtbPhone.Text },
                            { "userType", "Conductora" },

                    };

                DialogResult result = MessageBox.Show("¿Estás seguro que quiere crear este registro?", "Confirmación de creacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si el usuario confirmó la eliminación, eliminar el registro de la base de datos y del DataGridView
                if (result == DialogResult.Yes)
                {

                    DocumentReference docRef = db.Collection("Users").Document();
                    await docRef.SetAsync(data);


                    MessageBox.Show("Registro creado correctamente.");
                }
            }

        }

        private void ModConductoraForm_Load_1(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"lilawaybase.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("lilaway-aca5b");

            LoadImageFromDatabase(txtbID.Text);
        }

        private async void btnDel_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del registro que se va a eliminar
                string id = txtbID.Text;

                // Mostrar mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este registro?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si el usuario confirmó la eliminación, eliminar el registro de la base de datos y del DataGridView
                if (result == DialogResult.Yes)
                {
                    DocumentReference docRef = db.Collection("Users").Document(id);
                    await docRef.DeleteAsync();


                    MessageBox.Show("Registro eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro: " + ex.Message);
            }
        }

        private void ModConductoraForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Conductora modificar = new Conductora();
            modificar.ShowDialog();
        }
        private async void LoadImageFromDatabase(string reportId)
        {
            DocumentReference reportRef = db.Collection("Users").Document(reportId);
            DocumentSnapshot snapshot = await reportRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                if (snapshot.ContainsField("image"))
                {
                    string imageUrl = snapshot.GetValue<string>("image");

                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        try
                        {
                            using (HttpClient httpClient = new HttpClient())
                            {
                                byte[] imageData = await httpClient.GetByteArrayAsync(imageUrl);
                                MemoryStream memoryStream = new MemoryStream(imageData);
                                Image image = Image.FromStream(memoryStream);

                                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                                pictureBox1.Image = image;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La imagen no está disponible en la base de datos.");
                    }
                }
                else
                {
                    MessageBox.Show("El campo de imagen no existe en el documento.");
                }
            }
            else
            {
                MessageBox.Show("El informe con el ID proporcionado no existe en la base de datos.");
            }
        }

    }
}
