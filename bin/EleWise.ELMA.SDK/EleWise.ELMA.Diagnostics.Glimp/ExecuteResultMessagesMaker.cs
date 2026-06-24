using System;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Events;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Message;
using Glimpse.Mvc.Message;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers;

[Component]
internal class ExecuteResultMessagesMaker : AbstractMessagesMaker
{
	private static readonly MethodInfo MethodInfo;

	internal static ExecuteResultMessagesMaker iWpfNMEqxiJYwrCnkWr0;

	public override Type[] SupportedEventTypes => new Type[2]
	{
		TypeOf<ExecuteResultCallEndEvent>.Raw,
		TypeOf<ExecuteResultCallErrorEvent>.Raw
	};

	public override object[] MakeMessages(DiagnosticsEvent @event)
	{
		//Discarded unreachable code: IL_0070, IL_007f
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d0: Expected O, but got Unknown
		int num = 1;
		IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent = default(IDiagnosticsCallInfoEvent);
		ExecuteResultCallInfo executeResultCallInfo = default(ExecuteResultCallInfo);
		TimerResult val = default(TimerResult);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (diagnosticsCallInfoEvent != null)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 1:
					diagnosticsCallInfoEvent = @event as IDiagnosticsCallInfoEvent;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return new object[0];
				case 3:
				{
					TimerResult val2 = new TimerResult();
					qF0sveEqM1ieuNQYrWh8((object)val2, x54ToWEqyasoD6x5JPws(executeResultCallInfo));
					val2.set_Offset(om9PqIEqdu6keMIpVrym(x54ToWEqyasoD6x5JPws(executeResultCallInfo), PjlGwtEq9lMFYi7ZHDw3(JHU2uEEqJZBPSPCWjqYe(executeResultCallInfo))));
					CnuN1HEqrQKpAv8OGroQ((object)val2, Dtd2VJEqlb3nZ2W2s8Ec(executeResultCallInfo));
					val = val2;
					num2 = 5;
					break;
				}
				case 4:
					if ((executeResultCallInfo = diagnosticsCallInfoEvent.Info as ExecuteResultCallInfo) != null)
					{
						num2 = 3;
						break;
					}
					goto case 2;
				case 5:
				{
					object[] array = new object[1];
					ExecuteResultMessage executeResultMessage = new ExecuteResultMessage();
					HY9MR4EqjPMnri9yBa8v(executeResultMessage, (JOluJdEqg8pO3efREk9H(executeResultCallInfo) != null) ? VNCnLCEq5iNH5exULxcb(JOluJdEqg8pO3efREk9H(executeResultCallInfo)) : "");
					array[0] = TimedMessageExtension.AsTimedMessage<ExecuteResultMessage>(ChildActionMessageExtension.AsChildActionMessage<ExecuteResultMessage>(MvcTimelineExtension.AsMvcTimelineMessage<ExecuteResultMessage>(ActionMessageExtension.AsActionMessage<ExecuteResultMessage>(SourceMessageExtension.AsSourceMessage<ExecuteResultMessage>(executeResultMessage, ((object)((ControllerContext)OZ2Jo2EqYw9E8Ze9VMtg(executeResultCallInfo)).get_Controller()).GetType(), MethodInfo), (ControllerContext)(object)executeResultCallInfo.ResultExecutingContext), MvcTimelineCategory.get_Controller()), (ControllerContext)OZ2Jo2EqYw9E8Ze9VMtg(executeResultCallInfo)), val);
					return array;
				}
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public ExecuteResultMessagesMaker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vMRHk9EqLFTQx8MG7I3i();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ExecuteResultMessagesMaker()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				vMRHk9EqLFTQx8MG7I3i();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			MethodInfo = TypeOf<ActionResult>.Raw.GetMethod((string)nLcmUpEqU5XgE0YsceOG(-606654180 ^ -606923260), new Type[1] { TypeOf<ControllerContext>.Raw });
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
			{
				num2 = 2;
			}
		}
	}

	internal static bool YPqnMjEq01QJoaF8yUXB()
	{
		return iWpfNMEqxiJYwrCnkWr0 == null;
	}

	internal static ExecuteResultMessagesMaker xBZbklEqmc2tgYljHqyP()
	{
		return iWpfNMEqxiJYwrCnkWr0;
	}

	internal static DateTime x54ToWEqyasoD6x5JPws(object P_0)
	{
		return ((AbstractCallInfo)P_0).StartTime;
	}

	internal static void qF0sveEqM1ieuNQYrWh8(object P_0, DateTime P_1)
	{
		((TimerResult)P_0).set_StartTime(P_1);
	}

	internal static object JHU2uEEqJZBPSPCWjqYe(object P_0)
	{
		return ((AbstractCallInfo)P_0).ContextInfo;
	}

	internal static DateTime PjlGwtEq9lMFYi7ZHDw3(object P_0)
	{
		return ((CallContextInfo)P_0).StartTime;
	}

	internal static TimeSpan om9PqIEqdu6keMIpVrym(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static TimeSpan Dtd2VJEqlb3nZ2W2s8Ec(object P_0)
	{
		return ((AbstractCallInfo)P_0).TotalTime;
	}

	internal static void CnuN1HEqrQKpAv8OGroQ(object P_0, TimeSpan P_1)
	{
		((TimerResult)P_0).set_Duration(P_1);
	}

	internal static object JOluJdEqg8pO3efREk9H(object P_0)
	{
		return ((AbstractCallInfo)P_0).Exception;
	}

	internal static object VNCnLCEq5iNH5exULxcb(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void HY9MR4EqjPMnri9yBa8v(object P_0, object P_1)
	{
		((BaseMessage)P_0).EventSubText = (string)P_1;
	}

	internal static object OZ2Jo2EqYw9E8Ze9VMtg(object P_0)
	{
		return ((ExecuteResultCallInfo)P_0).ResultExecutingContext;
	}

	internal static void vMRHk9EqLFTQx8MG7I3i()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object nLcmUpEqU5XgE0YsceOG(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
