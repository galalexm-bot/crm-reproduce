using System;
using System.Diagnostics;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events.Impl;

[DebuggerDisplay("Type={EventHandlerType}, Order = {Order}, IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}")]
internal class LazyEventHandler : Lazy<IEventHandler>
{
	internal static LazyEventHandler bI2PLUGYpWvNPxsBKlsa;

	public Type EventHandlerType { get; }

	public int Order { get; }

	public LazyEventHandler(Func<IEventHandler> valueFactory, Type eventHandlerType, int order)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(valueFactory);
		EventHandlerType = eventHandlerType;
		Order = order;
	}

	public LazyEventHandler(IEventHandler eventHandler)
	{
		//Discarded unreachable code: IL_0040, IL_0045, IL_009c
		qDXvKwGYtC16A90yevi9();
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.eventHandler = eventHandler;
		base._002Ector((Func<IEventHandler>)(() => CS_0024_003C_003E8__locals0.eventHandler));
		int num = 4;
		OrderAttribute attribute = default(OrderAttribute);
		while (true)
		{
			switch (num)
			{
			case 4:
				EventHandlerType = CS_0024_003C_003E8__locals0.eventHandler.GetType();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num = 0;
				}
				continue;
			case 2:
				return;
			case 1:
				if (attribute == null)
				{
					num = 2;
					continue;
				}
				break;
			default:
				attribute = AttributeHelper<OrderAttribute>.GetAttribute(EventHandlerType, inherited: true);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num = 1;
				}
				continue;
			case 5:
				break;
			case 3:
				return;
			}
			Order = iuWNC9GYwQBUmExIt0We(attribute);
			num = 3;
		}
	}

	internal static void qDXvKwGYtC16A90yevi9()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static int iuWNC9GYwQBUmExIt0We(object P_0)
	{
		return ((OrderAttribute)P_0).Order;
	}

	internal static bool rrsK20GYakEWLYAQ3QNw()
	{
		return bI2PLUGYpWvNPxsBKlsa == null;
	}

	internal static LazyEventHandler iF9VF9GYDWf3cZyNf1Da()
	{
		return bI2PLUGYpWvNPxsBKlsa;
	}
}
