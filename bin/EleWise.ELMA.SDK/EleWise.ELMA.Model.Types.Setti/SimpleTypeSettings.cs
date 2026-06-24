using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class SimpleTypeSettings : TypeSettings
{
	internal static SimpleTypeSettings PAeYBZbFNYOWXd8xyiHJ;

	[PublicationBehaviour(PublicationType.Restart)]
	[DataMember]
	[JsonSerializationIgnore]
	[XmlElement("FieldName")]
	[DefaultValue("")]
	public string FieldName
	{
		[CompilerGenerated]
		get
		{
			return _003CFieldName_003Ek__BackingField;
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
					_003CFieldName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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

	[DefaultValue(null)]
	[JsonSerializationIgnore]
	[XmlElement("CustomSettings")]
	public string CustomSettingsSerialized
	{
		get
		{
			//Discarded unreachable code: IL_005a, IL_0069
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return ClassSerializationHelper.SerializeObjectByXml(new CustomSettingsValueContainer(CustomSettings));
				case 2:
					return null;
				case 3:
					if (CustomSettings == null)
					{
						num2 = 2;
						break;
					}
					goto case 1;
				case 1:
					if (JIqibebFDgn2PpetuZuF(CustomSettings) != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
		set
		{
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
				case 1:
					CustomSettings = new List<CustomSettingValue>();
					num2 = 3;
					break;
				case 3:
					return;
				case 2:
					if (!EJRnJtbFtfM4idaByF2y(value))
					{
						CustomSettings = ClassSerializationHelper.DeserializeObjectByXml<CustomSettingsValueContainer>(value).Settings;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 0;
						}
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public List<CustomSettingValue> CustomSettings { get; set; }

	public SimpleTypeSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bMYsTVbFap3lcO5CDx2l();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
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
			CustomSettings = new List<CustomSettingValue>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
			{
				num = 1;
			}
		}
	}

	protected SimpleTypeSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public T GetCustomSetting<T>(string key)
	{
		return (T)GetCustomSetting(key);
	}

	public object GetCustomSetting(string key)
	{
		//Discarded unreachable code: IL_003d, IL_004c
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		CustomSettingValue customSettingValue = default(CustomSettingValue);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (CustomSettings != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 2;
			case 1:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (customSettingValue == null)
				{
					num2 = 3;
					break;
				}
				return hhN8KtbFwKN573kwEEP9(customSettingValue);
			default:
				_003C_003Ec__DisplayClass14_.key = key;
				num2 = 6;
				break;
			case 2:
				return null;
			case 5:
				customSettingValue = CustomSettings.FirstOrDefault(_003C_003Ec__DisplayClass14_._003CGetCustomSetting_003Eb__0);
				num2 = 4;
				break;
			case 3:
				return null;
			}
		}
	}

	public void SetCustomSetting(string key, object value)
	{
		//Discarded unreachable code: IL_0087, IL_0096
		int num = 9;
		int num2 = num;
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		CustomSettingValue customSettingValue = default(CustomSettingValue);
		while (true)
		{
			switch (num2)
			{
			case 9:
				_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
				num2 = 8;
				break;
			case 2:
			case 7:
				gCCHxjbF4vGpGj4CAlBE(customSettingValue, value);
				num2 = 10;
				break;
			default:
				CustomSettings.Add(customSettingValue);
				num2 = 7;
				break;
			case 3:
				customSettingValue = CustomSettings.FirstOrDefault(_003C_003Ec__DisplayClass15_._003CSetCustomSetting_003Eb__0);
				num2 = 5;
				break;
			case 4:
				if (CustomSettings == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 3;
			case 10:
				return;
			case 6:
				CustomSettings = new List<CustomSettingValue>();
				num2 = 3;
				break;
			case 5:
				if (customSettingValue != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 1:
				customSettingValue = new CustomSettingValue
				{
					Key = _003C_003Ec__DisplayClass15_.key
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				_003C_003Ec__DisplayClass15_.key = key;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public virtual string[] GetFieldNames()
	{
		return new string[1] { FieldName };
	}

	public virtual bool Equals(SimpleTypeSettings other)
	{
		//Discarded unreachable code: IL_009e
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return true;
			default:
				return rboSn8bFH6w8Gu0WMdQh(frbfe0bFAguI8ZA2KCZb(other), CustomSettingsSerialized);
			case 4:
				return false;
			case 2:
				if (this != other)
				{
					if (!rboSn8bFH6w8Gu0WMdQh(Pk9MXdbF6f9m5sa4cyVZ(other), FieldName))
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 3:
				if (other != null)
				{
					num2 = 2;
					break;
				}
				goto case 4;
			}
		}
	}

	public override bool Equals(object obj)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return false;
				case 3:
					return true;
				case 2:
					if (obj == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 0;
						}
						break;
					}
					if (this == obj)
					{
						goto end_IL_0012;
					}
					if (!vRmh72bF7i18PuxDMmTp(obj.GetType(), typeof(SimpleTypeSettings)))
					{
						return YDVVr9bFxCUPvqsLIFIF(this, (SimpleTypeSettings)obj);
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return false;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public override int GetHashCode()
	{
		//Discarded unreachable code: IL_0038
		int num = 1;
		int num2 = num;
		int hashCode;
		while (true)
		{
			switch (num2)
			{
			default:
				hashCode = yKouswbF0O2eO8alPxZb(typeof(string).TypeHandle).GetHashCode();
				break;
			case 1:
				if (FieldName == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					continue;
				}
				hashCode = FieldName.GetHashCode();
				break;
			}
			break;
		}
		return (hashCode * 397) ^ (((CustomSettingsSerialized != null) ? CustomSettingsSerialized.GetHashCode() : typeof(string).GetHashCode()) * 13);
	}

	internal static void bMYsTVbFap3lcO5CDx2l()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Wr2rCZbF3nssxguw9g1l()
	{
		return PAeYBZbFNYOWXd8xyiHJ == null;
	}

	internal static SimpleTypeSettings J6fuxTbFpaCdCdcX5dyh()
	{
		return PAeYBZbFNYOWXd8xyiHJ;
	}

	internal static int JIqibebFDgn2PpetuZuF(object P_0)
	{
		return ((List<CustomSettingValue>)P_0).Count;
	}

	internal static bool EJRnJtbFtfM4idaByF2y(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object hhN8KtbFwKN573kwEEP9(object P_0)
	{
		return ((CustomSettingValue)P_0).Value;
	}

	internal static void gCCHxjbF4vGpGj4CAlBE(object P_0, object P_1)
	{
		((CustomSettingValue)P_0).Value = P_1;
	}

	internal static object Pk9MXdbF6f9m5sa4cyVZ(object P_0)
	{
		return ((SimpleTypeSettings)P_0).FieldName;
	}

	internal static bool rboSn8bFH6w8Gu0WMdQh(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object frbfe0bFAguI8ZA2KCZb(object P_0)
	{
		return ((SimpleTypeSettings)P_0).CustomSettingsSerialized;
	}

	internal static bool vRmh72bF7i18PuxDMmTp(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool YDVVr9bFxCUPvqsLIFIF(object P_0, object P_1)
	{
		return ((SimpleTypeSettings)P_0).Equals((SimpleTypeSettings)P_1);
	}

	internal static Type yKouswbF0O2eO8alPxZb(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
