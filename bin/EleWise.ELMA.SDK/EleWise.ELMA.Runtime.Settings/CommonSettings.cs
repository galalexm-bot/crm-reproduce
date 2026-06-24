using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Mvc;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Remoting;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Settings;

public class CommonSettings : GlobalSettingsBase
{
	internal class __Resources_CommonSettings
	{
		private static __Resources_CommonSettings oBuyDLQ1rJkrVT1iOFKS;

		public static string WindowTitle => (string)R7TmkxQ1YLa2Wgw0xY8G(Uv8C2yQ1jNEccCrpwRps(-1921202237 ^ -1921404869));

		public static string ApplicationBaseUrl => (string)R7TmkxQ1YLa2Wgw0xY8G(Uv8C2yQ1jNEccCrpwRps(-1426094279 ^ -1426391263));

		public static string ApplicationBaseUrlErrorMessage => SR.T((string)Uv8C2yQ1jNEccCrpwRps(0x63ABA4E8 ^ 0x63AEDCAA));

		public static string MaxFileSize => (string)R7TmkxQ1YLa2Wgw0xY8G(Uv8C2yQ1jNEccCrpwRps(-398663332 ^ -398878296));

		public static string InvalidFileExtensions => (string)R7TmkxQ1YLa2Wgw0xY8G(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E16795));

		public static string RemotingPort => (string)R7TmkxQ1YLa2Wgw0xY8G(Uv8C2yQ1jNEccCrpwRps(-475857671 ^ -475560619));

		public static string SystemDefaultCultureName => (string)R7TmkxQ1YLa2Wgw0xY8G(Uv8C2yQ1jNEccCrpwRps(0x3C5338FF ^ 0x3C56411B));

		public static string UseBaseUrlForRemoting => (string)R7TmkxQ1YLa2Wgw0xY8G(Uv8C2yQ1jNEccCrpwRps(0x103FE975 ^ 0x103A9357));

		public static string UseBaseUrlForRemoting_Description => (string)R7TmkxQ1YLa2Wgw0xY8G(Uv8C2yQ1jNEccCrpwRps(-70037984 ^ -69847878));

		public __Resources_CommonSettings()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			e2mLxOQ1LGymIgol2nj1();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object Uv8C2yQ1jNEccCrpwRps(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object R7TmkxQ1YLa2Wgw0xY8G(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool TacgCRQ1gxpGJqXNgmST()
		{
			return oBuyDLQ1rJkrVT1iOFKS == null;
		}

		internal static __Resources_CommonSettings JMHVIoQ15NNTx3L3uKdQ()
		{
			return oBuyDLQ1rJkrVT1iOFKS;
		}

		internal static void e2mLxOQ1LGymIgol2nj1()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private int remotingPort;

	private string _systemDefaultCultureName;

	private string applicationBaseUrl;

	private string invalidFileExtensions;

	private List<string> invalidFileExtensionsList;

	internal static CommonSettings CXAtgsWhnwEGFX35JZve;

	[DisplayName(typeof(__Resources_CommonSettings), "WindowTitle")]
	public string WindowTitle
	{
		[CompilerGenerated]
		get
		{
			return _003CWindowTitle_003Ek__BackingField;
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
					_003CWindowTitle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[RegularExpression("^(?:https?)://[^\\s/$.?#].?[^\\s]*$", typeof(__Resources_CommonSettings), "ApplicationBaseUrlErrorMessage")]
	[DisplayName(typeof(__Resources_CommonSettings), "ApplicationBaseUrl")]
	public string ApplicationBaseUrl
	{
		get
		{
			return applicationBaseUrl;
		}
		set
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					applicationBaseUrl = value;
					num2 = 3;
					break;
				case 2:
					if (!m70puYWhNSVI5c96jjAQ(value, UriKind.Absolute))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				case 3:
					return;
				case 1:
					throw new ArgumentException((string)laLnMCWhPIbSKirF48ER(-1870892489 ^ -1870794911));
				}
			}
		}
	}

	[DisplayName(typeof(__Resources_CommonSettings), "MaxFileSize")]
	public int MaxFileSize
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxFileSize_003Ek__BackingField;
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
					_003CMaxFileSize_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(__Resources_CommonSettings), "InvalidFileExtensions")]
	public string InvalidFileExtensions
	{
		get
		{
			return invalidFileExtensions;
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
					invalidFileExtensionsList = null;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					invalidFileExtensions = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}
	}

	[DisplayName(typeof(__Resources_CommonSettings), "RemotingPort")]
	public int RemotingPort
	{
		get
		{
			return remotingPort;
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
				case 2:
					remotingPort = value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					QT9tOMWh3LEgyq045PnI();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[HiddenInput(DisplayValue = false)]
	public int StartedRemotingPort => RemotingServiceRegistrar.GetRegisterdPort<ConfigurationServiceProvider>();

	[DisplayName(typeof(__Resources_CommonSettings), "SystemDefaultCultureName")]
	public string SystemDefaultCultureName
	{
		get
		{
			return _systemDefaultCultureName;
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
					_systemDefaultCultureName = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
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

	[Description(typeof(__Resources_CommonSettings), "UseBaseUrlForRemoting_Description")]
	[DisplayName(typeof(__Resources_CommonSettings), "UseBaseUrlForRemoting")]
	public bool UseBaseUrlForRemoting
	{
		[CompilerGenerated]
		get
		{
			return _003CUseBaseUrlForRemoting_003Ek__BackingField;
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
					_003CUseBaseUrlForRemoting_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

	public CommonSettings()
	{
		//Discarded unreachable code: IL_0055, IL_005a
		i81QfFWhen9IC1utmULV();
		remotingPort = 7100;
		applicationBaseUrl = (string)laLnMCWhPIbSKirF48ER(0x269E5FCA ^ 0x269FC2C2);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				WindowTitle = (string)YmwiWHWh1rUK0wMhtxPC(laLnMCWhPIbSKirF48ER(--1418440330 ^ 0x548A33A6));
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			case 1:
				InvalidFileExtensions = (string)laLnMCWhPIbSKirF48ER(-1870892489 ^ -1870794885);
				num = 2;
				break;
			case 3:
				MaxFileSize = 1000;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public int GetRealRemotingPort()
	{
		return RemotingPort;
	}

	public List<string> GetInvalidFileExtensions()
	{
		if (invalidFileExtensionsList == null)
		{
			invalidFileExtensionsList = InvalidFileExtensions.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A77DE95), string.Empty).Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(delegate(string e)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return e;
					case 1:
						if (!e.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812031350)))
						{
							return (string)_003C_003Ec.Jsge7fQNB5R3BRpEkYN9(_003C_003Ec.foD4b0QNFkRin0pGfC4I(0x3A5D5EF ^ 0x3A5CF2B), e);
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			})
				.ToList();
		}
		return invalidFileExtensionsList;
	}

	internal static void i81QfFWhen9IC1utmULV()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object laLnMCWhPIbSKirF48ER(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object YmwiWHWh1rUK0wMhtxPC(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static bool DbpRW1WhOMh9DRW7QGDK()
	{
		return CXAtgsWhnwEGFX35JZve == null;
	}

	internal static CommonSettings UtjJ1rWh2ad6vDkpiSiW()
	{
		return CXAtgsWhnwEGFX35JZve;
	}

	internal static bool m70puYWhNSVI5c96jjAQ(object P_0, UriKind P_1)
	{
		return Uri.IsWellFormedUriString((string)P_0, P_1);
	}

	internal static void QT9tOMWh3LEgyq045PnI()
	{
		ConfigurationServiceProvider.Register();
	}
}
