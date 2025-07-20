using System.Data;
using ClubRegistration.WinForms.Entities;

namespace ClubRegistration.WinForms.Interfaces;

public interface IClubRegistrationQuery
{
    bool RegisterStudent(ClubMember clubMember);
    DataTable DisplayList();
    bool UpdateClubMember(ClubMember clubMember);
    public List<long> GetAllStudentIds();

    ClubMember GetClubMemberById(long id);
}