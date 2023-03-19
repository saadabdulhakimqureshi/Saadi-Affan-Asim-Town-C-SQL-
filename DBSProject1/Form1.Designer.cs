
namespace DBSProject1
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
            this.Ownbtn = new System.Windows.Forms.Button();
            this.Empbtn = new System.Windows.Forms.Button();
            this.Resbtn = new System.Windows.Forms.Button();
            this.prcdbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ownbtn
            // 
            this.Ownbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Ownbtn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Ownbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ownbtn.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ownbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ownbtn.Image = global::DBSProject1.Properties.Resources.user;
            this.Ownbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ownbtn.Location = new System.Drawing.Point(117, 267);
            this.Ownbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Ownbtn.Name = "Ownbtn";
            this.Ownbtn.Size = new System.Drawing.Size(303, 70);
            this.Ownbtn.TabIndex = 15;
            this.Ownbtn.Text = "     Owner";
            this.Ownbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ownbtn.UseVisualStyleBackColor = false;
            this.Ownbtn.Click += new System.EventHandler(this.Ownbtn_Click);
            // 
            // Empbtn
            // 
            this.Empbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Empbtn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Empbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Empbtn.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Empbtn.Image = global::DBSProject1.Properties.Resources.employee;
            this.Empbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Empbtn.Location = new System.Drawing.Point(117, 420);
            this.Empbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Empbtn.Name = "Empbtn";
            this.Empbtn.Size = new System.Drawing.Size(303, 70);
            this.Empbtn.TabIndex = 14;
            this.Empbtn.Text = "    Employee";
            this.Empbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Empbtn.UseVisualStyleBackColor = false;
            this.Empbtn.Click += new System.EventHandler(this.Empbtn_Click);
            // 
            // Resbtn
            // 
            this.Resbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Resbtn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Resbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resbtn.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resbtn.ForeColor = System.Drawing.Color.Snow;
            this.Resbtn.Image = global::DBSProject1.Properties.Resources.clipart1038671_50x50;
            this.Resbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Resbtn.Location = new System.Drawing.Point(117, 111);
            this.Resbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Resbtn.Name = "Resbtn";
            this.Resbtn.Size = new System.Drawing.Size(303, 70);
            this.Resbtn.TabIndex = 13;
            this.Resbtn.Text = "     Resident or Tenant";
            this.Resbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Resbtn.UseVisualStyleBackColor = false;
            this.Resbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // prcdbtn
            // 
            this.prcdbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.prcdbtn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prcdbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.prcdbtn.Location = new System.Drawing.Point(368, 588);
            this.prcdbtn.Name = "prcdbtn";
            this.prcdbtn.Size = new System.Drawing.Size(161, 49);
            this.prcdbtn.TabIndex = 16;
            this.prcdbtn.Text = "Proceed";
            this.prcdbtn.UseVisualStyleBackColor = false;
            this.prcdbtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(160, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 55);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Azure;
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Location = new System.Drawing.Point(109, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(109, 55);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(34, 18);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(41, 17);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.Text = "NO";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(36, 18);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(46, 17);
            this.radioButton4.TabIndex = 26;
            this.radioButton4.Text = "YES";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(160, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 55);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(46, 27);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.Text = "YES";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(133, 27);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 17);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.Text = "NO";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 339);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ARE YOU AN EXISTING OWNER?";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Azure;
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Controls.Add(this.radioButton8);
            this.groupBox3.Location = new System.Drawing.Point(160, 512);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 55);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(46, 27);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(46, 17);
            this.radioButton7.TabIndex = 26;
            this.radioButton7.Text = "YES";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(133, 27);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(41, 17);
            this.radioButton8.TabIndex = 25;
            this.radioButton8.Text = "NO";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 496);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ARE YOU AN EXISTING EMPLOYEE?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "ARE YOU AN EXISTING RESIDENT?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = global::DBSProject1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 649);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.prcdbtn);
            this.Controls.Add(this.Ownbtn);
            this.Controls.Add(this.Empbtn);
            this.Controls.Add(this.Resbtn);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Resbtn;
        private System.Windows.Forms.Button Empbtn;
        private System.Windows.Forms.Button Ownbtn;
        private System.Windows.Forms.Button prcdbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
    }
}

