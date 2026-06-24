using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using Autofac.Core;

namespace Orchard.Wcf;

public class OrchardDependencyInjectionServiceBehavior : IServiceBehavior
{
	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly Type _implementationType;

	private readonly IComponentRegistration _componentRegistration;

	public OrchardDependencyInjectionServiceBehavior(IWorkContextAccessor workContextAccessor, Type implementationType, IComponentRegistration componentRegistration)
	{
		if (workContextAccessor == null)
		{
			throw new ArgumentNullException("workContextAccessor");
		}
		if (implementationType == null)
		{
			throw new ArgumentNullException("implementationType");
		}
		if (componentRegistration == null)
		{
			throw new ArgumentNullException("componentRegistration");
		}
		_workContextAccessor = workContextAccessor;
		_implementationType = implementationType;
		_componentRegistration = componentRegistration;
	}

	public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
	{
	}

	public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
	{
		if (serviceDescription == null)
		{
			throw new ArgumentNullException("serviceDescription");
		}
		if (serviceHostBase == null)
		{
			throw new ArgumentNullException("serviceHostBase");
		}
		IEnumerable<string> source = from ep in serviceDescription.Endpoints
			where ep.Contract.ContractType.IsAssignableFrom(_implementationType)
			select ep.Contract.Name;
		OrchardInstanceProvider instanceProvider = new OrchardInstanceProvider(_workContextAccessor, _componentRegistration);
		foreach (ChannelDispatcherBase channelDispatcher2 in serviceHostBase.ChannelDispatchers)
		{
			if (!(channelDispatcher2 is ChannelDispatcher channelDispatcher))
			{
				continue;
			}
			foreach (EndpointDispatcher endpoint in channelDispatcher.Endpoints)
			{
				if (source.Contains(endpoint.ContractName))
				{
					endpoint.DispatchRuntime.InstanceProvider = instanceProvider;
				}
			}
		}
	}

	public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
	{
	}
}
