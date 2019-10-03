namespace CoffeeShop3LayerArchitecture
{
    partial class Orders
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCustomerName = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCustomerOrder = new System.Windows.Forms.ComboBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCustomerName);
            this.groupBox1.Controls.Add(this.comboBoxCustomerOrder);
            this.groupBox1.Controls.Add(this.textBoxTotalPrice);
            this.groupBox1.Controls.Add(this.textBoxQuantity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 251);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // comboBoxCustomerName
            // 
            this.comboBoxCustomerName.DataSource = this.customerBindingSource;
            this.comboBoxCustomerName.DisplayMember = "Name";
            this.comboBoxCustomerName.FormattingEnabled = true;
            this.comboBoxCustomerName.Location = new System.Drawing.Point(178, 40);
            this.comboBoxCustomerName.Name = "comboBoxCustomerName";
            this.comboBoxCustomerName.Size = new System.Drawing.Size(81, 28);
            this.comboBoxCustomerName.TabIndex = 2;
            this.comboBoxCustomerName.ValueMember = "Item";
            // 
            // customerBindingSource
            // 
//            this.customerBindingSource.DataSource = typeof(CoffeeShop3LayerArchitecture.Model.Customer);
            // 
            // comboBoxCustomerOrder
            // 
            this.comboBoxCustomerOrder.DataSource = this.itemBindingSource;
            this.comboBoxCustomerOrder.DisplayMember = "Name";
            this.comboBoxCustomerOrder.FormattingEnabled = true;
            this.comboBoxCustomerOrder.Location = new System.Drawing.Point(178, 85);
            this.comboBoxCustomerOrder.Name = "comboBoxCustomerOrder";
            this.comboBoxCustomerOrder.Size = new System.Drawing.Size(81, 28);
            this.comboBoxCustomerOrder.TabIndex = 2;
            this.comboBoxCustomerOrder.ValueMember = "Id";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(159, 185);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(100, 26);
            this.textBoxTotalPrice.TabIndex = 1;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(159, 137);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 26);
            this.textBoxQuantity.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Name";
            // 
            // itemBindingSource
            // 
//            this.itemBindingSource.DataSource = typeof(CoffeeShop3LayerArchitecture.Model.Item);
            // 
            // customerBindingSource1
            // 
//            this.customerBindingSource1.DataSource = typeof(CoffeeShop3LayerArchitecture.Model.Customer);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(393, 65);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowTemplate.Height = 28;
            this.dataGridViewOrder.Size = new System.Drawing.Size(746, 434);
            this.dataGridViewOrder.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(115, 526);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(82, 45);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(260, 84);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(76, 39);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(154, 90);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 26);
            this.textBoxSearch.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Search By Name";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 667);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.groupBox1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCustomerOrder;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label label6;
    }
}