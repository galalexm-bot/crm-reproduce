using System;
using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.Model.Metadata.Managers;

internal interface IModuleReferenceManager
{
	void Save(ModuleReference moduleReference);

	ModuleReference LoadOrNull(Guid metadataUid);
}
