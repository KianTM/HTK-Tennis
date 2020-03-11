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
        public static List<Classification> GetAllClassifications()
        {
            return ClassificationRepository.GetAll();
        }

        public static Classification GetSingleClassification(int id)
        {
            return ClassificationRepository.GetSingle(id);
        }

        public static void InsertClassification(string name)
        {
            ClassificationRepository.Insert(name);
        }

        public static void DeleteClassification(int id)
        {
            ClassificationRepository.Delete(id);
        }

        public static void UpdateClassification(int id, string name)
        {
            ClassificationRepository.Update(id, name);
        }
        #endregion
    }
}
