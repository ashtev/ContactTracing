using System;
using System.IO;
using System.Windows.Forms;

namespace ContactTracing
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void DisplayInfo_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\Contacts\\" +
            FirstNameBox.Text + " " + LastNameB.Text + ".txt");
            ReadFile.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
