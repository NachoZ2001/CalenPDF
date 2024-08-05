namespace CalenPDF
{
    partial class FormCalendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendario));
            btnSelectFiles = new Button();
            button1 = new Button();
            textBoxExcel = new TextBox();
            textBoxPeriodo = new TextBox();
            textBoxNombre = new TextBox();
            textBoxTitulo = new TextBox();
            textBoxPeriodoInforme = new TextBox();
            textBoxRutaExcel = new TextBox();
            pictureBoxRuedaCargando = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRuedaCargando).BeginInit();
            SuspendLayout();
            // 
            // btnSelectFiles
            // 
            btnSelectFiles.BackColor = Color.BlueViolet;
            btnSelectFiles.FlatStyle = FlatStyle.Flat;
            btnSelectFiles.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelectFiles.ForeColor = Color.White;
            btnSelectFiles.Location = new Point(433, 29);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(143, 38);
            btnSelectFiles.TabIndex = 0;
            btnSelectFiles.Text = "Seleccionar Excel";
            btnSelectFiles.UseVisualStyleBackColor = false;
            btnSelectFiles.Click += btnSelectFiles_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.BlueViolet;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(433, 101);
            button1.Name = "button1";
            button1.Size = new Size(143, 38);
            button1.TabIndex = 1;
            button1.Text = "Procesar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxExcel
            // 
            textBoxExcel.BackColor = Color.BlueViolet;
            textBoxExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxExcel.ForeColor = Color.White;
            textBoxExcel.Location = new Point(31, 38);
            textBoxExcel.Name = "textBoxExcel";
            textBoxExcel.Size = new Size(326, 23);
            textBoxExcel.TabIndex = 2;
            // 
            // textBoxPeriodo
            // 
            textBoxPeriodo.BackColor = Color.BlueViolet;
            textBoxPeriodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPeriodo.ForeColor = Color.White;
            textBoxPeriodo.Location = new Point(31, 110);
            textBoxPeriodo.Name = "textBoxPeriodo";
            textBoxPeriodo.Size = new Size(326, 23);
            textBoxPeriodo.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.BlueViolet;
            textBoxNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxNombre.ForeColor = Color.White;
            textBoxNombre.Location = new Point(31, 187);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(326, 23);
            textBoxNombre.TabIndex = 4;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.BackColor = Color.Purple;
            textBoxTitulo.BorderStyle = BorderStyle.None;
            textBoxTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTitulo.ForeColor = Color.White;
            textBoxTitulo.Location = new Point(31, 163);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(127, 18);
            textBoxTitulo.TabIndex = 5;
            textBoxTitulo.Text = "Título del informe";
            // 
            // textBoxPeriodoInforme
            // 
            textBoxPeriodoInforme.BackColor = Color.Purple;
            textBoxPeriodoInforme.BorderStyle = BorderStyle.None;
            textBoxPeriodoInforme.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPeriodoInforme.ForeColor = Color.White;
            textBoxPeriodoInforme.Location = new Point(31, 86);
            textBoxPeriodoInforme.Name = "textBoxPeriodoInforme";
            textBoxPeriodoInforme.Size = new Size(198, 18);
            textBoxPeriodoInforme.TabIndex = 6;
            textBoxPeriodoInforme.Text = "Periodo (solo mes, ejemplo: 08)";
            // 
            // textBoxRutaExcel
            // 
            textBoxRutaExcel.BackColor = Color.Purple;
            textBoxRutaExcel.BorderStyle = BorderStyle.None;
            textBoxRutaExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxRutaExcel.ForeColor = Color.White;
            textBoxRutaExcel.Location = new Point(31, 14);
            textBoxRutaExcel.Name = "textBoxRutaExcel";
            textBoxRutaExcel.Size = new Size(127, 18);
            textBoxRutaExcel.TabIndex = 7;
            textBoxRutaExcel.Text = "Ruta del archivo";
            // 
            // pictureBoxRuedaCargando
            // 
            pictureBoxRuedaCargando.Image = (Image)resources.GetObject("pictureBoxRuedaCargando.Image");
            pictureBoxRuedaCargando.Location = new Point(445, 163);
            pictureBoxRuedaCargando.Name = "pictureBoxRuedaCargando";
            pictureBoxRuedaCargando.Size = new Size(106, 86);
            pictureBoxRuedaCargando.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRuedaCargando.TabIndex = 8;
            pictureBoxRuedaCargando.TabStop = false;
            // 
            // FormCalendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(598, 261);
            Controls.Add(pictureBoxRuedaCargando);
            Controls.Add(textBoxRutaExcel);
            Controls.Add(textBoxPeriodoInforme);
            Controls.Add(textBoxTitulo);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxPeriodo);
            Controls.Add(textBoxExcel);
            Controls.Add(button1);
            Controls.Add(btnSelectFiles);
            Name = "FormCalendario";
            Text = "FormCalendario";
            ((System.ComponentModel.ISupportInitialize)pictureBoxRuedaCargando).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFiles;
        private Button button1;
        private TextBox textBoxExcel;
        private TextBox textBoxPeriodo;
        private TextBox textBoxNombre;
        private TextBox textBoxTitulo;
        private TextBox textBoxPeriodoInforme;
        private TextBox textBoxRutaExcel;
        private PictureBox pictureBoxRuedaCargando;
    }
}