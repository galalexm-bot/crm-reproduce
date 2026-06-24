using System;
using System.Linq;
using System.Net;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class FaultContractBehavior : Attribute, IContractBehavior
{
	internal class FaultOperationBehavior : IOperationBehavior
	{
		public void Validate(OperationDescription operationDescription)
		{
		}

		public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
		{
			dispatchOperation.Invoker = new FaultOperationInvoker(dispatchOperation);
		}

		public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
		{
		}

		public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
		{
		}
	}

	internal class FaultOperationInvoker : IOperationInvoker
	{
		private IOperationInvoker InnerOperationInvoker { get; set; }

		public bool IsSynchronous => InnerOperationInvoker.IsSynchronous;

		public FaultOperationInvoker(DispatchOperation dispatchOperation)
		{
			InnerOperationInvoker = dispatchOperation.Invoker;
		}

		public object[] AllocateInputs()
		{
			return InnerOperationInvoker.AllocateInputs();
		}

		public object Invoke(object instance, object[] inputs, out object[] outputs)
		{
			object result = null;
			object[] output = null;
			InvokeWithCheck(delegate
			{
				result = InnerOperationInvoker.Invoke(instance, inputs, out output);
			});
			outputs = output;
			return result;
		}

		public IAsyncResult InvokeBegin(object instance, object[] inputs, AsyncCallback callback, object state)
		{
			IAsyncResult asyncResult = null;
			InvokeWithCheck(delegate
			{
				asyncResult = InnerOperationInvoker.InvokeBegin(instance, inputs, callback, state);
			});
			return asyncResult;
		}

		public object InvokeEnd(object instance, out object[] outputs, IAsyncResult result)
		{
			return InnerOperationInvoker.InvokeEnd(instance, out outputs, result);
		}

		private static void InvokeWithCheck(Action callIfOk)
		{
			try
			{
				if (callIfOk == null)
				{
					throw new ArgumentNullException("callIfOk");
				}
				callIfOk();
			}
			catch (FaultException)
			{
				throw;
			}
			catch (TargetInvocationException ex2)
			{
				if (ex2.InnerException is ElmaInvalidOperationException)
				{
					throw new WebFaultException<PublicServiceException>(new PublicServiceException(ex2.InnerException), HttpStatusCode.Conflict);
				}
				throw;
			}
			catch (ElmaInvalidOperationException ex3)
			{
				throw new WebFaultException<PublicServiceException>(new PublicServiceException(ex3.InnerException), HttpStatusCode.Conflict);
			}
			catch (Exception ex4)
			{
				throw PublicServiceException.CreateWebFault(ex4.Message, 500);
			}
		}
	}

	public Type DetailType { get; private set; }

	public FaultContractBehavior(Type detailType)
	{
		DetailType = detailType;
	}

	void IContractBehavior.Validate(ContractDescription contractDescription, ServiceEndpoint endpoint)
	{
	}

	void IContractBehavior.ApplyDispatchBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, DispatchRuntime dispatchRuntime)
	{
		string @namespace = contractDescription.Namespace;
		Type typeFromHandle = typeof(FaultOperationBehavior);
		foreach (OperationDescription operation in contractDescription.Operations)
		{
			if (!operation.Behaviors.Contains(typeFromHandle))
			{
				operation.Behaviors.Add(new FaultOperationBehavior());
			}
			if (!operation.Faults.Any((FaultDescription f) => f.DetailType == DetailType))
			{
				FaultDescription item = CreateFaultDescription(@namespace, operation);
				operation.Faults.Add(item);
			}
		}
	}

	private FaultDescription CreateFaultDescription(string ns, OperationDescription operation)
	{
		string text = DetailType.Name + "Fault";
		FaultDescription faultDescription = new FaultDescription(ns + "/" + operation.Name + text)
		{
			Name = text,
			Namespace = ns,
			DetailType = DetailType
		};
		PropertyInfo property = faultDescription.GetType().GetProperty("ElementName", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty);
		if (property != null)
		{
			property.SetValue(faultDescription, null, null);
		}
		return faultDescription;
	}

	void IContractBehavior.ApplyClientBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, ClientRuntime clientRuntime)
	{
	}

	void IContractBehavior.AddBindingParameters(ContractDescription contractDescription, ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
	{
	}
}
