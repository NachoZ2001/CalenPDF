using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Spire.Xls;
using System.IO;


namespace CalenPDF
{
    public partial class FormGenerarPDF : Form
    {

        private List<string> excelFiles;

        public FormGenerarPDF()
        {
            InitializeComponent();

            excelFiles = new List<string>();

            // Establecer el estilo del borde y deshabilitar el cambio de tamaño
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Establecer el tamaño mínimo y máximo para evitar el cambio de tamaño
            this.MinimumSize = this.MaximumSize = this.Size;

            pictureBoxRuedaCargando.Visible = false;
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Excel Files|*.xlsx;*.xls"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                excelFiles.AddRange(openFileDialog.FileNames);
                foreach (var file in openFileDialog.FileNames)
                {
                    listBoxFiles.Items.Add(file);
                }
            }
        }

        private async void btnConvertToPdf_Click(object sender, EventArgs e)
        {
            pictureBoxRuedaCargando.Visible = true;

            foreach (var excelFile in excelFiles)
            {
                await Task.Run(() => ConvertExcelToPdf(excelFile));
            }

            pictureBoxRuedaCargando.Visible = false;

            MessageBox.Show("Conversion completada");
        }

        private void ConvertExcelToPdf(string excelFilePath)
        {
            // Load the Excel file
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(excelFilePath);

            // Set PDF save options
            workbook.ConverterSetting.SheetFitToPage = true;
            foreach (Worksheet sheet in workbook.Worksheets)
            {
                sheet.PageSetup.Orientation = PageOrientationType.Landscape;
            }

            // Define the output PDF file path
            string pdfFolder = Path.Combine(Path.GetDirectoryName(excelFilePath), "PDF");
            Directory.CreateDirectory(pdfFolder); // Create the PDF folder if it doesn't exist
            string pdfFileName = Path.GetFileNameWithoutExtension(excelFilePath) + ".pdf";
            string pdfFilePath = Path.Combine(pdfFolder, pdfFileName);

            // Save the Excel file as PDF
            workbook.SaveToFile(pdfFilePath, Spire.Xls.FileFormat.PDF);
        }
    }
}
