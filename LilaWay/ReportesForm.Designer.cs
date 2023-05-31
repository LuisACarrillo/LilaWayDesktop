namespace LilaWay
{
    partial class ReportesForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            idClient = new DataGridViewTextBoxColumn();
            idDriver = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            victim = new DataGridViewTextBoxColumn();
            urgency = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            textBox1 = new TextBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(243, 217, 255);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(152, 84, 194);
            dataGridViewCellStyle1.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, idClient, idDriver, status, type, description, victim, urgency });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(152, 84, 194);
            dataGridViewCellStyle2.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(0, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(152, 84, 194);
            dataGridViewCellStyle3.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(152, 84, 194);
            dataGridViewCellStyle4.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(900, 468);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // idClient
            // 
            idClient.HeaderText = "Cliente";
            idClient.MinimumWidth = 6;
            idClient.Name = "idClient";
            idClient.ReadOnly = true;
            // 
            // idDriver
            // 
            idDriver.HeaderText = "Conductora";
            idDriver.MinimumWidth = 6;
            idDriver.Name = "idDriver";
            idDriver.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Estatus";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            status.Resizable = DataGridViewTriState.True;
            status.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // type
            // 
            type.HeaderText = "Tipo";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.ReadOnly = true;
            // 
            // description
            // 
            description.HeaderText = "Descripción";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // victim
            // 
            victim.HeaderText = "Victima";
            victim.Name = "victim";
            victim.ReadOnly = true;
            // 
            // urgency
            // 
            urgency.HeaderText = "Urgencia";
            urgency.Name = "urgency";
            urgency.ReadOnly = true;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(50, 0, 50);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnSearch.Location = new Point(735, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(165, 28);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese un correo";
            textBox1.Size = new Size(729, 26);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(50, 0, 50);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(740, 508);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 53);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // ReportesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 217, 255);
            ClientSize = new Size(901, 559);
            Controls.Add(btnAdd);
            Controls.Add(textBox1);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Name = "ReportesForm";
            Text = "Reportes";
            Load += ReportesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSearch;
        private TextBox textBox1;
        private Button btnAdd;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn idClient;
        private DataGridViewTextBoxColumn idDriver;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn victim;
        private DataGridViewTextBoxColumn urgency;
    }
}