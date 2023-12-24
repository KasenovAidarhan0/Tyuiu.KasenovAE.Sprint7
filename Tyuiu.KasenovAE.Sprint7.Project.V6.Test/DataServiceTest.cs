using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Diagnostics;
using Tyuiu.KasenovAE.Sprint7.Project.V6.Lib;

namespace Tyuiu.KasenovAE.Sprint7.Project.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetData_Test()
        {
            DataService.path = $@"C:\Users\kasen\Desktop\testM.csv";

            DataTable dt = DataService.GetData();

            string[] con = { null , "&", null , "&", "&", "&", "&", };

            DataService.ChangeData("1", con);
        }
    }
}
