using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.OmniSharp;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UIBuilder.CodeGeneration;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;
using EleWise.ELMA.UIBuilder.Components;
using EleWise.ELMA.UIBuilder.Services;

namespace EleWise.ELMA.UIBuilder.OmniSharp;

[Component]
internal sealed class ClientEntityCodeEditorExtension : AbstractClientCodeEditorExtension
{
	private readonly IUITypeGenerationFacade uiTypeGenerationFacade;

	private readonly IMetadataSourceCodeCache metadataSourceCodeCache;

	public ClientEntityCodeEditorExtension(IUITypeGenerationFacade uiTypeGenerationFacade, IMetadataSourceCodeCache metadataSourceCodeCache)
	{
		this.uiTypeGenerationFacade = uiTypeGenerationFacade;
		this.metadataSourceCodeCache = metadataSourceCodeCache;
	}

	public override bool Check(InitWorkspaceRequest request)
	{
		if (request != null && request.CodeType == CodeType.Client)
		{
			return request.Metadata is EntityMetadata;
		}
		return false;
	}

	public override IScriptData GenerateSource(InitWorkspaceRequest request)
	{
		if (!(request?.Metadata is EntityMetadata entityMetadata))
		{
			return null;
		}
		ScriptModule scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, ClientScriptModuleType.TypeUid);
		EntityMetadata entityMetadata2 = entityMetadata.CreateInterfaceImplementationMetadata();
		using (new MetadataServiceContext(new ExtendedMetadataService(base.MetadataRuntimeService, new EntityMetadata[2] { entityMetadata2, entityMetadata })))
		{
			ScriptModule serverScriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, EntityScriptModuleType.UID);
			IList<IScriptSource> list = GenerateSources(entityMetadata2, scriptModule, serverScriptModule);
			IList<IScriptReference> assemblies = GetAssemblies();
			WorkspaceProjectHelper projectHelper = new WorkspaceProjectHelper(scriptModule);
			list.Add(GenerateProjectFile(projectHelper, list, assemblies));
			return new ScriptData(list, assemblies);
		}
	}

	protected override ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request)
	{
		if (!(request?.Metadata is EntityMetadata metadata))
		{
			return null;
		}
		ScriptModule scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, ClientScriptModuleType.TypeUid);
		WorkspaceProjectHelper workspaceProjectHelper = new WorkspaceProjectHelper(scriptModule);
		return new CodeEditorInitData
		{
			FileName = GetControllerFileName(metadata),
			ClassName = GetClassName(metadata),
			MethodName = request.MethodName,
			SourceCode = scriptModule.SourceCode,
			ProjectName = workspaceProjectHelper.CsprojFileName
		};
	}

	protected override List<IScriptReference> GetDynamicAssemblies()
	{
		DbPreUpdater dbPreUpdater = base.RuntimeApplication?.DbPreUpdater;
		if (dbPreUpdater == null)
		{
			return new List<IScriptReference>();
		}
		return dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.PublishedDisabled, "ExternalUIModel").Select(AbstractCodeEditorExtension.CreateScriptReference).ToList();
	}

	private IList<IScriptSource> GenerateSources(ClassMetadata metadata, ScriptModule scriptModule, ScriptModule serverScriptModule)
	{
		List<IScriptSource> list = new List<IScriptSource>
		{
			new ScriptSource(GetControllerFileName(metadata), scriptModule.SourceCode, ScriptSourceType.Edit)
		};
		GeneratedFileInfo[] array = ((ICodeGenerator)new EntityClientScriptGenerator(serverScriptModule, null, uiTypeGenerationFacade)
		{
			Metadata = metadata,
			GenerationParams = 
			{
				Mode = GenerationMode.CodeEditor
			}
		}).Generate();
		foreach (GeneratedFileInfo generatedFileInfo in array)
		{
			if (generatedFileInfo.Type == GeneratedFileType.CS)
			{
				list.Add(new ScriptSource(metadata.Name + generatedFileInfo.Extension, Encoding.UTF8.GetString(generatedFileInfo.Data), ScriptSourceType.Additional));
			}
		}
		return list;
	}

	private IScriptSource GenerateProjectFile(WorkspaceProjectHelper projectHelper, IEnumerable<IScriptSource> sources, IEnumerable<IScriptReference> references)
	{
		string content = AbstractCodeEditorExtension.GenerateTemplate<ScriptService>("BridgeScriptProject.csproj", (string s) => s.Replace("{PROJECT_GUID}", projectHelper.ProjectGuid).Replace("{ASSEMBLY_NAME}", projectHelper.ProjectAssemblyName).Replace("{REFERENCES}", GenerateReferencesSection(references))
			.Replace("{BRIDGE_IMPORT_TARGETS}", string.Empty)
			.Replace("{SOURCES}", GenerateEntitySourcesSection(sources)));
		return projectHelper.CreateCsprojSource(content);
	}

	private string GenerateEntitySourcesSection(IEnumerable<IScriptSource> sources)
	{
		List<IScriptSource> sources2 = sources.ToList();
		string text = AbstractCodeEditorExtension.GenerateSourcesSection(sources2);
		string text2 = GenerateCacheSourceSection(sources2);
		return string.Join(Environment.NewLine, text, text2);
	}

	private string GenerateCacheSourceSection(List<IScriptSource> sources)
	{
		metadataSourceCodeCache.UpdateDiskCache();
		string cacheFolder = metadataSourceCodeCache.GetFolderPath(CodeType);
		string[] files = Directory.GetFiles(cacheFolder);
		if (files.Length == 0)
		{
			return string.Empty;
		}
		List<string> list = sources.Select((IScriptSource source) => Path.Combine(cacheFolder, source.Name + ".cs")).ToList();
		StringBuilder stringBuilder = new StringBuilder();
		string[] array = files;
		foreach (string text in array)
		{
			if (!list.Contains(text))
			{
				stringBuilder.Append($"<Compile Include=\"{text}\" />");
				stringBuilder.AppendLine();
			}
		}
		return stringBuilder.ToString();
	}

	private static string GetControllerFileName(ClassMetadata metadata)
	{
		return string.Join(".", metadata.Name, "Controller");
	}

	private static string GetClassName(ClassMetadata metadata)
	{
		return metadata.Name + "Scripts";
	}
}
