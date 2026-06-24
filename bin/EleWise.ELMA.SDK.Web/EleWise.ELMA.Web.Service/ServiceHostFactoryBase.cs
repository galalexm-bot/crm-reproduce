using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Service.JsonBehavior;

namespace EleWise.ELMA.Web.Service;

internal class ServiceHostFactoryBase : ServiceHostFactory
{
	protected bool isSoapService;

	protected bool isStreamed;

	protected ServiceHostFactoryBase(bool isSoapService, bool isStreamed)
	{
		this.isSoapService = isSoapService;
		this.isStreamed = isStreamed;
	}

	protected virtual ServiceEndpoint AddHostEndpoint(ServiceHost host, Type contractType, Binding binding, string address = "")
	{
		ServiceEndpoint serviceEndpoint = host.AddServiceEndpoint(contractType, binding, address);
		UpdateDataContractItemGraph(serviceEndpoint);
		return serviceEndpoint;
	}

	protected virtual void UpdateDataContractItemGraph(ServiceEndpoint endpoint)
	{
		DataContractSerializerOperationBehavior dataContractSerializerOperationBehavior = endpoint.Behaviors.Find<DataContractSerializerOperationBehavior>();
		if (dataContractSerializerOperationBehavior != null)
		{
			dataContractSerializerOperationBehavior.MaxItemsInObjectGraph = int.MaxValue;
		}
	}

	protected virtual void UpdateServiceHost(Type contractType, Uri[] baseAddresses, ServiceHost host)
	{
		if (isSoapService)
		{
			Uri[] array = baseAddresses;
			foreach (Uri baseAddress in array)
			{
				BasicHttpBinding basicHttpBinding = CreateSoapBinding(baseAddress);
				if (isStreamed)
				{
					basicHttpBinding.TransferMode = TransferMode.Streamed;
				}
				AddHostEndpoint(host, contractType, basicHttpBinding);
			}
		}
		else
		{
			Uri[] array = baseAddresses;
			foreach (Uri baseAddress2 in array)
			{
				WebHttpBinding webHttpBinding = CreateWebBinding(baseAddress2);
				if (isStreamed)
				{
					webHttpBinding.TransferMode = TransferMode.Streamed;
				}
				CustomContentTypeMapperAttribute attribute = AttributeHelper<CustomContentTypeMapperAttribute>.GetAttribute(host.Description.ServiceType, inherited: false);
				if (attribute != null)
				{
					WebContentTypeMapper webContentTypeMapper2 = (webHttpBinding.ContentTypeMapper = (WebContentTypeMapper)Activator.CreateInstance(attribute.ContentTypeMapperType));
				}
				ServiceEndpoint serviceEndpoint = AddHostEndpoint(host, contractType, webHttpBinding);
				object[] customAttributes = contractType.GetCustomAttributes(typeof(XmlSerializerFormatAttribute), inherit: false);
				if (customAttributes != null && customAttributes.Length != 0)
				{
					serviceEndpoint.Behaviors.Add(new WebHttpBehavior
					{
						HelpEnabled = true,
						AutomaticFormatSelectionEnabled = false,
						DefaultOutgoingRequestFormat = WebMessageFormat.Xml,
						DefaultOutgoingResponseFormat = WebMessageFormat.Xml
					});
				}
				else
				{
					serviceEndpoint.Behaviors.Add(new NewtonsoftJsonBehavior(host.Description.ServiceType)
					{
						HelpEnabled = true,
						AutomaticFormatSelectionEnabled = true,
						DefaultOutgoingRequestFormat = WebMessageFormat.Json,
						DefaultOutgoingResponseFormat = WebMessageFormat.Json
					});
				}
			}
		}
		if (HasHttpEndpoint(baseAddresses))
		{
			if (host.Description.Behaviors.Contains(typeof(ServiceMetadataBehavior)))
			{
				((ServiceMetadataBehavior)host.Description.Behaviors[typeof(ServiceMetadataBehavior)]).HttpGetEnabled = true;
			}
			else
			{
				ServiceMetadataBehavior item = new ServiceMetadataBehavior
				{
					HttpGetEnabled = true
				};
				host.Description.Behaviors.Add(item);
			}
		}
		if (HasHttpsEndpoint(baseAddresses))
		{
			if (host.Description.Behaviors.Contains(typeof(ServiceMetadataBehavior)))
			{
				((ServiceMetadataBehavior)host.Description.Behaviors[typeof(ServiceMetadataBehavior)]).HttpsGetEnabled = true;
			}
			else
			{
				ServiceMetadataBehavior item2 = new ServiceMetadataBehavior
				{
					HttpsGetEnabled = true
				};
				host.Description.Behaviors.Add(item2);
			}
		}
		SessionBehavior.AddTo(host.Description.Behaviors);
		DisableSessionBehavior.AddTo(host.Description.Behaviors);
	}

	protected bool HasHttpsEndpoint(Uri[] baseAddresses)
	{
		return baseAddresses.Any((Uri b) => b.Scheme == Uri.UriSchemeHttps);
	}

	protected bool HasHttpEndpoint(Uri[] baseAddresses)
	{
		return baseAddresses.Any((Uri b) => b.Scheme == Uri.UriSchemeHttp);
	}

	protected BasicHttpBinding CreateSoapBinding(Uri baseAddress)
	{
		BasicHttpBinding basicHttpBinding = ((!(baseAddress.Scheme == Uri.UriSchemeHttps)) ? new BasicHttpBinding(BasicHttpSecurityMode.None) : new BasicHttpBinding(BasicHttpSecurityMode.Transport));
		basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
		basicHttpBinding.Security.Transport.ProxyCredentialType = HttpProxyCredentialType.None;
		basicHttpBinding.MessageEncoding = WSMessageEncoding.Text;
		basicHttpBinding.TextEncoding = Encoding.UTF8;
		basicHttpBinding.ReaderQuotas = new XmlDictionaryReaderQuotas
		{
			MaxDepth = int.MaxValue,
			MaxNameTableCharCount = int.MaxValue,
			MaxArrayLength = int.MaxValue,
			MaxBytesPerRead = int.MaxValue,
			MaxStringContentLength = int.MaxValue
		};
		basicHttpBinding.MaxBufferSize = int.MaxValue;
		basicHttpBinding.MaxBufferPoolSize = 2147483647L;
		basicHttpBinding.MaxReceivedMessageSize = 2147483647L;
		basicHttpBinding.Name = "BasicHttpBinding-ELMA";
		basicHttpBinding.Namespace = "http://www.elma-bpm.ru/api/";
		return basicHttpBinding;
	}

	protected WebHttpBinding CreateWebBinding(Uri baseAddress)
	{
		WebHttpBinding webHttpBinding = ((!(baseAddress.Scheme == Uri.UriSchemeHttps)) ? new WebHttpBinding() : new WebHttpBinding(WebHttpSecurityMode.Transport));
		webHttpBinding.ReaderQuotas = new XmlDictionaryReaderQuotas
		{
			MaxDepth = int.MaxValue,
			MaxNameTableCharCount = int.MaxValue,
			MaxArrayLength = int.MaxValue,
			MaxBytesPerRead = int.MaxValue,
			MaxStringContentLength = int.MaxValue
		};
		webHttpBinding.MaxBufferSize = int.MaxValue;
		webHttpBinding.MaxBufferPoolSize = 2147483647L;
		webHttpBinding.MaxReceivedMessageSize = 2147483647L;
		webHttpBinding.Name = "WebHttpBinding-ELMA";
		webHttpBinding.Namespace = "http://www.elma-bpm.ru/api/";
		return webHttpBinding;
	}
}
