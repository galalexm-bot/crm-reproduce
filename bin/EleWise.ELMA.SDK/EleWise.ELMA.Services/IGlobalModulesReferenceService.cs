using System;

namespace EleWise.ELMA.Services;

internal interface IGlobalModulesReferenceService
{
	string CreateGlobalModuleAssembly(Guid globalModuleHeaderUid);

	string GetGlobalModuleAssemblyPath(Guid globalModuleHeaderUid);
}
