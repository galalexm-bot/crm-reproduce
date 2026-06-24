using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Service(Type = ComponentType.WebServer, InjectProperties = true, Scope = ServiceScope.Application, EnableInterceptors = false)]
public class FormsAuthenticationService : IAuthenticationService
{
	private readonly IHttpContextAccessor _httpContextAccessor;

	private IContextBoundVariableService _contextBoundVariables;

	[NotNull]
	private readonly IAuthenticationServiceEventHandler _authenticationServiceEventHandler;

	[NotNull]
	private readonly IAuthenticationServiceEventHandler2 _authenticationServiceEventHandler2;

	[NotNull]
	private readonly ActiveUserSessionService _activeUserSessionService;

	private ISessionProvider _sessionProvider;

	private static FormsAuthenticationService kQ3keLns3UrMIkLS2Bj;

	private UserManager userManager => (UserManager)QgGmven4frvXnetDBJK();

	private UserSecurityProfileManager userSecurityProfileManager => (UserSecurityProfileManager)F9PEO1nV4TM3yZLO74p();

	public IContextObjects ContextObjects
	{
		[CompilerGenerated]
		get
		{
			return _003CContextObjects_003Ek__BackingField;
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
					_003CContextObjects_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TimeSpan ExpirationTimeSpan
	{
		[CompilerGenerated]
		get
		{
			return _003CExpirationTimeSpan_003Ek__BackingField;
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
					_003CExpirationTimeSpan_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
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

	public ILogger Logger
	{
		[CompilerGenerated]
		get
		{
			return _003CLogger_003Ek__BackingField;
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
					_003CLogger_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private IContextBoundVariableService ContextBoundVariables
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return _contextBoundVariables;
				case 1:
					if (_contextBoundVariables != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_contextBoundVariables = Locator.GetService<IContextBoundVariableService>();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
					{
						num2 = 2;
					}
					break;
				default:
					return _contextBoundVariables;
				}
			}
		}
	}

	private ISessionProvider SessionProvider
	{
		get
		{
			int num = 1;
			int num2 = num;
			ISessionProvider sessionProvider = default(ISessionProvider);
			ISessionProvider sessionProvider2;
			while (true)
			{
				switch (num2)
				{
				default:
					sessionProvider = (_sessionProvider = Locator.GetServiceNotNull<ISessionProvider>());
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					sessionProvider2 = _sessionProvider;
					if (sessionProvider2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					sessionProvider2 = sessionProvider;
					break;
				}
				break;
			}
			return sessionProvider2;
		}
	}

	public FormsAuthenticationService(IHttpContextAccessor httpContextAccessor, IContextObjects contextObjects, IAuthenticationServiceEventHandler authenticationServiceEventHandler, IAuthenticationServiceEventHandler2 authenticationServiceEventHandler2, ActiveUserSessionService activeUserSessionService)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		Qur95onQMscAvceqKGU();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 1:
				_activeUserSessionService = activeUserSessionService;
				num = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d != 0)
				{
					num = 7;
				}
				break;
			case 6:
				ContextObjects = contextObjects;
				num = 2;
				break;
			case 2:
				_authenticationServiceEventHandler = authenticationServiceEventHandler;
				num = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
				{
					num = 2;
				}
				break;
			default:
				ExpirationTimeSpan = q7bhXknTqvB46Pn3Rla();
				num = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
				{
					num = 4;
				}
				break;
			case 4:
				_httpContextAccessor = httpContextAccessor;
				num = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
				{
					num = 6;
				}
				break;
			case 7:
				Logger = (ILogger)n6x9v5ndXGVXfRiZFIx();
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 != 0)
				{
					num = 0;
				}
				break;
			case 5:
				return;
			case 3:
				_authenticationServiceEventHandler2 = authenticationServiceEventHandler2;
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public IUser GetCurrentUser()
	{
		Guid ticketId;
		return GetCurrentUser(tryReSignIn: true, getInactiove: false, out ticketId);
	}

	public object GetCurrentUserId()
	{
		//Discarded unreachable code: IL_0075, IL_01c6, IL_01d5, IL_01e5, IL_01f4, IL_0246, IL_0255, IL_0265, IL_02db, IL_02ea, IL_02fa
		int num = 11;
		int num2 = num;
		UserHolder value = default(UserHolder);
		EleWise.ELMA.Security.Models.IUser contextUser = default(EleWise.ELMA.Security.Models.IUser);
		HttpContextBase httpContextBase = default(HttpContextBase);
		int result = default(int);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 9:
			case 13:
			case 16:
				return null;
			case 20:
				if (value != null)
				{
					num2 = 18;
					break;
				}
				goto case 8;
			case 19:
				return contextUser.GetId();
			case 2:
				if (ContextBoundVariables == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 15;
			case 1:
				return xA6Rkcn8O7T13mdvJZ4(value.Object);
			case 5:
			case 6:
				httpContextBase = (HttpContextBase)jYHgxanrq486gaeeQgk(_httpContextAccessor);
				num2 = 12;
				break;
			case 11:
			{
				contextUser = GetContextUser(tryReSignIn: false, out var _);
				num2 = 10;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 != 0)
				{
					num2 = 7;
				}
				break;
			}
			case 15:
				if (!ContextBoundVariables.TryGetValue<UserHolder>((string)gyh8jhngSulEXijBLOt(0x1B3723C5 ^ 0x1B3706B1), out value))
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 20;
			case 14:
				if (zorHD4nbpMDOxdxLCu5(nZGtoVnyNQkTYumMHQJ(httpContextBase)) is FormsIdentity)
				{
					if (int.TryParse((string)((object[])gd8hlgn17Pd6rgfyMAH(XMk5TZn9JPdWwpJ4Lxh(FHBvwUnSRLo8UTPgAWn((FormsIdentity)((IPrincipal)nZGtoVnyNQkTYumMHQJ(httpContextBase)).Identity)), iyHkQ9nfrun35C64I8O(gyh8jhngSulEXijBLOt(-2119527672 ^ -2119518474))))[0], out result))
					{
						num2 = 3;
						break;
					}
					goto case 4;
				}
				num2 = 9;
				break;
			case 7:
				return null;
			case 3:
				return result;
			case 12:
				if (httpContextBase == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc != 0)
					{
						num2 = 13;
					}
					break;
				}
				goto case 17;
			case 10:
				if (contextUser == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 8:
				obj = null;
				goto IL_030b;
			default:
				if (contextUser.IsActive())
				{
					num2 = 19;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
					{
						num2 = 19;
					}
					break;
				}
				goto case 2;
			case 4:
				fUqkj7nzcr9948hnkSm(Logger, gyh8jhngSulEXijBLOt(0x201ABE6B ^ 0x201A986F));
				num2 = 7;
				break;
			case 17:
				if (!wjcs7pn3KhnMa95I3w2(httpContextBase.Request))
				{
					num2 = 16;
					break;
				}
				goto case 14;
			case 18:
				{
					obj = value.Object;
					goto IL_030b;
				}
				IL_030b:
				if (obj != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	public IUser GetCurrentUserInactive()
	{
		Guid ticketId;
		return GetCurrentUser(tryReSignIn: true, getInactiove: true, out ticketId);
	}

	private IUser GetCurrentUser(bool tryReSignIn, bool getInactiove, out Guid ticketId)
	{
		//Discarded unreachable code: IL_006d, IL_015c, IL_0198, IL_01b8, IL_01c7
		int num = 8;
		int num2 = num;
		IUser currentUserNonCached = default(IUser);
		UserHolder value = default(UserHolder);
		string value2 = default(string);
		EleWise.ELMA.Security.Models.IUser contextUser = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 14:
				return currentUserNonCached;
			case 1:
				ContextBoundVariables.Set((string)gyh8jhngSulEXijBLOt(0x432996D0 ^ 0x4329B3A4), new UserHolder((EleWise.ELMA.Security.Models.IUser)currentUserNonCached, ticketId));
				num2 = 14;
				break;
			case 5:
				if (!getInactiove)
				{
					num2 = 16;
					break;
				}
				goto case 6;
			case 2:
				ticketId = REkPQmikDZ6QMuWCa2a(value);
				num2 = 13;
				break;
			case 3:
				return userManager.LoadOrNull(int.Parse(value2));
			default:
				currentUserNonCached = GetCurrentUserNonCached(tryReSignIn, out ticketId);
				num2 = 15;
				break;
			case 18:
				if (ContextBoundVariables.TryGetValue<UserHolder>((string)gyh8jhngSulEXijBLOt(-434542700 ^ -434552096), out value))
				{
					num2 = 9;
					break;
				}
				goto case 11;
			case 8:
				contextUser = GetContextUser(tryReSignIn, out ticketId);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
				{
					num2 = 7;
				}
				break;
			case 13:
				return value.Object;
			case 11:
			case 17:
				if (ContextBoundVariables == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 12;
			case 7:
				if (contextUser != null)
				{
					num2 = 5;
					break;
				}
				if (ContextBoundVariables == null)
				{
					num2 = 17;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
					{
						num2 = 12;
					}
					break;
				}
				goto case 18;
			case 16:
				if (!contextUser.IsActive())
				{
					num2 = 10;
					break;
				}
				goto case 6;
			case 6:
				return contextUser;
			case 10:
				return null;
			case 15:
				if (ContextBoundVariables != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 14;
			case 4:
				if (!string.IsNullOrEmpty(value2))
				{
					num2 = 3;
					break;
				}
				goto default;
			case 9:
				if (value == null)
				{
					num2 = 11;
					break;
				}
				goto case 2;
			case 12:
				if (ContextBoundVariables.TryGetValue<string>((string)gyh8jhngSulEXijBLOt(-2119527672 ^ -2119518900), out value2))
				{
					num2 = 4;
					break;
				}
				goto default;
			}
		}
	}

	private IUser GetCurrentUserNonCached(bool tryReSignIn, out Guid ticketId)
	{
		//Discarded unreachable code: IL_00aa, IL_00f6, IL_0128, IL_0160, IL_016f, IL_01bb, IL_02ca, IL_02fa, IL_0309, IL_0372, IL_0381, IL_0422, IL_0431
		int num = 11;
		int num2 = num;
		string text = default(string);
		HttpContextBase httpContextBase = default(HttpContextBase);
		IUser result = default(IUser);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		string[] array = default(string[]);
		int result2 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 18:
				Logger.Fatal(gyh8jhngSulEXijBLOt(0x738E3073 ^ 0x738E1677));
				num2 = 7;
				break;
			case 22:
				try
				{
					text = (string)XMk5TZn9JPdWwpJ4Lxh(AVwv2xinFlXcVsfL8eS(((HttpCookie)NqboG2iXJniNIuf9x6h(AgkGBqi58o2E0UI6S5l(httpContextBase.Request), FormsAuthentication.FormsCookieName)).Value));
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							return result;
						}
						result = null;
						num4 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
						{
							num4 = 1;
						}
					}
				}
				goto case 2;
			case 11:
				ticketId = Guid.Empty;
				num2 = 10;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				httpContextBase = (HttpContextBase)jYHgxanrq486gaeeQgk(_httpContextAccessor);
				num2 = 15;
				break;
			case 19:
				if (((IEnumerable<string>)IP5rUuiAKxqqfwjS6jI(AgkGBqi58o2E0UI6S5l(UK0kygipps0l580mDwP(httpContextBase)))).Contains((string)U0Ke7LiWyAuWkQAXkGf()))
				{
					num2 = 22;
					break;
				}
				goto case 14;
			case 13:
				return null;
			case 3:
				return user;
			case 15:
				if (httpContextBase == null)
				{
					num2 = 16;
					break;
				}
				goto case 21;
			case 6:
				text = ((FormsAuthenticationTicket)FHBvwUnSRLo8UTPgAWn((FormsIdentity)httpContextBase.User.Identity)).UserData;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
				{
					num2 = 2;
				}
				break;
			case 8:
				if (!int.TryParse(array[0], out result2))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
					{
						num2 = 18;
					}
					break;
				}
				if (array.Length >= 2)
				{
					num2 = 24;
					break;
				}
				goto case 4;
			case 5:
				return null;
			case 4:
				return null;
			case 1:
				user = userManager.LoadOrNull(result2);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (user != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
					{
						num2 = 12;
					}
					break;
				}
				goto case 5;
			case 24:
				if (Guid.TryParse(array[1], out ticketId))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 17:
				if (!(zorHD4nbpMDOxdxLCu5(nZGtoVnyNQkTYumMHQJ(httpContextBase)) is WindowsIdentity))
				{
					num2 = 23;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
					{
						num2 = 23;
					}
					break;
				}
				goto case 19;
			case 12:
				if (user.IsActive())
				{
					if (GetAndCheckSession(ticketId, user, tryReSignIn) != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 13;
				}
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
				{
					num2 = 1;
				}
				break;
			case 14:
			case 23:
				return null;
			case 2:
				array = text.Split((char[])iyHkQ9nfrun35C64I8O(gyh8jhngSulEXijBLOt(-230994601 ^ -230987607)));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
				{
					num2 = 8;
				}
				break;
			case 7:
				return null;
			case 21:
				if (wjcs7pn3KhnMa95I3w2(UK0kygipps0l580mDwP(httpContextBase)))
				{
					num2 = 20;
					break;
				}
				goto case 9;
			case 9:
			case 16:
				return null;
			case 20:
				if (zorHD4nbpMDOxdxLCu5(nZGtoVnyNQkTYumMHQJ(httpContextBase)) is FormsIdentity)
				{
					num2 = 6;
					break;
				}
				goto case 17;
			}
		}
	}

	public T GetCurrentUser<T>() where T : IUser
	{
		IUser currentUser = GetCurrentUser();
		if (currentUser == null)
		{
			return default(T);
		}
		return (T)currentUser;
	}

	public T GetCurrentUserInactive<T>() where T : IUser
	{
		IUser currentUserInactive = GetCurrentUserInactive();
		if (currentUserInactive == null)
		{
			return default(T);
		}
		return (T)currentUserInactive;
	}

	public void SignIn([NotNull] IUser user, bool rememberMeSet, bool checkRequireChangePassword)
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
				SignIn(user, null, rememberMeSet, checkRequireChangePassword);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void SignIn([NotNull] IUser user, bool rememberMeSet = false)
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
				SignIn(user, null, rememberMeSet);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void SignIn([NotNull] IUser user, string tiketAdditionalData, bool rememberMeSet = false)
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
				SignIn(user, tiketAdditionalData, rememberMeSet, checkRequireChangePassword: false);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void SignIn([NotNull] IUser user, string tiketAdditionalData, bool rememberMeSet, bool checkRequireChangePassword = false)
	{
		//Discarded unreachable code: IL_023b, IL_0330, IL_0406, IL_0415, IL_0532, IL_0554, IL_0616, IL_066d, IL_0690, IL_069f, IL_06e4, IL_06f3
		switch (1)
		{
		case 1:
			try
			{
				if (user != null)
				{
					int num = 30;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
					{
						num = 34;
					}
					EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
					string text = default(string);
					string value = default(string);
					HttpCookie httpCookie = default(HttpCookie);
					HttpContextBase httpContextBase = default(HttpContextBase);
					AuthenticatedSessionInfo authenticatedSessionInfo = default(AuthenticatedSessionInfo);
					DateTime dateTime2 = default(DateTime);
					long id = default(long);
					string value2 = default(string);
					DateTime dateTime = default(DateTime);
					DateTime issueDate = default(DateTime);
					while (true)
					{
						int num2;
						object obj;
						switch (num)
						{
						case 24:
							if (Tw2HpDi6JX1hUGeDYwp(userSecurityProfileManager.Load(user2)))
							{
								num = 17;
								continue;
							}
							goto case 8;
						case 36:
							text = text + (string)gyh8jhngSulEXijBLOt(-2068904634 ^ -2068897608) + tiketAdditionalData;
							num = 29;
							continue;
						case 4:
						{
							HttpCookie httpCookie2 = new HttpCookie((string)U0Ke7LiWyAuWkQAXkGf(), value);
							us1yJViR4Akgkwfd7Wc(httpCookie2, true);
							KyOrnyi2XayELSJEI0E(httpCookie2, droecdiw6TZCSHcCIHJ());
							uNuO2jiPlbFEceqgvs9(httpCookie2, ocNJJdiHyP5WiE9ELuT());
							httpCookie = httpCookie2;
							num2 = 31;
							goto IL_0045;
						}
						case 15:
							((HttpCookieCollection)eVNRDHix86qrnvkv4N4(httpContextBase.Response)).Remove((string)U0Ke7LiWyAuWkQAXkGf());
							num = 19;
							continue;
						case 7:
							authenticatedSessionInfo = new AuthenticatedSessionInfo(xTB4AhimXEOJHMJSXrk(), user2.Id, httpContextBase);
							num = 23;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
							{
								num = 19;
							}
							continue;
						case 2:
							dateTime2 = iARdiSiuuGcrN2eOrIf();
							num = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
							{
								num = 1;
							}
							continue;
						case 32:
							throw new AuthenticationException((string)vEVlAVi7JtHyaP6cWSQ(gyh8jhngSulEXijBLOt(-1757426405 ^ -1757418989)));
						case 21:
							id = user2.Id;
							num = 16;
							continue;
						case 12:
						case 41:
							obj = null;
							goto IL_0630;
						case 11:
							((HttpSessionStateBase)dhisbWilJb8a9gJIldG(httpContextBase))[(string)gyh8jhngSulEXijBLOt(-95913524 ^ -95913440)] = value2;
							num = 9;
							continue;
						case 6:
							throw new AuthenticationException((string)vEVlAVi7JtHyaP6cWSQ(gyh8jhngSulEXijBLOt(-2119527672 ^ -2119519156)));
						case 17:
							throw new RequireChangePasswordException(user);
						case 8:
							httpContextBase = (HttpContextBase)jYHgxanrq486gaeeQgk(_httpContextAccessor);
							num = 40;
							continue;
						case 25:
							((HttpCookie)YuHl83iBwYqRaQAR7bN(eVNRDHix86qrnvkv4N4(zbnBH0iZXfUK79oVZrD(httpContextBase)), gyh8jhngSulEXijBLOt(0x4CD4C8A0 ^ 0x4CD4EF2A))).Expires = DateTime.MinValue;
							num = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 != 0)
							{
								num = 2;
							}
							continue;
						default:
							authenticatedSessionInfo.Expiration = dateTime;
							num = 10;
							continue;
						case 40:
							if (httpContextBase == null)
							{
								num = 18;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 != 0)
								{
									num = 41;
								}
								continue;
							}
							goto case 39;
						case 23:
							if (rememberMeSet)
							{
								num = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
								{
									num = 0;
								}
								continue;
							}
							goto case 10;
						case 13:
							a5ATyDiogXjoicJN0OJ(_authenticationServiceEventHandler, user);
							num = 26;
							continue;
						case 38:
							if (httpContextBase != null)
							{
								num = 18;
								continue;
							}
							goto case 9;
						case 5:
							if (string.IsNullOrEmpty(tiketAdditionalData))
							{
								num = 28;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 == 0)
								{
									num = 4;
								}
								continue;
							}
							goto case 36;
						case 28:
						case 29:
							value = (string)nOYe1yiaFjgUL2q5vPo(new FormsAuthenticationTicket(1, user2.UserName, issueDate, dateTime, rememberMeSet, text, (string)ocNJJdiHyP5WiE9ELuT()));
							num = 4;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 != 0)
							{
								num = 1;
							}
							continue;
						case 39:
							if (dhisbWilJb8a9gJIldG(httpContextBase) == null)
							{
								num = 12;
								continue;
							}
							obj = YQ2AHPiNW6kslvD4jh4(dhisbWilJb8a9gJIldG(httpContextBase));
							goto IL_0630;
						case 37:
							SetContextUser(user2, YWh5LIiLrwFsfgNjDcf(authenticatedSessionInfo), inSession: true);
							num = 13;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc != 0)
							{
								num = 2;
							}
							continue;
						case 3:
							RGqLa1ivAbQZhIlyPU3(httpCookie, dateTime);
							num = 14;
							continue;
						case 33:
							dateTime = issueDate.Add(ExpirationTimeSpan);
							num = 7;
							continue;
						case 31:
							if (rememberMeSet)
							{
								num = 3;
								continue;
							}
							goto case 14;
						case 9:
							if (httpContextBase != null)
							{
								num = 25;
								continue;
							}
							goto case 2;
						case 16:
							text = (string)PgxfgMijD3sZh5HrKnB(id.ToString(), gyh8jhngSulEXijBLOt(0x4B68CDFB ^ 0x4B68E805), YWh5LIiLrwFsfgNjDcf(authenticatedSessionInfo).ToString());
							num = 5;
							continue;
						case 27:
							httpCookie.Domain = FormsAuthentication.CookieDomain;
							num = 22;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc == 0)
							{
								num = 10;
							}
							continue;
						case 18:
							if (httpContextBase.Session != null)
							{
								num = 11;
								continue;
							}
							goto case 9;
						case 1:
							issueDate = dateTime2.ToLocalTime();
							num = 33;
							continue;
						case 20:
							if (yUHIAMiiDoZJVvQoeAt(user2) != UserStatus.Blocked)
							{
								if (yUHIAMiiDoZJVvQoeAt(user2) == UserStatus.System)
								{
									num = 6;
									continue;
								}
								if (!checkRequireChangePassword)
								{
									num = 7;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 != 0)
									{
										num = 8;
									}
									continue;
								}
								goto case 24;
							}
							num = 32;
							continue;
						case 10:
							QGKZgWiePF9c1v602wB(_activeUserSessionService, authenticatedSessionInfo, (EleWise.ELMA.Security.Models.IUser)user);
							num = 21;
							continue;
						case 19:
							zGDc0tiUn3awB4eFVkn(eVNRDHix86qrnvkv4N4(zbnBH0iZXfUK79oVZrD(httpContextBase)), httpCookie);
							num = 11;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
							{
								num = 37;
							}
							continue;
						case 22:
						case 30:
							if (httpContextBase != null)
							{
								num = 15;
								continue;
							}
							goto case 37;
						case 14:
							if (IVBtfXiCZHyLmJGVEed() == null)
							{
								num = 30;
								continue;
							}
							goto case 27;
						case 35:
							break;
						case 34:
							user2 = CheckUserModel(user);
							num2 = 20;
							goto IL_0045;
						case 26:
							return;
							IL_0045:
							num = num2;
							continue;
							IL_0630:
							value2 = (string)obj;
							num = 38;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
							{
								num = 13;
							}
							continue;
						}
						break;
					}
				}
				throw new ArgumentNullException((string)gyh8jhngSulEXijBLOt(0x3E79A885 ^ 0x3E79A56F));
			}
			catch (Exception ex)
			{
				int num3 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					case 3:
						QuXaI3iJjPI7kaDLjLT(_authenticationServiceEventHandler2, user, ex);
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 != 0)
						{
							num3 = 0;
						}
						break;
					case 1:
						if (user == null)
						{
							num3 = 2;
							break;
						}
						goto case 3;
					default:
						throw;
					}
				}
			}
		case 0:
			break;
		}
	}

	public void SetAuthenticatedUserIdForRequest(object userId)
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
				w6V9bPiKi6C0MYBuB4F(ContextBoundVariables, gyh8jhngSulEXijBLOt(-848444002 ^ -848436262), userId.ToString());
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public AuthenticatedSessionInfo GetCurrentSession()
	{
		int num = 1;
		int num2 = num;
		Guid ticketId = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 1:
				GetContextUser(tryReSignIn: false, out ticketId);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (AuthenticatedSessionInfo)PpG1EfitJD95MuSxL6x(_activeUserSessionService, ticketId);
			}
		}
	}

	public IEnumerable<AuthenticatedSessionInfo> GetActiveSessions()
	{
		return _activeUserSessionService.GetSessions(new AuthenticatedSessionFilter
		{
			OnlyActive = true
		});
	}

	public IEnumerable<AuthenticatedSessionInfo> GetSessions(AuthenticatedSessionFilter filter)
	{
		return _activeUserSessionService.GetSessions(filter);
	}

	public void RemoveSession(Guid ticketId)
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
				H4AExnihFlVdbuyZi4Y(_activeUserSessionService, ticketId);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void RemoveAllUserSessions(object userId)
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
				_activeUserSessionService.RemoveAllUserSessions(userId);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private EleWise.ELMA.Security.Models.IUser CheckUserModel(IUser user)
	{
		int num = 1;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 1:
				user2 = user as EleWise.ELMA.Security.Models.IUser;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				throw new ArgumentException((string)YlkSDfiqmgywG5AElu8(gyh8jhngSulEXijBLOt(-2104667969 ^ -2104658161), new object[1] { OtxldLiOunLjvuAXd6Z(typeof(EleWise.ELMA.Security.Models.IUser).TypeHandle).FullName }));
			}
			if (user2 != null)
			{
				return user2;
			}
			num2 = 2;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
			{
				num2 = 2;
			}
		}
	}

	private void ClearContextUser()
	{
		//Discarded unreachable code: IL_00a9, IL_00b8
		int num = 4;
		UserHolder userHolder = default(UserHolder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (ContextBoundVariables != null)
					{
						num = 3;
						break;
					}
					goto case 5;
				case 6:
					if (DJ07hCicMoGV9uqDIOX(userHolder.TicketId, Guid.Empty))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 5:
					userHolder = ContextObjects.Get<UserHolder>();
					num = 7;
					break;
				case 2:
					return;
				case 7:
					if (userHolder == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				default:
					RemoveSession(userHolder.TicketId);
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
					{
						num2 = 8;
					}
					continue;
				case 3:
					w6V9bPiKi6C0MYBuB4F(ContextBoundVariables, gyh8jhngSulEXijBLOt(-2119527672 ^ -2119517390), null);
					num2 = 5;
					continue;
				case 1:
				case 8:
					ContextObjects.Set<UserHolder>(null);
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	private void SetContextUser(EleWise.ELMA.Security.Models.IUser user, Guid tickedId, bool inSession = false)
	{
		int num = 3;
		int num2 = num;
		UserHolder userHolder = default(UserHolder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				userHolder = new UserHolder(user, tickedId);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (inSession)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				if (ContextBoundVariables != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 4:
				return;
			case 1:
				ContextBoundVariables.Set((string)gyh8jhngSulEXijBLOt(-1365352774 ^ -1365346688), userHolder);
				num2 = 5;
				break;
			default:
				ContextObjects.Set(userHolder);
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	private EleWise.ELMA.Security.Models.IUser GetContextUser(bool tryReSignIn, out Guid ticketId)
	{
		//Discarded unreachable code: IL_024d, IL_025c, IL_026c
		int num = 5;
		_003C_003Ec__DisplayClass50_0 _003C_003Ec__DisplayClass50_ = default(_003C_003Ec__DisplayClass50_0);
		Action<Action> action = default(Action<Action>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					ticketId = Guid.Empty;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return null;
				case 9:
					if (_003C_003Ec__DisplayClass50_.ctx != null)
					{
						num2 = 16;
						continue;
					}
					goto case 14;
				case 2:
					action(_003C_003Ec__DisplayClass50_._003CGetContextUser_003Eb__1);
					num2 = 17;
					continue;
				case 3:
					if (REkPQmikDZ6QMuWCa2a(_003C_003Ec__DisplayClass50_.ctx) != Guid.Empty)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 9;
				case 7:
					if (_003C_003Ec__DisplayClass50_.ctx != null)
					{
						num2 = 3;
						continue;
					}
					goto case 9;
				case 1:
					_003C_003Ec__DisplayClass50_.ctx = ContextObjects.Get<UserHolder>();
					num2 = 8;
					continue;
				case 14:
					return null;
				case 16:
					return _003C_003Ec__DisplayClass50_.ctx.Object;
				case 10:
					ticketId = REkPQmikDZ6QMuWCa2a(_003C_003Ec__DisplayClass50_.ctx);
					num2 = 18;
					continue;
				case 17:
					if (_003C_003Ec__DisplayClass50_.ctx == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 7;
				case 15:
					if (ContextBoundVariables != null)
					{
						num2 = 13;
						continue;
					}
					goto case 17;
				case 4:
					break;
				case 8:
					action(_003C_003Ec__DisplayClass50_._003CGetContextUser_003Eb__2);
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					action = _003C_003Ec__DisplayClass50_._003CGetContextUser_003Eb__0;
					num2 = 15;
					continue;
				case 12:
					_003C_003Ec__DisplayClass50_.ctx = null;
					num2 = 11;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
					{
						num2 = 6;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_0();
					num2 = 4;
					continue;
				case 18:
					if (GetAndCheckSession(ticketId, _003C_003Ec__DisplayClass50_.ctx.Object, tryReSignIn) != null)
					{
						num2 = 9;
						continue;
					}
					goto case 6;
				case 13:
					if (ContextBoundVariables.TryGetValue<UserHolder>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E79A885 ^ 0x3E7980BF), out _003C_003Ec__DisplayClass50_.ctx))
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 17;
				}
				break;
			}
			_003C_003Ec__DisplayClass50_._003C_003E4__this = this;
			num = 12;
		}
	}

	public void SignOut()
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_0187
		int num = 9;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		HttpSessionState httpSessionState = default(HttpSessionState);
		Guid ticketId = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 5:
				ClearContextUser();
				num2 = 4;
				break;
			default:
				Lc2kQxiFM4lAN76VjaV();
				num2 = 10;
				break;
			case 4:
				if (bsJ87tiGpAHT2gEMXah() == null)
				{
					num2 = 13;
					break;
				}
				goto default;
			case 3:
			case 13:
				if (user == null)
				{
					num2 = 12;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 11;
			case 11:
				if (dVGSqDiMdc7wVLQ957i(user) != SecurityConstants.SystemUserUid)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 == 0)
					{
						num2 = 2;
					}
					break;
				}
				return;
			case 14:
				ML0p5YiDMsWvdi4u53Y(httpSessionState);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				brver3iEvqXpCq93JCw(httpSessionState);
				num2 = 14;
				break;
			case 9:
				user = (EleWise.ELMA.Security.Models.IUser)GetCurrentUser(tryReSignIn: false, getInactiove: false, out ticketId);
				num2 = 8;
				break;
			case 2:
				AJAVDvisBAjvoFAg9kP(_authenticationServiceEventHandler, user);
				num2 = 7;
				break;
			case 7:
				return;
			case 12:
				return;
			case 8:
				RemoveSession(ticketId);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d != 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				if (httpSessionState != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 10:
				httpSessionState = (HttpSessionState)sDsFbyi0rU18QUMot2n(bsJ87tiGpAHT2gEMXah());
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IUser GetSessionUser(string sessionId)
	{
		//Discarded unreachable code: IL_008b, IL_00c3, IL_00fb, IL_010a
		int num = 2;
		int num2 = num;
		AuthenticatedSessionInfo authenticatedSessionInfo = default(AuthenticatedSessionInfo);
		CallContextSessionOwner callContextSessionOwner = default(CallContextSessionOwner);
		IUser result = default(IUser);
		while (true)
		{
			switch (num2)
			{
			case 2:
				authenticatedSessionInfo = (AuthenticatedSessionInfo)mTlgJJiYDCwWi8MA2Xa(_activeUserSessionService, sessionId);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				try
				{
					result = UserManager.Instance.LoadOrNull((long)lIRIqei4R0AHqE1n1U8(authenticatedSessionInfo));
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => result, 
						_ => result, 
					};
				}
				finally
				{
					if (callContextSessionOwner != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								AblWQeiV18qgXYXtMvy(callContextSessionOwner);
								num4 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 != 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 3:
				return result;
			case 1:
				if (authenticatedSessionInfo == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					callContextSessionOwner = (CallContextSessionOwner)r5BVeMiIqrRMdM8QxRI();
					num2 = 4;
				}
				break;
			default:
				return null;
			}
		}
	}

	public void SetAuthenticatedUserForRequest(IUser user)
	{
		int num = 1;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				SetContextUser(user2, Guid.Empty);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				user2 = CheckUserModel(user);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private AuthenticatedSessionInfo GetAndCheckSession(Guid ticketId, EleWise.ELMA.Security.Models.IUser user, bool tryReSignIn)
	{
		//Discarded unreachable code: IL_00e2, IL_0114, IL_0167, IL_019f, IL_01ae
		int num = 5;
		int num2 = num;
		AuthenticatedSessionInfo authenticatedSessionInfo = default(AuthenticatedSessionInfo);
		HttpContextBase httpContextBase = default(HttpContextBase);
		AuthenticatedSessionInfo result = default(AuthenticatedSessionInfo);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return authenticatedSessionInfo;
			case 1:
				if (!tryReSignIn)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d != 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
					{
						num2 = 1;
					}
				}
				break;
			default:
				oNuy5OiQHSL7V5lYeck(_activeUserSessionService, authenticatedSessionInfo, httpContextBase);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				return authenticatedSessionInfo;
			case 2:
				try
				{
					QGKZgWiePF9c1v602wB(_activeUserSessionService, authenticatedSessionInfo, user);
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => authenticatedSessionInfo, 
						_ => authenticatedSessionInfo, 
					};
				}
				catch (SimultaneousSessionExceededException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return result;
						case 0:
							return result;
						case 1:
							result = null;
							num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 != 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				}
				catch (ConcurrentLicenseExceededException)
				{
					int num5 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							return result;
						case 0:
							return result;
						case 1:
							result = null;
							num5 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
							{
								num5 = 0;
							}
							break;
						}
					}
				}
			case 3:
				return null;
			case 5:
				authenticatedSessionInfo = (AuthenticatedSessionInfo)PpG1EfitJD95MuSxL6x(_activeUserSessionService, ticketId);
				num2 = 4;
				break;
			case 8:
				return null;
			case 4:
				if (authenticatedSessionInfo != null)
				{
					if (authenticatedSessionInfo.Status != AuthenticatedSessionStatus.Frozen)
					{
						httpContextBase = (HttpContextBase)jYHgxanrq486gaeeQgk(_httpContextAccessor);
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
						{
							num2 = 0;
						}
					}
				}
				else
				{
					num2 = 8;
				}
				break;
			}
		}
	}

	internal static object QgGmven4frvXnetDBJK()
	{
		return UserManager.Instance;
	}

	internal static object F9PEO1nV4TM3yZLO74p()
	{
		return UserSecurityProfileManager.Instance;
	}

	internal static void Qur95onQMscAvceqKGU()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object n6x9v5ndXGVXfRiZFIx()
	{
		return NullLogger.Instance;
	}

	internal static TimeSpan q7bhXknTqvB46Pn3Rla()
	{
		return FormsAuthentication.Timeout;
	}

	internal static bool pLBh7LnYpMHhVCFYw77()
	{
		return kQ3keLns3UrMIkLS2Bj == null;
	}

	internal static FormsAuthenticationService xT4PlynIBu1VAPL15CI()
	{
		return kQ3keLns3UrMIkLS2Bj;
	}

	internal static object gyh8jhngSulEXijBLOt(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object xA6Rkcn8O7T13mdvJZ4(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object jYHgxanrq486gaeeQgk(object P_0)
	{
		return ((IHttpContextAccessor)P_0).Current();
	}

	internal static bool wjcs7pn3KhnMa95I3w2(object P_0)
	{
		return ((HttpRequestBase)P_0).IsAuthenticated;
	}

	internal static object nZGtoVnyNQkTYumMHQJ(object P_0)
	{
		return ((HttpContextBase)P_0).User;
	}

	internal static object zorHD4nbpMDOxdxLCu5(object P_0)
	{
		return ((IPrincipal)P_0).Identity;
	}

	internal static object FHBvwUnSRLo8UTPgAWn(object P_0)
	{
		return ((FormsIdentity)P_0).Ticket;
	}

	internal static object XMk5TZn9JPdWwpJ4Lxh(object P_0)
	{
		return ((FormsAuthenticationTicket)P_0).UserData;
	}

	internal static object iyHkQ9nfrun35C64I8O(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object gd8hlgn17Pd6rgfyMAH(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static void fUqkj7nzcr9948hnkSm(object P_0, object P_1)
	{
		((ILogger)P_0).Fatal(P_1);
	}

	internal static Guid REkPQmikDZ6QMuWCa2a(object P_0)
	{
		return ((UserHolder)P_0).TicketId;
	}

	internal static object UK0kygipps0l580mDwP(object P_0)
	{
		return ((HttpContextBase)P_0).Request;
	}

	internal static object AgkGBqi58o2E0UI6S5l(object P_0)
	{
		return ((HttpRequestBase)P_0).Cookies;
	}

	internal static object IP5rUuiAKxqqfwjS6jI(object P_0)
	{
		return ((HttpCookieCollection)P_0).AllKeys;
	}

	internal static object U0Ke7LiWyAuWkQAXkGf()
	{
		return FormsAuthentication.FormsCookieName;
	}

	internal static object NqboG2iXJniNIuf9x6h(object P_0, object P_1)
	{
		return ((HttpCookieCollection)P_0)[(string)P_1];
	}

	internal static object AVwv2xinFlXcVsfL8eS(object P_0)
	{
		return FormsAuthentication.Decrypt((string)P_0);
	}

	internal static UserStatus yUHIAMiiDoZJVvQoeAt(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Status;
	}

	internal static object vEVlAVi7JtHyaP6cWSQ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool Tw2HpDi6JX1hUGeDYwp(object P_0)
	{
		return ((IUserSecurityProfile)P_0).ForcedChangePassword;
	}

	internal static object dhisbWilJb8a9gJIldG(object P_0)
	{
		return ((HttpContextBase)P_0).Session;
	}

	internal static object YQ2AHPiNW6kslvD4jh4(object P_0)
	{
		return ((HttpSessionStateBase)P_0).SessionID;
	}

	internal static object zbnBH0iZXfUK79oVZrD(object P_0)
	{
		return ((HttpContextBase)P_0).Response;
	}

	internal static object eVNRDHix86qrnvkv4N4(object P_0)
	{
		return ((HttpResponseBase)P_0).Cookies;
	}

	internal static object YuHl83iBwYqRaQAR7bN(object P_0, object P_1)
	{
		return ((HttpCookieCollection)P_0).Get((string)P_1);
	}

	internal static DateTime iARdiSiuuGcrN2eOrIf()
	{
		return DateTime.UtcNow;
	}

	internal static Guid xTB4AhimXEOJHMJSXrk()
	{
		return Guid.NewGuid();
	}

	internal static void QGKZgWiePF9c1v602wB(object P_0, object P_1, object P_2)
	{
		((ActiveUserSessionService)P_0).Insert((AuthenticatedSessionInfo)P_1, (EleWise.ELMA.Security.Models.IUser)P_2);
	}

	internal static Guid YWh5LIiLrwFsfgNjDcf(object P_0)
	{
		return ((AuthenticatedSessionInfo)P_0).TicketUid;
	}

	internal static object PgxfgMijD3sZh5HrKnB(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object ocNJJdiHyP5WiE9ELuT()
	{
		return FormsAuthentication.FormsCookiePath;
	}

	internal static object nOYe1yiaFjgUL2q5vPo(object P_0)
	{
		return FormsAuthentication.Encrypt((FormsAuthenticationTicket)P_0);
	}

	internal static void us1yJViR4Akgkwfd7Wc(object P_0, bool P_1)
	{
		((HttpCookie)P_0).HttpOnly = P_1;
	}

	internal static bool droecdiw6TZCSHcCIHJ()
	{
		return FormsAuthentication.RequireSSL;
	}

	internal static void KyOrnyi2XayELSJEI0E(object P_0, bool P_1)
	{
		((HttpCookie)P_0).Secure = P_1;
	}

	internal static void uNuO2jiPlbFEceqgvs9(object P_0, object P_1)
	{
		((HttpCookie)P_0).Path = (string)P_1;
	}

	internal static void RGqLa1ivAbQZhIlyPU3(object P_0, DateTime P_1)
	{
		((HttpCookie)P_0).Expires = P_1;
	}

	internal static object IVBtfXiCZHyLmJGVEed()
	{
		return FormsAuthentication.CookieDomain;
	}

	internal static void zGDc0tiUn3awB4eFVkn(object P_0, object P_1)
	{
		((HttpCookieCollection)P_0).Add((HttpCookie)P_1);
	}

	internal static void a5ATyDiogXjoicJN0OJ(object P_0, object P_1)
	{
		((IAuthenticationServiceEventHandler)P_0).SignedIn((IUser)P_1);
	}

	internal static void QuXaI3iJjPI7kaDLjLT(object P_0, object P_1, object P_2)
	{
		((IAuthenticationServiceEventHandler2)P_0).SignInError((IUser)P_1, (Exception)P_2);
	}

	internal static void w6V9bPiKi6C0MYBuB4F(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}

	internal static object PpG1EfitJD95MuSxL6x(object P_0, Guid ticketId)
	{
		return ((ActiveUserSessionService)P_0).Get(ticketId);
	}

	internal static void H4AExnihFlVdbuyZi4Y(object P_0, Guid ticketId)
	{
		((ActiveUserSessionService)P_0).RemoveSession(ticketId);
	}

	internal static Type OtxldLiOunLjvuAXd6Z(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object YlkSDfiqmgywG5AElu8(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static bool DJ07hCicMoGV9uqDIOX(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object bsJ87tiGpAHT2gEMXah()
	{
		return HttpContext.Current;
	}

	internal static void Lc2kQxiFM4lAN76VjaV()
	{
		FormsAuthentication.SignOut();
	}

	internal static object sDsFbyi0rU18QUMot2n(object P_0)
	{
		return ((HttpContext)P_0).Session;
	}

	internal static void brver3iEvqXpCq93JCw(object P_0)
	{
		((HttpSessionState)P_0).Clear();
	}

	internal static void ML0p5YiDMsWvdi4u53Y(object P_0)
	{
		((HttpSessionState)P_0).Abandon();
	}

	internal static Guid dVGSqDiMdc7wVLQ957i(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Uid;
	}

	internal static void AJAVDvisBAjvoFAg9kP(object P_0, object P_1)
	{
		((IAuthenticationServiceEventHandler)P_0).SignedOut((IUser)P_1);
	}

	internal static object mTlgJJiYDCwWi8MA2Xa(object P_0, object P_1)
	{
		return ((ActiveUserSessionService)P_0).FindBySessionId((string)P_1);
	}

	internal static object r5BVeMiIqrRMdM8QxRI()
	{
		return CallContextSessionOwner.Create();
	}

	internal static object lIRIqei4R0AHqE1n1U8(object P_0)
	{
		return ((AuthenticatedSessionInfo)P_0).UserId;
	}

	internal static void AblWQeiV18qgXYXtMvy(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void oNuy5OiQHSL7V5lYeck(object P_0, object P_1, object P_2)
	{
		((ActiveUserSessionService)P_0).SetUpdated((AuthenticatedSessionInfo)P_1, (HttpContextBase)P_2);
	}
}
