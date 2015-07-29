using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace UnitTestStudy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ADOStudy.ADO unitADO = new ADOStudy.ADO();
            
            ADOStudy.Info unitInfo = new ADOStudy.Info();
            unitInfo.Name = "Aashish";
            unitInfo.Gender = "Male";

            Assert.IsTrue(unitADO.Insert(unitInfo));
        }

        [TestMethod]
        public void TestMethod2()
        {
            ADOStudy.ADO unitADO = new ADOStudy.ADO();
            DataSet dsRetrieve = new DataSet();
            dsRetrieve = unitADO.Retrieve();
            
            Assert.IsNotNull(unitADO.Retrieve());
        }
    }
}
