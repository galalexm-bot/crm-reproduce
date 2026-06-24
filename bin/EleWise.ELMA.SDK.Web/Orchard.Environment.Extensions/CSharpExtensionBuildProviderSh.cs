using System;
using System.Reflection;
using System.Web.Compilation;

namespace Orchard.Environment.Extensions.Compilers;

public class CSharpExtensionBuildProviderShim : BuildProvider, IShim
{
	private readonly CompilerType _codeCompilerType;

	public IOrchardHostContainer HostContainer { get; set; }

	public override CompilerType CodeCompilerType => _codeCompilerType;

	public CSharpExtensionBuildProviderShim()
	{
		OrchardHostContainerRegistry.RegisterShim(this);
		_codeCompilerType = GetDefaultCompilerTypeForLanguage("C#");
		Version version = new AssemblyName(typeof(IDependency).Assembly.FullName).Version;
		_codeCompilerType.CompilerParameters.CompilerOptions += $"/define:ORCHARD_{version.Major}_{version.Minor}";
	}

	public override void GenerateCode(AssemblyBuilder assemblyBuilder)
	{
		CompileExtensionContext context = new CompileExtensionContext
		{
			VirtualPath = base.VirtualPath,
			AssemblyBuilder = new AspNetAssemblyBuilder(assemblyBuilder, this)
		};
		HostContainer.Resolve<IExtensionCompiler>().Compile(context);
	}
}
