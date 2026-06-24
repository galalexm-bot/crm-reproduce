using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Web.Mvc;
using System.Xml.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Types.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class StringSettings : SimpleTypeSettings, IHasDefaultValue<string>, IMvcValidatableTypeSettings
{
	private static class __Resources
	{
		internal static object uWU2qUCTzXCHoJryMUZC;

		public static string MinValue => (string)mSh6bDCkoabonsdNr1Oj(iH5G2ICkWsCxJpaR1AXA(-1123633026 ^ -1123869032));

		public static string MaxValue => (string)mSh6bDCkoabonsdNr1Oj(iH5G2ICkWsCxJpaR1AXA(-1751176224 ^ -1751479046));

		public static string MultiLine => (string)mSh6bDCkoabonsdNr1Oj(iH5G2ICkWsCxJpaR1AXA(0x463A0F3C ^ 0x463FA888));

		public static string RegularExpression => (string)mSh6bDCkoabonsdNr1Oj(iH5G2ICkWsCxJpaR1AXA(0x4EA5403C ^ 0x4EA0E856));

		public static string RegularExpressionMessage => (string)mSh6bDCkoabonsdNr1Oj(iH5G2ICkWsCxJpaR1AXA(0x66F566B6 ^ 0x66F0CE60));

		internal static object iH5G2ICkWsCxJpaR1AXA(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object mSh6bDCkoabonsdNr1Oj(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool pL9q1ZCkFQvGLjjOiKYM()
		{
			return uWU2qUCTzXCHoJryMUZC == null;
		}

		internal static __Resources sBbkR3CkBgE9d75GmxyQ()
		{
			return (__Resources)uWU2qUCTzXCHoJryMUZC;
		}
	}

	public const string MAX_LENGTH = "2147483647";

	private static StringSettings bHIunrbWddYcrpvGYn5x;

	[DefaultValue(0)]
	[PublicationBehaviour(PublicationType.Restart)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "MinValue")]
	[XmlElement("MinValue")]
	public int MinValue
	{
		[CompilerGenerated]
		get
		{
			return _003CMinValue_003Ek__BackingField;
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
					_003CMinValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[PublicationBehaviour(PublicationType.Restart)]
	[XmlIgnore]
	public int? MaxValue { get; set; }

	[XmlElement("MaxValue")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "MaxValue")]
	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue(null)]
	public string MaxValueString
	{
		get
		{
			//Discarded unreachable code: IL_004d, IL_005c
			int num = 1;
			int num2 = num;
			int? maxValue = default(int?);
			int value = default(int);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return null;
				case 3:
					maxValue = MaxValue;
					num2 = 4;
					break;
				case 4:
					value = maxValue.Value;
					num2 = 5;
					break;
				default:
					if (maxValue.HasValue)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 2;
				case 1:
					maxValue = MaxValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					return value.ToString();
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_0035, IL_0044
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					MaxValue = int.Parse(value);
					num2 = 4;
					break;
				case 4:
					return;
				case 2:
					MaxValue = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					if (jFcMsAbW5YwNlpewN4AV(value))
					{
						num2 = 2;
						break;
					}
					goto case 1;
				case 0:
					return;
				}
			}
		}
	}

	[DefaultValue(false)]
	[XmlElement("MultiLine")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "MultiLine")]
	public virtual bool MultiLine
	{
		[CompilerGenerated]
		get
		{
			return _003CMultiLine_003Ek__BackingField;
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
					_003CMultiLine_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
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

	[PublicationBehaviour(PublicationType.Restart)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "RegularExpression")]
	[DefaultValue("")]
	[XmlElement("RegularExpression")]
	public string RegularExpression
	{
		[CompilerGenerated]
		get
		{
			return _003CRegularExpression_003Ek__BackingField;
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
					_003CRegularExpression_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
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

	[PublicationBehaviour(PublicationType.Restart)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "RegularExpressionMessage")]
	[XmlElement("RegularExpressionMessage")]
	[DefaultValue("")]
	public string RegularExpressionMessage
	{
		[CompilerGenerated]
		get
		{
			return _003CRegularExpressionMessage_003Ek__BackingField;
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
					_003CRegularExpressionMessage_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
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

	[DefaultValue("")]
	[PublicationBehaviour(PublicationType.Delta)]
	[XmlElement("DefaultValue")]
	[JsonSerializationIgnore]
	public string DefaultValue
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultValue_003Ek__BackingField;
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
					_003CDefaultValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
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

	public StringSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		U4G8a3bWgcMgyXLvfdEH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected StringSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		U4G8a3bWgcMgyXLvfdEH();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[IteratorStateMachine(typeof(_003CWriteValidatePropertyAttributes_003Ed__30))]
	public override IEnumerable<ISyntaxNode> WriteValidatePropertyAttributes()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteValidatePropertyAttributes_003Ed__30(-2)
		{
			_003C_003E4__this = this
		};
	}

	void IMvcValidatableTypeSettings.ApplyValidationRules(ICollection<ModelClientValidationRule> rules, ModelMetadata metadata, ControllerContext context, TypeSettings originalPropertySettings)
	{
		Contract.ArgumentNotNull(rules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886478209));
		StringSettings stringSettings = originalPropertySettings as StringSettings;
		if (stringSettings == null || !string.Equals(RegularExpression, stringSettings.RegularExpression) || !string.Equals(RegularExpressionMessage, stringSettings.RegularExpressionMessage))
		{
			rules.RemoveAll((ModelClientValidationRule r) => _003C_003Ec.rqcRg6CkSXUd3diex1ig(_003C_003Ec.pBMohYCkIoZi8P8CRlg8(r), _003C_003Ec.TdXV3RCkVZA3QSrPkqc0(0xE1229CF ^ 0xE108ABF)));
			if (!string.IsNullOrEmpty(RegularExpression))
			{
				rules.AddRange(((ModelValidator)new RegularExpressionValidator(metadata, context, new RegularExpressionAttribute(RegularExpression, RegularExpressionMessage))).GetClientValidationRules());
			}
		}
		if (stringSettings == null || stringSettings.MinValue != MinValue || stringSettings.MaxValue != MaxValue)
		{
			rules.RemoveAll((ModelClientValidationRule r) => _003C_003Ec.rqcRg6CkSXUd3diex1ig(r.get_ValidationType(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671968841)));
			if (MinValue > 0 || (MaxValue.HasValue && MaxValue.Value > 0))
			{
				rules.AddRange(((ModelValidator)new StringRangeLengthValidator(metadata, context, new StringRangeLengthAttribute(MinValue, MaxValueString))).GetClientValidationRules());
			}
		}
	}

	internal static void U4G8a3bWgcMgyXLvfdEH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool kmm58ybWll3nD1KRZpry()
	{
		return bHIunrbWddYcrpvGYn5x == null;
	}

	internal static StringSettings KrOfN7bWrwyEE6y8IpNq()
	{
		return bHIunrbWddYcrpvGYn5x;
	}

	internal static bool jFcMsAbW5YwNlpewN4AV(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
