namespace LilaWay
{
    partial class Conductora
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            txtbIDdriver = new TextBox();
            txtbNombre = new TextBox();
            txtbApellido = new TextBox();
            txtbCURP = new TextBox();
            btnRetDriver = new Button();
            btnModifyDriver = new Button();
            txtbUser = new TextBox();
            txtbPassword = new TextBox();
            btnModUser = new Button();
            btnRetUser = new Button();
            txtbIDuser = new TextBox();
            registerBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            userName = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            curp = new DataGridViewTextBoxColumn();
            carModel = new DataGridViewTextBoxColumn();
            places = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            Modified = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            btnAdd = new Button();
            textBox1 = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)registerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtbIDdriver
            // 
            txtbIDdriver.Location = new Point(79, 129);
            txtbIDdriver.Name = "txtbIDdriver";
            txtbIDdriver.Size = new Size(100, 23);
            txtbIDdriver.TabIndex = 0;
            // 
            // txtbNombre
            // 
            txtbNombre.Location = new Point(79, 191);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(100, 23);
            txtbNombre.TabIndex = 1;
            // 
            // txtbApellido
            // 
            txtbApellido.Location = new Point(79, 256);
            txtbApellido.Name = "txtbApellido";
            txtbApellido.Size = new Size(100, 23);
            txtbApellido.TabIndex = 2;
            // 
            // txtbCURP
            // 
            txtbCURP.Location = new Point(79, 318);
            txtbCURP.Name = "txtbCURP";
            txtbCURP.Size = new Size(100, 23);
            txtbCURP.TabIndex = 3;
            // 
            // btnRetDriver
            // 
            btnRetDriver.Location = new Point(36, 372);
            btnRetDriver.Name = "btnRetDriver";
            btnRetDriver.Size = new Size(75, 23);
            btnRetDriver.TabIndex = 4;
            btnRetDriver.Text = "button1";
            btnRetDriver.UseVisualStyleBackColor = true;
            btnRetDriver.Click += btnModDriver_Click;
            // 
            // btnModifyDriver
            // 
            btnModifyDriver.Location = new Point(178, 372);
            btnModifyDriver.Name = "btnModifyDriver";
            btnModifyDriver.Size = new Size(75, 23);
            btnModifyDriver.TabIndex = 5;
            btnModifyDriver.Text = "button1";
            btnModifyDriver.UseVisualStyleBackColor = true;
            // 
            // txtbUser
            // 
            txtbUser.Location = new Point(0, 0);
            txtbUser.Name = "txtbUser";
            txtbUser.Size = new Size(100, 23);
            txtbUser.TabIndex = 0;
            // 
            // txtbPassword
            // 
            txtbPassword.Location = new Point(0, 0);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.Size = new Size(100, 23);
            txtbPassword.TabIndex = 0;
            // 
            // btnModUser
            // 
            btnModUser.Location = new Point(0, 0);
            btnModUser.Name = "btnModUser";
            btnModUser.Size = new Size(75, 23);
            btnModUser.TabIndex = 0;
            // 
            // btnRetUser
            // 
            btnRetUser.Location = new Point(0, 0);
            btnRetUser.Name = "btnRetUser";
            btnRetUser.Size = new Size(75, 23);
            btnRetUser.TabIndex = 0;
            // 
            // txtbIDuser
            // 
            txtbIDuser.Location = new Point(0, 0);
            txtbIDuser.Name = "txtbIDuser";
            txtbIDuser.Size = new Size(100, 23);
            txtbIDuser.TabIndex = 0;
            // 
            // registerBindingSource
            // 
            registerBindingSource.DataSource = typeof(register);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(152, 84, 194);
            dataGridViewCellStyle1.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(243, 217, 255);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(152, 84, 194);
            dataGridViewCellStyle2.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, userName, password, email, name, lastName, curp, carModel, places, phone, Modified, Eliminar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(165, 46, 178);
            dataGridViewCellStyle3.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.FromArgb(165, 46, 178);
            dataGridView1.Location = new Point(1, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(152, 84, 194);
            dataGridViewCellStyle4.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 255);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(152, 84, 194);
            dataGridViewCellStyle5.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 128, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1269, 576);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit_1;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // userName
            // 
            userName.HeaderText = "userName";
            userName.Name = "userName";
            userName.ReadOnly = true;
            userName.Visible = false;
            // 
            // password
            // 
            password.HeaderText = "password";
            password.Name = "password";
            password.ReadOnly = true;
            password.Visible = false;
            // 
            // email
            // 
            email.HeaderText = "email";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // lastName
            // 
            lastName.HeaderText = "lastName";
            lastName.Name = "lastName";
            lastName.ReadOnly = true;
            // 
            // curp
            // 
            curp.HeaderText = "curp";
            curp.Name = "curp";
            curp.ReadOnly = true;
            curp.Visible = false;
            // 
            // carModel
            // 
            carModel.HeaderText = "carModel";
            carModel.Name = "carModel";
            carModel.ReadOnly = true;
            carModel.Visible = false;
            // 
            // places
            // 
            places.HeaderText = "places";
            places.Name = "places";
            places.ReadOnly = true;
            places.Visible = false;
            // 
            // phone
            // 
            phone.HeaderText = "phone";
            phone.Name = "phone";
            phone.ReadOnly = true;
            phone.Visible = false;
            // 
            // Modified
            // 
            Modified.HeaderText = "Modified";
            Modified.Name = "Modified";
            Modified.ReadOnly = true;
            Modified.Visible = false;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Visible = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(50, 0, 50);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1098, 545);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 53);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnMod_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(1, 5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese un correo";
            textBox1.Size = new Size(1063, 26);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(50, 0, 50);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = Properties.Resources.pngwing_com;
            btnSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnSearch.Location = new Point(1093, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(165, 28);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // Conductora
            // 
            BackColor = Color.FromArgb(243, 217, 255);
            ClientSize = new Size(1270, 610);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "Conductora";
            Load += ModificarForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)registerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbIDdriver;
        private TextBox txtbNombre;
        private TextBox txtbApellido;
        private TextBox txtbCURP;
        private Button btnRetDriver;
        private Button btnModifyDriver;
        private TextBox txtbUser;
        private TextBox txtbPassword;
        private Button btnModUser;
        private Button btnRetUser;
        private TextBox txtbIDuser;
        private BindingSource registerBindingSource;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private TextBox textBox1;
        private Button btnSearch;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn curp;
        private DataGridViewTextBoxColumn carModel;
        private DataGridViewTextBoxColumn places;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn Modified;
        private DataGridViewButtonColumn Eliminar;
    }
}