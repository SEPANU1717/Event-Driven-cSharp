using System.ComponentModel;

namespace TextFile;

partial class FrmStudentRecord
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
        listView1 = new System.Windows.Forms.ListView();
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // listView1
        // 
        listView1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        listView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        listView1.Location = new System.Drawing.Point(49, 88);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(548, 305);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.List;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label1.Location = new System.Drawing.Point(49, 41);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(200, 44);
        label1.TabIndex = 1;
        label1.Text = "View Record";
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        button1.Location = new System.Drawing.Point(620, 88);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(140, 40);
        button1.TabIndex = 2;
        button1.Text = "Register";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        button2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        button2.Location = new System.Drawing.Point(620, 143);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(140, 40);
        button2.TabIndex = 3;
        button2.Text = "Find";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        button3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        button3.Location = new System.Drawing.Point(620, 199);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(140, 40);
        button3.TabIndex = 4;
        button3.Text = "Upload";
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // FrmStudentRecord
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(809, 450);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label1);
        Controls.Add(listView1);
        Text = "FrmStudentRecord";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ListView listView1;

    #endregion
}