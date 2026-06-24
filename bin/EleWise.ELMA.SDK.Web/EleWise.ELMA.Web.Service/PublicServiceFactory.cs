using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service;

internal class PublicServiceFactory : ServiceHostFactoryBase
{
	private readonly IPublicService publicService;

	public PublicServiceFactory(IPublicService publicService, bool isSoapService = true)
		: base(isSoapService, isStreamed: false)
	{
		this.publicService = publicService;
	}

	protected override ServiceEndpoint AddHostEndpoint(ServiceHost host, Type contractType, Binding binding, string address = "")
	{
		ServiceEndpoint serviceEndpoint = host.AddServiceEndpoint(publicService.Name, binding, address);
		UpdateDataContractItemGraph(serviceEndpoint);
		return serviceEndpoint;
	}

	protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
	{
		ServiceHost serviceHost = new PublicServiceHost(publicService, serviceType, baseAddresses);
		UpdateServiceHost(serviceType, baseAddresses, serviceHost);
		return serviceHost;
	}
}
