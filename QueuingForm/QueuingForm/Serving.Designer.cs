using System.ComponentModel;

namespace QueuingForm;

partial class Serving
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
        label1 = new System.Windows.Forms.Label();
        lblServing = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label1.Location = new System.Drawing.Point(83, 71);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(320, 78);
        label1.TabIndex = 0;
        label1.Text = "Now Serving";
        // 
        // lblServing
        // 
        lblServing.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblServing.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        lblServing.Location = new System.Drawing.Point(144, 202);
        lblServing.Name = "lblServing";
        lblServing.Size = new System.Drawing.Size(603, 133);
        lblServing.TabIndex = 1;
        lblServing.Click += lblServing_Click;
        // 
        // Serving
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(780, 416);
        Controls.Add(lblServing);
        Controls.Add(label1);
        Text = "Serving";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label lblServe;

    private System.Windows.Forms.Label lblServing;

    private System.Windows.Forms.Label label1;

    #endregion
}