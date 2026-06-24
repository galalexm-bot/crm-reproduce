using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.OmniSharp;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Scripts;
using EleWise.ELMA.UIBuilder.Services;

namespace EleWise.ELMA.UIBuilder.OmniSharp;

internal sealed class TestComponentCodeEditorExtension : AbstractComponentCodeEditorExtension
{
	protected override Guid ModuleTypeUid => TestScriptModuleType.TypeUid;

	protected override CodeType CodeType => CodeType.Test;

	public override IScriptData GenerateSource(InitWorkspaceRequest request)
	{
		if (!(request?.Metadata is ComponentMetadata obj))
		{
			return null;
		}
		ScriptModule scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, ModuleTypeUid);
		MetadataSourcesProviderArgs metadataSourcesProviderArgs = new MetadataSourcesProviderArgs();
		metadataSourcesProviderArgs.Metadata = ClassSerializationHelper.CloneObjectByXml(obj);
		metadataSourcesProviderArgs.ScriptModule = AbstractCodeEditorExtension.FindScriptModule(request.ScriptModules, ComponentScriptModuleType.TypeUid);
		metadataSourcesProviderArgs.ClientScriptModule = AbstractCodeEditorExtension.FindScriptModule(request.ScriptModules, ComponentClientScriptModuleType.TypeUid);
		metadataSourcesProviderArgs.TestScriptModule = scriptModule;
		metadataSourcesProviderArgs.GenerationMode = GenerationMode.CodeEditor;
		MetadataSourcesProviderArgs args = metadataSourcesProviderArgs;
		IList<IScriptSource> list = GenerateSources(args);
		IList<IScriptReference> assemblies = GetAssemblies();
		WorkspaceProjectHelper projectHelper = new WorkspaceProjectHelper(scriptModule);
		list.Add(GenerateProjectFile(projectHelper, list, assemblies));
		return new ScriptData(list, assemblies);
	}

	private IList<IScriptSource> GenerateSources(MetadataSourcesProviderArgs args)
	{
		using (MetadataServiceContext.Extend(GetExtendMetadata((ComponentMetadata)args.Metadata)))
		{
			return base.ComponentMetadataSourcesService.GetTestSources(args).Concat(base.ComponentMetadataSourcesService.GetClientSources(args)).ToList();
		}
	}

	private IScriptSource GenerateProjectFile(WorkspaceProjectHelper projectHelper, IEnumerable<IScriptSource> sources, IEnumerable<IScriptReference> references)
	{
		string content = AbstractCodeEditorExtension.GenerateTemplate<ScriptService>("BridgeScriptProject.csproj", (string s) => s.Replace("{PROJECT_GUID}", projectHelper.ProjectGuid).Replace("{ASSEMBLY_NAME}", projectHelper.ProjectAssemblyName).Replace("{REFERENCES}", GenerateReferencesSection(references))
			.Replace("{BRIDGE_IMPORT_TARGETS}", string.Empty)
			.Replace("{SOURCES}", AbstractCodeEditorExtension.GenerateSourcesSection(sources)));
		return projectHelper.CreateCsprojSource(content);
	}
}
