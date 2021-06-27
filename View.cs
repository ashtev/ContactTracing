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
        //To read saved file
        private void DisplayInfo_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\Contacts\\" +
            FirstNameBox.Text + " " + LastNameB.Text + ".txt");
            ReadFile.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LastNameBox_Click(object sender, EventArgs e)
        {

        }

        private void ReadFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
