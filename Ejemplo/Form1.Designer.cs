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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btoEnviar = new Button();
            Tabla = new DataGridView();
            lblId = new Label();
            lblNombre = new Label();
            lblDesc = new Label();
            lblPrec = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btoCon = new Button();
            btoAct = new Button();
            btoEli = new Button();
            btoSal = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // Tabla
            // 
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla.Location = new Point(168, 184);
            Tabla.Name = "Tabla";
            Tabla.RowTemplate.Height = 25;
            Tabla.Size = new Size(442, 150);
            Tabla.TabIndex = 2;
            Tabla.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.ForeColor = Color.Black;
            lblId.Location = new Point(58, 28);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 24);
            lblId.TabIndex = 3;
            lblId.Text = "ID";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(241, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 24);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.BackColor = Color.Transparent;
            lblDesc.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDesc.Location = new Point(437, 28);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(130, 24);
            lblDesc.TabIndex = 5;
            lblDesc.Text = "Descripcion";
            // 
            // lblPrec
            // 
            lblPrec.AutoSize = true;
            lblPrec.BackColor = Color.Transparent;
            lblPrec.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrec.Location = new Point(660, 28);
            lblPrec.Name = "lblPrec";
            lblPrec.Size = new Size(74, 24);
            lblPrec.TabIndex = 6;
            lblPrec.Text = "Precio";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(241, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(437, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(660, 67);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // btoCon
            // 
            btoCon.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btoCon.Location = new Point(168, 359);
            btoCon.Name = "btoCon";
            btoCon.Size = new Size(113, 29);
            btoCon.TabIndex = 12;
            btoCon.Text = "Consultar";
            btoCon.UseVisualStyleBackColor = true;
            btoCon.Click += button1_Click_1;
            // 
            // btoAct
            // 
            btoAct.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btoAct.Location = new Point(338, 359);
            btoAct.Name = "btoAct";
            btoAct.Size = new Size(117, 29);
            btoAct.TabIndex = 13;
            btoAct.Text = "Actualizar";
            btoAct.UseVisualStyleBackColor = true;
            btoAct.Click += btoAct_Click;
            // 
            // btoEli
            // 
            btoEli.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btoEli.Location = new Point(516, 359);
            btoEli.Name = "btoEli";
            btoEli.Size = new Size(94, 29);
            btoEli.TabIndex = 14;
            btoEli.Text = "Eliminar";
            btoEli.UseVisualStyleBackColor = true;
            btoEli.Click += btoEli_Click;
            // 
            // btoSal
            // 
            btoSal.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btoSal.Location = new Point(697, 409);
            btoSal.Name = "btoSal";
            btoSal.Size = new Size(91, 29);
            btoSal.TabIndex = 15;
            btoSal.Text = "Salir";
            btoSal.UseVisualStyleBackColor = true;
            btoSal.Click += btoSal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(797, 445);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btoSal);
            Controls.Add(btoEli);
            Controls.Add(btoAct);
            Controls.Add(btoCon);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblPrec);
            Controls.Add(lblDesc);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(Tabla);
            Controls.Add(btoEnviar);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btoEnviar;
        private Label lblId;
        private Label lblNombre;
        private Label lblDesc;
        private Label lblPrec;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        public Label label1;
        public DataGridView Tabla;
        private Button btoCon;
        private Button btoAct;
        private Button btoEli;
        private Button btoSal;
        private PictureBox pictureBox1;
    }
}