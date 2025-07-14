namespace Inventory;

partial class frmAddproduct
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtProductName = new System.Windows.Forms.TextBox();
        cbCategory = new System.Windows.Forms.ComboBox();
        dtPickerMfgDate = new System.Windows.Forms.DateTimePicker();
        dtPickerExpDate = new System.Windows.Forms.DateTimePicker();
        richTxtDescription = new System.Windows.Forms.RichTextBox();
        btnAddProduct = new System.Windows.Forms.Button();
        gridViewProductList = new System.Windows.Forms.DataGridView();
        txtQuantity = new System.Windows.Forms.TextBox();
        txtSellPrice = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
        SuspendLayout();
        // 
        // txtProductName
        // 
        txtProductName.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        txtProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtProductName.Location = new System.Drawing.Point(74, 155);
        txtProductName.Name = "txtProductName";
        txtProductName.Size = new System.Drawing.Size(253, 29);
        txtProductName.TabIndex = 0;
        // 
        // cbCategory
        // 
        cbCategory.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        cbCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbCategory.FormattingEnabled = true;
        cbCategory.Location = new System.Drawing.Point(349, 155);
        cbCategory.Name = "cbCategory";
        cbCategory.Size = new System.Drawing.Size(253, 29);
        cbCategory.TabIndex = 3;
        // 
        // dtPickerMfgDate
        // 
        dtPickerMfgDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtPickerMfgDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        dtPickerMfgDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtPickerMfgDate.Location = new System.Drawing.Point(74, 234);
        dtPickerMfgDate.Name = "dtPickerMfgDate";
        dtPickerMfgDate.Size = new System.Drawing.Size(253, 29);
        dtPickerMfgDate.TabIndex = 4;
        // 
        // dtPickerExpDate
        // 
        dtPickerExpDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtPickerExpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        dtPickerExpDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtPickerExpDate.Location = new System.Drawing.Point(349, 234);
        dtPickerExpDate.Name = "dtPickerExpDate";
        dtPickerExpDate.Size = new System.Drawing.Size(250, 29);
        dtPickerExpDate.TabIndex = 5;
        // 
        // richTxtDescription
        // 
        richTxtDescription.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        richTxtDescription.Location = new System.Drawing.Point(628, 155);
        richTxtDescription.Name = "richTxtDescription";
        richTxtDescription.Size = new System.Drawing.Size(329, 197);
        richTxtDescription.TabIndex = 6;
        richTxtDescription.Text = "";
        // 
        // btnAddProduct
        // 
        btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        btnAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        btnAddProduct.Location = new System.Drawing.Point(828, 385);
        btnAddProduct.Name = "btnAddProduct";
        btnAddProduct.Size = new System.Drawing.Size(129, 34);
        btnAddProduct.TabIndex = 7;
        btnAddProduct.Text = "Add Product";
        btnAddProduct.UseVisualStyleBackColor = false;
        btnAddProduct.Click += btnAddProduct_Click;
        // 
        // gridViewProductList
        // 
        gridViewProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        gridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridViewProductList.Location = new System.Drawing.Point(74, 450);
        gridViewProductList.Name = "gridViewProductList";
        gridViewProductList.Size = new System.Drawing.Size(883, 168);
        gridViewProductList.TabIndex = 8;
        gridViewProductList.Text = "dataGridView1";
        // 
        // txtQuantity
        // 
        txtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtQuantity.Location = new System.Drawing.Point(74, 323);
        txtQuantity.Name = "txtQuantity";
        txtQuantity.Size = new System.Drawing.Size(253, 29);
        txtQuantity.TabIndex = 9;
        // 
        // txtSellPrice
        // 
        txtSellPrice.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        txtSellPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtSellPrice.Location = new System.Drawing.Point(349, 323);
        txtSellPrice.Name = "txtSellPrice";
        txtSellPrice.Size = new System.Drawing.Size(250, 29);
        txtSellPrice.TabIndex = 10;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label1.Location = new System.Drawing.Point(74, 120);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(126, 23);
        label1.TabIndex = 11;
        label1.Text = "Product";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label2.Location = new System.Drawing.Point(349, 120);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(126, 23);
        label2.TabIndex = 12;
        label2.Text = "Category";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label3.Location = new System.Drawing.Point(74, 198);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(126, 23);
        label3.TabIndex = 13;
        label3.Text = "Mfg. Date";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label4.Location = new System.Drawing.Point(349, 198);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(126, 23);
        label4.TabIndex = 14;
        label4.Text = "Exp. Date";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label5.Location = new System.Drawing.Point(349, 288);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(126, 23);
        label5.TabIndex = 16;
        label5.Text = "Sell Price";
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label6.Location = new System.Drawing.Point(74, 288);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(126, 23);
        label6.TabIndex = 15;
        label6.Text = "Quantity";
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label7.Location = new System.Drawing.Point(628, 120);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(126, 23);
        label7.TabIndex = 17;
        label7.Text = "Description";
        // 
        // frmAddproduct
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(1027, 710);
        Controls.Add(label7);
        Controls.Add(label5);
        Controls.Add(label6);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtSellPrice);
        Controls.Add(txtQuantity);
        Controls.Add(gridViewProductList);
        Controls.Add(btnAddProduct);
        Controls.Add(richTxtDescription);
        Controls.Add(dtPickerExpDate);
        Controls.Add(dtPickerMfgDate);
        Controls.Add(cbCategory);
        Controls.Add(txtProductName);
        Text = "frmAddProduct";
        Load += frmAddproduct_Load;
        ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.DataGridView gridViewProductList;

    private System.Windows.Forms.Button btnAddProduct;

    private System.Windows.Forms.RichTextBox richTxtDescription;

    private System.Windows.Forms.DateTimePicker dtPickerExpDate;

    private System.Windows.Forms.DateTimePicker dtPickerMfgDate;

    private System.Windows.Forms.ComboBox cbCategory;

    private System.Windows.Forms.TextBox txtQuantity;
    private System.Windows.Forms.TextBox txtSellPrice;

    private System.Windows.Forms.TextBox txtProductName;

    #endregion
}