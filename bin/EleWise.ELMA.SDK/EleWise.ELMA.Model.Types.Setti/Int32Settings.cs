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
public class Int32Settings : SimpleTypeSettings, IHasDefaultValue<int?>, IMvcValidatableTypeSettings
{
	private static class __Resources
	{
		private static object CCLjffCTya6x0ixtvT0p;

		public static string MinValue => (string)Ca8CP5CTdNer59Pu0TCE(Uu943FCT9kf2s8gsUXvK(-218496594 ^ -218486752));

		public static string MaxValue => (string)Ca8CP5CTdNer59Pu0TCE(Uu943FCT9kf2s8gsUXvK(-1886646897 ^ -1886641099));

		internal static object Uu943FCT9kf2s8gsUXvK(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object Ca8CP5CTdNer59Pu0TCE(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool K7JWiKCTMIjZ3gfp85ZP()
		{
			return CCLjffCTya6x0ixtvT0p == null;
		}

		internal static __Resources B7vmgDCTJEyr1LEfWXAS()
		{
			return (__Resources)CCLjffCTya6x0ixtvT0p;
		}
	}

	public const int DefaultMinValue = int.MinValue;

	public const int DefaultMaxValue = int.MaxValue;

	private static Int32Settings ETZlwDbWHEOdoASKuch3;

	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue(int.MinValue)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "MinValue")]
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
				case 1:
					_003CMinValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
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

	[DefaultValue(int.MaxValue)]
	[PublicationBehaviour(PublicationType.Restart)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "MaxValue")]
	public int MaxValue
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxValue_003Ek__BackingField;
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
					_003CMaxValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
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
	public int? DefaultValue { get; set; }

	[PublicationBehaviour(PublicationType.Delta)]
	[JsonSerializationIgnore]
	[XmlElement("DefaultValue")]
	[DefaultValue(null)]
	public string DefaultValueStr
	{
		get
		{
			int num = 4;
			int num2 = num;
			int value = default(int);
			int? defaultValue = default(int?);
			while (true)
			{
				switch (num2)
				{
				case 2:
					value = defaultValue.Value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 1;
					}
					break;
				default:
					return null;
				case 1:
					return value.ToString();
				case 4:
					defaultValue = DefaultValue;
					num2 = 3;
					break;
				case 3:
					if (defaultValue.HasValue)
					{
						defaultValue = DefaultValue;
						num2 = 2;
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_00af, IL_00be
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					DefaultValue = int.Parse(value, (IFormatProvider)bDmMaFbWM6i7yJE4Z9Mw(WsmpPQbWyCy7RUoAe9Pc(bx3W2obWmnMt6loTtsJs())));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return;
				case 2:
					DefaultValue = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					if (opGiTKbW0vdgNejh9kns(value))
					{
						num2 = 2;
						break;
					}
					goto default;
				case 4:
					return;
				}
			}
		}
	}

	[XmlElement("RangeInFilter")]
	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue(true)]
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
				case 0:
					return;
				case 1:
					_003CRangeInFilter_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Int32Settings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Haeeq0bWxfHE5yYbUORk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected Int32Settings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		Haeeq0bWxfHE5yYbUORk();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
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
		//Discarded unreachable code: IL_00c1, IL_00d0
		int num = 4;
		Int32Settings int32Settings = default(Int32Settings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return MaxValue == wGeWVlbW9CphjJigej6i(int32Settings);
				default:
					return false;
				case 3:
					return false;
				case 2:
					if (!base.Equals(obj))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 5:
					if (MinValue == eJAFSibWJ1vm45XW8C2l(int32Settings))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 4:
					if (obj is Int32Settings)
					{
						int32Settings = (Int32Settings)obj;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 2;
						}
						continue;
					}
					num = 3;
					break;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CWriteValidatePropertyAttributes_003Ed__24))]
	public override IEnumerable<ISyntaxNode> WriteValidatePropertyAttributes()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteValidatePropertyAttributes_003Ed__24(-2)
		{
			_003C_003E4__this = this
		};
	}

	void IMvcValidatableTypeSettings.ApplyValidationRules(ICollection<ModelClientValidationRule> rules, ModelMetadata metadata, ControllerContext context, TypeSettings originalPropertySettings)
	{
		Contract.ArgumentNotNull(rules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2024B7BF));
		if (!(originalPropertySettings is Int32Settings int32Settings) || MinValue != int32Settings.MinValue || MaxValue != int32Settings.MaxValue)
		{
			rules.RemoveAll((ModelClientValidationRule r) => (string)_003C_003Ec.flP3KnCTsJjEktaBgE3X(r) == (string)_003C_003Ec.C2ijlfCTcQKjWUwh0yZ8(-521266112 ^ -521355504));
			if (MinValue != int.MinValue || MaxValue != int.MaxValue)
			{
				rules.AddRange(((ModelValidator)new RangeValueValidator(metadata, context, new RangeValueAttribute(MinValue, MaxValue))).GetClientValidationRules());
			}
		}
	}

	internal static void Haeeq0bWxfHE5yYbUORk()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool YUKAK0bWAHCEJMLnmeE5()
	{
		return ETZlwDbWHEOdoASKuch3 == null;
	}

	internal static Int32Settings a2drbgbW7sY4AT8k9OUX()
	{
		return ETZlwDbWHEOdoASKuch3;
	}

	internal static bool opGiTKbW0vdgNejh9kns(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object bx3W2obWmnMt6loTtsJs()
	{
		return Thread.CurrentThread;
	}

	internal static object WsmpPQbWyCy7RUoAe9Pc(object P_0)
	{
		return ((Thread)P_0).CurrentCulture;
	}

	internal static object bDmMaFbWM6i7yJE4Z9Mw(object P_0)
	{
		return ((CultureInfo)P_0).NumberFormat;
	}

	internal static int eJAFSibWJ1vm45XW8C2l(object P_0)
	{
		return ((Int32Settings)P_0).MinValue;
	}

	internal static int wGeWVlbW9CphjJigej6i(object P_0)
	{
		return ((Int32Settings)P_0).MaxValue;
	}
}
