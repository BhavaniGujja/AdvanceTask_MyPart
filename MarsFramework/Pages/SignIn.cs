using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using MarsFramework.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
   public  class SignIn
    {
        public void LoginSteps()
        {
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "SignIn");

            //Navigate to the Url
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Url"));

            Global.GlobalDefinitions.driver.FindElement(By.XPath("//a[@class='item']")).Click();

            //using excelhelper class reading data from excel data sheet


            Global.GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Email address']")).SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Username"));

            Global.GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            Global.GlobalDefinitions.driver.FindElement(By.XPath("//button[@class='fluid ui teal button']")).Click();
        }

        
    }
}