namespace LilaWay
{
    partial class RegistrosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            id = new DataGridViewTextBoxColumn();
            curp = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            TipodeUsuario = new DataGridViewTextBoxColumn();
            NombreDeUsuario = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewCheckBoxColumn();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            userName = new DataGridViewTextBoxColumn();
            typeUser = new DataGridViewTextBoxColumn();
            carModel = new DataGridViewTextBoxColumn();
            places = new DataGridViewTextBoxColumn();
            typeService = new DataGridViewTextBoxColumn();
            status = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            id.HeaderText = "id";
            id.Name = "id";
            // 
            // curp
            // 
            curp.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            curp.HeaderText = "curp";
            curp.Name = "curp";
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            email.HeaderText = "email";
            email.Name = "email";
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            nombre.HeaderText = "nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            apellido.HeaderText = "apellido";
            apellido.Name = "apellido";
            // 
            // TipodeUsuario
            // 
            TipodeUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TipodeUsuario.HeaderText = "Tipo de Usuario";
            TipodeUsuario.Name = "TipodeUsuario";
            // 
            // NombreDeUsuario
            // 
            NombreDeUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            NombreDeUsuario.HeaderText = "Nombre De Usuario";
            NombreDeUsuario.Name = "NombreDeUsuario";
            // 
            // Estatus
            // 
            Estatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, name, lastName, phone, userName, typeUser, carModel, places, typeService, status });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1324, 481);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "CURP";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Email";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Nombre";
            name.Name = "name";
            // 
            // lastName
            // 
            lastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lastName.HeaderText = "Apellido(s)";
            lastName.Name = "lastName";
            // 
            // phone
            // 
            phone.HeaderText = "Telefono";
            phone.Name = "phone";
            // 
            // userName
            // 
            userName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            userName.HeaderText = "Nombre de Usuario";
            userName.Name = "userName";
            // 
            // typeUser
            // 
            typeUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            typeUser.HeaderText = "Tipo de Usuaria";
            typeUser.Name = "typeUser";
            // 
            // carModel
            // 
            carModel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            carModel.HeaderText = "Modelo de Carro";
            carModel.Name = "carModel";
            // 
            // places
            // 
            places.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            places.HeaderText = "Placas";
            places.Name = "places";
            // 
            // typeService
            // 
            typeService.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            typeService.HeaderText = "Tipo de Servicio";
            typeService.Name = "typeService";
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status.HeaderText = "Estatus";
            status.Name = "status";
            status.Resizable = DataGridViewTriState.True;
            status.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // RegistrosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 481);
            Controls.Add(dataGridView1);
            Name = "RegistrosForm";
            Text = "RegistrosForm";
            Load += RegistrosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn curp;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn TipodeUsuario;
        private DataGridViewTextBoxColumn NombreDeUsuario;
        private DataGridViewCheckBoxColumn Estatus;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn typeUser;
        private DataGridViewTextBoxColumn carModel;
        private DataGridViewTextBoxColumn places;
        private DataGridViewTextBoxColumn typeService;
        private DataGridViewCheckBoxColumn status;
    }
}