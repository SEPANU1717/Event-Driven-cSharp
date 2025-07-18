namespace BasicCalculator;

partial class FrmBasicCalculator
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
        cbOperator = new System.Windows.Forms.ComboBox();
        label1 = new System.Windows.Forms.Label();
        txtNum1 = new System.Windows.Forms.TextBox();
        txtNum2 = new System.Windows.Forms.TextBox();
        panel1 = new System.Windows.Forms.Panel();
        label2 = new System.Windows.Forms.Label();
        lblTotal = new System.Windows.Forms.Label();
        btnCompute = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // cbOperator
        // 
        cbOperator.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        cbOperator.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbOperator.FormattingEnabled = true;
        cbOperator.Location = new System.Drawing.Point(181, 122);
        cbOperator.Name = "cbOperator";
        cbOperator.Size = new System.Drawing.Size(121, 33);
        cbOperator.TabIndex = 0;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label1.Location = new System.Drawing.Point(54, 62);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(199, 38);
        label1.TabIndex = 1;
        label1.Text = "Basic Calculator";
        // 
        // txtNum1
        // 
        txtNum1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        txtNum1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtNum1.Location = new System.Drawing.Point(54, 122);
        txtNum1.Name = "txtNum1";
        txtNum1.Size = new System.Drawing.Size(121, 33);
        txtNum1.TabIndex = 2;
        // 
        // txtNum2
        // 
        txtNum2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        txtNum2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtNum2.Location = new System.Drawing.Point(308, 122);
        txtNum2.Name = "txtNum2";
        txtNum2.Size = new System.Drawing.Size(121, 33);
        txtNum2.TabIndex = 3;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        panel1.Controls.Add(lblTotal);
        panel1.Controls.Add(label2);
        panel1.ForeColor = System.Drawing.Color.Black;
        panel1.Location = new System.Drawing.Point(54, 175);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(375, 100);
        panel1.TabIndex = 4;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        label2.Location = new System.Drawing.Point(3, 12);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 0;
        label2.Text = "Total:";
        // 
        // lblTotal
        // 
        lblTotal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        lblTotal.Location = new System.Drawing.Point(24, 35);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new System.Drawing.Size(161, 47);
        lblTotal.TabIndex = 1;
        lblTotal.Text = "Total:";
        // 
        // btnCompute
        // 
        btnCompute.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        btnCompute.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnCompute.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        btnCompute.Location = new System.Drawing.Point(308, 295);
        btnCompute.Name = "btnCompute";
        btnCompute.Size = new System.Drawing.Size(121, 34);
        btnCompute.TabIndex = 5;
        btnCompute.Text = "Compute";
        btnCompute.UseVisualStyleBackColor = false;
        btnCompute.Click += btnCompute_Click;
        // 
        // FrmBasicCalculator
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(491, 430);
        Controls.Add(btnCompute);
        Controls.Add(panel1);
        Controls.Add(txtNum2);
        Controls.Add(txtNum1);
        Controls.Add(label1);
        Controls.Add(cbOperator);
        Text = "Form1";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnCompute;

    private System.Windows.Forms.Label lblTotal;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.TextBox txtNum2;

    private System.Windows.Forms.ComboBox cbOperator;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNum1;

    #endregion
}