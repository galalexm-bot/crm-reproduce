using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Runtime;

namespace EleWise.ELMA.Services;

[ServiceContract]
public interface IServerStatusService
{
	StartInformation GetCurrentStartInformation { get; }

	System.Threading.Tasks.Task CheckServerStatus();
}
