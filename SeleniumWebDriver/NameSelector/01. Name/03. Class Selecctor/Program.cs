
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        String url = "https://blog.udemy.com/c-sharp-projects/";
        String Class_Name = "featured-article__title";
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.ClassName(Class_Name)); //-> This element is basically the top heading

        if (element.Displayed)
        {
            GreenMessage("The element is perfectly displayed!");
            Console.WriteLine("Text inside ClassName: "+ element.Text);
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