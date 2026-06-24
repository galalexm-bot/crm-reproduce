using System;
using System.Collections.Generic;
using Autofac;
using Autofac.Core;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Services.Scope;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services.Autofac;

internal sealed class ExecutionScope : IExecutionScope, IDisposable
{
	private readonly ILifetimeScope innerScope;

	private readonly ILifetimeScope parentScope;

	[ThreadStatic]
	private static ILifetimeScope currentScope;

	internal static ExecutionScope PybiBFBmmxGROGCHj4y6;

	internal unsafe ExecutionScope(ILifetimeScope globalScope, IEnumerable<IComponentRegistration> registrations)
	{
		SingletonReader.JJCZtPuTvSt();
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.registrations = registrations;
		base._002Ector();
		Contract.ArgumentNotNull(globalScope, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107920650));
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.registrations, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A68048));
		parentScope = currentScope ?? globalScope;
		innerScope = parentScope.BeginLifetimeScope((Action<ContainerBuilder>)delegate(ContainerBuilder containerBuilder)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					CS_0024_003C_003E8__locals0.registrations.ForEach(new Action<IComponentRegistration>(containerBuilder, (nint)(delegate*<ContainerBuilder, IComponentRegistration, void>)(&RegistrationExtensions.RegisterComponent)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		currentScope = innerScope;
	}

	public T Resolve<T>() where T : class
	{
		return ResolutionExtensions.Resolve<T>((IComponentContext)(object)innerScope);
	}

	public object Resolve(Type objectType)
	{
		return bZ34T6BmJsC00F9nDi6O(innerScope, objectType);
	}

	public void Dispose()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				currentScope = parentScope;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				o1qRdfBm939ab52hwjE7(innerScope);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object bZ34T6BmJsC00F9nDi6O(object P_0, Type P_1)
	{
		return ResolutionExtensions.Resolve((IComponentContext)P_0, P_1);
	}

	internal static bool KoDi2NBmyAhgXmFFeHUL()
	{
		return PybiBFBmmxGROGCHj4y6 == null;
	}

	internal static ExecutionScope JeImXkBmMeFBxENDAI69()
	{
		return PybiBFBmmxGROGCHj4y6;
	}

	internal static void o1qRdfBm939ab52hwjE7(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
