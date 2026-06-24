using System;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Events;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Message;
using Glimpse.Core.Tab.Assist;
using Glimpse.Mvc.Message;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers;

[Component]
internal class FindViewMessagesMaker : IGlimpseMessagesMaker
{
	private static readonly MethodInfo MethodInfo;

	private static FindViewMessagesMaker GcZqkdEqK0rhe1aex4Ot;

	public bool IsAvailable(DiagnosticsEvent @event)
	{
		return @event is FindViewEndEvent;
	}

	public object[] MakeMessages(DiagnosticsEvent @event)
	{
		//Discarded unreachable code: IL_01c1, IL_022b, IL_023a
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_012f: Expected O, but got Unknown
		int num = 8;
		FindViewInfo findViewInfo = default(FindViewInfo);
		TimerResult val2 = default(TimerResult);
		FindViewMessage findViewMessage = default(FindViewMessage);
		IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent = default(IDiagnosticsCallInfoEvent);
		Type baseType = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 5:
					goto end_IL_0012;
				case 4:
					return new object[0];
				case 9:
				{
					TimerResult val = new TimerResult();
					val.set_StartTime(jdM8X0EqnLocUl7TVqQl(findViewInfo));
					val.set_Offset(RrOOCuEqee84jlCuZoIq(findViewInfo.StartTime, baCdsWEq2RxggVglaK5b(zpH26gEqOJ4jyRxyjxHu(findViewInfo))));
					rLSdUXEq1Ds3mQJaACY5((object)val, IciNYKEqP63tMiJgunm4(findViewInfo));
					val2 = val;
					num2 = 10;
					continue;
				}
				case 3:
					return new object[1] { findViewMessage };
				default:
					if ((findViewInfo = g9xOBFEqkLyq3M9G9jCL(diagnosticsCallInfoEvent) as FindViewInfo) != null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 4;
				case 10:
					if (HcIjTVEqNyylRIt4Ndux(findViewInfo) == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = DUXkF4Eq3VBYH07LOI3S(findViewInfo.ViewContext).GetType();
					break;
				case 8:
					diagnosticsCallInfoEvent = @event as IDiagnosticsCallInfoEvent;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					obj = null;
					break;
				case 2:
					findViewMessage = SourceMessageExtension.AsSourceMessage<FindViewMessage>(findViewMessage, MSIMhtEqHf5YyM9DMq8W(g8WOg9Eq6DYXJ3c1EGrQ(findViewInfo)).GetType(), MethodInfo);
					num2 = 3;
					continue;
				case 6:
					if (dhKGc4EqtjmSMDTLKw5E(findViewInfo))
					{
						num2 = 2;
						continue;
					}
					goto case 3;
				case 7:
					if (diagnosticsCallInfoEvent != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				}
				baseType = (Type)obj;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			findViewMessage = TimedMessageExtension.AsTimedMessage<FindViewMessage>(TimelineMessageExtension.AsTimelineMessage<FindViewMessage>(ChildActionMessageExtension.AsChildActionMessage<FindViewMessage>(ActionMessageExtension.AsActionMessage<FindViewMessage>(new FindViewMessage(Su2YyMEqpHbldSjW4VAL(), (string)z5TRpKEqaLIQ0GUqpYRX(findViewInfo), findViewInfo.MasterName, useCache: true, findViewInfo.SearchedLocations, baseType, yJEajZEqDufDqgFZri0r(findViewInfo), dhKGc4EqtjmSMDTLKw5E(findViewInfo), null, null), findViewInfo.ControllerContext), (ControllerContext)A5N5R6Eqw23yWXa0icEg(findViewInfo)), (string)myl0c6Eq4IZkk59NhTfY(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767445139), new object[2]
			{
				z5TRpKEqaLIQ0GUqpYRX(findViewInfo),
				findViewInfo.IsFound
			}), GlimpseHelper.FindViewTimelineCategoryItem, (string)null), val2);
			num = 6;
		}
	}

	public FindViewMessagesMaker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		M4TbbvEqA4Riw7GJqvhF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static FindViewMessagesMaker()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				M4TbbvEqA4Riw7GJqvhF();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				MethodInfo = TypeOf<IViewEngine>.Raw.GetMethod((string)xsUaCnEq75vjj2uZKBqN(-29254301 ^ -28980829));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool omrFFXEqXqt3JFgjgmxY()
	{
		return GcZqkdEqK0rhe1aex4Ot == null;
	}

	internal static FindViewMessagesMaker JMf3Q5EqTSYWVGENHTLS()
	{
		return GcZqkdEqK0rhe1aex4Ot;
	}

	internal static object g9xOBFEqkLyq3M9G9jCL(object P_0)
	{
		return ((IDiagnosticsCallInfoEvent)P_0).Info;
	}

	internal static DateTime jdM8X0EqnLocUl7TVqQl(object P_0)
	{
		return ((AbstractCallInfo)P_0).StartTime;
	}

	internal static object zpH26gEqOJ4jyRxyjxHu(object P_0)
	{
		return ((AbstractCallInfo)P_0).ContextInfo;
	}

	internal static DateTime baCdsWEq2RxggVglaK5b(object P_0)
	{
		return ((CallContextInfo)P_0).StartTime;
	}

	internal static TimeSpan RrOOCuEqee84jlCuZoIq(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static TimeSpan IciNYKEqP63tMiJgunm4(object P_0)
	{
		return ((AbstractCallInfo)P_0).TotalTime;
	}

	internal static void rLSdUXEq1Ds3mQJaACY5(object P_0, TimeSpan P_1)
	{
		((TimerResult)P_0).set_Duration(P_1);
	}

	internal static object HcIjTVEqNyylRIt4Ndux(object P_0)
	{
		return ((FindViewInfo)P_0).ViewContext;
	}

	internal static object DUXkF4Eq3VBYH07LOI3S(object P_0)
	{
		return ((ViewContext)P_0).get_View();
	}

	internal static Guid Su2YyMEqpHbldSjW4VAL()
	{
		return Guid.NewGuid();
	}

	internal static object z5TRpKEqaLIQ0GUqpYRX(object P_0)
	{
		return ((FindViewInfo)P_0).ViewName;
	}

	internal static bool yJEajZEqDufDqgFZri0r(object P_0)
	{
		return ((FindViewInfo)P_0).IsPartial;
	}

	internal static bool dhKGc4EqtjmSMDTLKw5E(object P_0)
	{
		return ((FindViewInfo)P_0).IsFound;
	}

	internal static object A5N5R6Eqw23yWXa0icEg(object P_0)
	{
		return ((FindViewInfo)P_0).ControllerContext;
	}

	internal static object myl0c6Eq4IZkk59NhTfY(object P_0, object P_1)
	{
		return StringFormattingExtensions.FormatWith((string)P_0, (object[])P_1);
	}

	internal static object g8WOg9Eq6DYXJ3c1EGrQ(object P_0)
	{
		return ((FindViewInfo)P_0).ViewEngineResult;
	}

	internal static object MSIMhtEqHf5YyM9DMq8W(object P_0)
	{
		return ((ViewEngineResult)P_0).get_ViewEngine();
	}

	internal static void M4TbbvEqA4Riw7GJqvhF()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object xsUaCnEq75vjj2uZKBqN(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
