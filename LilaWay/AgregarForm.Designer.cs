namespace LilaWay
{
    partial class AgregarForm
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
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.txtbCURP = new System.Windows.Forms.TextBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.txtbVictimCurp = new System.Windows.Forms.TextBox();
            this.cmbbOffType = new System.Windows.Forms.ComboBox();
            this.txtbOffendercurp = new System.Windows.Forms.TextBox();
            this.cmbbSeverity = new System.Windows.Forms.ComboBox();
            this.txtbReason = new System.Windows.Forms.TextBox();
            this.btnAddReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbUser
            // 
            this.txtbUser.BackColor = System.Drawing.Color.White;
            this.txtbUser.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbUser.ForeColor = System.Drawing.Color.Black;
            this.txtbUser.Location = new System.Drawing.Point(346, 225);
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.PlaceholderText = "Usuario";
            this.txtbUser.Size = new System.Drawing.Size(100, 26);
            this.txtbUser.TabIndex = 0;
            // 
            // txtbPassword
            // 
            this.txtbPassword.BackColor = System.Drawing.Color.White;
            this.txtbPassword.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbPassword.ForeColor = System.Drawing.Color.Black;
            this.txtbPassword.Location = new System.Drawing.Point(346, 279);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PlaceholderText = "Contraseña";
            this.txtbPassword.Size = new System.Drawing.Size(100, 26);
            this.txtbPassword.TabIndex = 1;
            this.txtbPassword.UseSystemPasswordChar = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(346, 337);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 60);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Agregar Usuario";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbName
            // 
            this.txtbName.BackColor = System.Drawing.Color.White;
            this.txtbName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbName.ForeColor = System.Drawing.Color.Black;
            this.txtbName.Location = new System.Drawing.Point(111, 224);
            this.txtbName.Name = "txtbName";
            this.txtbName.PlaceholderText = "Nombre";
            this.txtbName.Size = new System.Drawing.Size(109, 26);
            this.txtbName.TabIndex = 4;
            this.txtbName.TabStop = false;
            // 
            // txtbLastName
            // 
            this.txtbLastName.BackColor = System.Drawing.Color.White;
            this.txtbLastName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbLastName.ForeColor = System.Drawing.Color.Black;
            this.txtbLastName.Location = new System.Drawing.Point(111, 279);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.PlaceholderText = "Apellido";
            this.txtbLastName.Size = new System.Drawing.Size(109, 26);
            this.txtbLastName.TabIndex = 5;
            // 
            // txtbCURP
            // 
            this.txtbCURP.BackColor = System.Drawing.Color.White;
            this.txtbCURP.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbCURP.ForeColor = System.Drawing.Color.Black;
            this.txtbCURP.Location = new System.Drawing.Point(111, 174);
            this.txtbCURP.Name = "txtbCURP";
            this.txtbCURP.PlaceholderText = "CURP";
            this.txtbCURP.Size = new System.Drawing.Size(109, 26);
            this.txtbCURP.TabIndex = 6;
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnAddDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDriver.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddDriver.ForeColor = System.Drawing.Color.White;
            this.btnAddDriver.Location = new System.Drawing.Point(111, 337);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(109, 60);
            this.btnAddDriver.TabIndex = 7;
            this.btnAddDriver.Text = "Agregar Conductora";
            this.btnAddDriver.UseVisualStyleBackColor = false;
            this.btnAddDriver.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbVictimCurp
            // 
            this.txtbVictimCurp.AllowDrop = true;
            this.txtbVictimCurp.BackColor = System.Drawing.Color.White;
            this.txtbVictimCurp.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbVictimCurp.ForeColor = System.Drawing.Color.Black;
            this.txtbVictimCurp.Location = new System.Drawing.Point(560, 126);
            this.txtbVictimCurp.Name = "txtbVictimCurp";
            this.txtbVictimCurp.PlaceholderText = "Víctima";
            this.txtbVictimCurp.Size = new System.Drawing.Size(100, 26);
            this.txtbVictimCurp.TabIndex = 16;
            // 
            // cmbbOffType
            // 
            this.cmbbOffType.BackColor = System.Drawing.Color.White;
            this.cmbbOffType.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbbOffType.ForeColor = System.Drawing.Color.Black;
            this.cmbbOffType.FormattingEnabled = true;
            this.cmbbOffType.Items.AddRange(new object[] {
            "cliente",
            "conductora"});
            this.cmbbOffType.Location = new System.Drawing.Point(560, 76);
            this.cmbbOffType.Name = "cmbbOffType";
            this.cmbbOffType.Size = new System.Drawing.Size(100, 27);
            this.cmbbOffType.TabIndex = 17;
            // 
            // txtbOffendercurp
            // 
            this.txtbOffendercurp.AllowDrop = true;
            this.txtbOffendercurp.BackColor = System.Drawing.Color.White;
            this.txtbOffendercurp.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbOffendercurp.ForeColor = System.Drawing.Color.Black;
            this.txtbOffendercurp.Location = new System.Drawing.Point(560, 174);
            this.txtbOffendercurp.Name = "txtbOffendercurp";
            this.txtbOffendercurp.PlaceholderText = "Agresor";
            this.txtbOffendercurp.Size = new System.Drawing.Size(100, 26);
            this.txtbOffendercurp.TabIndex = 18;
            // 
            // cmbbSeverity
            // 
            this.cmbbSeverity.BackColor = System.Drawing.Color.White;
            this.cmbbSeverity.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbbSeverity.ForeColor = System.Drawing.Color.Black;
            this.cmbbSeverity.FormattingEnabled = true;
            this.cmbbSeverity.Items.AddRange(new object[] {
            "Menor",
            "Urgente"});
            this.cmbbSeverity.Location = new System.Drawing.Point(560, 224);
            this.cmbbSeverity.Name = "cmbbSeverity";
            this.cmbbSeverity.Size = new System.Drawing.Size(100, 27);
            this.cmbbSeverity.TabIndex = 19;
            // 
            // txtbReason
            // 
            this.txtbReason.AllowDrop = true;
            this.txtbReason.BackColor = System.Drawing.Color.White;
            this.txtbReason.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbReason.ForeColor = System.Drawing.Color.Black;
            this.txtbReason.Location = new System.Drawing.Point(560, 282);
            this.txtbReason.Multiline = true;
            this.txtbReason.Name = "txtbReason";
            this.txtbReason.PlaceholderText = "Razón";
            this.txtbReason.Size = new System.Drawing.Size(100, 23);
            this.txtbReason.TabIndex = 20;
            // 
            // btnAddReport
            // 
            this.btnAddReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnAddReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReport.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddReport.ForeColor = System.Drawing.Color.White;
            this.btnAddReport.Location = new System.Drawing.Point(560, 337);
            this.btnAddReport.Name = "btnAddReport";
            this.btnAddReport.Size = new System.Drawing.Size(100, 60);
            this.btnAddReport.TabIndex = 21;
            this.btnAddReport.Text = "Agregar Reporte";
            this.btnAddReport.UseVisualStyleBackColor = false;
            this.btnAddReport.Click += new System.EventHandler(this.btnAddReport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(106, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Conductora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Agregar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(355, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(569, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Reporte";
            // 
            // AgregarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(84)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddReport);
            this.Controls.Add(this.txtbReason);
            this.Controls.Add(this.cmbbSeverity);
            this.Controls.Add(this.txtbOffendercurp);
            this.Controls.Add(this.cmbbOffType);
            this.Controls.Add(this.txtbVictimCurp);
            this.Controls.Add(this.btnAddDriver);
            this.Controls.Add(this.txtbCURP);
            this.Controls.Add(this.txtbLastName);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUser);
            this.Name = "AgregarForm";
            this.Text = "AgregarForm";
            this.Load += new System.EventHandler(this.AgregarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbUser;
        private TextBox txtbPassword;
        private Button btnAddUser;
        private TextBox txtbName;
        private TextBox txtbLastName;
        private TextBox txtbCURP;
        private Button btnAddDriver;
        private TextBox txtbVictimCurp;
        private ComboBox cmbbOffType;
        private TextBox txtbOffendercurp;
        private ComboBox cmbbSeverity;
        private TextBox txtbReason;
        private Button btnAddReport;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}