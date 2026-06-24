using System.Collections.Generic;
using EleWise.ELMA.Dynamic;
using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

public class EventNotification : IEventNotification, INotification, IExtendedPropertiesContainer
{
	private string @event;

	private IAuditEventArgs e;

	private static EventNotification aTcOSqtICpZGdJOhbqP;

	public string TemplateName => null;

	public string Event => @event;

	public IAuditObject Object => (IAuditObject)yTO4IntXTaHMHGOrStJ(e);

	public IAuditAction Action => (IAuditAction)rqL4V9tTFW9boJ9TcFU(e);

	public IDictionary<string, object> ExtendedProperties => e.ExtendedProperties;

	public EventNotification(string @event, IAuditEventArgs e)
	{
		//Discarded unreachable code: IL_002a
		jawZ9VtiZLxO3l6mYYC();
		base._002Ector();
		int num = 5;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
		{
			num = 4;
		}
		while (true)
		{
			int num2;
			switch (num)
			{
			case 4:
				VXYcQXtKh6ciFBgE7N9(@event, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FA88D6));
				num2 = 2;
				goto IL_002f;
			case 3:
				this.e = e;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			default:
				this.@event = @event;
				num2 = 3;
				goto IL_002f;
			case 2:
				OCUjNBtqimZf7FMwE9Z(e, tOTajrtRabDpkAQr0rA(0x2A7797B7 ^ 0x2A771F9F));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num = 0;
				}
				break;
			case 5:
				{
					OCUjNBtqimZf7FMwE9Z(@event, tOTajrtRabDpkAQr0rA(-812025778 ^ -811995050));
					num = 4;
					break;
				}
				IL_002f:
				num = num2;
				break;
			}
		}
	}

	internal static void jawZ9VtiZLxO3l6mYYC()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object tOTajrtRabDpkAQr0rA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void OCUjNBtqimZf7FMwE9Z(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void VXYcQXtKh6ciFBgE7N9(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static bool tNQTjVtVlKOoxWBOeBY()
	{
		return aTcOSqtICpZGdJOhbqP == null;
	}

	internal static EventNotification EpC94ctS4Hon5Wl2Sng()
	{
		return aTcOSqtICpZGdJOhbqP;
	}

	internal static object yTO4IntXTaHMHGOrStJ(object P_0)
	{
		return ((IAuditEventHolder)P_0).Object;
	}

	internal static object rqL4V9tTFW9boJ9TcFU(object P_0)
	{
		return ((IAuditEventHolder)P_0).Action;
	}
}
