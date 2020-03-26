using OpenQA.Selenium;
using System;
using AutoItX3Lib;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace SkillTradingFunctions
{
    internal class ShareSkill
    {
        internal void SaveSkillsbtn(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@href='/Home/ServiceListing']")).Click();

            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")).SendKeys("Automation Tester");

            driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")).SendKeys("I have an extensive experience around automation testing");

            System.Threading.Thread.Sleep(2000);
            IWebElement SelectCategory = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[3]/div[2]/div[1]/div[1]/select[1]/option[7]"));
            SelectCategory.Click();
            SelectCategory.GetAttribute("Programming & Tech");

            System.Threading.Thread.Sleep(2000);
            IWebElement SelectSubCategory = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[3]/div[2]/div[1]/div[2]/div[1]/select[1]/option[5]"));
            SelectSubCategory.Click();
            SelectSubCategory.GetAttribute("QA");

            System.Threading.Thread.Sleep(2000);
            IWebElement EnterTag = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[4]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            EnterTag.SendKeys("Automation Expertise");
            EnterTag.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(2000);
            EnterTag.SendKeys("Cypress Expertise");
            EnterTag.SendKeys(Keys.Enter);

            System.Threading.Thread.Sleep(2000);
            IWebElement ServiceTypeSelection = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[5]/div[2]/div[1]/div[2]/div[1]/input[1]"));
            ServiceTypeSelection.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement LocationTypeSelection = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[6]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            LocationTypeSelection.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement DayButton = driver.FindElement(By.XPath("//a[@role='button'][contains(.,'Today')]"));
            DayButton.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement opencalendar = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[1]/div[1]/ul[1]/li[4]/a[1]/span[1]"));
            opencalendar.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement monthforwarder = driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/a[3]/span[1]"));
            monthforwarder.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement pickdate = driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[3]/td[2]/a[1]"));
            pickdate.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement selectday1 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/th[1]/span[1]"));
            selectday1.Click();

            System.Threading.Thread.Sleep(2000);

            //Actions action = new Actions(driver);
            //System.Threading.Thread.Sleep(2000);
            //IWebElement SelectTime1 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[1]/table[1]/tbody[1]/tr[2]/td[2]/div[1]/table[1]/tbody[1]/tr[11]/td[1]"));
            //action.DoubleClick(SelectTime1).Perform();

            //System.Threading.Thread.Sleep(2000);
            //IWebElement EventWindow = driver.FindElement(By.XPath("/html[1]/body[1]/div[4]"));
            //IWebElement EventTitle = driver.FindElement(By.XPath("/html[1]/body[1]/div[4]/div[2]/div[1]/div[2]/input[1]"));
            //EventTitle.Clear();
            //System.Threading.Thread.Sleep(2000);
            //EventTitle.SendKeys("Automation Exercises");

            //System.Threading.Thread.Sleep(2000);
            //IWebElement ClockEndTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[11]/div[1]/ul[1]/li[27]"));
            //ClockEndTime.Click();
            //System.Threading.Thread.Sleep(2000);
            //ClockEndTime.SendKeys(Keys.Down);
            //ClockEndTime.FindElement(By.XPath("/html[1]/body[1]/div[11]/div[1]/ul[1]/li[29]")).Click();

            //System.Threading.Thread.Sleep(2000);
            //IWebElement EventDescription = driver.FindElement(By.XPath("/html[1]/body[1]/div[4]/div[2]/div[1]/div[13]/textarea[1]"));
            //EventDescription.SendKeys("Students must qualify ISTQB");

            //IWebElement EventSaveBtn = driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[16]/a[1]"));
            //System.Threading.Thread.Sleep(2000);
            //EventSaveBtn.Click();
            //System.Threading.Thread.Sleep(4000);

            //IWebElement DayForwarder = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[1]/div[1]/ul[1]/li[3]/a[1]"));
            //DayForwarder.Click();

            //Actions action2 = new Actions(driver);
            //System.Threading.Thread.Sleep(2000);
            //IWebElement SelectTime2 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[1]/table[1]/tbody[1]/tr[2]/td[2]/div[1]/table[1]/tbody[1]/tr[7]/td[1]"));
            //action2.DoubleClick(SelectTime2).Perform();

            //System.Threading.Thread.Sleep(2000);
            //IWebElement EventWindow2 = driver.FindElement(By.XPath("/html[1]/body[1]/div[4]"));
            //IWebElement EventTitle2 = driver.FindElement(By.XPath("/html[1]/body[1]/div[4]/div[2]/div[1]/div[2]/input[1]"));
            //EventTitle2.Clear();
            //System.Threading.Thread.Sleep(2000);
            //EventTitle2.SendKeys("My Birthday");

            //System.Threading.Thread.Sleep(2000);
            //IWebElement AllDayEvent1 = driver.FindElement(By.XPath("//input[contains(@type,'checkbox')]"));
            //AllDayEvent1.Click();

            //System.Threading.Thread.Sleep(2000);
            //IWebElement RepeatDropdown1 = driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[10]/div/span/span/span[1]"));
            //RepeatDropdown1.Click();
            //SelectElement SE = new SelectElement(RepeatDropdown1);
            //SelectElement SE = new SelectElement(driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[10]/div/span/span/span[1]")));
            //System.Threading.Thread.Sleep(2000);
            //SE.SelectByText("Monthly");
            //System.Threading.Thread.Sleep(2000);
            //RepeatDropdown1.Click();

            //The below coding was intended for the same section which was in the website previously, now the webpage got updated. Hence this coding/functionality got deprecated.
            //IWebElement StartDate = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[1]/div[2]/input[1]"));
            //StartDate.SendKeys("20/03/2020");
            //StartDate.SendKeys("02");
            //StartDate.SendKeys("2020");
            //IWebElement EndDate = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[1]/div[4]/input[1]"));
            //EndDate.SendKeys("30/02/2020");

            //Monday - Checks the day and defines the timing
            //IWebElement MondayAvailable = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[3]/div[1]/div[1]/input[1]"));
            //MondayAvailable.Click();
            //IWebElement MondayStartTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[3]/div[2]/input[1]"));
            //MondayStartTime.SendKeys("09:00");
            //MondayStartTime.SendKeys("AM");
            //IWebElement MondayEndTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[3]/div[3]/input[1]"));
            //MondayEndTime.SendKeys("05:00");
            //MondayEndTime.SendKeys("PM");

            //Wednesday - Checks the day and defines the timing
            //IWebElement WednesdayAvailable = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[1]/div[1]/input[1]"));
            //WednesdayAvailable.Click();
            //IWebElement WedStartTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[2]/input[1]"));
            //WedStartTime.SendKeys("10:00");
            //WedStartTime.SendKeys("AM");
            //IWebElement WedEndTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[3]/input[1]"));
            //WedEndTime.SendKeys("05:30");
            //WedEndTime.SendKeys("PM");

            //Wednesday - Checks the day and defines the timing
            //System.Threading.Thread.Sleep(2000);
            //IWebElement FridayAvailable = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[7]/div[1]/div[1]/input[1]"));
            //FridayAvailable.Click();
            //IWebElement FriStartTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[7]/div[2]/input[1]"));
            //FriStartTime.SendKeys("11:30");
            //FriStartTime.SendKeys("AM");
            //IWebElement FriEndTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[7]/div[3]/input[1]"));
            //FriEndTime.SendKeys("05:45");
            //FriEndTime.SendKeys("PM");

            //Choosing the option of learning a new skill
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[2]/div[1]/div[1]/div[1]/input[1]")).Click();

            //Defining the skills to be exchanged for the new one
            System.Threading.Thread.Sleep(2000);
            IWebElement SkillExchange = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[4]/div[1]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            SkillExchange.SendKeys("Cypress");
            SkillExchange.SendKeys(Keys.Enter);
            SkillExchange.SendKeys("SoapUI");
            SkillExchange.SendKeys(Keys.Enter);

            //The file uploading is failing, need to fix it until further progress
            //Approach 1 = using SendKeys
            //System.Threading.Thread.Sleep(2000);
            //IWebElement Uploadsample = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[9]/div[1]/div[2]/section[1]/div[1]/input[1]"));
            //Uploadsample.Click();
            //System.Threading.Thread.Sleep(2000);
            //Uploadsample.SendKeys("D:\\IndustryConnect\\MVP_Studio\\Project_MARS\\Task_2_(24_Dec-_Jan_2020)");
            //System.Threading.Thread.Sleep(3000);
            //Uploadsample.GetAttribute("16_01_2020");
            //Uploadsample.SendKeys(Keys.Enter);

            //Aproach 2 = Using AutoIT - Handles windows that do not belong to browser
            System.Threading.Thread.Sleep(2000);
            IWebElement Uploadsample = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[9]/div[1]/div[2]/section[1]/div[1]/label[1]/div[1]/span[1]/i[1]"));
            Uploadsample.Click();
            AutoItX3 autoit = new AutoItX3();
            autoit.WinActivate("Open"); //Activate so that next set of actions heppen on this window
            autoit.Send("D:\\IndustryConnect\\MVP_Studio\\Project_MARS\\Task_2_(24_Dec-_Jan_2020)\\Weird Issue");
            System.Threading.Thread.Sleep(5000);
            autoit.Send("{ENTER}");

            //Choosing the appropriate status of a service
            System.Threading.Thread.Sleep(2000);
            IWebElement ServiceStatus = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[10]/div[2]/div[1]/div[2]/div[1]/input[1]"));
            ServiceStatus.Click();

            //Saving the service
            System.Threading.Thread.Sleep(2000);
            IWebElement SaveServiceBtn = driver.FindElement(By.XPath("//input[@class='ui teal button']"));
            SaveServiceBtn.Click();

            System.Threading.Thread.Sleep(2000);

        }
    }
}

