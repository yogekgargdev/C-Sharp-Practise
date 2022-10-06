using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver= new ChromeDriver();
    static IWebElement dropdown_element;
    static IWebElement dropdownmenu_element;
    static void Main()
    {
        
        String url = "http://demo.guru99.com/test/newtours/register.php";
        String name = "country";
        String insideelementxpath = "/html[1]/body[1]/div[2]/table[1]/tbody[1]/tr[1]/td[2]/table[1]/tbody[1]/tr[4]/td[1]/table[1]/tbody[1]/tr[1]/td[2]/table[1]/tbody[1]/tr[5]/td[1]/form[1]/table[1]/tbody[1]/tr[11]/td[2]/select[1]/option[8]";
        driver.Navigate().GoToUrl(url);
        dropdown_element=driver.FindElement(By.Name(name));

        Console.WriteLine(dropdown_element.GetAttribute("value"));
        // The above code returns the pre selected value in the select element

        dropdownmenu_element=driver.FindElement(By.XPath(insideelementxpath));
        Console.WriteLine(dropdownmenu_element.GetAttribute("value"));
        dropdownmenu_element.Click();
        Thread.Sleep(3000);
        Console.WriteLine("New DropDown Menu Selected Value is: "+ dropdown_element.GetAttribute("value"));

        //-> Iterating first 10 values of the dropdown menu

        for(int i=1;i<=10;i++)
        {
            insideelementxpath = "/html[1]/body[1]/div[2]/table[1]/tbody[1]/tr[1]/td[2]/table[1]/tbody[1]/tr[4]/td[1]/" +
                "table[1]/tbody[1]/tr[1]/td[2]/table[1]/tbody[1]/tr[5]/td[1]/form[1]/table[1]/tbody[1]/" +
                "tr[11]/td[2]/select[1]/option["+i+"]";

            dropdownmenu_element = driver.FindElement(By.XPath(insideelementxpath));
            Console.WriteLine("Value in dropdown list "+ dropdownmenu_element.GetAttribute("value"));

        }







    }

}