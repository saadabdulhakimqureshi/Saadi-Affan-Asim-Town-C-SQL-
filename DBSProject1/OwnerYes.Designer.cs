
namespace DBSProject1
{
    partial class OwnerYes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerYes));
            this.textSignIn = new System.Windows.Forms.TextBox();
            this.dataOwnedPlots = new System.Windows.Forms.DataGridView();
            this.dataResidents = new System.Windows.Forms.DataGridView();
            this.dataAvailablePlots = new System.Windows.Forms.DataGridView();
            this.buttonSell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataApplications = new System.Windows.Forms.DataGridView();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.buttonApprove = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonEvict = new System.Windows.Forms.Button();
            this.textFName = new System.Windows.Forms.TextBox();
            this.textLName = new System.Windows.Forms.TextBox();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textSellPlotId = new System.Windows.Forms.TextBox();
            this.textPurchasePlotId = new System.Windows.Forms.TextBox();
            this.dataOwner = new System.Windows.Forms.DataGridView();
            this.textResidentLName = new System.Windows.Forms.TextBox();
            this.textResidentFName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonUpdateRent = new System.Windows.Forms.Button();
            this.textRent = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonReject = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textResidentPhoneNumber = new System.Windows.Forms.TextBox();
            this.buttonOpenClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataOwnedPlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataResidents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAvailablePlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOwner)).BeginInit();
            this.SuspendLayout();
            // 
            // textSignIn
            // 
            this.textSignIn.Location = new System.Drawing.Point(1132, 39);
            this.textSignIn.Name = "textSignIn";
            this.textSignIn.Size = new System.Drawing.Size(116, 20);
            this.textSignIn.TabIndex = 1;
            this.textSignIn.TextChanged += new System.EventHandler(this.textSignIn_TextChanged);
            // 
            // dataOwnedPlots
            // 
            this.dataOwnedPlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOwnedPlots.Location = new System.Drawing.Point(646, 141);
            this.dataOwnedPlots.Name = "dataOwnedPlots";
            this.dataOwnedPlots.RowHeadersWidth = 51;
            this.dataOwnedPlots.Size = new System.Drawing.Size(335, 153);
            this.dataOwnedPlots.TabIndex = 2;
            this.dataOwnedPlots.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOwnedPlots_CellContentClick);
            this.dataOwnedPlots.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOwnedPlots_CellDoubleClick);
            // 
            // dataResidents
            // 
            this.dataResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResidents.Location = new System.Drawing.Point(650, 375);
            this.dataResidents.Name = "dataResidents";
            this.dataResidents.RowHeadersWidth = 51;
            this.dataResidents.Size = new System.Drawing.Size(335, 95);
            this.dataResidents.TabIndex = 3;
            this.dataResidents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataResidents_CellDoubleClick);
            // 
            // dataAvailablePlots
            // 
            this.dataAvailablePlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAvailablePlots.Location = new System.Drawing.Point(1046, 141);
            this.dataAvailablePlots.Name = "dataAvailablePlots";
            this.dataAvailablePlots.RowHeadersWidth = 51;
            this.dataAvailablePlots.Size = new System.Drawing.Size(319, 153);
            this.dataAvailablePlots.TabIndex = 4;
            this.dataAvailablePlots.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAvailablePlots_CellContentClick);
            this.dataAvailablePlots.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAvailablePlots_CellDoubleClick);
            // 
            // buttonSell
            // 
            this.buttonSell.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSell.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSell.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSell.Location = new System.Drawing.Point(884, 299);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(97, 35);
            this.buttonSell.TabIndex = 11;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = false;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Owner Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(641, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Owned Properties:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(646, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tenants/Residents:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1042, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Avalable Properties:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Personal Information:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1028, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Enter ID:";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.Location = new System.Drawing.Point(1268, 37);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(97, 25);
            this.buttonSignIn.TabIndex = 22;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1042, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "Applications:";
            // 
            // dataApplications
            // 
            this.dataApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataApplications.Location = new System.Drawing.Point(1046, 375);
            this.dataApplications.Name = "dataApplications";
            this.dataApplications.RowHeadersWidth = 51;
            this.dataApplications.Size = new System.Drawing.Size(335, 187);
            this.dataApplications.TabIndex = 24;
            this.dataApplications.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataApplications_CellClick);
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonPurchase.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPurchase.Location = new System.Drawing.Point(1268, 299);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(97, 35);
            this.buttonPurchase.TabIndex = 25;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = false;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // buttonApprove
            // 
            this.buttonApprove.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonApprove.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApprove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonApprove.Location = new System.Drawing.Point(1285, 583);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(97, 35);
            this.buttonApprove.TabIndex = 26;
            this.buttonApprove.Text = "Approve";
            this.buttonApprove.UseVisualStyleBackColor = false;
            this.buttonApprove.Click += new System.EventHandler(this.buttonApprove_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonUpdate.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(485, 337);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(97, 35);
            this.buttonUpdate.TabIndex = 27;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonEvict
            // 
            this.buttonEvict.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonEvict.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEvict.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEvict.Location = new System.Drawing.Point(889, 520);
            this.buttonEvict.Name = "buttonEvict";
            this.buttonEvict.Size = new System.Drawing.Size(97, 35);
            this.buttonEvict.TabIndex = 28;
            this.buttonEvict.Text = "Evict";
            this.buttonEvict.UseVisualStyleBackColor = false;
            this.buttonEvict.Click += new System.EventHandler(this.button4_Click);
            // 
            // textFName
            // 
            this.textFName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFName.Location = new System.Drawing.Point(332, 425);
            this.textFName.MaxLength = 50;
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(251, 31);
            this.textFName.TabIndex = 29;
            // 
            // textLName
            // 
            this.textLName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLName.Location = new System.Drawing.Point(332, 462);
            this.textLName.MaxLength = 50;
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(251, 31);
            this.textLName.TabIndex = 30;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhoneNumber.Location = new System.Drawing.Point(332, 500);
            this.textPhoneNumber.MaxLength = 11;
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(251, 31);
            this.textPhoneNumber.TabIndex = 31;
            this.textPhoneNumber.TextChanged += new System.EventHandler(this.textPhoneNumber_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(166, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 26);
            this.label8.TabIndex = 32;
            this.label8.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(169, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 26);
            this.label9.TabIndex = 33;
            this.label9.Text = "Last Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 26);
            this.label10.TabIndex = 34;
            this.label10.Text = "Phone Number:";
            // 
            // textSellPlotId
            // 
            this.textSellPlotId.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSellPlotId.Location = new System.Drawing.Point(650, 299);
            this.textSellPlotId.MaxLength = 50;
            this.textSellPlotId.Name = "textSellPlotId";
            this.textSellPlotId.ReadOnly = true;
            this.textSellPlotId.Size = new System.Drawing.Size(108, 31);
            this.textSellPlotId.TabIndex = 35;
            // 
            // textPurchasePlotId
            // 
            this.textPurchasePlotId.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPurchasePlotId.Location = new System.Drawing.Point(1154, 299);
            this.textPurchasePlotId.MaxLength = 50;
            this.textPurchasePlotId.Name = "textPurchasePlotId";
            this.textPurchasePlotId.ReadOnly = true;
            this.textPurchasePlotId.Size = new System.Drawing.Size(108, 31);
            this.textPurchasePlotId.TabIndex = 36;
            // 
            // dataOwner
            // 
            this.dataOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOwner.Location = new System.Drawing.Point(37, 141);
            this.dataOwner.Name = "dataOwner";
            this.dataOwner.RowHeadersWidth = 51;
            this.dataOwner.Size = new System.Drawing.Size(546, 118);
            this.dataOwner.TabIndex = 19;
            this.dataOwner.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOwner_CellContentClick);
            this.dataOwner.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOwner_CellDoubleClick);
            // 
            // textResidentLName
            // 
            this.textResidentLName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResidentLName.Location = new System.Drawing.Point(754, 519);
            this.textResidentLName.MaxLength = 50;
            this.textResidentLName.Name = "textResidentLName";
            this.textResidentLName.ReadOnly = true;
            this.textResidentLName.Size = new System.Drawing.Size(108, 31);
            this.textResidentLName.TabIndex = 37;
            // 
            // textResidentFName
            // 
            this.textResidentFName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResidentFName.Location = new System.Drawing.Point(754, 484);
            this.textResidentFName.MaxLength = 50;
            this.textResidentFName.Name = "textResidentFName";
            this.textResidentFName.ReadOnly = true;
            this.textResidentFName.Size = new System.Drawing.Size(108, 31);
            this.textResidentFName.TabIndex = 38;
            this.textResidentFName.TextChanged += new System.EventHandler(this.textResidentFName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(626, 485);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 26);
            this.label11.TabIndex = 39;
            this.label11.Text = "First Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(629, 520);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 26);
            this.label12.TabIndex = 40;
            this.label12.Text = "Last Name:";
            // 
            // buttonUpdateRent
            // 
            this.buttonUpdateRent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonUpdateRent.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateRent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdateRent.Location = new System.Drawing.Point(889, 589);
            this.buttonUpdateRent.Name = "buttonUpdateRent";
            this.buttonUpdateRent.Size = new System.Drawing.Size(97, 35);
            this.buttonUpdateRent.TabIndex = 41;
            this.buttonUpdateRent.Text = "Update Rent";
            this.buttonUpdateRent.UseVisualStyleBackColor = false;
            this.buttonUpdateRent.Click += new System.EventHandler(this.buttonUpdateRent_Click);
            // 
            // textRent
            // 
            this.textRent.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRent.Location = new System.Drawing.Point(754, 591);
            this.textRent.MaxLength = 11;
            this.textRent.Name = "textRent";
            this.textRent.Size = new System.Drawing.Size(108, 31);
            this.textRent.TabIndex = 42;
            this.textRent.TextChanged += new System.EventHandler(this.textRent_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(680, 592);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 26);
            this.label13.TabIndex = 43;
            this.label13.Text = "Rent:";
            // 
            // buttonReject
            // 
            this.buttonReject.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonReject.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReject.Location = new System.Drawing.Point(1046, 583);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(97, 35);
            this.buttonReject.TabIndex = 44;
            this.buttonReject.Text = "Reject";
            this.buttonReject.UseVisualStyleBackColor = false;
            this.buttonReject.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(590, 553);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 26);
            this.label14.TabIndex = 45;
            this.label14.Text = "Phone Number:";
            // 
            // textResidentPhoneNumber
            // 
            this.textResidentPhoneNumber.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResidentPhoneNumber.Location = new System.Drawing.Point(754, 555);
            this.textResidentPhoneNumber.MaxLength = 50;
            this.textResidentPhoneNumber.Name = "textResidentPhoneNumber";
            this.textResidentPhoneNumber.ReadOnly = true;
            this.textResidentPhoneNumber.Size = new System.Drawing.Size(108, 31);
            this.textResidentPhoneNumber.TabIndex = 46;
            // 
            // buttonOpenClose
            // 
            this.buttonOpenClose.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonOpenClose.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOpenClose.Location = new System.Drawing.Point(781, 299);
            this.buttonOpenClose.Name = "buttonOpenClose";
            this.buttonOpenClose.Size = new System.Drawing.Size(97, 35);
            this.buttonOpenClose.TabIndex = 47;
            this.buttonOpenClose.Text = "Open/Close";
            this.buttonOpenClose.UseVisualStyleBackColor = false;
            this.buttonOpenClose.Click += new System.EventHandler(this.buttonOpenClose_Click);
            // 
            // OwnerYes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1391, 779);
            this.Controls.Add(this.buttonOpenClose);
            this.Controls.Add(this.textResidentPhoneNumber);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonReject);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textRent);
            this.Controls.Add(this.buttonUpdateRent);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textResidentFName);
            this.Controls.Add(this.textResidentLName);
            this.Controls.Add(this.textPurchasePlotId);
            this.Controls.Add(this.textSellPlotId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.textLName);
            this.Controls.Add(this.textFName);
            this.Controls.Add(this.buttonEvict);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.buttonPurchase);
            this.Controls.Add(this.dataApplications);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataOwner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.dataAvailablePlots);
            this.Controls.Add(this.dataResidents);
            this.Controls.Add(this.dataOwnedPlots);
            this.Controls.Add(this.textSignIn);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OwnerYes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnerLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OwnerYes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOwnedPlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataResidents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAvailablePlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOwner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSignIn;
        private System.Windows.Forms.DataGridView dataOwnedPlots;
        private System.Windows.Forms.DataGridView dataResidents;
        private System.Windows.Forms.DataGridView dataAvailablePlots;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataApplications;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Button buttonApprove;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonEvict;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textSellPlotId;
        private System.Windows.Forms.TextBox textPurchasePlotId;
        private System.Windows.Forms.DataGridView dataOwner;
        private System.Windows.Forms.TextBox textResidentLName;
        private System.Windows.Forms.TextBox textResidentFName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonUpdateRent;
        private System.Windows.Forms.TextBox textRent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonReject;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textResidentPhoneNumber;
        private System.Windows.Forms.Button buttonOpenClose;
    }
}