using System.Threading.Tasks;
using EleWise.ELMA.Hubs;

namespace EleWise.ELMA.Web.Hubs;

internal interface IAgentHub : IHub
{
	Task OnConnected();

	Task OnReconnected();

	Task OnDisconnected(bool stopCalled);

	Task Exchange(string command, string args);
}
