using System;
using EleWise.ELMA.ComponentModel;
using Glimpse.Core.Message;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers;

[Component]
internal class MessagePointMessagesMaker : IGlimpseMessagesMaker
{
	internal static MessagePointMessagesMaker kooIb0ERE4k2C3tl3nPD;

	public bool IsAvailable(DiagnosticsEvent @event)
	{
		return @event is MessagePointEvent;
	}

	public object[] MakeMessages(DiagnosticsEvent @event)
	{
		int num = 2;
		int num2 = num;
		MessagePointEvent messagePointEvent = default(MessagePointEvent);
		while (true)
		{
			switch (num2)
			{
			default:
				return new object[0];
			case 2:
				messagePointEvent = @event as MessagePointEvent;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (messagePointEvent != null)
				{
					object[] array = new object[1];
					BaseMessage baseMessage = new BaseMessage();
					lQmXVlERvJj59OhhO0v9(baseMessage, ayxmJHERCeJGSGmSwfbN(messagePointEvent));
					baseMessage.Offset = Xw4PkYERuaqnMdP0MU0G(ayxmJHERCeJGSGmSwfbN(messagePointEvent), ycH93vERZd2jYffO1WEq(c09RTaER8g1nk1w7xAQt(messagePointEvent)));
					bZGGpeERIuJ4YqNuTtQY(baseMessage, TimeSpan.Zero);
					FrudNMERSeHUj0UeIgtT(baseMessage, gJBtruERV08nWnuLYYjo(messagePointEvent));
					n7wrHAERiTcPNIAnlKGy(baseMessage, GlimpseHelper.MessagePoinTimelineCategoryItem);
					array[0] = baseMessage;
					return array;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public MessagePointMessagesMaker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ymlwiAERRmEF5uwdsZc0();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool cjHVYIERfZTew7ti51KD()
	{
		return kooIb0ERE4k2C3tl3nPD == null;
	}

	internal static MessagePointMessagesMaker PJlsiDERQlB4qyjvjncW()
	{
		return kooIb0ERE4k2C3tl3nPD;
	}

	internal static DateTime ayxmJHERCeJGSGmSwfbN(object P_0)
	{
		return ((DiagnosticsEvent)P_0).TimeStamp;
	}

	internal static void lQmXVlERvJj59OhhO0v9(object P_0, DateTime value)
	{
		((BaseMessage)P_0).StartTime = value;
	}

	internal static object c09RTaER8g1nk1w7xAQt(object P_0)
	{
		return ((DiagnosticsEvent)P_0).CallContextInfo;
	}

	internal static DateTime ycH93vERZd2jYffO1WEq(object P_0)
	{
		return ((CallContextInfo)P_0).StartTime;
	}

	internal static TimeSpan Xw4PkYERuaqnMdP0MU0G(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static void bZGGpeERIuJ4YqNuTtQY(object P_0, TimeSpan value)
	{
		((BaseMessage)P_0).Duration = value;
	}

	internal static object gJBtruERV08nWnuLYYjo(object P_0)
	{
		return ((DiagnosticsEvent)P_0).Message;
	}

	internal static void FrudNMERSeHUj0UeIgtT(object P_0, object P_1)
	{
		((BaseMessage)P_0).EventName = (string)P_1;
	}

	internal static void n7wrHAERiTcPNIAnlKGy(object P_0, object P_1)
	{
		((BaseMessage)P_0).EventCategory = (TimelineCategoryItem)P_1;
	}

	internal static void ymlwiAERRmEF5uwdsZc0()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
