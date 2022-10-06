using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.google.com");

        IWebElement element = driver.FindElement(By.Name("q")); //-> This element is basically the input box for Search

        if (element.Displayed)
        {
            GreenMessage("The element is perfectly displayed!");
        }
        else
        {
            RedMessage("The element is not displayed, please check the code!");

        }

        driver.Quit();


    }

    private static void RedMessage(string v)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(v);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string v)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(v);
        Console.ForegroundColor = ConsoleColor.White;
    }
}