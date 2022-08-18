using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.Init
{
    public class BrowserDriverInit
    {
        IWebDriver driver;
        string DRIVER = "Edge";
        
        public void Init_Browser()
        {
            if(DRIVER == "Chrome")
            {
                driver = new ChromeDriver("C:\\Users\\gerardo.ferreyra\\source\\repos\\BankingProject\\BankingProject\\Drivers\\");
            }

            if (DRIVER == "Firefox")
            {
                driver = new FirefoxDriver("C:\\Users\\gerardo.ferreyra\\source\\repos\\BankingProject\\BankingProject\\Drivers\\");
            }

            if (DRIVER == "Edge")
            {
                driver = new EdgeDriver("C:\\Users\\gerardo.ferreyra\\source\\repos\\BankingProject\\BankingProject\\Drivers\\");
            }           

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
            System.Threading.Thread.Sleep(10000);
        }

        public IWebDriver getDriver { get { return driver; } }

        public void Close()
        {
            driver.Quit();
        }

    }
}
