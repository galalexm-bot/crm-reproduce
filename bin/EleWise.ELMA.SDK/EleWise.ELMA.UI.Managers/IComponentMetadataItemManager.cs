using System;
using System.Collections.Generic;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UI.Managers;

internal interface IComponentMetadataItemManager : IEntityManager<ComponentMetadataItem, long>, IEntityManager<ComponentMetadataItem>, IEntityManager
{
	ComponentMetadataItem Create(Guid typeUid, Guid moduleUid, Guid groupUid, string displayName);

	ComponentMetadataItem Copy(Guid headerUid);

	void MarkAsNotWorking(ComponentMetadataItem obj);

	void Rename(ComponentMetadataItem current, string oldName);

	List<RuntimeComponentModel> LoadRuntimeMetadata(IEnumerable<Guid> itemUids, bool debug);

	UIMetadataPublishResult Publish(Guid headerId, string comment, bool forEmulation);

	IEnumerable<ComponentMetadataItemWrapper> GetCandidates(Guid headerUid);

	IEnumerable<ComponentMetadataItemWrapper> GetLastPublished();
}
