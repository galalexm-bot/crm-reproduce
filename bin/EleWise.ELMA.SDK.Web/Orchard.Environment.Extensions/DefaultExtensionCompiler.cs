using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Logging;
using Orchard.Environment.Extensions.Loaders;
using Orchard.Exceptions;
using Orchard.FileSystems.Dependencies;
using Orchard.FileSystems.VirtualPath;
using Orchard.Localization;
using Orchard.Logging;

namespace Orchard.Environment.Extensions.Compilers;

public class DefaultExtensionCompiler : IExtensionCompiler
{
	private readonly IVirtualPathProvider _virtualPathProvider;

	private readonly IProjectFileParser _projectFileParser;

	private readonly IDependenciesFolder _dependenciesFolder;

	private readonly IEnumerable<IExtensionLoader> _loaders;

	private readonly IAssemblyLoader _assemblyLoader;

	private readonly ICriticalErrorProvider _criticalErrorProvider;

	public Localizer T { get; set; }

	public ILogger Logger { get; set; }

	public DefaultExtensionCompiler(IVirtualPathProvider virtualPathProvider, IProjectFileParser projectFileParser, IDependenciesFolder dependenciesFolder, IEnumerable<IExtensionLoader> loaders, IAssemblyLoader assemblyLoader, ICriticalErrorProvider criticalErrorProvider)
	{
		_virtualPathProvider = virtualPathProvider;
		_projectFileParser = projectFileParser;
		_dependenciesFolder = dependenciesFolder;
		_loaders = loaders;
		_assemblyLoader = assemblyLoader;
		_criticalErrorProvider = criticalErrorProvider;
		T = NullLocalizer.Instance;
		Logger = NullLogger.Instance;
	}

	public void Compile(CompileExtensionContext context)
	{
		Logger.Information("Generate code for file \"{0}\"", context.VirtualPath);
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(context.VirtualPath);
		DependencyDescriptor descriptor = _dependenciesFolder.GetDescriptor(fileNameWithoutExtension);
		if (descriptor == null)
		{
			return;
		}
		try
		{
			ProjectFileDescriptor projectFileDescriptor = _projectFileParser.Parse(context.VirtualPath);
			string directory = _virtualPathProvider.GetDirectoryName(context.VirtualPath);
			foreach (string item in projectFileDescriptor.SourceFilenames.Select((string f) => _virtualPathProvider.Combine(directory, f)))
			{
				context.AssemblyBuilder.AddCodeCompileUnit(CreateCompileUnit(item));
			}
			HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			foreach (DependencyReferenceDescriptor reference in descriptor.References)
			{
				DependencyReferenceDescriptor referenceTemp = reference;
				IExtensionLoader extensionLoader = _loaders.SingleOrDefault((IExtensionLoader l) => l.Name == referenceTemp.LoaderName);
				if (extensionLoader == null)
				{
					Logger.Warning("Could not find loader '{0}' in active loaders", reference.LoaderName);
					continue;
				}
				Assembly assembly = extensionLoader.LoadReference(reference);
				if (assembly == null)
				{
					Logger.Warning("Loader '{0}' could not load reference '{1}'", reference.LoaderName, reference.Name);
				}
				else
				{
					hashSet.Add(reference.Name);
					context.AssemblyBuilder.AddAssemblyReference(assembly);
				}
			}
			_criticalErrorProvider.Clear();
			foreach (ReferenceDescriptor reference2 in projectFileDescriptor.References)
			{
				if (!hashSet.Contains(reference2.SimpleName))
				{
					Assembly assembly2 = _assemblyLoader.Load(reference2.FullName);
					if (!(assembly2 != null))
					{
						Logger.Error("Assembly reference '{0}' for project '{1}' cannot be loaded", reference2.FullName, context.VirtualPath);
						_criticalErrorProvider.RegisterErrorMessage(T("The assembly reference '{0}' could not be loaded for module '{1}'.\r\n\r\nThere are generally a few ways to solve this issue:\r\n1. Install any dependent module.\r\n2. Remove the assembly reference from the project file if it's not needed.\r\n3. Ensure the assembly reference is present in the 'bin' directory of the module.\r\n4. Ensure the assembly reference is present in the 'bin' directory of the application.\r\n5. Specify the strong name of the assembly (name, version, culture, publickey) if the assembly is present in the GAC.", reference2.FullName, fileNameWithoutExtension));
						throw new OrchardCoreException(T("Assembly reference '{0}' for project '{1}' cannot be loaded", reference2.FullName, context.VirtualPath));
					}
					context.AssemblyBuilder.AddAssemblyReference(assembly2);
				}
			}
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			throw new OrchardCoreException(T("Error compiling module \"{0}\" from file \"{1}\":\r\n{2}", fileNameWithoutExtension, context.VirtualPath, ex.Message), ex);
		}
	}

	private CodeCompileUnit CreateCompileUnit(string virtualPath)
	{
		CodeSnippetCompileUnit codeSnippetCompileUnit = new CodeSnippetCompileUnit(GetContents(virtualPath));
		string text = _virtualPathProvider.MapPath(virtualPath);
		if (!string.IsNullOrEmpty(text))
		{
			codeSnippetCompileUnit.LinePragma = new CodeLinePragma(text, 1);
		}
		return codeSnippetCompileUnit;
	}

	private string GetContents(string virtualPath)
	{
		using Stream stream = _virtualPathProvider.OpenFile(virtualPath);
		using StreamReader streamReader = new StreamReader(stream);
		return streamReader.ReadToEnd();
	}
}
