using ClubRegistration.WinForms.Entities;
using ClubRegistration.WinForms.Services;

namespace ClubRegistration.WinForms.Forms
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, gender, Program;
        private long studentId;

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

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUpdateMember updateMember = new FrmUpdateMember(this);
            Hide();
            updateMember.ShowDialog();
            Show();
        }

        public void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dgListOfClubMembers.DataSource = clubRegistrationQuery.bindingSource;
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListOfClubMembers();
        }

        private int RegistrationId() => ++count;

        private void button1_Click(object sender, EventArgs e)
        {
            Validation();
            var clubMember = new ClubMember
            {
                Id = RegistrationId(),
                StudentId = long.TryParse(tStudentID.Text, out var sid) ? sid : 0,
                FirstName = tFiirstName.Text,
                MiddleName = tMiddleName.Text,
                LastName = tLastName.Text,
                Age = int.TryParse(tAge.Text, out var age) ? age : 0,
                Gender = cGender.SelectedItem?.ToString() ?? "",
                Program = cProgram.SelectedItem?.ToString() ?? ""
            };

            clubRegistrationQuery.RegisterStudent(clubMember);
            RefreshListOfClubMembers();
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void Validation()
        {
            if (string.IsNullOrWhiteSpace(tAge.Text) ||
                string.IsNullOrWhiteSpace(tFiirstName.Text) ||
                string.IsNullOrWhiteSpace(tLastName.Text) ||
                string.IsNullOrWhiteSpace(tStudentID.Text) ||
                cGender.SelectedItem is null ||
                cProgram.SelectedItem is null)
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Successfully registered!", "Registration Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
