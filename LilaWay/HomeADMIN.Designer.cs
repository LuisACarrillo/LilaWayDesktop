namespace LilaWay
{
    partial class HomeADMIN
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
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnReportes = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnRegistros = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(234, 46);
            label3.Name = "label3";
            label3.Size = new Size(351, 21);
            label3.TabIndex = 6;
            label3.Text = "Bienvenido a Soporte Técnico LilaWay";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Mi_proyecto;
            pictureBox1.Location = new Point(291, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(50, 0, 50);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(25, 316);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(160, 53);
            btnReportes.TabIndex = 8;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(50, 0, 50);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(425, 316);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(160, 53);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Conductora";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(50, 0, 50);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(628, 316);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 53);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnRegistros
            // 
            btnRegistros.BackColor = Color.FromArgb(50, 0, 50);
            btnRegistros.FlatStyle = FlatStyle.Flat;
            btnRegistros.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistros.ForeColor = Color.White;
            btnRegistros.Location = new Point(212, 316);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(160, 53);
            btnRegistros.TabIndex = 12;
            btnRegistros.Text = "Registros";
            btnRegistros.UseVisualStyleBackColor = false;
            btnRegistros.Click += btnRegistros_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 0, 50);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(574, 110);
            button1.Name = "button1";
            button1.Size = new Size(160, 53);
            button1.TabIndex = 13;
            button1.Text = "Agregar Soporte";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // HomeADMIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(152, 84, 194);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnRegistros);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnReportes);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Name = "HomeADMIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeADMIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox1;
        private Button btnReportes;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnRegistros;
        private Button button1;
    }
}