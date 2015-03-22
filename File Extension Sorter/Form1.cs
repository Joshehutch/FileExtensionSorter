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

namespace File_Extension_Sorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 544;
        }

        private bool sourceSelected = false;
        private bool destSelected = false;
        private List<string> commonFileExt = new List<string>(){"txt", "doc", "docx", "odt", "msg", "rtf", "pps", "ppt", "pptx", "rar", "m3u",
                                                                "m4a", " mp3", "wma", "avi", "flv", "flv", "m4v", "mov", "mp4", "mpg", "swf",
                                                                "wmv", "bmp", "gif", "jpg", "png", "png", "psd", "tif", "tiff", "xls", "xlsx",
                                                                "db", "exe", "7z", "rar", "zip", "msi"};

        private void SorceBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browsedPath = new FolderBrowserDialog();
            DialogResult result = browsedPath.ShowDialog();
            if (result == DialogResult.OK && Directory.Exists(browsedPath.SelectedPath))
            {
                SourcePath.Text = browsedPath.SelectedPath;
                sourceSelected = true;
            }
            else if (result == DialogResult.OK && Directory.Exists(browsedPath.SelectedPath) == false)
            {
                MessageBox.Show("The specified folder is invalid");
                sourceSelected = false;
            }
        }

        private void DestBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browsedPath = new FolderBrowserDialog();
            DialogResult result = browsedPath.ShowDialog();
            if (result == DialogResult.OK && Directory.Exists(browsedPath.SelectedPath))
            {
                DestPath.Text = browsedPath.SelectedPath;
                destSelected = true;

            }
            else if (result == DialogResult.OK && Directory.Exists(browsedPath.SelectedPath) == false)
            {
                MessageBox.Show("The specified folder is invalid");
                destSelected = false;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Width = 646;
            moveCounter = 0;
            Sorter();
        }
        private int moveCounter = 0;

        private async void Sorter()
        {
            if(destSelected != true || sourceSelected != true)
            {
                MessageBox.Show("The Source or Destination Paths are invalid");
                return;
            }
            else
            {
                List<string> files = Directory.GetFiles(SourcePath.Text, "*", SearchOption.AllDirectories).ToList();
                TotalFileCounter.Text = files.Count.ToString();
                List<string> extensions = new List<string>();
                foreach(string file in files)
                {
                    if (Path.GetExtension(file) != "")
                    {
                        if (extensions.Contains(Path.GetExtension(file)) == false && 
                            commonFileExt.Contains(Path.GetExtension(file).ToString().ToLower().Substring(1, Path.GetExtension(file).ToString().Length - 1)))
                        {
                            extensions.Add(Path.GetExtension(file).Substring(1, 3).ToLower());
                        }
                    }
                }

                foreach(string ext in extensions)
                {
                    Directory.CreateDirectory(Path.Combine(DestPath.Text, ext));
                }
                string placeHolder = "";
                string extension = "";
                foreach(string file in files)
                {
                    if (Path.GetExtension(file) != "")
                    {
                        extension = Path.GetExtension(file).Remove(0,1);
                        if (extensions.Contains(extension))
                        {
                            placeHolder = Path.Combine(DestPath.Text, extension, Path.GetFileName(file));
                            if (File.Exists(placeHolder))
                            {
                                
                                int counter = 2;
                                while (File.Exists(placeHolder))
                                {
                                    placeHolder = String.Format(placeHolder + " ({0})", counter);
                                    counter++;
                                }
                            }

                            File.Copy(file, placeHolder);
                            while (File.Exists(placeHolder) == false)
                                await delay(10);
                            moveCounter++;

                            this.Invoke((MethodInvoker)delegate()
                               {
                                   CurrentFileCounter.Text = moveCounter.ToString();

                               });
                        }
                    }
                }
            }
            this.Width = 544;
            MessageBox.Show("Finished!" + Environment.NewLine + "Moved " + moveCounter.ToString() + " Files");
        }

        private async Task delay(int time)
        {
            await Task.Delay(time);
        }
    }
}
