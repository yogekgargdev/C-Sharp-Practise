
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement element; //-> not initialsing bcoz we have still not put the url string will throw exception
    static void Main()
    {
        String url = "https://demo.guru99.com/test/radio.html";
        String xpath = "";
        String[] checkboxarray = { "1", "2", "3" };

        driver.Navigate().GoToUrl(url);

        xpath = "/html[1]/body[1]/div[4]/input[" + 3 + "]";
        element = driver.FindElement(By.XPath(xpath));
        element.Click();
        Thread.Sleep(3000);



        for (int i = 0; i < checkboxarray.Length; i++)
        {
            xpath = "/html[1]/body[1]/div[4]/input[" + checkboxarray[i] + "]";
            element = driver.FindElement(By.XPath(xpath)); //-> This element is basically the radio box

            if (element.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The element at " + (i + 1) + " is checked!");
            }
            else
            {
                Console.WriteLine("The element at " + (i + 1) + " is not checked!");
            }

        }


        driver.Quit();


    }
}