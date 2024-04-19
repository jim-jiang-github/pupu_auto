using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuPuAuto.Contracts
{
    public interface IWeChatService
    {
        Task<bool> SayHi(string user);
        Task<bool> OpenWeChat();
    }
}
