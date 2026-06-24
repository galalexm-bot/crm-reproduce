using System.ComponentModel;
using EleWise.ELMA.Hubs;

namespace EleWise.ELMA.Web.Hubs;

[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class HubClientProxy<TClient, TClientProxy> : IClient where TClient : IClient where TClientProxy : class
{
	protected readonly TClientProxy ClientProxy;

	protected HubClientProxy(TClientProxy clientProxy)
	{
		ClientProxy = clientProxy;
	}
}
