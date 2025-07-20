namespace ClubRegistration.WinForms.Forms;

partial class FrmClubRegistration
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
        tStudentID = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        tLastName = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        tMiddleName = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        tAge = new System.Windows.Forms.TextBox();
        cProgram = new System.Windows.Forms.ComboBox();
        tFiirstName = new System.Windows.Forms.TextBox();
        cGender = new System.Windows.Forms.ComboBox();
        Gender = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        dgListOfClubMembers = new System.Windows.Forms.DataGridView();
        label7 = new System.Windows.Forms.Label();
        bRefresh = new System.Windows.Forms.Button();
        btnRegister = new System.Windows.Forms.Button();
        btnUpdate = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgListOfClubMembers).BeginInit();
        SuspendLayout();
        // 
        // tStudentID
        // 
        tStudentID.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        tStudentID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tStudentID.Location = new System.Drawing.Point(64, 197);
        tStudentID.Name = "tStudentID";
        tStudentID.Size = new System.Drawing.Size(252, 33);
        tStudentID.TabIndex = 0;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label1.Location = new System.Drawing.Point(64, 160);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(132, 34);
        label1.TabIndex = 1;
        label1.Text = "Student ID";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label2.Location = new System.Drawing.Point(64, 268);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(132, 34);
        label2.TabIndex = 3;
        label2.Text = "Last name";
        // 
        // tLastName
        // 
        tLastName.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        tLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tLastName.Location = new System.Drawing.Point(64, 305);
        tLastName.Name = "tLastName";
        tLastName.Size = new System.Drawing.Size(252, 33);
        tLastName.TabIndex = 2;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label3.Location = new System.Drawing.Point(350, 268);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(132, 34);
        label3.TabIndex = 5;
        label3.Text = "Fiirst name";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label4.Location = new System.Drawing.Point(635, 268);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(148, 34);
        label4.TabIndex = 7;
        label4.Text = "Middle name";
        // 
        // tMiddleName
        // 
        tMiddleName.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        tMiddleName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tMiddleName.Location = new System.Drawing.Point(635, 305);
        tMiddleName.Name = "tMiddleName";
        tMiddleName.Size = new System.Drawing.Size(252, 33);
        tMiddleName.TabIndex = 6;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label5.Location = new System.Drawing.Point(467, 42);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(316, 70);
        label5.TabIndex = 8;
        label5.Text = "Club Registration";
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label6.Location = new System.Drawing.Point(64, 377);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(132, 34);
        label6.TabIndex = 10;
        label6.Text = "Age";
        // 
        // tAge
        // 
        tAge.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        tAge.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tAge.Location = new System.Drawing.Point(64, 414);
        tAge.Name = "tAge";
        tAge.Size = new System.Drawing.Size(252, 33);
        tAge.TabIndex = 9;
        // 
        // cProgram
        // 
        cProgram.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        cProgram.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cProgram.FormattingEnabled = true;
        cProgram.Location = new System.Drawing.Point(350, 197);
        cProgram.Name = "cProgram";
        cProgram.Size = new System.Drawing.Size(537, 33);
        cProgram.TabIndex = 11;
        // 
        // tFiirstName
        // 
        tFiirstName.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        tFiirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tFiirstName.Location = new System.Drawing.Point(350, 305);
        tFiirstName.Name = "tFiirstName";
        tFiirstName.Size = new System.Drawing.Size(252, 33);
        tFiirstName.TabIndex = 4;
        // 
        // cGender
        // 
        cGender.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        cGender.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cGender.FormattingEnabled = true;
        cGender.Location = new System.Drawing.Point(350, 414);
        cGender.Name = "cGender";
        cGender.Size = new System.Drawing.Size(252, 33);
        cGender.TabIndex = 12;
        // 
        // Gender
        // 
        Gender.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Gender.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        Gender.Location = new System.Drawing.Point(350, 377);
        Gender.Name = "Gender";
        Gender.Size = new System.Drawing.Size(132, 34);
        Gender.TabIndex = 13;
        Gender.Text = "Gender";
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label8.Location = new System.Drawing.Point(350, 160);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(132, 34);
        label8.TabIndex = 14;
        label8.Text = "Program";
        // 
        // dgListOfClubMembers
        // 
        dgListOfClubMembers.BackgroundColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        dgListOfClubMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgListOfClubMembers.Location = new System.Drawing.Point(64, 539);
        dgListOfClubMembers.Name = "dgListOfClubMembers";
        dgListOfClubMembers.Size = new System.Drawing.Size(823, 217);
        dgListOfClubMembers.TabIndex = 15;
        dgListOfClubMembers.Text = "dataGridView1";
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        label7.Location = new System.Drawing.Point(64, 502);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(225, 34);
        label7.TabIndex = 16;
        label7.Text = "List of Club Members";
        // 
        // bRefresh
        // 
        bRefresh.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        bRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        bRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        bRefresh.Location = new System.Drawing.Point(957, 539);
        bRefresh.Name = "bRefresh";
        bRefresh.Size = new System.Drawing.Size(140, 47);
        bRefresh.TabIndex = 17;
        bRefresh.Text = "Refresh";
        bRefresh.UseVisualStyleBackColor = false;
        bRefresh.Click += bRefresh_Click;
        // 
        // btnRegister
        // 
        btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        btnRegister.Location = new System.Drawing.Point(957, 197);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new System.Drawing.Size(140, 47);
        btnRegister.TabIndex = 18;
        btnRegister.Text = "Register";
        btnRegister.UseVisualStyleBackColor = false;
        btnRegister.Click += button1_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)251)), ((int)((byte)252)));
        btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        btnUpdate.Location = new System.Drawing.Point(957, 268);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new System.Drawing.Size(140, 47);
        btnUpdate.TabIndex = 19;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.Click += button2_Click;
        // 
        // FrmClubRegistration
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)61)), ((int)((byte)90)), ((int)((byte)128)));
        ClientSize = new System.Drawing.Size(1221, 842);
        Controls.Add(btnUpdate);
        Controls.Add(btnRegister);
        Controls.Add(bRefresh);
        Controls.Add(label7);
        Controls.Add(dgListOfClubMembers);
        Controls.Add(label8);
        Controls.Add(Gender);
        Controls.Add(cGender);
        Controls.Add(cProgram);
        Controls.Add(label6);
        Controls.Add(tAge);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(tMiddleName);
        Controls.Add(label3);
        Controls.Add(tFiirstName);
        Controls.Add(label2);
        Controls.Add(tLastName);
        Controls.Add(label1);
        Controls.Add(tStudentID);
        Text = "Form1";
        Load += FrmClubRegistration_Load;
        ((System.ComponentModel.ISupportInitialize)dgListOfClubMembers).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Button btnUpdate;

    private System.Windows.Forms.Button bRefresh;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.DataGridView dgListOfClubMembers;

    private System.Windows.Forms.Label Gender;
    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.ComboBox cGender;

    private System.Windows.Forms.ComboBox cProgram;

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tAge;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tLastName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tFiirstName;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tMiddleName;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox tStudentID;

    #endregion
}