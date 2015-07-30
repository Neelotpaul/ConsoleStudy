using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseFirstStudy
{
    public class DBoperation : IDBoperations
    {
        static StudentDBEntities context;
        public bool Create(Info info)
        {
            try
            {
                context = new StudentDBEntities();
                context.Infoes.Add(info);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Info> Retrieve()
        {
            context = new StudentDBEntities();
            return context.Infoes.ToList();
        }

        public bool Update(Info info)
        {
            context = new StudentDBEntities();
            try
            {
                Info change = context.Infoes.Where(c => c.Name == info.Name).ToList().FirstOrDefault();
                if (change != null)
                    change = info;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;       
            }
        }

        public bool Delete(Info info)
        {
            try
            {
                Info change = context.Infoes.Where(c => c.Name == info.Name).ToList().FirstOrDefault();
                if (change != null)
                    context.Infoes.Remove(info);
                context.SaveChanges();
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
