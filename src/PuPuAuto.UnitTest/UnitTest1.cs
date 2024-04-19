using PuPuAuto.Contracts;

namespace PuPuAuto.UnitTest
{
    public class UnitTest1(IWeChatService weChatService)
    {
        [Theory]
        [InlineData("smile", true)]
        [InlineData("煎饼的归宿", true)]
        public async void SayHi(string user, bool expected)
        {
            var result = await weChatService.SayHi(user);
            Assert.Equal(expected, result);
        }
        [Fact]
        public async void OpenWeChat()
        {
            await weChatService.OpenWeChat();
        }
    }
}