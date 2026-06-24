using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.TestFramework.Helpers;

internal sealed class Promise : IPromise
{
	private delegate void PromiseDelegate(params object[] args);

	private delegate void Next(PromiseDelegate fulfilledHandler, PromiseDelegate errorHandler = null, PromiseDelegate progressHandler = null);

	private class Handler
	{
		private PromiseDelegate _003CFilled_003Ek__BackingField;

		private PromiseDelegate _003CError_003Ek__BackingField;

		private PromiseDelegate _003CProgress_003Ek__BackingField;

		public PromiseDelegate Filled
		{
			get
			{
				return _003CFilled_003Ek__BackingField;
			}
			set
			{
				_003CFilled_003Ek__BackingField = value;
			}
		}

		public PromiseDelegate Error
		{
			get
			{
				return _003CError_003Ek__BackingField;
			}
			set
			{
				_003CError_003Ek__BackingField = value;
			}
		}

		public PromiseDelegate Progress
		{
			get
			{
				return _003CProgress_003Ek__BackingField;
			}
			set
			{
				_003CProgress_003Ek__BackingField = value;
			}
		}
	}

	private enum Which
	{
		Resolve,
		Reject
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public Func<System.Threading.Tasks.Task> asyncFunc;

		internal Promise _003CPromisify_003Eb__0()
		{
			_003C_003Ec__DisplayClass5_1 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_1();
			_003C_003Ec__DisplayClass5_.CS_0024_003C_003E8__locals1 = this;
			_003C_003Ec__DisplayClass5_.promise = new Promise();
			((Func<System.Threading.Tasks.Task>)delegate
			{
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0022: Unknown result type (might be due to invalid IL or missing references)
				_003C_003Ec__DisplayClass5_1._003C_003CPromisify_003Eb__1_003Ed _003C_003CPromisify_003Eb__1_003Ed = default(_003C_003Ec__DisplayClass5_1._003C_003CPromisify_003Eb__1_003Ed);
				_003C_003CPromisify_003Eb__1_003Ed._003C_003E4__this = _003C_003Ec__DisplayClass5_;
				_003C_003CPromisify_003Eb__1_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_003C_003CPromisify_003Eb__1_003Ed._003C_003E1__state = -1;
				AsyncTaskMethodBuilder _003C_003Et__builder = _003C_003CPromisify_003Eb__1_003Ed._003C_003Et__builder;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003C_003Ec__DisplayClass5_1._003C_003CPromisify_003Eb__1_003Ed>(ref _003C_003CPromisify_003Eb__1_003Ed);
				return ((AsyncTaskMethodBuilder)(ref _003C_003CPromisify_003Eb__1_003Ed._003C_003Et__builder)).get_Task();
			}).Invoke();
			return _003C_003Ec__DisplayClass5_.promise;
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_1
	{
		[StructLayout(3)]
		private struct _003C_003CPromisify_003Eb__1_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public _003C_003Ec__DisplayClass5_1 _003C_003E4__this;

			private object _003C_003Eu__1;

			private void MoveNext()
			{
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected O, but got Unknown
				int num = _003C_003E1__state;
				_003C_003Ec__DisplayClass5_1 _003C_003Ec__DisplayClass5_ = _003C_003E4__this;
				try
				{
					try
					{
						TaskAwaiter val;
						if (num != 0)
						{
							val = _003C_003Ec__DisplayClass5_.CS_0024_003C_003E8__locals1.asyncFunc.Invoke().GetAwaiter();
							if (!val.get_IsCompleted())
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = val;
								((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003C_003CPromisify_003Eb__1_003Ed>(ref val, ref this);
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
						_003C_003Ec__DisplayClass5_.promise.Resolve();
					}
					catch (System.Exception ex)
					{
						_003C_003Ec__DisplayClass5_.promise.Reject(ex);
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

		public Promise promise;

		public _003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals1;

		internal System.Threading.Tasks.Task _003CPromisify_003Eb__1()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			_003C_003CPromisify_003Eb__1_003Ed _003C_003CPromisify_003Eb__1_003Ed = default(_003C_003CPromisify_003Eb__1_003Ed);
			_003C_003CPromisify_003Eb__1_003Ed._003C_003E4__this = this;
			_003C_003CPromisify_003Eb__1_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
			_003C_003CPromisify_003Eb__1_003Ed._003C_003E1__state = -1;
			AsyncTaskMethodBuilder _003C_003Et__builder = _003C_003CPromisify_003Eb__1_003Ed._003C_003Et__builder;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003C_003CPromisify_003Eb__1_003Ed>(ref _003C_003CPromisify_003Eb__1_003Ed);
			return ((AsyncTaskMethodBuilder)(ref _003C_003CPromisify_003Eb__1_003Ed._003C_003Et__builder)).get_Task();
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public Promise _003C_003E4__this;

		public object[] args;

		internal void _003CComplete_003Eb__0(PromiseDelegate f, PromiseDelegate e, PromiseDelegate p)
		{
			_003C_003E4__this.Resolve(args);
		}

		internal void _003CComplete_003Eb__1(PromiseDelegate f, PromiseDelegate e, PromiseDelegate p)
		{
			_003C_003E4__this.Reject(args);
		}
	}

	private Next doThen;

	private List<Handler> thens;

	public Promise()
	{
		thens = new List<Handler>();
		doThen = delegate(PromiseDelegate f, PromiseDelegate e, PromiseDelegate p)
		{
			thens.Add(new Handler
			{
				Filled = f,
				Error = e,
				Progress = p
			});
		};
	}

	public static Func<Promise> Promisify(Func<System.Threading.Tasks.Task> asyncFunc)
	{
		return new _003C_003Ec__DisplayClass5_0
		{
			asyncFunc = asyncFunc
		}._003CPromisify_003Eb__0;
	}

	public void Then(System.Delegate fulfilledHandler, System.Delegate errorHandler = null, System.Delegate progressHandler = null)
	{
		doThen((PromiseDelegate)fulfilledHandler, (PromiseDelegate)errorHandler, (PromiseDelegate)progressHandler);
	}

	public void Resolve(params object[] args)
	{
		Complete(Which.Resolve, args);
	}

	public void Reject(params object[] args)
	{
		Complete(Which.Reject, args);
	}

	public void Progress(params object[] args)
	{
		for (int i = 0; i < thens.get_Count(); i++)
		{
			Handler handler = thens.get_Item(i);
			if (handler.Progress != null)
			{
				handler.Progress(args);
			}
		}
	}

	private void Complete(Which which, params object[] args)
	{
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.args = args;
		if (which == Which.Resolve)
		{
			doThen = delegate
			{
				CS_0024_003C_003E8__locals0._003C_003E4__this.Resolve(CS_0024_003C_003E8__locals0.args);
			};
		}
		else
		{
			doThen = delegate
			{
				CS_0024_003C_003E8__locals0._003C_003E4__this.Reject(CS_0024_003C_003E8__locals0.args);
			};
		}
		for (int i = 0; i < thens.get_Count(); i++)
		{
			Handler handler = thens.get_Item(i);
			if (which == Which.Resolve)
			{
				if (handler.Filled != null)
				{
					((System.Delegate)handler.Filled).Apply((object)null, (System.Array)CS_0024_003C_003E8__locals0.args);
				}
			}
			else if (handler.Error != null)
			{
				((System.Delegate)handler.Error).Apply((object)null, (System.Array)CS_0024_003C_003E8__locals0.args);
			}
			if (handler.Progress != null)
			{
				handler.Progress(100);
			}
		}
		thens.Clear();
	}

	private void _003C_002Ector_003Eb__4_0(PromiseDelegate f, PromiseDelegate e, PromiseDelegate p)
	{
		thens.Add(new Handler
		{
			Filled = f,
			Error = e,
			Progress = p
		});
	}
}
