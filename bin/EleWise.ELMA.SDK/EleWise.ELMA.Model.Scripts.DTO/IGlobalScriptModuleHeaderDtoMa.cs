using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Scripts.DTO.Models;

namespace EleWise.ELMA.Model.Scripts.DTO.Manager;

public interface IGlobalScriptModuleHeaderDtoManager : IConfigurationService
{
	GlobalScriptModuleHeaderDto Save(GlobalScriptModuleHeaderDto gsm);

	GlobalScriptModuleHeaderDto LoadOrNull(long id);

	GlobalScriptModuleHeaderDto LoadOrNull(Guid uid);

	bool CheckGlobalScriptModuleName(long id, string name, out string errorMessage);

	bool CheckGlobalScriptModuleClassName(long id, string name, out string errorMessage);

	bool CheckGlobalScriptModuleTableName(long id, string name, out string errorMessage);

	IEnumerable<GlobalScriptModuleHeaderDto> LoadGlobalScriptModulesByName(string headerName);

	IEnumerable<GlobalScriptModuleHeaderDto> LoadPublishedGlobalScriptModuleHeaders();

	IEnumerable<GlobalScriptModuleHeaderDto> LoadAllGlobalScriptModuleHeaders();

	IEnumerable<GlobalScriptModuleHeaderDto> LoadPublishedGlobalScriptModuleHeaders(bool deletedIncluded);

	IEnumerable<GlobalScriptModuleHeaderDto> LoadRuntimeLoadedHeaders();

	void Delete(GlobalScriptModuleHeaderDto header);

	byte[] GetAssemblyRaw(Guid headerUid);
}
