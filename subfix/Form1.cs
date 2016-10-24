using System.IO;
using System.Windows.Forms;
using System.IO.Compression;
using System;
using System.Text;

namespace subfix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

            zirnevis sub = new zirnevis();
            string[] path = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string fof in path)
            {
                
               foreach(string file in Directory.GetFiles(fof, "*", SearchOption.AllDirectories))
                {                 
                    int adlen = file.Length;
                    string adstr = file.Substring(adlen - 3, 3);

                    if (adstr == "srt")
                        sub.FixIt(file);

                    else if (adstr == "zip")
                    {
                        sub.FixItzip(file);

                       
                    }
                }
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
