namespace LilaWay
{
    partial class ModReportesForm
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
            this.txtbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbAgressor = new System.Windows.Forms.TextBox();
            this.txtbAssaulted = new System.Windows.Forms.TextBox();
            this.cmbSeverity = new System.Windows.Forms.ComboBox();
            this.txtbReason = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbID
            // 
            this.txtbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.txtbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbID.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbID.ForeColor = System.Drawing.Color.White;
            this.txtbID.Location = new System.Drawing.Point(277, 78);
            this.txtbID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbID.Name = "txtbID";
            this.txtbID.ReadOnly = true;
            this.txtbID.Size = new System.Drawing.Size(248, 23);
            this.txtbID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(294, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Modificar Reporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(185, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // txtbAgressor
            // 
            this.txtbAgressor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.txtbAgressor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbAgressor.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbAgressor.ForeColor = System.Drawing.Color.White;
            this.txtbAgressor.Location = new System.Drawing.Point(277, 164);
            this.txtbAgressor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbAgressor.Name = "txtbAgressor";
            this.txtbAgressor.Size = new System.Drawing.Size(248, 23);
            this.txtbAgressor.TabIndex = 18;
            // 
            // txtbAssaulted
            // 
            this.txtbAssaulted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.txtbAssaulted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbAssaulted.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbAssaulted.ForeColor = System.Drawing.Color.White;
            this.txtbAssaulted.Location = new System.Drawing.Point(277, 246);
            this.txtbAssaulted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbAssaulted.Name = "txtbAssaulted";
            this.txtbAssaulted.Size = new System.Drawing.Size(248, 23);
            this.txtbAssaulted.TabIndex = 19;
            // 
            // cmbSeverity
            // 
            this.cmbSeverity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.cmbSeverity.FormattingEnabled = true;
            this.cmbSeverity.Items.AddRange(new object[] {
            "Minor",
            "Urgent"});
            this.cmbSeverity.Location = new System.Drawing.Point(277, 317);
            this.cmbSeverity.Name = "cmbSeverity";
            this.cmbSeverity.Size = new System.Drawing.Size(248, 28);
            this.cmbSeverity.TabIndex = 20;
            // 
            // txtbReason
            // 
            this.txtbReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.txtbReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbReason.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbReason.ForeColor = System.Drawing.Color.White;
            this.txtbReason.Location = new System.Drawing.Point(277, 386);
            this.txtbReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbReason.Multiline = true;
            this.txtbReason.Name = "txtbReason";
            this.txtbReason.Size = new System.Drawing.Size(248, 171);
            this.txtbReason.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(93, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Aggressor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(93, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "Assaulted";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(110, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "Severity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(121, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 27);
            this.label6.TabIndex = 25;
            this.label6.Text = "Reason";
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMod.ForeColor = System.Drawing.Color.White;
            this.btnMod.Location = new System.Drawing.Point(93, 616);
            this.btnMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(216, 71);
            this.btnMod.TabIndex = 26;
            this.btnMod.Text = "Modificar/Agregar";
            this.btnMod.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(487, 616);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(183, 71);
            this.btnDel.TabIndex = 27;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // ModReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbReason);
            this.Controls.Add(this.cmbSeverity);
            this.Controls.Add(this.txtbAssaulted);
            this.Controls.Add(this.txtbAgressor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbID);
            this.Name = "ModReportesForm";
            this.Text = "ModReportesForm";
            this.Load += new System.EventHandler(this.ModReportesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox txtbID;
        private Label label3;
        private Label label1;
        public TextBox txtbAgressor;
        public TextBox txtbAssaulted;
        private ComboBox cmbSeverity;
        public TextBox txtbReason;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnMod;
        private Button btnDel;
    }
}