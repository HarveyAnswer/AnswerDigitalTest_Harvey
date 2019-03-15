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
    class KeyPresses
    {
        //Set Variables before test
        IWebDriver driver;

        ////*[@class='example']/p[@id='result']

        //Test case 3: Click on 4 keys and assert the text displayed after every key press

        [Test]
        public void KeyPress()
        {
            // Open the Chrome and go to Url
            driver = new ChromeDriver(@"C:\driver");
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.Manage().Window.Maximize();

            //Find and click on Key Press
            IWebElement KeyPress = driver.FindElement(By.XPath("//*[@id='content']/ul/li[27]/a"));
            KeyPress.Click();

            //Wait
            Thread.Sleep(1000);

            //Find the page body and SendKeys
            IWebElement PressA = driver.FindElement(By.XPath("/html/body"));
            PressA.SendKeys("a");
            
            //Wait
            Thread.Sleep(1000);

            //Assert for the result after pressing a
            IWebElement EnteredA = driver.FindElement(By.XPath("//p[2][contains(text(), 'You entered: A')]"));

            //Wait
            Thread.Sleep(1000);

            //Press S on keyboard
            IWebElement PressB = driver.FindElement(By.XPath("/html/body"));
            PressA.SendKeys("s");

            //Wait
            Thread.Sleep(1000);

            //Assert for the result after pressing S
            IWebElement EnteredS = driver.FindElement(By.XPath("//p[2][contains(text(), 'You entered: S')]"));

            //Wait
            Thread.Sleep(1000);

            //Press D on keyboard
            IWebElement PressD = driver.FindElement(By.XPath("/html/body"));
            PressA.SendKeys("D");

            //Wait
            Thread.Sleep(1000);

            //Assert for the result after pressing D
            IWebElement EnteredD = driver.FindElement(By.XPath("//p[2][contains(text(), 'You entered: D')]"));

            //Wait
            Thread.Sleep(1000);

            //Press F on keyboard
            IWebElement PressF = driver.FindElement(By.XPath("/html/body"));
            PressA.SendKeys("F");

            //Wait
            Thread.Sleep(1000);

            //Assert for the result after pressing D
            IWebElement EnteredF = driver.FindElement(By.XPath("//p[2][contains(text(), 'You entered: F')]"));

            //Wait
            Thread.Sleep(1000);

        }

        [TearDown]
        public void CloseBrowser()
        {
            //End test
            driver.Quit();
        }

    }
}
