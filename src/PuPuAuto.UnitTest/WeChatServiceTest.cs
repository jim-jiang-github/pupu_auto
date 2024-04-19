using PuPuAuto.Contracts;

namespace PuPuAuto.UnitTest
{
    public class WeChatServiceTest(IWeChatService weChatService)
    {
        [Theory]
        [InlineData("smile", "测试发送一些字符串", true)]
        [InlineData("煎饼的归宿", "测试发送一些字符串", true)]
        public async void SendMessage(string user, string message, bool expected)
        {
            var result = await weChatService.SendMessage(user, message);
            Assert.Equal(expected, result);
        }
        [Fact]
        public async void OpenWeChat()
        {
            await weChatService.OpenWeChat();
        }
    }
}