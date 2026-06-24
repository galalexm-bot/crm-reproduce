using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Composite;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Ioc;

namespace EleWise.ELMA.DynamicProxy;

[Service]
internal sealed class MiddlewareService : IMiddlewareService
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public MiddlewareService _003C_003E4__this;

		public IMiddleware nextHandler;

		internal System.Threading.Tasks.Task _003CProceedInvocation_003Eb__0(InvocationContext ic)
		{
			return _003C_003E4__this.ProceedInvocation(ic, nextHandler);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<InvocationContext, System.Threading.Tasks.Task> _003C_003E9__7_1;

		internal System.Threading.Tasks.Task _003CProceedInvocation_003Eb__7_1(InvocationContext _)
		{
			return System.Threading.Tasks.Task.get_CompletedTask();
		}
	}

	[StructLayout(3)]
	private struct _003CProceedInvocation_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MiddlewareService _003C_003E4__this;

		public InvocationContext invContext;

		public IMiddleware next;

		private InvocationContext _003CinvocationContext_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected O, but got Unknown
			int num = _003C_003E1__state;
			MiddlewareService middlewareService = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
					CS_0024_003C_003E8__locals0._003C_003E4__this = _003C_003E4__this;
					Contract.ArgumentNotNull(invContext, "invContext");
					Contract.ArgumentNotNull(next, "next");
					CS_0024_003C_003E8__locals0.nextHandler = null;
					int num2 = middlewareService.handlers.LastIndexOf(next);
					switch (num2)
					{
					case -1:
						goto end_IL_000e;
					default:
						CS_0024_003C_003E8__locals0.nextHandler = middlewareService.handlers.get_Item(num2 - 1);
						goto case 0;
					case 0:
						_003CinvocationContext_003E5__2 = middlewareService.CreateContext(invContext.Method, invContext.TargetType, invContext.Arguments, invContext.ContextVars, (CS_0024_003C_003E8__locals0.nextHandler != null) ? ((Func<InvocationContext, System.Threading.Tasks.Task>)((InvocationContext ic) => CS_0024_003C_003E8__locals0._003C_003E4__this.ProceedInvocation(ic, CS_0024_003C_003E8__locals0.nextHandler))) : ((Func<InvocationContext, System.Threading.Tasks.Task>)((InvocationContext _) => System.Threading.Tasks.Task.get_CompletedTask())));
						val = next.Call(_003CinvocationContext_003E5__2).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CProceedInvocation_003Ed__7>(ref val, ref this);
							return;
						}
						break;
					}
				}
				else
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				val.GetResult();
				invContext.ReturnValue = _003CinvocationContext_003E5__2.ReturnValue;
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

	private List<IMiddleware> handlers;

	private readonly ILazy<IApplication> lazyApplication;

	private IApplication application => lazyApplication.Value();

	public MiddlewareService(ILazy<IApplication> lazyApplication)
	{
		this.lazyApplication = lazyApplication;
	}

	public InvocationContext CreateContext(MethodInfo method, System.Type targetType, object[] arguments, Dictionary<string, object> contextVars, Func<InvocationContext, System.Threading.Tasks.Task> next = null)
	{
		Contract.ArgumentNotNull(method, "method");
		Contract.ArgumentNotNull(targetType, "targetType");
		return new InvocationContext(method, targetType, arguments, next, contextVars);
	}

	public System.Threading.Tasks.Task Proceed(InvocationContext invContext)
	{
		Contract.ArgumentNotNull(invContext, "invContext");
		if (handlers == null)
		{
			handlers = Enumerable.ToList<IMiddleware>(application.Handlers);
		}
		return ProceedInvocation(invContext, Enumerable.LastOrDefault<IMiddleware>((System.Collections.Generic.IEnumerable<IMiddleware>)handlers));
	}

	private System.Threading.Tasks.Task ProceedInvocation(InvocationContext invContext, IMiddleware next)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CProceedInvocation_003Ed__7 _003CProceedInvocation_003Ed__ = default(_003CProceedInvocation_003Ed__7);
		_003CProceedInvocation_003Ed__._003C_003E4__this = this;
		_003CProceedInvocation_003Ed__.invContext = invContext;
		_003CProceedInvocation_003Ed__.next = next;
		_003CProceedInvocation_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CProceedInvocation_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CProceedInvocation_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CProceedInvocation_003Ed__7>(ref _003CProceedInvocation_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CProceedInvocation_003Ed__._003C_003Et__builder)).get_Task();
	}
}
