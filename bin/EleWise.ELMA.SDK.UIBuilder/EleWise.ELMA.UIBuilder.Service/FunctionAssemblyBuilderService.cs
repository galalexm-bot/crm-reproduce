using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.CodeAnalyzers;
using EleWise.ELMA.CodeAnalyzers.Model;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.CodeGeneration.Analyzers;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.UIBuilder.Services;

[Service]
internal sealed class FunctionAssemblyBuilderService : IFunctionAssemblyBuilderService
{
	private readonly IGlobalModulesReferenceService globalModulesReferenceService;

	public FunctionAssemblyBuilderService(IGlobalModulesReferenceService globalModulesReferenceService)
	{
		this.globalModulesReferenceService = globalModulesReferenceService;
	}

	public void Build(FunctionBuildAssemblyModel model)
	{
		FunctionMetadataItem item = model.Item;
		if (!(item.Metadata is FunctionMetadata functionMetadata))
		{
			return;
		}
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
		ScriptModule scriptModule = item.ScriptModule;
		modelAssemblyBuilder.AddSourceCode(scriptModule.SourceCode);
		modelAssemblyBuilder.GenerateAssemblyInfo((string q) => q.Replace("{ASSEMBLY_VERSION}", item.AssemblyVersion).Replace("{ASSEMBLY_FILE_VERSION}", item.AssemblyVersion));
		if (scriptModule.References != null)
		{
			string[] array = scriptModule.References.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			foreach (string text in array)
			{
				modelAssemblyBuilder.AddReferenceByName(text.Trim());
			}
		}
		if (scriptModule.GlobalScriptModules != null)
		{
			foreach (AssemblyReference globalScriptModule in scriptModule.GlobalScriptModules)
			{
				string text2 = globalModulesReferenceService.CreateGlobalModuleAssembly(globalScriptModule.Uid);
				if (text2 != null)
				{
					modelAssemblyBuilder.AddReference(text2);
				}
			}
		}
		List<string> list = new List<string>();
		if (scriptModule.WebReferences != null)
		{
			foreach (ScriptWebReference webReference in scriptModule.WebReferences)
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
		DataClassUsageAnalyzer dataClassUsageAnalyzer = new DataClassUsageAnalyzer();
		ServerEntityUsageAnalyzer serverEntityUsageAnalyzer = new ServerEntityUsageAnalyzer();
		EnumUsageAnalyzer enumUsageAnalyzer = new EnumUsageAnalyzer();
		modelAssemblyBuilder.AddAnalyzers((DiagnosticAnalyzer)dataClassUsageAnalyzer);
		modelAssemblyBuilder.AddAnalyzers(new ComponentsAnalyzer());
		modelAssemblyBuilder.AddAnalyzers((DiagnosticAnalyzer)serverEntityUsageAnalyzer);
		modelAssemblyBuilder.AddAnalyzers((DiagnosticAnalyzer)enumUsageAnalyzer);
		modelAssemblyBuilder.Build();
		List<EnumDependency> list2 = new List<EnumDependency>();
		List<EntityDependency> list3 = new List<EntityDependency>();
		List<DataClassDependency> list4 = new List<DataClassDependency>();
		foreach (KeyValuePair<IMetadata, ICollection<IPropertyMetadata>> referenceMetadatum in serverEntityUsageAnalyzer.CodeAnalyzerResult.CombineResult(dataClassUsageAnalyzer.CodeAnalyzerResult).CombineResult(enumUsageAnalyzer.CodeAnalyzerResult).ReferenceMetadata)
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
		functionMetadata.DataClassDependencies = DependencyHelper.CombineClassDependencies(functionMetadata.DataClassDependencies.Concat(list4)).ToList();
		functionMetadata.EntityDependencies = DependencyHelper.CombineClassDependencies(functionMetadata.EntityDependencies.Concat(list3)).ToList();
		functionMetadata.EnumDependencies = DependencyHelper.CombineDependencies(functionMetadata.EnumDependencies.Concat(list2)).ToList();
		item.AssemblyRaw = modelAssemblyBuilder.AssemblyRaw;
		item.DocumentationRaw = modelAssemblyBuilder.DocumentationRaw;
		item.DebugRaw = modelAssemblyBuilder.DebugRaw;
	}
}
