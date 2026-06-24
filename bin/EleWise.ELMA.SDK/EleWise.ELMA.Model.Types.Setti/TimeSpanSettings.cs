using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class TimeSpanSettings : SimpleTypeSettings
{
	private static class __Resources
	{
		private static object YQoPHQCXehgKxNfC5kTT;

		public static string ShowDays => (string)q1E9kiCX3A5AldAgh1pR(vXeTPgCXNroRf6eaW9uc(-629844702 ^ -630132678));

		public static string ShowHours => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x47801935));

		public static string ShowMinutes => (string)q1E9kiCX3A5AldAgh1pR(vXeTPgCXNroRf6eaW9uc(-29254301 ^ -29083591));

		public static string ShowSeconds => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A4C18F));

		internal static object vXeTPgCXNroRf6eaW9uc(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object q1E9kiCX3A5AldAgh1pR(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool KkHw9mCXPQlMdaA6FIJ9()
		{
			return YQoPHQCXehgKxNfC5kTT == null;
		}

		internal static __Resources wTHMBPCX1PEBWPfXENTn()
		{
			return (__Resources)YQoPHQCXehgKxNfC5kTT;
		}
	}

	[OptionalField]
	private bool showDays;

	[OptionalField]
	private bool showHours;

	[OptionalField]
	private bool showMinutes;

	private static TimeSpanSettings m4KwnHbB7OjvCC0CusWf;

	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "ShowDays")]
	[DefaultValue(true)]
	[XmlElement("ShowDays")]
	public bool ShowDays
	{
		get
		{
			return showDays;
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
					showDays = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "ShowHours")]
	[DefaultValue(true)]
	[XmlElement("ShowHours")]
	public bool ShowHours
	{
		get
		{
			return showHours;
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
					showHours = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "ShowMinutes")]
	[XmlElement("ShowMinutes")]
	[DefaultValue(true)]
	public bool ShowMinutes
	{
		get
		{
			return showMinutes;
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
				case 1:
					showMinutes = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
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

	[XmlElement("ShowSeconds")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "ShowSeconds")]
	[DefaultValue(false)]
	public bool ShowSeconds
	{
		[CompilerGenerated]
		get
		{
			return _003CShowSeconds_003Ek__BackingField;
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
					_003CShowSeconds_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
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

	public TimeSpanSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LWs5ZqbBmsLjFIEbIcaG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected TimeSpanSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		LWs5ZqbBmsLjFIEbIcaG();
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

	internal static void LWs5ZqbBmsLjFIEbIcaG()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool vQeGb8bBx5v2WU1kquQM()
	{
		return m4KwnHbB7OjvCC0CusWf == null;
	}

	internal static TimeSpanSettings dNe4ILbB0eb58uBl10KC()
	{
		return m4KwnHbB7OjvCC0CusWf;
	}
}
