using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseFirstStudy
{
    public class DBoperation : IDBoperations
    {

        public bool Create(Info info)
        {
            return false;
        }

        public List<Info> Retrieve()
        {
            return new List<Info>();
        }

        public bool Update(Info info)
        {
            return false;
        }

        public bool Delete(Info info)
        {
            return false;
        }
    }
}
