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
    }
}
