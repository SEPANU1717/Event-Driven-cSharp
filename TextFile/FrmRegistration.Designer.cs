using System.ComponentModel;

namespace TextFile;

partial class FrmRegistration
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
        tStudentNum = new System.Windows.Forms.TextBox();
        cProgram = new System.Windows.Forms.ComboBox();
        tLast = new System.Windows.Forms.TextBox();
        tFirst = new System.Windows.Forms.TextBox();
        tMiidle = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        cGender = new System.Windows.Forms.ComboBox();
        tContact = new System.Windows.Forms.TextBox();
        tAge = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        dtpBday = new System.Windows.Forms.DateTimePicker();
        bRegister = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // tStudentNum
        // 
        tStudentNum.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        tStudentNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tStudentNum.Location = new System.Drawing.Point(63, 138);
        tStudentNum.Name = "tStudentNum";
        tStudentNum.Size = new System.Drawing.Size(226, 33);
        tStudentNum.TabIndex = 0;
        // 
        // cProgram
        // 
        cProgram.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        cProgram.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cProgram.FormattingEnabled = true;
        cProgram.Location = new System.Drawing.Point(315, 138);
        cProgram.Name = "cProgram";
        cProgram.Size = new System.Drawing.Size(341, 33);
        cProgram.TabIndex = 1;
        // 
        // tLast
        // 
        tLast.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        tLast.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tLast.Location = new System.Drawing.Point(63, 225);
        tLast.Name = "tLast";
        tLast.Size = new System.Drawing.Size(226, 33);
        tLast.TabIndex = 2;
        // 
        // tFirst
        // 
        tFirst.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        tFirst.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tFirst.Location = new System.Drawing.Point(315, 225);
        tFirst.Name = "tFirst";
        tFirst.Size = new System.Drawing.Size(226, 33);
        tFirst.TabIndex = 3;
        // 
        // tMiidle
        // 
        tMiidle.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        tMiidle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tMiidle.Location = new System.Drawing.Point(567, 225);
        tMiidle.Name = "tMiidle";
        tMiidle.Size = new System.Drawing.Size(89, 33);
        tMiidle.TabIndex = 4;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label1.Location = new System.Drawing.Point(63, 103);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(171, 32);
        label1.TabIndex = 5;
        label1.Text = "Student Number";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label2.Location = new System.Drawing.Point(315, 103);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(171, 32);
        label2.TabIndex = 6;
        label2.Text = "Program";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label3.Location = new System.Drawing.Point(63, 190);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(171, 32);
        label3.TabIndex = 7;
        label3.Text = "Last Name";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label4.Location = new System.Drawing.Point(315, 190);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(171, 32);
        label4.TabIndex = 8;
        label4.Text = "First Name";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label5.Location = new System.Drawing.Point(567, 190);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(171, 32);
        label5.TabIndex = 9;
        label5.Text = "M.I.";
        // 
        // cGender
        // 
        cGender.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        cGender.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cGender.FormattingEnabled = true;
        cGender.Location = new System.Drawing.Point(315, 322);
        cGender.Name = "cGender";
        cGender.Size = new System.Drawing.Size(226, 33);
        cGender.TabIndex = 10;
        // 
        // tContact
        // 
        tContact.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        tContact.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tContact.Location = new System.Drawing.Point(63, 322);
        tContact.Name = "tContact";
        tContact.Size = new System.Drawing.Size(226, 33);
        tContact.TabIndex = 11;
        // 
        // tAge
        // 
        tAge.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        tAge.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tAge.Location = new System.Drawing.Point(567, 322);
        tAge.Name = "tAge";
        tAge.Size = new System.Drawing.Size(89, 33);
        tAge.TabIndex = 12;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label6.Location = new System.Drawing.Point(567, 287);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(171, 32);
        label6.TabIndex = 15;
        label6.Text = "Age";
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label7.Location = new System.Drawing.Point(315, 287);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(171, 32);
        label7.TabIndex = 14;
        label7.Text = "Gender";
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label8.Location = new System.Drawing.Point(63, 287);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(171, 32);
        label8.TabIndex = 13;
        label8.Text = "ContactNumber";
        // 
        // label9
        // 
        label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label9.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label9.Location = new System.Drawing.Point(63, 382);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(171, 32);
        label9.TabIndex = 16;
        label9.Text = "Birthday";
        // 
        // dtpBday
        // 
        dtpBday.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpBday.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        dtpBday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpBday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpBday.Location = new System.Drawing.Point(63, 417);
        dtpBday.Name = "dtpBday";
        dtpBday.Size = new System.Drawing.Size(226, 29);
        dtpBday.TabIndex = 17;
        // 
        // bRegister
        // 
        bRegister.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        bRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        bRegister.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        bRegister.Location = new System.Drawing.Point(518, 471);
        bRegister.Name = "bRegister";
        bRegister.Size = new System.Drawing.Size(140, 33);
        bRegister.TabIndex = 18;
        bRegister.Text = "Register";
        bRegister.UseVisualStyleBackColor = false;
        bRegister.Click += bRegister_Click;
        // 
        // FrmRegistration
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(724, 588);
        Controls.Add(bRegister);
        Controls.Add(dtpBday);
        Controls.Add(label9);
        Controls.Add(label6);
        Controls.Add(label7);
        Controls.Add(label8);
        Controls.Add(tAge);
        Controls.Add(tContact);
        Controls.Add(cGender);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(tMiidle);
        Controls.Add(tFirst);
        Controls.Add(tLast);
        Controls.Add(cProgram);
        Controls.Add(tStudentNum);
        Text = "FrmRegistration";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button bRegister;

    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.DateTimePicker dtpBday;

    private System.Windows.Forms.TextBox tContact;
    private System.Windows.Forms.TextBox tAge;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.ComboBox cGender;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox tFirst;
    private System.Windows.Forms.TextBox tMiidle;

    private System.Windows.Forms.TextBox tLast;

    private System.Windows.Forms.ComboBox cProgram;

    private System.Windows.Forms.TextBox tStudentNum;

    #endregion
}