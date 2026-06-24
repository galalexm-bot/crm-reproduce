using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Cache;

[ServiceContract]
internal interface IContentActionCacheService
{
	void Cache(System.Collections.Generic.IEnumerable<ContentAction> contentActions);

	System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ContentAction>> GetFromCache();
}
