using Microsoft.Playwright;

namespace PlaywrightDemo;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {

        //Playwright
        using var playwright = await Playwright.CreateAsync();
        //Browser
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless=false
        });
        //Page
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://playwright.dev/dotnet");
        await page.ClickAsync("xpath=//a[contains(@class, 'getStarted')]");

        await page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "test.jpg"
        });
     
    }
}
