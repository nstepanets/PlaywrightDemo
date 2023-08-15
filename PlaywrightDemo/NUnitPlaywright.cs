using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightDemo
{
	public class NUnitPlaywright : PageTest
	{
		[SetUp]
		public async Task Setup()
		{
            await Page.GotoAsync("https://playwright.dev/dotnet");
        }

		[Test]
		public async Task NUnitTest()
		{
			var getStartedButton = Page.Locator("a", new PageLocatorOptions { HasTextString = "Get started"});
			var installationPageTitle = Page.Locator("xpath=//h1[text()='Installation']");

            await getStartedButton.ClickAsync();
			await Expect(installationPageTitle).ToBeVisibleAsync();
		}
	}
}

