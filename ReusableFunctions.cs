using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteDemo
{
    class ReusableFunctions
    {
        public void selectDropDownByText(IWebElement element,String value)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(value);
        }

        public void selectDropDownByValue(IWebElement element, String value)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByValue(value);
        }



        public void defaultWait(IWebElement element)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromMinutes(2);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
        }

        public void verify(string value,IWebElement element,string printMessage)
        {
            if (value.Equals(element.Text))
            {
                Console.WriteLine(printMessage+" displayed");
            }
            else
            {
                Console.WriteLine(printMessage+" not displayed");
            }
        }
       
       
    }
}
