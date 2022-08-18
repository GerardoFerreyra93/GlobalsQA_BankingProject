using BankingProject.Init;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.Validations
{
    public class TestActions : BrowserDriverInit
    {
        BrowserDriverInit browser = new BrowserDriverInit();
        private IWebElement BankManageLoginButton => browser.getDriver.FindElement(By.XPath("//button[@ng-click='manager()']"));
        private IWebElement AddCustomerButton => browser.getDriver.FindElement(By.XPath("//button[@ng-class='btnClass1']"));
        private IWebElement AddCustomerFirstName => browser.getDriver.FindElement(By.XPath("//input[@placeholder='First Name']"));        
        private IWebElement AddCustomerLastName => browser.getDriver.FindElement(By.XPath("//input[@placeholder='Last Name']"));
        private IWebElement AddCustomerPostCode => browser.getDriver.FindElement(By.XPath("//input[@placeholder='Post Code']"));
        private IWebElement AddCustomerBtn => browser.getDriver.FindElement(By.XPath("//button[@class='btn btn-default']"));
        private IWebElement OpenAcountBtn => browser.getDriver.FindElement(By.XPath("//button[@ng-click='openAccount()']")); 
        private IWebElement SelectCustomer => browser.getDriver.FindElement(By.XPath("//option[@value='6']")); 
        private IWebElement SelectCurrency => browser.getDriver.FindElement(By.XPath("//option[@value='Pound']")); 
        private IWebElement ProcessBtn => browser.getDriver.FindElement(By.XPath("//button[@type='submit']")); 
        private IWebElement ShowCustomersBtn => browser.getDriver.FindElement(By.XPath("//button[@ng-click='showCust()']")); 
        private IWebElement ShowUsr => browser.getDriver.FindElement(By.XPath("//td[contains(text(), 'Gerardo')]"));

        internal void InitBrowser()
        {
            browser.Init_Browser();
        }

        internal void Validations_TC1()
        {
            BankManageLoginButton.Click();
            System.Threading.Thread.Sleep(5000);

            AddCustomerButton.Click();
            System.Threading.Thread.Sleep(5000);

            AddCustomerFirstName.SendKeys("Gerardo");
            System.Threading.Thread.Sleep(5000);

            AddCustomerLastName.SendKeys("Ferreyra");
            System.Threading.Thread.Sleep(5000);

            AddCustomerPostCode.SendKeys("58195");
            System.Threading.Thread.Sleep(5000);

            AddCustomerBtn.Click();
            System.Threading.Thread.Sleep(5000);

            IAlert alert = browser.getDriver.SwitchTo().Alert();//cerrar pop-ups
            alert.Accept();
            System.Threading.Thread.Sleep(5000);

            OpenAcountBtn.Click();
            System.Threading.Thread.Sleep(5000);

            SelectCustomer.Click();
            System.Threading.Thread.Sleep(5000);

            SelectCurrency.Click();
            System.Threading.Thread.Sleep(5000);

            ProcessBtn.Click();
            System.Threading.Thread.Sleep(5000);

            IAlert alert2 = browser.getDriver.SwitchTo().Alert();
            alert2.Accept();
            System.Threading.Thread.Sleep(5000);

            ShowCustomersBtn.Click();
            System.Threading.Thread.Sleep(5000);

            IWebElement s = browser.getDriver.FindElement(By.XPath("//td[contains(text(), 'Gerardo')]"));
            IJavaScriptExecutor je = (IJavaScriptExecutor)browser.getDriver;
            je.ExecuteScript("arguments[0].scrollIntoView(true);", s);
            System.Threading.Thread.Sleep(5000);

            Assert.IsTrue(ShowUsr.Displayed);
            System.Threading.Thread.Sleep(5000);
        }

        internal void Validation_TC2()
        {
           
        }

        internal void CloseBrowser()
        {
            browser.Close();
        }

    }
}
