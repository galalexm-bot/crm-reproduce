using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.OmniSharp;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;
using EleWise.ELMA.UIBuilder.Components;
using EleWise.ELMA.UIBuilder.OmniSharp;
using EleWise.ELMA.UIBuilder.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scripts;
using EleWise.ELMA.Workflow.UIBuilder.CodeGeneration;

namespace EleWise.ELMA.Workflow.UIBuilder.Components;

[Component(Order = -50)]
internal sealed class ClientWorkflowCodeEditorExtension : AbstractClientCodeEditorExtension
{
	private readonly WorkflowProcessManager workflowProcessManager;

	private readonly IUITypeGenerationFacade uiTypeGenerationFacade;

	public ClientWorkflowCodeEditorExtension(WorkflowProcessManager workflowProcessManager, IUITypeGenerationFacade uiTypeGenerationFacade)
	{
		this.workflowProcessManager = workflowProcessManager;
		this.uiTypeGenerationFacade = uiTypeGenerationFacade;
	}

	public override bool Check(InitWorkspaceRequest request)
	{
		if (request != null && request.CodeType == CodeType)
		{
			return request.Metadata is ProcessContext;
		}
		return false;
	}

	public override IScriptData GenerateSource(InitWorkspaceRequest request)
	{
		if (!(request?.Metadata is ProcessContext processContext))
		{
			return null;
		}
		ScriptModule scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, ClientScriptModuleType.TypeUid);
		List<EntityMetadata> list = new List<EntityMetadata>();
		list.Add(processContext);
		if (request is WorkflowInitWorkspaceRequest workflowInitWorkspaceRequest && workflowInitWorkspaceRequest.ProcessUid != Guid.Empty)
		{
			IWorkflowProcess workflowProcess = workflowProcessManager.Load(workflowInitWorkspaceRequest.ProcessUid);
			while (workflowProcess.Parent != null)
			{
				ProcessContext context = workflowProcess.Parent.Context;
				ProcessContext processContext2 = ClassSerializationHelper.CloneObjectByXml(context);
				processContext2.Properties.AddRange((IEnumerable<PropertyMetadata>)context.EntityProperties);
				processContext2.TableParts.AddRange((IEnumerable<TablePartMetadata>)context.EntityTableParts);
				list.Add(processContext2);
				workflowProcess = workflowProcess.Parent;
			}
		}
		using (MetadataServiceContext.Extend(list))
		{
			ScriptModule serverScriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, ProcessScriptModuleType.UID);
			IList<IScriptSource> list2 = GenerateSources(processContext, scriptModule, serverScriptModule);
			IList<IScriptReference> assemblies = GetAssemblies();
			WorkspaceProjectHelper projectHelper = new WorkspaceProjectHelper(scriptModule);
			list2.Add(GenerateProjectFile(projectHelper, list2, assemblies));
			return new ScriptData(list2, assemblies);
		}
	}

	protected override ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request)
	{
		if (!(request?.Metadata is ProcessContext processContext))
		{
			return null;
		}
		ScriptModule scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, ClientScriptModuleType.TypeUid);
		ProcessContext processContext2 = ClassSerializationHelper.CloneObjectByXml(processContext);
		processContext2.Properties.AddRange((IEnumerable<PropertyMetadata>)processContext.EntityProperties);
		processContext2.TableParts.AddRange((IEnumerable<TablePartMetadata>)processContext.EntityTableParts);
		request.Metadata = processContext2;
		WorkspaceProjectHelper workspaceProjectHelper = new WorkspaceProjectHelper(scriptModule);
		return new CodeEditorInitData
		{
			FileName = GetControllerFileName(processContext),
			ClassName = GetClassName(processContext),
			MethodName = request.MethodName,
			SourceCode = scriptModule.SourceCode,
			ProjectName = workspaceProjectHelper.CsprojFileName
		};
	}

	private IList<IScriptSource> GenerateSources(ProcessContext metadata, ScriptModule scriptModule, ScriptModule serverScriptModule)
	{
		ProcessContextClientScriptGenerator obj = new ProcessContextClientScriptGenerator(serverScriptModule, Enumerable.Empty<FormViewItem>(), MetadataServiceContext.Service, uiTypeGenerationFacade)
		{
			Metadata = metadata,
			GenerationParams = 
			{
				Mode = GenerationMode.CodeEditor
			}
		};
		List<IScriptSource> list = new List<IScriptSource>
		{
			new ScriptSource(GetControllerFileName(metadata), scriptModule.SourceCode, ScriptSourceType.Edit)
		};
		GeneratedFileInfo[] array = ((ICodeGenerator)obj).Generate();
		foreach (GeneratedFileInfo generatedFileInfo in array)
		{
			if (generatedFileInfo.Type == GeneratedFileType.CS)
			{
				string text = generatedFileInfo.Extension;
				if (text.EndsWith(".cs"))
				{
					text = text.Substring(0, text.Length - ".cs".Length);
				}
				list.Add(new ScriptSource(metadata.Name + text, Encoding.UTF8.GetString(generatedFileInfo.Data), ScriptSourceType.Additional));
			}
		}
		return list;
	}

	private IScriptSource GenerateProjectFile(WorkspaceProjectHelper projectHelper, IEnumerable<IScriptSource> sources, IEnumerable<IScriptReference> references)
	{
		string content = AbstractCodeEditorExtension.GenerateTemplate<IResourcesMarker>("BridgeScriptProject.csproj", (string s) => s.Replace("{PROJECT_GUID}", projectHelper.ProjectGuid).Replace("{ASSEMBLY_NAME}", projectHelper.ProjectAssemblyName).Replace("{REFERENCES}", GenerateReferencesSection(references))
			.Replace("{BRIDGE_IMPORT_TARGETS}", string.Empty)
			.Replace("{SOURCES}", AbstractCodeEditorExtension.GenerateSourcesSection(sources)));
		return projectHelper.CreateCsprojSource(content);
	}

	private static string GetControllerFileName(ClassMetadata metadata)
	{
		return metadata.Name + "_Scripts.Controller";
	}

	private static string GetClassName(ProcessContext context)
	{
		return string.Join("_", context.Name, "Scripts");
	}
}
