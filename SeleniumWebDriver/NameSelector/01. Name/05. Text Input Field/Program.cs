
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement element; //-> not initialsing bcoz we have still not put the url string will throw exception
    static void Main()
    {
        String url = "https://github.com/yogekgargdev";
        String Name = "q";

        driver.Navigate().GoToUrl(url);

        element = driver.FindElement(By.Name(Name)); //-> This element is basically the input box

        if (element.Displayed)
        {
            GreenMessage("The element is perfectly displayed!");
            element.SendKeys("Yogek Garg");
            Thread.Sleep(3000);
            Console.WriteLine("Text inside InputBox: " + element.GetAttribute("value"));
            //-> note above here 'element.Text' won't work
            element.Clear(); //-> Basically clears the input field
            Thread.Sleep(3000);
            Console.WriteLine("Type of element is: " + element.GetAttribute("type"));

           
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