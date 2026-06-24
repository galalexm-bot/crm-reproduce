using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.DTO;

[ServiceContract]
internal interface IProxyGeneratorServiceInternal : IProxyGeneratorService
{
	ReactiveProxy GenerateProxyByStringUid(string typeUid);

	System.Threading.Tasks.Task<ReactiveProxy> GenerateProxyByStringUidAsync(string typeUid);
}
