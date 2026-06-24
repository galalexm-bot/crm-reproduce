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
public class Int16Settings : SimpleTypeSettings, IHasDefaultValue<short?>, IMvcValidatableTypeSettings
{
	private static class __Resources
	{
		private static object bSZ4pRCTZcnAbVBNu9iq;

		public static string MinValue => (string)wWSqahCTS5kdT78F9Ead(s9t3wwCTVFeZC5ZdmUUT(0x1C9495B4 ^ 0x1C94BC3A));

		public static string MaxValue => (string)wWSqahCTS5kdT78F9Ead(s9t3wwCTVFeZC5ZdmUUT(0x2A7797B7 ^ 0x2A77BE0D));

		internal static object s9t3wwCTVFeZC5ZdmUUT(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object wWSqahCTS5kdT78F9Ead(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool J9NED5CTuxD2Y6MW2Wv8()
		{
			return bSZ4pRCTZcnAbVBNu9iq == null;
		}

		internal static __Resources t1O9bQCTI3IZ7X7gsfJB()
		{
			return (__Resources)bSZ4pRCTZcnAbVBNu9iq;
		}
	}

	public const short DefaultMinValue = short.MinValue;

	public const short DefaultMaxValue = short.MaxValue;

	internal static Int16Settings Sno92rbWqQYtXUGEGpFJ;

	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue(short.MinValue)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "MinValue")]
	public short MinValue
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
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

	[DefaultValue(short.MaxValue)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "MaxValue")]
	[PublicationBehaviour(PublicationType.Restart)]
	public short MaxValue
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[PublicationBehaviour(PublicationType.Delta)]
	[XmlIgnore]
	public short? DefaultValue { get; set; }

	[DefaultValue(null)]
	[XmlElement("DefaultValue")]
	[JsonSerializationIgnore]
	[PublicationBehaviour(PublicationType.Delta)]
	public string DefaultValueStr
	{
		get
		{
			int num = 2;
			int num2 = num;
			short value = default(short);
			short? defaultValue = default(short?);
			while (true)
			{
				switch (num2)
				{
				case 4:
					value = defaultValue.Value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (!defaultValue.HasValue)
					{
						num2 = 3;
						break;
					}
					defaultValue = DefaultValue;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 4;
					}
					break;
				default:
					return value.ToString();
				case 3:
					return null;
				case 2:
					defaultValue = DefaultValue;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_00b3, IL_00c2
			int num = 3;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						if (qNKyq0bWkfJNFOZHAZUQ(value))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num2 = 2;
							}
							continue;
						}
						break;
					case 4:
						return;
					case 2:
						DefaultValue = null;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						return;
					}
					break;
				}
				DefaultValue = Pp2xuybW24sJMW0URdFs(value, CF8gfTbWOUBUcs7PJ4cw(tnyOIIbWnrlGeTOeqWmf(Thread.CurrentThread)));
				num = 4;
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
				case 1:
					_003CRangeInFilter_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
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

	public Int16Settings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qETWNObWTFp55WmSGltH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected Int16Settings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
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
		//Discarded unreachable code: IL_0065
		int num = 4;
		int num2 = num;
		Int16Settings int16Settings = default(Int16Settings);
		while (true)
		{
			switch (num2)
			{
			default:
				if (MinValue == H2xZbYbWeMwce5SfC0rG(int16Settings))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_0094;
			case 4:
				if (obj is Int16Settings)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 1:
				return MaxValue == int16Settings.MaxValue;
			case 5:
				if (base.Equals(obj))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0094;
			case 2:
				return false;
			case 3:
				{
					int16Settings = (Int16Settings)obj;
					num2 = 5;
					break;
				}
				IL_0094:
				return false;
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
		Contract.ArgumentNotNull(rules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426249015));
		if (!(originalPropertySettings is Int16Settings int16Settings) || MinValue != int16Settings.MinValue || MaxValue != int16Settings.MaxValue)
		{
			rules.RemoveAll((ModelClientValidationRule r) => _003C_003Ec.sWiOWHCTPpkt2js3JqWq(_003C_003Ec.jUpv9YCTegN4tbuVulj0(r), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341AFD05)));
			if (MinValue != short.MinValue || MaxValue != short.MaxValue)
			{
				rules.AddRange(((ModelValidator)new RangeValueValidator(metadata, context, new RangeValueAttribute(MinValue, MaxValue))).GetClientValidationRules());
			}
		}
	}

	internal static void qETWNObWTFp55WmSGltH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool rhbUgPbWK2RErNIKggid()
	{
		return Sno92rbWqQYtXUGEGpFJ == null;
	}

	internal static Int16Settings XGhOEibWXun0cCOdjUM1()
	{
		return Sno92rbWqQYtXUGEGpFJ;
	}

	internal static bool qNKyq0bWkfJNFOZHAZUQ(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object tnyOIIbWnrlGeTOeqWmf(object P_0)
	{
		return ((Thread)P_0).CurrentCulture;
	}

	internal static object CF8gfTbWOUBUcs7PJ4cw(object P_0)
	{
		return ((CultureInfo)P_0).NumberFormat;
	}

	internal static short Pp2xuybW24sJMW0URdFs(object P_0, object P_1)
	{
		return short.Parse((string)P_0, (IFormatProvider)P_1);
	}

	internal static short H2xZbYbWeMwce5SfC0rG(object P_0)
	{
		return ((Int16Settings)P_0).MinValue;
	}
}
