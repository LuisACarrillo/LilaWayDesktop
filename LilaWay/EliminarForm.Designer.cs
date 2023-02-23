namespace LilaWay
{
    partial class EliminarForm
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
            this.btnDelDriver = new System.Windows.Forms.Button();
            this.txtbIDuser = new System.Windows.Forms.TextBox();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbIDdriver
            // 
            this.txtbIDdriver.Location = new System.Drawing.Point(61, 289);
            this.txtbIDdriver.Name = "txtbIDdriver";
            this.txtbIDdriver.Size = new System.Drawing.Size(100, 23);
            this.txtbIDdriver.TabIndex = 0;
            // 
            // btnDelDriver
            // 
            this.btnDelDriver.Location = new System.Drawing.Point(75, 350);
            this.btnDelDriver.Name = "btnDelDriver";
            this.btnDelDriver.Size = new System.Drawing.Size(75, 23);
            this.btnDelDriver.TabIndex = 1;
            this.btnDelDriver.Text = "button1";
            this.btnDelDriver.UseVisualStyleBackColor = true;
            this.btnDelDriver.Click += new System.EventHandler(this.btnDelDriver_Click);
            // 
            // txtbIDuser
            // 
            this.txtbIDuser.Location = new System.Drawing.Point(312, 289);
            this.txtbIDuser.Name = "txtbIDuser";
            this.txtbIDuser.Size = new System.Drawing.Size(100, 23);
            this.txtbIDuser.TabIndex = 2;
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(321, 350);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(75, 23);
            this.btnDelUser.TabIndex = 3;
            this.btnDelUser.Text = "button1";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // EliminarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.txtbIDuser);
            this.Controls.Add(this.btnDelDriver);
            this.Controls.Add(this.txtbIDdriver);
            this.Name = "EliminarForm";
            this.Text = "EliminarForm";
            this.Load += new System.EventHandler(this.EliminarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbIDdriver;
        private Button btnDelDriver;
        private TextBox txtbIDuser;
        private Button btnDelUser;
    }
}