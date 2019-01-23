using Microsoft.VisualStudio.TestTools.UnitTesting;
using BSTestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTests
{
    [TestClass()]
    public class BSTests
    {
        [TestMethod()]
        public void NewUserSignUpInfoTest()
        {
            NewUserInfoPage  nuInfoPage = new NewUserInfoPage();
            nuInfoPage.NewUserSignUpInfo();
           
            Assert.IsTrue(NewUserInfoPage.Success());
           
        }

        [TestCleanup]
        public void CleanUp()
        {
           NewUserInfoPage.CloseBrowser();
        }

        
        
    }
}