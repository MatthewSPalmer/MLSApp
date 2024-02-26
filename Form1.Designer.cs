namespace MLSApp
{
    partial class MLSForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblMLS = new Label();
            lblCurrent = new Label();
            dataGridCurrent = new DataGridView();
            lblDiscription = new Label();
            btnLogin = new Button();
            groupBoxModify = new GroupBox();
            btnRemove = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            txtMLS = new Label();
            groupBoxFilter = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblPrice = new Label();
            btnLoad = new Button();
            btnSaveFilter = new Button();
            btnClear = new Button();
            btnApply = new Button();
            comboBoxCity = new ComboBox();
            comboBoxBath = new ComboBox();
            comboBoxBed = new ComboBox();
            comboBoxArea = new ComboBox();
            comboBoxPrice = new ComboBox();
            btnSaveSelected = new Button();
            richTextDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridCurrent).BeginInit();
            groupBoxModify.SuspendLayout();
            groupBoxFilter.SuspendLayout();
            SuspendLayout();
            // 
            // lblMLS
            // 
            lblMLS.AutoSize = true;
            lblMLS.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMLS.Location = new Point(341, 31);
            lblMLS.Margin = new Padding(6, 0, 6, 0);
            lblMLS.Name = "lblMLS";
            lblMLS.Size = new Size(529, 38);
            lblMLS.TabIndex = 0;
            lblMLS.Text = "Make-believe Listing System";
            // 
            // lblCurrent
            // 
            lblCurrent.AutoSize = true;
            lblCurrent.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrent.Location = new Point(172, 123);
            lblCurrent.Margin = new Padding(6, 0, 6, 0);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(273, 38);
            lblCurrent.TabIndex = 1;
            lblCurrent.Text = "Current Listings";
            // 
            // dataGridCurrent
            // 
            dataGridCurrent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridCurrent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCurrent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridCurrent.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridCurrent.Location = new Point(12, 185);
            dataGridCurrent.Name = "dataGridCurrent";
            dataGridCurrent.RowHeadersWidth = 20;
            dataGridCurrent.Size = new Size(593, 448);
            dataGridCurrent.TabIndex = 2;
            dataGridCurrent.RowHeaderMouseClick += dataGridCurrent_RowHeaderMouseClick;
            // 
            // lblDiscription
            // 
            lblDiscription.AutoSize = true;
            lblDiscription.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscription.Location = new Point(770, 123);
            lblDiscription.Margin = new Padding(6, 0, 6, 0);
            lblDiscription.Name = "lblDiscription";
            lblDiscription.Size = new Size(199, 38);
            lblDiscription.TabIndex = 3;
            lblDiscription.Text = "Description";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(820, 677);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(315, 67);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Realtor Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // groupBoxModify
            // 
            groupBoxModify.Controls.Add(btnRemove);
            groupBoxModify.Controls.Add(btnAdd);
            groupBoxModify.Location = new Point(822, 758);
            groupBoxModify.Name = "groupBoxModify";
            groupBoxModify.Size = new Size(313, 100);
            groupBoxModify.TabIndex = 6;
            groupBoxModify.TabStop = false;
            groupBoxModify.Text = "Modify";
            groupBoxModify.Visible = false;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(171, 32);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(136, 62);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove Listing";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 32);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 62);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Listing";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(492, 677);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(313, 67);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search By MLS #";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(496, 772);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(309, 33);
            txtSearch.TabIndex = 8;
            // 
            // txtMLS
            // 
            txtMLS.AutoSize = true;
            txtMLS.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMLS.Location = new Point(506, 752);
            txtMLS.Name = "txtMLS";
            txtMLS.Size = new Size(197, 18);
            txtMLS.TabIndex = 9;
            txtMLS.Text = "Enter MLS # to search:";
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Controls.Add(label4);
            groupBoxFilter.Controls.Add(label3);
            groupBoxFilter.Controls.Add(label2);
            groupBoxFilter.Controls.Add(label1);
            groupBoxFilter.Controls.Add(lblPrice);
            groupBoxFilter.Controls.Add(btnLoad);
            groupBoxFilter.Controls.Add(btnSaveFilter);
            groupBoxFilter.Controls.Add(btnClear);
            groupBoxFilter.Controls.Add(btnApply);
            groupBoxFilter.Controls.Add(comboBoxCity);
            groupBoxFilter.Controls.Add(comboBoxBath);
            groupBoxFilter.Controls.Add(comboBoxBed);
            groupBoxFilter.Controls.Add(comboBoxArea);
            groupBoxFilter.Controls.Add(comboBoxPrice);
            groupBoxFilter.Location = new Point(34, 639);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(442, 261);
            groupBoxFilter.TabIndex = 10;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Filter Listings";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 211);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 14;
            label4.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 167);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 13;
            label3.Text = "Bath:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 129);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 12;
            label2.Text = "Bed:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 90);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 11;
            label1.Text = "Area:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(21, 50);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(78, 25);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Price:";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(339, 163);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(97, 33);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSaveFilter
            // 
            btnSaveFilter.Location = new Point(339, 125);
            btnSaveFilter.Name = "btnSaveFilter";
            btnSaveFilter.Size = new Size(97, 33);
            btnSaveFilter.TabIndex = 8;
            btnSaveFilter.Text = "Save";
            btnSaveFilter.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(339, 86);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 33);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(339, 46);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(97, 33);
            btnApply.TabIndex = 6;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(111, 207);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(210, 33);
            comboBoxCity.TabIndex = 5;
            comboBoxCity.Text = "City";
            // 
            // comboBoxBath
            // 
            comboBoxBath.FormattingEnabled = true;
            comboBoxBath.Items.AddRange(new object[] { "All", "1", "2", "3", "4" });
            comboBoxBath.Location = new Point(111, 163);
            comboBoxBath.Name = "comboBoxBath";
            comboBoxBath.Size = new Size(210, 33);
            comboBoxBath.TabIndex = 4;
            comboBoxBath.Text = "Bathrooms";
            // 
            // comboBoxBed
            // 
            comboBoxBed.FormattingEnabled = true;
            comboBoxBed.Items.AddRange(new object[] { "All", "1", "2", "3", "4", "5" });
            comboBoxBed.Location = new Point(111, 125);
            comboBoxBed.Name = "comboBoxBed";
            comboBoxBed.Size = new Size(210, 33);
            comboBoxBed.TabIndex = 3;
            comboBoxBed.Text = "Bedrooms";
            // 
            // comboBoxArea
            // 
            comboBoxArea.FormattingEnabled = true;
            comboBoxArea.Items.AddRange(new object[] { "All", "<1500", "1500 - 1750", "1750 - 2000", "2000 - 2250", "2250 - 2500", "2500 - 2750", "2750 - 3000", "3000 - 3250", ">3250" });
            comboBoxArea.Location = new Point(111, 86);
            comboBoxArea.Name = "comboBoxArea";
            comboBoxArea.Size = new Size(210, 33);
            comboBoxArea.TabIndex = 2;
            comboBoxArea.Text = "Square Footage";
            // 
            // comboBoxPrice
            // 
            comboBoxPrice.FormattingEnabled = true;
            comboBoxPrice.Items.AddRange(new object[] { "All", "<$375K", "$375K - $400K", "$400K - $425K", "$425K - $450K", "$450K - $475K", "$475 - $500K", "$500K - $525K", ">$525K " });
            comboBoxPrice.Location = new Point(111, 46);
            comboBoxPrice.Name = "comboBoxPrice";
            comboBoxPrice.Size = new Size(210, 33);
            comboBoxPrice.TabIndex = 1;
            comboBoxPrice.Text = "Price";
            // 
            // btnSaveSelected
            // 
            btnSaveSelected.Location = new Point(506, 127);
            btnSaveSelected.Name = "btnSaveSelected";
            btnSaveSelected.Size = new Size(204, 38);
            btnSaveSelected.TabIndex = 13;
            btnSaveSelected.Text = "Save Selected";
            btnSaveSelected.UseVisualStyleBackColor = true;
            btnSaveSelected.Click += btnSaveSelected_Click;
            // 
            // richTextDescription
            // 
            richTextDescription.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextDescription.Location = new Point(602, 185);
            richTextDescription.Name = "richTextDescription";
            richTextDescription.Size = new Size(549, 448);
            richTextDescription.TabIndex = 14;
            richTextDescription.Text = "";
            // 
            // MLSForm
            // 
            AutoScaleDimensions = new SizeF(15F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 938);
            Controls.Add(richTextDescription);
            Controls.Add(btnSaveSelected);
            Controls.Add(groupBoxFilter);
            Controls.Add(txtMLS);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(groupBoxModify);
            Controls.Add(btnLogin);
            Controls.Add(lblDiscription);
            Controls.Add(dataGridCurrent);
            Controls.Add(lblCurrent);
            Controls.Add(lblMLS);
            Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "MLSForm";
            Text = "Make-believe Listing System";
            Load += MLSForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCurrent).EndInit();
            groupBoxModify.ResumeLayout(false);
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMLS;
        private Label lblCurrent;
        private DataGridView dataGridCurrent;
        private Label lblDiscription;
        private Button btnLogin;
        private Button btnRemove;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label txtMLS;
        private GroupBox groupBoxFilter;
        private ComboBox comboBoxArea;
        private ComboBox comboBoxPrice;
        private Button btnSaveFilter;
        private Button btnClear;
        private Button btnApply;
        private ComboBox comboBoxCity;
        private ComboBox comboBoxBath;
        private ComboBox comboBoxBed;
        private Button btnLoad;
        private Button btnSaveSelected;
        public GroupBox groupBoxModify;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblPrice;
        private RichTextBox richTextDescription;
    }
}
