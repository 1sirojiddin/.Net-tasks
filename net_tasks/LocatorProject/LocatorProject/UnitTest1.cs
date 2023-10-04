using OpenQA.Selenium.Support.UI;

namespace LocatorProject
{
    [TestFixture]
    public class BBCNewsSportPage
    {
        IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://www.bbc.com/sport");
        }

        [TearDown]
        public void GoOutFromWebSite()
        {
            driver.Quit();
        }

        [Test]
        public void FindBBCIcon()
        {
            driver.FindElements(By.XPath("//img[contains(@alt, 'BBC')]"));
        }
        [Test]
        public void SearchDecenders()
        {
            driver.FindElements(By.XPath("//form[@id='homepage-link']/div"));
            driver.FindElements(By.ClassName("Football"));
        }
        [Test]
        public void FindFutureClassButton()
        {
            IWebElement futureButton = driver.FindElement(By.LinkText("Future"));
            futureButton.Click();
        
        }
    }
}