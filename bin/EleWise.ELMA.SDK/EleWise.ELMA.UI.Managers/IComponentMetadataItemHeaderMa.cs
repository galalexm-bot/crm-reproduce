using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UI.Managers;

internal interface IComponentMetadataItemHeaderManager : IEntityManager<ComponentMetadataItemHeader, long>, IEntityManager<ComponentMetadataItemHeader>, IEntityManager
{
	long GetPublishingVersionNumber(long headerId);

	IEnumerable<ComponentMetadataItemHeader> GetAllPublished();

	IEnumerable<ComponentMetadataItemHeader> GetAllDrafts();

	bool ValidateName(Guid headerUid, string name, out string errorMessage);

	bool ValidateDisplayName(Guid headerUid, string displayName, out string errorMessage);

	ComponentMetadataItemHeader Edit(Guid uid, Guid groupUid);

	void Delete(long headerId);

	IEnumerable<ComponentMetadataItemHeader> SortByDependencies(IEnumerable<ComponentMetadataItemHeader> headers);

	ICollection<ComponentMetadataItemHeader> FindByIdArray(Guid[] UidArray);
}
