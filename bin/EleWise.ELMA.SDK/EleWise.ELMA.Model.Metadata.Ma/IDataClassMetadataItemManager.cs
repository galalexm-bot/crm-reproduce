using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.Model.Metadata.Managers;

internal interface IDataClassMetadataItemManager : IEntityManager<DataClassMetadataItem, long>, IEntityManager<DataClassMetadataItem>, IEntityManager
{
	DataClassMetadataItem Create(Guid moduleUid, Guid groupUid, string displayName);

	DataClassMetadataItem Copy(Guid headerUid);

	UIMetadataPublishResult Publish(string comment, Guid[] headerIds);

	UIMetadataPublishResult Publish(string comment, Guid headerId);

	IEnumerable<DataClassMetadataItem> GetLastPublished();

	List<RuntimeDataClassModel> LoadRuntimeMetadata(IEnumerable<Guid> itemUids);
}
