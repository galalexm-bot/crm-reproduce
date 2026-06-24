using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Notifications.Impl.TemplateGenerator;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Components;

[Component]
public class NotificationUserFunctions : INotificationFunctions
{
	private struct UserField
	{
		private static object m5VcVDpUbbyglyIfa7jc;

		public string Id
		{
			[CompilerGenerated]
			get
			{
				return _003CId_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public string ShortName
		{
			[CompilerGenerated]
			get
			{
				return _003CShortName_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CShortName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		internal static bool mPdj05pUSNVvpBPS1sAL()
		{
			return m5VcVDpUbbyglyIfa7jc == null;
		}

		internal static object vMXQoZpU9mkHhsufyWW6()
		{
			return m5VcVDpUbbyglyIfa7jc;
		}
	}

	internal static NotificationUserFunctions hkyjqu1eb64FHfo102Q;

	public static FormatedValue UserShortName(FunctionEvaluationContext context)
	{
		int num = 1;
		int num2 = num;
		UserField userField = default(UserField);
		while (true)
		{
			switch (num2)
			{
			default:
				return (FormatedValue)aVSlqa1HWBfDuwxAjXA(context, userField);
			case 1:
				ExtractUserField(context, out userField);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static FormatedValue GenerateUserShortName(object context, UserField userField)
	{
		//Discarded unreachable code: IL_00a8, IL_00b7
		int num = 1;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				JAlKLY1PmxUhcIyImW0(stringBuilder, userField.ShortName);
				num2 = 3;
				break;
			default:
				JAlKLY1PmxUhcIyImW0(stringBuilder, EHPFb112GKD2MbXTxBC(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-179348817 ^ -179418657), text, userField.Id, userField.ShortName));
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
			case 4:
				return new FormatedValue(new HtmlString(stringBuilder.ToString()));
			case 1:
			{
				TemplateRenderMode num3 = qEVJsy1Rogq2eWf982R(J3c8Jq1a1bHjVB3FtKd(context));
				text = "";
				if (Locator.Initialized)
				{
					CommonSettingsModule service = Locator.GetService<CommonSettingsModule>();
					if (service != null)
					{
						text = (string)G4Ncl51wqR2fWMV5EHQ(service.Settings);
					}
				}
				stringBuilder = new StringBuilder();
				if (num3 == TemplateRenderMode.HTML)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
			}
		}
	}

	private static void ExtractUserField(object context, out UserField userField)
	{
		//Discarded unreachable code: IL_005a, IL_00eb
		int num = 6;
		FormatedValue formatedValue = default(FormatedValue);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 6:
					userField = default(UserField);
					num = 5;
					break;
				case 7:
					return;
				default:
					if (formatedValue == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						user = x8DQqI1CDiFEdJl7qWj(formatedValue) as EleWise.ELMA.Security.Models.IUser;
						num2 = 8;
					}
					continue;
				case 2:
					return;
				case 5:
					if (wcmpRi1vQVaT0IG3jTs(((FunctionEvaluationContext)context).Parameters) >= 1)
					{
						num = 3;
						break;
					}
					goto case 4;
				case 4:
					obj = null;
					goto IL_0126;
				case 8:
					if (user != null)
					{
						userField = new UserField
						{
							Id = user.Id.ToString(),
							ShortName = (string)z2Sqna1UQQ4ETM7EdbO(user)
						};
						num2 = 7;
					}
					else
					{
						num2 = 2;
					}
					continue;
				case 1:
					return;
				case 3:
					{
						obj = ((FunctionEvaluationContext)context).Parameters[0];
						goto IL_0126;
					}
					IL_0126:
					formatedValue = (FormatedValue)obj;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	public NotificationUserFunctions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		etTmAF1o4L80KnGTxXj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object aVSlqa1HWBfDuwxAjXA(object P_0, UserField userField)
	{
		return GenerateUserShortName(P_0, userField);
	}

	internal static bool Q5eL6f1LvWvsIXw9AIR()
	{
		return hkyjqu1eb64FHfo102Q == null;
	}

	internal static NotificationUserFunctions khbLEv1jhNOLkyQss3U()
	{
		return hkyjqu1eb64FHfo102Q;
	}

	internal static object J3c8Jq1a1bHjVB3FtKd(object P_0)
	{
		return ((FunctionEvaluationContext)P_0).GenerationContext;
	}

	internal static TemplateRenderMode qEVJsy1Rogq2eWf982R(object P_0)
	{
		return ((GenerationContext)P_0).GetRenderMode();
	}

	internal static object G4Ncl51wqR2fWMV5EHQ(object P_0)
	{
		return ((CommonSettings)P_0).ApplicationBaseUrl;
	}

	internal static object EHPFb112GKD2MbXTxBC(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object JAlKLY1PmxUhcIyImW0(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static int wcmpRi1vQVaT0IG3jTs(object P_0)
	{
		return ((List<FormatedValue>)P_0).Count;
	}

	internal static object x8DQqI1CDiFEdJl7qWj(object P_0)
	{
		return ((FormatedValue)P_0).Value;
	}

	internal static object z2Sqna1UQQ4ETM7EdbO(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).GetShortName();
	}

	internal static void etTmAF1o4L80KnGTxXj()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
