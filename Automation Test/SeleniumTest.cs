using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation_Test
{
	[TestFixture]

	public class SeleniumTest
	{
        WebDriver СhromeDriver { get; set; }

		[SetUp]
		public void SetUp()
		{
            СhromeDriver = new ChromeDriver();
            СhromeDriver.Manage().Window.Maximize();
            СhromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

		[Test]
		public void MyFirstSelenium()
		{
            СhromeDriver.Navigate().GoToUrl("https://www.sharelane.com/");
		}

        [Test]
        public void MyFirstCheckBoxTest()
        {
            СhromeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");
            //return void
            //СhromeDriver.FindElement(By.TagName("input")).Click();

            //it's possible to click 
            IWebElement checkBox = СhromeDriver.FindElement(By.TagName("input"));
            checkBox.Click();
            var checkedAttribute = checkBox.GetAttribute("checked");

            Assert.IsNotNull(checkedAttribute);

            var checkBoxes = СhromeDriver.FindElements(By.TagName("input"));

        }

        [TearDown]
		public void TearDown()
		{
            СhromeDriver.Quit();
        }
	}
}

