using System;
using System.IO;
using System.Windows.Forms;

namespace ContactTracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Contacts\\" +
                FirstNameBox.Text + " " + LastNameBox.Text + ".txt");

            sw.WriteLine(fname.Text + " " + FirstNameBox.Text);
            sw.WriteLine(lname.Text + " " + LastNameBox.Text);
            sw.WriteLine(gender.Text + " " + GenderBox.Text);
            sw.WriteLine(age.Text + " " + AgeBox.Text);
            sw.WriteLine(contactnum.Text + " " + ContactBox.Text);
            sw.WriteLine(emailadd.Text + " " + EmailBox.Text);
            sw.WriteLine(addr.Text + " " + AddressBox.Text);
            sw.WriteLine(temp.Text + " " + TempBox.Text);
            System.Windows.Forms.MessageBox.Show("Information Saved!");
            sw.Close();

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FirstNameBox.Clear();
            LastNameBox.Clear();
            GenderBox.Text = string.Empty;
            AgeBox.Clear();
            ContactBox.Clear();
            EmailBox.Clear();
            AddressBox.Clear();
            TempBox.Clear();

        }

        private void View_Click_1(object sender, EventArgs e)
        {
            View form2 = new View();
            form2.ShowDialog();
        }
    }
}
