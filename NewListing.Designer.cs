namespace MLSApp
{
    partial class NewListing
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
            lblNewListing = new Label();
            lblNewMLS = new Label();
            lblNewPrice = new Label();
            lblNewSqFeet = new Label();
            lblNewBed = new Label();
            lblNewBath = new Label();
            lblNewCity = new Label();
            txtNewMLS = new TextBox();
            comboBoxNewBed = new ComboBox();
            comboBoxNewBath = new ComboBox();
            comboBoxNewCity = new ComboBox();
            btnNewSubmit = new Button();
            btnNewClear = new Button();
            btnNewReturn = new Button();
            lblNewDescription = new Label();
            richTextNewDescription = new RichTextBox();
            txtNewPrice = new TextBox();
            txtNewSqFeet = new TextBox();
            SuspendLayout();
            // 
            // lblNewListing
            // 
            lblNewListing.AutoSize = true;
            lblNewListing.Location = new Point(294, 9);
            lblNewListing.Name = "lblNewListing";
            lblNewListing.Size = new Size(228, 38);
            lblNewListing.TabIndex = 0;
            lblNewListing.Text = "New Listing";
            // 
            // lblNewMLS
            // 
            lblNewMLS.AutoSize = true;
            lblNewMLS.Location = new Point(26, 63);
            lblNewMLS.Name = "lblNewMLS";
            lblNewMLS.Size = new Size(142, 38);
            lblNewMLS.TabIndex = 1;
            lblNewMLS.Text = "MLS #:";
            // 
            // lblNewPrice
            // 
            lblNewPrice.AutoSize = true;
            lblNewPrice.Location = new Point(26, 122);
            lblNewPrice.Name = "lblNewPrice";
            lblNewPrice.Size = new Size(120, 38);
            lblNewPrice.TabIndex = 2;
            lblNewPrice.Text = "Price:";
            // 
            // lblNewSqFeet
            // 
            lblNewSqFeet.AutoSize = true;
            lblNewSqFeet.Location = new Point(26, 181);
            lblNewSqFeet.Name = "lblNewSqFeet";
            lblNewSqFeet.Size = new Size(245, 38);
            lblNewSqFeet.TabIndex = 3;
            lblNewSqFeet.Text = "Square Feet:";
            // 
            // lblNewBed
            // 
            lblNewBed.AutoSize = true;
            lblNewBed.Location = new Point(26, 240);
            lblNewBed.Name = "lblNewBed";
            lblNewBed.Size = new Size(210, 38);
            lblNewBed.TabIndex = 4;
            lblNewBed.Text = "Bedrooms:";
            // 
            // lblNewBath
            // 
            lblNewBath.AutoSize = true;
            lblNewBath.Location = new Point(26, 299);
            lblNewBath.Name = "lblNewBath";
            lblNewBath.Size = new Size(237, 38);
            lblNewBath.TabIndex = 5;
            lblNewBath.Text = "Bathrooms: ";
            // 
            // lblNewCity
            // 
            lblNewCity.AutoSize = true;
            lblNewCity.Location = new Point(26, 358);
            lblNewCity.Name = "lblNewCity";
            lblNewCity.Size = new Size(100, 38);
            lblNewCity.TabIndex = 6;
            lblNewCity.Text = "City:";
            // 
            // txtNewMLS
            // 
            txtNewMLS.Font = new Font("Verdana", 20.25F);
            txtNewMLS.Location = new Point(274, 59);
            txtNewMLS.Name = "txtNewMLS";
            txtNewMLS.Size = new Size(248, 40);
            txtNewMLS.TabIndex = 7;
            // 
            // comboBoxNewBed
            // 
            comboBoxNewBed.Font = new Font("Verdana", 20.25F);
            comboBoxNewBed.FormattingEnabled = true;
            comboBoxNewBed.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBoxNewBed.Location = new Point(274, 236);
            comboBoxNewBed.Name = "comboBoxNewBed";
            comboBoxNewBed.Size = new Size(248, 40);
            comboBoxNewBed.TabIndex = 10;
            // 
            // comboBoxNewBath
            // 
            comboBoxNewBath.Font = new Font("Verdana", 20.25F);
            comboBoxNewBath.FormattingEnabled = true;
            comboBoxNewBath.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBoxNewBath.Location = new Point(274, 295);
            comboBoxNewBath.Name = "comboBoxNewBath";
            comboBoxNewBath.Size = new Size(248, 40);
            comboBoxNewBath.TabIndex = 11;
            // 
            // comboBoxNewCity
            // 
            comboBoxNewCity.Font = new Font("Verdana", 20.25F);
            comboBoxNewCity.FormattingEnabled = true;
            comboBoxNewCity.Location = new Point(274, 354);
            comboBoxNewCity.Name = "comboBoxNewCity";
            comboBoxNewCity.Size = new Size(248, 40);
            comboBoxNewCity.TabIndex = 12;
            comboBoxNewCity.SelectedIndexChanged += comboBoxNewCity_SelectedIndexChanged;
            // 
            // btnNewSubmit
            // 
            btnNewSubmit.Location = new Point(73, 415);
            btnNewSubmit.Name = "btnNewSubmit";
            btnNewSubmit.Size = new Size(163, 58);
            btnNewSubmit.TabIndex = 14;
            btnNewSubmit.Text = "Submit";
            btnNewSubmit.UseVisualStyleBackColor = true;
            btnNewSubmit.Click += btnNewSubmit_Click;
            btnNewSubmit.Validating += btnNewSubmit_Validating;
            // 
            // btnNewClear
            // 
            btnNewClear.Location = new Point(346, 415);
            btnNewClear.Name = "btnNewClear";
            btnNewClear.Size = new Size(163, 58);
            btnNewClear.TabIndex = 15;
            btnNewClear.Text = "Clear";
            btnNewClear.UseVisualStyleBackColor = true;
            btnNewClear.Click += btnNewClear_Click;
            // 
            // btnNewReturn
            // 
            btnNewReturn.Location = new Point(608, 415);
            btnNewReturn.Name = "btnNewReturn";
            btnNewReturn.Size = new Size(163, 58);
            btnNewReturn.TabIndex = 16;
            btnNewReturn.Text = "Return";
            btnNewReturn.UseVisualStyleBackColor = true;
            btnNewReturn.Click += btnNewReturn_Click;
            // 
            // lblNewDescription
            // 
            lblNewDescription.AutoSize = true;
            lblNewDescription.Location = new Point(608, 63);
            lblNewDescription.Name = "lblNewDescription";
            lblNewDescription.Size = new Size(236, 38);
            lblNewDescription.TabIndex = 16;
            lblNewDescription.Text = "Description:";
            // 
            // richTextNewDescription
            // 
            richTextNewDescription.Font = new Font("Verdana", 20.25F);
            richTextNewDescription.Location = new Point(528, 115);
            richTextNewDescription.Name = "richTextNewDescription";
            richTextNewDescription.Size = new Size(394, 279);
            richTextNewDescription.TabIndex = 13;
            richTextNewDescription.Text = "";
            // 
            // txtNewPrice
            // 
            txtNewPrice.Font = new Font("Verdana", 20.25F);
            txtNewPrice.Location = new Point(274, 119);
            txtNewPrice.Name = "txtNewPrice";
            txtNewPrice.Size = new Size(248, 40);
            txtNewPrice.TabIndex = 8;
            // 
            // txtNewSqFeet
            // 
            txtNewSqFeet.Font = new Font("Verdana", 20.25F);
            txtNewSqFeet.Location = new Point(274, 178);
            txtNewSqFeet.Name = "txtNewSqFeet";
            txtNewSqFeet.Size = new Size(248, 40);
            txtNewSqFeet.TabIndex = 9;
            // 
            // NewListing
            // 
            AutoScaleDimensions = new SizeF(22F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 485);
            Controls.Add(txtNewSqFeet);
            Controls.Add(txtNewPrice);
            Controls.Add(richTextNewDescription);
            Controls.Add(lblNewDescription);
            Controls.Add(btnNewReturn);
            Controls.Add(btnNewClear);
            Controls.Add(btnNewSubmit);
            Controls.Add(comboBoxNewCity);
            Controls.Add(comboBoxNewBath);
            Controls.Add(comboBoxNewBed);
            Controls.Add(txtNewMLS);
            Controls.Add(lblNewCity);
            Controls.Add(lblNewBath);
            Controls.Add(lblNewBed);
            Controls.Add(lblNewSqFeet);
            Controls.Add(lblNewPrice);
            Controls.Add(lblNewMLS);
            Controls.Add(lblNewListing);
            Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(9, 8, 9, 8);
            Name = "NewListing";
            Text = "New Listing";
            Load += NewListing_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNewListing;
        private Label lblNewMLS;
        private Label lblNewPrice;
        private Label lblNewSqFeet;
        private Label lblNewBed;
        private Label lblNewBath;
        private Label lblNewCity;
        private TextBox txtNewMLS;
        private ComboBox comboBoxNewBed;
        private ComboBox comboBoxNewBath;
        private ComboBox comboBoxNewCity;
        private Button btnNewSubmit;
        private Button btnNewClear;
        private Button btnNewReturn;
        private Label lblNewDescription;
        private RichTextBox richTextNewDescription;
        private TextBox txtNewPrice;
        private TextBox txtNewSqFeet;

        #endregion
        //private TextBox textBox4;
        //private TextBox textBox5;
        //private Label label8;
        //private RichTextBox richTextBox1;
    }
}