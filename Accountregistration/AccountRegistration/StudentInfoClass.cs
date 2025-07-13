namespace AccountRegistration;

public delegate long DelegateNumber(long number);
public delegate string DelegateText(string txt);

public class StudentInfoClass
{
    public static string FirstName ="";
    public static string LastName = "";
    public static string MiddleName = "";
    public static string Address = "";
    public static string Program = "";
    
    public static long Age = 0;
    public static long ContactNo = 0;
    public static long StudentNo = 0;
    
    public static string GetFirstName(string FirstName) => FirstName;
    public static string GetLastName(string LastName) => LastName;
    public static string GetMiddleName(string MiddleName) => MiddleName;
    public static string GetAddress(string Address) => Address;
    public static string GetProgram(string Program) => Program;
    public static long GetAge(long Age) => Age;
    public static long GetContactNo(long ContactNo) => ContactNo;   
    public static long GetStudentNo(long StudentNo) => StudentNo;   
    
    
}