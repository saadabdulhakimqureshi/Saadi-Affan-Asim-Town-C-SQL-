
namespace DBSProject1
{
    partial class EmployeeNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeNo));
            this.textFName = new System.Windows.Forms.TextBox();
            this.textLName = new System.Windows.Forms.TextBox();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textDepartment = new System.Windows.Forms.TextBox();
            this.dataDepartment = new System.Windows.Forms.DataGridView();
            this.textPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // textFName
            // 
            this.textFName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFName.Location = new System.Drawing.Point(47, 213);
            this.textFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textFName.MaxLength = 50;
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(488, 36);
            this.textFName.TabIndex = 6;
            this.textFName.TextChanged += new System.EventHandler(this.textFName_TextChanged);
            // 
            // textLName
            // 
            this.textLName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLName.Location = new System.Drawing.Point(47, 325);
            this.textLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textLName.MaxLength = 50;
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(488, 36);
            this.textLName.TabIndex = 7;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhoneNumber.Location = new System.Drawing.Point(47, 438);
            this.textPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPhoneNumber.MaxLength = 11;
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(488, 36);
            this.textPhoneNumber.TabIndex = 8;
            this.textPhoneNumber.TextChanged += new System.EventHandler(this.textPhoneNumber_TextChanged);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(429, 543);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(99, 27);
            this.radioButtonFemale.TabIndex = 10;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "FEMALE";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(327, 543);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(79, 27);
            this.radioButtonMale.TabIndex = 9;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "MALE";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSubmit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSubmit.Location = new System.Drawing.Point(1141, 528);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(269, 42);
            this.buttonSubmit.TabIndex = 13;
            this.buttonSubmit.Text = "Confirm Application";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textDepartment
            // 
            this.textDepartment.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDepartment.Location = new System.Drawing.Point(1141, 391);
            this.textDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDepartment.MaxLength = 50;
            this.textDepartment.Name = "textDepartment";
            this.textDepartment.ReadOnly = true;
            this.textDepartment.Size = new System.Drawing.Size(268, 36);
            this.textDepartment.TabIndex = 14;
            this.textDepartment.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataDepartment
            // 
            this.dataDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDepartment.Location = new System.Drawing.Point(960, 126);
            this.dataDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataDepartment.Name = "dataDepartment";
            this.dataDepartment.RowHeadersWidth = 51;
            this.dataDepartment.Size = new System.Drawing.Size(449, 217);
            this.dataDepartment.TabIndex = 15;
            this.dataDepartment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDepartment_CellContentClick);
            this.dataDepartment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDepartment_CellDoubleClick);
            // 
            // textPosition
            // 
            this.textPosition.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPosition.Location = new System.Drawing.Point(1141, 463);
            this.textPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPosition.MaxLength = 50;
            this.textPosition.Name = "textPosition";
            this.textPosition.ReadOnly = true;
            this.textPosition.Size = new System.Drawing.Size(268, 36);
            this.textPosition.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(824, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Department Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(824, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Position Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(955, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(457, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "The positions available for applicants are:";
            // 
            // EmployeeNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1492, 799);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPosition);
            this.Controls.Add(this.dataDepartment);
            this.Controls.Add(this.textDepartment);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.textLName);
            this.Controls.Add(this.textFName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "EmployeeNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Application";
            this.Load += new System.EventHandler(this.EmployeeNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textDepartment;
        private System.Windows.Forms.DataGridView dataDepartment;
        private System.Windows.Forms.TextBox textPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}