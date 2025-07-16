namespace TextFile;

partial class FrmLab1
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
        btnCreate = new System.Windows.Forms.Button();
        txtInput = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // btnCreate
        // 
        btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        btnCreate.Location = new System.Drawing.Point(147, 182);
        btnCreate.Name = "btnCreate";
        btnCreate.Size = new System.Drawing.Size(199, 35);
        btnCreate.TabIndex = 0;
        btnCreate.Text = "Create";
        btnCreate.UseVisualStyleBackColor = false;
        btnCreate.Click += btnCreate_Click;
        // 
        // txtInput
        // 
        txtInput.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        txtInput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtInput.Location = new System.Drawing.Point(69, 64);
        txtInput.Multiline = true;
        txtInput.Name = "txtInput";
        txtInput.Size = new System.Drawing.Size(341, 82);
        txtInput.TabIndex = 1;
        // 
        // FrmLab1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(484, 320);
        Controls.Add(txtInput);
        Controls.Add(btnCreate);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.TextBox txtInput;

    #endregion
}