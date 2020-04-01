using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Npm
{
    public class NpmRebuildTask : ExternalProcessTaskBase<int, NpmRunScriptTask>
    {
        protected override string Description { get; set; }

        /// <summary>
        /// Runs an arbitrary command from a package's "scripts".
        /// </summary>
        /// <param name="packages"></param>
        public NpmRebuildTask(params string[] packages)
        {
            ExecutablePath = "npm";
            WithArguments("rebuild");

            if (packages.Length > 0)
            {
                WithArguments(packages);
            }
        }
    }
}
