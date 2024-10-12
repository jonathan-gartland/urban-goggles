// This sample code supports Appium .NET client >=5
// https://github.com/appium/dotnet-client
using System;
using System.Drawing;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace AppiumTests;

public class Tests2
{
    private AndroidDriver _driver;

    [OneTimeSetUp]
    public void SetUp()
    {
        var serverUri = new Uri("http://127.0.0.1:4724");
        var options = new AppiumOptions() {
            AutomationName = AutomationName.AndroidUIAutomator2,
            PlatformName = "Android",
            // DeviceName = "Pixel_7_API_34",
            DeviceName = "34151JEHN10650",
            PlatformVersion = "14",

        };
       
        options.AddAdditionalAppiumOption("appPackage", "com.webstaurantstore.storefront");
        options.AddAdditionalAppiumOption("appActivity", "com.webstaurantstore.storefront.MainActivity");
        options.AddAdditionalAppiumOption("noReset", false);
        options.AddAdditionalAppiumOption("newCommandTimeout", 300);
        options.AddAdditionalAppiumOption("autoAcceptAlerts", true);
        options.AddAdditionalAppiumOption("autoGrantPermissions", true);
        options.AddAdditionalAppiumOption("ensureWebviewsHavePages", true);
        options.AddAdditionalAppiumOption("nativeWebScreenshot", true);
        options.AddAdditionalAppiumOption("connectHardwareKeyboard", true);

        _driver = new AndroidDriver(serverUri, options);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        _driver.Dispose();
    }

    [Test]
    public void SampleTest()
    {
        Assert.That(1, Is.EqualTo(1));
    }
}
