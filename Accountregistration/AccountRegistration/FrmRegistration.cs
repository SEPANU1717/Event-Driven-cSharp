namespace AccountRegistration;

public partial class FrmRegistration : Form
{
    public FrmRegistration()
    {
        InitializeComponent();
        string [] programs = { "Bachelor of Science in Information Technology",
                               "Bachelor of Science in Computer Science",
                               "Bachelor of Science in Information System",
                               "Bachelor of Science in Computer Engineering" };
        foreach (var program in programs)
            cboProgram.Items.Add(program);
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
        StudentInfoClass.Program = cboProgram.Text;
        StudentInfoClass.FirstName = txtFirst.Text;
        StudentInfoClass.LastName = txtLast.Text;
        StudentInfoClass.MiddleName = txtMiddle.Text;
        StudentInfoClass.Address = txtAddress.Text;
        StudentInfoClass.Age = long.Parse(txtAge.Text);
        StudentInfoClass.ContactNo = long.Parse(txtContact.Text);
        StudentInfoClass.StudentNo = long.Parse(txtStudNum.Text);
        
        FrmConfirm frmConfirm = new FrmConfirm();
        if (frmConfirm.ShowDialog() == DialogResult.OK)
        {
            ClearFields();
        }
    }
    private void ClearFields()
    {
        txtAddress.Text = string.Empty;
        txtAge.Text = string.Empty;
        txtContact.Text = string.Empty;
        txtFirst.Text = string.Empty;
        txtLast.Text = string.Empty;
        txtMiddle.Text = string.Empty;
        txtStudNum.Text = string.Empty;
        txtContact.Text = string.Empty;
        cboProgram.Text = string.Empty;
    }
}