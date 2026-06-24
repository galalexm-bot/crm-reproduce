using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.UIBuilder.MetadataEdit.DTO;

public sealed class ScriptModuleDTO
{
	public Guid Uid { get; set; }

	public Guid ModuleTypeUid { get; set; }

	public string SourceCode { get; set; }

	public string CompiledFileName { get; set; }

	public string AssemblyName { get; set; }

	public string Namespace { get; set; }

	public string ClassName { get; set; }

	public string ModuleName { get; set; }

	public string References { get; set; }

	public string ElmaReferences { get; set; }

	public List<ScriptWebReference> WebReferences { get; set; }

	public List<AssemblyReference> LocalReferences { get; set; }

	public List<AssemblyReference> GlobalScriptModules { get; set; }

	public List<ScriptMethodDeclaration> ScriptMethods { get; set; }

	public Guid ObjectUid { get; set; }

	public ScriptModuleDTO()
	{
		WebReferences = new List<ScriptWebReference>();
		LocalReferences = new List<AssemblyReference>();
		GlobalScriptModules = new List<AssemblyReference>();
		ScriptMethods = new List<ScriptMethodDeclaration>();
	}
}
