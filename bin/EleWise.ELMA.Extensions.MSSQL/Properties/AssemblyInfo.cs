using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions.MSSQL;
using EleWise.ELMA.Modules.Attributes;

[assembly: AssemblyModule("{C1392D5A-E5B7-4150-B245-C8D15C738A12}")]
[assembly: AssemblyDescription("Провайдер БД ELMA - MSSQL")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyLicenseUnit(ComponentType.Server, typeof(MSSQLProviderImpl))]
[assembly: InternalsVisibleTo("EleWise.ELMA.History.Db.MsSql")]
[assembly: ComponentAssembly]
[assembly: ComVisible(false)]
[assembly: Guid("4A8FFDB8-2C56-4457-99A8-0D83448E8C2B")]
[assembly: AssemblyCompany("ELMA")]
[assembly: AssemblyProduct("ELMA")]
[assembly: AssemblyFileVersion("4.1.34.11114")]
[assembly: AssemblyInformationalVersion("4.1.34.11114 R.ce76722f6d1f86")]
[assembly: AssemblyCopyright("Copyright © 2006-2023 ELMA")]
[assembly: AssemblyTrademark("ELMA")]
[assembly: AssemblyVersion("1.0.0.0")]
