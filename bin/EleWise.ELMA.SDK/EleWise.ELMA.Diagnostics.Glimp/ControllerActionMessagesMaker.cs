using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Events;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Message;
using Glimpse.Mvc.AlternateType;
using Glimpse.Mvc.Message;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers;

[Component]
internal class ControllerActionMessagesMaker : AbstractMessagesMaker
{
	private static ControllerActionMessagesMaker EhWfxhEqsFPGfhSSSBHm;

	public override Type[] SupportedEventTypes => new Type[2]
	{
		TypeOf<ControllerActionCallEndEvent>.Raw,
		TypeOf<ControllerActionCallErrorEvent>.Raw
	};

	public override object[] MakeMessages(DiagnosticsEvent @event)
	{
		//Discarded unreachable code: IL_00e0, IL_0151, IL_0160
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d1: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		int num = 5;
		ReflectedActionDescriptor val3 = default(ReflectedActionDescriptor);
		MethodInfo methodInfo = default(MethodInfo);
		ControllerActionCallInfo controllerActionCallInfo = default(ControllerActionCallInfo);
		TimerResult val2 = default(TimerResult);
		IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent = default(IDiagnosticsCallInfoEvent);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (val3 == null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 3:
					methodInfo = (MethodInfo)B8vU2OEKo9du7UPFLeX0(val3);
					num2 = 7;
					continue;
				case 5:
					break;
				case 1:
				case 7:
				{
					TimerResult val4 = new TimerResult();
					ehonn2EKfoI2C1L4eY2m((object)val4, RFsr2GEKEv56QD9iGYf8(controllerActionCallInfo));
					WZ6iZiEK8f1dnXPps5uj((object)val4, xIFthUEKvqyE9GR79iCt(controllerActionCallInfo.StartTime, QBs6crEKCAcg0vlIYOIU(nbw4a2EKQBPlWaGUC1N2(controllerActionCallInfo))));
					I1a0tdEKZHOarwIWZWNB((object)val4, controllerActionCallInfo.TotalTime);
					val2 = val4;
					num2 = 8;
					continue;
				}
				case 6:
				{
					if ((controllerActionCallInfo = PjSGtcEKF9OAfA5PjVPk(diagnosticsCallInfoEvent) as ControllerActionCallInfo) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 0;
						}
						continue;
					}
					object obj = aZnZWSEKWY12lEKpl6AT(OqwbPSEKB9QBYHktmGfV(controllerActionCallInfo));
					val3 = (ReflectedActionDescriptor)((obj is ReflectedActionDescriptor) ? obj : null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				default:
					return new object[0];
				case 4:
					if (diagnosticsCallInfoEvent != null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto default;
				case 9:
				case 10:
				{
					ControllerDescriptor controllerDescriptor = ((ActionDescriptor)aZnZWSEKWY12lEKpl6AT(controllerActionCallInfo.ActionExecutedContext)).get_ControllerDescriptor();
					string name = (string)Mm7kX6EKbniiSYUOMLDw(((ActionExecutedContext)OqwbPSEKB9QBYHktmGfV(controllerActionCallInfo)).get_ActionDescriptor());
					Type[] types = ((IEnumerable<ParameterDescriptor>)J12WyfEKho1xbctEessm(aZnZWSEKWY12lEKpl6AT(OqwbPSEKB9QBYHktmGfV(controllerActionCallInfo)))).Select((ParameterDescriptor p) => p.get_ParameterType()).ToArray();
					methodInfo = HRPZHlEKGNoWETwivq7i(controllerDescriptor).GetMethod(name, types);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 8:
				{
					object[] array = new object[1];
					Message val = new Message(((object)controllerActionCallInfo.ActionExecutedContext.get_Result()).GetType());
					val.set_EventSubText((AeXGFSEKuu33UW7sKINl(controllerActionCallInfo) != null) ? controllerActionCallInfo.Exception.Message : "");
					array[0] = TimedMessageExtension.AsTimedMessage<Message>(MvcTimelineExtension.AsMvcTimelineMessage<Message>(ChildActionMessageExtension.AsChildActionMessage<Message>(ActionMessageExtension.AsActionMessage<Message>(SourceMessageExtension.AsSourceMessage<Message>(val, HRPZHlEKGNoWETwivq7i(hNIcwREKIujVfpQUWxfh(((ActionExecutedContext)OqwbPSEKB9QBYHktmGfV(controllerActionCallInfo)).get_ActionDescriptor())), methodInfo), (ActionDescriptor)aZnZWSEKWY12lEKpl6AT(controllerActionCallInfo.ActionExecutedContext)), (ControllerContext)(object)controllerActionCallInfo.ActionExecutedContext), (TimelineCategoryItem)p57lXCEKVT5J9YVpiHhF()), val2);
					return array;
				}
				}
				break;
			}
			diagnosticsCallInfoEvent = @event as IDiagnosticsCallInfoEvent;
			num = 4;
		}
	}

	public ControllerActionMessagesMaker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WEB1C8EKSoFCE3cArJy2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rRVvMREqcwpw5HdKNTZj()
	{
		return EhWfxhEqsFPGfhSSSBHm == null;
	}

	internal static ControllerActionMessagesMaker in39T7EqzFcT7VWUoLcX()
	{
		return EhWfxhEqsFPGfhSSSBHm;
	}

	internal static object PjSGtcEKF9OAfA5PjVPk(object P_0)
	{
		return ((IDiagnosticsCallInfoEvent)P_0).Info;
	}

	internal static object OqwbPSEKB9QBYHktmGfV(object P_0)
	{
		return ((ControllerActionCallInfo)P_0).ActionExecutedContext;
	}

	internal static object aZnZWSEKWY12lEKpl6AT(object P_0)
	{
		return ((ActionExecutedContext)P_0).get_ActionDescriptor();
	}

	internal static object B8vU2OEKo9du7UPFLeX0(object P_0)
	{
		return ((ReflectedActionDescriptor)P_0).get_MethodInfo();
	}

	internal static object Mm7kX6EKbniiSYUOMLDw(object P_0)
	{
		return ((ActionDescriptor)P_0).get_ActionName();
	}

	internal static object J12WyfEKho1xbctEessm(object P_0)
	{
		return ((ActionDescriptor)P_0).GetParameters();
	}

	internal static Type HRPZHlEKGNoWETwivq7i(object P_0)
	{
		return ((ControllerDescriptor)P_0).get_ControllerType();
	}

	internal static DateTime RFsr2GEKEv56QD9iGYf8(object P_0)
	{
		return ((AbstractCallInfo)P_0).StartTime;
	}

	internal static void ehonn2EKfoI2C1L4eY2m(object P_0, DateTime P_1)
	{
		((TimerResult)P_0).set_StartTime(P_1);
	}

	internal static object nbw4a2EKQBPlWaGUC1N2(object P_0)
	{
		return ((AbstractCallInfo)P_0).ContextInfo;
	}

	internal static DateTime QBs6crEKCAcg0vlIYOIU(object P_0)
	{
		return ((CallContextInfo)P_0).StartTime;
	}

	internal static TimeSpan xIFthUEKvqyE9GR79iCt(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static void WZ6iZiEK8f1dnXPps5uj(object P_0, TimeSpan P_1)
	{
		((TimerResult)P_0).set_Offset(P_1);
	}

	internal static void I1a0tdEKZHOarwIWZWNB(object P_0, TimeSpan P_1)
	{
		((TimerResult)P_0).set_Duration(P_1);
	}

	internal static object AeXGFSEKuu33UW7sKINl(object P_0)
	{
		return ((AbstractCallInfo)P_0).Exception;
	}

	internal static object hNIcwREKIujVfpQUWxfh(object P_0)
	{
		return ((ActionDescriptor)P_0).get_ControllerDescriptor();
	}

	internal static object p57lXCEKVT5J9YVpiHhF()
	{
		return MvcTimelineCategory.get_Controller();
	}

	internal static void WEB1C8EKSoFCE3cArJy2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
