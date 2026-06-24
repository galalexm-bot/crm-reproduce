using System.Threading.Tasks;
using EleWise.ELMA.Hubs;

namespace EleWise.ELMA.Web.Hubs;

internal interface IAgentHubClient : IClient
{
	Task Exchange(string command, string args);
}
