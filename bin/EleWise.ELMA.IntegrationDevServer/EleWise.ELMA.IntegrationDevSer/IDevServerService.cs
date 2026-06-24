using System.Threading.Tasks;

namespace EleWise.ELMA.IntegrationDevServer.Services;

public interface IDevServerService
{
	Task<string> Deploy(byte[] container);
}
