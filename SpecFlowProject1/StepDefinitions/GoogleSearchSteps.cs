
[Binding]
public class GoogleSearchSteps
{
    private readonly IWebDriver _driver;
    private readonly HomePage _homePage;

    public GoogleSearchSteps()
    {
        _driver = Hooks.Driver;
        _homePage = new HomePage(_driver);
    }

    [Given(@"I am on the Google homepage")]
    public void GivenIAmOnTheGoogleHomepage()
    {
        _homePage.NavigateTo("https://www.google.com");
    }

    [When(@"I search for ""(.*)""")]
    public void WhenISearchFor(string query)
    {
        _homePage.Search(query);
    }

    [Then(@"the first result should contain ""(.*)""")]
    public void ThenTheFirstResultShouldContain(string expectedText)
    {
        var firstResult = _homePage.FindElement(By.CssSelector("h3")).Text;
        Assert.IsTrue(firstResult.Contains(expectedText));
    }
}
