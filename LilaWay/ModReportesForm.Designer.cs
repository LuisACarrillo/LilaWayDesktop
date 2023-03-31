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
            this.cmbSeverity = new System.Windows.Forms.ComboBox();
            this.txtbReason = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.cmbAggressor = new System.Windows.Forms.ComboBox();
            this.cmbAssaulted = new System.Windows.Forms.ComboBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.S = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbID
            // 
            this.txtbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.txtbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbID.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbID.ForeColor = System.Drawing.Color.White;
            this.txtbID.Location = new System.Drawing.Point(277, 77);
            this.txtbID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbID.Name = "txtbID";
            this.txtbID.ReadOnly = true;
            this.txtbID.Size = new System.Drawing.Size(248, 23);
            this.txtbID.TabIndex = 15;
            this.txtbID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(294, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Modificar Reporte";
            // 
            // cmbSeverity
            // 
            this.cmbSeverity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.cmbSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeverity.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSeverity.FormattingEnabled = true;
            this.cmbSeverity.Items.AddRange(new object[] {
            "Minor",
            "Urgent"});
            this.cmbSeverity.Location = new System.Drawing.Point(277, 317);
            this.cmbSeverity.Name = "cmbSeverity";
            this.cmbSeverity.Size = new System.Drawing.Size(249, 30);
            this.cmbSeverity.TabIndex = 20;
            // 
            // txtbReason
            // 
            this.txtbReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.txtbReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbReason.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbReason.ForeColor = System.Drawing.Color.White;
            this.txtbReason.Location = new System.Drawing.Point(277, 387);
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
            this.label4.Location = new System.Drawing.Point(93, 243);
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
            this.label5.Location = new System.Drawing.Point(110, 317);
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
            this.label6.Location = new System.Drawing.Point(121, 387);
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
            this.btnMod.Location = new System.Drawing.Point(93, 741);
            this.btnMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(216, 71);
            this.btnMod.TabIndex = 26;
            this.btnMod.Text = "Modificar/Agregar";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(510, 741);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(183, 71);
            this.btnDel.TabIndex = 27;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cmbAggressor
            // 
            this.cmbAggressor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.cmbAggressor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAggressor.Enabled = false;
            this.cmbAggressor.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAggressor.FormattingEnabled = true;
            this.cmbAggressor.Location = new System.Drawing.Point(277, 159);
            this.cmbAggressor.Name = "cmbAggressor";
            this.cmbAggressor.Size = new System.Drawing.Size(249, 30);
            this.cmbAggressor.TabIndex = 28;
            // 
            // cmbAssaulted
            // 
            this.cmbAssaulted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.cmbAssaulted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssaulted.Enabled = false;
            this.cmbAssaulted.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAssaulted.FormattingEnabled = true;
            this.cmbAssaulted.Location = new System.Drawing.Point(277, 235);
            this.cmbAssaulted.Name = "cmbAssaulted";
            this.cmbAssaulted.Size = new System.Drawing.Size(249, 30);
            this.cmbAssaulted.TabIndex = 29;
            // 
            // cmbState
            // 
            this.cmbState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Solved",
            "Pending"});
            this.cmbState.Location = new System.Drawing.Point(275, 627);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(249, 30);
            this.cmbState.TabIndex = 30;
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S.ForeColor = System.Drawing.Color.Black;
            this.S.Location = new System.Drawing.Point(143, 635);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(66, 27);
            this.S.TabIndex = 31;
            this.S.Text = "State";
            // 
            // ModReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 853);
            this.Controls.Add(this.S);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.cmbAssaulted);
            this.Controls.Add(this.cmbAggressor);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbReason);
            this.Controls.Add(this.cmbSeverity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbID);
            this.Name = "ModReportesForm";
            this.Text = "ModReportesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModReportesForm_FormClosed);
            this.Load += new System.EventHandler(this.ModReportesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox txtbID;
        private Label label3;
        private ComboBox cmbSeverity;
        public TextBox txtbReason;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnMod;
        private Button btnDel;
        private ComboBox cmbAggressor;
        private ComboBox cmbAssaulted;
        private ComboBox cmbState;
        private Label S;
    }
}