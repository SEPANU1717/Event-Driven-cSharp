using System.ComponentModel;

namespace BasicQueuingCashier.Forms;

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
        label2 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // btnCashier
        // 
        btnCashier.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        btnCashier.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnCashier.Location = new System.Drawing.Point(78, 128);
        btnCashier.Name = "btnCashier";
        btnCashier.Size = new System.Drawing.Size(143, 122);
        btnCashier.TabIndex = 0;
        btnCashier.Text = "Cashier";
        btnCashier.UseVisualStyleBackColor = false;
        btnCashier.Click += btnCashier_Click;
        // 
        // lblQueue
        // 
        lblQueue.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblQueue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        lblQueue.Location = new System.Drawing.Point(285, 167);
        lblQueue.Name = "lblQueue";
        lblQueue.Size = new System.Drawing.Size(346, 83);
        lblQueue.TabIndex = 1;
        lblQueue.Text = "P - 10000";
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label1.Location = new System.Drawing.Point(303, 118);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(287, 60);
        label1.TabIndex = 2;
        label1.Text = "Position in Queue";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)152)), ((int)((byte)193)), ((int)((byte)217)));
        label2.Location = new System.Drawing.Point(78, 266);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(343, 60);
        label2.TabIndex = 3;
        label2.Text = "Click to get a number";
        label2.Click += label2_Click;
        // 
        // QueuingForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(671, 356);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(lblQueue);
        Controls.Add(btnCashier);
        Text = "QueuingForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Label lblQueue;

    private System.Windows.Forms.Button btnCashier;

    #endregion
}