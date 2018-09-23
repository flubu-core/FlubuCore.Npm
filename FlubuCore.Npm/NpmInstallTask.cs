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

        public NpmInstallTask AddPackage(string package)
        {
            _packages.Add(package);
            return this;
        }

        public NpmInstallTask Production()
        {
            WithArguments("--production");
            return this;
        }

        /// <summary>
        /// argument will force npm to fetch remote resources even if a local copy exists on disk.
        /// </summary>
        /// <returns></returns>
        public NpmInstallTask Force()
        {
            WithArguments("--force");
            return this;
        }

        /// <summary>
        ///  argument will cause npm to install the package globally rather than locally. 
        /// </summary>
        /// <returns></returns>
        public NpmInstallTask Global()
        {
            WithArguments("--global");
            return this;
        }

        /// <summary>
        /// argument will cause npm to install the package into your local node_modules folder with the same layout it uses with the global node_modules folder.
        /// </summary>
        /// <returns></returns>
        public NpmInstallTask GlobalStyle()
        {
            WithArguments("--global-style");
            return this;
        }

        /// <summary>
        /// argument will cause npm to not execute any scripts defined in the package.json.
        /// </summary>
        /// <returns></returns>
        public NpmInstallTask IgnoreScripts()
        {
            WithArguments("--ignore-scripts");
            return this;
        }

        /// <summary>
        /// rgument will cause npm to install the package such that versions of npm prior to 1.4, such as the one included with node 0.8, can install the package.
        /// This eliminates all automatic deduping.
        /// </summary>
        /// <returns></returns>
        public NpmInstallTask LegacyBundling()
        {
            WithArguments("--legacy-bundling");
            return this;
        }

        /// <summary>
        /// argument will cause npm to link global installs into the local space in some cases.
        /// </summary>
        /// <returns></returns>
        public NpmInstallTask Link()
        {
            WithArguments("--link");
            return this;
        }

        /// <summary>
        ///  argument will prevent npm from creating symlinks for any binaries the package might contain.
        /// </summary>
        /// <returns></returns>
        public NpmInstallTask NoBinLinks()
        {
            WithArguments("--no-bin-links");
            return this;
        }

        /// <summary>
        /// argument will prevent optional dependencies from being installed.
        /// </summary>
        /// <returns></returns>
        public NpmInstallTask NoOptional()
        {
            WithArguments("--no-optional");
            return this;
        }

        /// <summary>
        /// argument, which will ignore an available package lock or shrinkwrap file and use the package.json instead.
        /// </summary>
        /// <returns></returns>
        public NpmInstallTask NoShrinkWrap()
        {
            WithArguments("--no-shrinkwrap");
            return this;
        }

        public NpmInstallTask NoPackageLock()
        {
            WithArguments("--no-package-lock");
            return this;
        }

        /// <summary>
        /// argument will allow npm to find the node source code so that npm can compile native modules.
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public NpmInstallTask NodeDir(string directory)
        {
            WithArguments($"nodedir={directory}");
            return this;
        }

        /// <summary>
        /// argument will cause either only devDependencies or only non-devDependencies to be installed regardless of the NODE_ENV.
        /// </summary>
        /// <param name="only"></param>
        /// <returns></returns>
        public NpmInstallTask Only(string only)
        {
            WithArguments($"only={only}");
            return this;
        }

        public NpmInstallTask NoAudit()
        {
            WithArguments("--no-audit");
            return this;
        }

        public NpmInstallTask DryRun()
        {
            WithArguments("--dry-run");
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
