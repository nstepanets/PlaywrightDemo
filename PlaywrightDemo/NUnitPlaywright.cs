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
			await Page.ClickAsync("xpath=//a[contains(@class, 'getStarted')]");
			await Page.ClickAsync("xpath=//h1[text()='Installation']");

			await Expect(Page.Locator("xpath=//h1[text()='Installation']")).ToBeVisibleAsync();
		}
	}
}

