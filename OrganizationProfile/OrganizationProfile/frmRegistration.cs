using System.Text.RegularExpressions;

namespace OrganizationProfile;

public partial class frmRegistration : Form
{
    private string _FullName;
    private int _Age;
    private long _ContactNo;
    private long _StudentNo;

    public frmRegistration()
    {
        InitializeComponent();
    }

    private void frmRegistration_Load(object sender, EventArgs e)
    {
        string[] listOfGender =
        {"Male", "Female", "Prefer not to say"};
        for (int i = 0; i < 3; i++)
        {
            cbGender.Items.Add(listOfGender[i]).ToString();
        }
        
        string[] ListOfProgram =
        {
            "BS in Information Technology",
            "BS in Computer Science",
            "BS in Information System",
            "BS in Computer Accountancy",
            "BS in Hospitality Management",
            "BS in Tourism Management"
        };
        for (int i = 0; i < 6; i++)
        {
            cbPrograms.Items.Add(ListOfProgram[i]);
        }
    }

    
    public long StudentNumber(string studNum)
    {
        try
        {
            if (string.IsNullOrEmpty(studNum))
                throw new ArgumentNullException(nameof(studNum),"Student number cannot be empty.");
            if (!long.TryParse(studNum, out _StudentNo))
                throw new FormatException("Student number cannot be string.");
            if (studNum.Length < 6 || studNum.Length > 12)
                throw new IndexOutOfRangeException("Student number must be between 6 and 12 digits.");

            _StudentNo = long.Parse(studNum);
            return _StudentNo;
        }
        catch (ArgumentNullException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (FormatException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (IndexOutOfRangeException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Console.WriteLine("Student number validation completed.");
        }

        return 0;
    }

    public long ContactNo(string Contact)
    {
        try
        {
            if (string.IsNullOrEmpty(Contact))
                throw new ArgumentNullException(nameof(Contact),"Contact number cannot be empty.");
            if (!Regex.IsMatch(Contact, @"^[0-9]{10,12}$"))
                throw new FormatException("Contact number cannot be numeric.");
            
            _ContactNo = long.Parse(Contact);
            return _ContactNo;
        }
        catch (ArgumentNullException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (FormatException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Console.WriteLine("Contact number validation completed.");
        }
        return 0;
    }

    public string FullName(string LastName, string FirstName, string MiddleInitial)
    {
        try
        {
            
            if (string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(MiddleInitial))
                throw new ArgumentNullException(nameof(_FullName),"Full name fields cannot be empty.");

            if (!Regex.IsMatch(LastName, @"^[a-zA-Z]+$")
                && !Regex.IsMatch(FirstName, @"^[a-zA-Z]+$")
                && !Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
                throw new FormatException("Full name must only contain letters.\"");
            
            if(Regex.IsMatch(LastName,@"\d") || Regex.IsMatch(FirstName,@"\d") || Regex.IsMatch(MiddleInitial,@"\d"))
                throw new FormatException("Full name cannot contain numbers.");
            
            _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            return _FullName;
        }
        catch (ArgumentNullException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (FormatException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Console.WriteLine("Full name validation completed.");
        }

        return string.Empty;
    }
    


    public int Age(string age)
    {
        try
        {
            if (string.IsNullOrEmpty(age))
                throw new ArgumentNullException(nameof(age), "Age cannot be empty.");

            _Age = int.Parse(age);
            if (_Age < 1 || _Age > 120)
                throw new OverflowException("Age must be between 1 and 120.");

            if (!Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                throw new FormatException("Age must be a number between 1 and 120.");
            return _Age;
        }
        catch (ArgumentNullException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (OverflowException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (FormatException ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Console.WriteLine("Student age validation completed.");
        }
        return 0;
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
            StudentInformationClass.SetFullName = FullName(txtLastName.Text,
                txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNo = (int)StudentNumber(txtStudentNo.Text);
            StudentInformationClass.SetProgram = cbPrograms.Text;

            StudentInformationClass.SetGender = cbGender.Text;
            StudentInformationClass.SetContactNo = (int)ContactNo(txtContactNo.Text);
            StudentInformationClass.SetAge = Age(txtAge.Text);
            StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
            
            var frm = new frmConfirmation();
            frm.ShowDialog();
    }
}