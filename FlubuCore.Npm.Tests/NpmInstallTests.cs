using System;
using FlubuCore.Context;
using Xunit;

namespace FlubuCore.Npm.Tests
{
    public class NpmInstallTests
    {
        private NpmInstallTask task;

        public NpmInstallTests()
        {
            task = new NpmInstallTask();
        }

        [Fact]
        public void NpmInstallBasicTest()
        {
            task.AddPackage("a").Global().AddPackage("b");
            //// todo
        }
    }
}
