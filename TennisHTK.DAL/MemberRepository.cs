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
    public class MemberRepository
    {
        public static List<Member> GetAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                var output = connection.Query<Member>("dbo.GetAll").ToList();
                return output;
            }
        }

        public static Member GetSingle(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                Member output = connection.Query<Member>("dbo.GetSingle @Id", id) as Member;
                return output;
            }
        }

        public static void Insert(string name, string address, string mobileNumber, string email, DateTime birthdate, List<Classification> classifications, int points)
        {
            //using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            //{
            //    connection.Execute("dbo.Member_Insert @Name, @Address, @MobileNumber, @Email, @Birthdate, @Classifications, @Points");
            //}
            throw new NotImplementedException();
        }
    }
}
