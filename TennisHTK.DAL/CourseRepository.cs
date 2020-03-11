using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisHTK.Entities;

namespace TennisHTK.DAL
{
    public class CourseRepository
    {
        public static List<Course> GetAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                var output = connection.Query<Course>("dbo.Courses_GetAll").ToList();
                return output;
            }
        }

        public static Course GetSingle(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                var output = connection.Query<Course>("dbo.Courses_GetSingle @Id", id) as Course;
                return output;
            }
        }

        public static void Insert(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                connection.Execute("dbo.Courses_Insert @Name", name);
            }
        }

        public static void Update(int id, string name, DateTime? renovationStart = null)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                connection.Execute("dbo.Courses_Update @Id, @Name, @RenovationStart", new { Id = id, Name = name, RenovationStart = renovationStart });
            }
        }

        public static void SetUnderRenovation(int id, bool underRenovation)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                connection.Execute("dbo.Courses_SetUnderRenovation @Id, @UnderRenovation", new { Id = id, UnderRenovation = underRenovation });
            }
        }
    }
}
