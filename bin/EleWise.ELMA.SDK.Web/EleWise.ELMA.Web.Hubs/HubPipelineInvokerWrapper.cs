using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Runtime.Context;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace EleWise.ELMA.Web.Hubs;

internal sealed class HubPipelineInvokerWrapper : IHubPipelineInvoker
{
	private readonly IHubPipelineInvoker invoker;

	public HubPipelineInvokerWrapper(IHubPipelineInvoker invoker)
	{
		this.invoker = invoker;
	}

	async Task<object> IHubPipelineInvoker.Invoke(IHubIncomingInvokerContext context)
	{
		using (ELMAContext.Create())
		{
			return await invoker.Invoke(context);
		}
	}

	bool IHubPipelineInvoker.AuthorizeConnect(HubDescriptor hubDescriptor, IRequest request)
	{
		return invoker.AuthorizeConnect(hubDescriptor, request);
	}

	IList<string> IHubPipelineInvoker.RejoiningGroups(HubDescriptor hubDescriptor, IRequest request, IList<string> groups)
	{
		return invoker.RejoiningGroups(hubDescriptor, request, groups);
	}

	Task IHubPipelineInvoker.Connect(IHub hub)
	{
		return invoker.Connect(hub);
	}

	Task IHubPipelineInvoker.Disconnect(IHub hub, bool stopCalled)
	{
		return invoker.Disconnect(hub, stopCalled);
	}

	Task IHubPipelineInvoker.Reconnect(IHub hub)
	{
		return invoker.Reconnect(hub);
	}

	Task IHubPipelineInvoker.Send(IHubOutgoingInvokerContext context)
	{
		return invoker.Send(context);
	}
}
