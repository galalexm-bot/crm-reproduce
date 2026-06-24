using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using Bridge.Html5;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Dispatcher;

[Component]
internal sealed class StartProcessAsyncCommandHandler : AbstractAsyncCommandHandler
{
	[StructLayout(3)]
	private struct _003CHandleAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionCommand command;

		public StartProcessAsyncCommandHandler _003C_003E4__this;

		private void MoveNext()
		{
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			StartProcessAsyncCommandHandler startProcessAsyncCommandHandler = _003C_003E4__this;
			try
			{
				if (!(command.ActionTypeId != "StartProcessAsyncTypeCommand"))
				{
					IViewModel viewModel = command.Args[0] as IViewModel;
					if (viewModel?.RenderOwner != null && command.Args[1] is object[] array && array[0] is StartProcessModel startProcessModel)
					{
						ValueTuple<ReactiveProxy, bool> val = startProcessAsyncCommandHandler.GenerateContext(startProcessModel, viewModel.RenderOwner);
						ReactiveProxy item = val.Item1;
						bool item2 = val.Item2;
						object obj = ConvertContext(item);
						RunProcess(startProcessModel.ProcessHeaderId, JSON.Stringify(obj), item2);
					}
				}
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
		}
	}

	private readonly IProxyGeneratorService proxyGeneratorService;

	private readonly IDescriptorService descriptorService;

	private readonly IMetadataServiceContext metadataServiceContext;

	private readonly IExtendEntityService extendEntityService;

	public StartProcessAsyncCommandHandler(IProxyGeneratorService proxyGeneratorService, IDescriptorService descriptorService, IMetadataServiceContext metadataServiceContext, IExtendEntityService extendEntityService)
	{
		this.proxyGeneratorService = proxyGeneratorService;
		this.descriptorService = descriptorService;
		this.metadataServiceContext = metadataServiceContext;
		this.extendEntityService = extendEntityService;
	}

	public override System.Threading.Tasks.Task HandleAsync(ActionCommand command)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CHandleAsync_003Ed__5 _003CHandleAsync_003Ed__ = default(_003CHandleAsync_003Ed__5);
		_003CHandleAsync_003Ed__._003C_003E4__this = this;
		_003CHandleAsync_003Ed__.command = command;
		_003CHandleAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CHandleAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CHandleAsync_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CHandleAsync_003Ed__5>(ref _003CHandleAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CHandleAsync_003Ed__._003C_003Et__builder)).get_Task();
	}

	[Template("{@}({id}, {paramsJson}, undefined, undefined, undefined, {disableRedirect})")]
	private static extern void RunProcess(long id, string paramsJson, bool disableRedirect);

	private ValueTuple<ReactiveProxy, bool> GenerateContext(StartProcessModel model, IViewModel viewModel)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		ReactiveProxy reactiveProxy = proxyGeneratorService.GenerateProxy((ClassMetadata)(object)model.ContextMetadata);
		Enumerator<InputComputedValue> enumerator = Enumerable.OfType<InputComputedValue>((System.Collections.IEnumerable)(object)model.DynamicProperties).ToList().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				InputComputedValue current = enumerator.get_Current();
				string text = current.Name.Replace("Input___", "");
				object dynamicPropertyValue = GetDynamicPropertyValue(current, viewModel.Controller, viewModel, descriptorService, metadataServiceContext, extendEntityService, proxyGeneratorService);
				if (text == "DisableRedirect")
				{
					flag = bool.Parse(dynamicPropertyValue.ToString());
				}
				else
				{
					reactiveProxy.SetPlainPropertyValue(text, dynamicPropertyValue);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return new ValueTuple<ReactiveProxy, bool>(reactiveProxy, flag);
	}

	internal static object GetDynamicPropertyValue(InputComputedValue dynamicProperty, IController controller, IViewModel viewModel, IDescriptorService descriptorService, IMetadataServiceContext metadataServiceContext, IExtendEntityService extendEntityService, IProxyGeneratorService proxyGeneratorService)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		switch (dynamicProperty.ComputedValueType)
		{
		case 0:
			return ComputedValueHelper.GetValue(descriptorService, dynamicProperty.TypeUid, dynamicProperty.Value, new ConvertContext
			{
				ExtendEntityService = extendEntityService,
				ProxyGeneratorService = proxyGeneratorService
			}, dynamicProperty.Nullable);
		case 3:
			if (!(viewModel is IMetadataViewModel viewModel2))
			{
				return null;
			}
			return viewModel2.GetPropertyContext<object>(metadataServiceContext, dynamicProperty.PropertyUid, Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)dynamicProperty.PropertyParents)).Invoke();
		case 1:
		case 2:
			return ViewModelHelper.CallControllerMethod(controller, dynamicProperty.MethodName, null);
		default:
			return null;
		}
	}

	private static object ConvertContext(ReactiveProxy processContext)
	{
		object obj = new object();
		System.Collections.Generic.IEnumerator<PropertyMetadata> enumerator = ((System.Collections.Generic.IEnumerable<PropertyMetadata>)processContext.Metadata.get_Properties()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				PropertyMetadata current = enumerator.get_Current();
				object plainPropertyValue = processContext.Json.GetPlainPropertyValue(((INamedMetadata)current).get_Name());
				TypeSettings settings = ((IPropertyMetadata)current).get_Settings();
				EntitySettings val;
				if ((val = (EntitySettings)(object)((settings is EntitySettings) ? settings : null)) != null)
				{
					if (plainPropertyValue == null)
					{
						continue;
					}
					if (val.get_RelationType() == 0)
					{
						object plainPropertyValue2 = plainPropertyValue.GetPlainPropertyValue("Id");
						obj.SetAndCreatePlainPropertyValue(((INamedMetadata)current).get_Name() + ".Id", plainPropertyValue2);
						continue;
					}
					int num = 0;
					{
						System.Collections.IEnumerator enumerator2 = ((System.Collections.IEnumerable)plainPropertyValue).GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								object plainPropertyValue3 = enumerator2.get_Current().GetPlainPropertyValue("Id");
								obj.SetAndCreatePlainPropertyValue($"{((INamedMetadata)current).get_Name()}[{num}].Id", plainPropertyValue3);
								num++;
							}
						}
						finally
						{
							System.IDisposable disposable = enumerator2 as System.IDisposable;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
					}
				}
				else
				{
					obj.SetAndCreatePlainPropertyValue(((INamedMetadata)current).get_Name(), plainPropertyValue);
				}
			}
			return obj;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}
}
