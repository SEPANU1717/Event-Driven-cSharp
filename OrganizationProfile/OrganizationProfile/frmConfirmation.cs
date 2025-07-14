﻿namespace OrganizationProfile;

public partial class frmConfirmation : Form
{
    public frmConfirmation()
    {
        InitializeComponent();
    }

    private void frmConfirmation_Load(object sender, EventArgs e)
    {
        lblStudNo.Text = StudentInformationClass.SetStudentNo.ToString();
        lblName.Text = StudentInformationClass.SetFullName;
        lblProgram.Text = StudentInformationClass.SetProgram;
        lblBirthday.Text = StudentInformationClass.SetBirthday;
        lblGender.Text = StudentInformationClass.SetGender;
        lblContactNo.Text = StudentInformationClass.SetContactNo.ToString();
        lblAge.Text = StudentInformationClass.SetAge.ToString();
    }
}