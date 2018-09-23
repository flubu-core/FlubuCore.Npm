using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Npm
{
    public class NpmPublishTask : ExternalProcessTaskBase<NpmPublishTask>
    {
        protected override string Description { get; set; }

        /// <summary>
        /// Runs an arbitrary command from a package's "scripts".
        /// </summary>
        /// <param name="command"></param>
        public NpmPublishTask()
        {
            WithArguments("publish");
        }

        /// <summary>
        /// A folder containing a package.json file or
        /// A url or file path to a gzipped tar archive containing a single folder with a package.json file inside.
        /// </summary>
        /// <param name="source"></param>
        public NpmPublishTask FolderOrTarball(string source)
        {
            WithArguments(source);
            return this;
        }

        /// <summary>
        /// Registers the published package with the given tag, such that npm install <name>@<tag> will install this version.
        /// By default, npm publish updates and npm install installs the latest tag.
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public NpmPublishTask Tag(string tag)
        {
            WithArguments($"--tag={tag}");
            return this;
        }

        /// <summary>
        /// Tells the registry whether this package should be published as public or restricted. Only applies to scoped packages, which default to restricted.
        /// If you don't have a paid account, you must publish with --access public to publish scoped packages.
        /// </summary>
        /// <param name="access"></param>
        /// <returns></returns>
        public NpmPublishTask Access(NpmAccess access)
        {
            WithArguments($"--access={access}");
            return this;
        }

        /// <summary>
        ///  If you have two-factor authentication enabled in auth-and-writes mode then you can provide a code from your authenticator with this. 
        /// </summary>
        /// <param name="otp"></param>
        /// <returns></returns>
        public NpmPublishTask Otp(string otp)
        {
            WithArguments($"--otp={otp}");
            return this;
        }

        /// <summary>
        ///  Does everything publish would do except actually publishing to the registry. Reports the details of what would have been published.
        /// </summary>
        /// <returns></returns>
        public NpmPublishTask DryRun()
        {
            WithArguments("--dry-run");
            return this;
        }
    }
}
