using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using PuPuAuto.Contracts;

namespace PuPuAuto.Services
{
    public class WeChatService : IWeChatService
    {
        public async Task<bool> SendMessage(string user, string message)
        {
            try
            {
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability("deviceName", "ce466c93");
                options.AddAdditionalCapability("automationName", "Appium");
                options.AddAdditionalCapability("platformName", "Android");
                options.AddAdditionalCapability("platformVersion", "13");
                options.AddAdditionalCapability("appPackage", "com.tencent.mm");
                options.AddAdditionalCapability("appActivity", "com.tencent.mm.ui.LauncherUI");
                options.AddAdditionalCapability("noReset", true);
                RemoteWebDriver remoteWebDriver = new RemoteWebDriver(new Uri("http://egretfamily.cn:4723/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(10000));
                await Task.Delay(1000);
                remoteWebDriver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.tencent.mm:id/icon_tv\" and @text=\"微信\"]").Click();
                await Task.Delay(1000);
                remoteWebDriver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.tencent.mm:id/h5n\"])[1]").Click();
                await Task.Delay(1000);
                remoteWebDriver.FindElementByXPath("//android.widget.EditText[@resource-id=\"com.tencent.mm:id/d98\"]").SendKeys(user);
                await Task.Delay(1000);
                remoteWebDriver.FindElementByXPath($"//android.widget.TextView[@resource-id=\"com.tencent.mm:id/odf\" and @text=\"{user}\"]").Click();
                await Task.Delay(1000);
                remoteWebDriver.FindElementByXPath("//android.widget.EditText[@resource-id=\"com.tencent.mm:id/bkk\"]").SendKeys(message); //Input textbox
                await Task.Delay(1000);
                remoteWebDriver.FindElementByXPath("//android.widget.Button[@resource-id=\"com.tencent.mm:id/bql\"]").Click(); //Send button
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> OpenWeChat()
        {
            return await Task.Run(() =>
            {
                try
                {
                    return true;
                }
                catch
                {
                    return false;
                }
            });
        }
    }
}
