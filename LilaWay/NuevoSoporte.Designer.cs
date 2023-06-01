namespace LilaWay
{
    partial class NuevoSoporte
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(326, 252);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PlaceholderText = "contraseña";
            this.txtbPassword.Size = new System.Drawing.Size(100, 23);
            this.txtbPassword.TabIndex = 1;
            // 
            // txtbUser
            // 
            this.txtbUser.Location = new System.Drawing.Point(326, 175);
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.PlaceholderText = "usuario";
            this.txtbUser.Size = new System.Drawing.Size(100, 23);
            this.txtbUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar nuevo soporte";
            // 
            // NuevoSoporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUser);
            this.Name = "NuevoSoporte";
            this.Text = "NuevoSoporte";
            this.Load += new System.EventHandler(this.NuevoSoporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txtbPassword;
        private TextBox txtbUser;
        private Label label1;
    }
}