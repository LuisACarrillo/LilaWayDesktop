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
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.txtbdescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.cmbidClient = new System.Windows.Forms.ComboBox();
            this.cmbidDriver = new System.Windows.Forms.ComboBox();
            this.S = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbVictim = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbUrgency = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtbID
            // 
            this.txtbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.txtbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbID.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbID.ForeColor = System.Drawing.Color.White;
            this.txtbID.Location = new System.Drawing.Point(242, 58);
            this.txtbID.Name = "txtbID";
            this.txtbID.ReadOnly = true;
            this.txtbID.Size = new System.Drawing.Size(217, 18);
            this.txtbID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(257, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Modificar Reporte";
            // 
            // cmbstatus
            // 
            this.cmbstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "open",
            "closed"});
            this.cmbstatus.Location = new System.Drawing.Point(242, 238);
            this.cmbstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(218, 27);
            this.cmbstatus.TabIndex = 20;
            // 
            // txtbdescription
            // 
            this.txtbdescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.txtbdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbdescription.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbdescription.ForeColor = System.Drawing.Color.White;
            this.txtbdescription.Location = new System.Drawing.Point(243, 392);
            this.txtbdescription.Multiline = true;
            this.txtbdescription.Name = "txtbdescription";
            this.txtbdescription.Size = new System.Drawing.Size(217, 42);
            this.txtbdescription.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(81, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "idClient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(81, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "idDriver";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(96, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(81, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "description";
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMod.ForeColor = System.Drawing.Color.White;
            this.btnMod.Location = new System.Drawing.Point(43, 575);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(189, 53);
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
            this.btnDel.Location = new System.Drawing.Point(504, 575);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(160, 53);
            this.btnDel.TabIndex = 27;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cmbidClient
            // 
            this.cmbidClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.cmbidClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbidClient.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbidClient.FormattingEnabled = true;
            this.cmbidClient.Location = new System.Drawing.Point(242, 119);
            this.cmbidClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbidClient.Name = "cmbidClient";
            this.cmbidClient.Size = new System.Drawing.Size(218, 27);
            this.cmbidClient.TabIndex = 28;
            // 
            // cmbidDriver
            // 
            this.cmbidDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.cmbidDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbidDriver.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbidDriver.FormattingEnabled = true;
            this.cmbidDriver.Location = new System.Drawing.Point(242, 176);
            this.cmbidDriver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbidDriver.Name = "cmbidDriver";
            this.cmbidDriver.Size = new System.Drawing.Size(218, 27);
            this.cmbidDriver.TabIndex = 29;
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S.ForeColor = System.Drawing.Color.Black;
            this.S.Location = new System.Drawing.Point(116, 302);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(50, 21);
            this.S.TabIndex = 31;
            this.S.Text = "type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(150, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(116, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "victim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(96, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "urgency";
            // 
            // cmbVictim
            // 
            this.cmbVictim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.cmbVictim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVictim.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbVictim.FormattingEnabled = true;
            this.cmbVictim.Items.AddRange(new object[] {
            "client",
            "driver"});
            this.cmbVictim.Location = new System.Drawing.Point(241, 460);
            this.cmbVictim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVictim.Name = "cmbVictim";
            this.cmbVictim.Size = new System.Drawing.Size(218, 27);
            this.cmbVictim.TabIndex = 38;
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Conductora descortés",
            "La persona que aparece en la foto no es la misma que está conduciendo el vehículo" +
                "",
            "Vehículo en mal estado",
            "Mala conducción (no respeta leyes de tránsito)",
            "Auto sucio.",
            "Punto de partida poco seguro",
            "Distraído con el teléfono",
            "Conducción lenta"});
            this.cmbType.Location = new System.Drawing.Point(241, 307);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(218, 27);
            this.cmbType.TabIndex = 39;
            // 
            // cmbUrgency
            // 
            this.cmbUrgency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(46)))), ((int)(((byte)(178)))));
            this.cmbUrgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrgency.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbUrgency.FormattingEnabled = true;
            this.cmbUrgency.Items.AddRange(new object[] {
            "urgent",
            "minor"});
            this.cmbUrgency.Location = new System.Drawing.Point(241, 523);
            this.cmbUrgency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUrgency.Name = "cmbUrgency";
            this.cmbUrgency.Size = new System.Drawing.Size(218, 27);
            this.cmbUrgency.TabIndex = 40;
            // 
            // ModReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(700, 640);
            this.Controls.Add(this.cmbUrgency);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbVictim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.S);
            this.Controls.Add(this.cmbidDriver);
            this.Controls.Add(this.cmbidClient);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbdescription);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private ComboBox cmbstatus;
        public TextBox txtbdescription;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnMod;
        private Button btnDel;
        private ComboBox cmbidClient;
        private ComboBox cmbidDriver;
        private Label S;
        private Label label1;
        private Label label7;
        private Label label8;
        private ComboBox cmbVictim;
        private ComboBox cmbType;
        private ComboBox cmbUrgency;
    }
}