namespace TextFile;

public partial class FrmRegistration : Form
{
    FrmFileName frmFile = new();
    public FrmRegistration()
    {
        InitializeComponent();
        ComboBoxValue();
    }

    private void ComboBoxValue()
    {
        cProgram.Items.AddRange(new object[]
        {
            "BS in Information Technology",
            "BS in Computer Science",
            "BS in Information Systems",
            "BS in Computer Engineering"
        });

        cGender.Items.AddRange(new object[]
        {
            "Male", "Female", "Other", "Prefer not to say"
        });
    }

    private bool Validation()
    {
        var fields = new[]
        {
            tAge.Text, tLast.Text, tFirst.Text, tMiidle.Text,
            cProgram.Text, cGender.Text, tContact.Text, tStudentNum.Text
        };

        if (fields.Any(string.IsNullOrWhiteSpace))
        {
            MessageBox.Show(this,"Please enter a field", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            return false;
        }
        return true;
    }

    private void Stream()
    {
        try
        {
            var fileName = FrmFileName.SetFileName;
            var path = Path.Combine(@"C:\Users\emsii\Downloads", fileName);
            var fullName = $"{tFirst.Text} {tMiidle.Text} {tLast.Text}";

            using var writer = new StreamWriter(path);
            writer.WriteLine("Student Number: " + tStudentNum.Text);
            writer.WriteLine("Full Name: " + fullName);
            writer.WriteLine("Program: " + cProgram.Text);
            writer.WriteLine("Gender: " + cGender.Text);
            writer.WriteLine("Age: " + tAge.Text);
            writer.WriteLine("Birthday: " + dtpBday.Text);
            writer.WriteLine("Contact Number: " + tContact.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, "Error writing to file: " + ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            frmFile.Close();
        }
    }

    private void bRegister_Click(object sender, EventArgs e)
    {
        
        if (Validation())
        {
            frmFile.ShowDialog();
            Stream();
            MessageBox.Show(this, "Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}