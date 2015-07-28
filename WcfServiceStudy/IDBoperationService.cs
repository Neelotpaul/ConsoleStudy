using DatabaseFirstStudy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceStudy
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDBoperationService
    {
        [OperationContract]
        bool Create(Info info);
        [OperationContract]
        List<Info> Retrieve();
        [OperationContract]
        bool Update(Info info);
        [OperationContract]
        bool Delete(Info info);
    }
}
