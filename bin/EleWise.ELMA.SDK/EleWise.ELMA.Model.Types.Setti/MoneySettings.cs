using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
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
public class MoneySettings : SimpleTypeSettings, IHasDefaultValue<double?>, IMvcValidatableTypeSettings
{
	private static class __Resources
	{
		private static object mk26QhCKNvKFXIpu9yg7;

		public static string MinValue => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A77BE39));

		public static string MaxValue => (string)BN0kHbCKD5OoXW4c6AoZ(f7ilkpCKameXkakjEJCt(-1217523399 ^ -1217513341));

		internal static bool iDa4ALCK3w2AtlPX2mMF()
		{
			return mk26QhCKNvKFXIpu9yg7 == null;
		}

		internal static __Resources DpKL55CKp8CMTTiwQs0p()
		{
			return (__Resources)mk26QhCKNvKFXIpu9yg7;
		}

		internal static object f7ilkpCKameXkakjEJCt(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object BN0kHbCKD5OoXW4c6AoZ(object P_0)
		{
			return SR.T((string)P_0);
		}
	}

	private double _minValue;

	private double _maxValue;

	internal static MoneySettings cC82UNoz2PvnhSmI18Oe;

	[DefaultValue(-1E+300)]
	[PublicationBehaviour(PublicationType.Restart)]
	[XmlElement("MinValue")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "MinValue")]
	public double MinValue
	{
		get
		{
			return _minValue;
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
					_minValue = ((value < _minValue) ? (-1E+300) : value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "MaxValue")]
	[DefaultValue(1E+300)]
	[PublicationBehaviour(PublicationType.Restart)]
	[XmlElement("MaxValue")]
	public double MaxValue
	{
		get
		{
			return _maxValue;
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
					_maxValue = ((value > _maxValue) ? 1E+300 : value);
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

	[XmlIgnore]
	[PublicationBehaviour(PublicationType.Delta)]
	public double? DefaultValue { get; set; }

	[DefaultValue(null)]
	[PublicationBehaviour(PublicationType.Delta)]
	[JsonSerializationIgnore]
	[XmlElement("DefaultValue")]
	public string DefaultValueStr
	{
		get
		{
			int num = 4;
			int num2 = num;
			double value = default(double);
			double? defaultValue = default(double?);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return value.ToString();
				case 3:
					if (!defaultValue.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 1;
						}
						break;
					}
					defaultValue = DefaultValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					break;
				default:
					value = defaultValue.Value;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					defaultValue = DefaultValue;
					num2 = 3;
					break;
				case 1:
					return null;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_005f, IL_006e
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					DefaultValue = vcelmooza0o1XrT2oO1g(value, ((CultureInfo)DhARtTozpXJqrjAge2oB(vw6VAdoz3v3WVyxjZWmn())).NumberFormat);
					num2 = 4;
					break;
				case 3:
					return;
				case 4:
					return;
				case 1:
					DefaultValue = null;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					if (koSjD4ozNAMBBDjAW6Vr(value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}
	}

	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue(true)]
	[XmlElement("RangeInFilter")]
	[JsonSerializationIgnore]
	public bool RangeInFilter
	{
		[CompilerGenerated]
		get
		{
			return _003CRangeInFilter_003Ek__BackingField;
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
					_003CRangeInFilter_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
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

	public MoneySettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected MoneySettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		D0DZ34oz13mWrPI5rD2B();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_0091, IL_00a0
		int num = 3;
		MoneySettings moneySettings = default(MoneySettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!base.Equals(obj))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 1:
					if (MinValue == lDoXv8ozDGJAgqQ8F6X6(moneySettings))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 4;
				case 5:
					return MaxValue == PZijRIoztoG70V2yYNNx(moneySettings);
				case 4:
					return false;
				case 2:
					return false;
				case 3:
					if (obj is MoneySettings)
					{
						moneySettings = (MoneySettings)obj;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 2;
						}
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	[IteratorStateMachine(typeof(_003CWriteValidatePropertyAttributes_003Ed__20))]
	public override IEnumerable<ISyntaxNode> WriteValidatePropertyAttributes()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteValidatePropertyAttributes_003Ed__20(-2)
		{
			_003C_003E4__this = this
		};
	}

	void IMvcValidatableTypeSettings.ApplyValidationRules(ICollection<ModelClientValidationRule> rules, ModelMetadata metadata, ControllerContext context, TypeSettings originalPropertySettings)
	{
		Contract.ArgumentNotNull(rules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x5117AFED));
		if (!(originalPropertySettings is MoneySettings moneySettings) || MinValue != moneySettings.MinValue || MaxValue != moneySettings.MaxValue)
		{
			rules.RemoveAll((ModelClientValidationRule r) => _003C_003Ec.AsCnx1CKMBdeERB8xTel(_003C_003Ec.CjiRXdCKmoH3oXjlUFGS(r), _003C_003Ec.paFBt9CKyAk9V0svAbeh(0x20261A4F ^ 0x2024B91F)));
			if (MinValue > -1E+300 || MaxValue < 1E+300)
			{
				rules.AddRange(((ModelValidator)new RangeValueValidator(metadata, context, new RangeValueAttribute(MinValue, MaxValue))).GetClientValidationRules());
			}
		}
	}

	internal static bool RuY7beoze42Kar6wAJg8()
	{
		return cC82UNoz2PvnhSmI18Oe == null;
	}

	internal static MoneySettings vooqclozPVMbwy2Zgn4T()
	{
		return cC82UNoz2PvnhSmI18Oe;
	}

	internal static void D0DZ34oz13mWrPI5rD2B()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool koSjD4ozNAMBBDjAW6Vr(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object vw6VAdoz3v3WVyxjZWmn()
	{
		return Thread.CurrentThread;
	}

	internal static object DhARtTozpXJqrjAge2oB(object P_0)
	{
		return ((Thread)P_0).CurrentCulture;
	}

	internal static double vcelmooza0o1XrT2oO1g(object P_0, object P_1)
	{
		return double.Parse((string)P_0, (IFormatProvider)P_1);
	}

	internal static double lDoXv8ozDGJAgqQ8F6X6(object P_0)
	{
		return ((MoneySettings)P_0).MinValue;
	}

	internal static double PZijRIoztoG70V2yYNNx(object P_0)
	{
		return ((MoneySettings)P_0).MaxValue;
	}
}
