using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.CodeAnalyzers;
using EleWise.ELMA.CodeAnalyzers.Model;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.CodeGeneration.Analyzers;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.UIBuilder.Analyzers;
using EleWise.ELMA.UIBuilder.CodeAnalyzers;
using EleWise.ELMA.UIBuilder.CodeGeneration;
using EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;
using EleWise.ELMA.UIBuilder.Services;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.UIBuilder.CodeAnalyzers;
using EleWise.ELMA.Workflow.UIBuilder.CodeGeneration;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.Workflow.UIBuilder.Components;

[Component]
internal sealed class WorkflowClientScriptModuleExtension : IWorkflowClientScriptModuleExtensions
{
	private readonly IJavaScriptCompilerService javaScriptCompilerService;

	private readonly IUITypeGenerationFacade uiTypeGenerationFacade;

	private readonly ISearchMetadataService searchMetadataService;

	private readonly DbPreUpdater dbPreUpdater;

	public WorkflowClientScriptModuleExtension(IJavaScriptCompilerService javaScriptCompilerService, IRuntimeApplication runtimeApplication, IUITypeGenerationFacade uiTypeGenerationFacade, ISearchMetadataService searchMetadataService)
	{
		this.javaScriptCompilerService = javaScriptCompilerService;
		this.uiTypeGenerationFacade = uiTypeGenerationFacade;
		this.searchMetadataService = searchMetadataService;
		dbPreUpdater = runtimeApplication.DbPreUpdater;
	}

	public void BuildClientProcessContextScript(IWorkflowProcess process)
	{
		Contract.ArgumentNotNull(process, "process");
		if (process.ScriptModule == null)
		{
			return;
		}
		if (process.ClientScriptModule.Uid == Guid.Empty)
		{
			process.ClientScriptModule.Uid = Guid.NewGuid();
		}
		List<ProcessContext> list = new List<ProcessContext>();
		IWorkflowProcess workflowProcess = process;
		do
		{
			if (workflowProcess.Header?.Current?.Context != null)
			{
				list.Add(workflowProcess.Header.Current.Context);
			}
			if (workflowProcess.Context != null)
			{
				list.Add(workflowProcess.Context);
			}
			workflowProcess = workflowProcess.Parent;
		}
		while (workflowProcess != null);
		using (MetadataServiceContext.Extend(list))
		{
			List<FormViewItem> forms = process.Forms.Items.Select((WorkflowForm form) => form.CreateFormViewItem(process)).ToList();
			JavaScriptCodeCompilerResult javaScriptCodeCompilerResult = BuildClientEntityScript(list, process.Context, process.VersionNumber.ToString(), process.ClientScriptModule.SourceCode, process.ScriptModule, process.ClientScriptModule, forms);
			process.ClientScriptModule.AssemblyName = process.Context.Name;
			process.ClientScriptModule.AssemblyRaw = javaScriptCodeCompilerResult.MinJsAssemblyRaw;
			process.ClientScriptModule.DebugRaw = javaScriptCodeCompilerResult.JsAssemblyRaw;
		}
		process.ClientScriptModule.Save();
	}

	private JavaScriptCodeCompilerResult BuildClientEntityScript(IEnumerable<ProcessContext> contexts, ProcessContext context, string versionNumber, string sourceCode, ScriptModule scriptModule, ScriptModule clientScriptModule, IEnumerable<FormViewItem> forms)
	{
		string name = context.Name;
		IJavaScriptCompilerModel model = javaScriptCompilerService.CreateCompilerModel(name, scriptApiCheck: true, versionNumber);
		model.AddSourceCode(sourceCode);
		model.AddSourceCode(GenerateAssemblyInfo(context));
		GeneratedFileInfo[] array = ((ICodeGenerator)new ProcessContextClientScriptGenerator(scriptModule, forms, MetadataServiceContext.Service, uiTypeGenerationFacade)
		{
			Metadata = context
		}).Generate();
		foreach (GeneratedFileInfo generatedFileInfo in array)
		{
			model.AddSourceCode(Encoding.UTF8.GetString(generatedFileInfo.Data));
		}
		foreach (AssemblyModelsMetadata assemblyModel in dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.PublishedDisabled, "ConfigurationUIModel", "DynamicUIModel", "ExternalUIModel"))
		{
			if (assemblyModel?.AssemblyRawStream != null)
			{
				model.AddReference(assemblyModel.AssemblyRawStream.ToArray());
			}
		}
		foreach (DataClassAssemblyInfo item in searchMetadataService.GetPublishedDataClassAssemblies().ToList())
		{
			model.AddReference(item.ClientAssemblyRaw);
		}
		ClientEntityUsageAnalyzer entityUsageAnalyzer = new ClientEntityUsageAnalyzer();
		ProcessContextUsageAnalyzer processContextUsageAnalyzer = new ProcessContextUsageAnalyzer(contexts, name);
		EnumUsageAnalyzer enumUsageAnalyzer = new EnumUsageAnalyzer();
		DataClassUsageAnalyzer dataClassUsageAnalyzer = new DataClassUsageAnalyzer();
		model.AddAnalyzers((DiagnosticAnalyzer)entityUsageAnalyzer, (DiagnosticAnalyzer)processContextUsageAnalyzer, (DiagnosticAnalyzer)enumUsageAnalyzer, (DiagnosticAnalyzer)dataClassUsageAnalyzer, new UIComponentsAnalyzer(), new ComponentControllerPublicClassesAnalyzer(), new AsynchronousCodeAnalyzer());
		FillReplaceViewModelMetadata(model.ReplaceModelMetadata, context, model.ProjectName, context.Name);
		JavaScriptCodeCompilerResult result = javaScriptCompilerService.Compile(model, withoutJsOutput: false, delegate
		{
			BridgeCompilerServiceStatics.DefaultAction(model, entityUsageAnalyzer, enumUsageAnalyzer, dataClassUsageAnalyzer);
		});
		List<EnumDependency> list = new List<EnumDependency>();
		List<EntityDependency> list2 = new List<EntityDependency>();
		List<DataClassDependency> list3 = new List<DataClassDependency>();
		foreach (KeyValuePair<IMetadata, ICollection<IPropertyMetadata>> referenceMetadatum in entityUsageAnalyzer.CodeAnalyzerResult.CombineResult(processContextUsageAnalyzer.CodeAnalyzerResult).CombineResult(dataClassUsageAnalyzer.CodeAnalyzerResult).CombineResult(enumUsageAnalyzer.CodeAnalyzerResult)
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
						list3.Add(metadata.GetSignature(referenceMetadatum.Value));
					}
				}
				else
				{
					EntityMetadata metadata2 = entityMetadata;
					list2.Add(metadata2.GetSignature(referenceMetadatum.Value));
				}
			}
			else
			{
				EnumMetadata metadata3 = enumMetadata;
				list.Add(metadata3.GetSignature());
			}
		}
		ScriptModuleDependencyContainer scriptModuleDependencyContainer = new ScriptModuleDependencyContainer();
		scriptModuleDependencyContainer.EnumDependencies.AddRange(list);
		scriptModuleDependencyContainer.EntityDependencies.AddRange(list2);
		scriptModuleDependencyContainer.DataClassDependencies.AddRange(list3);
		clientScriptModule.Dependencies = scriptModuleDependencyContainer;
		return result;
	}

	private void FillReplaceViewModelMetadata(IList<IReplaceModelMetadata> listReplace, EntityMetadata targetMetadata, string moduleName, string metadataRootName)
	{
		if (targetMetadata != null)
		{
			if (targetMetadata.ViewModelMetadata != null)
			{
				listReplace.Add(new ReplaceModelMetadata(targetMetadata.ViewModelMetadata, moduleName, targetMetadata.Namespace + "." + metadataRootName + "_Scripts." + targetMetadata.Name + targetMetadata.ViewModelMetadata.Name));
				AddTablePartsReplaceModelMetadata(listReplace, targetMetadata.TableParts, moduleName, metadataRootName, targetMetadata.Namespace);
			}
			Guid baseClassUid = targetMetadata.BaseClassUid;
			if (!(baseClassUid == Guid.Empty))
			{
				EntityMetadata targetMetadata2 = (EntityMetadata)MetadataServiceContext.Service.GetMetadata(baseClassUid, loadImplementation: false);
				FillReplaceViewModelMetadata(listReplace, targetMetadata2, moduleName, metadataRootName);
			}
		}
	}

	private void AddTablePartsReplaceModelMetadata(IList<IReplaceModelMetadata> listReplace, IEnumerable<TablePartMetadata> tableParts, string moduleName, string metadataRootName, string targetMetadataNamespace)
	{
		if (tableParts == null || tableParts.Count() == 0)
		{
			return;
		}
		foreach (TablePartMetadata tablePart in tableParts)
		{
			listReplace.Add(new ReplaceModelMetadata(tablePart, moduleName, targetMetadataNamespace + "." + metadataRootName + "_Scripts." + tablePart.Name));
			AddTablePartsReplaceModelMetadata(listReplace, tablePart.TableParts, moduleName, metadataRootName, targetMetadataNamespace);
		}
	}

	private static string GenerateAssemblyInfo(ClassMetadata metadata)
	{
		ICodeGenerator codeGenerator = new AssemblyInfoWebGenerator();
		codeGenerator.Metadata = metadata;
		codeGenerator.GenerationParams.FileName = metadata.Name + ".cs";
		codeGenerator.GenerationParams.Namespace = metadata.Namespace;
		return Encoding.UTF8.GetString(codeGenerator.GenerateMainFile().Data);
	}
}
