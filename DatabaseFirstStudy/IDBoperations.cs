using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseFirstStudy
{
    public interface IDBoperations
    {
        bool Create(Info info);

        List<Info> Retrieve();

        bool Update(Info info);

        bool Delete(Info info);
    }
}
