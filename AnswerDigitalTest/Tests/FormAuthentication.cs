using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace AnswerDigitalTest
{
    class FormAuthentication
    {
        //Set Variable before test
        IWebDriver driver;
        
        /*
         Test case 1: Automate Form Authentication

         Scenario 1: Try to login with correct username and wrong password and assert login validation
         Scenario 2: Try to login with incorrect username and correct password and assert login validation
         Scenario 3: Try to login with correct username and password and then logout
        */       

        [Test]
        public void Scenario1()
        {
            // Open the Chrome and go to Url
            driver = new ChromeDriver(@"C:\driver");
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.Manage().Window.Maximize();

            //Find and click on Form Authentication
            driver.FindElement(By.XPath("//*[@id='content']/ul/li[18]/a")).Click();

            Thread.Sleep(2000);

            //Find Username and type in "tomsmith"
            IWebElement Username = driver.FindElement(By.Id("username"));
            Username.SendKeys("tomsmith");

            Thread.Sleep(1000);

            //Find Password and type in "harvey"
            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("harvey");

            Thread.Sleep(2000);

            //Find Login button and click
            IWebElement Login = driver.FindElement(By.XPath("//div[2]/div/div/form/button"));
            Login.Click();

            //Set a wait period
            Thread.Sleep(2000);

            //Verify password invalid error
            IWebElement ErrorPassword = driver.FindElement(By.XPath("//div/div/div[contains(text(), 'Your password is invalid')]"));

            //Set a wait period
            Thread.Sleep(2000);

            //End test
            driver.Quit();
        }
        
        [Test]
        public void Scenario2()
        {
            // Open the Chrome and go to Url
            driver = new ChromeDriver(@"C:\driver");
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.Manage().Window.Maximize();

            //Find and click on Form Authentication
            driver.FindElement(By.XPath("//*[@id='content']/ul/li[18]/a")).Click();

            Thread.Sleep(2000);

            //Find Username and type in "tomsmith"
            IWebElement Username = driver.FindElement(By.Id("username"));
            Username.SendKeys("harveysembhy");

            Thread.Sleep(1000);

            //Find Password and type in "harvey"
            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("SuperSecretPassword!");

            Thread.Sleep(2000);

            //Find Login button and click
            IWebElement Login = driver.FindElement(By.XPath("//div[2]/div/div/form/button"));
            Login.Click();
                        
            //Set a wait period
            Thread.Sleep(2000);

            //Verify Error message
            IWebElement ErrorUsername = driver.FindElement(By.XPath("//div/div/div[contains(text(), 'Your username is invalid')]"));

            //Set a wait period
            Thread.Sleep(1000);

            //End test
            driver.Quit();
        }
                
        [Test]
        public void Scenario3()
        {
            // Open the Chrome and go to Url
            driver = new ChromeDriver(@"C:\driver");
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.Manage().Window.Maximize();

            //Find and click on Form Authentication
            driver.FindElement(By.XPath("//*[@id='content']/ul/li[18]/a")).Click();

            //Wait
            Thread.Sleep(2000);

            //Find Username and type in "tomsmith"
            IWebElement Username = driver.FindElement(By.Id("username"));
            Username.SendKeys("tomsmith");

            //Wait
            Thread.Sleep(1000);

            //Find Password and type in "harvey"
            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("SuperSecretPassword!");

            //Wait
            Thread.Sleep(2000);

            //Find Login button and click
            IWebElement Login = driver.FindElement(By.XPath("//div[2]/div/div/form/button"));
            Login.Click();

            //Set a wait period
            Thread.Sleep(2000);

            //Successfully logged in message
            IWebElement LoginSuccessful = driver.FindElement(By.XPath("//div/div/div[contains(text(), 'You logged into a secure area!')]"));

            //Set a wait period
            Thread.Sleep(1000);

            //Logout button
            IWebElement LogOut = driver.FindElement(By.XPath("//div[2]/div/div/a"));
            LogOut.Click();                       

            //Verify you are on the Login Page
            IWebElement LoginPageText = driver.FindElement(By.XPath("//div[2]/div/div/h2[contains(text(), 'Login Page')]"));

            //Set a wait period
            Thread.Sleep(2000);

            //End test
            driver.Quit();
        }
       
    }
}
