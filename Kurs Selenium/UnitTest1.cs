using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Kurs_Selenium
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\Testing\C# projects\Kurs Selenium\Kurs Selenium\bin\Debug\netcoreapp3.1\Resources\");
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("http://google.pl");
        }
    }
}