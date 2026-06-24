using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Messaging.EmailFormat;

public class EmailFormatSettings : GlobalSettingsBase
{
	public List<EmailFormatInfo> _formats;

	internal static EmailFormatSettings jTm3kGhy4EAoMomJQ3Dl;

	[HiddenInput(DisplayValue = false)]
	public List<EmailFormatInfo> Formats
	{
		get
		{
			if (_formats.Count == 0)
			{
				Init();
			}
			return _formats;
		}
		set
		{
			_formats = value;
		}
	}

	public string SerializedFormats
	{
		get
		{
			return string.Join((string)gfDyqshyx4g8lXqocvJI(-289714582 ^ -289727818), _formats.Select((EmailFormatInfo v) => ClassSerializationHelper.SerializeObjectByXml(v)));
		}
		set
		{
			int num = 3;
			int num2 = num;
			string[] source = default(string[]);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					if (MkmS9xhy0kRyxHqFZBGd(value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						source = value.Split(new string[1] { (string)gfDyqshyx4g8lXqocvJI(-867826612 ^ -867807088) }, StringSplitOptions.RemoveEmptyEntries);
						num2 = 4;
					}
					break;
				case 0:
					return;
				case 2:
					Init();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 4:
					_formats = source.Select((string v) => ClassSerializationHelper.DeserializeObjectByXml<EmailFormatInfo>(v)).ToList();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public EmailFormatSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		r0pXeBhyAgU6Vd6neGCS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
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
			_formats = new List<EmailFormatInfo>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
			{
				num = 1;
			}
		}
	}

	public void Init()
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				_003C_003Ec__DisplayClass5_.emailFormats = ((ComponentManager)jmQdkMhy7iP1xFc60DqT()).GetExtensionPoints<IEmailFormat>().ToList();
				num2 = 5;
				break;
			case 1:
				_formats.RemoveAll(_003C_003Ec__DisplayClass5_._003CInit_003Eb__1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass5_.emailFormats.ForEach(_003C_003Ec__DisplayClass5_._003CInit_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 2:
				_003C_003Ec__DisplayClass5_._003C_003E4__this = this;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	internal static void r0pXeBhyAgU6Vd6neGCS()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool VhJp60hy6tfyQWH8l3Ft()
	{
		return jTm3kGhy4EAoMomJQ3Dl == null;
	}

	internal static EmailFormatSettings smCDCKhyHFStDsXXXLWm()
	{
		return jTm3kGhy4EAoMomJQ3Dl;
	}

	internal static object jmQdkMhy7iP1xFc60DqT()
	{
		return ComponentManager.Current;
	}

	internal static object gfDyqshyx4g8lXqocvJI(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool MkmS9xhy0kRyxHqFZBGd(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
