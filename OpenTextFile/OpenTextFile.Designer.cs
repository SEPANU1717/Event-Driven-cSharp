namespace OpenTextFile;

partial class OpenTextFile
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
        lvShowText = new System.Windows.Forms.ListView();
        btnOpen = new System.Windows.Forms.Button();
        openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        SuspendLayout();
        // 
        // lvShowText
        // 
        lvShowText.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        lvShowText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lvShowText.ForeColor = System.Drawing.SystemColors.WindowText;
        lvShowText.Location = new System.Drawing.Point(12, 12);
        lvShowText.Name = "lvShowText";
        lvShowText.Size = new System.Drawing.Size(710, 301);
        lvShowText.TabIndex = 0;
        lvShowText.UseCompatibleStateImageBehavior = false;
        lvShowText.View = System.Windows.Forms.View.Tile;
        // 
        // btnOpen
        // 
        btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        btnOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        btnOpen.Location = new System.Drawing.Point(270, 351);
        btnOpen.Name = "btnOpen";
        btnOpen.Size = new System.Drawing.Size(182, 49);
        btnOpen.TabIndex = 1;
        btnOpen.Text = "Open";
        btnOpen.UseVisualStyleBackColor = false;
        btnOpen.Click += btnOpen_Click;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(734, 450);
        Controls.Add(btnOpen);
        Controls.Add(lvShowText);
        Text = "frmOpenTextFile";
        ResumeLayout(false);
    }

    private System.Windows.Forms.OpenFileDialog openFileDialog1;

    private System.Windows.Forms.Button btnOpen;

    private System.Windows.Forms.ListView lvShowText;

    #endregion
}