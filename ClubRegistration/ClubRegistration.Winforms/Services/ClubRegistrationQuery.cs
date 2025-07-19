using System.Data;
using System.Data.Common;
using ClubRegistration.WinForms.Entities;
using ClubRegistration.WinForms.Interfaces;
using Microsoft.Data.SqlClient;

namespace ClubRegistration.WinForms.Services;

public class ClubRegistrationQuery : IClubRegistrationQuery
{
    private SqlConnection sqlConnect;
    private SqlCommand sqlCommand;
    private DataAdapter sqlAdapter;
    private SqlDataReader sqlDataReader;
    
    public BindingSource bindingSource;
    public DataTable dataTable;
    private string connectionString;

    public ClubRegistrationQuery()
    {
        connectionString = DbConnectionString.Value;
        sqlConnect = new SqlConnection(connectionString);
        dataTable = new DataTable();
        bindingSource = new BindingSource();
    }

    public bool RegisterStudent(ClubMember clubMember)
    {
        throw new NotImplementedException();
    }

    public DataTable DisplayList()
    {
        string query = "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";
        return dataTable;
    }

    public bool UpdateClubMember(ClubMember clubMember)
    {
        throw new NotImplementedException();
    }
}
