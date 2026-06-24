using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Cache.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Cache;

[ServiceContract]
public interface IDataClassMetadataCacheService
{
	void Cache(System.Collections.Generic.ICollection<RuntimeDataClassModel> dataClassModels);

	System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<RuntimeDataClassModel>> GetFromCache(System.Collections.Generic.IEnumerable<Guid> metadataUidList);

	System.Threading.Tasks.Task<IMetadataUidDifference> GetDifferenceMetadataUids(System.Collections.Generic.IEnumerable<Guid> requiredMetadataUidList);
}
