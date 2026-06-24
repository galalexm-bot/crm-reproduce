using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.OmniSharp;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.UIBuilder.OmniSharp;

[Component]
internal sealed class FunctionCodeEditorExtension : AbstractCodeEditorExtension
{
	protected override CodeType CodeType => CodeType.Server;

	public override bool Check(InitWorkspaceRequest request)
	{
		if (request != null && request.CodeType == CodeType)
		{
			return request.Metadata is FunctionMetadata;
		}
		return false;
	}

	public override IScriptData GenerateSource(InitWorkspaceRequest request)
	{
		if (!(request?.Metadata is FunctionMetadata functionMetadata))
		{
			return null;
		}
		ScriptModule scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, FunctionScriptModuleType.UID);
		List<IScriptSource> list = new List<IScriptSource>
		{
			new ScriptSource(functionMetadata.Name, scriptModule.SourceCode, ScriptSourceType.Edit)
		};
		list.AddRange(GenerateWebReferencesSources(scriptModule));
		IList<IScriptReference> assemblies = GetAssemblies(scriptModule);
		WorkspaceProjectHelper projectHelper = new WorkspaceProjectHelper(scriptModule);
		list.Add(GenerateProjectFile(projectHelper, list, assemblies));
		return new ScriptData(list, assemblies);
	}

	protected override ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request)
	{
		if (!(request?.Metadata is FunctionMetadata functionMetadata))
		{
			return null;
		}
		ScriptModule scriptModule = AbstractCodeEditorExtension.FindScriptModuleRequired(request.ScriptModules, FunctionScriptModuleType.UID);
		WorkspaceProjectHelper workspaceProjectHelper = new WorkspaceProjectHelper(scriptModule);
		return new CodeEditorInitData
		{
			FileName = functionMetadata.Name,
			ClassName = FunctionMetadataHelper.ExecutorName(functionMetadata),
			MethodName = request.MethodName,
			SourceCode = scriptModule.SourceCode,
			ProjectName = workspaceProjectHelper.CsprojFileName
		};
	}

	private IScriptSource GenerateProjectFile(WorkspaceProjectHelper projectHelper, IEnumerable<IScriptSource> sources, IEnumerable<IScriptReference> references)
	{
		string content = AbstractCodeEditorExtension.GenerateTemplate<ServerComponentCodeEditorExtension>("ProjectTemplate.csproj", (string s) => s.Replace("{PROJECT_GUID}", projectHelper.ProjectGuid).Replace("{ASSEMBLY_NAME}", projectHelper.ProjectAssemblyName).Replace("{REFERENCES}", GenerateReferencesSection(references))
			.Replace("{SOURCES}", AbstractCodeEditorExtension.GenerateSourcesSection(sources)));
		return projectHelper.CreateCsprojSource(content);
	}
}
