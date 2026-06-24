using EleWise.ELMA.Hubs;

namespace EleWise.ELMA.Web.Hubs;

public interface IHubContextWrapper<T> where T : IClient
{
	IHubConnectionContextWrapper<T> Clients { get; }

	IGroupManagerWrapper Groups { get; }
}
