namespace CalenPDF
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
            menuStrip1 = new MenuStrip();
            menuItemCrearInformes = new ToolStripMenuItem();
            menuItemGenerarPDFs = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkMagenta;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuItemCrearInformes, menuItemGenerarPDFs });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(731, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuItemCrearInformes
            // 
            menuItemCrearInformes.BackColor = Color.Transparent;
            menuItemCrearInformes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuItemCrearInformes.ForeColor = Color.White;
            menuItemCrearInformes.Name = "menuItemCrearInformes";
            menuItemCrearInformes.Size = new Size(142, 21);
            menuItemCrearInformes.Text = "Generar calendarios";
            menuItemCrearInformes.Click += generarCalendariosToolStripMenuItem_Click;
            // 
            // menuItemGenerarPDFs
            // 
            menuItemGenerarPDFs.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuItemGenerarPDFs.ForeColor = Color.White;
            menuItemGenerarPDFs.Name = "menuItemGenerarPDFs";
            menuItemGenerarPDFs.Size = new Size(117, 21);
            menuItemGenerarPDFs.Text = "Convertir a PDF";
            menuItemGenerarPDFs.Click += menuItemGenerarPDFs_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(639, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(731, 297);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuItemCrearInformes;
        private ToolStripMenuItem menuItemGenerarPDFs;
        private PictureBox pictureBox1;
    }
}