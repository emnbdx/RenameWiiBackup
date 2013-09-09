using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace RenameWiiBackup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            bool flag = this.openFileDialog1.ShowDialog() != DialogResult.OK;
            if (!flag)
            {
                this.tbFile.Text = this.openFileDialog1.FileName;
            }
        }

        private void btnBrowserFolder_Click(object sender, EventArgs e)
        {
            bool flag = this.folderBrowserDialog1.ShowDialog() != DialogResult.OK;
            if (!flag)
            {
                this.tbFolder.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            bool flag;
            if (string.IsNullOrEmpty(this.tbFile.Text))
            {
                flag = true;
            }
            else
            {
                flag = string.IsNullOrEmpty(this.tbFolder.Text);
            }
            bool endOfStream = flag;
            if (!endOfStream)
            {
                Dictionary<string, string> idGame = new Dictionary<string, string>();
                StreamReader sr = new StreamReader(this.tbFile.Text);
                try
                {
                    while (true)
                    {
                        endOfStream = !sr.EndOfStream;
                        if (!endOfStream)
                        {
                            break;
                        }
                        string tmp = sr.ReadLine();
                        char[] chrArray = new char[1];
                        chrArray[0] = '=';
                        string[] value = tmp.Split(chrArray);
                        idGame.Add(value[0].Trim(), value[1].Trim());
                    }
                }
                finally
                {
                    endOfStream = sr == null;
                    if (!endOfStream)
                    {
                        sr.Dispose();
                    }
                }
                DirectoryInfo di = new DirectoryInfo(this.tbFolder.Text);
                FileInfo[] files = di.GetFiles("*.wbfs");
                this.Rename(idGame, files);
                files = di.GetFiles("*.wbf1");
                this.Rename(idGame, files);
                files = di.GetFiles("*.wbf2");
                this.Rename(idGame, files);
                files = di.GetFiles("*.iso");
                this.Rename(idGame, files);
            }
        }

        protected override void Dispose(bool disposing)
        {
            bool flag;
            if (!disposing)
            {
                flag = true;
            }
            else
            {
                flag = this.components == null;
            }
            bool flag1 = flag;
            if (!flag1)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private string GetNewRename(Dictionary<string, string> idGame, FileInfo file)
        {
            string str;
            string id = Path.GetFileNameWithoutExtension(file.Name);
            bool flag = idGame.ContainsKey(id);
            if (flag)
            {
                string regexSearch = string.Concat(new string(Path.GetInvalidFileNameChars()), new string(Path.GetInvalidPathChars()));
                Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
                string[] item = new string[5];
                item[0] = idGame[id];
                item[1] = " [";
                item[2] = id;
                item[3] = "]";
                item[4] = Path.GetExtension(file.Name);
                string tmpName = string.Concat(item);
                string newName = r.Replace(tmpName, "").Replace("  ", " ");
                str = newName;
            }
            else
            {
                str = null;
            }
            return str;
        }

        private void Rename(Dictionary<string, string> idGame, FileInfo[] files)
        {
            FileInfo[] fileInfoArray = files;
            int num = 0;
            while (true)
            {
                bool length = num < (int)fileInfoArray.Length;
                if (!length)
                {
                    break;
                }
                FileInfo file = fileInfoArray[num];
                string newName = this.GetNewRename(idGame, file);
                length = !string.IsNullOrEmpty(newName);
                if (length)
                {
                    file.MoveTo(Path.Combine(file.DirectoryName, newName));
                }
                num++;
            }
        }
    }
}
