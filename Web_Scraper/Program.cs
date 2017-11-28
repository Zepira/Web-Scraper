using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Net;
using System.ComponentModel;

namespace Web_Scraper
{
    class Program
    {
        static void Main(string[] args)
        {
            //login to the portal
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ecom.eastdist.com/#login";
            System.Threading.Thread.Sleep(2000);
            var username = driver.FindElement(By.XPath("//*[@id='username']"));
            var password = driver.FindElement(By.XPath("//*[@id='password']"));
            username.SendKeys("111277");
            password.SendKeys("Horses01!");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='loginForm']/button")).Click();
            System.Threading.Thread.Sleep(2000);


            IList<IWebElement> all_pets = driver.FindElements(By.ClassName("panel"));
            IList<IWebElement> all_subs = driver.FindElements(By.ClassName("collapsed"));
            IList<IWebElement> subNavs = driver.FindElements(By.XPath("//*[@id='subNav1']/div[1]"));

            String[] allTextPets = new String[all_pets.Count];
            int i = 0;
            int counter = 0;
            foreach (IWebElement element in all_pets)
            {
                if(element.Text != "" && element.Text != null)
                {
                    counter = counter + 1;
                    allTextPets[i++] = element.Text;
                }                
            }

            var allPets = allTextPets.Take(counter);
            var listPets = allPets.ToList();

            foreach (var petGroup in listPets)
            {

                var pet = petGroup;

            }

            var c = 1;
        }
    }
}
