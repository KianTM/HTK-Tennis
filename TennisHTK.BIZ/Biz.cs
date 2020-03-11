using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisHTK.DAL;
using TennisHTK.Entities;

namespace TennisHTK.BIZ
{
    public class Biz
    {
        #region Classification
        public static List<Classification> GetAllClassifications() => ClassificationRepository.GetAll();

        public static Classification GetSingleClassification(int id) => ClassificationRepository.GetSingle(id);

        public static void InsertClassification(string name) => ClassificationRepository.Insert(name);

        public static void DeleteClassification(int id) => ClassificationRepository.Delete(id);

        public static void UpdateClassification(int id, string name) => ClassificationRepository.Update(id, name);
        #endregion

        #region Member
        public static List<Member> GetAllMembers() => MemberRepository.GetAll();

        public static Member GetSingleMember(int id) => MemberRepository.GetSingle(id);

        public static void InsertMember(Member member) => MemberRepository.Insert(member);

        public static void UpdateMember(Member member) => MemberRepository.Update(member);

        public static void SetMemberActive(int id, bool active) => MemberRepository.SetActive(id, active);
        #endregion

        #region Course
        public static List<Course> GetAllCourses() => CourseRepository.GetAll();

        public static Course GetSingleCourse(int id) => CourseRepository.GetSingle(id);

        public static void InsertCourse(string name) => CourseRepository.Insert(name);

        public static void UpdateCourse(int id, string name, DateTime? renovationStart = null)
        {
            if (renovationStart != null)
                CourseRepository.Update(id, name, renovationStart);
            else
                CourseRepository.Update(id, name);
        }

        public static void SetCourseUnderRenovation(int id, bool underRenovation) => CourseRepository.SetUnderRenovation(id, underRenovation);
        #endregion

        #region Reservation
        public static List<Reservation> GetAllReservations() => ReservationRepository.GetAll();

        public static Reservation GetSingleReservation(int id) => ReservationRepository.GetSingle(id);

        public static void InsertReservation(Reservation reservation) => ReservationRepository.Insert(reservation);

        public static void DeleteReservation(int id) => ReservationRepository.Delete(id);
        #endregion
    }
}
