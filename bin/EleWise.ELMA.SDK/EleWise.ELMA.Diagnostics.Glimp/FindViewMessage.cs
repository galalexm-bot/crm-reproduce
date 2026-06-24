using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Glimpse.Core.Message;
using Glimpse.Mvc.AlternateType;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Glimpse;

internal class FindViewMessage : Message, ITimelineMessage, ITimedMessage, IMessage
{
	private static FindViewMessage Jj3YZaEifyNIINXfbqi9;

	public FindViewMessage(Guid id, string viewName, string masterName, bool useCache, IEnumerable<string> searchedLocations, Type baseType, bool isPartial, bool isFound, string displayModeId, Type displayModeType)
	{
		SingletonReader.JJCZtPuTvSt();
		((Message)this)._002Ector(id, viewName, masterName, useCache, searchedLocations, baseType, isPartial, isFound, displayModeId, displayModeType);
	}

	[SpecialName]
	string ITimelineMessage.get_EventName()
	{
		return (string)XJJHt5EivcRQlNYktYps(this);
	}

	[SpecialName]
	void ITimelineMessage.set_EventName(string value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				oZ9OCOEi8RKa5q30XuSw(this, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[SpecialName]
	TimelineCategoryItem ITimelineMessage.get_EventCategory()
	{
		return (TimelineCategoryItem)ARSL8vEiZvcvV68P6sAg(this);
	}

	[SpecialName]
	void ITimelineMessage.set_EventCategory(TimelineCategoryItem value)
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
				SSamw3Eiuo0cDLTq4ryX(this, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[SpecialName]
	string ITimelineMessage.get_EventSubText()
	{
		return (string)FiH463EiIoTATQSx0KVH(this);
	}

	[SpecialName]
	void ITimelineMessage.set_EventSubText(string value)
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
				aWI2ncEiV2lNB7K12amf(this, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object XJJHt5EivcRQlNYktYps(object P_0)
	{
		return ((Message)P_0).get_EventName();
	}

	internal static void oZ9OCOEi8RKa5q30XuSw(object P_0, object P_1)
	{
		((Message)P_0).set_EventName((string)P_1);
	}

	internal static bool poZNttEiQ9ixa2RbVKIL()
	{
		return Jj3YZaEifyNIINXfbqi9 == null;
	}

	internal static FindViewMessage DFBUbdEiC44bW7Dhpjx3()
	{
		return Jj3YZaEifyNIINXfbqi9;
	}

	internal static object ARSL8vEiZvcvV68P6sAg(object P_0)
	{
		return ((Message)P_0).get_EventCategory();
	}

	internal static void SSamw3Eiuo0cDLTq4ryX(object P_0, object P_1)
	{
		((Message)P_0).set_EventCategory((TimelineCategoryItem)P_1);
	}

	internal static object FiH463EiIoTATQSx0KVH(object P_0)
	{
		return ((Message)P_0).get_EventSubText();
	}

	internal static void aWI2ncEiV2lNB7K12amf(object P_0, object P_1)
	{
		((Message)P_0).set_EventSubText((string)P_1);
	}
}
