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
    class Program
    {
        static void Main(string[] args)
        {
            //Test Suite
            var checkLogin = new FormAuthentication();
            var checkScroll = new InfiniteScroll();
            var checkKeyPress = new KeyPresses();

            

            //Login Test
            try
            {
                Console.WriteLine("Checking Login Tests...\n");
                checkLogin.Scenario1();
                checkLogin.Scenario2();
                checkLogin.Scenario3();
                Console.WriteLine("Login Tests have PASSSED\n");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Login checks Failed");
            }

            //Scrolling Test
            try
            {
                Console.WriteLine("Checking Infinite Scrolling Tests...\n");
                checkScroll.ScrollTwice();
                Console.WriteLine("Scrolling tests have PASSED\n");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Scrolling checks Failed\n");
            }

            //Key Press Tests
            try
            {
                Console.WriteLine("Checking Key Press Tests...\n");
                checkKeyPress.KeyPress();
                Console.WriteLine("Key Press tests PASSED\n");
            }

            catch (NoSuchElementException)
            {
                Console.WriteLine("Key Press checks Failed\n");
            }

            Console.ReadLine();
        }
        
        
    }
    
}
