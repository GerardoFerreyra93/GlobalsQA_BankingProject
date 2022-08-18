using NUnit.Framework;
using OpenQA.Selenium;
using BankingProject.Init;
using BankingProject.Validations;

namespace BankingProject
{
    public class Tests : TestActions
    {
        [SetUp]
        public void Setup()
        {
            InitBrowser();
        }

        [Test]
        public void Test_Case1()
        {
            Validations_TC1();
        }

        [Test]
        public void Test_Case2()
        {
            Validation_TC2();
        }

        [TearDown]
        public void closeBrowser()
        {
            CloseBrowser();
        }

    }
}