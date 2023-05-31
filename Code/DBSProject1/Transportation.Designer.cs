
namespace DBSProject1
{
    partial class Transportation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transportation));
            this.buttonApproveEmployee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataRequests = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.textLName = new System.Windows.Forms.TextBox();
            this.textFName = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataPersonalData = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textSignIn = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonalData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApproveEmployee
            // 
            this.buttonApproveEmployee.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonApproveEmployee.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonApproveEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonApproveEmployee.Location = new System.Drawing.Point(855, 500);
            this.buttonApproveEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApproveEmployee.Name = "buttonApproveEmployee";
            this.buttonApproveEmployee.Size = new System.Drawing.Size(441, 89);
            this.buttonApproveEmployee.TabIndex = 104;
            this.buttonApproveEmployee.Text = "Resolve";
            this.buttonApproveEmployee.UseVisualStyleBackColor = false;
            this.buttonApproveEmployee.Click += new System.EventHandler(this.buttonApproveEmployee_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(849, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 33);
            this.label2.TabIndex = 103;
            this.label2.Text = "Requests";
            // 
            // dataRequests
            // 
            this.dataRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRequests.Location = new System.Drawing.Point(856, 137);
            this.dataRequests.Margin = new System.Windows.Forms.Padding(4);
            this.dataRequests.Name = "dataRequests";
            this.dataRequests.RowHeadersWidth = 51;
            this.dataRequests.Size = new System.Drawing.Size(441, 340);
            this.dataRequests.TabIndex = 102;
            this.dataRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRequests_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 444);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 33);
            this.label10.TabIndex = 101;
            this.label10.Text = "Phone Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 399);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 33);
            this.label9.TabIndex = 100;
            this.label9.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 353);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 33);
            this.label8.TabIndex = 99;
            this.label8.Text = "First Name:";
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhoneNumber.Location = new System.Drawing.Point(216, 438);
            this.textPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textPhoneNumber.MaxLength = 11;
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(220, 36);
            this.textPhoneNumber.TabIndex = 98;
            this.textPhoneNumber.TextChanged += new System.EventHandler(this.textPhoneNumber_TextChanged_1);
            // 
            // textLName
            // 
            this.textLName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLName.Location = new System.Drawing.Point(216, 393);
            this.textLName.Margin = new System.Windows.Forms.Padding(4);
            this.textLName.MaxLength = 50;
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(220, 36);
            this.textLName.TabIndex = 97;
            // 
            // textFName
            // 
            this.textFName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFName.Location = new System.Drawing.Point(216, 347);
            this.textFName.Margin = new System.Windows.Forms.Padding(4);
            this.textFName.MaxLength = 50;
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(220, 36);
            this.textFName.TabIndex = 96;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonUpdate.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(583, 347);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(221, 70);
            this.buttonUpdate.TabIndex = 95;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click_1);
            // 
            // dataPersonalData
            // 
            this.dataPersonalData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPersonalData.Location = new System.Drawing.Point(16, 137);
            this.dataPersonalData.Margin = new System.Windows.Forms.Padding(4);
            this.dataPersonalData.Name = "dataPersonalData";
            this.dataPersonalData.RowHeadersWidth = 51;
            this.dataPersonalData.Size = new System.Drawing.Size(804, 191);
            this.dataPersonalData.TabIndex = 94;
            this.dataPersonalData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPersonalData_CellDoubleClick_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 33);
            this.label4.TabIndex = 93;
            this.label4.Text = "Personal Information";
            // 
            // textSignIn
            // 
            this.textSignIn.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSignIn.Location = new System.Drawing.Point(964, 36);
            this.textSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.textSignIn.MaxLength = 50;
            this.textSignIn.Name = "textSignIn";
            this.textSignIn.Size = new System.Drawing.Size(171, 36);
            this.textSignIn.TabIndex = 92;
            this.textSignIn.TextChanged += new System.EventHandler(this.textSignIn_TextChanged_1);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSignIn.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonSignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSignIn.Location = new System.Drawing.Point(1168, 26);
            this.buttonSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(129, 64);
            this.buttonSignIn.TabIndex = 91;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(829, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 33);
            this.label6.TabIndex = 90;
            this.label6.Text = "Enter ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 58);
            this.label1.TabIndex = 89;
            this.label1.Text = "Transportation Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(448, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 109);
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // Transportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1343, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonApproveEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataRequests);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.textLName);
            this.Controls.Add(this.textFName);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataPersonalData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSignIn);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Transportation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transportation";
            ((System.ComponentModel.ISupportInitialize)(this.dataRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonalData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonApproveEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataRequests;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataPersonalData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSignIn;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}