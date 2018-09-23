using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Npm
{
    public class NpmRunScriptTask : ExternalProcessTaskBase<NpmRunScriptTask>
    {
        protected override string Description { get; set; }

        /// <summary>
        /// Runs an arbitrary command from a package's "scripts".
        /// </summary>
        /// <param name="command"></param>
        public NpmRunScriptTask(string command)
        {
            WithArguments("run-script");
            WithArguments(command);
        }
    }
}
