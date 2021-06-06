
namespace ContactTracing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.contactnum = new System.Windows.Forms.Label();
            this.addr = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.ContactBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.emailadd = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.temp = new System.Windows.Forms.Label();
            this.TempBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(42, 53);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(60, 13);
            this.fname.TabIndex = 0;
            this.fname.Text = "First Name:";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(42, 81);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(61, 13);
            this.lname.TabIndex = 0;
            this.lname.Text = "Last Name:";
            // 
            // contactnum
            // 
            this.contactnum.AutoSize = true;
            this.contactnum.Location = new System.Drawing.Point(42, 166);
            this.contactnum.Name = "contactnum";
            this.contactnum.Size = new System.Drawing.Size(87, 13);
            this.contactnum.TabIndex = 0;
            this.contactnum.Text = "Contact Number:";
            // 
            // addr
            // 
            this.addr.AutoSize = true;
            this.addr.Location = new System.Drawing.Point(42, 225);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(48, 13);
            this.addr.TabIndex = 0;
            this.addr.Text = "Address:";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(42, 137);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(29, 13);
            this.age.TabIndex = 0;
            this.age.Text = "Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Covid-19 Contact Tracing Form";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(145, 50);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(151, 20);
            this.FirstNameBox.TabIndex = 1;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(145, 78);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(151, 20);
            this.LastNameBox.TabIndex = 2;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(145, 136);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(58, 20);
            this.AgeBox.TabIndex = 2;
            // 
            // ContactBox
            // 
            this.ContactBox.Location = new System.Drawing.Point(146, 162);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(151, 20);
            this.ContactBox.TabIndex = 2;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(145, 225);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(151, 79);
            this.AddressBox.TabIndex = 2;
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderBox.Location = new System.Drawing.Point(145, 109);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(81, 21);
            this.GenderBox.TabIndex = 3;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(43, 112);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(42, 13);
            this.gender.TabIndex = 0;
            this.gender.Text = "Gender";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(145, 351);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // emailadd
            // 
            this.emailadd.AutoSize = true;
            this.emailadd.Location = new System.Drawing.Point(42, 198);
            this.emailadd.Name = "emailadd";
            this.emailadd.Size = new System.Drawing.Size(76, 13);
            this.emailadd.TabIndex = 0;
            this.emailadd.Text = "Email Address:";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(146, 195);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(151, 20);
            this.EmailBox.TabIndex = 2;
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Location = new System.Drawing.Point(43, 316);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(90, 13);
            this.temp.TabIndex = 0;
            this.temp.Text = "Temperature (°C):";
            // 
            // TempBox
            // 
            this.TempBox.Location = new System.Drawing.Point(145, 313);
            this.TempBox.Name = "TempBox";
            this.TempBox.Size = new System.Drawing.Size(58, 20);
            this.TempBox.TabIndex = 2;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(145, 379);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(146, 408);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 7;
            this.View.Text = "View Info";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 436);
            this.Controls.Add(this.View);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.TempBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.age);
            this.Controls.Add(this.emailadd);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.contactnum);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Covid-19 Contact Tracing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label contactnum;
        private System.Windows.Forms.Label addr;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.TextBox ContactBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label emailadd;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.TextBox TempBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button View;
    }
}

