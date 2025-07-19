namespace ClubRegistration.WinForms.Entities;

public class ClubMember
{
    public int Id { get; set; }
    public long StudentId { get; set; }
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastnName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public String Program { get; set; }
    
    
}