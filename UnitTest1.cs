using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace AppiumTests;

public class Tests
{
    private AndroidDriver _driver;

    [OneTimeSetUp]
    public void SetUp()
    {
        var serverUri = new Uri(Environment.GetEnvironmentVariable("APPIUM_HOST") ?? "http://127.0.0.1:4724/");
        var driverOptions = new AppiumOptions() {
            AutomationName = AutomationName.AndroidUIAutomator2,
            PlatformName = "Android",
            DeviceName = "Pixel_7_API_34",
        };

        driverOptions.AddAdditionalAppiumOption("appPackage", "com.webstaurantstore.storefront");
        driverOptions.AddAdditionalAppiumOption("appActivity", "com.webstaurantstore.storefront.MainActivity");
        // driverOptions.AddAdditionalAppiumOption("appPackage", "com.android.settings");
        // driverOptions.AddAdditionalAppiumOption("appActivity", ".Settings");
        // NoReset assumes the app com.google.android is preinstalled on the emulator
        driverOptions.AddAdditionalAppiumOption("noReset", true);

        _driver = new AndroidDriver(serverUri, driverOptions, TimeSpan.FromSeconds(180));
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        _driver.Dispose();
    }

    [Test]
    public void TestBattery()
    {
        // _driver.StartActivity("com.android.settings", ".Settings");
        // _driver.FindElement(By.XPath("//*[@text='Battery']")).Click();
        Assert.That(1, Is.EqualTo(1));
    }
}
