using System.ComponentModel;

namespace ClubRegistration.WinForms.Forms;

partial class FrmUpdateMember
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
        UpdateStudID = new System.Windows.Forms.ComboBox();
        UpdateGender = new System.Windows.Forms.ComboBox();
        UpdateProgram = new System.Windows.Forms.ComboBox();
        UpdatelastName = new System.Windows.Forms.TextBox();
        UpdateFirstName = new System.Windows.Forms.TextBox();
        UpdateMiddleName = new System.Windows.Forms.TextBox();
        UpdateAge = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        bConfirm = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // UpdateStudID
        // 
        UpdateStudID.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        UpdateStudID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        UpdateStudID.FormattingEnabled = true;
        UpdateStudID.Location = new System.Drawing.Point(384, 163);
        UpdateStudID.Name = "UpdateStudID";
        UpdateStudID.Size = new System.Drawing.Size(258, 33);
        UpdateStudID.TabIndex = 0;
        UpdateStudID.SelectedIndexChanged += UpdateStudID_SelectedIndexChanged;
        // 
        // UpdateGender
        // 
        UpdateGender.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        UpdateGender.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        UpdateGender.FormattingEnabled = true;
        UpdateGender.Location = new System.Drawing.Point(384, 445);
        UpdateGender.Name = "UpdateGender";
        UpdateGender.Size = new System.Drawing.Size(258, 33);
        UpdateGender.TabIndex = 1;
        // 
        // UpdateProgram
        // 
        UpdateProgram.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        UpdateProgram.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        UpdateProgram.FormattingEnabled = true;
        UpdateProgram.Location = new System.Drawing.Point(384, 500);
        UpdateProgram.Name = "UpdateProgram";
        UpdateProgram.Size = new System.Drawing.Size(258, 33);
        UpdateProgram.TabIndex = 2;
        // 
        // UpdatelastName
        // 
        UpdatelastName.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        UpdatelastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        UpdatelastName.Location = new System.Drawing.Point(384, 218);
        UpdatelastName.Name = "UpdatelastName";
        UpdatelastName.Size = new System.Drawing.Size(258, 33);
        UpdatelastName.TabIndex = 3;
        // 
        // UpdateFirstName
        // 
        UpdateFirstName.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        UpdateFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        UpdateFirstName.Location = new System.Drawing.Point(384, 276);
        UpdateFirstName.Name = "UpdateFirstName";
        UpdateFirstName.Size = new System.Drawing.Size(258, 33);
        UpdateFirstName.TabIndex = 4;
        // 
        // UpdateMiddleName
        // 
        UpdateMiddleName.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        UpdateMiddleName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        UpdateMiddleName.Location = new System.Drawing.Point(384, 333);
        UpdateMiddleName.Name = "UpdateMiddleName";
        UpdateMiddleName.Size = new System.Drawing.Size(258, 33);
        UpdateMiddleName.TabIndex = 5;
        // 
        // UpdateAge
        // 
        UpdateAge.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        UpdateAge.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        UpdateAge.Location = new System.Drawing.Point(384, 389);
        UpdateAge.Name = "UpdateAge";
        UpdateAge.Size = new System.Drawing.Size(258, 33);
        UpdateAge.TabIndex = 6;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label1.Location = new System.Drawing.Point(108, 166);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(140, 30);
        label1.TabIndex = 7;
        label1.Text = "Student ID:";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label2.Location = new System.Drawing.Point(108, 221);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(140, 30);
        label2.TabIndex = 8;
        label2.Text = "Last name:";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label3.Location = new System.Drawing.Point(108, 279);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(140, 30);
        label3.TabIndex = 9;
        label3.Text = "First name:";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label4.Location = new System.Drawing.Point(108, 336);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(156, 30);
        label4.TabIndex = 10;
        label4.Text = "Middle name:";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label5.Location = new System.Drawing.Point(108, 392);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(140, 30);
        label5.TabIndex = 11;
        label5.Text = "Age:";
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label6.Location = new System.Drawing.Point(108, 448);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(140, 30);
        label6.TabIndex = 12;
        label6.Text = "Gender:";
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label7.Location = new System.Drawing.Point(108, 503);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(140, 30);
        label7.TabIndex = 13;
        label7.Text = "Program:";
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label8.Location = new System.Drawing.Point(217, 50);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(349, 45);
        label8.TabIndex = 14;
        label8.Text = "Update Club Members";
        // 
        // bConfirm
        // 
        bConfirm.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        bConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        bConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        bConfirm.Location = new System.Drawing.Point(502, 567);
        bConfirm.Name = "bConfirm";
        bConfirm.Size = new System.Drawing.Size(140, 38);
        bConfirm.TabIndex = 15;
        bConfirm.Text = "Confirm";
        bConfirm.UseVisualStyleBackColor = false;
        bConfirm.Click += bConfirm_Click;
        // 
        // FrmUpdateMember
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(759, 693);
        Controls.Add(bConfirm);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(UpdateAge);
        Controls.Add(UpdateMiddleName);
        Controls.Add(UpdateFirstName);
        Controls.Add(UpdatelastName);
        Controls.Add(UpdateProgram);
        Controls.Add(UpdateGender);
        Controls.Add(UpdateStudID);
        Text = "FrmUpdateMember";
        Load += FrmUpdateMember_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button bConfirm;

    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox UpdateFirstName;
    private System.Windows.Forms.TextBox UpdateMiddleName;
    private System.Windows.Forms.TextBox UpdateAge;

    private System.Windows.Forms.ComboBox UpdateGender;
    private System.Windows.Forms.ComboBox UpdateProgram;
    private System.Windows.Forms.TextBox UpdatelastName;

    private System.Windows.Forms.ComboBox UpdateStudID;

    #endregion
}