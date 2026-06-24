using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Workflow.Processes;

[assembly: AssemblyLicenseUnit(ComponentType.Server, typeof(InternalProcessesService))]
[assembly: AssemblyModule("{5909F95F-DF99-456F-B6CB-0215D25C5603}")]
[assembly: Module("EleWise.ELMA.Workflow.Processes", "{5909F95F-DF99-456F-B6CB-0215D25C5603}")]
[assembly: AssemblyDescription("Модуль управления бизнес-процессами")]
[assembly: ComponentAssembly]
[assembly: ModelAssembly]
[assembly: ModuleTitle("Управление бизнес-процессами")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Workflow.Processes.Proxies")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Actors")]
[assembly: ModuleWebSite("http://www.elma-bpm.ru")]
[assembly: ServerModuleRequired]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
[assembly: AssemblyCompany("ELMA")]
[assembly: AssemblyProduct("ELMA")]
[assembly: AssemblyCopyright("Copyright © 2006-2023 ELMA")]
[assembly: Guid("05eacdb3-6ab1-48b2-bf4f-50a785fd1f09")]
[assembly: ComVisible(false)]
[assembly: AssemblyTitle("Управление бизнес-процессами")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyTrademark("ELMA")]
[assembly: AssemblyFileVersion("4.1.34.11114")]
[assembly: AssemblyInformationalVersion("4.1.34.11114 R.ce76722f6d1f86")]
[assembly: AssemblyVersion("1.0.0.0")]
