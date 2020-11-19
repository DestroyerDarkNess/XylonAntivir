using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Xylon_Antivir.Lxib;

namespace XylosAntivir_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Antivir Engine = new Antivir();

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog1.ShowDialog();
           
            if (result == DialogResult.OK)
            {
                listBox1.Items.Clear();
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles(textBox1.Text, "*.*", SearchOption.AllDirectories);
                // SearchOption.AllDirectories It is to search within all folders and sub folders. 
                // SearchOption.TopDirectoryOnly It is to search only within that folder and not sub folders

                foreach (string file in files)
                {
                    string FilePath = file;
                    string FileName = Path.GetFileName(file);

                    string ScanResult = Engine.FileScan(FilePath, true, false, true);

                    if (ScanResult != "False")
                    {

                        string[] VirusInfo = ScanResult.Split(@"|".ToCharArray());

                        string FilePathEx = VirusInfo[0];
                        string VirusDefinition = VirusInfo[1];

                        listBox1.Items.Add("Name: " + FileName + " Path : " + FilePathEx + " Sig: [" + VirusDefinition + "]");

                    }

                }

                label2.Text = Convert.ToString(listBox1.Items.Count);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Engine.Test();
        }

    }
}
