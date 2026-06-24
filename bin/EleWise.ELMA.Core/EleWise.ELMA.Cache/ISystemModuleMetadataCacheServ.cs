using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Cache;

[ServiceContract]
internal interface ISystemModuleMetadataCacheService
{
	System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Guid>> GetCachedModuleUids();

	System.Threading.Tasks.Task<object[]> GetSerializedModules(System.Collections.Generic.IEnumerable<Guid> guidsToLoad);

	void Cache(SystemMetadata systemMetadata, Guid uid);
}
