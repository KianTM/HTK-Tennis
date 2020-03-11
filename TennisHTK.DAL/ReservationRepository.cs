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
    class ReservationRepository
    {
        public static List<Reservation> GetAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                var output = connection.Query<Reservation>("dbo.Reservations_GetAll").ToList();
                return output;
            }
        }

        public static Reservation GetSingle(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                var output = connection.Query<Reservation>("dbo.Reservations_GetSingle @Id", id) as Reservation;
                return output;
            }
        }

        public static void Insert(Reservation reservation)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                connection.Execute("dbo.Reservation_Insert @Member1Id, @Member2Id, @CourseId, @StartTime, @EndTime", new 
                { 
                    Member1Id = reservation.Reservants[0].ID, 
                    Member2Id = reservation.Reservants[1].ID, 
                    CourseID = reservation.Course.ID,
                    StartTime = reservation.StartTime,
                    EndTime = reservation.EndTime
                });
            }
        }

        public static void Delete(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TennisDB")))
            {
                connection.Execute("dbo.Reservation_Delete @Id", id);
            }
        }
    }
}
