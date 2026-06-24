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
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Api.Services.Internal;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Models;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.ExtensionPoints;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.DTO;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Model.Actions;

internal class AbstractServerActionExecutionHandlerWrapperBase
{
	[StructLayout(3)]
	private struct _003CProcessResult_003Ed__8<TResult> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TResult> _003C_003Et__builder;

		public object result;

		public ActionExecutionRequestDto requestDto;

		public AbstractServerActionExecutionHandlerWrapperBase _003C_003E4__this;

		private void MoveNext()
		{
			AbstractServerActionExecutionHandlerWrapperBase abstractServerActionExecutionHandlerWrapperBase = _003C_003E4__this;
			TResult val;
			try
			{
				if (result != null)
				{
					goto IL_003c;
				}
				if (requestDto.ReturnType.RelationType != 0)
				{
					result = new object[0];
					goto IL_003c;
				}
				val = default(TResult);
				goto end_IL_0007;
				IL_003c:
				if (typeof(TResult) == typeof(object))
				{
					val = ObjectExtensions.As<TResult>(result);
				}
				else if (typeof(TResult) == typeof(object[]))
				{
					val = Script.Write<TResult>("Object.values({0})", new object[1] { result });
				}
				else
				{
					TResult val2 = abstractServerActionExecutionHandlerWrapperBase.FromObjectToDeclaredType<TResult>(result);
					if (!((object)val2 is Entity entity))
					{
						if ((object)val2 is ReactiveProxy reactiveProxy)
						{
							reactiveProxy.Json = new object();
							reactiveProxy.Json.set_Item("$t", (object)reactiveProxy.TypeRef);
							ConvertHelper.Reconcile(val2, result);
						}
					}
					else if (entity.As<ReactiveProxy>().Json.get_Item("$id") != null)
					{
						object obj = ConvertHelper.Serialize(entity, new SerializationSettings
						{
							Mode = SerializationMode.Default,
							WriteReferences = true,
							UseOriginalReferencesIfExists = true
						});
						ConvertHelper.Reconcile(entity, obj, Script.Write<object>("globals.reconcileContext", new object[0]));
					}
					val = val2;
				}
				end_IL_0007:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(val);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private readonly FindComponentService findComponentService;

	private readonly ConvertContext context;

	protected readonly IExtendEntityService ExtendEntityService;

	protected readonly IProxyGeneratorService ProxyGeneratorService;

	public AbstractServerActionExecutionHandlerWrapperBase(FindComponentService findComponentService, IExtendEntityService extendEntityService, IProxyGeneratorService proxyGeneratorService)
	{
		this.findComponentService = findComponentService;
		ExtendEntityService = extendEntityService;
		ProxyGeneratorService = proxyGeneratorService;
		context = new ConvertContext
		{
			ExtendEntityService = extendEntityService,
			ProxyGeneratorService = proxyGeneratorService
		};
	}

	protected static ActionExecutionRequestDto CreateRequest(IActionExecutionContext context, IServerActionExecutionHandler handler)
	{
		return handler.CreateRequest(context);
	}

	protected ActionExecutionRequestDto CreateRequest(IServerActionExecutionHandler handler, IActionExecutionContext context, object parameter)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		ActionExecutionRequestDto actionExecutionRequestDto = CreateRequest(context, handler);
		if (actionExecutionRequestDto == null)
		{
			return null;
		}
		if (parameter == null)
		{
			goto IL_0106;
		}
		if (parameter is string text)
		{
			string text3 = (actionExecutionRequestDto.Parameter = text);
		}
		else
		{
			if (!(parameter is System.Collections.IEnumerable enumerable))
			{
				goto IL_0106;
			}
			System.Collections.IEnumerable enumerable2 = enumerable;
			if (actionExecutionRequestDto.ParameterType.TypeUid == ListOfSimpleTypeDescriptor.UID)
			{
				string[] array = new string[0];
				{
					System.Collections.IEnumerator enumerator = enumerable2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object current = enumerator.get_Current();
							string text4 = "\"" + SerializeValue(current) + "\"";
							ArrayExtensions.Push<string>(array, new string[1] { text4 });
						}
					}
					finally
					{
						System.IDisposable disposable = enumerator as System.IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
				}
				if (array.Length != 0)
				{
					actionExecutionRequestDto.Parameter = "[" + string.Join(",", array) + "]";
				}
				else
				{
					actionExecutionRequestDto.Parameter = "[]";
				}
			}
			else
			{
				actionExecutionRequestDto.Parameter = SerializeValue(parameter);
			}
		}
		goto IL_0113;
		IL_0106:
		actionExecutionRequestDto.Parameter = SerializeValue(parameter);
		goto IL_0113;
		IL_0113:
		return actionExecutionRequestDto;
	}

	protected System.Threading.Tasks.Task LoadAdditionalModules(ActionExecutionResponseDto responseDto)
	{
		ClientComponentModelDto[] additionalComponentModels = responseDto.AdditionalComponentModels;
		if (additionalComponentModels.Length != 0)
		{
			return findComponentService.LoadRuntimeMetadata((System.Collections.Generic.IEnumerable<ClientComponentModel>)Enumerable.Select<ClientComponentModelDto, ClientComponentModel>((System.Collections.Generic.IEnumerable<ClientComponentModelDto>)additionalComponentModels, (Func<ClientComponentModelDto, ClientComponentModel>)FindComponentService.MapClientComponentModelFromDto));
		}
		return System.Threading.Tasks.Task.get_CompletedTask();
	}

	protected unsafe System.Threading.Tasks.Task<TResult> ProcessResult<TResult>(ActionExecutionRequestDto requestDto, object result)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CProcessResult_003Ed__8<TResult> _003CProcessResult_003Ed__ = default(_003CProcessResult_003Ed__8<TResult>);
		_003CProcessResult_003Ed__._003C_003E4__this = this;
		_003CProcessResult_003Ed__.requestDto = requestDto;
		_003CProcessResult_003Ed__.result = result;
		_003CProcessResult_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<TResult>.Create();
		_003CProcessResult_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<TResult> _003C_003Et__builder = _003CProcessResult_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder<_003CProcessResult_003Ed__8<TResult>>*)(&_003C_003Et__builder))->Start<_003CProcessResult_003Ed__8<TResult>>(ref _003CProcessResult_003Ed__);
		return _003CProcessResult_003Ed__._003C_003Et__builder.get_Task();
	}

	internal TResult FromObjectToDeclaredType<TResult>(object res)
	{
		return Script.Write<TResult>("require('Convert').convert.FromObjectToDeclaredType({0}, TResult, {1})", new object[2] { res, context });
	}

	private string SerializeValue(object value)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (value is ComponentMetadataItem)
		{
			Guid val = new Guid("85a97708-d13a-403c-b13f-5de968ee9b90");
			((Guid)(ref val)).ToString("N");
		}
		object obj = Script.Write<object>("require('Convert').convert.FromObject({ v: {0} }, {$context: {1}})", new object[2] { value, context });
		if (obj is string result)
		{
			return result;
		}
		return JSON.Stringify(ConvertHelper.Serialize(obj, new SerializationSettings
		{
			WriteReferences = true
		}));
	}
}
internal sealed class AbstractServerActionExecutionHandlerWrapper : AbstractServerActionExecutionHandlerWrapperBase, IAbstractServerActionExecutionHandlerWrapper
{
	[StructLayout(3)]
	private struct _003CExecute_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IActionExecutionContext context;

		public IServerActionExecutionHandler handler;

		public AbstractServerActionExecutionHandlerWrapper _003C_003E4__this;

		private ActionExecutionResponseDto _003Cresult_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Expected O, but got Unknown
			int num = _003C_003E1__state;
			AbstractServerActionExecutionHandlerWrapper abstractServerActionExecutionHandlerWrapper = _003C_003E4__this;
			try
			{
				TaskAwaiter<ActionExecutionResponseDto> val;
				if (num == 0)
				{
					val = (TaskAwaiter<ActionExecutionResponseDto>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00a6;
				}
				TaskAwaiter val2;
				if (num == 1)
				{
					val2 = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_011f;
				}
				ActionExecutionRequestDto actionExecutionRequestDto = AbstractServerActionExecutionHandlerWrapperBase.CreateRequest(context, handler);
				if (actionExecutionRequestDto != null)
				{
					val = abstractServerActionExecutionHandlerWrapper.actionExecutionService.Execute(actionExecutionRequestDto, ScriptMethodInfoHelper.Deserialize(actionExecutionRequestDto.ScriptName)?.Name).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<ActionExecutionResponseDto>, _003CExecute_003Ed__2>(ref val, ref this);
						return;
					}
					goto IL_00a6;
				}
				goto end_IL_000e;
				IL_011f:
				val2.GetResult();
				if (!string.IsNullOrEmpty(_003Cresult_003E5__2.ExceptionMessage))
				{
					System.Exception ex = new System.Exception(_003Cresult_003E5__2.ExceptionMessage);
					_ = _003Cresult_003E5__2.ExceptionStackTrace;
					throw ex;
				}
				goto end_IL_000e;
				IL_00a6:
				ActionExecutionResponseDto actionExecutionResponseDto = (_003Cresult_003E5__2 = val.GetResult());
				if (_003Cresult_003E5__2 != null)
				{
					val2 = abstractServerActionExecutionHandlerWrapper.LoadAdditionalModules(_003Cresult_003E5__2).GetAwaiter();
					if (!val2.get_IsCompleted())
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = val2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CExecute_003Ed__2>(ref val2, ref this);
						return;
					}
					goto IL_011f;
				}
				end_IL_000e:;
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

	private readonly IActionExecutionService actionExecutionService;

	public AbstractServerActionExecutionHandlerWrapper(IProxyGeneratorService proxyGeneratorService, IActionExecutionService actionExecutionService, FindComponentService findComponentService, IExtendEntityService extendEntityService)
		: base(findComponentService, extendEntityService, proxyGeneratorService)
	{
		this.actionExecutionService = actionExecutionService;
	}

	public System.Threading.Tasks.Task Execute(IServerActionExecutionHandler handler, IActionExecutionContext context)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CExecute_003Ed__2 _003CExecute_003Ed__ = default(_003CExecute_003Ed__2);
		_003CExecute_003Ed__._003C_003E4__this = this;
		_003CExecute_003Ed__.handler = handler;
		_003CExecute_003Ed__.context = context;
		_003CExecute_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CExecute_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CExecute_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CExecute_003Ed__2>(ref _003CExecute_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CExecute_003Ed__._003C_003Et__builder)).get_Task();
	}
}
internal sealed class AbstractServerActionExecutionHandlerWrapperWithParameter<TParam> : AbstractServerActionExecutionHandlerWrapperBase, IAbstractServerActionExecutionHandlerWrapperWithParameter
{
	[StructLayout(3)]
	private struct _003CExecute_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AbstractServerActionExecutionHandlerWrapperWithParameter<TParam> _003C_003E4__this;

		public IServerActionExecutionHandler handler;

		public IActionExecutionContext context;

		public object parameter;

		private ActionExecutionResponseDto _003Cresult_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Expected O, but got Unknown
			int num = _003C_003E1__state;
			AbstractServerActionExecutionHandlerWrapperWithParameter<TParam> abstractServerActionExecutionHandlerWrapperWithParameter = _003C_003E4__this;
			try
			{
				TaskAwaiter<ActionExecutionResponseDto> val;
				if (num == 0)
				{
					val = (TaskAwaiter<ActionExecutionResponseDto>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00ad;
				}
				TaskAwaiter val2;
				if (num == 1)
				{
					val2 = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0126;
				}
				ActionExecutionRequestDto actionExecutionRequestDto = abstractServerActionExecutionHandlerWrapperWithParameter.CreateRequest(handler, context, parameter);
				if (actionExecutionRequestDto != null)
				{
					val = abstractServerActionExecutionHandlerWrapperWithParameter.actionExecutionService.Execute(actionExecutionRequestDto, ScriptMethodInfoHelper.Deserialize(actionExecutionRequestDto.ScriptName)?.Name).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<ActionExecutionResponseDto>, _003CExecute_003Ed__2>(ref val, ref this);
						return;
					}
					goto IL_00ad;
				}
				goto end_IL_000e;
				IL_0126:
				val2.GetResult();
				if (!string.IsNullOrEmpty(_003Cresult_003E5__2.ExceptionMessage))
				{
					System.Exception ex = new System.Exception(_003Cresult_003E5__2.ExceptionMessage);
					_ = _003Cresult_003E5__2.ExceptionStackTrace;
					throw ex;
				}
				goto end_IL_000e;
				IL_00ad:
				ActionExecutionResponseDto actionExecutionResponseDto = (_003Cresult_003E5__2 = val.GetResult());
				if (_003Cresult_003E5__2 != null)
				{
					val2 = abstractServerActionExecutionHandlerWrapperWithParameter.LoadAdditionalModules(_003Cresult_003E5__2).GetAwaiter();
					if (!val2.get_IsCompleted())
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = val2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CExecute_003Ed__2>(ref val2, ref this);
						return;
					}
					goto IL_0126;
				}
				end_IL_000e:;
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

	private readonly IActionExecutionService actionExecutionService;

	public AbstractServerActionExecutionHandlerWrapperWithParameter(IProxyGeneratorService proxyGeneratorService, IActionExecutionService actionExecutionService, FindComponentService findComponentService, IExtendEntityService extendEntityService)
		: base(findComponentService, extendEntityService, proxyGeneratorService)
	{
		this.actionExecutionService = actionExecutionService;
	}

	public System.Threading.Tasks.Task Execute(IServerActionExecutionHandler handler, IActionExecutionContext context, object parameter)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		_003CExecute_003Ed__2 _003CExecute_003Ed__ = default(_003CExecute_003Ed__2);
		_003CExecute_003Ed__._003C_003E4__this = this;
		_003CExecute_003Ed__.handler = handler;
		_003CExecute_003Ed__.context = context;
		_003CExecute_003Ed__.parameter = parameter;
		_003CExecute_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CExecute_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CExecute_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CExecute_003Ed__2>(ref _003CExecute_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CExecute_003Ed__._003C_003Et__builder)).get_Task();
	}
}
internal sealed class AbstractServerActionExecutionHandlerWrapperWithParameterAndResult<TResult, TParam> : AbstractServerActionExecutionHandlerWrapperBase, IAbstractServerActionExecutionHandlerWrapperWithParameterAndResult
{
	[StructLayout(3)]
	private struct _003CExecute_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

		public AbstractServerActionExecutionHandlerWrapperWithParameterAndResult<TResult, TParam> _003C_003E4__this;

		public IServerActionExecutionHandler handler;

		public IActionExecutionContext context;

		public object parameter;

		private ActionExecutionRequestDto _003Crequest_003E5__2;

		private ActionExecutionResponseDto _003Cresult_003E5__3;

		private object _003C_003Eu__1;

		private ExtendEntityServiceContext _003C_003E7__wrap3;

		private ProxyGeneratorServiceContext _003C_003E7__wrap4;

		private void MoveNext()
		{
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected O, but got Unknown
			int num = _003C_003E1__state;
			AbstractServerActionExecutionHandlerWrapperWithParameterAndResult<TResult, TParam> abstractServerActionExecutionHandlerWrapperWithParameterAndResult = _003C_003E4__this;
			object result;
			try
			{
				TaskAwaiter<ActionExecutionResponseDto> val2;
				TaskAwaiter val;
				ActionExecutionResponseDto actionExecutionResponseDto;
				switch (num)
				{
				default:
					_003Crequest_003E5__2 = abstractServerActionExecutionHandlerWrapperWithParameterAndResult.CreateRequest(handler, context, parameter);
					if (_003Crequest_003E5__2 != null)
					{
						val2 = abstractServerActionExecutionHandlerWrapperWithParameterAndResult.actionExecutionService.Execute(_003Crequest_003E5__2, ScriptMethodInfoHelper.Deserialize(_003Crequest_003E5__2.ScriptName)?.Name).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val2;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ActionExecutionResponseDto>, _003CExecute_003Ed__2>(ref val2, ref this);
							return;
						}
						goto IL_00d8;
					}
					result = default(TResult);
					goto end_IL_000e;
				case 0:
					val2 = (TaskAwaiter<ActionExecutionResponseDto>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00d8;
				case 1:
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0162;
				case 2:
					break;
					IL_0162:
					val.GetResult();
					if (!string.IsNullOrEmpty(_003Cresult_003E5__3.ExceptionMessage))
					{
						System.Exception ex = new System.Exception(_003Cresult_003E5__3.ExceptionMessage);
						_ = _003Cresult_003E5__3.ExceptionStackTrace;
						throw ex;
					}
					_003C_003E7__wrap3 = new ExtendEntityServiceContext(abstractServerActionExecutionHandlerWrapperWithParameterAndResult.ExtendEntityService);
					break;
					IL_00d8:
					actionExecutionResponseDto = (_003Cresult_003E5__3 = val2.GetResult());
					if (_003Cresult_003E5__3 != null)
					{
						val = abstractServerActionExecutionHandlerWrapperWithParameterAndResult.LoadAdditionalModules(_003Cresult_003E5__3).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter, _003CExecute_003Ed__2>(ref val, ref this);
							return;
						}
						goto IL_0162;
					}
					result = default(TResult);
					goto end_IL_000e;
				}
				try
				{
					if (num != 2)
					{
						_003C_003E7__wrap4 = new ProxyGeneratorServiceContext(abstractServerActionExecutionHandlerWrapperWithParameterAndResult.ProxyGeneratorService);
					}
					try
					{
						TaskAwaiter<TResult> val3;
						if (num != 2)
						{
							val3 = abstractServerActionExecutionHandlerWrapperWithParameterAndResult.ProcessResult<TResult>(_003Crequest_003E5__2, _003Cresult_003E5__3.Result).GetAwaiter();
							if (!val3.get_IsCompleted())
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__1 = val3;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<TResult>, _003CExecute_003Ed__2>(ref val3, ref this);
								return;
							}
						}
						else
						{
							val3 = (TaskAwaiter<TResult>)_003C_003Eu__1;
							_003C_003Eu__1 = null;
							num = (_003C_003E1__state = -1);
						}
						result = val3.GetResult();
					}
					finally
					{
						if (num < 0 && _003C_003E7__wrap4 != null)
						{
							((System.IDisposable)_003C_003E7__wrap4).Dispose();
						}
					}
				}
				finally
				{
					if (num < 0 && _003C_003E7__wrap3 != null)
					{
						((System.IDisposable)_003C_003E7__wrap3).Dispose();
					}
				}
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private readonly IActionExecutionService actionExecutionService;

	public AbstractServerActionExecutionHandlerWrapperWithParameterAndResult(IProxyGeneratorService proxyGeneratorService, IActionExecutionService actionExecutionService, FindComponentService findComponentService, IExtendEntityService extendEntityService)
		: base(findComponentService, extendEntityService, proxyGeneratorService)
	{
		this.actionExecutionService = actionExecutionService;
	}

	public System.Threading.Tasks.Task<object> Execute(IServerActionExecutionHandler handler, IActionExecutionContext context, object parameter)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		_003CExecute_003Ed__2 _003CExecute_003Ed__ = default(_003CExecute_003Ed__2);
		_003CExecute_003Ed__._003C_003E4__this = this;
		_003CExecute_003Ed__.handler = handler;
		_003CExecute_003Ed__.context = context;
		_003CExecute_003Ed__.parameter = parameter;
		_003CExecute_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		_003CExecute_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object> _003C_003Et__builder = _003CExecute_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CExecute_003Ed__2>(ref _003CExecute_003Ed__);
		return _003CExecute_003Ed__._003C_003Et__builder.get_Task();
	}
}
internal sealed class AbstractServerActionExecutionHandlerWrapperWithResult<TResult> : AbstractServerActionExecutionHandlerWrapperBase, IAbstractServerActionExecutionHandlerWrapperWithResult
{
	[StructLayout(3)]
	private struct _003CExecute_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

		public IActionExecutionContext context;

		public IServerActionExecutionHandler handler;

		public AbstractServerActionExecutionHandlerWrapperWithResult<TResult> _003C_003E4__this;

		private ActionExecutionRequestDto _003Crequest_003E5__2;

		private ActionExecutionResponseDto _003Cresult_003E5__3;

		private object _003C_003Eu__1;

		private ExtendEntityServiceContext _003C_003E7__wrap3;

		private ProxyGeneratorServiceContext _003C_003E7__wrap4;

		private void MoveNext()
		{
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Expected O, but got Unknown
			int num = _003C_003E1__state;
			AbstractServerActionExecutionHandlerWrapperWithResult<TResult> abstractServerActionExecutionHandlerWrapperWithResult = _003C_003E4__this;
			object result;
			try
			{
				TaskAwaiter<ActionExecutionResponseDto> val2;
				TaskAwaiter val;
				ActionExecutionResponseDto actionExecutionResponseDto;
				switch (num)
				{
				default:
					_003Crequest_003E5__2 = AbstractServerActionExecutionHandlerWrapperBase.CreateRequest(context, handler);
					if (_003Crequest_003E5__2 != null)
					{
						val2 = abstractServerActionExecutionHandlerWrapperWithResult.actionExecutionService.Execute(_003Crequest_003E5__2, ScriptMethodInfoHelper.Deserialize(_003Crequest_003E5__2.ScriptName)?.Name).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val2;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ActionExecutionResponseDto>, _003CExecute_003Ed__2>(ref val2, ref this);
							return;
						}
						goto IL_00d1;
					}
					result = default(TResult);
					goto end_IL_000e;
				case 0:
					val2 = (TaskAwaiter<ActionExecutionResponseDto>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00d1;
				case 1:
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_015b;
				case 2:
					break;
					IL_015b:
					val.GetResult();
					if (!string.IsNullOrEmpty(_003Cresult_003E5__3.ExceptionMessage))
					{
						System.Exception ex = new System.Exception(_003Cresult_003E5__3.ExceptionMessage);
						_ = _003Cresult_003E5__3.ExceptionStackTrace;
						throw ex;
					}
					_003C_003E7__wrap3 = new ExtendEntityServiceContext(abstractServerActionExecutionHandlerWrapperWithResult.ExtendEntityService);
					break;
					IL_00d1:
					actionExecutionResponseDto = (_003Cresult_003E5__3 = val2.GetResult());
					if (_003Cresult_003E5__3 != null)
					{
						val = abstractServerActionExecutionHandlerWrapperWithResult.LoadAdditionalModules(_003Cresult_003E5__3).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter, _003CExecute_003Ed__2>(ref val, ref this);
							return;
						}
						goto IL_015b;
					}
					result = default(TResult);
					goto end_IL_000e;
				}
				try
				{
					if (num != 2)
					{
						_003C_003E7__wrap4 = new ProxyGeneratorServiceContext(abstractServerActionExecutionHandlerWrapperWithResult.ProxyGeneratorService);
					}
					try
					{
						TaskAwaiter<TResult> val3;
						if (num != 2)
						{
							val3 = abstractServerActionExecutionHandlerWrapperWithResult.ProcessResult<TResult>(_003Crequest_003E5__2, _003Cresult_003E5__3.Result).GetAwaiter();
							if (!val3.get_IsCompleted())
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__1 = val3;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<TResult>, _003CExecute_003Ed__2>(ref val3, ref this);
								return;
							}
						}
						else
						{
							val3 = (TaskAwaiter<TResult>)_003C_003Eu__1;
							_003C_003Eu__1 = null;
							num = (_003C_003E1__state = -1);
						}
						result = val3.GetResult();
					}
					finally
					{
						if (num < 0 && _003C_003E7__wrap4 != null)
						{
							((System.IDisposable)_003C_003E7__wrap4).Dispose();
						}
					}
				}
				finally
				{
					if (num < 0 && _003C_003E7__wrap3 != null)
					{
						((System.IDisposable)_003C_003E7__wrap3).Dispose();
					}
				}
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private readonly IActionExecutionService actionExecutionService;

	public AbstractServerActionExecutionHandlerWrapperWithResult(IProxyGeneratorService proxyGeneratorService, IActionExecutionService actionExecutionService, FindComponentService findComponentService, IExtendEntityService extendEntityService)
		: base(findComponentService, extendEntityService, proxyGeneratorService)
	{
		this.actionExecutionService = actionExecutionService;
	}

	public System.Threading.Tasks.Task<object> Execute(IServerActionExecutionHandler handler, IActionExecutionContext context)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CExecute_003Ed__2 _003CExecute_003Ed__ = default(_003CExecute_003Ed__2);
		_003CExecute_003Ed__._003C_003E4__this = this;
		_003CExecute_003Ed__.handler = handler;
		_003CExecute_003Ed__.context = context;
		_003CExecute_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		_003CExecute_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object> _003C_003Et__builder = _003CExecute_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CExecute_003Ed__2>(ref _003CExecute_003Ed__);
		return _003CExecute_003Ed__._003C_003Et__builder.get_Task();
	}
}
[Component]
internal abstract class AbstractServerActionExecutionHandler : IServerActionExecutionHandler, IActionExecutionHandler, IServerActionExecutionHandlerServices
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public IDependencyHackList dependencyHackItem;

		internal EntityTypeSerializationSettingsDto _003CGetEntityTypeSerializationSettings_003Eb__1(Guid type)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return new EntityTypeSerializationSettingsDto
			{
				TypeUid = type,
				Properties = Enumerable.Select<ValueTuple<Guid, string>, string>((System.Collections.Generic.IEnumerable<ValueTuple<Guid, string>>)dependencyHackItem.Properties, (Func<ValueTuple<Guid, string>, string>)((ValueTuple<Guid, string> a) => a.Item2)).ToArray()
			};
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ValueTuple<Guid, string>, string> _003C_003E9__14_2;

		internal string _003CGetEntityTypeSerializationSettings_003Eb__14_2(ValueTuple<Guid, string> a)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return a.Item2;
		}
	}

	private readonly IActionExecutionService actionExecutionService;

	private readonly IExtendEntityService extendEntityService;

	private readonly ICurrentPageService currentPageService;

	protected readonly FindComponentService findComponentService;

	private readonly IProxyGeneratorService proxyGeneratorService;

	private readonly System.Collections.Generic.IEnumerable<IDependencyHackList> dependencyHackList;

	private readonly IApplicationData applicationData;

	IActionExecutionService IServerActionExecutionHandlerServices.ActionExecutionService => actionExecutionService;

	IProxyGeneratorService IServerActionExecutionHandlerServices.ProxyGeneratorService => proxyGeneratorService;

	FindComponentService IServerActionExecutionHandlerServices.FindComponentService => findComponentService;

	IExtendEntityService IServerActionExecutionHandlerServices.ExtendEntityService => extendEntityService;

	protected AbstractServerActionExecutionHandler(IActionExecutionService actionExecutionService, IExtendEntityService extendEntityService, ICurrentPageService currentPageService, FindComponentService findComponentService, IProxyGeneratorService proxyGeneratorService, System.Collections.Generic.IEnumerable<IDependencyHackList> dependencyHackList, IApplicationData applicationData)
	{
		this.actionExecutionService = actionExecutionService;
		this.extendEntityService = extendEntityService;
		this.currentPageService = currentPageService;
		this.findComponentService = findComponentService;
		this.proxyGeneratorService = proxyGeneratorService;
		this.dependencyHackList = dependencyHackList;
		this.applicationData = applicationData;
	}

	public abstract bool Check(IActionExecutionContext context);

	public System.Threading.Tasks.Task Execute(IActionExecutionContext context)
	{
		return new AbstractServerActionExecutionHandlerWrapper(proxyGeneratorService, actionExecutionService, findComponentService, extendEntityService).Execute(this, context);
	}

	public System.Threading.Tasks.Task<TResult> Execute<TResult>(IActionExecutionContext context)
	{
		return ObjectExtensions.As<System.Threading.Tasks.Task<TResult>>((object)new AbstractServerActionExecutionHandlerWrapperWithResult<TResult>(proxyGeneratorService, actionExecutionService, findComponentService, extendEntityService).Execute(this, context));
	}

	public System.Threading.Tasks.Task Execute<TParam>(IActionExecutionContext context, TParam parameter)
	{
		return new AbstractServerActionExecutionHandlerWrapperWithParameter<TParam>(proxyGeneratorService, actionExecutionService, findComponentService, extendEntityService).Execute(this, context, parameter);
	}

	public System.Threading.Tasks.Task<TResult> Execute<TParam, TResult>(IActionExecutionContext context, TParam parameter)
	{
		return ObjectExtensions.As<System.Threading.Tasks.Task<TResult>>((object)new AbstractServerActionExecutionHandlerWrapperWithParameterAndResult<TResult, TParam>(proxyGeneratorService, actionExecutionService, findComponentService, extendEntityService).Execute(this, context, parameter));
	}

	public abstract ActionExecutionRequestDto CreateRequest(IActionExecutionContext context);

	protected EntityTypeSerializationSettingsDto[] GetEntityTypeSerializationSettings()
	{
		if (applicationData.InterfaceBuilderMode == InterfaceBuilderMode.DevServer)
		{
			return new EntityTypeSerializationSettingsDto[0];
		}
		EntityDependency[] array = Enumerable.ToArray<EntityDependency>(currentPageService.GetEntityDependencies());
		if (array.Length == 0)
		{
			List<EntityTypeSerializationSettingsDto> val = new List<EntityTypeSerializationSettingsDto>();
			System.Collections.Generic.IEnumerator<IDependencyHackList> enumerator = dependencyHackList.GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
					CS_0024_003C_003E8__locals0.dependencyHackItem = enumerator.get_Current();
					val.AddRange((System.Collections.Generic.IEnumerable<EntityTypeSerializationSettingsDto>)Enumerable.Select<Guid, EntityTypeSerializationSettingsDto>((System.Collections.Generic.IEnumerable<Guid>)CS_0024_003C_003E8__locals0.dependencyHackItem.TypeUids, (Func<Guid, EntityTypeSerializationSettingsDto>)((Guid type) => new EntityTypeSerializationSettingsDto
					{
						TypeUid = type,
						Properties = Enumerable.Select<ValueTuple<Guid, string>, string>((System.Collections.Generic.IEnumerable<ValueTuple<Guid, string>>)CS_0024_003C_003E8__locals0.dependencyHackItem.Properties, (Func<ValueTuple<Guid, string>, string>)((ValueTuple<Guid, string> a) => a.Item2)).ToArray()
					})));
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			return val.ToArray();
		}
		return Enumerable.Select<EntityDependency, EntityTypeSerializationSettingsDto>((System.Collections.Generic.IEnumerable<EntityDependency>)array, (Func<EntityDependency, EntityTypeSerializationSettingsDto>)((EntityDependency dependency) => new EntityTypeSerializationSettingsDto
		{
			TypeUid = ((Dependency)dependency).get_HeaderUid(),
			Properties = dependency.GetProperties(dependencyHackList)
		})).ToArray();
	}

	private EntityTypeSerializationSettingsDto _003CGetEntityTypeSerializationSettings_003Eb__14_0(EntityDependency dependency)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return new EntityTypeSerializationSettingsDto
		{
			TypeUid = ((Dependency)dependency).get_HeaderUid(),
			Properties = dependency.GetProperties(dependencyHackList)
		};
	}
}
