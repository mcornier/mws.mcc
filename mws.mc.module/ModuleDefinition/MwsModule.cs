using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mws.mc.module
{
    public abstract class MwsModule
    {
        public const string Name = "mws.mc.module";

        public readonly Guid ModuleKey;

        public readonly Version Version;

        public readonly string Description = "";
    }
}
