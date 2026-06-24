using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using Autofac.Core;

namespace Orchard.Wcf;

public class OrchardInstanceProvider : IInstanceProvider
{
	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly IComponentRegistration _componentRegistration;

	public OrchardInstanceProvider(IWorkContextAccessor workContextAccessor, IComponentRegistration componentRegistration)
	{
		_workContextAccessor = workContextAccessor;
		_componentRegistration = componentRegistration;
	}

	public object GetInstance(InstanceContext instanceContext, Message message)
	{
		OrchardInstanceContext orchardInstanceContext = new OrchardInstanceContext(_workContextAccessor);
		instanceContext.Extensions.Add(orchardInstanceContext);
		return orchardInstanceContext.Resolve(_componentRegistration);
	}

	public object GetInstance(InstanceContext instanceContext)
	{
		return GetInstance(instanceContext, null);
	}

	public void ReleaseInstance(InstanceContext instanceContext, object instance)
	{
		instanceContext.Extensions.Find<OrchardInstanceContext>()?.Dispose();
	}
}
