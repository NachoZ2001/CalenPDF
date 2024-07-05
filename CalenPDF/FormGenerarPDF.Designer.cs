namespace CalenPDF
{
    partial class FormGenerarPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerarPDF));
            btnConvertToPdf = new Button();
            btnSelectFiles = new Button();
            listBoxFiles = new ListBox();
            pictureBoxRuedaCargando = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRuedaCargando).BeginInit();
            SuspendLayout();
            // 
            // btnConvertToPdf
            // 
            btnConvertToPdf.BackColor = Color.BlueViolet;
            btnConvertToPdf.FlatStyle = FlatStyle.Flat;
            btnConvertToPdf.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvertToPdf.ForeColor = Color.White;
            btnConvertToPdf.Location = new Point(567, 130);
            btnConvertToPdf.Name = "btnConvertToPdf";
            btnConvertToPdf.Size = new Size(152, 63);
            btnConvertToPdf.TabIndex = 0;
            btnConvertToPdf.Text = "Convertir";
            btnConvertToPdf.UseVisualStyleBackColor = false;
            btnConvertToPdf.Click += btnConvertToPdf_Click;
            // 
            // btnSelectFiles
            // 
            btnSelectFiles.BackColor = Color.BlueViolet;
            btnSelectFiles.FlatStyle = FlatStyle.Flat;
            btnSelectFiles.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelectFiles.ForeColor = Color.White;
            btnSelectFiles.Location = new Point(567, 43);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(152, 63);
            btnSelectFiles.TabIndex = 1;
            btnSelectFiles.Text = "Seleccionar";
            btnSelectFiles.UseVisualStyleBackColor = false;
            btnSelectFiles.Click += btnSelectFiles_Click;
            // 
            // listBoxFiles
            // 
            listBoxFiles.BackColor = Color.BlueViolet;
            listBoxFiles.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxFiles.ForeColor = Color.White;
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.ItemHeight = 15;
            listBoxFiles.Location = new Point(22, 43);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(509, 274);
            listBoxFiles.TabIndex = 2;
            // 
            // pictureBoxRuedaCargando
            // 
            pictureBoxRuedaCargando.Image = (Image)resources.GetObject("pictureBoxRuedaCargando.Image");
            pictureBoxRuedaCargando.Location = new Point(579, 209);
            pictureBoxRuedaCargando.Name = "pictureBoxRuedaCargando";
            pictureBoxRuedaCargando.Size = new Size(128, 108);
            pictureBoxRuedaCargando.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRuedaCargando.TabIndex = 3;
            pictureBoxRuedaCargando.TabStop = false;
            // 
            // FormGenerarPDF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(770, 365);
            Controls.Add(pictureBoxRuedaCargando);
            Controls.Add(listBoxFiles);
            Controls.Add(btnSelectFiles);
            Controls.Add(btnConvertToPdf);
            Name = "FormGenerarPDF";
            Text = "FormGenerarPDF";
            ((System.ComponentModel.ISupportInitialize)pictureBoxRuedaCargando).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConvertToPdf;
        private Button btnSelectFiles;
        private ListBox listBoxFiles;
        private PictureBox pictureBoxRuedaCargando;
    }
}