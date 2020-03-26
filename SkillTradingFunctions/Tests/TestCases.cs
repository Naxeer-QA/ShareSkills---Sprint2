using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SkillTradingFunctions.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SkillTradingFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [TestFixture]
        public class MyFixture
        {
            ExtentReports extent = null;

            [OneTimeSetUp]
            public void ExtentStart()
            {
                extent = new ExtentReports();
                var htmlReporter = new ExtentHtmlReporter(@"D:\IndustryConnect\Automation\MVP_MARSproject\Sprint_2\SkillTradingFunctions\SkillTradingFunctions\ExtentReports\Test1Report.html");
                extent.AttachReporter(htmlReporter);
            }

            [OneTimeTearDown]
            public void ExtentClose()
            {
                extent.Flush();
            }
            //}

            // Test Case #1 - Share Skills
            [Test, Order(1)]
            //Creating a method for the test case
            public void TradeSkills()
            {
                //ExtentReports extentreport = null;
                //Initiating a web driver
                ExtentTest test = extent.CreateTest("TradeSkills").Info("Test Started");
                IWebDriver driver = new ChromeDriver();
                test.Log(Status.Info, "Chrome Browser launched");

                //Maximize the Chrome Web Browser
                driver.Manage().Window.Maximize();

                //Instantiating an instance of a class for SignUp
                SignUp signup = new SignUp();
                signup.RegisterSuccess(driver);
                test.Log(Status.Info, "User registered successfully");

                //Instantiating an instance of a class for login  
                Login login = new Login();
                login.LoginSuccess(driver);
                test.Log(Status.Info, "User logs in the website");

                //Instantiating an instance of a class for ShareSkill Page
                ShareSkill Sskill = new ShareSkill();
                Sskill.SaveSkillsbtn(driver);
                test.Log(Status.Info, "User successfully creates new skill");

                //Close driver
                driver.Close();
                test.Log(Status.Pass);
            }

            [Test,Order(2)]
            //Test Case #2 - Manage Listings
            //Creating a method for the test case 
            public void UpdateServiceListing()
            {
                //ExtentReports extentreport = null;
                //ExtentTest extenttest = null;

                ExtentTest test = extent.CreateTest("UpdateServiceListing").Info("Test Started");

                //Initiating a web driver
                IWebDriver driver = new ChromeDriver();
                test.Log(Status.Info, "Chrome browser launched");

                //Maximize the Chrome Web Browser
                driver.Manage().Window.Maximize();

                //Instantiating an instance of a class for login  
                Login login = new Login();
                login.LoginSuccess(driver);
                test.Log(Status.Info, "User Logged in successfully");

                ManageListings managelistings = new ManageListings();
                managelistings.UpdateServices(driver);
                test.Log(Status.Info, "User updated the servicess successfully");

                //Close driver
                driver.Close();
                test.Log(Status.Pass);

            }
            [Test,Order(3)]
            //Test Case #3 - View Services In Details
            //Creating a method for the test case
            public void ServicesInView()
            {
                //ExtentReports extentreport = null;
                //ExtentTest extenttest = null;

                ExtentTest test = extent.CreateTest("ServicesInView").Info("Test Started");

                //Initiating a web driver
                IWebDriver driver = new ChromeDriver();
                test.Log(Status.Info, "Chrome Browser launched");

                //Maximize the Chrome Web Browser
                driver.Manage().Window.Maximize();

                //Instantiating an instance of a class for login  
                Login login = new Login();
                login.LoginSuccess(driver);
                test.Log(Status.Info, "User logged in successfully");

                ViewSerices viewservices = new ViewSerices();
                viewservices.ServiceDetails(driver);
                test.Log(Status.Info, "User is able to view the services");

                System.Threading.Thread.Sleep(3000);
                driver.Close();
                test.Log(Status.Pass);
            }
        }
    }
}
