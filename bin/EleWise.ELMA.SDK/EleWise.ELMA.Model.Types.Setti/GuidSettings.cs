using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class GuidSettings : SimpleTypeSettings, IHasDefaultValue<Guid?>
{
	internal static GuidSettings lcmyJAbBaerW407xeD8Q;

	[XmlIgnore]
	[PublicationBehaviour(PublicationType.Delta)]
	public Guid? DefaultValue { get; set; }

	[JsonSerializationIgnore]
	[DefaultValue("")]
	[XmlElement("DefaultValue")]
	[PublicationBehaviour(PublicationType.Delta)]
	public string DefaultValueStr
	{
		get
		{
			//Discarded unreachable code: IL_00c7, IL_012b, IL_013a
			int num = 5;
			int num2 = num;
			Guid? defaultValue = default(Guid?);
			Guid value = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (defaultValue.Value != Guid.Empty)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto default;
				case 7:
					defaultValue = DefaultValue;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return value.ToString();
				case 5:
					defaultValue = DefaultValue;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					value = defaultValue.Value;
					num2 = 3;
					break;
				default:
					return "";
				case 6:
					defaultValue = DefaultValue;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					if (!defaultValue.HasValue)
					{
						num2 = 8;
						break;
					}
					goto case 7;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_0072, IL_00a5, IL_010b, IL_011a
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					DefaultValue = null;
					num2 = 3;
					continue;
				case 1:
					if (!VCkPCQbB43r27OECQTms(value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 3:
					return;
				}
				try
				{
					DefaultValue = new Guid(value);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							LXiPehbBAqmDNIJEx1Gk(mIpYQRbB6Ok34hojaIqK(), SR.T((string)aS2wrjbBHfhX4QQ933aQ(0x4A1640F ^ 0x4A3CB17), value), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			}
		}
	}

	public GuidSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RKPjOfbBwjQnd8pOIapL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected GuidSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		RKPjOfbBwjQnd8pOIapL();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void RKPjOfbBwjQnd8pOIapL()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool yjDLaVbBDh7LhDxyOohn()
	{
		return lcmyJAbBaerW407xeD8Q == null;
	}

	internal static GuidSettings J3jqMibBtJZpaHVrtfkR()
	{
		return lcmyJAbBaerW407xeD8Q;
	}

	internal static bool VCkPCQbB43r27OECQTms(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object mIpYQRbB6Ok34hojaIqK()
	{
		return Logger.Log;
	}

	internal static object aS2wrjbBHfhX4QQ933aQ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void LXiPehbBAqmDNIJEx1Gk(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}
}
