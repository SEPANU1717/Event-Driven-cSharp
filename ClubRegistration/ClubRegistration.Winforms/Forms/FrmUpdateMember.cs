using ClubRegistration.WinForms.Entities;
using ClubRegistration.WinForms.Services;

namespace ClubRegistration.WinForms.Forms;

public partial class FrmUpdateMember : Form
{
    private FrmClubRegistration _mainForm;
    public FrmUpdateMember(FrmClubRegistration mainForm)
    {
        InitializeComponent();
        ComboBoxValues();
        _mainForm = mainForm;
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
    private void UpdateSwitching()
    {
        MessageBox.Show("Member details updated successfully!", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        FrmClubRegistration Register = new();
        Hide();
        Register.ShowDialog();
    }
    private void bConfirm_Click(object sender, EventArgs e)
    {
        
        var updatedInfo = new ClubMember()
        {
            StudentId = long.Parse(UpdateStudID.Text),
            FirstName = UpdateFirstName.Text,
            MiddleName = string.IsNullOrWhiteSpace(UpdateMiddleName.Text) ? null : UpdateMiddleName.Text,
            LastName = UpdatelastName.Text,
            Age = int.Parse(UpdateAge.Text),
            Gender = UpdateGender.SelectedItem?.ToString() ?? "Prefer not to say",
            Program = UpdateProgram.SelectedItem?.ToString()
            
        };
        var service = new ClubRegistrationQuery();
        bool success = service.UpdateClubMember(updatedInfo);

        if (success)
        {
            UpdateSwitching();
            _mainForm.RefreshListOfClubMembers();
            Close(); 
            
        }
        else
        {
            MessageBox.Show("Failed to update","Update failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
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