using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services;

public abstract class BaseLocalizationService : ILocalizationService
{
	private static BaseLocalizationService Wx3emWB77QSFaLnFLSco;

	public IAuthenticationService AuthenticationService
	{
		[CompilerGenerated]
		get
		{
			return _003CAuthenticationService_003Ek__BackingField;
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
					_003CAuthenticationService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public abstract CultureInfo DefaultCulture { get; }

	public abstract void Save(CultureInfo info);

	public abstract void Save(CultureInfo info, IUser user);

	public virtual CultureInfo Load()
	{
		int num = 1;
		int num2 = num;
		IUser user = default(IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				return (CultureInfo)g8nT4SB7ycTJQXTE6MWr(this, user);
			case 1:
				user = (IUser)qyViOAB7m7aiWtLssqMy(AuthenticationService);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public abstract CultureInfo Load(IUser user);

	public virtual void InitCulture()
	{
		int num = 2;
		int num2 = num;
		CultureInfo threadCulture = default(CultureInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				SetThreadCulture(threadCulture);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				threadCulture = (CultureInfo)rJBgHZB7McT10Ms7Y8Tm(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public virtual void InitCulture(string filePath)
	{
		//Discarded unreachable code: IL_00a2
		int num = 2;
		int num2 = num;
		CultureInfo threadCulture = default(CultureInfo);
		LanguageHolder languageHolder = default(LanguageHolder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				threadCulture = (CultureInfo)vcIPxbB79e8s40MGNOeY(languageHolder);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			default:
				SetThreadCulture(threadCulture);
				num2 = 4;
				break;
			case 2:
				languageHolder = (LanguageHolder)h0mvV1B7JJrun6LZaJXd(filePath);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (languageHolder == null)
				{
					num2 = 5;
					break;
				}
				goto case 3;
			case 4:
				return;
			case 5:
				return;
			}
		}
	}

	private void SetThreadCulture(CultureInfo culture)
	{
		//Discarded unreachable code: IL_008a
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
				((Thread)okSv0pB7d0IMhQlSXyDn()).CurrentUICulture = culture;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				QVPtPRB7gxoQNRBk3435(okSv0pB7d0IMhQlSXyDn(), Tgf7cZB7reTntkttX7r2(Rj2SMkB7l4dhuCyPpdkM(culture)));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (culture == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public abstract void SetDefaultCulture(string name);

	protected BaseLocalizationService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool OGC5j3B7x1s95jAkHDWc()
	{
		return Wx3emWB77QSFaLnFLSco == null;
	}

	internal static BaseLocalizationService kqdnb4B70LjfdjoEUnfn()
	{
		return Wx3emWB77QSFaLnFLSco;
	}

	internal static object qyViOAB7m7aiWtLssqMy(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static object g8nT4SB7ycTJQXTE6MWr(object P_0, object P_1)
	{
		return ((BaseLocalizationService)P_0).Load((IUser)P_1);
	}

	internal static object rJBgHZB7McT10Ms7Y8Tm(object P_0)
	{
		return ((BaseLocalizationService)P_0).Load();
	}

	internal static object h0mvV1B7JJrun6LZaJXd(object P_0)
	{
		return SR.ReadFromFile((string)P_0);
	}

	internal static object vcIPxbB79e8s40MGNOeY(object P_0)
	{
		return ((LanguageHolder)P_0).GetCulture();
	}

	internal static object okSv0pB7d0IMhQlSXyDn()
	{
		return Thread.CurrentThread;
	}

	internal static object Rj2SMkB7l4dhuCyPpdkM(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static object Tgf7cZB7reTntkttX7r2(object P_0)
	{
		return CultureInfo.CreateSpecificCulture((string)P_0);
	}

	internal static void QVPtPRB7gxoQNRBk3435(object P_0, object P_1)
	{
		((Thread)P_0).CurrentCulture = (CultureInfo)P_1;
	}
}
