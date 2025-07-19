namespace ClubRegistration.WinForms.Forms;

public partial class FrmClubRegistration : Form
{
    public FrmClubRegistration()
    {
        InitializeComponent();
        ComboBoxValues();
    }

    private void ComboBoxValues()
    {
        cProgram.Items.AddRange(new object[]
        {
            "BS in Computer Science",
            "BS in Information Technology",
            "BS in Information Systems",
            "BS in Computer Engineering",
            "BS in Software Engineering",
            "BS in Data Science",
        });

        cGender.Items.AddRange(new object[]
        {
         "Male", "Female", "Prefer not to say", "Other"
        });
        
    }
    
}