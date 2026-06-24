using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace EleWise.ELMA.IntegrationModules.Extensions;

internal sealed class ClientMessageInspector : IClientMessageInspector
{
	private readonly IDictionary<string, string> headers;

	public ClientMessageInspector(IDictionary<string, string> headers)
	{
		this.headers = headers;
	}

	public object BeforeSendRequest(ref Message request, IClientChannel channel)
	{
		if (headers != null)
		{
			HttpRequestMessageProperty httpRequestMessageProperty = new HttpRequestMessageProperty();
			foreach (KeyValuePair<string, string> header in headers)
			{
				httpRequestMessageProperty.Headers.Add(header.Key, header.Value);
			}
			request.Properties[HttpRequestMessageProperty.Name] = httpRequestMessageProperty;
		}
		return null;
	}

	public void AfterReceiveReply(ref Message reply, object correlationState)
	{
	}
}
