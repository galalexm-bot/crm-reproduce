using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class BoolSettings : SimpleTypeSettings, IHasDefaultValue<bool>, IHasDefaultValue<bool?>
{
	private static class __Resources
	{
		internal static object TJ1bJ9CKUPf1bpYVWoyg;

		public static string DisplayType => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A3661A2), BoolDisplayType.RadioButtons, BoolDisplayType.Checkbox, BoolDisplayType.Switch);

		public static string YesText => (string)lEduTbCXFnul8FXeVviw(p57eoWCKzYTZ3YLVJI54(-882126494 ^ -881954496));

		public static string NoText => SR.T((string)p57eoWCKzYTZ3YLVJI54(-70007027 ^ -69834913));

		internal static bool LTo8XtCKsM5WqTdW4wxW()
		{
			return TJ1bJ9CKUPf1bpYVWoyg == null;
		}

		internal static __Resources EgT0NtCKcl1dSMpQVEDp()
		{
			return (__Resources)TJ1bJ9CKUPf1bpYVWoyg;
		}

		internal static object p57eoWCKzYTZ3YLVJI54(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object lEduTbCXFnul8FXeVviw(object P_0)
		{
			return SR.T((string)P_0);
		}
	}

	internal static BoolSettings iFVum4bFgdeTpAWfnib9;

	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "YesText")]
	[DefaultValue("")]
	[XmlElement("YesText")]
	public string YesText
	{
		[CompilerGenerated]
		get
		{
			return _003CYesText_003Ek__BackingField;
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
					_003CYesText_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	[XmlElement("NoText")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "NoText")]
	public string NoText
	{
		[CompilerGenerated]
		get
		{
			return _003CNoText_003Ek__BackingField;
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
					_003CNoText_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	[JsonSerializationIgnore]
	[PublicationBehaviour(PublicationType.Delta)]
	public bool? BoolDefaultValue { get; set; }

	[PublicationBehaviour(PublicationType.Delta)]
	[DefaultValue(null)]
	[JsonSerializationIgnore]
	[XmlElement("DefaultValue")]
	public string DefaultValueStr
	{
		get
		{
			int num = 1;
			int num2 = num;
			bool valueOrDefault = default(bool);
			bool? boolDefaultValue = default(bool?);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return valueOrDefault.ToString();
				case 1:
					boolDefaultValue = BoolDefaultValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return null;
				}
				if (!boolDefaultValue.HasValue)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					valueOrDefault = boolDefaultValue.GetValueOrDefault();
					num2 = 3;
				}
			}
		}
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
					BoolDefaultValue = (kBiaP6bFL2wLWMuGwugc(value) ? null : new bool?(bool.Parse(value)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	[Obsolete("Use BoolDefaultValue property instead", true)]
	[JsonSerializationIgnore]
	public bool DefaultValue
	{
		get
		{
			//Discarded unreachable code: IL_0069, IL_0078
			int num = 1;
			int num2 = num;
			bool? boolDefaultValue = default(bool?);
			while (true)
			{
				switch (num2)
				{
				default:
					if (boolDefaultValue.HasValue)
					{
						num2 = 3;
						break;
					}
					goto case 2;
				case 1:
					boolDefaultValue = BoolDefaultValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return false;
				case 3:
					return boolDefaultValue.GetValueOrDefault();
				}
			}
		}
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
					BoolDefaultValue = (value ? new bool?(true) : null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	[JsonSerializationIgnore]
	bool? IHasDefaultValue<bool?>.DefaultValue
	{
		get
		{
			return BoolDefaultValue;
		}
		set
		{
			BoolDefaultValue = value;
		}
	}

	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "DisplayType")]
	[DefaultValue(BoolDisplayType.RadioButtons)]
	[XmlElement("DisplayType")]
	public BoolDisplayType DisplayType
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayType_003Ek__BackingField;
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
					_003CDisplayType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public BoolSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TEE548bFYtlRrLC7L8pM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected BoolSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		TEE548bFYtlRrLC7L8pM();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void TEE548bFYtlRrLC7L8pM()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool frvyljbF5M2oohbYpuvR()
	{
		return iFVum4bFgdeTpAWfnib9 == null;
	}

	internal static BoolSettings clxLgkbFjYcKYLBjI2Eg()
	{
		return iFVum4bFgdeTpAWfnib9;
	}

	internal static bool kBiaP6bFL2wLWMuGwugc(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
