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
    }
}
