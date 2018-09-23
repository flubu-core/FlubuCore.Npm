using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context.FluentInterface.Interfaces;

namespace FlubuCore.Npm
{
    public static class NpmExtensions
    {
        /// <summary>
        /// Npm specific tasks.
        /// </summary>
        /// <param name="flubu"></param>
        /// <returns></returns>
        public static Npm Npm(this ITaskFluentInterface flubu)
        {
            return new Npm();
        }
    }
}
