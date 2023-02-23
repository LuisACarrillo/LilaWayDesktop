namespace LilaWay
{
    partial class ModificarForm
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
            this.btnModifyDriver.Click += new System.EventHandler(this.btnModifyDriver_Click);
            // 
            // txtbUser
            // 
            this.txtbUser.Location = new System.Drawing.Point(313, 256);
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.Size = new System.Drawing.Size(100, 23);
            this.txtbUser.TabIndex = 6;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(313, 318);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(100, 23);
            this.txtbPassword.TabIndex = 7;
            // 
            // btnModUser
            // 
            this.btnModUser.Location = new System.Drawing.Point(398, 372);
            this.btnModUser.Name = "btnModUser";
            this.btnModUser.Size = new System.Drawing.Size(75, 23);
            this.btnModUser.TabIndex = 8;
            this.btnModUser.Text = "button1";
            this.btnModUser.UseVisualStyleBackColor = true;
            this.btnModUser.Click += new System.EventHandler(this.btnModUser_Click);
            // 
            // btnRetUser
            // 
            this.btnRetUser.Location = new System.Drawing.Point(289, 372);
            this.btnRetUser.Name = "btnRetUser";
            this.btnRetUser.Size = new System.Drawing.Size(75, 23);
            this.btnRetUser.TabIndex = 9;
            this.btnRetUser.Text = "button1";
            this.btnRetUser.UseVisualStyleBackColor = true;
            this.btnRetUser.Click += new System.EventHandler(this.btnRetUser_Click);
            // 
            // txtbIDuser
            // 
            this.txtbIDuser.Location = new System.Drawing.Point(313, 191);
            this.txtbIDuser.Name = "txtbIDuser";
            this.txtbIDuser.Size = new System.Drawing.Size(100, 23);
            this.txtbIDuser.TabIndex = 10;
            // 
            // ModificarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbIDuser);
            this.Controls.Add(this.btnRetUser);
            this.Controls.Add(this.btnModUser);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUser);
            this.Controls.Add(this.btnModifyDriver);
            this.Controls.Add(this.btnRetDriver);
            this.Controls.Add(this.txtbCURP);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.txtbIDdriver);
            this.Name = "ModificarForm";
            this.Text = "ModificarForm";
            this.Load += new System.EventHandler(this.ModificarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}