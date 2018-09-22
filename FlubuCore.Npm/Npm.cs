using System;
using System.Collections.Generic;
using System.Text;

namespace FlubuCore.Npm
{
    public class Npm
    {
        public NpmInstallTask Install()
        {
            return new NpmInstallTask();
        }
    }
}
