using System;
using System.ComponentModel;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Attributes;

public class LocalizedStringAttribute : System.ComponentModel.DescriptionAttribute
{
	private class PropertyLocalizer : SR.ILocalizer
	{
		private readonly object propInfo;

		internal static object ndyJSvCGgMBWSds6cjf5;

		public PropertyLocalizer(PropertyInfo propInfo)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			cn5hnZCGYQcxZqyr1mxj();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					this.propInfo = propInfo;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public string Localize()
		{
			return (string)DUljbJCGLVnARA2YiLrU(propInfo, null, null);
		}

		internal static void cn5hnZCGYQcxZqyr1mxj()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool xLTRFGCG5LutMrP5PnIg()
		{
			return ndyJSvCGgMBWSds6cjf5 == null;
		}

		internal static PropertyLocalizer w2aLZvCGjDJaTrQ0BYnd()
		{
			return (PropertyLocalizer)ndyJSvCGgMBWSds6cjf5;
		}

		internal static object DUljbJCGLVnARA2YiLrU(object P_0, object P_1, object P_2)
		{
			return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
		}
	}

	private class ExceptionLocalizer : SR.ILocalizer
	{
		private readonly object exception;

		internal static object AEQDCSCGUhATOnXckymP;

		public ExceptionLocalizer(Exception exception)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				this.exception = exception;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num = 1;
				}
			}
		}

		public string Localize()
		{
			throw exception;
		}

		internal static bool qEwRDrCGsyhJXfdGOOyr()
		{
			return AEQDCSCGUhATOnXckymP == null;
		}

		internal static ExceptionLocalizer KdPZOVCGcHXDS0oEHeg6()
		{
			return (ExceptionLocalizer)AEQDCSCGUhATOnXckymP;
		}
	}

	protected Type staticResourceType;

	protected string propertyName;

	private readonly string value;

	private bool containsKey;

	internal static LocalizedStringAttribute eqBaqioI0IP71LOjRkcB;

	public string Value
	{
		get
		{
			//Discarded unreachable code: IL_0079, IL_0088
			int num = 4;
			int num2 = num;
			while (true)
			{
				PropertyInfo property;
				switch (num2)
				{
				case 3:
					if (fUbOncoI9FeJML1BvYGa(staticResourceType, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_00af;
				case 4:
					if (value == null)
					{
						num2 = 3;
						break;
					}
					goto IL_00af;
				default:
					throw new NullReferenceException((string)VkJGJwoIdAUK4muTBMFp(-1108654032 ^ -1108799206));
				case 1:
					if (containsKey)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 2;
				case 2:
					return value;
				case 5:
					{
						return SR.T(value);
					}
					IL_00af:
					if (value != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 1;
						}
						break;
					}
					property = staticResourceType.GetProperty(propertyName);
					if (BXQj1WoIlV8o77hn0h8j(property, null))
					{
						throw new NullReferenceException((string)QbniODoIrrjW6rLQ8caR(VkJGJwoIdAUK4muTBMFp(0x1637C429 ^ 0x16359DAD), propertyName, staticResourceType.FullName));
					}
					return (string)xfraoEoIgiXu3R2yxSgb(property, null, null);
				}
			}
		}
	}

	public override string Description => Value;

	internal SR.LocalizableString LocalizedString
	{
		get
		{
			//Discarded unreachable code: IL_00f0, IL_00ff, IL_0169, IL_0178, IL_0188, IL_0197
			int num = 2;
			int num2 = num;
			PropertyInfo property = default(PropertyInfo);
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (!containsKey)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return (SR.LocalizableString)BcLQW1oIYMdaFs73tdGt(new SR.LocalizableString.SRTLocalizer((string)vRGLZToIj3AGOD3mdnxk(value)));
				case 2:
					if (value != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 9;
				case 7:
					return SR.LocalizableString.Create(new ExceptionLocalizer(new NullReferenceException((string)VkJGJwoIdAUK4muTBMFp(-812025778 ^ -811916956))));
				case 1:
					if (value == null)
					{
						num2 = 6;
						break;
					}
					goto case 5;
				case 4:
					if (!BXQj1WoIlV8o77hn0h8j(property, null))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				default:
					return (SR.LocalizableString)nRe6r3oI5Ut6oCAYgRuZ(value);
				case 6:
					property = staticResourceType.GetProperty(propertyName);
					num2 = 4;
					break;
				case 9:
					if (fUbOncoI9FeJML1BvYGa(staticResourceType, null))
					{
						num2 = 7;
						break;
					}
					goto case 1;
				case 3:
					return (SR.LocalizableString)BcLQW1oIYMdaFs73tdGt(new ExceptionLocalizer(new NullReferenceException((string)QbniODoIrrjW6rLQ8caR(VkJGJwoIdAUK4muTBMFp(0x7247028A ^ 0x72455B0E), propertyName, staticResourceType.FullName))));
				case 8:
					return (SR.LocalizableString)BcLQW1oIYMdaFs73tdGt(new PropertyLocalizer(property));
				}
			}
		}
	}

	public LocalizedStringAttribute(Type staticResourceType, string propertyName)
	{
		//Discarded unreachable code: IL_001e
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				this.staticResourceType = staticResourceType;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				this.propertyName = propertyName;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public LocalizedStringAttribute(string value)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		pwaBDjoIM4k7b8gNa7x1();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				containsKey = Rk2mZCoIJ22Yf19I0i25(value);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				this.value = value ?? "";
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static bool InyakvoImgqtVXP5kObN()
	{
		return eqBaqioI0IP71LOjRkcB == null;
	}

	internal static LocalizedStringAttribute i1NOoQoIyE47pC91ycMg()
	{
		return eqBaqioI0IP71LOjRkcB;
	}

	internal static void pwaBDjoIM4k7b8gNa7x1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Rk2mZCoIJ22Yf19I0i25(object P_0)
	{
		return SR.ContainsKey((string)P_0);
	}

	internal static bool fUbOncoI9FeJML1BvYGa(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object VkJGJwoIdAUK4muTBMFp(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool BXQj1WoIlV8o77hn0h8j(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object QbniODoIrrjW6rLQ8caR(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object xfraoEoIgiXu3R2yxSgb(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static object nRe6r3oI5Ut6oCAYgRuZ(object P_0)
	{
		return (SR.LocalizableString)(string)P_0;
	}

	internal static object vRGLZToIj3AGOD3mdnxk(object P_0)
	{
		return SR.ExtractKeyFromString((string)P_0);
	}

	internal static object BcLQW1oIYMdaFs73tdGt(object P_0)
	{
		return SR.LocalizableString.Create((SR.ILocalizer)P_0);
	}
}
