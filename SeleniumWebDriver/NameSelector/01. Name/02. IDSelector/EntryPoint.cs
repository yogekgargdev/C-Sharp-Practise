
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        String url = "https://www.interviewbit.com/blog/c-sharp-projects/";
        String ID = "toclist";
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.Id(ID)); //-> This element is basically the list of contents

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