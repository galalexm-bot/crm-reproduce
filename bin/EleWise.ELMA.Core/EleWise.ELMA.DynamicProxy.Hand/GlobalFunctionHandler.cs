using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Api;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.DynamicProxy.Handlers;

internal sealed class GlobalFunctionHandler : IMiddleware
{
	[StructLayout(3)]
	private struct _003CCall_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GlobalFunctionHandler _003C_003E4__this;

		public InvocationContext invocationContext;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected O, but got Unknown
			int num = _003C_003E1__state;
			GlobalFunctionHandler globalFunctionHandler = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				TaskAwaiter<GlobalFunctionResponse> val2;
				if (num != 0)
				{
					if (num == 1)
					{
						val = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_00e2;
					}
					val2 = globalFunctionHandler.Request(invocationContext).GetAwaiter();
					if (!val2.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<GlobalFunctionResponse>, _003CCall_003Ed__4>(ref val2, ref this);
						return;
					}
				}
				else
				{
					val2 = (TaskAwaiter<GlobalFunctionResponse>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				GlobalFunctionResponse result = val2.GetResult();
				if (result == null)
				{
					val = invocationContext.Next().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CCall_003Ed__4>(ref val, ref this);
						return;
					}
					goto IL_00e2;
				}
				invocationContext.ReturnValue = result;
				goto end_IL_000e;
				IL_00e2:
				val.GetResult();
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

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public GlobalFunctionExecutionContext globalFunctionExecutionContext;

		internal bool _003CRequest_003Eb__0(IServerActionExecutionHandler a)
		{
			return a.Check(globalFunctionExecutionContext);
		}
	}

	[StructLayout(3)]
	private struct _003CRequest_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<GlobalFunctionResponse> _003C_003Et__builder;

		public InvocationContext invocationContext;

		public GlobalFunctionHandler _003C_003E4__this;

		private GlobalFunctionResponse _003Cresult_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Expected O, but got Unknown
			//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c2: Expected O, but got Unknown
			int num = _003C_003E1__state;
			GlobalFunctionHandler globalFunctionHandler = _003C_003E4__this;
			GlobalFunctionResponse result;
			try
			{
				TaskAwaiter<object> val2;
				TaskAwaiter val;
				object result2;
				switch (num)
				{
				default:
				{
					_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
					MethodInfo method = invocationContext.Method;
					System.Type returnType = method.get_ReturnType();
					System.Type[] genericArguments = returnType.GetGenericArguments();
					System.Type type = ((genericArguments.Length != 0) ? genericArguments[0] : typeof(void));
					GlobalFunctionAttribute attribute = AttributeHelper<GlobalFunctionAttribute>.GetAttribute((MemberInfo)(object)method, inherited: false);
					CS_0024_003C_003E8__locals0.globalFunctionExecutionContext = null;
					if (attribute != null)
					{
						if (!ApiProvider.IsTask(returnType))
						{
							throw new System.Exception(SR.T("Метод должен Возвращать System.Threading.Tasks.Task`1"));
						}
						Guid functionUid = attribute.FunctionUid;
						Signature returnType2 = new Signature();
						if (type != typeof(void))
						{
							returnType2 = globalFunctionHandler.ToSignature(type);
						}
						Signature parameterType = new Signature();
						System.Type[] parameterTypes = ((MethodBase)method).get_ParameterTypes();
						if (parameterTypes.Length > 1)
						{
							throw new System.Exception("Глобальные функции могут принимать только один параметр");
						}
						foreach (System.Type type2 in parameterTypes)
						{
							parameterType = globalFunctionHandler.ToSignature(type2);
						}
						CS_0024_003C_003E8__locals0.globalFunctionExecutionContext = new GlobalFunctionExecutionContext(functionUid, returnType2, parameterType);
					}
					if (CS_0024_003C_003E8__locals0.globalFunctionExecutionContext != null)
					{
						object[] arguments = invocationContext.Arguments;
						IServerActionExecutionHandler serverActionExecutionHandler = Enumerable.FirstOrDefault<IServerActionExecutionHandler>(globalFunctionHandler.actionExecutionHandlers, (Func<IServerActionExecutionHandler, bool>)((IServerActionExecutionHandler a) => a.Check(CS_0024_003C_003E8__locals0.globalFunctionExecutionContext)));
						_003Cresult_003E5__2 = new GlobalFunctionResponse();
						if (type != typeof(void))
						{
							IServerActionExecutionHandlerServices serverActionExecutionHandlerServices = (IServerActionExecutionHandlerServices)serverActionExecutionHandler;
							if (arguments.Length == 0)
							{
								val2 = ((IAbstractServerActionExecutionHandlerWrapperWithResult)Activator.CreateInstance(typeof(AbstractServerActionExecutionHandlerWrapperWithResult<>).MakeGenericType(new System.Type[1] { type }), new object[4] { serverActionExecutionHandlerServices.ProxyGeneratorService, serverActionExecutionHandlerServices.ActionExecutionService, serverActionExecutionHandlerServices.FindComponentService, serverActionExecutionHandlerServices.ExtendEntityService })).Execute(serverActionExecutionHandler, CS_0024_003C_003E8__locals0.globalFunctionExecutionContext).GetAwaiter();
								if (!val2.get_IsCompleted())
								{
									num = (_003C_003E1__state = 0);
									_003C_003Eu__1 = val2;
									_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<object>, _003CRequest_003Ed__5>(ref val2, ref this);
									return;
								}
								goto IL_021e;
							}
							val2 = ((IAbstractServerActionExecutionHandlerWrapperWithParameterAndResult)Activator.CreateInstance(typeof(AbstractServerActionExecutionHandlerWrapperWithParameterAndResult<, >).MakeGenericType(new System.Type[2]
							{
								type,
								((MethodBase)method).get_ParameterTypes()[0]
							}), new object[4] { serverActionExecutionHandlerServices.ProxyGeneratorService, serverActionExecutionHandlerServices.ActionExecutionService, serverActionExecutionHandlerServices.FindComponentService, serverActionExecutionHandlerServices.ExtendEntityService })).Execute(serverActionExecutionHandler, CS_0024_003C_003E8__locals0.globalFunctionExecutionContext, arguments[0]).GetAwaiter();
							if (!val2.get_IsCompleted())
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__1 = val2;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<object>, _003CRequest_003Ed__5>(ref val2, ref this);
								return;
							}
							goto IL_02ec;
						}
						if (arguments.Length == 0)
						{
							val = serverActionExecutionHandler.Execute(CS_0024_003C_003E8__locals0.globalFunctionExecutionContext).GetAwaiter();
							if (!val.get_IsCompleted())
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__1 = val;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter, _003CRequest_003Ed__5>(ref val, ref this);
								return;
							}
							goto IL_036a;
						}
						val = serverActionExecutionHandler.Execute(CS_0024_003C_003E8__locals0.globalFunctionExecutionContext, arguments[0]).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter, _003CRequest_003Ed__5>(ref val, ref this);
							return;
						}
						goto IL_03d2;
					}
					result = null;
					break;
				}
				case 0:
					val2 = (TaskAwaiter<object>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_021e;
				case 1:
					val2 = (TaskAwaiter<object>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_02ec;
				case 2:
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_036a;
				case 3:
					{
						val = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_03d2;
					}
					IL_03d2:
					val.GetResult();
					goto IL_03d9;
					IL_02ec:
					result2 = val2.GetResult();
					goto IL_02f5;
					IL_02f5:
					_003Cresult_003E5__2.Result = result2;
					goto IL_03d9;
					IL_021e:
					result2 = val2.GetResult();
					goto IL_02f5;
					IL_03d9:
					result = _003Cresult_003E5__2;
					break;
					IL_036a:
					val.GetResult();
					goto IL_03d9;
				}
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

	private readonly System.Collections.Generic.IEnumerable<IServerActionExecutionHandler> actionExecutionHandlers;

	private readonly IDescriptorService descriptorService;

	private readonly ISystemProxyMetadataReferencesStorage systemMetadataReferencesStorage;

	public GlobalFunctionHandler(System.Collections.Generic.IEnumerable<IServerActionExecutionHandler> actionExecutionHandlers, IDescriptorService descriptorService, ISystemProxyMetadataReferencesStorage systemMetadataReferencesStorage)
	{
		this.actionExecutionHandlers = actionExecutionHandlers;
		this.descriptorService = descriptorService;
		this.systemMetadataReferencesStorage = systemMetadataReferencesStorage;
	}

	public System.Threading.Tasks.Task Call(InvocationContext invocationContext)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CCall_003Ed__4 _003CCall_003Ed__ = default(_003CCall_003Ed__4);
		_003CCall_003Ed__._003C_003E4__this = this;
		_003CCall_003Ed__.invocationContext = invocationContext;
		_003CCall_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CCall_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CCall_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CCall_003Ed__4>(ref _003CCall_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CCall_003Ed__._003C_003Et__builder)).get_Task();
	}

	private System.Threading.Tasks.Task<GlobalFunctionResponse> Request(InvocationContext invocationContext)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CRequest_003Ed__5 _003CRequest_003Ed__ = default(_003CRequest_003Ed__5);
		_003CRequest_003Ed__._003C_003E4__this = this;
		_003CRequest_003Ed__.invocationContext = invocationContext;
		_003CRequest_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<GlobalFunctionResponse>.Create();
		_003CRequest_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<GlobalFunctionResponse> _003C_003Et__builder = _003CRequest_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CRequest_003Ed__5>(ref _003CRequest_003Ed__);
		return _003CRequest_003Ed__._003C_003Et__builder.get_Task();
	}

	private Signature ToSignature(System.Type type)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		Signature signature = new Signature();
		if (type == typeof(void))
		{
			return signature;
		}
		if (type.IsNullableType())
		{
			signature.Nullable = true;
			type = type.GetNonNullableType();
		}
		else
		{
			signature.Nullable = false;
		}
		signature.RelationType = 0;
		if (type.get_IsGenericType())
		{
			System.Type genericTypeDefinition = type.GetGenericTypeDefinition();
			if (typeof(System.Collections.Generic.ICollection<>).IsAssignableFrom(genericTypeDefinition) || typeof(System.Collections.Generic.IEnumerable<>).IsAssignableFrom(genericTypeDefinition))
			{
				signature.RelationType = 2;
				type = Enumerable.FirstOrDefault<System.Type>((System.Collections.Generic.IEnumerable<System.Type>)type.GetGenericArguments());
			}
		}
		else if (type.get_IsArray())
		{
			signature.RelationType = 2;
			type = type.GetElementType();
		}
		if (type.get_IsInterface())
		{
			signature.TypeUid = DataClassDescriptor.UID;
			string metadataUid = systemMetadataReferencesStorage.GetMetadataUid(type.get_FullName());
			signature.SubTypeUid = new Guid(metadataUid);
		}
		else if (type.get_IsClass() && Script.Write<bool>("type.$$name === \"EleWise.ELMA.DTO.ProxyType\"", new object[0]))
		{
			ProxyType proxyType = ObjectExtensions.As<ProxyType>((object)type);
			signature.TypeUid = DataClassDescriptor.UID;
			signature.SubTypeUid = proxyType.Type;
		}
		else if (type.get_IsEnum())
		{
			signature.TypeUid = EnumDescriptor.UID;
		}
		else
		{
			ITypeDescriptor typeDescriptor = descriptorService.GetTypeDescriptor(type);
			if (typeDescriptor != null)
			{
				signature.TypeUid = typeDescriptor.Uid;
				signature.SubTypeUid = typeDescriptor.SubTypeUid;
			}
		}
		return signature;
	}
}
