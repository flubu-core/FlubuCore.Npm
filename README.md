# FlubuCore.Npm

# FlubuCore.CakePlugin

[![NuGet](https://img.shields.io/nuget/v/FlubuCore.CakePlugin.svg)](https://www.nuget.org/packages/FlubuCore.Cakeplugin/)
[![Gitter](https://img.shields.io/gitter/room/FlubuCore/Lobby.svg)](https://gitter.im/FlubuCore/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![License](https://img.shields.io/github/license/flubu-core/flubuCore.CakePlugin.svg)](https://github.com/flubu-core/FlubuCore.CakePlugin/blob/master/LICENSE)

FlubuCore.Npm is a [FlubuCore](https://github.com/flubu-core/flubu.core) plugin adds npm specific tasks.

Plugin adds npm tasks to FlubuCore ``` ITaskContext ``` interface:  ``` context.Tasks().Npm() ```

Plugin adds Following tasks:
* NpmInstallTask
* NpmPackTask
* NpmPublishTask
* NpmRebuildTask 
* NpmRunScriptTask
* NpmUpdateTask
