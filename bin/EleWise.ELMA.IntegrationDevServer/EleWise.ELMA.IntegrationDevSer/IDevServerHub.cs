using System.Threading.Tasks;
using EleWise.ELMA.Hubs;

namespace EleWise.ELMA.IntegrationDevServer.Hubs;

internal interface IDevServerHub : IHub
{
	Task<string> Deploy(byte[] container);
}
