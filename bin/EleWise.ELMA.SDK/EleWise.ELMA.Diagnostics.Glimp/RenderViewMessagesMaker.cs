using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Events;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Extensions;
using Glimpse.Core.Message;
using Glimpse.Core.Tab.Assist;
using Glimpse.Mvc.AlternateType;
using Glimpse.Mvc.Message;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers;

[Component]
internal class RenderViewMessagesMaker : AbstractMessagesMaker
{
	private static RenderViewMessagesMaker yNZKFQERAgOBnYRoqwRv;

	public override Type[] SupportedEventTypes => new Type[2]
	{
		TypeOf<RenderViewEndEvent>.Raw,
		TypeOf<RenderViewStartEvent>.Raw
	};

	public override object[] MakeMessages(DiagnosticsEvent @event)
	{
		//Discarded unreachable code: IL_01cd
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		int num = 4;
		int num2 = num;
		IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent = default(IDiagnosticsCallInfoEvent);
		RenderViewInfo renderViewInfo = default(RenderViewInfo);
		TimerResult val = default(TimerResult);
		Type typeOrNull = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (diagnosticsCallInfoEvent != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			default:
				if ((renderViewInfo = WJbPFMER06faKNevRBTE(diagnosticsCallInfoEvent) as RenderViewInfo) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 2:
				return new object[0];
			case 1:
			{
				TimerResult val2 = new TimerResult();
				val2.set_StartTime(QcrZXcERmqVbkoNMxUAq(renderViewInfo));
				HC2s0AER9NT7DPYmyic5((object)val2, twBjPeERJk4mjB7UC2tt(QcrZXcERmqVbkoNMxUAq(renderViewInfo), Es5CexERMlJJexnt8Dts(amx6yEERy6rdAN9YeXwp(renderViewInfo))));
				val2.set_Duration(zrAUiJERdjL6d68YDBpJ(renderViewInfo));
				val = val2;
				num2 = 5;
				break;
			}
			case 4:
				diagnosticsCallInfoEvent = @event as IDiagnosticsCallInfoEvent;
				num2 = 3;
				break;
			case 5:
				typeOrNull = ObjectExtensions.GetTypeOrNull(Y28kDLERgK8xPBuTpl2f(kFwjcdERrS4gG4tYfHgf(qsEyDZERldMNyACInyhl(renderViewInfo))));
				num2 = 6;
				break;
			case 6:
				return new object[1] { TimedMessageExtension.AsTimedMessage<Message>(TimelineMessageExtension.AsTimelineMessage<Message>(ActionMessageExtension.AsActionMessage<Message>(new Message(typeOrNull, ((ModelStateDictionary)Mr1JnWER52Y5Y2ICGmZ8(kFwjcdERrS4gG4tYfHgf(qsEyDZERldMNyACInyhl(renderViewInfo)))).get_IsValid(), (IDictionary<string, object>)((ViewContext)qsEyDZERldMNyACInyhl(renderViewInfo)).get_TempData(), (IDictionary<string, object>)kFwjcdERrS4gG4tYfHgf(qsEyDZERldMNyACInyhl(renderViewInfo)), (ModelMetadata)I9Ho7gERj1h9Weg6nhja(((ViewContext)qsEyDZERldMNyACInyhl(renderViewInfo)).get_ViewData()), htk39uERYrMYp8jL0NrI(qsEyDZERldMNyACInyhl(renderViewInfo)).GetType(), (IViewCorrelationMixin)new ViewCorrelationMixin(renderViewInfo.VirtualPath, AxOwZtERLfrgAYC9YoAk(renderViewInfo), Cml9U2ERUSLOaWn6Rlg2())), (ControllerContext)(object)renderViewInfo.ViewContext), (string)La8khRERz2OgxC1vrJVg(u9GHKfERs8CgGPBymrOH(--1333735954 ^ 0x4F7B666C), new object[1] { BwAeuNERcxan8OF6NgIe(renderViewInfo) }), (TimelineCategoryItem)WabGaOEqF1yS4d1WYay3(), (string)null), val) };
			}
		}
	}

	public RenderViewMessagesMaker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool YfFFjeER73OfZf4GGUe6()
	{
		return yNZKFQERAgOBnYRoqwRv == null;
	}

	internal static RenderViewMessagesMaker mJX2yrERxfkjDXQZVQc1()
	{
		return yNZKFQERAgOBnYRoqwRv;
	}

	internal static object WJbPFMER06faKNevRBTE(object P_0)
	{
		return ((IDiagnosticsCallInfoEvent)P_0).Info;
	}

	internal static DateTime QcrZXcERmqVbkoNMxUAq(object P_0)
	{
		return ((AbstractCallInfo)P_0).StartTime;
	}

	internal static object amx6yEERy6rdAN9YeXwp(object P_0)
	{
		return ((AbstractCallInfo)P_0).ContextInfo;
	}

	internal static DateTime Es5CexERMlJJexnt8Dts(object P_0)
	{
		return ((CallContextInfo)P_0).StartTime;
	}

	internal static TimeSpan twBjPeERJk4mjB7UC2tt(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static void HC2s0AER9NT7DPYmyic5(object P_0, TimeSpan P_1)
	{
		((TimerResult)P_0).set_Offset(P_1);
	}

	internal static TimeSpan zrAUiJERdjL6d68YDBpJ(object P_0)
	{
		return ((AbstractCallInfo)P_0).TotalTime;
	}

	internal static object qsEyDZERldMNyACInyhl(object P_0)
	{
		return ((RenderViewInfo)P_0).ViewContext;
	}

	internal static object kFwjcdERrS4gG4tYfHgf(object P_0)
	{
		return ((ViewContext)P_0).get_ViewData();
	}

	internal static object Y28kDLERgK8xPBuTpl2f(object P_0)
	{
		return ((ViewDataDictionary)P_0).get_Model();
	}

	internal static object Mr1JnWER52Y5Y2ICGmZ8(object P_0)
	{
		return ((ViewDataDictionary)P_0).get_ModelState();
	}

	internal static object I9Ho7gERj1h9Weg6nhja(object P_0)
	{
		return ((ViewDataDictionary)P_0).get_ModelMetadata();
	}

	internal static object htk39uERYrMYp8jL0NrI(object P_0)
	{
		return ((ViewContext)P_0).get_View();
	}

	internal static bool AxOwZtERLfrgAYC9YoAk(object P_0)
	{
		return ((RenderViewInfo)P_0).IsPartial;
	}

	internal static Guid Cml9U2ERUSLOaWn6Rlg2()
	{
		return Guid.NewGuid();
	}

	internal static object u9GHKfERs8CgGPBymrOH(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object BwAeuNERcxan8OF6NgIe(object P_0)
	{
		return ((RenderViewInfo)P_0).VirtualPath;
	}

	internal static object La8khRERz2OgxC1vrJVg(object P_0, object P_1)
	{
		return StringFormattingExtensions.FormatWith((string)P_0, (object[])P_1);
	}

	internal static object WabGaOEqF1yS4d1WYay3()
	{
		return MvcTimelineCategory.get_View();
	}
}
