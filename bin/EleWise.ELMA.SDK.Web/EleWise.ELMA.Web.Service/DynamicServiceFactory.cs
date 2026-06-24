using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Service;

internal class DynamicServiceFactory : ServiceHostFactoryBase
{
	private readonly Type contractType;

	public DynamicServiceFactory(bool isSoapService, [NotNull] Type contractType, bool isStreamed)
		: base(isSoapService, isStreamed)
	{
		if (contractType == null)
		{
			throw new ArgumentNullException("contractType");
		}
		this.contractType = contractType;
	}

	public DynamicServiceFactory([NotNull] Type contractType, bool isStreamed)
		: base(isSoapService: false, isStreamed)
	{
		if (contractType == null)
		{
			throw new ArgumentNullException("contractType");
		}
		this.contractType = contractType;
	}

	protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
	{
		ServiceHost serviceHost = (isSoapService ? new ServiceHost(serviceType, baseAddresses) : new WebServiceHost(serviceType, baseAddresses));
		UpdateServiceHost(contractType, baseAddresses, serviceHost);
		return serviceHost;
	}
}
