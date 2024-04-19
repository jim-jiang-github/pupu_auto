using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using PuPuAuto.Contracts;

namespace PuPuAuto.Services
{
    public class WeChatService : IWeChatService
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        public WeChatService()
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("deviceName", "ce466c93");
            options.AddAdditionalCapability("automationName", "Appium");
            options.AddAdditionalCapability("platformName", "Android");
            options.AddAdditionalCapability("platformVersion", "13");
            options.AddAdditionalCapability("appPackage", "com.tencent.mm");
            options.AddAdditionalCapability("appActivity", "com.tencent.mm.ui.LauncherUI");
            options.AddAdditionalCapability("noReset", true);
            _remoteWebDriver = new RemoteWebDriver(new Uri("http://egretfamily.cn:4723/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(10000));
        }

        public Task<bool> SayHi(string user)
        {
            _remoteWebDriver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.tencent.mm:id/icon_tv\" and @text=\"微信\"]").Click();
            _remoteWebDriver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.tencent.mm:id/h5n\"])[1]").Click();
            _remoteWebDriver.FindElementByXPath("//android.widget.EditText[@resource-id=\"com.tencent.mm:id/d98\"]").SendKeys(user);
            //android.widget.EditText[@resource-id="com.tencent.mm:id/d98"]
            //android.widget.EditText[@resource-id="com.tencent.mm:id/d98"]
            throw new NotImplementedException();
        }
        public async Task<bool> OpenWeChat()
        {
            return await Task.Run(() =>
            {
                try
                {
                    _remoteWebDriver.FindElementsByXPath("//android.widget.RelativeLayout[@content-desc=\"微信\"]");
                }
                catch (Exception ex)
                {

                }
                return true;
            });
        }
        public async Task<bool> ClickChat()
        {
            return await Task.Run(() =>
            {
                try
                {
                    _remoteWebDriver.FindElementsByXPath("//android.widget.TextView[@resource-id=\"com.tencent.mm:id/icon_tv\" and @text=\"微信\"]");
                    _remoteWebDriver.FindElementsByXPath("(//android.widget.ImageView[@resource-id=\"com.tencent.mm:id/h5n\"])[1]");
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            });
        }
    }
}
