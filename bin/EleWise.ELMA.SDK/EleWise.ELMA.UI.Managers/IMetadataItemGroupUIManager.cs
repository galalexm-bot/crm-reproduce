using System;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UI.Managers;

internal interface IMetadataItemGroupUIManager : IEntityManager<MetadataItemGroupUI, long>, IEntityManager<MetadataItemGroupUI>, IEntityManager
{
	MetadataItemGroupUI Create(Guid typeUid, Guid moduleUid, Guid groupUid, string displayName, string name);

	MetadataItemGroupUI Edit(Guid uid, Guid typeUid, Guid moduleUid, Guid groupUid, string displayName, string name);
}
