using MaestroPanelApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MaestroPanelApi_Test
{
    
    
    /// <summary>
    ///This is a test class for ClientTest and is intended
    ///to contain all ClientTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ClientTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for DomainCreate
        ///</summary>
        [TestMethod()]
        public void DomainCreateTest()
        {
            string ApiKey = "1_885bd9d868494d078d4394809f5ca7ac";
            string apiHostdomain = "localhost";
            int port = 9715;
            bool ssl = false; 
            Client target = new Client(ApiKey, apiHostdomain, port, ssl);

            string name = "demo1.com";
            string planAlias = "GOLD_PLAN";
            string username = "demo1.com";
            string password = "kr3m@12!";
            bool activedomainuser = false;
            string firstName = "Demo";
            string lastName = "Customer";
            string email = "demo@customer.com";            

            ApiResult actual = target.DomainCreate(name, planAlias, username, password, activedomainuser, firstName, lastName, email);
            Assert.AreEqual(0, actual.Code);            
        }

        /// <summary>
        ///A test for DomainDelete
        ///</summary>
        [TestMethod()]
        public void DomainDeleteTest()
        {
            string ApiKey = "1_885bd9d868494d078d4394809f5ca7ac";
            string apiHostdomain = "localhost";
            int port = 9715;
            bool ssl = false; 

            Client target = new Client(ApiKey, apiHostdomain, port, ssl); // TODO: Initialize to an appropriate value
            string name = "demo1.com";            
            ApiResult actual = target.DomainDelete(name);
            Assert.AreEqual(0, actual.Code);               
        }

        /// <summary>
        ///A test for DomainStart
        ///</summary>
        [TestMethod()]
        public void DomainStartTest()
        {
            string ApiKey = "1_885bd9d868494d078d4394809f5ca7ac";
            string apiHostdomain = "localhost";
            int port = 9715;
            bool ssl = false; 

            Client target = new Client(ApiKey, apiHostdomain, port, ssl); // TODO: Initialize to an appropriate value
            
            string name = "demo1.com";       
            ApiResult actual = target.DomainStart(name);
            Assert.AreEqual(0, actual.Code);            
        }

        /// <summary>
        ///A test for DomainStop
        ///</summary>
        [TestMethod()]
        public void DomainStopTest()
        {
            string ApiKey = "1_885bd9d868494d078d4394809f5ca7ac";
            string apiHostdomain = "localhost";
            int port = 9715;
            bool ssl = false; 

            Client target = new Client(ApiKey, apiHostdomain, port, ssl); // TODO: Initialize to an appropriate value
            string name = "demo1.com";  
            
            ApiResult actual = target.DomainStop(name);
            Assert.AreEqual(0, actual.Code);                       
        }
    }
}
