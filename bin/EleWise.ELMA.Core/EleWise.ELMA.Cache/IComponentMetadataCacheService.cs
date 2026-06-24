using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Cache.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Cache;

[ServiceContract]
public interface IComponentMetadataCacheService
{
	void Cache(System.Collections.Generic.ICollection<RuntimeComponentModel> componentModels);

	System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<RuntimeComponentModel>> GetFromCache(System.Collections.Generic.IEnumerable<Guid> metadataUidList);

	System.Threading.Tasks.Task<IMetadataUidDifference> GetDifferenceMetadataUids(System.Collections.Generic.IEnumerable<Guid> requiredMetadataUidList);
}
