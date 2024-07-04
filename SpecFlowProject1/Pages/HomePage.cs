

public class HomePage : BasePage
{
    public HomePage(IWebDriver driver) : base(driver) { }

    public IWebElement SearchBox => FindElement(By.Name("q"));
    public IWebElement AcceptCookie => FindElement(By.CssSelector("#L2AGLb"));

    public void Search(string query)
    {
        AcceptCookie.Click();
        SearchBox.SendKeys(query);
        SearchBox.Submit();
    }
}
