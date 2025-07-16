using System.ComponentModel;

namespace TextFile;

partial class FrmFileName
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        btnOkay = new System.Windows.Forms.Button();
        txtFileName = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // btnOkay
        // 
        btnOkay.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        btnOkay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnOkay.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        btnOkay.Location = new System.Drawing.Point(124, 188);
        btnOkay.Name = "btnOkay";
        btnOkay.Size = new System.Drawing.Size(195, 33);
        btnOkay.TabIndex = 0;
        btnOkay.Text = "Okay";
        btnOkay.UseVisualStyleBackColor = false;
        btnOkay.Click += btnOkay_Click;
        // 
        // txtFileName
        // 
        txtFileName.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        txtFileName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtFileName.Location = new System.Drawing.Point(70, 111);
        txtFileName.Name = "txtFileName";
        txtFileName.Size = new System.Drawing.Size(303, 35);
        txtFileName.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label1.Location = new System.Drawing.Point(70, 72);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(163, 23);
        label1.TabIndex = 2;
        label1.Text = "Enter File Name";
        // 
        // FrmFileName
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(447, 293);
        Controls.Add(label1);
        Controls.Add(txtFileName);
        Controls.Add(btnOkay);
        Text = "FrmFileName";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button btnOkay;
    private System.Windows.Forms.TextBox txtFileName;

    #endregion
}