
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        String url = "https://blog.udemy.com/c-sharp-projects/";
        String Css_Path = "body > > div.container-fluid.px-0 > div > div > div > div > h1"; 
        // The above xpath is not correct! -> will throw exception

        String xpath_element = "/html/body/article/div[2]/div/div/div/div/h1";
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        IWebElement element_csspath = null;
        IWebElement element_xpath = driver.FindElement(By.XPath(xpath_element)); //-> This element is basically the top heading

        //-> Below code perfectly handles the NoSuchElementException
        try
        {
            element_csspath = driver.FindElement(By.CssSelector(Css_Path)); //-> This element is basically the top heading
            if (element_csspath.Displayed)
            {
                GreenMessage("The CSS Selector element is perfectly displayed!");
            }
        }
        catch(NoSuchElementException ex)
        {
            RedMessage("The CSS element is not displayed, please check the code!");

        }
        

        if (element_xpath.Displayed)
        {
            GreenMessage("The xpath Selector element is perfectly displayed!");
        }
        else
        {
            RedMessage("The xpath element is not displayed, please check the code!");

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