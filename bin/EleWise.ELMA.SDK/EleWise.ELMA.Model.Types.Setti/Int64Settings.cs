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
public class Int64Settings : SimpleTypeSettings, IHasDefaultValue<long?>, IMvcValidatableTypeSettings
{
	private static class __Resources
	{
		private static object MRNIssCT1RFe5p8EGqe8;

		public static string MinValue => (string)pbdxDiCTaF8Miaf59my0(deG0PpCTpOkhH7SMlO0d(-2112703338 ^ -2112709352));

		public static string MaxValue => (string)pbdxDiCTaF8Miaf59my0(deG0PpCTpOkhH7SMlO0d(-1633514411 ^ -1633507857));

		internal static object deG0PpCTpOkhH7SMlO0d(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object pbdxDiCTaF8Miaf59my0(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool hnpsjBCTNxX1WxAWJNu0()
		{
			return MRNIssCT1RFe5p8EGqe8 == null;
		}

		internal static __Resources t1Jls3CT38vMQjgcUVnS()
		{
			return (__Resources)MRNIssCT1RFe5p8EGqe8;
		}
	}

	public const long DefaultMinValue = long.MinValue;

	public const long DefaultMaxValue = long.MaxValue;

	private static Int64Settings lMybjVbWPUsN4WhRcQlR;

	[DefaultValue(long.MinValue)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "MinValue")]
	[PublicationBehaviour(PublicationType.Restart)]
	public long MinValue
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
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

	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "MaxValue")]
	[DefaultValue(long.MaxValue)]
	[PublicationBehaviour(PublicationType.Restart)]
	public long MaxValue
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
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
	public long? DefaultValue { get; set; }

	[JsonSerializationIgnore]
	[DefaultValue(null)]
	[XmlElement("DefaultValue")]
	[PublicationBehaviour(PublicationType.Delta)]
	public string DefaultValueStr
	{
		get
		{
			int num = 4;
			int num2 = num;
			long value = default(long);
			long? defaultValue = default(long?);
			while (true)
			{
				switch (num2)
				{
				default:
					return value.ToString();
				case 2:
					return null;
				case 3:
					if (defaultValue.HasValue)
					{
						defaultValue = DefaultValue;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 2;
					}
					break;
				case 1:
					value = defaultValue.Value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					defaultValue = DefaultValue;
					num2 = 3;
					break;
				}
			}
		}
		set
		{
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
					case 2:
						DefaultValue = WviLSibWwLpLliRT7Wrg(value, ShaJBRbWtNCIRqMLoJ3i(zYQrYsbWDyhaY7fAfedE(aOte0kbWaFEw5g2HQgD8())));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 0;
						}
						continue;
					case 1:
						return;
					case 0:
						return;
					case 3:
						if (t6WFE5bWp2nUXWpeWWZO(value))
						{
							DefaultValue = null;
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
							{
								num2 = 1;
							}
							continue;
						}
						num = 2;
						break;
					}
					break;
				}
			}
		}
	}

	[JsonSerializationIgnore]
	[XmlElement("RangeInFilter")]
	[DefaultValue(true)]
	[PublicationBehaviour(PublicationType.Restart)]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Int64Settings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uNd2w1bW3i7IoelfjpQD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected Int64Settings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
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
		int num = 2;
		int num2 = num;
		Int64Settings int64Settings = default(Int64Settings);
		while (true)
		{
			switch (num2)
			{
			default:
				if (base.Equals(obj))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 4:
				if (MinValue == a9BhNTbW4X5oB4tRl0I8(int64Settings))
				{
					num2 = 3;
					continue;
				}
				break;
			case 2:
				if (!(obj is Int64Settings))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 1;
					}
					continue;
				}
				int64Settings = (Int64Settings)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return false;
			case 3:
				return MaxValue == P3k0XQbW6ST6KjgtQSsX(int64Settings);
			}
			break;
		}
		return false;
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
		Contract.ArgumentNotNull(rules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE17079));
		if (!(originalPropertySettings is Int64Settings int64Settings) || MinValue != int64Settings.MinValue || MaxValue != int64Settings.MaxValue)
		{
			rules.RemoveAll((ModelClientValidationRule r) => _003C_003Ec.mkYK7uCTmcFwtO1q6N78(r.get_ValidationType(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859058959)));
			if (MinValue != long.MinValue || MaxValue != long.MaxValue)
			{
				rules.AddRange(((ModelValidator)new RangeValueValidator(metadata, context, new RangeValueAttribute(MinValue, MaxValue))).GetClientValidationRules());
			}
		}
	}

	internal static void uNd2w1bW3i7IoelfjpQD()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool DhIFhybW13A1uqXQQ6IK()
	{
		return lMybjVbWPUsN4WhRcQlR == null;
	}

	internal static Int64Settings KMIFrkbWNJJrIgbxW1ZU()
	{
		return lMybjVbWPUsN4WhRcQlR;
	}

	internal static bool t6WFE5bWp2nUXWpeWWZO(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object aOte0kbWaFEw5g2HQgD8()
	{
		return Thread.CurrentThread;
	}

	internal static object zYQrYsbWDyhaY7fAfedE(object P_0)
	{
		return ((Thread)P_0).CurrentCulture;
	}

	internal static object ShaJBRbWtNCIRqMLoJ3i(object P_0)
	{
		return ((CultureInfo)P_0).NumberFormat;
	}

	internal static long WviLSibWwLpLliRT7Wrg(object P_0, object P_1)
	{
		return long.Parse((string)P_0, (IFormatProvider)P_1);
	}

	internal static long a9BhNTbW4X5oB4tRl0I8(object P_0)
	{
		return ((Int64Settings)P_0).MinValue;
	}

	internal static long P3k0XQbW6ST6KjgtQSsX(object P_0)
	{
		return ((Int64Settings)P_0).MaxValue;
	}
}
