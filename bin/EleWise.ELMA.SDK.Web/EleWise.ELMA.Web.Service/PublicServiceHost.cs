using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service.v1;

namespace EleWise.ELMA.Web.Service;

internal class PublicServiceHost : ServiceHost
{
	private class OperationInvoker : IOperationBehavior, IOperationInvoker
	{
		private readonly IPublicServiceMethod process;

		public bool IsSynchronous => true;

		public OperationInvoker(IPublicServiceMethod process)
		{
			this.process = process;
		}

		public object[] AllocateInputs()
		{
			return new object[1];
		}

		public object Invoke(object instance, object[] inputs, out object[] outputs)
		{
			try
			{
				outputs = new object[0];
				IPublicServiceEventHandler serviceNotNull = Locator.GetServiceNotNull<IPublicServiceEventHandler>();
				WebData parameters = inputs[0] as WebData;
				PublicServiceMethodEventArgs publicServiceMethodEventArgs = new PublicServiceMethodEventArgs
				{
					MethodName = process.Name,
					ServiceUid = process.ServiceUid,
					MethodVersion = process.Version,
					Parameters = parameters
				};
				serviceNotNull.ActionExecuting(publicServiceMethodEventArgs);
				WebData webData2 = (publicServiceMethodEventArgs.Result = publicServiceMethodEventArgs.Result ?? process.Execute(parameters).UpdateVersion());
				serviceNotNull.ActionExecuted(publicServiceMethodEventArgs);
				return publicServiceMethodEventArgs.Result;
			}
			catch (FaultException)
			{
				throw;
			}
			catch (TargetInvocationException ex2)
			{
				Logger.Log.Error(SR.T("Ошибка при выполнении публичного метода {0} из сервиса {1}. Параметры: {2}", process.Name, process.ServiceUid, string.Join("; ", inputs)), ex2.InnerException ?? ex2);
				if (ex2.InnerException is ElmaInvalidOperationException)
				{
					throw new WebFaultException<PublicServiceException>(new PublicServiceException(ex2.InnerException), HttpStatusCode.Conflict);
				}
				throw;
			}
			catch (ElmaInvalidOperationException ex3)
			{
				Logger.Log.Error(SR.T("Ошибка при выполнении публичного метода {0} из сервиса {1}. Параметры: {2}", process.Name, process.ServiceUid, string.Join("; ", inputs)), ex3);
				throw new WebFaultException<PublicServiceException>(new PublicServiceException(ex3.InnerException), HttpStatusCode.Conflict);
			}
			catch (Exception ex4)
			{
				Logger.Log.Error(SR.T("Ошибка при выполнении публичного метода {0} из сервиса {1}. Параметры: {2}", process.Name, process.ServiceUid, string.Join("; ", inputs)), ex4);
				throw PublicServiceException.CreateWebFault(ex4.Message, 500);
			}
		}

		public IAsyncResult InvokeBegin(object instance, object[] inputs, AsyncCallback callback, object state)
		{
			throw new NotSupportedException();
		}

		public object InvokeEnd(object instance, out object[] outputs, IAsyncResult result)
		{
			throw new NotSupportedException();
		}

		public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
		{
		}

		public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
		{
		}

		public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
		{
			dispatchOperation.Invoker = this;
		}

		public void Validate(OperationDescription operationDescription)
		{
		}
	}

	private readonly IPublicService publicService;

	private ContractDescription contractDescription;

	private const string DefaultNamespace = "http://www.elma-bpm.ru/api/";

	private const string ServiceContextItemsKey = "IPublicService.ContextItems.Key";

	private IPublicService PublicService => publicService ?? GetContextService();

	public PublicServiceHost(IPublicService publicService, Type serviceType, Uri[] baseAddresses)
		: base(SetContextSevice(serviceType, publicService), baseAddresses)
	{
		this.publicService = publicService;
		RemoveContextSevice();
	}

	private static Type SetContextSevice(Type serviceType, IPublicService publicService1)
	{
		HttpContextAccessor.CurrentContext.Items["IPublicService.ContextItems.Key"] = publicService1;
		return serviceType;
	}

	private static IPublicService GetContextService()
	{
		return HttpContextAccessor.CurrentContext.Items["IPublicService.ContextItems.Key"] as IPublicService;
	}

	private static void RemoveContextSevice()
	{
		HttpContextAccessor.CurrentContext.Items.Remove("IPublicService.ContextItems.Key");
	}

	protected override ServiceDescription CreateDescription(out IDictionary<string, ContractDescription> implementedContracts)
	{
		ServiceDescription serviceDescription = base.CreateDescription(out implementedContracts);
		serviceDescription.Name = PublicService.Name;
		serviceDescription.Namespace = "http://www.elma-bpm.ru/api/";
		contractDescription = CreateContractDescription(PublicService);
		implementedContracts.Add(PublicService.Name, contractDescription);
		return serviceDescription;
	}

	public override ReadOnlyCollection<ServiceEndpoint> AddDefaultEndpoints()
	{
		return new List<ServiceEndpoint>().AsReadOnly();
	}

	private ContractDescription CreateContractDescription(IPublicService model)
	{
		ContractDescription contractDescription = new ContractDescription(model.Name, "http://www.elma-bpm.ru/api/" + model.Name);
		foreach (IPublicServiceMethod serviceMethod in GetServiceMethods(model))
		{
			contractDescription.Operations.Add(CreateOperationDescription(contractDescription, serviceMethod));
		}
		return contractDescription;
	}

	private IEnumerable<IPublicServiceMethod> GetServiceMethods(IPublicService model)
	{
		return ComponentManager.Current.GetExtensionPoints<IPublicServiceMethodsProvider>().SelectMany((IPublicServiceMethodsProvider p) => from m in p.GetMethods()
			where m.ServiceUid == model.Uid
			select m);
	}

	private OperationDescription CreateOperationDescription(ContractDescription contract, IPublicServiceMethod process)
	{
		OperationDescription operationDescription = new OperationDescription(process.Name, contract);
		string text = "http://www.elma-bpm.ru/api/" + contract.Name;
		MessageDescription messageDescription = new MessageDescription(text + "/" + process.Name, MessageDirection.Input);
		messageDescription.Body.WrapperNamespace = text;
		messageDescription.Body.WrapperName = process.Name;
		MessagePartDescription item = new MessagePartDescription("data", text)
		{
			Type = typeof(WebData),
			Index = 0
		};
		messageDescription.Body.Parts.Add(item);
		operationDescription.Messages.Add(messageDescription);
		MessageDescription messageDescription2 = new MessageDescription(text + "/" + process.Name + "Response", MessageDirection.Output);
		messageDescription2.Body.WrapperName = process.Name + "Response";
		messageDescription2.Body.WrapperNamespace = text;
		messageDescription2.Body.ReturnValue = new MessagePartDescription(process.Name + "Result", text)
		{
			Type = typeof(WebData)
		};
		operationDescription.Messages.Add(messageDescription2);
		operationDescription.Behaviors.Add(new OperationInvoker(process));
		operationDescription.Behaviors.Add(new OperationBehaviorAttribute());
		operationDescription.Behaviors.Add(new DataContractSerializerOperationBehavior(operationDescription));
		operationDescription.Behaviors.Add(new AuthorizeOperationBehavior());
		Type typeFromHandle = typeof(PublicServiceException);
		string name = typeFromHandle.Name + "Fault";
		FaultDescription item2 = new FaultDescription(text + "/" + process.Name)
		{
			Namespace = text,
			DetailType = typeFromHandle,
			Name = name
		};
		operationDescription.Faults.Add(item2);
		return operationDescription;
	}
}
