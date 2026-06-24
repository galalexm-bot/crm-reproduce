using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using EleWise.ELMA.CodeAnalyzers;
using EleWise.ELMA.CodeAnalyzers.Model;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UIBuilder.CodeAnalyzers;
using EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;
using EleWise.ELMA.UIBuilder.Model;
using EleWise.ELMA.UIBuilder.Services;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

internal sealed class ModuleAssemblyBuilder : IDisposable
{
	private static readonly ISet<Guid> designerModules = ModuleMetadataItemHeaderManager.DesignerModules;

	private readonly Guid itemUid;

	private readonly ModuleInfoMetadata moduleMetadata;

	private readonly IDictionary<Guid, ScriptModule> serverScripts;

	private readonly IDictionary<Guid, ScriptModule> clientScripts;

	private readonly IDictionary<Guid, ScriptModule> viewScripts;

	private readonly IDictionary<Guid, ScriptModule> testScripts;

	private readonly string version;

	private readonly IEnumerable<IMetadataSourcesProvider> metadataSourcesProviders;

	private readonly IJavaScriptCompilerService javaScriptCompilerService;

	private readonly IEnumerable<PublishedModule> dependencyModuleList;

	private readonly ModelAssemblyBuilder assemblyBuilder;

	private readonly IJavaScriptCompilerModel clientCompilerModel;

	private readonly string clientAssemblyName;

	private bool disposed;

	private Dictionary<string, byte[]> restrictedAssemblyRaws = new Dictionary<string, byte[]>();

	public ModuleAssemblyBuilder(Guid itemUid, ModuleInfoMetadata moduleMetadata, IDictionary<Guid, ScriptModule> serverScripts, IDictionary<Guid, ScriptModule> clientScripts, IDictionary<Guid, ScriptModule> viewScripts, IDictionary<Guid, ScriptModule> testScripts, string version, IEnumerable<IMetadataSourcesProvider> metadataSourcesProviders, IJavaScriptCompilerService javaScriptCompilerService, IEnumerable<PublishedModule> dependencyModuleList)
	{
		this.itemUid = itemUid;
		this.moduleMetadata = moduleMetadata;
		this.serverScripts = serverScripts;
		this.clientScripts = clientScripts;
		this.viewScripts = viewScripts;
		this.testScripts = testScripts;
		this.version = version;
		this.metadataSourcesProviders = metadataSourcesProviders;
		this.javaScriptCompilerService = javaScriptCompilerService;
		this.dependencyModuleList = dependencyModuleList;
		assemblyBuilder = new ModelAssemblyBuilder
		{
			AssemblyName = ModuleMetadataItemManager.ServerAssemblyName(moduleMetadata)
		};
		clientAssemblyName = ModuleMetadataItemManager.ClientAssemblyName(moduleMetadata);
		bool flag = moduleMetadata.Components.Any((ComponentMetadata c) => c.ViewScriptUid.HasValue && c.ViewScriptUid.Value != Guid.Empty);
		clientCompilerModel = javaScriptCompilerService.CreateCompilerModel(clientAssemblyName, !designerModules.Contains(moduleMetadata.Uid) && !flag, version);
	}

	public ModuleBuildResult Build(bool withoutJsOutput)
	{
		List<IMetadata> list = new List<IMetadata>(moduleMetadata.DataClasses.Count + moduleMetadata.Functions.Count + moduleMetadata.Components.Count);
		list.AddRange(moduleMetadata.DataClasses);
		list.AddRange(moduleMetadata.Functions);
		list.AddRange(moduleMetadata.Components);
		foreach (IMetadata item in list)
		{
			MetadataSourcesProviderArgs sourcesProviderArgs = GetSourcesProviderArgs(item);
			foreach (IMetadataSourcesProvider metadataSourcesProvider in metadataSourcesProviders)
			{
				metadataSourcesProvider.GetServerSources(sourcesProviderArgs).ForEach(delegate(string s)
				{
					assemblyBuilder.AddSourceCode(s);
				});
				metadataSourcesProvider.GetClientSources(sourcesProviderArgs).ForEach(delegate((string fileName, string sourceCode) a)
				{
					clientCompilerModel.AddSourceCode(a.fileName, a.sourceCode);
				});
				metadataSourcesProvider.GetViewSources(sourcesProviderArgs).ForEach(delegate((string fileName, string sourceCode) a)
				{
					clientCompilerModel.AddSourceCode(a.fileName, a.sourceCode);
				});
			}
		}
		moduleMetadata.ProjectItems.ForEach(delegate(ProjectItem a)
		{
			if (a is ClientProjectItem clientProjectItem)
			{
				if (clientProjectItem.FileExtension == "js")
				{
					clientCompilerModel.AddJsSourceCode(clientProjectItem.Code);
				}
				else
				{
					clientCompilerModel.AddSourceCode(a.FileName, a.Code);
				}
			}
			else
			{
				assemblyBuilder.AddSourceCode(a.Code);
			}
		});
		GenerateServerAssemblyInfo();
		AddDefaultServerReferences();
		AddServerReferences();
		AddWebDesignerOnlyReferences();
		DataClassUsageAnalyzer dataClassUsageAnalyzer = new DataClassUsageAnalyzer();
		ServerEntityUsageAnalyzer serverEntityUsageAnalyzer = new ServerEntityUsageAnalyzer();
		EnumUsageAnalyzer enumUsageAnalyzer = new EnumUsageAnalyzer();
		assemblyBuilder.AddAnalyzers((DiagnosticAnalyzer)dataClassUsageAnalyzer, (DiagnosticAnalyzer)serverEntityUsageAnalyzer, (DiagnosticAnalyzer)enumUsageAnalyzer);
		assemblyBuilder.AddAnalyzers(new MappersComponentsAnalyzer());
		assemblyBuilder.Build();
		AddClientReferences();
		clientCompilerModel.AddSourceCode(moduleMetadata.Name + "_AssemblyName", GetClientAssemblyInfo());
		clientCompilerModel.ReplaceModelMetadata.AddRange(moduleMetadata.DataClasses.Select((DataClassMetadata md) => new ReplaceModelMetadata(md, clientAssemblyName)));
		clientCompilerModel.ReplaceModelMetadata.AddRange(moduleMetadata.Components.SelectMany((ComponentMetadata md) => md.DataClasses.Select((DataClassMetadata localDataClass) => new ReplaceModelMetadata(md, localDataClass, clientAssemblyName))));
		clientCompilerModel.ReplaceModelMetadata.AddRange(dependencyModuleList.SelectMany((PublishedModule md) => md.Metadata.DataClasses.Select((DataClassMetadata dc) => new ReplaceModelMetadata(dc, md.ClientBuildResult?.AssemblyName))));
		ClientEntityUsageAnalyzer clientEntityUsageAnalyzer = new ClientEntityUsageAnalyzer();
		clientCompilerModel.AddAnalyzers((DiagnosticAnalyzer)clientEntityUsageAnalyzer, (DiagnosticAnalyzer)enumUsageAnalyzer, (DiagnosticAnalyzer)dataClassUsageAnalyzer);
		Dictionary<Guid, string> assemblyNames = dependencyModuleList.ToDictionary((PublishedModule pm) => pm.Metadata.Uid, (PublishedModule pm) => pm.ClientBuildResult?.AssemblyName);
		assemblyNames.Add(moduleMetadata.Uid, clientAssemblyName);
		JavaScriptCodeCompilerResult javaScriptCodeCompilerResult = javaScriptCompilerService.Compile(clientCompilerModel, withoutJsOutput, delegate
		{
			BridgeCompilerServiceStatics.DefaultActionWithNameGetter(clientCompilerModel, (Guid uid) => assemblyNames[uid], clientEntityUsageAnalyzer, enumUsageAnalyzer, dataClassUsageAnalyzer);
		});
		List<EnumDependency> list2 = new List<EnumDependency>();
		List<EntityDependency> list3 = new List<EntityDependency>();
		List<DataClassDependency> list4 = new List<DataClassDependency>();
		foreach (KeyValuePair<IMetadata, ICollection<IPropertyMetadata>> referenceMetadatum in serverEntityUsageAnalyzer.CodeAnalyzerResult.CombineResult(clientEntityUsageAnalyzer.CodeAnalyzerResult).CombineResult(dataClassUsageAnalyzer.CodeAnalyzerResult).CombineResult(enumUsageAnalyzer.CodeAnalyzerResult)
			.ReferenceMetadata)
		{
			if (!(referenceMetadatum.Key is ICodeItemMetadata codeItemMetadata))
			{
				continue;
			}
			ICodeItemMetadata codeItemMetadata2 = codeItemMetadata;
			if (codeItemMetadata2 == null)
			{
				continue;
			}
			if (!(codeItemMetadata2 is EnumMetadata enumMetadata))
			{
				if (!(codeItemMetadata2 is EntityMetadata entityMetadata))
				{
					if (codeItemMetadata2 is DataClassMetadata dataClassMetadata)
					{
						DataClassMetadata metadata = dataClassMetadata;
						list4.Add(metadata.GetSignature(referenceMetadatum.Value));
					}
				}
				else
				{
					EntityMetadata metadata2 = entityMetadata;
					list3.Add(metadata2.GetSignature(referenceMetadatum.Value));
				}
			}
			else
			{
				EnumMetadata metadata3 = enumMetadata;
				list2.Add(metadata3.GetSignature());
			}
		}
		List<EnumDependency> collection = DependencyHelper.CombineDependencies(moduleMetadata.Dependency.EnumDependencies.Concat(list2)).ToList();
		moduleMetadata.Dependency.EnumDependencies.Clear();
		moduleMetadata.Dependency.EnumDependencies.AddRange(collection);
		List<EntityDependency> collection2 = DependencyHelper.CombineClassDependencies(moduleMetadata.Dependency.EntityDependencies.Concat(list3)).ToList();
		moduleMetadata.Dependency.EntityDependencies.Clear();
		moduleMetadata.Dependency.EntityDependencies.AddRange(collection2);
		List<DataClassDependency> collection3 = DependencyHelper.CombineClassDependencies(moduleMetadata.Dependency.DataClasses.Concat(list4)).ToList();
		moduleMetadata.Dependency.DataClasses.Clear();
		moduleMetadata.Dependency.DataClasses.AddRange(collection3);
		return new ModuleBuildResult
		{
			ServerBuildResult = new ServerBuildResult(assemblyBuilder.AssemblyRaw, assemblyBuilder.DebugRaw, assemblyBuilder.AssemblyName, assemblyBuilder.DocumentationRaw),
			ClientBuildResult = new ClientBuildResult(javaScriptCodeCompilerResult.AssemblyRaw, javaScriptCodeCompilerResult.JsAssemblyRaw, javaScriptCodeCompilerResult.MinJsAssemblyRaw, clientAssemblyName, assemblyBuilder.DocumentationRaw)
		};
	}

	public void AddClientReference(byte[] assemblyRaw)
	{
		clientCompilerModel.AddReference(assemblyRaw);
	}

	public void AddServerReference(Assembly assembly)
	{
		assemblyBuilder.AddReference(assembly);
	}

	private void AddServerReferences()
	{
		foreach (ScriptModule value in serverScripts.Values)
		{
			if (value != null)
			{
				AddServerReferences(value);
			}
		}
		foreach (byte[] item in from a in dependencyModuleList
			select a.ServerBuildResult?.AssemblyRaw into a
			where a != null
			select a)
		{
			assemblyBuilder.AddReference(item);
		}
	}

	private void AddClientReferences()
	{
		foreach (byte[] item in from a in dependencyModuleList
			select a.ClientBuildResult?.AssemblyRaw into a
			where a != null
			select a)
		{
			clientCompilerModel.AddReference(item);
		}
	}

	private void AddServerReferences(IScriptModule scriptModule)
	{
		Contract.NotNull(scriptModule, "scriptModule");
		if (scriptModule.References != null)
		{
			string[] array = scriptModule.References.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array.Length; i++)
			{
				string assemblyName = array[i].Trim();
				assemblyBuilder.AddReferenceByName(assemblyName);
			}
		}
	}

	private void AddDefaultServerReferences()
	{
		assemblyBuilder.AddDefaultReferences();
	}

	private void AddWebDesignerOnlyReferences()
	{
		if (designerModules.Contains(moduleMetadata.Uid))
		{
			Assembly assembly = ComponentManager.FindLoadedAssembly("AutoMapper", isFullName: false);
			if (assembly != null)
			{
				assemblyBuilder.AddReference(assembly);
			}
			Assembly assembly2 = ComponentManager.FindLoadedAssembly("Microsoft.CodeAnalysis", isFullName: false);
			if (assembly2 != null)
			{
				assemblyBuilder.AddReference(assembly2);
			}
			Assembly assembly3 = ComponentManager.FindLoadedAssembly("Microsoft.CodeAnalysis.CSharp", isFullName: false);
			if (assembly3 != null)
			{
				assemblyBuilder.AddReference(assembly3);
			}
			Assembly assembly4 = ComponentManager.FindLoadedAssembly("Microsoft.CodeAnalysis.Workspaces", isFullName: false);
			if (assembly4 != null)
			{
				assemblyBuilder.AddReference(assembly4);
			}
			Assembly assembly5 = ComponentManager.FindLoadedAssembly("System.Collections.Immutable", isFullName: false);
			if (assembly5 != null)
			{
				assemblyBuilder.AddReference(assembly5);
			}
		}
	}

	private MetadataSourcesProviderArgs GetSourcesProviderArgs(IMetadata metadata)
	{
		return new MetadataSourcesProviderArgs
		{
			Metadata = metadata,
			ScriptModule = GetValueOrDefault(serverScripts, metadata.Uid),
			ClientScriptModule = GetValueOrDefault(clientScripts, metadata.Uid),
			ViewScriptModule = GetValueOrDefault(viewScripts, metadata.Uid),
			TestScriptModule = GetValueOrDefault(testScripts, metadata.Uid),
			GenerationMode = GenerationMode.Publish
		};
	}

	private static TValue GetValueOrDefault<TKey, TValue>(IDictionary<TKey, TValue> dictionary, TKey key)
	{
		if (!dictionary.TryGetValue(key, out var value))
		{
			return default(TValue);
		}
		return value;
	}

	private string GetClientAssemblyInfo()
	{
		ICodeGenerator codeGenerator = new AssemblyInfoWebGenerator(clientAssemblyName);
		codeGenerator.Metadata = moduleMetadata;
		codeGenerator.GenerationParams.FileName = moduleMetadata.Name + ".cs";
		return Encoding.UTF8.GetString(codeGenerator.GenerateMainFile().Data);
	}

	private void GenerateServerAssemblyInfo()
	{
		assemblyBuilder.GenerateAssemblyInfo((string a) => a.Replace("{ASSEMBLY_VERSION}", version).Replace("{ASSEMBLY_FILE_VERSION}", version));
		Type typeFromHandle = typeof(MetadataItemUidAttribute);
		object[] array = new object[1];
		Guid guid = itemUid;
		array[0] = guid.ToString();
		ISyntaxNode syntaxNode = typeFromHandle.CreateAttribute(array);
		syntaxNode.Unpack<AttributeSyntax>().AssemblySpecifier = true;
		ISyntaxNode syntaxNode2 = typeof(AssemblyModuleAttribute).CreateAttribute(moduleMetadata.UidStr);
		syntaxNode2.Unpack<AttributeSyntax>().AssemblySpecifier = true;
		assemblyBuilder.AddSourceCode(syntaxNode.GenerateCSCodeString() + Environment.NewLine + syntaxNode2.GenerateCSCodeString());
	}

	~ModuleAssemblyBuilder()
	{
		Dispose();
	}

	public void Dispose()
	{
		if (!disposed)
		{
			assemblyBuilder?.Dispose();
			disposed = true;
			GC.SuppressFinalize(this);
		}
	}
}
