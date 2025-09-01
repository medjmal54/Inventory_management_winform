namespace InventoryManager
{
    partial class InventoryManagement
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
            InvManageLabel = new Label();
            InventoryGridView = new DataGridView();
            SKUtextBox = new TextBox();
            NewButton = new Button();
            SaveButton = new Button();
            DeleteButton = new Button();
            PricetextBox = new TextBox();
            ShDesctextBox = new TextBox();
            NametextBox = new TextBox();
            QuantitytextBox = new TextBox();
            CategoryBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).BeginInit();
            SuspendLayout();
            // 
            // InvManageLabel
            // 
            InvManageLabel.AutoSize = true;
            InvManageLabel.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InvManageLabel.Location = new Point(102, 9);
            InvManageLabel.Name = "InvManageLabel";
            InvManageLabel.Size = new Size(727, 40);
            InvManageLabel.TabIndex = 0;
            InvManageLabel.Text = "Inventory Management Studio XY Market";
            InvManageLabel.TextAlign = ContentAlignment.TopCenter;
            InvManageLabel.Click += InvManageLabel_Click;
            // 
            // InventoryGridView
            // 
            InventoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InventoryGridView.BackgroundColor = SystemColors.ActiveBorder;
            InventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryGridView.Location = new Point(12, 206);
            InventoryGridView.Name = "InventoryGridView";
            InventoryGridView.Size = new Size(931, 418);
            InventoryGridView.TabIndex = 1;
            InventoryGridView.CellContentClick += InventoryGridView_CellContentClick;
            // 
            // SKUtextBox
            // 
            SKUtextBox.Location = new Point(12, 91);
            SKUtextBox.Name = "SKUtextBox";
            SKUtextBox.Size = new Size(276, 23);
            SKUtextBox.TabIndex = 2;
            SKUtextBox.TextChanged += textBox1_TextChanged;
            // 
            // NewButton
            // 
            NewButton.BackColor = Color.DarkOrange;
            NewButton.Location = new Point(12, 169);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(300, 31);
            NewButton.TabIndex = 3;
            NewButton.Text = "➕ New";
            NewButton.UseVisualStyleBackColor = false;
            NewButton.Click += NewButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Green;
            SaveButton.Location = new Point(332, 169);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(294, 31);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "✔️ Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Red;
            DeleteButton.Location = new Point(650, 169);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(292, 31);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "✖️ Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // PricetextBox
            // 
            PricetextBox.Location = new Point(12, 140);
            PricetextBox.Name = "PricetextBox";
            PricetextBox.Size = new Size(276, 23);
            PricetextBox.TabIndex = 6;
            // 
            // ShDesctextBox
            // 
            ShDesctextBox.Location = new Point(332, 140);
            ShDesctextBox.Name = "ShDesctextBox";
            ShDesctextBox.Size = new Size(266, 23);
            ShDesctextBox.TabIndex = 7;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(332, 91);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(266, 23);
            NametextBox.TabIndex = 8;
            // 
            // QuantitytextBox
            // 
            QuantitytextBox.Location = new Point(650, 140);
            QuantitytextBox.Name = "QuantitytextBox";
            QuantitytextBox.Size = new Size(263, 23);
            QuantitytextBox.TabIndex = 9;
            // 
            // CategoryBox
            // 
            CategoryBox.FormattingEnabled = true;
            CategoryBox.Items.AddRange(new object[] { "Automotive", "Grocery", "Hardware", "Pharmacy", "" });
            CategoryBox.Location = new Point(650, 91);
            CategoryBox.Name = "CategoryBox";
            CategoryBox.Size = new Size(263, 23);
            CategoryBox.TabIndex = 10;
            CategoryBox.SelectedIndexChanged += CategoryBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(276, 15);
            label1.TabIndex = 11;
            label1.Text = "SKU:*";
            // 
            // label2
            // 
            label2.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(276, 15);
            label2.TabIndex = 12;
            label2.Text = "Price:*";
            // 
            // label3
            // 
            label3.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(332, 122);
            label3.Name = "label3";
            label3.Size = new Size(266, 15);
            label3.TabIndex = 13;
            label3.Text = "Short description:";
            // 
            // label4
            // 
            label4.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(332, 73);
            label4.Name = "label4";
            label4.Size = new Size(266, 15);
            label4.TabIndex = 14;
            label4.Text = "Name:*";
            // 
            // label5
            // 
            label5.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(650, 122);
            label5.Name = "label5";
            label5.Size = new Size(263, 15);
            label5.TabIndex = 15;
            label5.Text = "Quantity:*";
            // 
            // label6
            // 
            label6.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(650, 73);
            label6.Name = "label6";
            label6.Size = new Size(263, 15);
            label6.TabIndex = 16;
            label6.Text = "Category:*";
            // 
            // InventoryManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(954, 636);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CategoryBox);
            Controls.Add(QuantitytextBox);
            Controls.Add(NametextBox);
            Controls.Add(ShDesctextBox);
            Controls.Add(PricetextBox);
            Controls.Add(DeleteButton);
            Controls.Add(SaveButton);
            Controls.Add(NewButton);
            Controls.Add(SKUtextBox);
            Controls.Add(InventoryGridView);
            Controls.Add(InvManageLabel);
            Name = "InventoryManagement";
            Text = "Inventory Management Studio";
            Load += InventoryManagement_Load;
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InvManageLabel;
        private DataGridView InventoryGridView;
        private TextBox SKUtextBox;
        private Button NewButton;
        private Button SaveButton;
        private Button DeleteButton;
        private TextBox PricetextBox;
        private TextBox ShDesctextBox;
        private TextBox NametextBox;
        private TextBox QuantitytextBox;
        private ComboBox CategoryBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
