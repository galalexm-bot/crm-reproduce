using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UIBuilder.Model;

namespace EleWise.ELMA.UIBuilder.Components;

[Component]
public sealed class ClientScriptModuleType : IScriptModuleType
{
	private readonly IEnumerable<IScriptModuleTypeInfo> scriptModuleTypeInfos;

	private const string UidS = "{817DA5DD-C874-476C-8F87-6C6D953935AF}";

	public static readonly Guid TypeUid = new Guid("{817DA5DD-C874-476C-8F87-6C6D953935AF}");

	public Guid Uid => TypeUid;

	public string Name => SR.T("Клиентский модуль сценариев");

	public ClientScriptModuleType(IEnumerable<IScriptModuleTypeInfo> scriptModuleTypeInfos)
	{
		this.scriptModuleTypeInfos = scriptModuleTypeInfos;
	}

	public string GenerateSourceCode(object parameters)
	{
		if (!(parameters is ClientScriptGenerationParams parameters2))
		{
			return string.Empty;
		}
		return GenerateSourceCode(parameters2);
	}

	public ScriptCompileResult Compile(ScriptModule module)
	{
		throw new NotImplementedException();
	}

	private string GenerateSourceCode(ClientScriptGenerationParams parameters)
	{
		Contract.ArgumentNotNull(parameters, "parameters");
		Contract.ArgumentNotNull(parameters.Metadata, "parameters.Metadata");
		IScriptModuleTypeInfo scriptModuleTypeInfo = scriptModuleTypeInfos.FirstOrDefault((IScriptModuleTypeInfo info) => info.Check(parameters.Metadata, TypeUid));
		if (scriptModuleTypeInfo == null)
		{
			return string.Empty;
		}
		ICodeGenerator codeGenerator = (ICodeGenerator)Activator.CreateInstance(scriptModuleTypeInfo.GeneratorType);
		codeGenerator.Metadata = parameters.Metadata;
		return Encoding.UTF8.GetString(codeGenerator.GenerateMainFile().Data);
	}
}
