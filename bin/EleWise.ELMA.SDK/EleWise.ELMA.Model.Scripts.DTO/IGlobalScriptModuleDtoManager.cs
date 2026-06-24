using System;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Scripts.DTO.Models;

namespace EleWise.ELMA.Model.Scripts.DTO.Manager;

public interface IGlobalScriptModuleDtoManager : IConfigurationService
{
	GlobalScriptModuleDto Save(GlobalScriptModuleDto gsm);

	GlobalScriptModuleDto Publish(GlobalScriptModuleDto gsm);

	bool NeedRestartServer();

	GlobalScriptModuleDto LoadOrNull(long id);

	GlobalScriptModuleDto LoadOrNull(Guid uid);

	void DeleteDirectory(string directoryPath);

	GlobalScriptModuleDto Load(long id);

	GlobalScriptModuleDto Validate(GlobalScriptModuleDto gsm);

	ScriptModuleDTO LoadScriptModuleForEdit(long gsmId);

	void SaveScriptModule(ScriptModuleDTO scriptModule);

	bool CheckGlobalModuleNamespace(string space);

	bool CheckGlobalModuleName(string name);

	GlobalScriptModuleDto DoNew(GlobalScriptModuleDto oldGsm, string newPrefix = "", bool copy = false);
}
