
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.note = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.BackColor = System.Drawing.Color.Transparent;
            this.fname.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fname.Location = new System.Drawing.Point(26, 81);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(78, 16);
            this.fname.TabIndex = 0;
            this.fname.Text = "First Name:";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.BackColor = System.Drawing.Color.Transparent;
            this.lname.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lname.Location = new System.Drawing.Point(252, 81);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(76, 16);
            this.lname.TabIndex = 0;
            this.lname.Text = "Last Name:";
            // 
            // contactnum
            // 
            this.contactnum.AutoSize = true;
            this.contactnum.BackColor = System.Drawing.Color.Transparent;
            this.contactnum.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactnum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.contactnum.Location = new System.Drawing.Point(195, 137);
            this.contactnum.Name = "contactnum";
            this.contactnum.Size = new System.Drawing.Size(112, 16);
            this.contactnum.TabIndex = 0;
            this.contactnum.Text = "Contact Number:";
            // 
            // addr
            // 
            this.addr.AutoSize = true;
            this.addr.BackColor = System.Drawing.Color.Transparent;
            this.addr.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addr.Location = new System.Drawing.Point(27, 205);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(62, 16);
            this.addr.TabIndex = 0;
            this.addr.Text = "Address:";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.BackColor = System.Drawing.Color.Transparent;
            this.age.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.age.Location = new System.Drawing.Point(26, 174);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(37, 16);
            this.age.TabIndex = 0;
            this.age.Text = "Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Coolvetica Rg", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(91, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(307, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Covid-19 Contact Tracing Form";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(29, 100);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(220, 20);
            this.FirstNameBox.TabIndex = 1;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.FirstNameBox_TextChanged);
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(255, 100);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(209, 20);
            this.LastNameBox.TabIndex = 2;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(86, 175);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(99, 20);
            this.AgeBox.TabIndex = 2;
            // 
            // ContactBox
            // 
            this.ContactBox.Location = new System.Drawing.Point(313, 139);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(151, 20);
            this.ContactBox.TabIndex = 2;
            this.ContactBox.TextChanged += new System.EventHandler(this.ContactBox_TextChanged);
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(29, 230);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(316, 20);
            this.AddressBox.TabIndex = 2;
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.GenderBox.Location = new System.Drawing.Point(86, 139);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(99, 21);
            this.GenderBox.TabIndex = 3;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gender.Location = new System.Drawing.Point(27, 140);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(53, 16);
            this.gender.TabIndex = 0;
            this.gender.Text = "Gender";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Gobold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(123, 272);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 32);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // emailadd
            // 
            this.emailadd.AutoSize = true;
            this.emailadd.BackColor = System.Drawing.Color.Transparent;
            this.emailadd.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailadd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailadd.Location = new System.Drawing.Point(195, 178);
            this.emailadd.Name = "emailadd";
            this.emailadd.Size = new System.Drawing.Size(102, 16);
            this.emailadd.TabIndex = 0;
            this.emailadd.Text = "Email Address:";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(313, 177);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(151, 20);
            this.EmailBox.TabIndex = 2;
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.BackColor = System.Drawing.Color.Transparent;
            this.temp.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.temp.Location = new System.Drawing.Point(348, 205);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(116, 16);
            this.temp.TabIndex = 0;
            this.temp.Text = "Temperature (°C):";
            // 
            // TempBox
            // 
            this.TempBox.Location = new System.Drawing.Point(351, 230);
            this.TempBox.Name = "TempBox";
            this.TempBox.Size = new System.Drawing.Size(113, 20);
            this.TempBox.TabIndex = 2;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Gobold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(214, 272);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 32);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View.Font = new System.Drawing.Font("Gobold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.Location = new System.Drawing.Point(305, 272);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 32);
            this.View.TabIndex = 7;
            this.View.Text = "View Info";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click_1);
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.BackColor = System.Drawing.Color.Transparent;
            this.note.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.note.Location = new System.Drawing.Point(145, 34);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(200, 15);
            this.note.TabIndex = 8;
            this.note.Text = "DO NOT TYPE WHITE SPACES AT THE END";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::ContactTracing.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(491, 338);
            this.Controls.Add(this.note);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Covid-19 Contact Tracing Form";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label note;
    }
}

