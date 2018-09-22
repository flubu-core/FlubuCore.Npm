using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context.FluentInterface.Interfaces;

namespace FlubuCore.Npm
{
    public static class NpmExtensions
    {
        public static Npm Npm(this ITaskFluentInterface flubu)
        {
            return new Npm();
        }
    }
}
