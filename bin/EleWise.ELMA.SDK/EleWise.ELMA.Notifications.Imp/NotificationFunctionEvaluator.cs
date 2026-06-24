using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl.TemplateGenerator;

public class NotificationFunctionEvaluator : ElmaGeneratorFunctionEvaluator
{
	private NotificationTemplateBase notificationTemplate;

	private static NotificationFunctionEvaluator BvfcYP6lpHXgorr9li6;

	public NotificationFunctionEvaluator(GenerationContext context, NotificationTemplateBase notificationTemplate = null)
	{
		//Discarded unreachable code: IL_001b, IL_0020, IL_0058, IL_0067, IL_0072, IL_0116, IL_0156, IL_0161, IL_0170
		ylwbR765bcT5EJiEtyo();
		base._002Ector(context);
		int num = 6;
		IEnumerator<INotificationFunctions> enumerator = default(IEnumerator<INotificationFunctions>);
		INotificationFunctions current = default(INotificationFunctions);
		IEnumerable<INotificationFunctions> service = default(IEnumerable<INotificationFunctions>);
		while (true)
		{
			switch (num)
			{
			case 7:
				try
				{
					while (true)
					{
						IL_00b3:
						int num2;
						if (!re2SCo6YqoDsUdVqixg(enumerator))
						{
							num2 = 3;
							goto IL_0076;
						}
						goto IL_0090;
						IL_0076:
						while (true)
						{
							switch (num2)
							{
							case 2:
								break;
							default:
								goto IL_00b3;
							case 1:
								RegisterFunctionsContainerType(current.GetType());
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
								{
									num2 = 0;
								}
								continue;
							case 3:
								goto end_IL_00b3;
							}
							break;
						}
						goto IL_0090;
						IL_0090:
						current = enumerator.Current;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num2 = 1;
						}
						goto IL_0076;
						continue;
						end_IL_00b3:
						break;
					}
				}
				finally
				{
					int num3;
					if (enumerator == null)
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num3 = 0;
						}
						goto IL_011a;
					}
					goto IL_0130;
					IL_0130:
					hwetkv6LuZiLhfq6i3c(enumerator);
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num3 = 1;
					}
					goto IL_011a;
					IL_011a:
					switch (num3)
					{
					default:
						goto end_IL_00f5;
					case 2:
						break;
					case 0:
						goto end_IL_00f5;
					case 1:
						goto end_IL_00f5;
					}
					goto IL_0130;
					end_IL_00f5:;
				}
				goto default;
			default:
				xFom3c6scb5pFefQy7e(this, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FF5AEB), GetType().GetMethod((string)ICZBW86UjY7x7Rr2tFL(-1146510045 ^ -1146538863), BindingFlags.Instance | BindingFlags.NonPublic), this);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				xFom3c6scb5pFefQy7e(this, ICZBW86UjY7x7Rr2tFL(0x4D1C1EE4 ^ 0x4D1C8F20), tvJQDh6cK7GHCCqwhEn(this).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A336FF2), BindingFlags.Instance | BindingFlags.NonPublic), this);
				num = 2;
				break;
			case 2:
				return;
			case 6:
				this.notificationTemplate = notificationTemplate;
				num = 5;
				break;
			case 8:
				if (service != null)
				{
					num = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num = 2;
					}
					break;
				}
				goto default;
			case 4:
				enumerator = service.GetEnumerator();
				num = 7;
				break;
			case 5:
				jS0JsW6jYuycMi41E3U(this, typeof(NotificationFunctions));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num = 3;
				}
				break;
			case 3:
				service = Locator.GetService<IEnumerable<INotificationFunctions>>();
				num = 8;
				break;
			}
		}
	}

	private FormatedValue Partial(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_02b9, IL_02c8, IL_02e8, IL_0318, IL_0327, IL_0337
		int num = 12;
		string text2 = default(string);
		string text = default(string);
		NotificationTemplateGenerator notificationTemplateGenerator = default(NotificationTemplateGenerator);
		object value = default(object);
		NotificationPartialTemplate partialTemplate = default(NotificationPartialTemplate);
		TemplateRenderMode renderMode = default(TemplateRenderMode);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
				case 11:
					return new FormatedValue(string.Empty);
				case 19:
					text2 = (string)context.Parameters[0].Value;
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					text = (string)xZmiYZHb6TwAl0l5b2a(notificationTemplateGenerator, wD651AHo25Vq4nRqsUN(context));
					num2 = 5;
					continue;
				case 4:
					if (context.Parameters.Count != 0)
					{
						num2 = 7;
						continue;
					}
					goto case 9;
				case 15:
					notificationTemplateGenerator.Provider.TemplateTimeZoneOffset = (int?)value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					if (context.Parameters[0] != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 9;
				case 12:
					if (notificationTemplate == null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 4;
				case 16:
					if (string.IsNullOrEmpty(text2))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 20;
						}
						continue;
					}
					partialTemplate = ((NotificationTemplateLoader)xJ0qBDHFtn16l4nP1eF(notificationTemplate.FileInfo)).GetPartialTemplate(notificationTemplate.FileInfo, text2);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					if (KJv0Vo6znn6MPHeI3S8(context.Parameters[0]) is string)
					{
						num2 = 19;
						continue;
					}
					goto case 9;
				case 14:
					break;
				case 1:
				case 17:
					return new FormatedValue(text);
				case 18:
					if (renderMode == TemplateRenderMode.HTML)
					{
						return new FormatedValue(MvcHtmlString.Create(text));
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					return new FormatedValue(string.Empty);
				case 13:
					renderMode = ((GenerationContext)v1v6tGHBgCHdaM6nkae(context)).GetRenderMode();
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 14;
					}
					continue;
				case 20:
					return new FormatedValue(string.Empty);
				case 6:
					if (!((GenerationContext)v1v6tGHBgCHdaM6nkae(context)).ExtendedProperties.TryGetValue((string)ICZBW86UjY7x7Rr2tFL(-1334993905 ^ -1335030291), out value))
					{
						num2 = 10;
						continue;
					}
					goto case 15;
				case 3:
					if (partialTemplate != null)
					{
						num2 = 13;
						continue;
					}
					goto case 8;
				case 5:
					if (text == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 18;
				}
				break;
			}
			notificationTemplateGenerator = new NotificationTemplateGenerator((string)pUnT3OHWraespVYsg22(partialTemplate), notificationTemplate, renderMode);
			num = 6;
		}
	}

	private FormatedValue ExtensionZone(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_0125, IL_0134, IL_013f, IL_01d0, IL_0240, IL_0253, IL_0262, IL_02a4, IL_02b3
		int num = 9;
		int num2 = num;
		TemplateRenderMode renderMode = default(TemplateRenderMode);
		StringBuilder stringBuilder = default(StringBuilder);
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		List<INotificationPartialTemplate>.Enumerator enumerator = default(List<INotificationPartialTemplate>.Enumerator);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (renderMode != TemplateRenderMode.HTML)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					break;
				}
				return new FormatedValue(B4STDlHQYtNO8k3OD4W(stringBuilder.ToString()));
			case 4:
			case 6:
				return new FormatedValue(string.Empty);
			case 3:
				if (context.Parameters[0] == null)
				{
					num2 = 4;
					break;
				}
				goto case 1;
			case 7:
			{
				List<INotificationPartialTemplate> list = ((ComponentManager)QF09ofHhUA6VDe6SPvu()).GetExtensionPoints<INotificationTemplateLoader>().SelectMany(_003C_003Ec__DisplayClass4_._003CExtensionZone_003Eb__0).ToList();
				renderMode = ((GenerationContext)v1v6tGHBgCHdaM6nkae(context)).GetRenderMode();
				stringBuilder = new StringBuilder();
				enumerator = list.GetEnumerator();
				num2 = 2;
				break;
			}
			case 1:
				if (context.Parameters[0].Value is string)
				{
					_003C_003Ec__DisplayClass4_.zone = (string)context.Parameters[0].Value;
					num2 = 7;
				}
				else
				{
					num2 = 6;
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						IL_01da:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
							{
								num3 = 2;
							}
							goto IL_0143;
						}
						goto IL_018b;
						IL_018b:
						text = (string)xZmiYZHb6TwAl0l5b2a(new NotificationTemplateGenerator((string)IaaxUJHGhQcYFCVSEy0(enumerator.Current), notificationTemplate, renderMode), wD651AHo25Vq4nRqsUN(context));
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num3 = 1;
						}
						goto IL_0143;
						IL_0143:
						while (true)
						{
							switch (num3)
							{
							case 3:
								if (oPtocWHE9P7rWWhGFD8(text))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 4;
							case 1:
								break;
							default:
								goto IL_01da;
							case 4:
								NH8w0iHf3rTVLfws0n7(stringBuilder, text);
								num3 = 5;
								continue;
							case 2:
								goto end_IL_01da;
							}
							break;
						}
						goto IL_018b;
						continue;
						end_IL_01da:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 5;
			default:
				return new FormatedValue(stringBuilder.ToString());
			case 9:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 8;
				break;
			case 8:
				if (context.Parameters.Count != 0)
				{
					num2 = 3;
					break;
				}
				goto case 4;
			}
		}
	}

	internal static void ylwbR765bcT5EJiEtyo()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void jS0JsW6jYuycMi41E3U(object P_0, Type P_1)
	{
		((GeneratorFunctionEvaluator)P_0).RegisterFunctionsContainerType(P_1);
	}

	internal static bool re2SCo6YqoDsUdVqixg(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void hwetkv6LuZiLhfq6i3c(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object ICZBW86UjY7x7Rr2tFL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void xFom3c6scb5pFefQy7e(object P_0, object P_1, object P_2, object P_3)
	{
		((GeneratorFunctionEvaluator)P_0).RegisterFunction((string)P_1, (MethodInfo)P_2, P_3);
	}

	internal static Type tvJQDh6cK7GHCCqwhEn(object P_0)
	{
		return P_0.GetType();
	}

	internal static bool SiHapY6raGFYUCklbOe()
	{
		return BvfcYP6lpHXgorr9li6 == null;
	}

	internal static NotificationFunctionEvaluator IVDkpc6g3DpIJ5uFhuS()
	{
		return BvfcYP6lpHXgorr9li6;
	}

	internal static object KJv0Vo6znn6MPHeI3S8(object P_0)
	{
		return ((FormatedValue)P_0).Value;
	}

	internal static object xJ0qBDHFtn16l4nP1eF(object P_0)
	{
		return ((NotificationTemplateFileInfo)P_0).Loader;
	}

	internal static object v1v6tGHBgCHdaM6nkae(object P_0)
	{
		return ((FunctionEvaluationContext)P_0).GenerationContext;
	}

	internal static object pUnT3OHWraespVYsg22(object P_0)
	{
		return ((NotificationPartialTemplate)P_0).Content;
	}

	internal static object wD651AHo25Vq4nRqsUN(object P_0)
	{
		return ((FunctionEvaluationContext)P_0).DataSource;
	}

	internal static object xZmiYZHb6TwAl0l5b2a(object P_0, object P_1)
	{
		return ((TextGenerator)P_0).Generate((IGeneratorDataSource)P_1);
	}

	internal static object QF09ofHhUA6VDe6SPvu()
	{
		return ComponentManager.Current;
	}

	internal static object IaaxUJHGhQcYFCVSEy0(object P_0)
	{
		return ((INotificationPartialTemplate)P_0).Content;
	}

	internal static bool oPtocWHE9P7rWWhGFD8(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object NH8w0iHf3rTVLfws0n7(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static object B4STDlHQYtNO8k3OD4W(object P_0)
	{
		return MvcHtmlString.Create((string)P_0);
	}
}
