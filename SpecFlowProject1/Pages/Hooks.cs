
using OpenQA.Selenium.Chrome;

[Binding]
public class Hooks
{
    public static IWebDriver Driver;

    [BeforeScenario]
    public void BeforeScenario()
    {
        Driver = new ChromeDriver();
    }

    [AfterScenario]
    public void AfterScenario()
    {
        Driver.Quit();
    }
}
