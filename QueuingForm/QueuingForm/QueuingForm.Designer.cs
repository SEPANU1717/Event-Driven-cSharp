using System.ComponentModel;

namespace QueuingForm;

partial class QueuingForm
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
        btnCashier = new System.Windows.Forms.Button();
        lblQueue = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // btnCashier
        // 
        btnCashier.BackColor = System.Drawing.Color.FromArgb(((int)((byte)152)), ((int)((byte)193)), ((int)((byte)217)));
        btnCashier.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnCashier.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        btnCashier.Location = new System.Drawing.Point(102, 90);
        btnCashier.Name = "btnCashier";
        btnCashier.Size = new System.Drawing.Size(172, 144);
        btnCashier.TabIndex = 0;
        btnCashier.Text = "Cashier";
        btnCashier.UseVisualStyleBackColor = false;
        // 
        // lblQueue
        // 
        lblQueue.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblQueue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        lblQueue.Location = new System.Drawing.Point(348, 151);
        lblQueue.Name = "lblQueue";
        lblQueue.Size = new System.Drawing.Size(350, 83);
        lblQueue.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label1.Location = new System.Drawing.Point(393, 90);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(254, 53);
        label1.TabIndex = 2;
        label1.Text = "Position in Queue";
        // 
        // QueuingForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(789, 329);
        Controls.Add(label1);
        Controls.Add(lblQueue);
        Controls.Add(btnCashier);
        Text = "QueuingForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button btnCashier;
    private System.Windows.Forms.Label lblQueue;

    #endregion
}