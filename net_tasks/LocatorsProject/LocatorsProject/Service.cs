using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace LocatorsProject
{
    public class Service
    {
        public static void Locate()
        {
            // Initialize the Chrome WebDriver
            IWebDriver driver = new FirefoxDriver();

                try
                {
                    driver.Navigate().GoToUrl("https://www.bbc.com/sport");

                    // Example 1: Locate the search field using XPath Axes (ancestor and descendant)
                   driver.FindElement(By.XPath("//button[@id='searchButton']"));

                    // Example 2: Locate the 'All Sports' button using XPath Axes (preceding-sibling)
                    driver.FindElement(By.XPath("//span[text()='All Sport']/preceding-sibling::a"));

                    // Example 3: Locate the BBC icon using XPath Axes (following-sibling)
                   driver.FindElement(By.XPath("//a[@id='orb-header__logo']/following-sibling::span"));

                    // Example 4: Locate an element using XPath Axes (child)
                    driver.FindElement(By.XPath("//div[@class='sp-c-global-header__logo']/*"));

                     //driver.FindElement(By.XPath("//div[@class = 'Football']/sancestor::book"));
                  
                }
                catch (NoSuchElementException e)
                {
                    Console.WriteLine("Element not found: " + e.Message);
                }
                finally
                {
                    driver.Quit();
                }
            
        }

    }
}
