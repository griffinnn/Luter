using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Luter
{
    /// <summary>
    /// TODO:
    /// Implement console front end to populate shipping info.
    /// 
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme the lut...");
            IWebDriver driver = new ChromeDriver();
            driver.Url= "http://www.supremenewyork.com/shop/all/jackets";
            driver.FindElement(By.XPath("//*[@id=\"container\"]/article[4]/div/h1/a")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"add-remove-buttons\"]/input")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"cart\"]/a[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("order_billing_name")).SendKeys("Lawtomated.");
            driver.FindElement(By.Id("order_email")).SendKeys("test@email.com.");
            driver.FindElement(By.Id("order_tel")).SendKeys("07711047857");
            driver.FindElement(By.Id("bo")).SendKeys("10 Test Street.");
            driver.FindElement(By.Id("oba3")).SendKeys("Suburbs.");
            driver.FindElement(By.Id("order_billing_address_3")).SendKeys("Subshire");
            driver.FindElement(By.Id("order_billing_city")).SendKeys("Test City");
            driver.FindElement(By.Id("order_billing_zip")).SendKeys("T3 3ST");
        }

        public class ShippingInfo
        {
            string Fullname;
            string Email;
            string Telephone;
            string Address;
            string Address2;
            string City;
            string PostCode;
            string Country;

            public ShippingInfo(string Fullname, string Email, string Telephone, string Address, string Address2, string City,
            string PostCode, string Country)
            {
                Fullname = Fullname;
                Email = Email;

            }
        }
    }
}
