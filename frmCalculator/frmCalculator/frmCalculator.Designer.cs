namespace frmCalculator;

partial class frmCalculator
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
        txtBoxInput1 = new System.Windows.Forms.TextBox();
        txtBoxInput2 = new System.Windows.Forms.TextBox();
        cbOperator = new System.Windows.Forms.ComboBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        btnEqual = new System.Windows.Forms.Button();
        label4 = new System.Windows.Forms.Label();
        lblDisplayTotal = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // txtBoxInput1
        // 
        txtBoxInput1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        txtBoxInput1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBoxInput1.Location = new System.Drawing.Point(226, 141);
        txtBoxInput1.Name = "txtBoxInput1";
        txtBoxInput1.Size = new System.Drawing.Size(128, 29);
        txtBoxInput1.TabIndex = 0;
        // 
        // txtBoxInput2
        // 
        txtBoxInput2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        txtBoxInput2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBoxInput2.Location = new System.Drawing.Point(226, 229);
        txtBoxInput2.Name = "txtBoxInput2";
        txtBoxInput2.Size = new System.Drawing.Size(128, 29);
        txtBoxInput2.TabIndex = 1;
        // 
        // cbOperator
        // 
        cbOperator.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        cbOperator.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbOperator.FormattingEnabled = true;
        cbOperator.Location = new System.Drawing.Point(226, 185);
        cbOperator.Name = "cbOperator";
        cbOperator.Size = new System.Drawing.Size(89, 27);
        cbOperator.TabIndex = 2;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label1.Location = new System.Drawing.Point(33, 141);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(187, 23);
        label1.TabIndex = 3;
        label1.Text = "Enter First Number:";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label2.Location = new System.Drawing.Point(33, 229);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(187, 23);
        label2.TabIndex = 4;
        label2.Text = "Enter Second Number:";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label3.Location = new System.Drawing.Point(33, 185);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(187, 23);
        label3.TabIndex = 5;
        label3.Text = "Select Operator:";
        // 
        // btnEqual
        // 
        btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)((byte)152)), ((int)((byte)193)), ((int)((byte)217)));
        btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnEqual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnEqual.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        btnEqual.Location = new System.Drawing.Point(226, 324);
        btnEqual.Name = "btnEqual";
        btnEqual.Size = new System.Drawing.Size(128, 37);
        btnEqual.TabIndex = 6;
        btnEqual.Text = "Calculate";
        btnEqual.UseVisualStyleBackColor = false;
        btnEqual.Click += btnEqual_Click;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label4.Location = new System.Drawing.Point(141, 285);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(79, 23);
        label4.TabIndex = 7;
        label4.Text = "Answer:";
        // 
        // lblDisplayTotal
        // 
        lblDisplayTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDisplayTotal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        lblDisplayTotal.Location = new System.Drawing.Point(226, 285);
        lblDisplayTotal.Name = "lblDisplayTotal";
        lblDisplayTotal.Size = new System.Drawing.Size(89, 23);
        lblDisplayTotal.TabIndex = 8;
        lblDisplayTotal.Text = "<Answer>";
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label6.Location = new System.Drawing.Point(96, 61);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(240, 36);
        label6.TabIndex = 9;
        label6.Text = "Calculator Application";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(417, 407);
        Controls.Add(label6);
        Controls.Add(lblDisplayTotal);
        Controls.Add(label4);
        Controls.Add(btnEqual);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(cbOperator);
        Controls.Add(txtBoxInput2);
        Controls.Add(txtBoxInput1);
        Text = "frmCalculator";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblDisplayTotal;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnEqual;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox cbOperator;

    private System.Windows.Forms.TextBox txtBoxInput2;

    private System.Windows.Forms.TextBox txtBoxInput1;

    #endregion
}