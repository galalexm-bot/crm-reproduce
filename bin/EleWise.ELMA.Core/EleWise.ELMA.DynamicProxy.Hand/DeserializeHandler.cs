using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.DynamicProxy.Handlers;

public sealed class DeserializeHandler : IMiddleware
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public System.Type taskType;

		internal bool _003CCall_003Eb__0(IDeserialization a)
		{
			return a.Check(taskType);
		}
	}

	[StructLayout(3)]
	private struct _003CCall_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InvocationContext invocationContext;

		private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

		public DeserializeHandler _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected O, but got Unknown
			int num = _003C_003E1__state;
			DeserializeHandler deserializeHandler = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				if (num != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass2_0();
					val = invocationContext.Next().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CCall_003Ed__2>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				val.GetResult();
				if (!(invocationContext.ReturnValue is Response response))
				{
					if (invocationContext.ReturnValue is GlobalFunctionResponse globalFunctionResponse)
					{
						invocationContext.ReturnValue = globalFunctionResponse.Result;
					}
				}
				else
				{
					string responseText = response.ResponseText;
					if (responseText == null)
					{
						invocationContext.ReturnValue = null;
					}
					else
					{
						System.Type[] genericArguments = invocationContext.Method.get_ReturnType().GetGenericArguments();
						System.Type typeFromHandle = typeof(void);
						_003C_003E8__1.taskType = ((genericArguments.Length != 0) ? genericArguments[0] : typeFromHandle);
						if (_003C_003E8__1.taskType != typeFromHandle)
						{
							try
							{
								IDeserialization deserialization = Enumerable.First<IDeserialization>(deserializeHandler.deserializations, (Func<IDeserialization, bool>)((IDeserialization a) => a.Check(_003C_003E8__1.taskType)));
								invocationContext.ReturnValue = deserialization.Deserialize(_003C_003E8__1.taskType, responseText);
							}
							catch (ArgumentException)
							{
								throw;
							}
							catch (System.Exception ex)
							{
								throw new System.Exception(SR.T("Ошибка при десериализации объекта в тип {0}", _003C_003E8__1.taskType.get_FullName()), ex);
							}
						}
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

	private readonly System.Collections.Generic.IEnumerable<IDeserialization> deserializations;

	public DeserializeHandler(System.Collections.Generic.IEnumerable<IDeserialization> deserializations)
	{
		this.deserializations = deserializations;
	}

	public System.Threading.Tasks.Task Call(InvocationContext invocationContext)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CCall_003Ed__2 _003CCall_003Ed__ = default(_003CCall_003Ed__2);
		_003CCall_003Ed__._003C_003E4__this = this;
		_003CCall_003Ed__.invocationContext = invocationContext;
		_003CCall_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CCall_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CCall_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CCall_003Ed__2>(ref _003CCall_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CCall_003Ed__._003C_003Et__builder)).get_Task();
	}
}
