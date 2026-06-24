using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using EleWise.ELMA.CodeAnalyzers;
using EleWise.ELMA.CodeAnalyzers.Model;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.CodeGeneration.Analyzers;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UIBuilder.Analyzers;
using EleWise.ELMA.UIBuilder.CodeAnalyzers;
using EleWise.ELMA.UIBuilder.CodeGeneration;
using EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.UIBuilder.Services;

[Service]
internal sealed class ComponentAssemblyBuilderService : IComponentAssemblyBuilderService
{
	private readonly IJavaScriptCompilerService javaScriptCompilerService;

	private readonly IComponentMetadataSourcesService componentMetadataSourcesService;

	private readonly DbPreUpdater dbPreUpdater;

	private readonly IGlobalModulesReferenceService globalModulesReferenceService;

	public ComponentAssemblyBuilderService(IJavaScriptCompilerService javaScriptCompilerService, IComponentMetadataSourcesService componentMetadataSourcesService, IRuntimeApplication runtimeApplication, IGlobalModulesReferenceService globalModulesReferenceService)
	{
		this.javaScriptCompilerService = javaScriptCompilerService;
		this.componentMetadataSourcesService = componentMetadataSourcesService;
		dbPreUpdater = runtimeApplication.DbPreUpdater;
		this.globalModulesReferenceService = globalModulesReferenceService;
	}

	public void Build(ComponentBuildAssemblyModel model)
	{
		ComponentMetadataItem item = model.Item;
		if (!(item.Metadata is ComponentMetadata componentMetadata))
		{
			return;
		}
		MetadataSourcesProviderArgs args = new MetadataSourcesProviderArgs
		{
			Metadata = componentMetadata,
			ScriptModule = item.ScriptModule,
			ClientScriptModule = item.ClientScriptModule,
			ViewScriptModule = item.ViewScriptModule,
			TestScriptModule = item.TestScriptModule,
			GenerationMode = GenerationMode.Publish
		};
		DataClassUsageAnalyzer dataClassUsageAnalyzer = new DataClassUsageAnalyzer();
		ServerEntityUsageAnalyzer serverEntityUsageAnalyzer = new ServerEntityUsageAnalyzer();
		EnumUsageAnalyzer enumUsageAnalyzer = new EnumUsageAnalyzer();
		if (item.ScriptModule != null)
		{
			using ModelAssemblyBuilder modelAssemblyBuilder = new ModelAssemblyBuilder(item.AssemblyName);
			modelAssemblyBuilder.AddDefaultReferences();
			modelAssemblyBuilder.AddAllElmaReferences();
			Assembly assembly = ComponentManager.FindLoadedAssembly("EleWise.ELMA.ConfigurationModel", isFullName: false);
			if (assembly != null)
			{
				modelAssemblyBuilder.AddReference(ComponentManager.GetLoadedAssemblyRawAsStream(assembly));
			}
			assembly = ComponentManager.FindLoadedAssembly("EleWise.ELMA.DynamicModel", isFullName: false);
			if (assembly != null)
			{
				modelAssemblyBuilder.AddReference(ComponentManager.GetLoadedAssemblyRawAsStream(assembly));
			}
			foreach (byte[] assembly2 in model.Assemblies)
			{
				modelAssemblyBuilder.AddReference(assembly2);
			}
			foreach (IScriptSource serverSource in componentMetadataSourcesService.GetServerSources(args))
			{
				modelAssemblyBuilder.AddSourceCode(serverSource.Content);
			}
			modelAssemblyBuilder.GenerateAssemblyInfo((string q) => q.Replace("{ASSEMBLY_VERSION}", item.AssemblyVersion).Replace("{ASSEMBLY_FILE_VERSION}", item.AssemblyVersion));
			ISyntaxNode syntaxNode = typeof(MetadataItemUidAttribute).CreateAttribute(item.Uid.ToString());
			syntaxNode.Unpack<AttributeSyntax>().AssemblySpecifier = true;
			byte[] bytes = syntaxNode.GenerateCSCode();
			modelAssemblyBuilder.AddSourceCode(Encoding.UTF8.GetString(bytes));
			if (item.ScriptModule.References != null)
			{
				string[] array = item.ScriptModule.References.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				foreach (string text in array)
				{
					modelAssemblyBuilder.AddReferenceByName(text.Trim());
				}
			}
			if (item.ScriptModule.GlobalScriptModules != null)
			{
				foreach (AssemblyReference globalScriptModule in item.ScriptModule.GlobalScriptModules)
				{
					string text2 = globalModulesReferenceService.CreateGlobalModuleAssembly(globalScriptModule.Uid);
					if (text2 != null)
					{
						modelAssemblyBuilder.AddReference(text2);
					}
				}
			}
			List<string> list = new List<string>();
			if (item.ScriptModule.WebReferences != null)
			{
				foreach (ScriptWebReference webReference in item.ScriptModule.WebReferences)
				{
					if (list.Contains(webReference.Name))
					{
						continue;
					}
					list.Add(webReference.Name);
					foreach (ScriptProjectItem item2 in webReference.Items)
					{
						if (!string.IsNullOrEmpty(item2.FileContent) && item2.ItemType != null && item2.ItemType.Equals("COMPILE", StringComparison.CurrentCultureIgnoreCase))
						{
							modelAssemblyBuilder.AddSourceCode(item2.FileContent);
						}
					}
				}
			}
			modelAssemblyBuilder.AddAnalyzers(new ComponentsAnalyzer(), (DiagnosticAnalyzer)dataClassUsageAnalyzer, (DiagnosticAnalyzer)serverEntityUsageAnalyzer, (DiagnosticAnalyzer)enumUsageAnalyzer);
			modelAssemblyBuilder.Build();
			item.ScriptModule.AssemblyRaw = modelAssemblyBuilder.AssemblyRaw;
			item.ScriptModule.DebugRaw = modelAssemblyBuilder.DebugRaw;
		}
		string text3 = ComponentMetadataHelper.ClientAssemblyName(componentMetadata, item.AssemblyVersion);
		IJavaScriptCompilerModel bridgeCompilerModel = javaScriptCompilerService.CreateCompilerModel(text3, !model.IsSystem, string.Empty);
		foreach (AssemblyModelsMetadata assemblyModel in dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.PublishedDisabled, "ConfigurationUIModel", "DynamicUIModel", "ExternalUIModel"))
		{
			if (assemblyModel?.AssemblyRawStream != null)
			{
				bridgeCompilerModel.AddReference(assemblyModel.AssemblyRawStream.ToArray());
			}
		}
		foreach (byte[] clientAssembly in model.ClientAssemblies)
		{
			bridgeCompilerModel.AddReference(clientAssembly);
		}
		foreach (IScriptSource clientSource in componentMetadataSourcesService.GetClientSources(args))
		{
			bridgeCompilerModel.AddSourceCode(clientSource.Name, clientSource.Content);
		}
		if (item.IsEmulation)
		{
			foreach (IScriptSource testSource in componentMetadataSourcesService.GetTestSources(args))
			{
				bridgeCompilerModel.AddSourceCode(testSource.Name, testSource.Content);
			}
		}
		string name = componentMetadata.Name;
		ICodeGenerator codeGenerator = new AssemblyInfoWebGenerator(text3);
		codeGenerator.Metadata = componentMetadata;
		codeGenerator.GenerationParams.FileName = name + ".cs";
		codeGenerator.GenerationParams.Namespace = componentMetadata.Namespace;
		bridgeCompilerModel.AddSourceCode(name + "_AssemblyInfo", Encoding.UTF8.GetString(codeGenerator.GenerateMainFile().Data));
		foreach (DataClassMetadata dataClass in componentMetadata.DataClasses)
		{
			bridgeCompilerModel.ReplaceModelMetadata.Add(new ReplaceModelMetadata(componentMetadata, dataClass, text3));
		}
		ClientEntityUsageAnalyzer clientEntityUsageAnalyzer = new ClientEntityUsageAnalyzer();
		bridgeCompilerModel.AddAnalyzers((DiagnosticAnalyzer)clientEntityUsageAnalyzer, (DiagnosticAnalyzer)enumUsageAnalyzer, (DiagnosticAnalyzer)dataClassUsageAnalyzer, new UIComponentsAnalyzer(), new ComponentControllerPublicClassesAnalyzer(), new AsynchronousCodeAnalyzer());
		JavaScriptCodeCompilerResult javaScriptCodeCompilerResult = javaScriptCompilerService.Compile(bridgeCompilerModel, withoutJsOutput: false, delegate
		{
			BridgeCompilerServiceStatics.DefaultAction(bridgeCompilerModel, clientEntityUsageAnalyzer, enumUsageAnalyzer, dataClassUsageAnalyzer);
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
						DataClassMetadata dataClassMetadata2 = dataClassMetadata;
						if (!componentMetadata.DataClasses.Contains(dataClassMetadata2))
						{
							list4.Add(dataClassMetadata2.GetSignature(referenceMetadatum.Value));
						}
					}
				}
				else
				{
					EntityMetadata metadata = entityMetadata;
					list3.Add(metadata.GetSignature(referenceMetadatum.Value));
				}
			}
			else
			{
				EnumMetadata metadata2 = enumMetadata;
				list2.Add(metadata2.GetSignature());
			}
		}
		componentMetadata.EnumDependencies = DependencyHelper.CombineDependencies(componentMetadata.EnumDependencies.Concat(list2)).ToList();
		componentMetadata.EntityDependencies = DependencyHelper.CombineClassDependencies(componentMetadata.EntityDependencies.Concat(list3)).ToList();
		componentMetadata.DataClassDependencies = DependencyHelper.CombineClassDependencies(componentMetadata.DataClassDependencies.Concat(list4)).ToList();
		byte[] minJsAssemblyRaw = javaScriptCodeCompilerResult.MinJsAssemblyRaw;
		byte[] jsAssemblyRaw = javaScriptCodeCompilerResult.JsAssemblyRaw;
		item.ClientScriptModule.AssemblyName = text3;
		item.ClientScriptModule.AssemblyRaw = minJsAssemblyRaw;
		item.ClientScriptModule.DebugRaw = jsAssemblyRaw;
	}
}
