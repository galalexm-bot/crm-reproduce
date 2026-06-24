using System;

namespace EleWise.ELMA.Model.Metadata.Managers;

public interface IDataClassMetadataTypeReferenceService
{
	Guid? GetMetadataUid(string typeRef);
}
