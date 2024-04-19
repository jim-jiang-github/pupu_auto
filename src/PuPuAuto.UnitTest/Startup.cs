using Microsoft.Extensions.DependencyInjection;
using PuPuAuto.Contracts;
using PuPuAuto.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.DependencyInjection;

namespace PuPuAuto.UnitTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IWeChatService, WeChatService>();
        }
    }
}
