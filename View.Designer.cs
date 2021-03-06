
namespace ContactTracing
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.ReadFile = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DisplayInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameB = new System.Windows.Forms.TextBox();
            this.NOTE2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReadFile
            // 
            this.ReadFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReadFile.Font = new System.Drawing.Font("Gobold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadFile.Location = new System.Drawing.Point(18, 138);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.ReadOnly = true;
            this.ReadFile.Size = new System.Drawing.Size(346, 182);
            this.ReadFile.TabIndex = 0;
            this.ReadFile.Text = "";
            this.ReadFile.TextChanged += new System.EventHandler(this.ReadFile_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Coolvetica Rg", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(44, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(307, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Covid-19 Contact Tracing Form";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DisplayInfo
            // 
            this.DisplayInfo.Font = new System.Drawing.Font("Gobold", 12F, System.Drawing.FontStyle.Italic);
            this.DisplayInfo.Location = new System.Drawing.Point(289, 86);
            this.DisplayInfo.Name = "DisplayInfo";
            this.DisplayInfo.Size = new System.Drawing.Size(75, 36);
            this.DisplayInfo.TabIndex = 2;
            this.DisplayInfo.Text = "View";
            this.DisplayInfo.UseVisualStyleBackColor = true;
            this.DisplayInfo.Click += new System.EventHandler(this.DisplayInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LastNameBox
            // 
            this.LastNameBox.AutoSize = true;
            this.LastNameBox.BackColor = System.Drawing.Color.Transparent;
            this.LastNameBox.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LastNameBox.Location = new System.Drawing.Point(22, 106);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(76, 16);
            this.LastNameBox.TabIndex = 3;
            this.LastNameBox.Text = "Last Name:";
            this.LastNameBox.Click += new System.EventHandler(this.LastNameBox_Click);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(109, 79);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(135, 20);
            this.FirstNameBox.TabIndex = 4;
            // 
            // LastNameB
            // 
            this.LastNameB.Location = new System.Drawing.Point(109, 105);
            this.LastNameB.Name = "LastNameB";
            this.LastNameB.Size = new System.Drawing.Size(135, 20);
            this.LastNameB.TabIndex = 4;
            // 
            // NOTE2
            // 
            this.NOTE2.AutoSize = true;
            this.NOTE2.BackColor = System.Drawing.Color.Transparent;
            this.NOTE2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOTE2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NOTE2.Location = new System.Drawing.Point(95, 39);
            this.NOTE2.Name = "NOTE2";
            this.NOTE2.Size = new System.Drawing.Size(200, 15);
            this.NOTE2.TabIndex = 9;
            this.NOTE2.Text = "DO NOT TYPE WHITE SPACES AT THE END";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::ContactTracing.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(387, 343);
            this.Controls.Add(this.NOTE2);
            this.Controls.Add(this.LastNameB);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReadFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ReadFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DisplayInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LastNameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameB;
        private System.Windows.Forms.Label NOTE2;
    }
}