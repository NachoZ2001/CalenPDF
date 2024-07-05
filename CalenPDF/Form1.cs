namespace CalenPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Establecer el estilo del borde y deshabilitar el cambio de tamaño
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Establecer el tamaño mínimo y máximo para evitar el cambio de tamaño
            this.MinimumSize = this.MaximumSize = this.Size;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            // Inicializa el MenuStrip
            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem menuItemCrearInformes = new ToolStripMenuItem("Crear Informes");
            ToolStripMenuItem menuItemGenerarPDFs = new ToolStripMenuItem("Generar PDFs");

            menuItemCrearInformes.Click += generarCalendariosToolStripMenuItem_Click;
            menuItemGenerarPDFs.Click += menuItemGenerarPDFs_Click;

            menuStrip.Items.Add(menuItemCrearInformes);
            menuStrip.Items.Add(menuItemGenerarPDFs);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        private void generarCalendariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalendario formCalendario = new FormCalendario();
            formCalendario.Show();
        }

        private void menuItemGenerarPDFs_Click(object sender, EventArgs e)
        {
            FormGenerarPDF formGenerarPDF = new FormGenerarPDF();
            formGenerarPDF.Show();
        }
    }
}