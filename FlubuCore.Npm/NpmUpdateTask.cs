using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Npm
{
    public class NpmUpdateTask: ExternalProcessTaskBase<NpmRunScriptTask>
    {
        protected override string Description { get; set; }

        /// <summary>
        /// This command will update all the packages listed to the latest version (specified by the tag config), respecting semver.
        /// </summary>
        public NpmUpdateTask()
        {
            ExecutablePath = "npm";
            WithArguments("update");
        }

        /// <summary>
        /// If the global (-g) flag is specified, this command will update globally installed packages.
        /// </summary>
        /// <returns></returns>
        public NpmUpdateTask Global()
        {
            WithArguments("-g");
            return this;
        }
    }
}
