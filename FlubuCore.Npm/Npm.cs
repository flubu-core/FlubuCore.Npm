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
        /// Create a tarball from a package.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public NpmPackTask Pack(string source)
        {
            return new NpmPackTask(source);
        }

        /// <summary>
        /// Publishes a package to the registry so that it can be installed by name. All files in the package directory are included if no local .gitignore or .npmignore file exists.
        /// If both files exist and a file is ignored by .gitignore but not by .npmignore then it will be included.
        /// </summary>
        /// <returns></returns>
        public NpmPublishTask Publish()
        {
            return new NpmPublishTask();
        }

        /// <summary>
        /// This command will update all the packages listed to the latest version (specified by the tag config), respecting semver.
        /// </summary>
        /// <returns></returns>
        public NpmUpdateTask Update()
        {
            return new NpmUpdateTask();
        }

        /// <summary>
        /// This command runs the npm build command on the matched folders.
        /// This is useful when you install a new version of node, and must recompile all your C++ addons with the new binary.
        /// </summary>
        /// <param name="packages">packages to rebuild.</param>
        /// <returns></returns>
        public NpmRebuildTask Rebuild(params string[] packages)
        {
            return new NpmRebuildTask(packages);
        }
    }
}
