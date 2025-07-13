namespace frmBasicThread;

partial class frmBasicThread
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
        button1 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        button1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        button1.Location = new System.Drawing.Point(229, 199);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(139, 54);
        button1.TabIndex = 0;
        button1.Text = "Run";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label1.Location = new System.Drawing.Point(107, 89);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(492, 63);
        label1.TabIndex = 1;
        label1.Text = "Before starting thread";
        // 
        // frmBasicThread
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(634, 388);
        Controls.Add(label1);
        Controls.Add(button1);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;

    #endregion
}