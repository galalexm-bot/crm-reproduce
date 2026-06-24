using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Workflow;

[assembly: InternalsVisibleTo("EleWise.ELMA.Workflow.Db.Oracle")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Workflow.Db.MsSql")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Workflow.Db.PostgeSQL")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Common.Integration.Tests")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Common.Tests")]
[assembly: ModuleWebSite("http://www.elma-bpm.ru")]
[assembly: ServerModuleRequired]
[assembly: InternalsVisibleTo("EleWise.ELMA.Workflow.UIBuilder")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Workflow.Processes.Web")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Workflow.Processes")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Workflow.Proxies")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Actors")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Workflow.Unit.Tests")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Workflow.Tests")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Documents.Mobile")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Workflow.Web.Unit.Tests")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Workflow.Web")]
[assembly: AssemblyTrademark("ELMA")]
[assembly: AssemblyCopyright("Copyright © 2006-2023 ELMA")]
[assembly: AssemblyFileVersion("4.1.34.11114")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyInformationalVersion("4.1.34.11114 R.ce76722f6d1f86")]
[assembly: AssemblyProduct("ELMA")]
[assembly: AssemblyCompany("ELMA")]
[assembly: AssemblyModule("{916F85CE-DF70-4304-B36C-5AAF4AF80C73}")]
[assembly: AssemblyLicenseUnit(ComponentType.Server, typeof(InternalWorkflowService))]
[assembly: Module("EleWise.ELMA.Workflow", "{916F85CE-DF70-4304-B36C-5AAF4AF80C73}")]
[assembly: ModuleType(ModuleType.Accessory)]
[assembly: ModuleTitle("Базовый модуль для процессов и маршрутов документов")]
[assembly: ComVisible(false)]
[assembly: Guid("c2d110bd-3d56-4daa-b91f-ed6fcbe90b0c")]
[assembly: AssemblyTitle("EleWise.ELMA.Workflow")]
[assembly: ModelAssembly]
[assembly: ComponentAssembly]
[assembly: AssemblyVersion("1.0.0.0")]
