namespace Ejemplo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btoEnviar = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            lblId = new Label();
            lblNombre = new Label();
            lblDesc = new Label();
            lblPrec = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btoEnviar
            // 
            btoEnviar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btoEnviar.Location = new Point(355, 125);
            btoEnviar.Name = "btoEnviar";
            btoEnviar.Size = new Size(91, 29);
            btoEnviar.TabIndex = 0;
            btoEnviar.Text = "Enviar";
            btoEnviar.UseVisualStyleBackColor = true;
            btoEnviar.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Descripcion, Precio });
            dataGridView1.Location = new Point(159, 276);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(442, 150);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(140, 28);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 24);
            lblId.TabIndex = 3;
            lblId.Text = "ID";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(263, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 24);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDesc.Location = new Point(410, 28);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(130, 24);
            lblDesc.TabIndex = 5;
            lblDesc.Text = "Descripcion";
            // 
            // lblPrec
            // 
            lblPrec.AutoSize = true;
            lblPrec.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrec.Location = new Point(571, 28);
            lblPrec.Name = "lblPrec";
            lblPrec.Size = new Size(74, 24);
            lblPrec.TabIndex = 6;
            lblPrec.Text = "Precio";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(263, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(417, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(561, 67);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblPrec);
            Controls.Add(lblDesc);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(dataGridView1);
            Controls.Add(btoEnviar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btoEnviar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private Label lblId;
        private Label lblNombre;
        private Label lblDesc;
        private Label lblPrec;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}