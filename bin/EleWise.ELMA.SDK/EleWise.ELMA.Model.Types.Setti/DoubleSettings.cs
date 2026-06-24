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
public class DoubleSettings : SimpleTypeSettings, IHasDefaultValue<double?>, IMvcValidatableTypeSettings
{
	private static class __Resources
	{
		internal static object q6Lf08CXBUQjcxC8Ma5k;

		public static string MinValue => (string)w2d8etCXbmDO9iNuBfSJ(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29248275));

		public static string MaxValue => (string)w2d8etCXbmDO9iNuBfSJ(ncydfiCXhhJc3DYDYQrg(-1858887263 ^ -1858893797));

		public static string Precision => (string)w2d8etCXbmDO9iNuBfSJ(ncydfiCXhhJc3DYDYQrg(-1939377524 ^ -1939680760));

		internal static object w2d8etCXbmDO9iNuBfSJ(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool IDhR3wCXWQQOQmQ0vKed()
		{
			return q6Lf08CXBUQjcxC8Ma5k == null;
		}

		internal static __Resources X9L5m8CXoolAtUXpRreM()
		{
			return (__Resources)q6Lf08CXBUQjcxC8Ma5k;
		}

		internal static object ncydfiCXhhJc3DYDYQrg(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	public const double DefaultMinValue = -1E+300;

	public const double DefaultMaxValue = 1E+300;

	private double _minValue;

	private double _maxValue;

	internal static DoubleSettings BVegl3bFUSW4IUf2AZ9S;

	[PublicationBehaviour(PublicationType.Restart)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "MinValue")]
	[XmlElement("MinValue")]
	[DefaultValue(-1E+300)]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
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
	[XmlElement("MaxValue")]
	[PublicationBehaviour(PublicationType.Restart)]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public int? Precision { get; set; }

	[XmlElement("Precision")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "Precision")]
	public string PrecisionString
	{
		get
		{
			//Discarded unreachable code: IL_00c0
			int num = 2;
			int num2 = num;
			int? precision = default(int?);
			int value = default(int);
			while (true)
			{
				switch (num2)
				{
				case 2:
					precision = Precision;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					return value.ToString();
				case 3:
					return null;
				default:
					precision = Precision;
					num2 = 5;
					break;
				case 5:
					value = precision.Value;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (precision.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_0095, IL_00a4
			int num = 3;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 3:
						if (string.IsNullOrEmpty(value))
						{
							num2 = 2;
							continue;
						}
						break;
					case 1:
						break;
					case 4:
						return;
					case 2:
						Precision = null;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
				Precision = RuBbmxbBFLBvT3POdATO(value);
				num = 4;
			}
		}
	}

	[PublicationBehaviour(PublicationType.Delta)]
	[XmlIgnore]
	public double? DefaultValue { get; set; }

	[XmlElement("DefaultValue")]
	[PublicationBehaviour(PublicationType.Delta)]
	[DefaultValue(null)]
	[JsonSerializationIgnore]
	public string DefaultValueStr
	{
		get
		{
			//Discarded unreachable code: IL_007a, IL_0089
			int num = 5;
			int num2 = num;
			double value = default(double);
			double? defaultValue = default(double?);
			while (true)
			{
				switch (num2)
				{
				case 2:
					value = defaultValue.Value;
					num2 = 3;
					break;
				case 3:
					return value.ToString();
				case 4:
					if (defaultValue.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 5:
					defaultValue = DefaultValue;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					return null;
				default:
					defaultValue = DefaultValue;
					num2 = 2;
					break;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_00c8
			int num = 3;
			int num2 = num;
			double result = default(double);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					return;
				case 4:
					return;
				case 5:
					DefaultValue = result;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					if (!double.TryParse(value, out result))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 5;
				case 3:
					if (nCATAbbBBMA5WfB9JdAc(value))
					{
						DefaultValue = null;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 2;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(true)]
	[PublicationBehaviour(PublicationType.Restart)]
	[JsonSerializationIgnore]
	[XmlElement("RangeInFilter")]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
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

	public DoubleSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gEg9c9bFzm9jL2AYVB0X();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected DoubleSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		gEg9c9bFzm9jL2AYVB0X();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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
		//Discarded unreachable code: IL_007f, IL_008e
		int num = 3;
		int num2 = num;
		DoubleSettings doubleSettings = default(DoubleSettings);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (!base.Equals(obj))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			default:
				if (MaxValue == mMOObqbBoCPGNp6ASCgH(doubleSettings))
				{
					num2 = 6;
					break;
				}
				goto case 4;
			case 6:
				return k8BHu6bBhP6Q3N3fYmH2(PrecisionString, umSMx5bBbZGIAHYRa9k8(doubleSettings));
			case 4:
				return false;
			case 2:
				return false;
			case 1:
				if (MinValue == BFJXgVbBWli6MVc7nZvY(doubleSettings))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 3:
				if (obj is DoubleSettings)
				{
					doubleSettings = (DoubleSettings)obj;
					num2 = 5;
					break;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CWriteValidatePropertyAttributes_003Ed__29))]
	public override IEnumerable<ISyntaxNode> WriteValidatePropertyAttributes()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteValidatePropertyAttributes_003Ed__29(-2)
		{
			_003C_003E4__this = this
		};
	}

	void IMvcValidatableTypeSettings.ApplyValidationRules(ICollection<ModelClientValidationRule> rules, ModelMetadata metadata, ControllerContext context, TypeSettings originalPropertySettings)
	{
		Contract.ArgumentNotNull(rules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675400625));
		if (!(originalPropertySettings is DoubleSettings doubleSettings) || MinValue != doubleSettings.MinValue || MaxValue != doubleSettings.MaxValue)
		{
			rules.RemoveAll((ModelClientValidationRule r) => _003C_003Ec.R9WGO9CXVLSnygpvSNKf(r.get_ValidationType(), _003C_003Ec.zSrna7CXI2Y9XW2d8L81(0x3B36AB09 ^ 0x3B340859)));
			if (MinValue > -1E+300 || MaxValue < 1E+300)
			{
				rules.AddRange(((ModelValidator)new RangeValueValidator(metadata, context, new RangeValueAttribute(MinValue, MaxValue))).GetClientValidationRules());
			}
		}
	}

	internal static void gEg9c9bFzm9jL2AYVB0X()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool wwYbWKbFsZDGmrsIT0Nx()
	{
		return BVegl3bFUSW4IUf2AZ9S == null;
	}

	internal static DoubleSettings WilS0cbFcT6xIJRsvZ1m()
	{
		return BVegl3bFUSW4IUf2AZ9S;
	}

	internal static int RuBbmxbBFLBvT3POdATO(object P_0)
	{
		return int.Parse((string)P_0);
	}

	internal static bool nCATAbbBBMA5WfB9JdAc(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static double BFJXgVbBWli6MVc7nZvY(object P_0)
	{
		return ((DoubleSettings)P_0).MinValue;
	}

	internal static double mMOObqbBoCPGNp6ASCgH(object P_0)
	{
		return ((DoubleSettings)P_0).MaxValue;
	}

	internal static object umSMx5bBbZGIAHYRa9k8(object P_0)
	{
		return ((DoubleSettings)P_0).PrecisionString;
	}

	internal static bool k8BHu6bBhP6Q3N3fYmH2(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
