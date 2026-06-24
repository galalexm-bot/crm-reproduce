using EleWise.ELMA.Hubs;

namespace EleWise.ELMA.Web.Hubs;

public interface IHubContextFactory
{
	IHubContextWrapper<TClient> GetContext<THub, TClient>() where TClient : IClient;
}
