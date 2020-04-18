using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TextViever
{
    public partial class Prompter : Form
    {
        private string[] lines;
        public Prompter(string fileName)
        {
            InitializeComponent();
            lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "files", fileName));
            KeyPreview = true;
            KeyDown += new KeyEventHandler(Form2_KeyDown);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FontConverter fc = new FontConverter();
            SetText(0);
            if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "settings.data")))
                textShow.Font= (Font)fc.ConvertFromString(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "settings.data")));
        }

        public void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    if (index > 0)
                        SetText(-1);
                    break;
                case Keys.Right:
                    if (index + 1 < lines.Length)
                        SetText(1);
                    break;
                   
            }
            e.Handled = true;
        }
        int index = 0;
        private void SetText(int hm)
        {
            index += hm;
            textShow.Text = lines[index];
        }
    }
}
