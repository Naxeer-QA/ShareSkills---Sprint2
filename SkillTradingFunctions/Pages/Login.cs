using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTradingFunctions
{
    class Login
    {
        public void LoginSuccess(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(5000);
            Utilities.ExcelLibHelpers.PopulateInCollection(@"D:\IndustryConnect\Automation\MVP_MARSproject\Sprint_2\SkillTradingFunctions\SkillTradingFunctions\TestData\TestData.xlsx","LoginPage");

            driver.Navigate().GoToUrl("http://localhost:5000/");

            System.Threading.Thread.Sleep(5000);
            IWebElement SignIn = driver.FindElement(By.XPath("//a[contains(.,'Sign In')]"));
            SignIn.Click();

            IWebElement Email = driver.FindElement(By.XPath("//input[contains(@placeholder,'Email address')]"));
            Email.SendKeys(Utilities.ExcelLibHelpers.ReadData(2,"Username"));

            IWebElement password = driver.FindElement(By.XPath("//input[contains(@type,'password')]"));
            password.SendKeys(Utilities.ExcelLibHelpers.ReadData(2,"Password"));

            IWebElement loginBtn = driver.FindElement(By.XPath("//button[contains(.,'Login')]"));
            loginBtn.Click();
            System.Threading.Thread.Sleep(3000);

            //Making console wait after running the whole program
            //Console.ReadLine();

            //Close driver
            //driver.Close();

           
        }
    }
}
