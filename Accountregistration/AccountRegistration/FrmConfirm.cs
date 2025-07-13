namespace AccountRegistration;

public partial class FrmConfirm : Form
{
    private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
    private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
    
    public FrmConfirm()
    {
        InitializeComponent();
        DelProgram = StudentInfoClass.GetProgram;
        DelLastName = StudentInfoClass.GetLastName;
        DelFirstName = StudentInfoClass.GetFirstName;
        DelMiddleName = StudentInfoClass.GetMiddleName;
        DelAddress = StudentInfoClass.GetAddress;
        DelNumAge = StudentInfoClass.GetAge;
        DelNumContactNo = StudentInfoClass.GetContactNo;
        DelStudNo = StudentInfoClass.GetStudentNo;
    }

    private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult = DialogResult.OK;
    }

    private void FrmConfirm_Load(object sender, EventArgs e)
    {
        lblAddress.Text = DelAddress(StudentInfoClass.Address);
        lblFirst.Text = DelFirstName(StudentInfoClass.FirstName);
        lblMiddle.Text = DelMiddleName(StudentInfoClass.MiddleName);
        lblLast.Text = DelLastName(StudentInfoClass.LastName);
        lblProgram.Text = DelProgram(StudentInfoClass.Program);
        lblAddress.Text = StudentInfoClass.Address;
        lblAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
        lblStud.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
        lblContact.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
        
    }
}
