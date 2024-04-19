using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuPuAuto.Contracts
{
    public interface IWeChatService
    {
        Task<bool> SendMessage(string user, string message);
        Task<bool> OpenWeChat();
    }
}
