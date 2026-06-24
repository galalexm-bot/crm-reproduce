using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Core.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Model.Actions;

[Component]
internal sealed class ClientFunctionExecutionHandler : IActionExecutionHandler
{
	[StructLayout(3)]
	private struct _003CExecute_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IActionExecutionContext context;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter val;
				if (num == 0)
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00b2;
				}
				ValueTuple<IController, string, object[]> executionInfo = GetExecutionInfo(context);
				IController item = executionInfo.Item1;
				string item2 = executionInfo.Item2;
				object[] item3 = executionInfo.Item3;
				if (item != null && item2 != null)
				{
					object obj = ((object)item).get_Item(item2);
					Action val2 = (Action)((obj is Action) ? obj : null);
					if (val2 != null && ((System.Delegate)(object)val2).Apply((object)item, (System.Array)item3) is System.Threading.Tasks.Task task)
					{
						val = task.GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CExecute_003Ed__1>(ref val, ref this);
							return;
						}
						goto IL_00b2;
					}
				}
				goto end_IL_0007;
				IL_00b2:
				val.GetResult();
				end_IL_0007:;
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

	[StructLayout(3)]
	private struct _003CExecute_003Ed__2<TResult> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TResult> _003C_003Et__builder;

		public IActionExecutionContext context;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			TResult result;
			try
			{
				TaskAwaiter<TResult> val;
				if (num == 0)
				{
					val = (TaskAwaiter<TResult>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00eb;
				}
				ValueTuple<IController, string, object[]> executionInfo = GetExecutionInfo(context);
				IController item = executionInfo.Item1;
				string item2 = executionInfo.Item2;
				object[] item3 = executionInfo.Item3;
				if (item == null || item2 == null)
				{
					result = default(TResult);
				}
				else
				{
					object obj = ((object)item).get_Item(item2);
					Action val2 = (Action)((obj is Action) ? obj : null);
					if (val2 == null)
					{
						result = default(TResult);
					}
					else
					{
						object obj2 = ((System.Delegate)(object)val2).Apply((object)item, (System.Array)item3);
						if (obj2 == null)
						{
							goto IL_00fa;
						}
						if (obj2 is System.Threading.Tasks.Task task)
						{
							val = ObjectExtensions.As<System.Threading.Tasks.Task<TResult>>((object)task).GetAwaiter();
							if (!val.get_IsCompleted())
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = val;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<TResult>, _003CExecute_003Ed__2<TResult>>(ref val, ref this);
								return;
							}
							goto IL_00eb;
						}
						if (!(obj2 is TResult val3))
						{
							goto IL_00fa;
						}
						result = val3;
					}
				}
				goto end_IL_0007;
				IL_00fa:
				result = default(TResult);
				goto end_IL_0007;
				IL_00eb:
				result = val.GetResult();
				end_IL_0007:;
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

	private sealed class _003C_003Ec__DisplayClass3_0<TParam>
	{
		public TParam parameter;

		internal object _003CExecute_003Eb__0()
		{
			return parameter;
		}
	}

	[StructLayout(3)]
	private struct _003CExecute_003Ed__3<TParam> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TParam parameter;

		public IActionExecutionContext context;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Expected O, but got Unknown
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter val;
				if (num == 0)
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00d1;
				}
				_003C_003Ec__DisplayClass3_0<TParam> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0<TParam>();
				CS_0024_003C_003E8__locals0.parameter = parameter;
				ValueTuple<IController, string, object[]> executionInfo = GetExecutionInfo(context, () => CS_0024_003C_003E8__locals0.parameter);
				IController item = executionInfo.Item1;
				string item2 = executionInfo.Item2;
				object[] item3 = executionInfo.Item3;
				if (item != null && item2 != null && ((object)item).get_Item(item2) is Action<TParam> val2 && ((System.Delegate)(object)val2).Apply((object)item, (System.Array)item3) is System.Threading.Tasks.Task task)
				{
					val = task.GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CExecute_003Ed__3<TParam>>(ref val, ref this);
						return;
					}
					goto IL_00d1;
				}
				goto end_IL_0007;
				IL_00d1:
				val.GetResult();
				end_IL_0007:;
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

	private sealed class _003C_003Ec__DisplayClass4_0<TParam, TResult>
	{
		public TParam parameter;

		internal object _003CExecute_003Eb__0()
		{
			return parameter;
		}
	}

	[StructLayout(3)]
	private struct _003CExecute_003Ed__4<TParam, TResult> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TResult> _003C_003Et__builder;

		public TParam parameter;

		public IActionExecutionContext context;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			TResult val2;
			try
			{
				TaskAwaiter<TResult> val;
				if (num == 0)
				{
					val = (TaskAwaiter<TResult>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_010b;
				}
				_003C_003Ec__DisplayClass4_0<TParam, TResult> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0<TParam, TResult>();
				CS_0024_003C_003E8__locals0.parameter = parameter;
				ValueTuple<IController, string, object[]> executionInfo = GetExecutionInfo(context, () => CS_0024_003C_003E8__locals0.parameter);
				IController item = executionInfo.Item1;
				string item2 = executionInfo.Item2;
				object[] item3 = executionInfo.Item3;
				if (item == null || item2 == null)
				{
					val2 = default(TResult);
				}
				else if (!(((object)item).get_Item(item2) is Action<TParam> val3))
				{
					val2 = default(TResult);
				}
				else
				{
					object obj = ((System.Delegate)(object)val3).Apply((object)item, (System.Array)item3);
					if (obj == null)
					{
						goto IL_011a;
					}
					if (obj is System.Threading.Tasks.Task task)
					{
						val = ((System.Threading.Tasks.Task<_003F>)(object)ObjectExtensions.As<System.Threading.Tasks.Task<TResult>>((object)task)).GetAwaiter();
						if (!((TaskAwaiter<_003F>)(object)val).get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							System.Runtime.CompilerServices.Unsafe.As<AsyncTaskMethodBuilder<TResult>, AsyncTaskMethodBuilder<_003F>>(ref _003C_003Et__builder).AwaitOnCompleted<TaskAwaiter<TResult>, _003CExecute_003Ed__4<TParam, TResult>>(ref val, ref this);
							return;
						}
						goto IL_010b;
					}
					if (!(obj is TResult val4))
					{
						goto IL_011a;
					}
					val2 = val4;
				}
				goto end_IL_0007;
				IL_011a:
				val2 = default(TResult);
				goto end_IL_0007;
				IL_010b:
				val2 = ((TaskAwaiter<_003F>)(object)val).GetResult();
				end_IL_0007:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				System.Runtime.CompilerServices.Unsafe.As<AsyncTaskMethodBuilder<TResult>, AsyncTaskMethodBuilder<_003F>>(ref _003C_003Et__builder).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			System.Runtime.CompilerServices.Unsafe.As<AsyncTaskMethodBuilder<TResult>, AsyncTaskMethodBuilder<_003F>>(ref _003C_003Et__builder).SetResult(val2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			System.Runtime.CompilerServices.Unsafe.As<AsyncTaskMethodBuilder<TResult>, AsyncTaskMethodBuilder<_003F>>(ref _003C_003Et__builder).SetStateMachine(stateMachine);
		}
	}

	private sealed class _003CUnwrapDataArray_003Ed__6 : System.Collections.Generic.IEnumerable<object>, System.Collections.IEnumerable, IBridgeClass, System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IDataStack data;

		public IDataStack _003C_003E3__data;

		private System.Collections.Generic.IEnumerator<DataStackItem> _003C_003E7__wrap1;

		object Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CUnwrapDataArray_003Ed__6(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.get_CurrentManagedThreadId();
		}

		[DebuggerHidden]
		void System.IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
		}

		private bool MoveNext()
		{
			try
			{
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					if (data == null)
					{
						return false;
					}
					_003C_003E7__wrap1 = Enumerable.Reverse<DataStackItem>((System.Collections.Generic.IEnumerable<DataStackItem>)data).GetEnumerator();
					_003C_003E1__state = -3;
					break;
				case 1:
					_003C_003E1__state = -3;
					break;
				}
				while (((System.Collections.IEnumerator)_003C_003E7__wrap1).MoveNext())
				{
					DataStackItem current = _003C_003E7__wrap1.get_Current();
					if (current?.Data != null)
					{
						_003C_003E2__current = current.Data.Item;
						_003C_003E1__state = 1;
						return true;
					}
				}
				_003C_003Em__Finally1();
				_003C_003E7__wrap1 = null;
				return false;
			}
			catch
			{
				//try-fault
				((System.IDisposable)this).Dispose();
				throw;
			}
		}

		bool System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				((System.IDisposable)_003C_003E7__wrap1).Dispose();
			}
		}

		[DebuggerHidden]
		void System.Collections.IEnumerator.Reset()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<object>.GetEnumerator()
		{
			_003CUnwrapDataArray_003Ed__6 _003CUnwrapDataArray_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.get_CurrentManagedThreadId())
			{
				_003C_003E1__state = 0;
				_003CUnwrapDataArray_003Ed__ = this;
			}
			else
			{
				_003CUnwrapDataArray_003Ed__ = new _003CUnwrapDataArray_003Ed__6(0);
			}
			_003CUnwrapDataArray_003Ed__.data = _003C_003E3__data;
			return _003CUnwrapDataArray_003Ed__;
		}

		[DebuggerHidden]
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return (System.Collections.IEnumerator)((System.Collections.Generic.IEnumerable<object>)this).GetEnumerator();
		}
	}

	public bool Check(IActionExecutionContext context)
	{
		return context.ActionExecutionType == ActionExecutionType.ClientFunction;
	}

	public System.Threading.Tasks.Task Execute(IActionExecutionContext context)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CExecute_003Ed__1 _003CExecute_003Ed__ = default(_003CExecute_003Ed__1);
		_003CExecute_003Ed__.context = context;
		_003CExecute_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CExecute_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CExecute_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CExecute_003Ed__1>(ref _003CExecute_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CExecute_003Ed__._003C_003Et__builder)).get_Task();
	}

	public unsafe System.Threading.Tasks.Task<TResult> Execute<TResult>(IActionExecutionContext context)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CExecute_003Ed__2<TResult> _003CExecute_003Ed__ = default(_003CExecute_003Ed__2<TResult>);
		_003CExecute_003Ed__.context = context;
		_003CExecute_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<TResult>.Create();
		_003CExecute_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<TResult> _003C_003Et__builder = _003CExecute_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder<_003CExecute_003Ed__2<TResult>>*)(&_003C_003Et__builder))->Start<_003CExecute_003Ed__2<TResult>>(ref _003CExecute_003Ed__);
		return _003CExecute_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task Execute<TParam>(IActionExecutionContext context, TParam parameter)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CExecute_003Ed__3<TParam> _003CExecute_003Ed__ = default(_003CExecute_003Ed__3<TParam>);
		_003CExecute_003Ed__.context = context;
		_003CExecute_003Ed__.parameter = parameter;
		_003CExecute_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CExecute_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CExecute_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CExecute_003Ed__3<TParam>>(ref _003CExecute_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CExecute_003Ed__._003C_003Et__builder)).get_Task();
	}

	public unsafe System.Threading.Tasks.Task<TResult> Execute<TParam, TResult>(IActionExecutionContext context, TParam parameter)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CExecute_003Ed__4<TParam, TResult> _003CExecute_003Ed__ = default(_003CExecute_003Ed__4<TParam, TResult>);
		_003CExecute_003Ed__.context = context;
		_003CExecute_003Ed__.parameter = parameter;
		_003CExecute_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<TResult>.Create();
		_003CExecute_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<TResult> _003C_003Et__builder = _003CExecute_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder<_003F>*)(&_003C_003Et__builder))->Start<_003CExecute_003Ed__4<TParam, TResult>>(ref _003CExecute_003Ed__);
		return _003CExecute_003Ed__._003C_003Et__builder.get_Task();
	}

	private static ValueTuple<IController, string, object[]> GetExecutionInfo(IActionExecutionContext context, Func<object> getParam = null)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		if (!(context is ClientFunctionExecutionContext clientFunctionExecutionContext) || string.IsNullOrEmpty(clientFunctionExecutionContext.MethodName))
		{
			return new ValueTuple<IController, string, object[]>((IController)null, (string)null, (object[])null);
		}
		ScriptMethodInfo scriptMethodInfo = ScriptMethodInfoHelper.Deserialize(clientFunctionExecutionContext.MethodName);
		string name = scriptMethodInfo.Name;
		IController controller;
		IDataStack data;
		if (clientFunctionExecutionContext.Controller == null)
		{
			IViewModel scope = GlobalScopeHelper.GetScope();
			if (scope == null)
			{
				return new ValueTuple<IController, string, object[]>((IController)null, (string)null, (object[])null);
			}
			controller = scope.Controller;
			if (scope is IFormViewModel formViewModel)
			{
				IDictionary<Guid, IController> controllers = formViewModel.Controllers;
				IController controller2 = default(IController);
				if (scriptMethodInfo.MetadataUid == Guid.Empty)
				{
					System.Collections.Generic.IEnumerator<KeyValuePair<Guid, IController>> enumerator = ((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, IController>>)controllers).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							IController value = enumerator.get_Current().get_Value();
							if (((object)value).get_Item(name) is Func<object>)
							{
								controller = value;
								break;
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
				}
				else if (controllers.TryGetValue(scriptMethodInfo.MetadataUid, ref controller2) && ((object)controller2).get_Item(name) is Func<object>)
				{
					controller = controller2;
				}
			}
			data = scope.GetPlainPropertyValue<IDataStack>("Stack");
		}
		else
		{
			controller = clientFunctionExecutionContext.Controller.Invoke();
			data = clientFunctionExecutionContext.DataStack;
		}
		if (controller == null)
		{
			return new ValueTuple<IController, string, object[]>((IController)null, (string)null, (object[])null);
		}
		object[] array = new object[0];
		if (getParam != null)
		{
			ArrayExtensions.Push<object>(array, new object[1] { getParam.Invoke() });
		}
		ArrayExtensions.Push<object>(array, Enumerable.ToArray<object>(UnwrapDataArray(data)));
		return new ValueTuple<IController, string, object[]>(controller, name, array);
	}

	private static System.Collections.Generic.IEnumerable<object> UnwrapDataArray(IDataStack data)
	{
		return new _003CUnwrapDataArray_003Ed__6(-2)
		{
			_003C_003E3__data = data
		};
	}
}
