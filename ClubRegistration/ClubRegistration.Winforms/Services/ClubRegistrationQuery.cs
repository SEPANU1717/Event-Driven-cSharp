using System.Data;
using ClubRegistration.WinForms.Entities;
using ClubRegistration.WinForms.Interfaces;
using Microsoft.Data.SqlClient;

namespace ClubRegistration.WinForms.Services;

public class ClubRegistrationQuery : IClubRegistrationQuery
{
    private SqlConnection sqlConnect;
    private SqlCommand sqlCommand;
    private SqlDataAdapter sqlAdapter;
    private SqlDataReader sqlDataReader;
    
    public BindingSource bindingSource;
    private DataTable dataTable;
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
        using (sqlConnect = new SqlConnection(connectionString))
        using (sqlCommand = new SqlCommand(
                   "INSERT INTO ClubMembers (ID, StudentID, FirstName, MiddleName, LastName, Age, Gender, Program) " +
                   "VALUES (@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect))
        {
            sqlCommand.Parameters.Add("@ID", SqlDbType.BigInt).Value = clubMember.Id;
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = clubMember.StudentId;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = clubMember.FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(clubMember.MiddleName) ? "N/A" : clubMember.MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = clubMember.LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = clubMember.Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = clubMember.Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = clubMember.Program;
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
        }
        return true;
    }

    public DataTable DisplayList()
    {
        var ViewClubMembers = "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";
        using (sqlConnect = new SqlConnection(connectionString))
        using (sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect))
        {
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            return dataTable;
        }
    }

    public bool UpdateClubMember(ClubMember clubMember)
    {
        using (sqlConnect = new SqlConnection(connectionString))
        using (sqlCommand = new SqlCommand(
                   "UPDATE ClubMembers SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, " +
                   "Age = @Age, Gender = @Gender, Program = @Program WHERE StudentId = @StudentId", sqlConnect))
        {
            sqlCommand.Parameters.AddWithValue("@FirstName", clubMember.FirstName);
            sqlCommand.Parameters.AddWithValue("@MiddleName", clubMember.MiddleName ?? "N/A");
            sqlCommand.Parameters.AddWithValue("@LastName", clubMember.LastName);
            sqlCommand.Parameters.AddWithValue("@Age", clubMember.Age);
            sqlCommand.Parameters.AddWithValue("@Gender", clubMember.Gender);
            sqlCommand.Parameters.AddWithValue("@Program", clubMember.Program);
            sqlCommand.Parameters.AddWithValue("@StudentID", clubMember.StudentId);
            
            sqlConnect.Open();
            int rowsAffected = sqlCommand.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }

    public List<long> GetAllStudentIds()
    {
        using (sqlConnect = new SqlConnection(connectionString))
        using (sqlCommand = new SqlCommand("SELECT StudentId FROM ClubMembers", sqlConnect))
        {
            sqlConnect.Open();
            using (var reader = sqlCommand.ExecuteReader())
            {
                var studentIds = new List<long>();
                while (reader.Read())
                {
                    if (long.TryParse(reader["StudentId"].ToString(), out var studentId))
                    {
                        studentIds.Add(studentId);
                    }
                }
                return studentIds;
            }
        }
    }

    public ClubMember GetClubMemberById(long id)
    {
        using (sqlConnect = new SqlConnection(connectionString))
        using (sqlCommand = new SqlCommand("SELECT * FROM ClubMembers WHERE StudentId = @StudentId", sqlConnect))
        {
            sqlCommand.Parameters.Add("@StudentId", SqlDbType.BigInt).Value = id;
            sqlConnect.Open();

            using (var reader = sqlCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new ClubMember
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("ID")),
                        StudentId = reader.GetInt64(reader.GetOrdinal("StudentID")),
                        FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                        MiddleName = reader.IsDBNull(reader.GetOrdinal("MiddleName")) ? null : reader.GetString(reader.GetOrdinal("MiddleName")),
                        LastName = reader.GetString(reader.GetOrdinal("LastName")),
                        Age = reader.GetInt32(reader.GetOrdinal("Age")),
                        Gender = reader.IsDBNull(reader.GetOrdinal("Gender")) ? null : reader.GetString(reader.GetOrdinal("Gender")),
                        Program = reader.IsDBNull(reader.GetOrdinal("Program")) ? null : reader.GetString(reader.GetOrdinal("Program"))
                    };
                }
            }
        }
        return null;
    }
}
