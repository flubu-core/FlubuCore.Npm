﻿using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Npm
{
    public class NpmPackTask : ExternalProcessTaskBase<int, NpmPackTask>
    {
        public NpmPackTask(string source)
        {
            ExecutablePath = "npm";
            WithArguments("pack");
            WithArguments(source);
        }
        
        protected override string Description { get; set; }

        public NpmPackTask DryRun()
        {
            WithArguments("--dry-run");
            return this;
        }
    }
}
