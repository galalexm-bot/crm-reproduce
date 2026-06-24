using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Events;
using Glimpse.Core.Message;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers;

[Component]
internal class MethodCallMessagesMaker : AbstractMessagesMaker
{
	internal static MethodCallMessagesMaker xitE61EqBWlC7F2KuBmG;

	public override Type[] SupportedEventTypes => new Type[2]
	{
		TypeOf<MethodCallEndEvent>.Raw,
		TypeOf<MethodCallErrorEvent>.Raw
	};

	public override object[] MakeMessages(DiagnosticsEvent @event)
	{
		int num = 3;
		int num2 = num;
		IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent = default(IDiagnosticsCallInfoEvent);
		while (true)
		{
			switch (num2)
			{
			case 3:
				diagnosticsCallInfoEvent = @event as IDiagnosticsCallInfoEvent;
				num2 = 2;
				continue;
			default:
			{
				if (!(NvpL3HEqbuwrqEpLRhTG(diagnosticsCallInfoEvent) is MethodCallInfo methodCallInfo))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				object[] array = new object[1];
				MethodMessage obj = new MethodMessage
				{
					StartTime = methodCallInfo.StartTime
				};
				igaBZqEqQCp1vgIlgBTt(obj, ATob7OEqfixBtfbOHIrU(DfoK8oEqhQJTJ4MXx9J9(methodCallInfo), tbUBbSEqET3cSUdnckbN(PLB3ElEqGa5J4JFyaGwO(methodCallInfo))));
				NHQAATEqvqvA2SkNZmJM(obj, GXmhO3EqCTApGrS28XwA(methodCallInfo));
				BxxxNNEqZk8k9kvKGmbU(obj, GgThgREq8Ox2lTW6djAR(methodCallInfo));
				bFwtjuEquVmQ83yLdac7(obj, GlimpseHelper.MethodTimelineCategoryItem);
				xFCnN1EqVhM4EUvX3WQ7(obj, BpvNVGEqIALHyhf8evpg(methodCallInfo));
				YL0J8NEqiJ6PAkiFSFjN(obj, SCJVbkEqSTDI5IkCCngy(methodCallInfo));
				obj.EventSubText = (string)((iiTRjbEqR5wQLKFIT8Zr(methodCallInfo) != null) ? gq66xREqql3htAUhie5m(methodCallInfo.Exception) : "");
				array[0] = obj;
				return array;
			}
			case 2:
				if (diagnosticsCallInfoEvent != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 1:
				break;
			}
			break;
		}
		return new object[0];
	}

	public MethodCallMessagesMaker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool QwTMofEqWogbcHP4B9Cn()
	{
		return xitE61EqBWlC7F2KuBmG == null;
	}

	internal static MethodCallMessagesMaker qZQy3IEqo9qbD7nW7aHr()
	{
		return xitE61EqBWlC7F2KuBmG;
	}

	internal static object NvpL3HEqbuwrqEpLRhTG(object P_0)
	{
		return ((IDiagnosticsCallInfoEvent)P_0).Info;
	}

	internal static DateTime DfoK8oEqhQJTJ4MXx9J9(object P_0)
	{
		return ((AbstractCallInfo)P_0).StartTime;
	}

	internal static object PLB3ElEqGa5J4JFyaGwO(object P_0)
	{
		return ((AbstractCallInfo)P_0).ContextInfo;
	}

	internal static DateTime tbUBbSEqET3cSUdnckbN(object P_0)
	{
		return ((CallContextInfo)P_0).StartTime;
	}

	internal static TimeSpan ATob7OEqfixBtfbOHIrU(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static void igaBZqEqQCp1vgIlgBTt(object P_0, TimeSpan value)
	{
		((BaseMessage)P_0).Offset = value;
	}

	internal static TimeSpan GXmhO3EqCTApGrS28XwA(object P_0)
	{
		return ((AbstractCallInfo)P_0).TotalTime;
	}

	internal static void NHQAATEqvqvA2SkNZmJM(object P_0, TimeSpan value)
	{
		((BaseMessage)P_0).Duration = value;
	}

	internal static object GgThgREq8Ox2lTW6djAR(object P_0)
	{
		return ((AbstractCallInfo)P_0).Description;
	}

	internal static void BxxxNNEqZk8k9kvKGmbU(object P_0, object P_1)
	{
		((BaseMessage)P_0).EventName = (string)P_1;
	}

	internal static void bFwtjuEquVmQ83yLdac7(object P_0, object P_1)
	{
		((BaseMessage)P_0).EventCategory = (TimelineCategoryItem)P_1;
	}

	internal static Type BpvNVGEqIALHyhf8evpg(object P_0)
	{
		return ((MethodCallInfo)P_0).OwnerType;
	}

	internal static void xFCnN1EqVhM4EUvX3WQ7(object P_0, Type value)
	{
		((MethodMessage)P_0).ExecutedType = value;
	}

	internal static object SCJVbkEqSTDI5IkCCngy(object P_0)
	{
		return ((MethodCallInfo)P_0).Method;
	}

	internal static void YL0J8NEqiJ6PAkiFSFjN(object P_0, object P_1)
	{
		((MethodMessage)P_0).ExecutedMethod = (MethodInfo)P_1;
	}

	internal static object iiTRjbEqR5wQLKFIT8Zr(object P_0)
	{
		return ((AbstractCallInfo)P_0).Exception;
	}

	internal static object gq66xREqql3htAUhie5m(object P_0)
	{
		return ((Exception)P_0).Message;
	}
}
