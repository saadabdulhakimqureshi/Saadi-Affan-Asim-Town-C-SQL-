
namespace DBSProject1
{
    partial class ResidentYes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentYes));
            this.textSignIn = new System.Windows.Forms.TextBox();
            this.dataResident = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTransport = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textFName = new System.Windows.Forms.TextBox();
            this.textLName = new System.Windows.Forms.TextBox();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataResident)).BeginInit();
            this.SuspendLayout();
            // 
            // textSignIn
            // 
            this.textSignIn.Location = new System.Drawing.Point(1244, 63);
            this.textSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSignIn.Name = "textSignIn";
            this.textSignIn.Size = new System.Drawing.Size(161, 22);
            this.textSignIn.TabIndex = 0;
            this.textSignIn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataResident
            // 
            this.dataResident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResident.Location = new System.Drawing.Point(377, 126);
            this.dataResident.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataResident.Name = "dataResident";
            this.dataResident.RowHeadersWidth = 51;
            this.dataResident.Size = new System.Drawing.Size(1029, 78);
            this.dataResident.TabIndex = 1;
            this.dataResident.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataResident_CellContentClick);
            this.dataResident.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataResident_CellDoubleClick);
            this.dataResident.Click += new System.EventHandler(this.dataResident_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 425);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select your preferred mode of transport";
            // 
            // comboBoxTransport
            // 
            this.comboBoxTransport.FormattingEnabled = true;
            this.comboBoxTransport.Items.AddRange(new object[] {
            "Shuttle",
            "Taxi"});
            this.comboBoxTransport.Location = new System.Drawing.Point(865, 425);
            this.comboBoxTransport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTransport.Name = "comboBoxTransport";
            this.comboBoxTransport.Size = new System.Drawing.Size(281, 24);
            this.comboBoxTransport.TabIndex = 3;
            this.comboBoxTransport.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBoxTransport.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(668, 593);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Security Services";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(921, 593);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "Fire Department";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(1188, 593);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "Health Services";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textFName
            // 
            this.textFName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFName.Location = new System.Drawing.Point(188, 210);
            this.textFName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFName.MaxLength = 50;
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(280, 36);
            this.textFName.TabIndex = 8;
            // 
            // textLName
            // 
            this.textLName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLName.Location = new System.Drawing.Point(188, 277);
            this.textLName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textLName.MaxLength = 50;
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(280, 36);
            this.textLName.TabIndex = 9;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhoneNumber.Location = new System.Drawing.Point(691, 210);
            this.textPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPhoneNumber.MaxLength = 11;
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(280, 36);
            this.textPhoneNumber.TabIndex = 10;
            this.textPhoneNumber.TextChanged += new System.EventHandler(this.textPhoneNumber_TextChanged);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Update.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update.Location = new System.Drawing.Point(1193, 281);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(213, 34);
            this.Update.TabIndex = 11;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SignIn.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignIn.Location = new System.Drawing.Point(668, 53);
            this.SignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(213, 34);
            this.SignIn.TabIndex = 15;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1188, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResidentYes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1483, 799);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.textLName);
            this.Controls.Add(this.textFName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxTransport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataResident);
            this.Controls.Add(this.textSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ResidentYes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResidentYes";
            this.Load += new System.EventHandler(this.ResidentYes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataResident)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSignIn;
        private System.Windows.Forms.DataGridView dataResident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTransport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button button1;
    }
}