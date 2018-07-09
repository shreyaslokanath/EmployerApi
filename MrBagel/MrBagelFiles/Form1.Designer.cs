namespace Assignment5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.headingLabel = new System.Windows.Forms.Label();
            this.bagelTypeListBox = new System.Windows.Forms.ListBox();
            this.bagelSizeListBox = new System.Windows.Forms.ListBox();
            this.customerchoicePanel = new System.Windows.Forms.Panel();
            this.bagelTotalPriceTextbox = new System.Windows.Forms.TextBox();
            this.bagelTotalPriceLabel = new System.Windows.Forms.Label();
            this.bagelQuantityTextBox = new System.Windows.Forms.TextBox();
            this.bagelQuantityLabel = new System.Windows.Forms.Label();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.bagelPriceTextBox = new System.Windows.Forms.TextBox();
            this.bagelPriceLabel = new System.Windows.Forms.Label();
            this.bagelSizeTextBox = new System.Windows.Forms.TextBox();
            this.bageSizeLabel = new System.Windows.Forms.Label();
            this.bagelTypeTextBox = new System.Windows.Forms.TextBox();
            this.bagelTypeDisplayLabel = new System.Windows.Forms.Label();
            this.bagelSizeLabel = new System.Windows.Forms.Label();
            this.bagelTypeLabel = new System.Windows.Forms.Label();
            this.choicePanelLabel = new System.Windows.Forms.Label();
            this.orderedBagelTypesListBox = new System.Windows.Forms.ListBox();
            this.orderedBagelSizeListBox = new System.Windows.Forms.ListBox();
            this.orderPriceListBox = new System.Windows.Forms.ListBox();
            this.orderedBagelTypeLabel = new System.Windows.Forms.Label();
            this.orderedBagelSizeLabel = new System.Windows.Forms.Label();
            this.orderPriceLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderedBagelQuantityListBox = new System.Windows.Forms.ListBox();
            this.orderedBagelQuantityLabel = new System.Windows.Forms.Label();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.confirmOrderbutton = new System.Windows.Forms.Button();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.averageTransactionsTextBox = new System.Windows.Forms.TextBox();
            this.averageTransactionsLabel = new System.Windows.Forms.Label();
            this.totalTransactionLabel = new System.Windows.Forms.Label();
            this.bagelsSummaryLabel = new System.Windows.Forms.Label();
            this.totalTransactionTextBox = new System.Windows.Forms.TextBox();
            this.bagelsSoldTextBox = new System.Windows.Forms.TextBox();
            this.transactionCountSummaryTextBox = new System.Windows.Forms.TextBox();
            this.transactionCountSummaryLabel = new System.Windows.Forms.Label();
            this.summaryHeadingLabel = new System.Windows.Forms.Label();
            this.managementReportButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.customerchoicePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.summaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.Image = global::Assignment5.Properties.Resources.Mr_Bagel_Logo;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(122, 138);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(352, 12);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(125, 21);
            this.headingLabel.TabIndex = 1;
            this.headingLabel.Text = "Mr.Bagel Inc";
            // 
            // bagelTypeListBox
            // 
            this.bagelTypeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bagelTypeListBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelTypeListBox.FormattingEnabled = true;
            this.bagelTypeListBox.ItemHeight = 15;
            this.bagelTypeListBox.Items.AddRange(new object[] {
            "Halloumi",
            "Bangkok",
            "Chicken Philly",
            "Classic Club",
            "Kiltimagh Special",
            "Veggie",
            "Ploughmans",
            "Mexicana",
            "Triple Cheese",
            "Atlantic Way",
            "BreakFast",
            "Maui",
            "Classic",
            "Chicken Caesar",
            "Student Surprise",
            "Cajun"});
            this.bagelTypeListBox.Location = new System.Drawing.Point(13, 53);
            this.bagelTypeListBox.Name = "bagelTypeListBox";
            this.bagelTypeListBox.Size = new System.Drawing.Size(120, 242);
            this.bagelTypeListBox.TabIndex = 2;
            this.bagelTypeListBox.SelectedIndexChanged += new System.EventHandler(this.BagelTypeListBox_SelectedIndexChanged);
            // 
            // bagelSizeListBox
            // 
            this.bagelSizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bagelSizeListBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelSizeListBox.FormattingEnabled = true;
            this.bagelSizeListBox.ItemHeight = 15;
            this.bagelSizeListBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Regular",
            "Large",
            "Extra Large"});
            this.bagelSizeListBox.Location = new System.Drawing.Point(172, 53);
            this.bagelSizeListBox.Name = "bagelSizeListBox";
            this.bagelSizeListBox.Size = new System.Drawing.Size(120, 77);
            this.bagelSizeListBox.TabIndex = 3;
            this.bagelSizeListBox.SelectedIndexChanged += new System.EventHandler(this.BagelSizeListBox_SelectedIndexChanged);
            // 
            // customerchoicePanel
            // 
            this.customerchoicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerchoicePanel.Controls.Add(this.bagelTotalPriceTextbox);
            this.customerchoicePanel.Controls.Add(this.bagelTotalPriceLabel);
            this.customerchoicePanel.Controls.Add(this.bagelQuantityTextBox);
            this.customerchoicePanel.Controls.Add(this.bagelQuantityLabel);
            this.customerchoicePanel.Controls.Add(this.addOrderButton);
            this.customerchoicePanel.Controls.Add(this.bagelPriceTextBox);
            this.customerchoicePanel.Controls.Add(this.bagelPriceLabel);
            this.customerchoicePanel.Controls.Add(this.bagelSizeTextBox);
            this.customerchoicePanel.Controls.Add(this.bageSizeLabel);
            this.customerchoicePanel.Controls.Add(this.bagelTypeTextBox);
            this.customerchoicePanel.Controls.Add(this.bagelTypeDisplayLabel);
            this.customerchoicePanel.Controls.Add(this.bagelSizeLabel);
            this.customerchoicePanel.Controls.Add(this.bagelTypeLabel);
            this.customerchoicePanel.Controls.Add(this.choicePanelLabel);
            this.customerchoicePanel.Controls.Add(this.bagelTypeListBox);
            this.customerchoicePanel.Controls.Add(this.bagelSizeListBox);
            this.customerchoicePanel.Location = new System.Drawing.Point(131, 36);
            this.customerchoicePanel.Name = "customerchoicePanel";
            this.customerchoicePanel.Size = new System.Drawing.Size(406, 371);
            this.customerchoicePanel.TabIndex = 4;
            // 
            // bagelTotalPriceTextbox
            // 
            this.bagelTotalPriceTextbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bagelTotalPriceTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bagelTotalPriceTextbox.Enabled = false;
            this.bagelTotalPriceTextbox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelTotalPriceTextbox.Location = new System.Drawing.Point(277, 294);
            this.bagelTotalPriceTextbox.Name = "bagelTotalPriceTextbox";
            this.bagelTotalPriceTextbox.Size = new System.Drawing.Size(103, 21);
            this.bagelTotalPriceTextbox.TabIndex = 16;
            // 
            // bagelTotalPriceLabel
            // 
            this.bagelTotalPriceLabel.AutoSize = true;
            this.bagelTotalPriceLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelTotalPriceLabel.Location = new System.Drawing.Point(169, 296);
            this.bagelTotalPriceLabel.Name = "bagelTotalPriceLabel";
            this.bagelTotalPriceLabel.Size = new System.Drawing.Size(77, 15);
            this.bagelTotalPriceLabel.TabIndex = 15;
            this.bagelTotalPriceLabel.Text = "Total Price";
            // 
            // bagelQuantityTextBox
            // 
            this.bagelQuantityTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bagelQuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bagelQuantityTextBox.Enabled = false;
            this.bagelQuantityTextBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelQuantityTextBox.Location = new System.Drawing.Point(277, 259);
            this.bagelQuantityTextBox.Name = "bagelQuantityTextBox";
            this.bagelQuantityTextBox.Size = new System.Drawing.Size(103, 21);
            this.bagelQuantityTextBox.TabIndex = 14;
            this.bagelQuantityTextBox.TextChanged += new System.EventHandler(this.BagelQuantityTextBox_TextChanged);
            // 
            // bagelQuantityLabel
            // 
            this.bagelQuantityLabel.AutoSize = true;
            this.bagelQuantityLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelQuantityLabel.Location = new System.Drawing.Point(137, 261);
            this.bagelQuantityLabel.Name = "bagelQuantityLabel";
            this.bagelQuantityLabel.Size = new System.Drawing.Size(141, 15);
            this.bagelQuantityLabel.TabIndex = 13;
            this.bagelQuantityLabel.Text = "Enter Bagel Quantity";
            // 
            // addOrderButton
            // 
            this.addOrderButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addOrderButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrderButton.Location = new System.Drawing.Point(163, 323);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(110, 23);
            this.addOrderButton.TabIndex = 5;
            this.addOrderButton.Text = "&Add to Order";
            this.toolTip1.SetToolTip(this.addOrderButton, "Add to Order");
            this.addOrderButton.UseVisualStyleBackColor = false;
            this.addOrderButton.Click += new System.EventHandler(this.AddOrder_Button_Click);
            // 
            // bagelPriceTextBox
            // 
            this.bagelPriceTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bagelPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bagelPriceTextBox.Enabled = false;
            this.bagelPriceTextBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelPriceTextBox.Location = new System.Drawing.Point(277, 227);
            this.bagelPriceTextBox.Name = "bagelPriceTextBox";
            this.bagelPriceTextBox.Size = new System.Drawing.Size(103, 21);
            this.bagelPriceTextBox.TabIndex = 12;
            // 
            // bagelPriceLabel
            // 
            this.bagelPriceLabel.AutoSize = true;
            this.bagelPriceLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelPriceLabel.Location = new System.Drawing.Point(162, 229);
            this.bagelPriceLabel.Name = "bagelPriceLabel";
            this.bagelPriceLabel.Size = new System.Drawing.Size(79, 15);
            this.bagelPriceLabel.TabIndex = 11;
            this.bagelPriceLabel.Text = "Bagel Price";
            // 
            // bagelSizeTextBox
            // 
            this.bagelSizeTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bagelSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bagelSizeTextBox.Enabled = false;
            this.bagelSizeTextBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelSizeTextBox.Location = new System.Drawing.Point(277, 191);
            this.bagelSizeTextBox.Name = "bagelSizeTextBox";
            this.bagelSizeTextBox.Size = new System.Drawing.Size(103, 21);
            this.bagelSizeTextBox.TabIndex = 10;
            // 
            // bageSizeLabel
            // 
            this.bageSizeLabel.AutoSize = true;
            this.bageSizeLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bageSizeLabel.Location = new System.Drawing.Point(169, 193);
            this.bageSizeLabel.Name = "bageSizeLabel";
            this.bageSizeLabel.Size = new System.Drawing.Size(72, 15);
            this.bageSizeLabel.TabIndex = 9;
            this.bageSizeLabel.Text = "Bagel Size";
            // 
            // bagelTypeTextBox
            // 
            this.bagelTypeTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bagelTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bagelTypeTextBox.Enabled = false;
            this.bagelTypeTextBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelTypeTextBox.Location = new System.Drawing.Point(277, 154);
            this.bagelTypeTextBox.Name = "bagelTypeTextBox";
            this.bagelTypeTextBox.Size = new System.Drawing.Size(103, 21);
            this.bagelTypeTextBox.TabIndex = 8;
            // 
            // bagelTypeDisplayLabel
            // 
            this.bagelTypeDisplayLabel.AutoSize = true;
            this.bagelTypeDisplayLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelTypeDisplayLabel.Location = new System.Drawing.Point(169, 160);
            this.bagelTypeDisplayLabel.Name = "bagelTypeDisplayLabel";
            this.bagelTypeDisplayLabel.Size = new System.Drawing.Size(76, 15);
            this.bagelTypeDisplayLabel.TabIndex = 7;
            this.bagelTypeDisplayLabel.Text = "Bagel Type";
            // 
            // bagelSizeLabel
            // 
            this.bagelSizeLabel.AutoSize = true;
            this.bagelSizeLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelSizeLabel.Location = new System.Drawing.Point(193, 32);
            this.bagelSizeLabel.Name = "bagelSizeLabel";
            this.bagelSizeLabel.Size = new System.Drawing.Size(85, 18);
            this.bagelSizeLabel.TabIndex = 6;
            this.bagelSizeLabel.Text = "Bagel Size";
            // 
            // bagelTypeLabel
            // 
            this.bagelTypeLabel.AutoSize = true;
            this.bagelTypeLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelTypeLabel.Location = new System.Drawing.Point(33, 32);
            this.bagelTypeLabel.Name = "bagelTypeLabel";
            this.bagelTypeLabel.Size = new System.Drawing.Size(90, 18);
            this.bagelTypeLabel.TabIndex = 5;
            this.bagelTypeLabel.Text = "Bagel Type";
            // 
            // choicePanelLabel
            // 
            this.choicePanelLabel.AutoSize = true;
            this.choicePanelLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choicePanelLabel.Location = new System.Drawing.Point(112, 14);
            this.choicePanelLabel.Name = "choicePanelLabel";
            this.choicePanelLabel.Size = new System.Drawing.Size(129, 18);
            this.choicePanelLabel.TabIndex = 4;
            this.choicePanelLabel.Text = "Customer Choice";
            // 
            // orderedBagelTypesListBox
            // 
            this.orderedBagelTypesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderedBagelTypesListBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedBagelTypesListBox.FormattingEnabled = true;
            this.orderedBagelTypesListBox.ItemHeight = 15;
            this.orderedBagelTypesListBox.Location = new System.Drawing.Point(85, 30);
            this.orderedBagelTypesListBox.Name = "orderedBagelTypesListBox";
            this.orderedBagelTypesListBox.Size = new System.Drawing.Size(137, 77);
            this.orderedBagelTypesListBox.TabIndex = 17;
            // 
            // orderedBagelSizeListBox
            // 
            this.orderedBagelSizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderedBagelSizeListBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedBagelSizeListBox.FormattingEnabled = true;
            this.orderedBagelSizeListBox.ItemHeight = 15;
            this.orderedBagelSizeListBox.Location = new System.Drawing.Point(85, 142);
            this.orderedBagelSizeListBox.Name = "orderedBagelSizeListBox";
            this.orderedBagelSizeListBox.Size = new System.Drawing.Size(137, 77);
            this.orderedBagelSizeListBox.TabIndex = 18;
            // 
            // orderPriceListBox
            // 
            this.orderPriceListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderPriceListBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPriceListBox.FormattingEnabled = true;
            this.orderPriceListBox.ItemHeight = 15;
            this.orderPriceListBox.Location = new System.Drawing.Point(85, 363);
            this.orderPriceListBox.Name = "orderPriceListBox";
            this.orderPriceListBox.Size = new System.Drawing.Size(137, 77);
            this.orderPriceListBox.TabIndex = 19;
            // 
            // orderedBagelTypeLabel
            // 
            this.orderedBagelTypeLabel.AutoSize = true;
            this.orderedBagelTypeLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedBagelTypeLabel.Location = new System.Drawing.Point(69, 6);
            this.orderedBagelTypeLabel.Name = "orderedBagelTypeLabel";
            this.orderedBagelTypeLabel.Size = new System.Drawing.Size(170, 18);
            this.orderedBagelTypeLabel.TabIndex = 17;
            this.orderedBagelTypeLabel.Text = "Customer Bagel Types";
            // 
            // orderedBagelSizeLabel
            // 
            this.orderedBagelSizeLabel.AutoSize = true;
            this.orderedBagelSizeLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedBagelSizeLabel.Location = new System.Drawing.Point(69, 121);
            this.orderedBagelSizeLabel.Name = "orderedBagelSizeLabel";
            this.orderedBagelSizeLabel.Size = new System.Drawing.Size(158, 18);
            this.orderedBagelSizeLabel.TabIndex = 20;
            this.orderedBagelSizeLabel.Text = "Customer Bagel Size";
            // 
            // orderPriceLabel
            // 
            this.orderPriceLabel.AutoSize = true;
            this.orderPriceLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPriceLabel.Location = new System.Drawing.Point(69, 342);
            this.orderPriceLabel.Name = "orderPriceLabel";
            this.orderPriceLabel.Size = new System.Drawing.Size(166, 18);
            this.orderPriceLabel.TabIndex = 21;
            this.orderPriceLabel.Text = "Customer Order Price";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.orderedBagelQuantityListBox);
            this.panel1.Controls.Add(this.orderedBagelQuantityLabel);
            this.panel1.Controls.Add(this.cancelOrderButton);
            this.panel1.Controls.Add(this.confirmOrderbutton);
            this.panel1.Controls.Add(this.orderedBagelTypeLabel);
            this.panel1.Controls.Add(this.orderedBagelTypesListBox);
            this.panel1.Controls.Add(this.orderPriceListBox);
            this.panel1.Controls.Add(this.orderPriceLabel);
            this.panel1.Controls.Add(this.orderedBagelSizeLabel);
            this.panel1.Controls.Add(this.orderedBagelSizeListBox);
            this.panel1.Location = new System.Drawing.Point(543, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 507);
            this.panel1.TabIndex = 23;
            // 
            // orderedBagelQuantityListBox
            // 
            this.orderedBagelQuantityListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderedBagelQuantityListBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedBagelQuantityListBox.FormattingEnabled = true;
            this.orderedBagelQuantityListBox.ItemHeight = 15;
            this.orderedBagelQuantityListBox.Location = new System.Drawing.Point(85, 252);
            this.orderedBagelQuantityListBox.Name = "orderedBagelQuantityListBox";
            this.orderedBagelQuantityListBox.Size = new System.Drawing.Size(137, 77);
            this.orderedBagelQuantityListBox.TabIndex = 24;
            // 
            // orderedBagelQuantityLabel
            // 
            this.orderedBagelQuantityLabel.AutoSize = true;
            this.orderedBagelQuantityLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedBagelQuantityLabel.Location = new System.Drawing.Point(59, 231);
            this.orderedBagelQuantityLabel.Name = "orderedBagelQuantityLabel";
            this.orderedBagelQuantityLabel.Size = new System.Drawing.Size(192, 18);
            this.orderedBagelQuantityLabel.TabIndex = 23;
            this.orderedBagelQuantityLabel.Text = "Customer Bagel Quantity";
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cancelOrderButton.Enabled = false;
            this.cancelOrderButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderButton.Location = new System.Drawing.Point(167, 446);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(110, 23);
            this.cancelOrderButton.TabIndex = 22;
            this.cancelOrderButton.Text = "C&ancel order";
            this.toolTip1.SetToolTip(this.cancelOrderButton, "Cancel Order");
            this.cancelOrderButton.UseVisualStyleBackColor = false;
            this.cancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // confirmOrderbutton
            // 
            this.confirmOrderbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.confirmOrderbutton.Enabled = false;
            this.confirmOrderbutton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmOrderbutton.Location = new System.Drawing.Point(34, 446);
            this.confirmOrderbutton.Name = "confirmOrderbutton";
            this.confirmOrderbutton.Size = new System.Drawing.Size(110, 23);
            this.confirmOrderbutton.TabIndex = 17;
            this.confirmOrderbutton.Text = "Confirm &Order";
            this.toolTip1.SetToolTip(this.confirmOrderbutton, "Confirm Order");
            this.confirmOrderbutton.UseVisualStyleBackColor = false;
            this.confirmOrderbutton.Click += new System.EventHandler(this.ConfirmOrderbutton_Click);
            // 
            // summaryPanel
            // 
            this.summaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summaryPanel.Controls.Add(this.clearButton);
            this.summaryPanel.Controls.Add(this.summaryButton);
            this.summaryPanel.Controls.Add(this.averageTransactionsTextBox);
            this.summaryPanel.Controls.Add(this.averageTransactionsLabel);
            this.summaryPanel.Controls.Add(this.totalTransactionLabel);
            this.summaryPanel.Controls.Add(this.bagelsSummaryLabel);
            this.summaryPanel.Controls.Add(this.totalTransactionTextBox);
            this.summaryPanel.Controls.Add(this.bagelsSoldTextBox);
            this.summaryPanel.Controls.Add(this.transactionCountSummaryTextBox);
            this.summaryPanel.Controls.Add(this.transactionCountSummaryLabel);
            this.summaryPanel.Controls.Add(this.summaryHeadingLabel);
            this.summaryPanel.Location = new System.Drawing.Point(131, 424);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(406, 186);
            this.summaryPanel.TabIndex = 25;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.clearButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(285, 101);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(110, 23);
            this.clearButton.TabIndex = 33;
            this.clearButton.Text = "&Clear Summary";
            this.toolTip1.SetToolTip(this.clearButton, "Clear Summary");
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.summaryButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryButton.Location = new System.Drawing.Point(285, 53);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(110, 23);
            this.summaryButton.TabIndex = 25;
            this.summaryButton.Text = "&Summary ";
            this.toolTip1.SetToolTip(this.summaryButton, "Summary");
            this.summaryButton.UseVisualStyleBackColor = false;
            this.summaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // averageTransactionsTextBox
            // 
            this.averageTransactionsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageTransactionsTextBox.Enabled = false;
            this.averageTransactionsTextBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageTransactionsTextBox.Location = new System.Drawing.Point(179, 142);
            this.averageTransactionsTextBox.Name = "averageTransactionsTextBox";
            this.averageTransactionsTextBox.Size = new System.Drawing.Size(100, 21);
            this.averageTransactionsTextBox.TabIndex = 32;
            // 
            // averageTransactionsLabel
            // 
            this.averageTransactionsLabel.AutoSize = true;
            this.averageTransactionsLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageTransactionsLabel.Location = new System.Drawing.Point(32, 142);
            this.averageTransactionsLabel.Name = "averageTransactionsLabel";
            this.averageTransactionsLabel.Size = new System.Drawing.Size(141, 15);
            this.averageTransactionsLabel.TabIndex = 31;
            this.averageTransactionsLabel.Text = "Average Transactions";
            // 
            // totalTransactionLabel
            // 
            this.totalTransactionLabel.AutoSize = true;
            this.totalTransactionLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTransactionLabel.Location = new System.Drawing.Point(48, 111);
            this.totalTransactionLabel.Name = "totalTransactionLabel";
            this.totalTransactionLabel.Size = new System.Drawing.Size(125, 15);
            this.totalTransactionLabel.TabIndex = 30;
            this.totalTransactionLabel.Text = "Total Transactions";
            // 
            // bagelsSummaryLabel
            // 
            this.bagelsSummaryLabel.AutoSize = true;
            this.bagelsSummaryLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelsSummaryLabel.Location = new System.Drawing.Point(55, 74);
            this.bagelsSummaryLabel.Name = "bagelsSummaryLabel";
            this.bagelsSummaryLabel.Size = new System.Drawing.Size(118, 15);
            this.bagelsSummaryLabel.TabIndex = 29;
            this.bagelsSummaryLabel.Text = "Total Bagels Sold";
            // 
            // totalTransactionTextBox
            // 
            this.totalTransactionTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.totalTransactionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTransactionTextBox.Enabled = false;
            this.totalTransactionTextBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTransactionTextBox.Location = new System.Drawing.Point(179, 109);
            this.totalTransactionTextBox.Name = "totalTransactionTextBox";
            this.totalTransactionTextBox.Size = new System.Drawing.Size(103, 21);
            this.totalTransactionTextBox.TabIndex = 28;
            // 
            // bagelsSoldTextBox
            // 
            this.bagelsSoldTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bagelsSoldTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bagelsSoldTextBox.Enabled = false;
            this.bagelsSoldTextBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelsSoldTextBox.Location = new System.Drawing.Point(179, 72);
            this.bagelsSoldTextBox.Name = "bagelsSoldTextBox";
            this.bagelsSoldTextBox.Size = new System.Drawing.Size(103, 21);
            this.bagelsSoldTextBox.TabIndex = 27;
            // 
            // transactionCountSummaryTextBox
            // 
            this.transactionCountSummaryTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.transactionCountSummaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transactionCountSummaryTextBox.Enabled = false;
            this.transactionCountSummaryTextBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionCountSummaryTextBox.Location = new System.Drawing.Point(179, 38);
            this.transactionCountSummaryTextBox.Name = "transactionCountSummaryTextBox";
            this.transactionCountSummaryTextBox.Size = new System.Drawing.Size(103, 21);
            this.transactionCountSummaryTextBox.TabIndex = 17;
            // 
            // transactionCountSummaryLabel
            // 
            this.transactionCountSummaryLabel.AutoSize = true;
            this.transactionCountSummaryLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionCountSummaryLabel.Location = new System.Drawing.Point(13, 40);
            this.transactionCountSummaryLabel.Name = "transactionCountSummaryLabel";
            this.transactionCountSummaryLabel.Size = new System.Drawing.Size(160, 15);
            this.transactionCountSummaryLabel.TabIndex = 17;
            this.transactionCountSummaryLabel.Text = "Number Of Transactions";
            // 
            // summaryHeadingLabel
            // 
            this.summaryHeadingLabel.AutoSize = true;
            this.summaryHeadingLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryHeadingLabel.Location = new System.Drawing.Point(157, 10);
            this.summaryHeadingLabel.Name = "summaryHeadingLabel";
            this.summaryHeadingLabel.Size = new System.Drawing.Size(90, 21);
            this.summaryHeadingLabel.TabIndex = 26;
            this.summaryHeadingLabel.Text = "Summary";
            // 
            // managementReportButton
            // 
            this.managementReportButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.managementReportButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementReportButton.Location = new System.Drawing.Point(3, 179);
            this.managementReportButton.Name = "managementReportButton";
            this.managementReportButton.Size = new System.Drawing.Size(110, 70);
            this.managementReportButton.TabIndex = 17;
            this.managementReportButton.Text = "&View Management Report";
            this.toolTip1.SetToolTip(this.managementReportButton, "Management Report");
            this.managementReportButton.UseVisualStyleBackColor = false;
            this.managementReportButton.Click += new System.EventHandler(this.ManagementReportButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exitButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(3, 270);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(110, 70);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "Exit";
            this.toolTip1.SetToolTip(this.exitButton, "Exit");
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(878, 733);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.managementReportButton);
            this.Controls.Add(this.summaryPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerchoicePanel);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr.Bagel Inc";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.customerchoicePanel.ResumeLayout(false);
            this.customerchoicePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.summaryPanel.ResumeLayout(false);
            this.summaryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.ListBox bagelTypeListBox;
        private System.Windows.Forms.ListBox bagelSizeListBox;
        private System.Windows.Forms.Panel customerchoicePanel;
        private System.Windows.Forms.TextBox bagelSizeTextBox;
        private System.Windows.Forms.Label bageSizeLabel;
        private System.Windows.Forms.TextBox bagelTypeTextBox;
        private System.Windows.Forms.Label bagelTypeDisplayLabel;
        private System.Windows.Forms.Label bagelSizeLabel;
        private System.Windows.Forms.Label bagelTypeLabel;
        private System.Windows.Forms.Label choicePanelLabel;
        private System.Windows.Forms.TextBox bagelPriceTextBox;
        private System.Windows.Forms.Label bagelPriceLabel;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.TextBox bagelQuantityTextBox;
        private System.Windows.Forms.Label bagelQuantityLabel;
        private System.Windows.Forms.TextBox bagelTotalPriceTextbox;
        private System.Windows.Forms.Label bagelTotalPriceLabel;
        private System.Windows.Forms.ListBox orderedBagelTypesListBox;
        private System.Windows.Forms.ListBox orderedBagelSizeListBox;
        private System.Windows.Forms.ListBox orderPriceListBox;
        private System.Windows.Forms.Label orderedBagelTypeLabel;
        private System.Windows.Forms.Label orderedBagelSizeLabel;
        private System.Windows.Forms.Label orderPriceLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button confirmOrderbutton;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.ListBox orderedBagelQuantityListBox;
        private System.Windows.Forms.Label orderedBagelQuantityLabel;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label summaryHeadingLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.TextBox averageTransactionsTextBox;
        private System.Windows.Forms.Label averageTransactionsLabel;
        private System.Windows.Forms.Label totalTransactionLabel;
        private System.Windows.Forms.Label bagelsSummaryLabel;
        private System.Windows.Forms.TextBox totalTransactionTextBox;
        private System.Windows.Forms.TextBox bagelsSoldTextBox;
        private System.Windows.Forms.TextBox transactionCountSummaryTextBox;
        private System.Windows.Forms.Label transactionCountSummaryLabel;
        private System.Windows.Forms.Button managementReportButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button exitButton;
    }
}

