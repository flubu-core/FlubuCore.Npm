using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Npm
{
    public class NpmInstallTask : ExternalProcessTaskBase<NpmInstallTask>
    {
        private List<string> _packages;

        public NpmInstallTask()
        {
            _packages = new List<string>();
            WithArguments("npm");
            WithArguments("install");
        }

        public NpmInstallTask Packages(string package)
        {
            _packages.Add(package);
            return this;
        }

        public NpmInstallTask Production()
        {
            WithArguments("--production");
            return this;
        }

        public NpmInstallTask Force()
        {
            WithArguments("--force");
            return this;
        }

        public NpmInstallTask Global()
        {
            WithArguments("--global");
            return this;
        }

        public NpmInstallTask GlobalStyle()
        {
            WithArguments("--global-style");
            return this;
        }

        public NpmInstallTask IgnoreScripts()
        {
            WithArguments("--ignore-scripts");
            return this;
        }

        public NpmInstallTask LegacyBundling()
        {
            WithArguments("--legacy-bundling");
            return this;
        }

        public NpmInstallTask Link()
        {
            WithArguments("--link");
            return this;
        }

        public NpmInstallTask NoBinLinks()
        {
            WithArguments("--no-bin-links");
            return this;
        }

        public NpmInstallTask NoOptional()
        {
            WithArguments("--no-optional");
            return this;
        }

        public NpmInstallTask NoShrinkWrap()
        {
            WithArguments("--no-shrinkwrap");
            return this;
        }

        public NpmInstallTask NodeDir(string directory)
        {
            WithArguments($"nodedir={directory}");
            return this;
        }

        public NpmInstallTask Only(string only)
        {
            WithArguments($"only={only}");
            return this;
        }

        protected override int DoExecute(ITaskContextInternal context)
        {
            foreach (var package in _packages)
            {
                InsertArgument(2, package);
            }

            return base.DoExecute(context);
        }

        protected override string Description { get; set; }
    }
}
