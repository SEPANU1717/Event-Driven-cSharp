using System.ComponentModel;

namespace BasicThreading.ThreadPriority;

partial class frmTrackThread
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
        btnRun = new System.Windows.Forms.Button();
        lblThreads = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // btnRun
        // 
        btnRun.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        btnRun.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnRun.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        btnRun.Location = new System.Drawing.Point(135, 180);
        btnRun.Name = "btnRun";
        btnRun.Size = new System.Drawing.Size(150, 47);
        btnRun.TabIndex = 0;
        btnRun.Text = "Run";
        btnRun.UseVisualStyleBackColor = false;
        btnRun.Click += btnRun_Click;
        // 
        // lblThreads
        // 
        lblThreads.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblThreads.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        lblThreads.Location = new System.Drawing.Point(86, 89);
        lblThreads.Name = "lblThreads";
        lblThreads.Size = new System.Drawing.Size(284, 57);
        lblThreads.TabIndex = 1;
        lblThreads.Text = "Thread Starts";
        // 
        // frmTrackThread
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(419, 343);
        Controls.Add(lblThreads);
        Controls.Add(btnRun);
        Text = "frmTrackThread";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.Label lblThreads;

    #endregion
}