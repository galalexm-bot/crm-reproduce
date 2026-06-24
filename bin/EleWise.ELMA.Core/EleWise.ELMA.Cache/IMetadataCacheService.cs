using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Cache.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Cache;

[ServiceContract]
public interface IMetadataCacheService
{
	void Cache(System.Collections.Generic.IEnumerable<IMetadata> metadataList);

	System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<IMetadata>> GetFromCache(System.Collections.Generic.IEnumerable<Guid> metadataUidList);

	System.Threading.Tasks.Task<IMetadataUidDifference> GetMetadataUids();

	System.Threading.Tasks.Task<IMetadataUidDifference> GetDifferenceMetadataUids(System.Collections.Generic.IEnumerable<Guid> requiredMetadataUidList);
}
