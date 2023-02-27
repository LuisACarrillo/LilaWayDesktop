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
            this.components = new System.ComponentModel.Container();
            this.txtbIDdriver = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbCURP = new System.Windows.Forms.TextBox();
            this.btnRetDriver = new System.Windows.Forms.Button();
            this.btnModifyDriver = new System.Windows.Forms.Button();
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.btnModUser = new System.Windows.Forms.Button();
            this.btnRetUser = new System.Windows.Forms.Button();
            this.txtbIDuser = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.places = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Modified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbIDdriver
            // 
            this.txtbIDdriver.Location = new System.Drawing.Point(79, 129);
            this.txtbIDdriver.Name = "txtbIDdriver";
            this.txtbIDdriver.Size = new System.Drawing.Size(100, 23);
            this.txtbIDdriver.TabIndex = 0;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(79, 191);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 23);
            this.txtbNombre.TabIndex = 1;
            // 
            // txtbApellido
            // 
            this.txtbApellido.Location = new System.Drawing.Point(79, 256);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(100, 23);
            this.txtbApellido.TabIndex = 2;
            // 
            // txtbCURP
            // 
            this.txtbCURP.Location = new System.Drawing.Point(79, 318);
            this.txtbCURP.Name = "txtbCURP";
            this.txtbCURP.Size = new System.Drawing.Size(100, 23);
            this.txtbCURP.TabIndex = 3;
            // 
            // btnRetDriver
            // 
            this.btnRetDriver.Location = new System.Drawing.Point(36, 372);
            this.btnRetDriver.Name = "btnRetDriver";
            this.btnRetDriver.Size = new System.Drawing.Size(75, 23);
            this.btnRetDriver.TabIndex = 4;
            this.btnRetDriver.Text = "button1";
            this.btnRetDriver.UseVisualStyleBackColor = true;
            this.btnRetDriver.Click += new System.EventHandler(this.btnModDriver_Click);
            // 
            // btnModifyDriver
            // 
            this.btnModifyDriver.Location = new System.Drawing.Point(178, 372);
            this.btnModifyDriver.Name = "btnModifyDriver";
            this.btnModifyDriver.Size = new System.Drawing.Size(75, 23);
            this.btnModifyDriver.TabIndex = 5;
            this.btnModifyDriver.Text = "button1";
            this.btnModifyDriver.UseVisualStyleBackColor = true;
            // 
            // txtbUser
            // 
            this.txtbUser.Location = new System.Drawing.Point(0, 0);
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.Size = new System.Drawing.Size(100, 23);
            this.txtbUser.TabIndex = 0;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(0, 0);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(100, 23);
            this.txtbPassword.TabIndex = 0;
            // 
            // btnModUser
            // 
            this.btnModUser.Location = new System.Drawing.Point(0, 0);
            this.btnModUser.Name = "btnModUser";
            this.btnModUser.Size = new System.Drawing.Size(75, 23);
            this.btnModUser.TabIndex = 0;
            // 
            // btnRetUser
            // 
            this.btnRetUser.Location = new System.Drawing.Point(0, 0);
            this.btnRetUser.Name = "btnRetUser";
            this.btnRetUser.Size = new System.Drawing.Size(75, 23);
            this.btnRetUser.TabIndex = 0;
            // 
            // txtbIDuser
            // 
            this.txtbIDuser.Location = new System.Drawing.Point(0, 0);
            this.txtbIDuser.Name = "txtbIDuser";
            this.txtbIDuser.Size = new System.Drawing.Size(100, 23);
            this.txtbIDuser.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.userName,
            this.password,
            this.name,
            this.lastName,
            this.curp,
            this.carModel,
            this.email,
            this.places,
            this.phone,
            this.Modified});
            this.dataGridView1.Location = new System.Drawing.Point(99, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 483);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // userName
            // 
            this.userName.HeaderText = "userName";
            this.userName.Name = "userName";
            // 
            // password
            // 
            this.password.HeaderText = "password";
            this.password.Name = "password";
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "lastName";
            this.lastName.Name = "lastName";
            // 
            // curp
            // 
            this.curp.HeaderText = "curp";
            this.curp.Name = "curp";
            // 
            // carModel
            // 
            this.carModel.HeaderText = "carModel";
            this.carModel.Name = "carModel";
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // places
            // 
            this.places.HeaderText = "places";
            this.places.Name = "places";
            // 
            // phone
            // 
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataSource = typeof(LilaWay.register);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modified
            // 
            this.Modified.HeaderText = "Modified";
            this.Modified.Name = "Modified";
            // 
            // Conductora
            // 
            this.ClientSize = new System.Drawing.Size(1270, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Conductora";
            this.Load += new System.EventHandler(this.ModificarForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private DataGridView dataGridView1;
        private BindingSource registerBindingSource;
        private Button button1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn curp;
        private DataGridViewTextBoxColumn carModel;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn places;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn Modified;
    }
}