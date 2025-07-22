namespace BasicThreading;

partial class FrmBasicThread
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
        btnRun = new System.Windows.Forms.Button();
        lblThread = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // btnRun
        // 
        btnRun.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        btnRun.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnRun.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        btnRun.Location = new System.Drawing.Point(187, 243);
        btnRun.Name = "btnRun";
        btnRun.Size = new System.Drawing.Size(136, 50);
        btnRun.TabIndex = 0;
        btnRun.Text = "Run";
        btnRun.UseVisualStyleBackColor = false;
        btnRun.Click += btnRun_Click;
        // 
        // lblThread
        // 
        lblThread.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblThread.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        lblThread.Location = new System.Drawing.Point(58, 115);
        lblThread.Name = "lblThread";
        lblThread.Size = new System.Drawing.Size(417, 61);
        lblThread.TabIndex = 1;
        lblThread.Text = "Before starting thread";
        // 
        // FrmBasicThread
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(519, 450);
        Controls.Add(lblThread);
        Controls.Add(btnRun);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.Label lblThread;

    #endregion
}