using System;
using System.Collections.Generic;
using System.Text;

namespace FlubuCore.Npm
{
    public class Npm
    {
        /// <summary>
        /// This command installs a package, and any packages that it depends on.
        /// If the package has a package-lock or shrinkwrap file, the installation of dependencies will be driven by that, with an npm-shrinkwrap.json taking precedence if both files exist.
        /// </summary>
        /// <returns></returns>
        public NpmInstallTask Install()
        {
            return new NpmInstallTask();
        }

        /// <summary>
        /// Runs an arbitrary command from a package's "scripts".
        /// </summary>
        /// <param name="command"></param>
        public NpmRunScriptTask RunScript(string command)
        {
            return new NpmRunScriptTask(command);
        }

        /// <summary>
        /// Create a tarball from a package
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public NpmPackTask Pack(string source)
        {
            return new NpmPackTask(source);
        }
    }
}
