using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProgram
{
    class LoginPage
    {
        public void LoginStep(IWebDriver driver)
        {
            driver.FindElement(By.Id("UserName")).SendKeys("hari");
            driver.FindElement(By.Id("UserName")).SendKeys("123123");
            driver.FindElement(By.XPath("//input[contains(@type,'submit')]")).Click();
        }
    }
}
