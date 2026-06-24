using System;
using System.ComponentModel;
using System.Configuration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Configuration;

public class ActorModelRuntimeSettingsSection : ProviderSettingsSection
{
	internal static ActorModelRuntimeSettingsSection vLLRuFfF0lRvsSYyB0CT;

	[TypeConverter(typeof(TimeSpanSecondsConverter))]
	[ConfigurationProperty("ResponseTimeout", DefaultValue = "600")]
	public TimeSpan ResponseTimeout
	{
		get
		{
			return (TimeSpan)VevEbffFJAGZF43Omv2x(this, QqO6rtfFMgEFA5tHKGLT(-475857671 ^ -475532455));
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
					base[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108457584)] = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected override void InitializeAutoInitilize()
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
				base.AutoInitialize = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public ActorModelRuntimeSettingsSection()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JuR9CcfF90J1bKBEjmQV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object QqO6rtfFMgEFA5tHKGLT(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VevEbffFJAGZF43Omv2x(object P_0, object P_1)
	{
		return ((ConfigurationElement)P_0)[(string)P_1];
	}

	internal static bool VTylD3fFmmvVGN6epZWr()
	{
		return vLLRuFfF0lRvsSYyB0CT == null;
	}

	internal static ActorModelRuntimeSettingsSection qKXwnFfFyC4sIERXTJqu()
	{
		return vLLRuFfF0lRvsSYyB0CT;
	}

	internal static void JuR9CcfF90J1bKBEjmQV()
	{
		SingletonReader.PushGlobal();
	}
}
