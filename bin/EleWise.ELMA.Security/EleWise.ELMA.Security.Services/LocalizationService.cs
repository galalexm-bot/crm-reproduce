using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services;

[Service(Type = ComponentType.Web)]
public class LocalizationService : BaseLocalizationService
{
	private readonly ILazy<ISessionProvider> sessionProvider;

	private readonly string userLangFieldName;

	private readonly string userTableName;

	private readonly string userIdFieldName;

	public const string Path = "CurrentUserLanguage";

	private ICacheService cacheService;

	internal static LocalizationService iHA7XCPWSUS5XEaCijT;

	public ICacheService CacheService
	{
		get
		{
			int num = 2;
			int num2 = num;
			ICacheService obj;
			ICacheService cacheService = default(ICacheService);
			while (true)
			{
				switch (num2)
				{
				case 2:
					obj = this.cacheService;
					if (obj == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					cacheService = (this.cacheService = Locator.GetServiceNotNull<ICacheService>());
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = cacheService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public override CultureInfo DefaultCulture
	{
		get
		{
			int num = 3;
			int num2 = num;
			_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return (CultureInfo)wcSb9aPvnRn2jw1iD6P();
				case 4:
					if (_003C_003Ec__DisplayClass13_.defaultCulture != null)
					{
						obj = SR.GetCultureNames().FirstOrDefault(_003C_003Ec__DisplayClass13_._003Cget_DefaultCulture_003Eb__0);
						if (obj == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass13_.defaultCulture = SR.GetCultureFromSettings();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = wcSb9aPvnRn2jw1iD6P();
					break;
				}
				break;
			}
			return (CultureInfo)obj;
		}
	}

	public LocalizationService(ILazy<ISessionProvider> sessionProvider, IRuntimeApplication runtimeApplication)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		this.sessionProvider = sessionProvider;
		Dialect dialect = runtimeApplication.TransformationProvider.Dialect;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(EleWise.ELMA.Security.Models.IUser), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B47BFA1 ^ 0x1B47E03F));
		userLangFieldName = dialect.QuoteIfNeeded(LinqUtils.NameOf(Expression.Lambda<Func<EleWise.ELMA.Security.Models.IUser, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		userTableName = runtimeApplication.TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-268626980 ^ -268624896));
		Dialect dialect2 = runtimeApplication.TransformationProvider.Dialect;
		parameterExpression = Expression.Parameter(typeof(EleWise.ELMA.Security.Models.IUser), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48E9668D ^ 0x48E93913));
		userIdFieldName = dialect2.QuoteIfNeeded(LinqUtils.NameOf(Expression.Lambda<Func<EleWise.ELMA.Security.Models.IUser, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
	}

	public override void Save(CultureInfo info)
	{
		int num = 2;
		int num2 = num;
		IUser user = default(IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				egNSHKP7WXj6UPMcCiX(this, info, user);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				user = (IUser)cllQRVPiggWidnNbiH2(base.AuthenticationService);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void Save(CultureInfo info, IUser user)
	{
		int num = 6;
		int num2 = num;
		string text = default(string);
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				aeVlAkPBwYGv7GdsNqb(CacheService, text);
				num2 = 4;
				break;
			case 1:
				text = (string)hYqpUZPxnvXhBpZc85d(WupJNgPZbyoQ1o8fDCI(-225736894 ^ -225715994), WupJNgPZbyoQ1o8fDCI(-1965109395 ^ -1965125413), user2.Id);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				PlC4DJPN0ZAIMk9EKrm(user2);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (user2 != null)
				{
					num2 = 3;
					break;
				}
				return;
			case 4:
				return;
			case 3:
				GKXxpoPlNNgkW3oSGWM(user2, WfbHpaP6pyAWVvmy7Xg(info));
				num2 = 7;
				break;
			case 6:
				user2 = user as EleWise.ELMA.Security.Models.IUser;
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
				{
					num2 = 5;
				}
				break;
			case 7:
				user2.IsSystemLocal = false;
				num2 = 2;
				break;
			}
		}
	}

	public override CultureInfo Load(IUser user)
	{
		//Discarded unreachable code: IL_0104, IL_0113, IL_0201, IL_0210, IL_0254, IL_02da, IL_036f, IL_037e, IL_038d, IL_05b3, IL_05c2, IL_05e7
		int num = 20;
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		long? num3 = default(long?);
		LanguageHolder languageHolder = default(LanguageHolder);
		string key = default(string);
		CultureInfo cultureByName = default(CultureInfo);
		string text = default(string);
		ISession val = default(ISession);
		CultureInfo defaultCulture = default(CultureInfo);
		HttpCookie httpCookie = default(HttpCookie);
		HttpContext current = default(HttpContext);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					if (user2 == null)
					{
						num2 = 25;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 != 0)
						{
							num2 = 27;
						}
						continue;
					}
					goto case 30;
				case 2:
					if (!num3.HasValue)
					{
						num2 = 31;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 8;
				case 26:
					if (languageHolder != null)
					{
						num2 = 7;
						continue;
					}
					goto case 15;
				case 20:
					user2 = user as EleWise.ELMA.Security.Models.IUser;
					num2 = 19;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
					{
						num2 = 11;
					}
					continue;
				case 17:
					languageHolder = CacheService.Get<LanguageHolder>(key);
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
					{
						num2 = 26;
					}
					continue;
				case 34:
					return cultureByName;
				case 22:
				case 23:
					return (CultureInfo)eMYwT8PPgPwTks9y0MG();
				case 30:
					if (!UM51MvPH334mNfNGEI3(text))
					{
						num2 = 6;
						continue;
					}
					goto case 14;
				case 29:
					if (cultureByName == null)
					{
						num2 = 23;
						continue;
					}
					goto case 34;
				case 27:
					val = (ISession)RnQcABPeo6fu1FhVQ8J(sessionProvider.Value, "");
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					defaultCulture = SR.GetDefaultCulture();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad != 0)
					{
						num2 = 1;
					}
					continue;
				case 24:
					text = (string)GZdnTCPmODyXdgsu4At(user2);
					num2 = 5;
					continue;
				case 21:
					num3 = igN0c0Pu9NOoK7MG22L(base.AuthenticationService) as long?;
					num2 = 10;
					continue;
				case 1:
				{
					LanguageHolder languageHolder3 = new LanguageHolder();
					EoD1jpPadKv3bwu1k2P(languageHolder3, defaultCulture.Name);
					languageHolder = languageHolder3;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 35:
					PlC4DJPN0ZAIMk9EKrm(user2);
					num2 = 13;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc == 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
				case 38:
					GKXxpoPlNNgkW3oSGWM(user2, defaultCulture.Name);
					num2 = 28;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
					{
						num2 = 35;
					}
					continue;
				default:
					if (user2 != null)
					{
						num2 = 3;
						continue;
					}
					goto case 32;
				case 19:
					num3 = null;
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc != 0)
					{
						num2 = 25;
					}
					continue;
				case 13:
				case 18:
				case 28:
					CacheService.Insert(key, languageHolder);
					num2 = 31;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
				{
					LanguageHolder languageHolder2 = new LanguageHolder();
					EoD1jpPadKv3bwu1k2P(languageHolder2, text);
					languageHolder = languageHolder2;
					num = 18;
					break;
				}
				case 25:
					val = null;
					num2 = 11;
					continue;
				case 32:
					((IQuery)val.CreateSQLQuery((string)vB97QmPLSjfLD2rIrIw(new string[7]
					{
						(string)WupJNgPZbyoQ1o8fDCI(-1801396866 ^ -1801405118),
						userTableName,
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788380826 ^ -1788405464),
						userLangFieldName,
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-163225536 ^ -163250148),
						userIdFieldName,
						(string)WupJNgPZbyoQ1o8fDCI(-268626980 ^ -268602424)
					}))).SetParameter<string>((string)WupJNgPZbyoQ1o8fDCI(0x4E6718AE ^ 0x4E677822), (string)WfbHpaP6pyAWVvmy7Xg(defaultCulture)).SetParameter<long>((string)WupJNgPZbyoQ1o8fDCI(0x4A799728 ^ 0x4A79F704), num3.Value).ExecuteUpdate();
					num2 = 28;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa != 0)
					{
						num2 = 15;
					}
					continue;
				case 5:
				case 10:
					if (user2 == null)
					{
						num2 = 2;
						continue;
					}
					goto case 8;
				case 16:
					httpCookie = (HttpCookie)gWwRqvPwJwLhTXg42l5(S5aRBdPRdVu0FdxRyPJ(current.Response), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2068904634 ^ -2068879904));
					num2 = 12;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
					{
						num2 = 7;
					}
					continue;
				case 11:
					text = "";
					num2 = 36;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
					{
						num2 = 12;
					}
					continue;
				case 12:
					if (httpCookie != null)
					{
						num2 = 37;
						continue;
					}
					goto case 22;
				case 9:
					text = ((IQuery)e2DDQLPjfE6uErk2Onf(val, vB97QmPLSjfLD2rIrIw(new string[7]
					{
						(string)WupJNgPZbyoQ1o8fDCI(-185816410 ^ -185797306),
						userLangFieldName,
						(string)WupJNgPZbyoQ1o8fDCI(0x6A336151 ^ 0x6A333EA3),
						userTableName,
						(string)WupJNgPZbyoQ1o8fDCI(-95913524 ^ -95938098),
						userIdFieldName,
						(string)WupJNgPZbyoQ1o8fDCI(-1278809262 ^ -1278833850)
					}))).SetParameter<long>((string)WupJNgPZbyoQ1o8fDCI(--1130812004 ^ 0x4366B248), num3.Value).UniqueResult<string>();
					num2 = 30;
					continue;
				case 4:
					if (current == null)
					{
						num = 22;
						break;
					}
					goto case 16;
				case 36:
					if (user2 == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 24;
				case 37:
					cultureByName = SR.GetCultureByName((string)qHaaGXP2CJBRd8CFmWQ(httpCookie));
					num2 = 29;
					continue;
				case 7:
				case 31:
					return languageHolder.GetCulture();
				case 33:
					current = HttpContext.Current;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 == 0)
					{
						num2 = 4;
					}
					continue;
				case 8:
					key = (string)hYqpUZPxnvXhBpZc85d(WupJNgPZbyoQ1o8fDCI(0x22A54A05 ^ 0x22A515A1), WupJNgPZbyoQ1o8fDCI(-724676315 ^ -724693357), user2?.Id ?? num3.Value);
					num2 = 17;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			}
		}
	}

	public override void SetDefaultCulture(string name)
	{
		//Discarded unreachable code: IL_0041, IL_0050
		int num = 3;
		int num2 = num;
		CommonSettingsModule service = default(CommonSettingsModule);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				return;
			case 0:
				return;
			case 6:
				return;
			case 1:
				gX0U93PUlrLcTbPJLOy(service);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				service = Locator.GetService<CommonSettingsModule>();
				num2 = 2;
				break;
			case 7:
				aDM51LPotGJdjKP1vSt(name);
				num2 = 6;
				break;
			case 5:
				cxnGHGPCbe9RsgyWFY1(service.Settings, name);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (service == null)
				{
					if (UM51MvPH334mNfNGEI3(name))
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 7;
				}
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	internal static bool Uj3xuwPXQXGBN2sofYS()
	{
		return iHA7XCPWSUS5XEaCijT == null;
	}

	internal static LocalizationService e1meMVPn0UMDcrLcIWE()
	{
		return iHA7XCPWSUS5XEaCijT;
	}

	internal static object cllQRVPiggWidnNbiH2(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static void egNSHKP7WXj6UPMcCiX(object P_0, object P_1, object P_2)
	{
		((BaseLocalizationService)P_0).Save((CultureInfo)P_1, (IUser)P_2);
	}

	internal static object WfbHpaP6pyAWVvmy7Xg(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static void GKXxpoPlNNgkW3oSGWM(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.IUser)P_0).Lang = (string)P_1;
	}

	internal static void PlC4DJPN0ZAIMk9EKrm(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object WupJNgPZbyoQ1o8fDCI(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object hYqpUZPxnvXhBpZc85d(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void aeVlAkPBwYGv7GdsNqb(object P_0, object P_1)
	{
		((ICacheService)P_0).Remove((string)P_1);
	}

	internal static object igN0c0Pu9NOoK7MG22L(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUserId();
	}

	internal static object GZdnTCPmODyXdgsu4At(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Lang;
	}

	internal static object RnQcABPeo6fu1FhVQ8J(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object vB97QmPLSjfLD2rIrIw(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object e2DDQLPjfE6uErk2Onf(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static bool UM51MvPH334mNfNGEI3(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void EoD1jpPadKv3bwu1k2P(object P_0, object P_1)
	{
		((LanguageHolder)P_0).Name = (string)P_1;
	}

	internal static object S5aRBdPRdVu0FdxRyPJ(object P_0)
	{
		return ((HttpResponse)P_0).Cookies;
	}

	internal static object gWwRqvPwJwLhTXg42l5(object P_0, object P_1)
	{
		return ((HttpCookieCollection)P_0).Get((string)P_1);
	}

	internal static object qHaaGXP2CJBRd8CFmWQ(object P_0)
	{
		return ((HttpCookie)P_0).Value;
	}

	internal static object eMYwT8PPgPwTks9y0MG()
	{
		return SR.GetDefaultCulture();
	}

	internal static object wcSb9aPvnRn2jw1iD6P()
	{
		return SR.KeyCultureInfo;
	}

	internal static void cxnGHGPCbe9RsgyWFY1(object P_0, object P_1)
	{
		((CommonSettings)P_0).SystemDefaultCultureName = (string)P_1;
	}

	internal static void gX0U93PUlrLcTbPJLOy(object P_0)
	{
		((GlobalSettingsModuleBase<CommonSettings>)P_0).SaveSettings();
	}

	internal static bool aDM51LPotGJdjKP1vSt(object P_0)
	{
		return SR.SaveCultureToSettings((string)P_0);
	}
}
