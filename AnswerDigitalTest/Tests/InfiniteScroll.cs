using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace AnswerDigitalTest
{
    class InfiniteScroll
    {
        //Set Variables before test
        IWebDriver driver;
        
        //Test case 2: scroll to the bottom of the page twice and scroll back to the top of the page and assert "Infinite Scroll" text
        
                
        [Test]
        public void ScrollTwice()
        {
            // Open the Chrome and go to Url
            driver = new ChromeDriver(@"C:\driver");
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.Manage().Window.Maximize();

            //Find and click on Infinite Scroll
            IWebElement InfiniteLink = driver.FindElement(By.XPath("//*[@id='content']/ul/li[23]/a"));
            InfiniteLink.Click();

            //Wait
            System.Threading.Thread.Sleep(1000);

            //Scroll to the bottom - 1st time
            IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
            var firstScrollHeight = js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight); return document.body.scrollHeight;");
            
            //Wait
            System.Threading.Thread.Sleep(1000);
            
            //Scroll to the bottom - 2nd time
            var secondScrollHeight = js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight); return document.body.scrollHeight;");

            //Wait
            System.Threading.Thread.Sleep(1000);

            //Scroll to the top and look for Infinite Scroll title
            var thirdScrollHeight = js.ExecuteScript("arguments[0].scrollIntoView()", driver.FindElement(By.XPath("//*[@id='content']/div/h3[contains(text(), 'Infinite Scroll')]")));
            
            //Wait
            System.Threading.Thread.Sleep(1000);                       
            
        }

        [TearDown]
        public void CloseBrowser()
        {
            //End test
            driver.Quit();
        }
                
    }
}
