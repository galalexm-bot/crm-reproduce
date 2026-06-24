using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Security;

[assembly: InternalsVisibleTo("EleWise.ELMA.BPM.Web.Security")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Security.Mobile")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Tasks.Tests")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Security.Tests")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Security.Web")]
[assembly: ServerModuleRequired]
[assembly: ModuleTitle("Безопасность")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Security.Proxies")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Tasks.Unit.Tests")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Documents.Web")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Actors")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Documents.Integration.Tests")]
[assembly: InternalsVisibleTo("EleWise.ELMA.BPM.Web.Tasks")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Workflow.Integration.Tests")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Documents")]
[assembly: InternalsVisibleTo("EleWise.ELMA.Tasks")]
[assembly: AssemblyCopyright("Copyright © 2006-2023 ELMA")]
[assembly: AssemblyProduct("ELMA")]
[assembly: AssemblyFileVersion("4.1.34.11114")]
[assembly: AssemblyTrademark("ELMA")]
[assembly: AssemblyCompany("ELMA")]
[assembly: AssemblyInformationalVersion("4.1.34.11114 R.ce76722f6d1f86")]
[assembly: AssemblyLicenseUnit(ComponentType.Server, typeof(InternalSecurityService))]
[assembly: ModelAssembly]
[assembly: Module("EleWise.ELMA.Security", "{F13760BF-2F26-4A87-AF64-3A9A19481D3B}")]
[assembly: AssemblyModule("{F13760BF-2F26-4A87-AF64-3A9A19481D3B}")]
[assembly: ComponentAssembly]
[assembly: Guid("6f08a1a5-c28e-4ca7-b955-f63891b7c0b7")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyTitle("EleWise.ELMA.Security")]
[assembly: ComVisible(false)]
[assembly: AssemblyVersion("1.0.0.0")]
