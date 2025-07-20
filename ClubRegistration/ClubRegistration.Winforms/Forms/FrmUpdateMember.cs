using ClubRegistration.WinForms.Services;

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

    private void bConfirm_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Member details updated successfully!", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        FrmClubRegistration Register = new();
        Hide();
        Register.ShowDialog();
    }

    private void FrmUpdateMember_Load(object sender, EventArgs e)
    {
        var query = new ClubRegistrationQuery();
        var studentIds = query.GetAllStudentIds();
        UpdateStudID.Items.Clear();
        foreach (var id in studentIds)
        {
            UpdateStudID.Items.Add(id);
        }
    }

    private void UpdateStudID_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (long.TryParse(UpdateStudID.SelectedItem?.ToString(), out long studentId))
        {
            var query = new ClubRegistrationQuery();
            var clubMember = query.GetClubMemberById(studentId);
            if (clubMember != null)
            {
                UpdateFirstName.Text = clubMember.FirstName;
                UpdateMiddleName.Text = clubMember.MiddleName ?? string.Empty;
                UpdatelastName.Text = clubMember.LastName;
                UpdateAge.Text = clubMember.Age.ToString();
                UpdateGender.SelectedItem = clubMember.Gender;
                UpdateProgram.SelectedItem = clubMember.Program;
            }
        }
    }
    }