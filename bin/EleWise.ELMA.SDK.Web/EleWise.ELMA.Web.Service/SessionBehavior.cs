using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Policy;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Threading;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.NH;

namespace EleWise.ELMA.Web.Service;

internal class SessionBehavior : IServiceBehavior, IContractBehavior, IEndpointBehavior, IOperationBehavior
{
	private class ServiceELMAContext : ELMAContext
	{
		private class InternalSynchronizationContext : SynchronizationContext, IExtension<OperationContext>
		{
			public void Attach(OperationContext owner)
			{
			}

			public void Detach(OperationContext owner)
			{
			}

			public override void Post(SendOrPostCallback d, object state)
			{
				base.Post(PostCallback, (d, state));
			}

			private void PostCallback(object state)
			{
				(SendOrPostCallback, object) tuple = ((SendOrPostCallback, object))state;
				SynchronizationContext.SetSynchronizationContext(this);
				Send(tuple.Item1, tuple.Item2);
			}
		}

		private readonly InternalSynchronizationContext currentSynchronizationContext;

		protected override object KeyObject => SynchronizationContext.Current;

		private ServiceELMAContext()
			: base(isolatedContext: false)
		{
			currentSynchronizationContext = OperationContext.Current.Extensions.Find<InternalSynchronizationContext>();
			if (currentSynchronizationContext == null)
			{
				OperationContext.Current.Extensions.Add(currentSynchronizationContext = new InternalSynchronizationContext());
			}
			SynchronizationContext.SetSynchronizationContext(currentSynchronizationContext);
		}

		protected override void SetAsCurrentInnerLogic()
		{
			SynchronizationContext.SetSynchronizationContext(currentSynchronizationContext);
		}

		public void Dispose(bool clear)
		{
			if (clear)
			{
				ELMAContext.Items.Clear();
			}
			base.Dispose();
		}

		public static void Start()
		{
			new ServiceELMAContext();
		}

		public static void End(bool clear)
		{
			((ServiceELMAContext)ELMAContext.Current).Dispose(clear);
		}
	}

	private class ServiceAuthenticationManager : System.ServiceModel.ServiceAuthenticationManager
	{
		private readonly System.ServiceModel.ServiceAuthenticationManager serviceAuthenticationManager;

		public ServiceAuthenticationManager(System.ServiceModel.ServiceAuthenticationManager serviceAuthenticationManager)
		{
			this.serviceAuthenticationManager = serviceAuthenticationManager;
		}

		public override ReadOnlyCollection<IAuthorizationPolicy> Authenticate(ReadOnlyCollection<IAuthorizationPolicy> authPolicy, Uri listenUri, ref Message message)
		{
			ServiceELMAContext.Start();
			CallContextSessionOwner.Create();
			OperationContext.Current.OperationCompleted += delegate
			{
				try
				{
					CallContextSessionOwner.Current.Dispose();
				}
				catch (Exception exception)
				{
					Logger.Log.Verbose("Unexpected exception on closing Hibernate Sessions", exception);
				}
				finally
				{
					ServiceELMAContext.End(clear: true);
				}
			};
			if (serviceAuthenticationManager != null)
			{
				return serviceAuthenticationManager.Authenticate(authPolicy, listenUri, ref message);
			}
			return base.Authenticate(authPolicy, listenUri, ref message);
		}
	}

	private class AsyncOperationInvoker : IOperationInvoker
	{
		private IOperationInvoker invoker;

		public bool IsSynchronous => false;

		public AsyncOperationInvoker(IOperationInvoker invoker)
		{
			this.invoker = invoker;
		}

		public object[] AllocateInputs()
		{
			return invoker.AllocateInputs();
		}

		public object Invoke(object instance, object[] inputs, out object[] outputs)
		{
			throw new NotImplementedException();
		}

		public IAsyncResult InvokeBegin(object instance, object[] inputs, AsyncCallback callback, object state)
		{
			try
			{
				return invoker.InvokeBegin(instance, inputs, callback, state);
			}
			finally
			{
				ServiceELMAContext.End(clear: false);
			}
		}

		public object InvokeEnd(object instance, out object[] outputs, IAsyncResult result)
		{
			ServiceELMAContext.Start();
			return invoker.InvokeEnd(instance, out outputs, result);
		}
	}

	private static readonly IServiceBehavior Singleton = new SessionBehavior();

	private SessionBehavior()
	{
	}

	internal static void AddTo(KeyedByTypeCollection<IServiceBehavior> behaviors)
	{
		SessionBehavior.AddTo<IServiceBehavior>(behaviors);
	}

	private static void AddTo<T>(KeyedByTypeCollection<T> behaviors)
	{
		if (!behaviors.Contains(TypeOf<SessionBehavior>.Raw))
		{
			behaviors.Add((T)Singleton);
		}
	}

	void IServiceBehavior.ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
	{
		serviceDescription.Endpoints.ForEach(delegate(ServiceEndpoint ep)
		{
			AddTo(ep.Contract.Behaviors);
		});
	}

	void IContractBehavior.ApplyDispatchBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, DispatchRuntime dispatchRuntime)
	{
		dispatchRuntime.ServiceAuthenticationManager = new ServiceAuthenticationManager(dispatchRuntime.ServiceAuthenticationManager);
		AddTo(endpoint.Behaviors);
	}

	void IEndpointBehavior.ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
	{
		endpoint.Contract.Operations.ForEach(delegate(OperationDescription o)
		{
			AddTo(o.Behaviors);
		});
	}

	void IOperationBehavior.ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
	{
		if (!dispatchOperation.Invoker.IsSynchronous)
		{
			dispatchOperation.Invoker = new AsyncOperationInvoker(dispatchOperation.Invoker);
		}
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

	void IEndpointBehavior.Validate(ServiceEndpoint endpoint)
	{
	}

	void IEndpointBehavior.AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
	{
	}

	void IEndpointBehavior.ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
	{
	}

	void IOperationBehavior.Validate(OperationDescription operationDescription)
	{
	}

	void IOperationBehavior.ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
	{
	}

	void IOperationBehavior.AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
	{
	}
}
