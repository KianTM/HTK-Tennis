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
    public class ClassificationRepository
    {
        public static List<Classification> GetAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                var output = connection.Query<Classification>("dbo.Classifications_GetAll").ToList();
                return output;
            }
        }

        public static Classification GetSingle(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                Classification output = connection.Query<Classification>("dbo.Classifications_GetSingle @Id", id) as Classification;
                return output;
            }
        }

        public static void Insert(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                connection.Execute("dbo.Classifications_Insert @Name", name);
            }
        }

        public static void Delete(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                connection.Execute("dbo.Classifications_Delete @Id", id);
            }
        }

        public static void Update(int id, string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                connection.Execute("dbo.Classifications_Update @Id, @Name", new { Id = id, Name = name });
            }
        }
    }
}
