

public class BasePage
{
    protected IWebDriver Driver;

    public BasePage(IWebDriver driver)
    {
        Driver = driver;
    }

    public void NavigateTo(string url)
    {
        Driver.Navigate().GoToUrl(url);
    }

    public IWebElement FindElement(By by)
    {
        return Driver.FindElement(by);
    }
}
