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
            txtbID = new TextBox();
            label3 = new Label();
            cmbstatus = new ComboBox();
            txtbdescription = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnMod = new Button();
            btnDel = new Button();
            cmbidClient = new ComboBox();
            cmbidDriver = new ComboBox();
            S = new Label();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbVictim = new ComboBox();
            cmbType = new ComboBox();
            cmbUrgency = new ComboBox();
            SuspendLayout();
            // 
            // txtbID
            // 
            txtbID.BackColor = Color.FromArgb(165, 46, 178);
            txtbID.BorderStyle = BorderStyle.None;
            txtbID.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbID.ForeColor = Color.White;
            txtbID.Location = new Point(242, 58);
            txtbID.Name = "txtbID";
            txtbID.ReadOnly = true;
            txtbID.Size = new Size(217, 18);
            txtbID.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(257, 20);
            label3.Name = "label3";
            label3.Size = new Size(171, 21);
            label3.TabIndex = 16;
            label3.Text = "Modificar Reporte";
            // 
            // cmbstatus
            // 
            cmbstatus.BackColor = Color.FromArgb(165, 46, 178);
            cmbstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbstatus.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Items.AddRange(new object[] { "open", "closed" });
            cmbstatus.Location = new Point(242, 238);
            cmbstatus.Margin = new Padding(3, 2, 3, 2);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(218, 27);
            cmbstatus.TabIndex = 20;
            // 
            // txtbdescription
            // 
            txtbdescription.BackColor = Color.FromArgb(165, 46, 178);
            txtbdescription.BorderStyle = BorderStyle.None;
            txtbdescription.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbdescription.ForeColor = Color.White;
            txtbdescription.Location = new Point(243, 392);
            txtbdescription.Multiline = true;
            txtbdescription.Name = "txtbdescription";
            txtbdescription.Size = new Size(217, 42);
            txtbdescription.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(116, 119);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 22;
            label2.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(81, 182);
            label4.Name = "label4";
            label4.Size = new Size(114, 21);
            label4.TabIndex = 23;
            label4.Text = "Conductora";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(119, 238);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 24;
            label5.Text = "Estatus";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(83, 392);
            label6.Name = "label6";
            label6.Size = new Size(118, 21);
            label6.TabIndex = 25;
            label6.Text = "Descripción";
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.FromArgb(50, 0, 50);
            btnMod.FlatStyle = FlatStyle.Flat;
            btnMod.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMod.ForeColor = Color.White;
            btnMod.Location = new Point(257, 575);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(189, 53);
            btnMod.TabIndex = 26;
            btnMod.Text = "Agregar";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btnMod_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(50, 0, 50);
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(528, 575);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(160, 53);
            btnDel.TabIndex = 27;
            btnDel.Text = "Eliminar";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // cmbidClient
            // 
            cmbidClient.BackColor = Color.FromArgb(165, 46, 178);
            cmbidClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbidClient.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbidClient.FormattingEnabled = true;
            cmbidClient.Location = new Point(242, 119);
            cmbidClient.Margin = new Padding(3, 2, 3, 2);
            cmbidClient.Name = "cmbidClient";
            cmbidClient.Size = new Size(218, 27);
            cmbidClient.TabIndex = 28;
            // 
            // cmbidDriver
            // 
            cmbidDriver.BackColor = Color.FromArgb(165, 46, 178);
            cmbidDriver.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbidDriver.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbidDriver.FormattingEnabled = true;
            cmbidDriver.Location = new Point(242, 176);
            cmbidDriver.Margin = new Padding(3, 2, 3, 2);
            cmbidDriver.Name = "cmbidDriver";
            cmbidDriver.Size = new Size(218, 27);
            cmbidDriver.TabIndex = 29;
            // 
            // S
            // 
            S.AutoSize = true;
            S.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            S.ForeColor = Color.Black;
            S.Location = new Point(141, 307);
            S.Name = "S";
            S.Size = new Size(50, 21);
            S.TabIndex = 31;
            S.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(150, 55);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 32;
            label1.Text = "id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(116, 466);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 35;
            label7.Text = "Víctima";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(96, 523);
            label8.Name = "label8";
            label8.Size = new Size(91, 21);
            label8.TabIndex = 36;
            label8.Text = "Urgencia";
            label8.Click += label8_Click;
            // 
            // cmbVictim
            // 
            cmbVictim.BackColor = Color.FromArgb(165, 46, 178);
            cmbVictim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVictim.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbVictim.FormattingEnabled = true;
            cmbVictim.Items.AddRange(new object[] { "client", "driver" });
            cmbVictim.Location = new Point(241, 460);
            cmbVictim.Margin = new Padding(3, 2, 3, 2);
            cmbVictim.Name = "cmbVictim";
            cmbVictim.Size = new Size(218, 27);
            cmbVictim.TabIndex = 38;
            // 
            // cmbType
            // 
            cmbType.BackColor = Color.FromArgb(165, 46, 178);
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Conductora descortés", "La persona que aparece en la foto no es la misma que está conduciendo el vehículo", "Vehículo en mal estado", "Mala conducción (no respeta leyes de tránsito)", "Auto sucio.", "Punto de partida poco seguro", "Distraído con el teléfono", "Conducción lenta" });
            cmbType.Location = new Point(241, 307);
            cmbType.Margin = new Padding(3, 2, 3, 2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(218, 27);
            cmbType.TabIndex = 39;
            // 
            // cmbUrgency
            // 
            cmbUrgency.BackColor = Color.FromArgb(165, 46, 178);
            cmbUrgency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUrgency.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbUrgency.FormattingEnabled = true;
            cmbUrgency.Items.AddRange(new object[] { "urgent", "minor" });
            cmbUrgency.Location = new Point(241, 523);
            cmbUrgency.Margin = new Padding(3, 2, 3, 2);
            cmbUrgency.Name = "cmbUrgency";
            cmbUrgency.Size = new Size(218, 27);
            cmbUrgency.TabIndex = 40;
            // 
            // ModReportesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 217, 255);
            ClientSize = new Size(700, 640);
            Controls.Add(cmbUrgency);
            Controls.Add(cmbType);
            Controls.Add(cmbVictim);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(S);
            Controls.Add(cmbidDriver);
            Controls.Add(cmbidClient);
            Controls.Add(btnDel);
            Controls.Add(btnMod);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtbdescription);
            Controls.Add(cmbstatus);
            Controls.Add(label3);
            Controls.Add(txtbID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ModReportesForm";
            Text = "Modificar Reporte";
            FormClosed += ModReportesForm_FormClosed;
            Load += ModReportesForm_Load;
            ResumeLayout(false);
            PerformLayout();
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