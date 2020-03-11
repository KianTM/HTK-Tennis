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
                var output = connection.Query<Member>("dbo.Members_GetAll").ToList();
                return output;
            }
        }

        public static Member GetSingle(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                Member output = connection.Query<Member>("dbo.Members_GetSingle @Id", new { Id = id }) as Member;
                return output;
            }
        }

        public static void Insert(Member member)
        {
            string csv = member.GetClassificationsAsCSV();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                connection.Execute("dbo.Members_Insert @Name, @Address, @MobileNumber, @Email, @Birthdate, @Classifications, @Points", new
                {
                    Name = member.Name,
                    Address = member.Address,
                    MobileNumber = member.MobileNumber,
                    Email = member.Email,
                    Birthdate = member.Birthdate,
                    Classifications = csv,
                    Points = member.Points
                });
            }
        }

        public static void Update(Member member)
        {
            string csv = member.GetClassificationsAsCSV();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                connection.Execute("dbo.Members_Update @Id, @Name, @Address, @MobileNumber, @Email, @Birthdate, @Classifications, @Points", new
                {
                    Id = member.ID,
                    Name = member.Name,
                    Address = member.Address,
                    MobileNumber = member.MobileNumber,
                    Email = member.Email,
                    Birthdate = member.Birthdate,
                    Classifications = csv,
                    Points = member.Points
                });
            }
        }

        public static void SetActive(int id, bool active)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                connection.Execute("dbo.Members_SetActive @Id, @Active", new { Id = id, Active = active });
            }
        }
    }
}
