using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace EleWise.ELMA.IntegrationModules.Extensions;

internal sealed class EndpointBehaviour : IEndpointBehavior
{
	private readonly IDictionary<string, string> headers;

	public EndpointBehaviour(IDictionary<string, string> headers)
	{
		this.headers = headers;
	}

	public void Validate(ServiceEndpoint endpoint)
	{
	}

	public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
	{
	}

	public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
	{
	}

	public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
	{
		clientRuntime.ClientMessageInspectors.Add(new ClientMessageInspector(headers));
	}
}
