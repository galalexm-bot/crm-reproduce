using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Framework;
using Glimpse.Core.Message;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Glimpse;

internal sealed class GlimpseHelper
{
	public static readonly TimelineCategoryItem FindViewTimelineCategoryItem;

	public static readonly TimelineCategoryItem MethodTimelineCategoryItem;

	public static readonly TimelineCategoryItem MessagePoinTimelineCategoryItem;

	private static List<IGlimpseMessagesMaker> _messagesMakers;

	internal static GlimpseHelper cogSn1EiNrmxIZCdq0Lr;

	internal static bool IsEnabled
	{
		get
		{
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			int num = 3;
			int num2 = num;
			IGlimpseConfiguration currentConfiguration = default(IGlimpseConfiguration);
			RuntimePolicy val = default(RuntimePolicy);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return false;
				case 2:
					if (currentConfiguration != null)
					{
						val = currentConfiguration.get_RuntimePolicyStrategy()();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 1;
						}
					}
					break;
				case 3:
					currentConfiguration = GetCurrentConfiguration();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 2;
					}
					break;
				default:
					return !((Enum)val).HasFlag((Enum)(object)(RuntimePolicy)1);
				}
			}
		}
	}

	private IList<IGlimpseMessagesMaker> MessageMakers => _messagesMakers ?? (_messagesMakers = ComponentManager.Current.GetExtensionPoints<IGlimpseMessagesMaker>().ToList());

	internal static IGlimpseConfiguration GetCurrentConfiguration()
	{
		//Discarded unreachable code: IL_00c5, IL_00d4, IL_0165
		int num = 7;
		int num2 = num;
		GlimpseRuntime val = default(GlimpseRuntime);
		CallContextInfo callContextInfo = default(CallContextInfo);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				return (IGlimpseConfiguration)EucDSUEiHwvoe6NwEy8o(val);
			case 5:
				return null;
			case 9:
				callContextInfo = (CallContextInfo)Dn66FsEitLaa7GitYHum(nlMuPGEiDEeGmUNlUBg3());
				num2 = 3;
				break;
			case 7:
				if (v1Hue8EiaCPgEbPusUnZ() != null)
				{
					num2 = 6;
					break;
				}
				goto case 5;
			case 4:
			case 8:
				return null;
			case 6:
				if (DiagnosticsManager.Enabled)
				{
					num2 = 9;
					break;
				}
				goto IL_007a;
			case 2:
				if (!CheckCurrentUser(callContextInfo.UserName))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto IL_007a;
			case 1:
				if (val == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 3:
				{
					if (callContextInfo == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 2;
				}
				IL_007a:
				obj = InaPCbEi6lZm5YEePqh8(lokxegEiwuxS94vIWdLP(v1Hue8EiaCPgEbPusUnZ()), lssbJwEi4BD1b1IyaxMW(-629844702 ^ -630127038));
				val = (GlimpseRuntime)((obj is GlimpseRuntime) ? obj : null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool AllowCurrentUser()
	{
		int num = 5;
		int num2 = num;
		bool? value = default(bool?);
		bool? value2 = default(bool?);
		while (true)
		{
			switch (num2)
			{
			default:
				if (value.HasValue)
				{
					num2 = 6;
					break;
				}
				value = CheckCurrentUser();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return false;
			case 3:
				value = AllowCurrentUserCtx(value2);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (HttpContext.Current != null)
				{
					value2 = null;
					num2 = 3;
					break;
				}
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return value.Value;
			case 6:
				return value.Value;
			case 1:
				AllowCurrentUserCtx(value);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static bool CheckCurrentUser(string name = null)
	{
		//Discarded unreachable code: IL_00f4, IL_01d1, IL_01e0, IL_0217
		int num = 10;
		string setting = default(string);
		string[] source = default(string[]);
		string name2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return false;
				case 7:
					break;
				case 3:
					if (((HttpContext)v1Hue8EiaCPgEbPusUnZ()).User != null)
					{
						num2 = 14;
						continue;
					}
					goto default;
				case 14:
					if (LasebWEiM8hYQGlTEXmK(eVNahJEiyosG7IDZxRlZ(v1Hue8EiaCPgEbPusUnZ())) != null)
					{
						num2 = 7;
						continue;
					}
					goto default;
				case 4:
					if (DrIGaAEi7plbWfXJNECB(setting))
					{
						num2 = 8;
						continue;
					}
					if (HGxkOCEix9lvAtRp0iIK(setting, lssbJwEi4BD1b1IyaxMW(0x3CE17B75 ^ 0x3CE12925)))
					{
						num2 = 11;
						continue;
					}
					source = (string[])JVU4rlEi07UGCp8u1FBm(setting, new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 6;
					}
					continue;
				case 10:
					if (!Dpo2bHEiAEuaWANtOtqG())
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 9;
						}
					}
					else
					{
						setting = SR.GetSetting((string)lssbJwEi4BD1b1IyaxMW(-672123589 ^ -671848769));
						num2 = 4;
					}
					continue;
				case 9:
					return false;
				case 8:
					return false;
				case 13:
					if (DrIGaAEi7plbWfXJNECB(name2))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 6:
					if (DrIGaAEi7plbWfXJNECB(name))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				case 11:
					return true;
				case 2:
					return source.Contains(name);
				case 1:
					if (H7B4NGEimaiYtD8GqCCA(((HttpContext)v1Hue8EiaCPgEbPusUnZ()).Request))
					{
						num2 = 3;
						continue;
					}
					goto default;
				case 5:
					return source.Contains(name2);
				case 12:
					return false;
				}
				break;
			}
			name2 = ((IIdentity)LasebWEiM8hYQGlTEXmK(eVNahJEiyosG7IDZxRlZ(HttpContext.Current))).Name;
			num = 13;
		}
	}

	private static bool? AllowCurrentUserCtx(bool? value = null)
	{
		if (!value.HasValue)
		{
			return (bool?)HttpContext.Current.Items[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97696798)];
		}
		HttpContext.Current.Items[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A28184)] = value;
		return value;
	}

	internal static void PublishMessage(object message)
	{
		//Discarded unreachable code: IL_006b, IL_007a
		int num = 4;
		IGlimpseConfiguration val = default(IGlimpseConfiguration);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					goto end_IL_0012;
				case 3:
					if (val == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 2:
					return;
				case 1:
					return;
				}
				((IMessageBroker)TZURjJEi9Xk9brVM930Z(val)).Publish<object>(message);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			val = (IGlimpseConfiguration)XOSI5rEiJP1uhw69N1SF();
			num = 3;
		}
	}

	public void OnDiagnosticEvent(DiagnosticsEvent @event)
	{
		//Discarded unreachable code: IL_007a, IL_0089, IL_0099, IL_00a8, IL_00cc
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		int num = 7;
		int num2 = num;
		IGlimpseMessagesMaker glimpseMessagesMaker = default(IGlimpseMessagesMaker);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent = default(IDiagnosticsCallInfoEvent);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (glimpseMessagesMaker == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 5;
					}
				}
				else
				{
					((IEnumerable<object>)GwhF3nERBy8EGh9Fr1LT(glimpseMessagesMaker, _003C_003Ec__DisplayClass10_.@event)).ForEach(PublishMessage);
					num2 = 4;
				}
				break;
			case 3:
				return;
			case 13:
				return;
			case 1:
				if (!KYYMt8EidBNdadN7AA7v())
				{
					num2 = 13;
					break;
				}
				goto case 10;
			case 4:
				return;
			case 9:
				if (diagnosticsCallInfoEvent == null)
				{
					num2 = 3;
					break;
				}
				goto case 11;
			case 7:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 6;
				}
				break;
			case 5:
				diagnosticsCallInfoEvent = _003C_003Ec__DisplayClass10_.@event as IDiagnosticsCallInfoEvent;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 9;
				}
				break;
			case 11:
			{
				BaseMessage baseMessage = new BaseMessage();
				iP4HZHEigZ9qUbV30i90(baseMessage, k2EdAqEirBnFG0CIgV6a(jQug0wEileZyTQ99qWf3(diagnosticsCallInfoEvent)));
				dG5yidEiLDdtM11s43Mn(baseMessage, bgbEM4EiYK9bll1S1Ips(((AbstractCallInfo)jQug0wEileZyTQ99qWf3(diagnosticsCallInfoEvent)).StartTime, lLjfZmEijSdKbZdE8GfR(YOOGkHEi5bimoAdVCiQJ(jQug0wEileZyTQ99qWf3(diagnosticsCallInfoEvent)))));
				rayiKkEisB7L6BcouLEq(baseMessage, bQdl36EiUpJPahMdjv1V(jQug0wEileZyTQ99qWf3(diagnosticsCallInfoEvent)));
				baseMessage.EventName = ((AbstractCallInfo)jQug0wEileZyTQ99qWf3(diagnosticsCallInfoEvent)).Description;
				F5L4eYEizVnqvBkTB4sH(baseMessage, (object)new TimelineCategoryItem((string)NHdPEpEicNDqwcY4Bl2b(diagnosticsCallInfoEvent.Info), (string)lssbJwEi4BD1b1IyaxMW(-1852837372 ^ -1853120028), (string)lssbJwEi4BD1b1IyaxMW(-1837662597 ^ -1837945463)));
				t24vXpERFroFBeU5WMfL(baseMessage);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 8:
				return;
			case 12:
				glimpseMessagesMaker = MessageMakers.FirstOrDefault(_003C_003Ec__DisplayClass10_._003COnDiagnosticEvent_003Eb__0);
				num2 = 2;
				break;
			case 10:
				if (_003C_003Ec__DisplayClass10_.@event == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 12;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass10_.@event = @event;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public GlimpseHelper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		c5qE2vERWiZLvff77FLA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static GlimpseHelper()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				MethodTimelineCategoryItem = new TimelineCategoryItem((string)lssbJwEi4BD1b1IyaxMW(-1487388570 ^ -1487119004), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822641616), (string)lssbJwEi4BD1b1IyaxMW(0x20261A4F ^ 0x20224E75));
				num2 = 2;
				break;
			case 0:
				return;
			case 3:
				FindViewTimelineCategoryItem = new TimelineCategoryItem(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36011215), (string)lssbJwEi4BD1b1IyaxMW(0x103FE975 ^ 0x103BBD71), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957573546));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				c5qE2vERWiZLvff77FLA();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				MessagePoinTimelineCategoryItem = new TimelineCategoryItem((string)lssbJwEi4BD1b1IyaxMW(0x2A7797B7 ^ 0x2A73C3FB), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3575744), (string)lssbJwEi4BD1b1IyaxMW(0x53CACA3 ^ 0x538F8CF));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool GcKFgdEi3LqPMrZIjh8d()
	{
		return cogSn1EiNrmxIZCdq0Lr == null;
	}

	internal static GlimpseHelper cfk4IMEiptZm7iF4giqm()
	{
		return cogSn1EiNrmxIZCdq0Lr;
	}

	internal static object v1Hue8EiaCPgEbPusUnZ()
	{
		return HttpContext.Current;
	}

	internal static object nlMuPGEiDEeGmUNlUBg3()
	{
		return DiagnosticsManager.Instance;
	}

	internal static object Dn66FsEitLaa7GitYHum(object P_0)
	{
		return ((DiagnosticsManager)P_0).GetCurrentDiagnosticSession();
	}

	internal static object lokxegEiwuxS94vIWdLP(object P_0)
	{
		return ((HttpContext)P_0).Application;
	}

	internal static object lssbJwEi4BD1b1IyaxMW(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object InaPCbEi6lZm5YEePqh8(object P_0, object P_1)
	{
		return ((HttpApplicationState)P_0)[(string)P_1];
	}

	internal static object EucDSUEiHwvoe6NwEy8o(object P_0)
	{
		return ((GlimpseRuntime)P_0).get_Configuration();
	}

	internal static bool Dpo2bHEiAEuaWANtOtqG()
	{
		return DiagnosticsManager.Enabled;
	}

	internal static bool DrIGaAEi7plbWfXJNECB(object P_0)
	{
		return ((string)P_0).IsNullOrWhiteSpace();
	}

	internal static bool HGxkOCEix9lvAtRp0iIK(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object JVU4rlEi07UGCp8u1FBm(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((char[])P_1, P_2);
	}

	internal static bool H7B4NGEimaiYtD8GqCCA(object P_0)
	{
		return ((HttpRequest)P_0).IsAuthenticated;
	}

	internal static object eVNahJEiyosG7IDZxRlZ(object P_0)
	{
		return ((HttpContext)P_0).User;
	}

	internal static object LasebWEiM8hYQGlTEXmK(object P_0)
	{
		return ((IPrincipal)P_0).Identity;
	}

	internal static object XOSI5rEiJP1uhw69N1SF()
	{
		return GetCurrentConfiguration();
	}

	internal static object TZURjJEi9Xk9brVM930Z(object P_0)
	{
		return ((IGlimpseConfiguration)P_0).get_MessageBroker();
	}

	internal static bool KYYMt8EidBNdadN7AA7v()
	{
		return IsEnabled;
	}

	internal static object jQug0wEileZyTQ99qWf3(object P_0)
	{
		return ((IDiagnosticsCallInfoEvent)P_0).Info;
	}

	internal static DateTime k2EdAqEirBnFG0CIgV6a(object P_0)
	{
		return ((AbstractCallInfo)P_0).StartTime;
	}

	internal static void iP4HZHEigZ9qUbV30i90(object P_0, DateTime value)
	{
		((BaseMessage)P_0).StartTime = value;
	}

	internal static object YOOGkHEi5bimoAdVCiQJ(object P_0)
	{
		return ((AbstractCallInfo)P_0).ContextInfo;
	}

	internal static DateTime lLjfZmEijSdKbZdE8GfR(object P_0)
	{
		return ((CallContextInfo)P_0).StartTime;
	}

	internal static TimeSpan bgbEM4EiYK9bll1S1Ips(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static void dG5yidEiLDdtM11s43Mn(object P_0, TimeSpan value)
	{
		((BaseMessage)P_0).Offset = value;
	}

	internal static TimeSpan bQdl36EiUpJPahMdjv1V(object P_0)
	{
		return ((AbstractCallInfo)P_0).TotalTime;
	}

	internal static void rayiKkEisB7L6BcouLEq(object P_0, TimeSpan value)
	{
		((BaseMessage)P_0).Duration = value;
	}

	internal static object NHdPEpEicNDqwcY4Bl2b(object P_0)
	{
		return ((AbstractCallInfo)P_0).CallType;
	}

	internal static void F5L4eYEizVnqvBkTB4sH(object P_0, object P_1)
	{
		((BaseMessage)P_0).EventCategory = (TimelineCategoryItem)P_1;
	}

	internal static void t24vXpERFroFBeU5WMfL(object P_0)
	{
		PublishMessage(P_0);
	}

	internal static object GwhF3nERBy8EGh9Fr1LT(object P_0, object P_1)
	{
		return ((IGlimpseMessagesMaker)P_0).MakeMessages((DiagnosticsEvent)P_1);
	}

	internal static void c5qE2vERWiZLvff77FLA()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
