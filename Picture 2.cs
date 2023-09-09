using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form4 : Form
    {
        List<string> fileNames = new List<string>();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                { 
                    fileNames.Clear();
                    listViewFile.Items.Clear();
                    foreach (string fileName in ofd.FileNames)
                    { 
                    FileInfo fi = new FileInfo(fileName);
                    fileNames.Add(fi.FullName);
                    listViewFile.Items.Add(fi.Name, 0);
                    } 
                }
            }
        }

        private void listViewFile_ItemActivate(object sender, EventArgs e)
        {
            if (listViewFile.FocusedItem != null)
            {
                using (frmViewer frm = new frmViewer())
                {
                    Image img = Image.FromFile(fileNames[listViewFile.FocusedItem.Index]);
                    frm.ImageBox = img;
                    frm.ShowDialog();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}
