using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Model.Metadata.Managers;

public interface IDataClassMetadataItemHeaderManager : IEntityManager<DataClassMetadataItemHeader, long>, IEntityManager<DataClassMetadataItemHeader>, IEntityManager
{
	IEnumerable<DataClassMetadataItemHeader> GetAllPublished();

	IEnumerable<DataClassMetadataItemHeader> GetAllDrafts();

	bool ValidateName(Guid headerUid, string name, out string errorMessage);

	bool ValidateDisplayName(Guid headerUid, string displayName, out string errorMessage);

	long GetNewPublishingVersionNumber(long headerId);

	DataClassMetadataItemHeader Edit(Guid uid, Guid group);
}
