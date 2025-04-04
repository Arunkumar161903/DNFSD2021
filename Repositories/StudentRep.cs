using System.Data.SqlClient;
using Apihome.Models;

namespace Apihome.Repositories
{
    public class StudentRep
    {
        private readonly string _com;

        public StudentRep(IConfiguration configuration)
        {
            _com = configuration.GetConnectionString("com");
        }
        public List<Student> Get()
        {
            List<Student> std = new List<Student>();
            using (SqlConnection con = new SqlConnection(_com))
            {
                SqlCommand cmd = new SqlCommand("SELECT*FROM student", con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    std.Add(new Student
                    {
                        Id = (int)reader["Id"],

                        Name = reader["Name"].ToString(),

                        Age = (int)reader["Age"],

                        Salary = (Decimal)reader["Salary"]
                    });
                }
                return std;
            }
        
        }
        //Get student by id
        public Student GetStudentById(int id)
        {


        }

    }
}
