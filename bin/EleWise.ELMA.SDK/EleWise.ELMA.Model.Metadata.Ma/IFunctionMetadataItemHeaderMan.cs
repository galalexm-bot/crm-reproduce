using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Model.Metadata.Managers;

internal interface IFunctionMetadataItemHeaderManager : IEntityManager<FunctionMetadataItemHeader, long>, IEntityManager<FunctionMetadataItemHeader>, IEntityManager
{
	long GetPublishingVersionNumber(long headerId);

	bool ValidateName(long headerId, string name, out string errorMessage);

	bool ValidateName(Guid headerUid, string name, out string errorMessage);

	bool ValidateDisplayName(long headerId, string displayName, out string errorMessage);

	bool ValidateDisplayName(Guid headerUid, string displayName, out string errorMessage);

	IEnumerable<FunctionMetadataItemHeader> GetAllPublished();

	IEnumerable<FunctionMetadataItemHeader> GetAllDrafts();

	FunctionMetadataItemHeader Edit(Guid uid, Guid group);
}
