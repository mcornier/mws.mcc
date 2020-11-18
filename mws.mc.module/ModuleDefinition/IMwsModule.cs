using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mws.mc.module
{
    public interface IMwsModuleStartup
    {
        Task Start(IServiceCollection services, MwsModuleSettings settings);

        MwsModuleSettings Settings { get; }

        IMwsModuleStartup Instance => throw new NotImplementedException();

        MwsModule MwsModule { get; }
    }
}
