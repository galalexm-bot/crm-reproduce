using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Api;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DynamicProxy;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Types.Storage;

namespace EleWise.ELMA.Ioc.Resolvers;

internal sealed class ServiceContractResolver : AbstractResolver
{
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public ServiceContractResolver _003C_003E4__this;

		public System.Type type;

		internal object _003C_002Ector_003Eb__0(IScopeContext scope)
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			TypedMap<string, object> val = _003C_003E4__this.interfacesCache.Get(scope);
			if (val == null)
			{
				val = new TypedMap<string, object>();
				_003C_003E4__this.interfacesCache.Set(scope, val);
			}
			string text = ObjectExtensions.As<string>(((object)type).get_Item("$$fullName"));
			object obj = val.Get(text);
			if (obj != null)
			{
				return obj;
			}
			if (!type.get_IsInterface())
			{
				string text2 = SR.T("Тип {0} должен быть интерфейсом", text);
				Logger.Log.Error(text2);
				throw new ArgumentException(text2);
			}
			IMiddlewareService middleware = scope.Resolve<IMiddlewareService>();
			obj = CreateProxy(type, middleware);
			object obj2 = Script.Write<object>("Bridge.box({0}, {1})", new object[2] { obj, type });
			val.Set(text, obj2);
			return obj2;
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public IMiddlewareService middleware;

		public System.Type type;
	}

	private sealed class _003C_003Ec__DisplayClass3_1
	{
		[StructLayout(3)]
		private struct _003C_003CCreateProxy_003Eb__0_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

			public _003C_003Ec__DisplayClass3_1 _003C_003E4__this;

			private InvocationContext _003CinvocationContext_003E5__2;

			private object _003C_003Eu__1;

			private void MoveNext()
			{
				//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a7: Expected O, but got Unknown
				int num = _003C_003E1__state;
				_003C_003Ec__DisplayClass3_1 _003C_003Ec__DisplayClass3_ = _003C_003E4__this;
				object returnValue;
				try
				{
					TaskAwaiter val;
					if (num != 0)
					{
						object[] arguments = Script.Write<object[]>("System.Linq.Enumerable.from(arguments).ToArray()", new object[0]);
						_003CinvocationContext_003E5__2 = _003C_003Ec__DisplayClass3_.CS_0024_003C_003E8__locals1.middleware.CreateContext(_003C_003Ec__DisplayClass3_.method, _003C_003Ec__DisplayClass3_.CS_0024_003C_003E8__locals1.type, arguments, new Dictionary<string, object>());
						val = _003C_003Ec__DisplayClass3_.CS_0024_003C_003E8__locals1.middleware.Proceed(_003CinvocationContext_003E5__2).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter, _003C_003CCreateProxy_003Eb__0_003Ed>(ref val, ref this);
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
					returnValue = _003CinvocationContext_003E5__2.ReturnValue;
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult(returnValue);
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}
		}

		public MethodInfo method;

		public _003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals1;

		internal System.Threading.Tasks.Task<object> _003CCreateProxy_003Eb__0()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			_003C_003CCreateProxy_003Eb__0_003Ed _003C_003CCreateProxy_003Eb__0_003Ed = default(_003C_003CCreateProxy_003Eb__0_003Ed);
			_003C_003CCreateProxy_003Eb__0_003Ed._003C_003E4__this = this;
			_003C_003CCreateProxy_003Eb__0_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
			_003C_003CCreateProxy_003Eb__0_003Ed._003C_003E1__state = -1;
			AsyncTaskMethodBuilder<object> _003C_003Et__builder = _003C_003CCreateProxy_003Eb__0_003Ed._003C_003Et__builder;
			_003C_003Et__builder.Start<_003C_003CCreateProxy_003Eb__0_003Ed>(ref _003C_003CCreateProxy_003Eb__0_003Ed);
			return _003C_003CCreateProxy_003Eb__0_003Ed._003C_003Et__builder.get_Task();
		}
	}

	private readonly TypedMap<IScopeContext, TypedMap<string, object>> interfacesCache = new TypedMap<IScopeContext, TypedMap<string, object>>();

	public ServiceContractResolver(System.Type type)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0
		{
			type = type
		};
		((AbstractResolver)this)._002Ector();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		((AbstractResolver)this).set_Resolve((Func<IScopeContext, object>)delegate(IScopeContext scope)
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			TypedMap<string, object> val = CS_0024_003C_003E8__locals0._003C_003E4__this.interfacesCache.Get(scope);
			if (val == null)
			{
				val = new TypedMap<string, object>();
				CS_0024_003C_003E8__locals0._003C_003E4__this.interfacesCache.Set(scope, val);
			}
			string text = ObjectExtensions.As<string>(((object)CS_0024_003C_003E8__locals0.type).get_Item("$$fullName"));
			object obj = val.Get(text);
			if (obj != null)
			{
				return obj;
			}
			if (!CS_0024_003C_003E8__locals0.type.get_IsInterface())
			{
				string text2 = SR.T("Тип {0} должен быть интерфейсом", text);
				Logger.Log.Error(text2);
				throw new ArgumentException(text2);
			}
			IMiddlewareService middleware = scope.Resolve<IMiddlewareService>();
			obj = CreateProxy(CS_0024_003C_003E8__locals0.type, middleware);
			object obj2 = Script.Write<object>("Bridge.box({0}, {1})", new object[2] { obj, CS_0024_003C_003E8__locals0.type });
			val.Set(text, obj2);
			return obj2;
		});
	}

	public override void Dispose(ILifetimeScope scope)
	{
		interfacesCache.Delete((IScopeContext)(object)scope);
	}

	private static object CreateProxy(System.Type type, IMiddlewareService middleware)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.middleware = middleware;
		_003C_003Ec__DisplayClass3_.type = type;
		MethodInfo[] methods = _003C_003Ec__DisplayClass3_.type.GetMethods();
		if (methods.Length == 0)
		{
			string text = SR.T("Интерфейс сервиса не имеет ни одного метода");
			Logger.Log.Error(text);
			throw new ArgumentException(text);
		}
		string text2 = _003C_003Ec__DisplayClass3_.type.get_FullName().Replace(".", "$");
		string text3 = Script.Write<string>("type.$module", new object[0]);
		string text4 = ((!string.IsNullOrWhiteSpace(text3)) ? (text3 + "$") : "");
		object obj = Script.ToObjectLiteral<object>(new object());
		MethodInfo[] array = methods;
		for (int i = 0; i < array.Length; i++)
		{
			_003C_003Ec__DisplayClass3_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass3_;
			CS_0024_003C_003E8__locals0.method = array[i];
			string name = ((MemberInfo)CS_0024_003C_003E8__locals0.method).get_Name();
			if (!ApiProvider.IsTask(CS_0024_003C_003E8__locals0.method.get_ReturnType()))
			{
				string text5 = SR.T("Метод '{0}' должен иметь тип возвращаемого значения {1}", name, typeof(System.Threading.Tasks.Task).get_FullName());
				Logger.Log.Error(text5);
				throw new ArgumentException(text5);
			}
			string propertyName = text4 + text2 + "$" + name.Capitalized();
			obj.SetAndCreatePlainPropertyValue(propertyName, Lambda<System.Threading.Tasks.Task<object>>(delegate
			{
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0022: Unknown result type (might be due to invalid IL or missing references)
				_003C_003Ec__DisplayClass3_1._003C_003CCreateProxy_003Eb__0_003Ed _003C_003CCreateProxy_003Eb__0_003Ed = default(_003C_003Ec__DisplayClass3_1._003C_003CCreateProxy_003Eb__0_003Ed);
				_003C_003CCreateProxy_003Eb__0_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
				_003C_003CCreateProxy_003Eb__0_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
				_003C_003CCreateProxy_003Eb__0_003Ed._003C_003E1__state = -1;
				AsyncTaskMethodBuilder<object> _003C_003Et__builder = _003C_003CCreateProxy_003Eb__0_003Ed._003C_003Et__builder;
				_003C_003Et__builder.Start<_003C_003Ec__DisplayClass3_1._003C_003CCreateProxy_003Eb__0_003Ed>(ref _003C_003CCreateProxy_003Eb__0_003Ed);
				return _003C_003CCreateProxy_003Eb__0_003Ed._003C_003Et__builder.get_Task();
			}));
		}
		return obj;
	}

	[Template("{0}")]
	private static extern Func<T> Lambda<T>(Func<T> x);
}
