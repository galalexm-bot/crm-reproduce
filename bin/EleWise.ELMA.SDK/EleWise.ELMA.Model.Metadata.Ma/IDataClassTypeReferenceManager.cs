using System;
using EleWise.ELMA.Model.Scripts;

namespace EleWise.ELMA.Model.Metadata.Managers;

internal interface IDataClassTypeReferenceManager
{
	long Save(DataClassTypeReference dataClassTypeReference);

	DataClassTypeReference LoadOrNull(string id);

	DataClassTypeReference FindByItemUid(Guid itemUid, Guid metadataUid);

	DataClassTypeReference FindByMetadataUid(Guid metadataUid);

	DataClassTypeReference[] FindReferencesByItemUid(Guid[] itemUid);
}
