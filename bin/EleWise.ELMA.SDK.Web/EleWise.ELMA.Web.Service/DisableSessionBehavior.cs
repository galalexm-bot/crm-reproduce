using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Policy;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.Modules;

namespace EleWise.ELMA.Web.Service;

internal sealed class DisableSessionBehavior : IServiceBehavior, IContractBehavior
{
	private sealed class ServiceAuthenticationManager : System.ServiceModel.ServiceAuthenticationManager
	{
		private readonly System.ServiceModel.ServiceAuthenticationManager serviceAuthenticationManager;

		public ServiceAuthenticationManager(System.ServiceModel.ServiceAuthenticationManager serviceAuthenticationManager)
		{
			this.serviceAuthenticationManager = serviceAuthenticationManager;
		}

		public override ReadOnlyCollection<IAuthorizationPolicy> Authenticate(ReadOnlyCollection<IAuthorizationPolicy> authPolicy, Uri listenUri, ref Message message)
		{
			ELMASessionStateModule.DisableSession = true;
			if (serviceAuthenticationManager != null)
			{
				return serviceAuthenticationManager.Authenticate(authPolicy, listenUri, ref message);
			}
			return base.Authenticate(authPolicy, listenUri, ref message);
		}
	}

	internal static void AddTo(KeyedByTypeCollection<IServiceBehavior> behaviors)
	{
		if (!behaviors.Contains(typeof(DisableSessionBehavior)))
		{
			behaviors.Add(new DisableSessionBehavior());
		}
	}

	void IServiceBehavior.ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
	{
		serviceDescription.Endpoints.ForEach(delegate(ServiceEndpoint ep)
		{
			if (!ep.Contract.Behaviors.Contains(typeof(DisableSessionBehavior)))
			{
				ep.Contract.Behaviors.Add(this);
			}
		});
	}

	void IContractBehavior.ApplyDispatchBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, DispatchRuntime dispatchRuntime)
	{
		dispatchRuntime.ServiceAuthenticationManager = new ServiceAuthenticationManager(dispatchRuntime.ServiceAuthenticationManager);
	}

	void IServiceBehavior.AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
	{
	}

	void IServiceBehavior.Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
	{
	}

	void IContractBehavior.Validate(ContractDescription contractDescription, ServiceEndpoint endpoint)
	{
	}

	void IContractBehavior.ApplyClientBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, ClientRuntime clientRuntime)
	{
	}

	void IContractBehavior.AddBindingParameters(ContractDescription contractDescription, ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
	{
	}
}
