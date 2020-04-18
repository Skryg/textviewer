using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TextViever
{
    public partial class TextViewer : Form
    {
        public TextViewer()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt";
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Multiselect = true;

            updateList();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            DialogResult fileResult = openFileDialog1.ShowDialog();
            if(fileResult == DialogResult.OK)
            {
                string[] files = openFileDialog1.FileNames;
                
                for(int i=0; i<files.Length; i++)
                {
                    string pth = Path.Combine(Directory.GetCurrentDirectory(), "files", Path.GetFileName(files[i]));
                    File.Copy(files[i], pth, true);
                }

                updateList();    
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            FontConverter fc = new FontConverter();
            if(File.Exists(Path.Combine(path, "settings.data")))
                fontDialog1.Font = (Font)fc.ConvertFromString(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "settings.data")));
            DialogResult fontResult = fontDialog1.ShowDialog();
            if(fontResult == DialogResult.OK)
            {              
                string font = fc.ConvertToString(fontDialog1.Font);
                
                
                File.WriteAllText(Path.Combine(path,"settings.data"), font);
            }
        }

        private void updateList()
        {
            string pth = Path.Combine(Directory.GetCurrentDirectory(), "files");
            if (!Directory.Exists(pth))
                Directory.CreateDirectory(pth);
            string[] files = Directory.GetFiles(pth, "*.txt");
            
            fileList.Items.Clear();
            for(int i=0; i<files.Length; i++)
            {
                fileList.Items.Add(Path.GetFileName(files[i]));
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(fileList.SelectedItem!=null)
            {
                File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "files", fileList.SelectedItem.ToString())); 
            }
            updateList();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if(fileList.SelectedItem!=null)
            {
                if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "files", fileList.SelectedItem.ToString())))
                {
                    Prompter form = new Prompter(fileList.SelectedItem.ToString());
                    form.Show();
                }
                else
                    updateList();
            }
        }
    }
}
