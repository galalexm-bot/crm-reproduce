using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.Model.Metadata.Managers;

internal interface IModuleMetadataItemManager : IEntityManager<ModuleMetadataItem, long>, IEntityManager<ModuleMetadataItem>, IEntityManager
{
	ModuleMetadataItem Create(string name, string displayName, string description);

	UIMetadataPublishResult Publish(Guid headerUid, string comment);

	List<RuntimeModuleModel> LoadRuntimeMetadata(IEnumerable<Guid> itemUids, bool debug);
}
