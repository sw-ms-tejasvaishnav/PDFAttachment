using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDFWithEmbadedFile_POC
{
    public partial class MainWindow : Form
    {
        public string Filter
        {
            get
            {
                return "All Supported Type|*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx;*.pdf;*.txt;*.rtf;*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|"
                    + "Word|*.doc;*.docx|"
                        + "Excel|*.xls;*.xlsx|"
                        + "PPT|*.ppt;*.pptx|"
                        + "PDF|*.pdf|"
                        + "Text|*.txt|"
                        + "RTF|*.rtf|"
                    + "Image|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            }
        }

        public string SaveFileExt
        {
            get
            {
                return "PDF|*.pdf";
            }
        }
        public List<string> FilterExt
        {
            get
            {
                return new List<string>(new string[]{".doc",".docx",".xls",".xlsx",".ppt",".pptx",".pdf",".txt",".rtf",
                    ".bmp",".jpg",".jpeg",".png",".tif",".tiff"});
            }
        }

        public string[] SelectedFiles { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            opfDialog.Multiselect = true;//false;
            opfDialog.Filter = Filter;
            sfDialog.Filter = SaveFileExt;
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            var result = opfDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //txtFilePath.Text = opfDialog.FileName;
                SelectedFiles = opfDialog.FileNames;
                lstSelectedFiles.DataSource = SelectedFiles;
                return;
            }
            MessageBox.Show("Please select a file to procees");
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            var result = sfDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtOutputFile.Text = sfDialog.FileName;
                return;
            }
            MessageBox.Show("Please select location to save output file");
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Core core = new Core();
            string password = txtpassword.Text;
            if (string.IsNullOrWhiteSpace(password))
                password = "1";
            //core.CreatePDFFile(txtOutputFile.Text, txtFilePath.Text, txtpassword.Text);
            core.CreatePDFFile(txtOutputFile.Text, SelectedFiles, txtpassword.Text);
            OpenFolder(txtOutputFile.Text);
        }

        private void OpenFolder(string folder)
        {
            if (File.GetAttributes(folder).HasFlag(FileAttributes.Directory))
            {
                try
                {
                    Process.Start("explorer.exe", folder);
                }
                catch { }

            }
            else
            {
                folder = Path.GetDirectoryName(folder);
                try
                {
                    Process.Start("explorer.exe", folder);
                }
                catch { }
            }

        }


    }
}
