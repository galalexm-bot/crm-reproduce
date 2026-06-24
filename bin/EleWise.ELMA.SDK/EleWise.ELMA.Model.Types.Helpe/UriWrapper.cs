using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
[XmlRoot("UriValue")]
public class UriWrapper : IXsiType
{
	private static UriWrapper bqi9D8bbBn4JpPNC1jrZ;

	[XmlElement("Value")]
	public string UriValue
	{
		[CompilerGenerated]
		get
		{
			return _003CUriValue_003Ek__BackingField;
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
					_003CUriValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public Uri Value
	{
		get
		{
			//Discarded unreachable code: IL_0080, IL_00b2, IL_00ea, IL_00f9
			int num = 2;
			int num2 = num;
			Uri uri = default(Uri);
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!string.IsNullOrEmpty(UriValue))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return null;
				case 1:
					try
					{
						uri = new Uri(UriValue, UriKind.RelativeOrAbsolute);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => uri, 
							_ => uri, 
						};
					}
					catch (Exception)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								return uri;
							case 0:
								return uri;
							case 1:
								uri = null;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
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
		set
		{
			//Discarded unreachable code: IL_007e, IL_008d
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
				case 2:
					return;
				case 3:
					UriValue = (string)qamb2mbbGkMwIQSxqM1x(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (!pTmxKhbbhgRRbow5T6Dq(value, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				}
			}
		}
	}

	public UriWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		M6h3eLbbbr4L2FTxHxXA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public UriWrapper(Uri uri)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Value = uri;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void M6h3eLbbbr4L2FTxHxXA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool E5eSJObbWGXWs5VVkR8r()
	{
		return bqi9D8bbBn4JpPNC1jrZ == null;
	}

	internal static UriWrapper V3BUWwbboHjh8AWpBnWY()
	{
		return bqi9D8bbBn4JpPNC1jrZ;
	}

	internal static bool pTmxKhbbhgRRbow5T6Dq(object P_0, object P_1)
	{
		return (Uri)P_0 != (Uri)P_1;
	}

	internal static object qamb2mbbGkMwIQSxqM1x(object P_0)
	{
		return ((Uri)P_0).OriginalString;
	}
}
