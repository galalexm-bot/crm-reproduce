using System;
using System.Reflection;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Web.Service.JsonBehavior;

internal class NewtonsoftJsonBehavior : WebHttpBehavior
{
	private readonly Type serviceTypeImpl;

	internal NewtonsoftJsonBehavior(Type serviceTypeImpl)
	{
		this.serviceTypeImpl = serviceTypeImpl;
	}

	public override void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
	{
		base.ApplyDispatchBehavior(endpoint, endpointDispatcher);
		foreach (OperationDescription operation in endpoint.Contract.Operations)
		{
			DispatchOperation dispatchOperation = null;
			if (endpointDispatcher.DispatchRuntime.Operations.Contains(operation.Name))
			{
				dispatchOperation = endpointDispatcher.DispatchRuntime.Operations[operation.Name];
			}
			else if (endpointDispatcher.DispatchRuntime.UnhandledDispatchOperation.Name == operation.Name)
			{
				dispatchOperation = endpointDispatcher.DispatchRuntime.UnhandledDispatchOperation;
			}
			if (dispatchOperation?.Formatter == null)
			{
				continue;
			}
			if (serviceTypeImpl == null)
			{
				dispatchOperation.Formatter = new NewtonsoftJsonPipedDispatchFormatter(dispatchOperation.Formatter, dispatchOperation, operation);
				continue;
			}
			MethodInfo methodInfo = operation.SyncMethod ?? operation.TaskMethod;
			if (methodInfo != null)
			{
				CustomBehaviorFormatterAttribute attribute = AttributeHelper<CustomBehaviorFormatterAttribute>.GetAttribute(serviceTypeImpl.GetImlementationMethodInfoFromInterface(methodInfo), inherited: false);
				if (attribute != null)
				{
					dispatchOperation.Formatter = (IDispatchMessageFormatter)Activator.CreateInstance(attribute.BehaviorFormatterType, dispatchOperation.Formatter, dispatchOperation, operation);
					continue;
				}
			}
			dispatchOperation.Formatter = new NewtonsoftJsonPipedDispatchFormatter(dispatchOperation.Formatter, dispatchOperation, operation);
		}
	}

	protected override void AddServerErrorHandlers(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
	{
		endpointDispatcher.ChannelDispatcher.ErrorHandlers.Clear();
		endpointDispatcher.ChannelDispatcher.ErrorHandlers.Add(new PublicServiceExceptionErrorHandler(this, endpoint.Contract));
	}
}
