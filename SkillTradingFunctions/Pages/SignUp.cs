using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTradingFunctions.Pages
{
    class SignUp
    {
        public void RegisterSuccess(IWebDriver driver)
        {
        System.Threading.Thread.Sleep(5000);
        Utilities.ExcelLibHelpers.PopulateInCollection(@"D:\IndustryConnect\Automation\MVP_MARSproject\Sprint_2\SkillTradingFunctions\SkillTradingFunctions\TestData\TestData.xlsx", "SignUpPage");

        driver.Navigate().GoToUrl("http://localhost:5000/");

        IWebElement Join = driver.FindElement(By.XPath("//button[contains(.,'Join')]"));
        Join.Click();

        IWebElement firstName = driver.FindElement(By.XPath("//input[@name='firstName']"));
        firstName.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "FirstName"));

        IWebElement lastName = driver.FindElement(By.XPath("//input[@name='lastName']"));
        lastName.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "LastName"));

        IWebElement Email = driver.FindElement(By.XPath("//input[@name='email']"));
        Email.SendKeys(Utilities.ExcelLibHelpers.ReadData(2,"Email"));

        IWebElement password = driver.FindElement(By.XPath("//input[@name='password']"));
        password.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "Password"));

        IWebElement confirmPassword = driver.FindElement(By.XPath("//input[@name='confirmPassword']"));
        confirmPassword.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "ConfirmPassword"));

        IWebElement checkBoxTC = driver.FindElement(By.XPath("//input[@type='checkbox']"));
        checkBoxTC.Click();

        IWebElement joinBtn = driver.FindElement(By.XPath("//div[@id='submit-btn']"));
        joinBtn.Click();

        System.Threading.Thread.Sleep(3000);
            
        }
    }
}
