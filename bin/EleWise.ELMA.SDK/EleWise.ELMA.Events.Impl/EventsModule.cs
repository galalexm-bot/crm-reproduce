using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using EleWise.ELMA.Events.Audit.Impl;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events.Impl;

internal class EventsModule : Module
{
	internal static EventsModule CkahViGLvEJIYZrTjnrV;

	protected override void Load(ContainerBuilder builder)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 3:
				RegistrationExtensions.RegisterType<AuditEventBus>(builder).As<IEventBus>().As<IEventBusAsync>()
					.SingleInstance();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				diTpMvGLuVohwu6D3tHi(builder, new EventsRegistrationSource());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Bt6Q6aGLIIXDcGj8ZkGN(this, builder);
				num2 = 4;
				break;
			default:
				RegistrationExtensions.RegisterType<DefaultEventBus>(builder).As<IEventBus>().As<IEventBusAsync>()
					.As<IEventHandlerSubscribeService>()
					.SingleInstance();
				num2 = 3;
				break;
			}
		}
	}

	protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass1_.registration = registration;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				pGgSnvGLVqS6EZu3MOFe(componentRegistry, RegistrationBuilder.CreateRegistration<LazyEventHandler, SimpleActivatorData, SingleRegistrationStyle>(RegistrationExtensions.Targeting<LazyEventHandler, SimpleActivatorData, SingleRegistrationStyle>(RegistrationBuilder.ForDelegate<LazyEventHandler>((Func<IComponentContext, IEnumerable<Parameter>, LazyEventHandler>)_003C_003Ec__DisplayClass1_._003CAttachToComponentRegistration_003Eb__1), _003C_003Ec__DisplayClass1_.registration)));
				num2 = 4;
				continue;
			case 3:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 2;
				continue;
			case 4:
				return;
			}
			if (!_003C_003Ec__DisplayClass1_.registration.get_Services().Any(delegate(Service s)
			{
				//Discarded unreachable code: IL_0069, IL_0078
				int num3 = 1;
				int num4 = num3;
				IServiceWithType val = default(IServiceWithType);
				while (true)
				{
					switch (num4)
					{
					case 1:
						if ((val = (IServiceWithType)(object)((s is IServiceWithType) ? s : null)) == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
							{
								num4 = 0;
							}
							break;
						}
						goto case 2;
					case 2:
						return _003C_003Ec.dbdxN78urS6JssVtoTPX(val) == TypeOf<IEventHandler>.Raw;
					default:
						return false;
					}
				}
			}))
			{
				return;
			}
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
			{
				num2 = 0;
			}
		}
	}

	public EventsModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		o0v675GLSFrRXx2iZgsf();
		((Module)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void diTpMvGLuVohwu6D3tHi(object P_0, object P_1)
	{
		RegistrationExtensions.RegisterSource((ContainerBuilder)P_0, (IRegistrationSource)P_1);
	}

	internal static void Bt6Q6aGLIIXDcGj8ZkGN(object P_0, object P_1)
	{
		((Module)P_0).Load((ContainerBuilder)P_1);
	}

	internal static bool B455BYGL8biiqRlmTrcg()
	{
		return CkahViGLvEJIYZrTjnrV == null;
	}

	internal static EventsModule se5WG0GLZoKTgHJWFsgV()
	{
		return CkahViGLvEJIYZrTjnrV;
	}

	internal static void pGgSnvGLVqS6EZu3MOFe(object P_0, object P_1)
	{
		((IComponentRegistry)P_0).Register((IComponentRegistration)P_1);
	}

	internal static void o0v675GLSFrRXx2iZgsf()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
