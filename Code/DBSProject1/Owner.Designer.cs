
namespace DBSProject1
{
    partial class Owner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner));
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.textLName = new System.Windows.Forms.TextBox();
            this.textFName = new System.Windows.Forms.TextBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textBlock = new System.Windows.Forms.TextBox();
            this.dataPlot = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1177, 560);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Confirm Application";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(409, 356);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(88, 27);
            this.radioButtonFemale.TabIndex = 14;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // textLName
            // 
            this.textLName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLName.Location = new System.Drawing.Point(240, 274);
            this.textLName.Margin = new System.Windows.Forms.Padding(4);
            this.textLName.MaxLength = 50;
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(473, 36);
            this.textLName.TabIndex = 13;
            // 
            // textFName
            // 
            this.textFName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFName.Location = new System.Drawing.Point(240, 170);
            this.textFName.Margin = new System.Windows.Forms.Padding(4);
            this.textFName.MaxLength = 50;
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(473, 36);
            this.textFName.TabIndex = 12;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(276, 356);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(69, 27);
            this.radioButtonMale.TabIndex = 11;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhoneNumber.Location = new System.Drawing.Point(240, 420);
            this.textPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textPhoneNumber.MaxLength = 11;
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(473, 36);
            this.textPhoneNumber.TabIndex = 18;
            this.textPhoneNumber.TextChanged += new System.EventHandler(this.textPhoneNumber_TextChanged);
            // 
            // textNumber
            // 
            this.textNumber.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumber.Location = new System.Drawing.Point(1199, 384);
            this.textNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textNumber.Name = "textNumber";
            this.textNumber.ReadOnly = true;
            this.textNumber.Size = new System.Drawing.Size(205, 36);
            this.textNumber.TabIndex = 19;
            // 
            // textBlock
            // 
            this.textBlock.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBlock.Location = new System.Drawing.Point(1199, 460);
            this.textBlock.Margin = new System.Windows.Forms.Padding(4);
            this.textBlock.Name = "textBlock";
            this.textBlock.ReadOnly = true;
            this.textBlock.Size = new System.Drawing.Size(205, 36);
            this.textBlock.TabIndex = 20;
            // 
            // dataPlot
            // 
            this.dataPlot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPlot.Location = new System.Drawing.Point(773, 209);
            this.dataPlot.Margin = new System.Windows.Forms.Padding(4);
            this.dataPlot.Name = "dataPlot";
            this.dataPlot.RowHeadersWidth = 51;
            this.dataPlot.Size = new System.Drawing.Size(632, 156);
            this.dataPlot.TabIndex = 15;
            this.dataPlot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPlot_CellContentClick);
            this.dataPlot.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPlot_CellDoubleClick);
            this.dataPlot.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataPlot_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1047, 386);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1079, 469);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Block:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(768, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Double click on the plot you would like to purchase.";
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1483, 799);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBlock);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataPlot);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.textLName);
            this.Controls.Add(this.textFName);
            this.Controls.Add(this.radioButtonMale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Owner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner Registration";
            this.Load += new System.EventHandler(this.Owner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textBlock;
        private System.Windows.Forms.DataGridView dataPlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}