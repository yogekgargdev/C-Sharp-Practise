
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement element; //-> not initialsing bcoz we have still not put the url string will throw exception
    static void Main()
    {
        String url = "https://mail.rediff.com/cgi-bin/login.cgi";
        String xpath = "//*[@id=\"remember\"]";

        driver.Navigate().GoToUrl(url);

        element = driver.FindElement(By.XPath(xpath)); //-> This element is basically the check box

        if (element.Displayed)
        {
            GreenMessage("The element is perfectly displayed!");

            if (element.GetAttribute("checked") == "true")
            {
                Console.WriteLine("Element is checked");
                Console.WriteLine(element.GetAttribute("value"));
            }
            Thread.Sleep(3000);

            element.Click();
            Thread.Sleep(3000);
            Console.WriteLine("Element is checked NOW! -- Automated ");
            Console.WriteLine(element.GetAttribute("value"));

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