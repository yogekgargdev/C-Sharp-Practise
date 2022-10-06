using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.google.com");
        Thread.Sleep(3000); //-> 3 second thread sleep

        driver.Quit();

    }
}