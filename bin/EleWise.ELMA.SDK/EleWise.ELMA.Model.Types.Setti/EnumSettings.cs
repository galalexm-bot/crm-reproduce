using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class EnumSettings : SimpleTypeSettings, IHasDefaultValue<Guid?>
{
	private static class __Resources
	{
		internal static object d4JayMCXTMNr0QbxF4Ve;

		public static string DisplayType => (string)nqcPwLCX2H2e8HhwAarR(ymPAy0CXO6KSj9kgsxSA(-675505729 ^ -675725867));

		public static string MaxCount => (string)nqcPwLCX2H2e8HhwAarR(ymPAy0CXO6KSj9kgsxSA(-675505729 ^ -675725971));

		internal static object ymPAy0CXO6KSj9kgsxSA(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object nqcPwLCX2H2e8HhwAarR(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool RJ67INCXkNXX3iKMYp0M()
		{
			return d4JayMCXTMNr0QbxF4Ve == null;
		}

		internal static __Resources QkMI6WCXnXKVE1yjyFUQ()
		{
			return (__Resources)d4JayMCXTMNr0QbxF4Ve;
		}
	}

	private static EnumSettings kWovcLbB2v9g2cExBDc2;

	[PublicationBehaviour(PublicationType.Delta)]
	[XmlIgnore]
	public Guid? DefaultValue { get; set; }

	[PublicationBehaviour(PublicationType.Delta)]
	[DefaultValue("")]
	[XmlElement("DefaultValue")]
	[JsonSerializationIgnore]
	public string DefaultValueStr
	{
		get
		{
			//Discarded unreachable code: IL_007a
			int num = 6;
			int num2 = num;
			Guid? defaultValue = default(Guid?);
			Guid value = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (defaultValue.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 2:
					value = defaultValue.Value;
					num2 = 7;
					break;
				case 1:
					if (defaultValue.Value != Guid.Empty)
					{
						num2 = 4;
						break;
					}
					goto case 3;
				default:
					defaultValue = DefaultValue;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return "";
				case 4:
					defaultValue = DefaultValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 2;
					}
					break;
				case 6:
					defaultValue = DefaultValue;
					num2 = 5;
					break;
				case 7:
					return value.ToString();
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_00a8, IL_00db, IL_013b
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					if (!K6tqMVbBNv0Mv1HLIr8y(value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 3;
				case 0:
					return;
				case 3:
					DefaultValue = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					try
					{
						DefaultValue = new Guid(value);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								aEOyMLbBp1o1ODRD9VBl(Logger.Log, SR.T((string)qwZSfbbB3s8INIHHe866(-2112703338 ^ -2112873586), value), ex);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					}
				}
			}
		}
	}

	[DefaultValue(EnumRelationType.One)]
	[PublicationBehaviour(PublicationType.Restart)]
	[XmlElement("RelationType")]
	[JsonSerializationIgnore]
	public EnumRelationType RelationType
	{
		[CompilerGenerated]
		get
		{
			return _003CRelationType_003Ek__BackingField;
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
					_003CRelationType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
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

	[XmlElement("DisplayType")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "DisplayType")]
	[DefaultValue(EnumDisplayType.Standard)]
	public EnumDisplayType DisplayType
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
				case 1:
					_003CDisplayType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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

	[DefaultValue(100)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "MaxCount")]
	[XmlElement("MaxCount")]
	public int MaxCount
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxCount_003Ek__BackingField;
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
					_003CMaxCount_003Ek__BackingField = value;
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

	[XmlIgnore]
	[PublicationBehaviour(PublicationType.Restart)]
	public bool ShowIcon
	{
		[CompilerGenerated]
		get
		{
			return _003CShowIcon_003Ek__BackingField;
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
					_003CShowIcon_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
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

	public EnumSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected EnumSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		zLgUewbB1YEwn4U2YQgg();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rRZWBXbBeOP2fNsbRIws()
	{
		return kWovcLbB2v9g2cExBDc2 == null;
	}

	internal static EnumSettings wKeTCabBPthe0ovsxBPX()
	{
		return kWovcLbB2v9g2cExBDc2;
	}

	internal static void zLgUewbB1YEwn4U2YQgg()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool K6tqMVbBNv0Mv1HLIr8y(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object qwZSfbbB3s8INIHHe866(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void aEOyMLbBp1o1ODRD9VBl(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}
}
