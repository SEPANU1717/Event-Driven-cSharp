namespace ClubRegistration.WinForms.Forms;

public partial class FrmUpdateMember : Form
{
    public FrmUpdateMember()
    {
        InitializeComponent();
        ComboBoxValues();
    }

    private void ComboBoxValues()
    {
        UpdateProgram.Items.AddRange(new object[]
        {
            "BS in Computer Science",
            "BS in Information Technology",
            "BS in Information Systems",
            "BS in Computer Engineering",
            "BS in Software Engineering",
            "BS in Data Science",
        });

        UpdateGender.Items.AddRange(new object[]
        {
            "Male", "Female", "Prefer not to say", "Other"
        });
    }
}