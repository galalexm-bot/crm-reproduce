using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Autofac;
using Autofac.Core;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Logging;

public class LoggingModule : Module
{
	private readonly ConcurrentDictionary<string, ILogger> loggerCache;

	private static readonly Type LoggerType;

	internal static LoggingModule JKIVNQhl2kReexWkVsRB;

	public LoggingModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Fp57o5hl1Wd6kXwp146X();
		((Module)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			loggerCache = new ConcurrentDictionary<string, ILogger>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
			{
				num = 1;
			}
		}
	}

	protected override void Load(ContainerBuilder moduleBuilder)
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
				RegistrationExtensions.Register<ILogger>(moduleBuilder, (Func<IComponentContext, IEnumerable<Parameter>, ILogger>)CreateLogger).As(new Type[1] { LoggerType }).InstancePerDependency();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				RegistrationExtensions.RegisterType<Log4NetFactory>(moduleBuilder).As<ILoggerFactory>().SingleInstance();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		Type limitType = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 5:
				_003C_003Ec__DisplayClass4_.injectors = BuildLoggerInjectors(limitType).ToArray();
				num2 = 3;
				break;
			case 4:
				return;
			case 1:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				limitType = registration.get_Activator().get_LimitType();
				num2 = 5;
				break;
			case 3:
				if (_003C_003Ec__DisplayClass4_.injectors.Any())
				{
					registration.add_Activated((EventHandler<ActivatedEventArgs<object>>)_003C_003Ec__DisplayClass4_._003CAttachToComponentRegistration_003Eb__0);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 4;
					}
				}
				break;
			case 2:
				return;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CBuildLoggerInjectors_003Ed__5))]
	private IEnumerable<Action<IComponentContext, object>> BuildLoggerInjectors(Type componentType)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CBuildLoggerInjectors_003Ed__5(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__componentType = componentType
		};
	}

	private static ILogger CreateLogger(object context, Type componentType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				sCTZ7ehlNQNMNioADNB9(context, LoggerType, new Parameter[1] { (Parameter)TypedParameter.From<Type>(componentType) });
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (ILogger)bok1nlhl3KpRwFeTNRUX(ResolutionExtensions.Resolve<ILoggerFactory>((IComponentContext)context), componentType);
			}
		}
	}

	private static ILogger CreateLogger(object context, IEnumerable<Parameter> parameters)
	{
		TypedParameter[] array = parameters.OfType<TypedParameter>().ToArray();
		ILoggerFactory loggerFactory = ResolutionExtensions.Resolve<ILoggerFactory>((IComponentContext)context);
		Type type = ((array.Length != 0) ? ParameterExtensions.TypedAs<Type>((IEnumerable<Parameter>)(object)array) : typeof(Logger));
		return loggerFactory.CreateLogger(type);
	}

	static LoggingModule()
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
				LoggerType = typeof(ILogger);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				Fp57o5hl1Wd6kXwp146X();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void Fp57o5hl1Wd6kXwp146X()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool HXaMvkhlej0VBw6uXgQ2()
	{
		return JKIVNQhl2kReexWkVsRB == null;
	}

	internal static LoggingModule lHTMVbhlPtNnmtDXxoPn()
	{
		return JKIVNQhl2kReexWkVsRB;
	}

	internal static object sCTZ7ehlNQNMNioADNB9(object P_0, Type P_1, object P_2)
	{
		return ResolutionExtensions.Resolve((IComponentContext)P_0, P_1, (Parameter[])P_2);
	}

	internal static object bok1nlhl3KpRwFeTNRUX(object P_0, Type type)
	{
		return ((ILoggerFactory)P_0).CreateLogger(type);
	}
}
