using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Service(Scope = ServiceScope.Shell, EnableInterceptors = false)]
internal class MembershipService : IMembershipService
{
	[NotNull]
	private readonly UserManager _userManager;

	[NotNull]
	private readonly UserSecurityProfileManager _userSecurityProfileManager;

	[NotNull]
	private readonly IMembershipServiceEventHandler _membershipServiceEventHandler;

	[NotNull]
	private readonly IMembershipServiceEventHandler2 _membershipServiceEventHandler2;

	[NotNull]
	private readonly IAuthenticationService _authenticationService;

	internal static MembershipService U9ilte6h60DuxhnvkMg;

	public static MembershipService Instance => Locator.GetServiceNotNull<MembershipService>();

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
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private bool TryUserError(UserValidationContext context)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_0168
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (Vs7h0p6GQ9r1gZTU1Sx(SWnTaW6cgOtHvxZ1BUm(context) as EleWise.ELMA.Security.Models.IUser) == UserStatus.Blocked)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 2:
					if (Vs7h0p6GQ9r1gZTU1Sx(SWnTaW6cgOtHvxZ1BUm(context) as EleWise.ELMA.Security.Models.IUser) == UserStatus.System)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 3;
				case 3:
				case 8:
					if (Pj31w46DrIcWYOOqpH3(context) == null)
					{
						num2 = 4;
						continue;
					}
					goto case 6;
				case 5:
					context.Error = new AuthenticationException((string)eiwLHq60gKlRBiOCZHI(YBknCZ6FOW25Tdgq1Cs(0x6AA79E0 ^ 0x6AA5EA4)));
					num2 = 3;
					continue;
				case 6:
					BWtIPv6MtQXRF5U9iVY(_membershipServiceEventHandler2, context);
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 == 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
				case 7:
					return context.Error != null;
				}
				break;
			}
			BlkkDR6Eqost9mCdfmS(context, new AuthenticationException((string)eiwLHq60gKlRBiOCZHI(YBknCZ6FOW25Tdgq1Cs(0x38328F00 ^ 0x3832A808))));
			num = 8;
		}
	}

	public MembershipService(UserManager userManager, UserSecurityProfileManager userSecurityProfileManager, IMembershipServiceEventHandler2 membershipServiceEventHandler2, IAuthenticationService authenticationService, IMembershipServiceEventHandler membershipServiceEventHandler)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 3:
				_userManager = userManager;
				num = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 != 0)
				{
					num = 0;
				}
				break;
			case 5:
				_membershipServiceEventHandler2 = membershipServiceEventHandler2;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
				{
					num = 0;
				}
				break;
			default:
				_authenticationService = authenticationService;
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				_userSecurityProfileManager = userSecurityProfileManager;
				num = 4;
				break;
			case 4:
				_membershipServiceEventHandler = membershipServiceEventHandler;
				num = 5;
				break;
			}
		}
	}

	public MembershipSettings GetSettings()
	{
		return new MembershipSettings();
	}

	public MembershipSettings GetSettings(IUser user)
	{
		return new MembershipSettings
		{
			EnablePasswordReset = (user.AuthProviderGuid == Guid.Empty)
		};
	}

	public IUser CreateUser(CreateUserParams createUserParams)
	{
		throw new NotImplementedException();
	}

	public IUser GetUser(string username)
	{
		return _userManager.LoadByLogin(username);
	}

	public IUser GetUser(object userId)
	{
		int num = 1;
		int num2 = num;
		long id = default(long);
		while (true)
		{
			switch (num2)
			{
			default:
				return _userManager.LoadOrNull(id);
			case 1:
				id = J8sv7w6sOjRZLlEAFu5(userId);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IUser ValidateUser([NotNull] string userNameOrEmail, string password)
	{
		//Discarded unreachable code: IL_0076, IL_0089, IL_0098, IL_0116, IL_01fa, IL_0209, IL_023c, IL_026d, IL_02f0, IL_02ff, IL_030f, IL_031e, IL_0346, IL_0361, IL_03b1, IL_03c0, IL_03f1, IL_0421, IL_04ce, IL_0542, IL_0551, IL_0594, IL_05a3
		int num = 4;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		UserValidationContext userValidationContext2 = default(UserValidationContext);
		bool flag2 = default(bool);
		bool flag = default(bool);
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		IUser result = default(IUser);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (user != null)
				{
					num2 = 8;
					continue;
				}
				break;
			case 4:
				if (userNameOrEmail != null)
				{
					num2 = 3;
					continue;
				}
				goto case 10;
			case 5:
				if (!TryUserError(userValidationContext2))
				{
					num2 = 7;
					continue;
				}
				goto case 2;
			case 10:
				throw new ArgumentNullException((string)YBknCZ6FOW25Tdgq1Cs(0x7DABA580 ^ 0x7DAB8E5A));
			case 3:
				user = (EleWise.ELMA.Security.Models.IUser)Ns3YH56YTFfotPF1L0V(_userManager, userNameOrEmail);
				num2 = 6;
				continue;
			case 9:
				try
				{
					k6MEJp6dG2OGrIM2c63(_membershipServiceEventHandler, userValidationContext2);
					int num3 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
					{
						num3 = 16;
					}
					while (true)
					{
						object obj;
						switch (num3)
						{
						case 8:
							FXhfLN64x5twIwt2hVg(userValidationContext2, flag2 = true);
							num3 = 4;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d == 0)
							{
								num3 = 4;
							}
							continue;
						case 4:
							flag = flag2;
							num3 = 27;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
							{
								num3 = 27;
							}
							continue;
						case 15:
							if (Pj31w46DrIcWYOOqpH3(userValidationContext2) == null)
							{
								num3 = 24;
								continue;
							}
							goto case 14;
						case 26:
							break;
						case 16:
							flag = false;
							num3 = 15;
							continue;
						case 1:
						case 3:
							if (Pj31w46DrIcWYOOqpH3(userValidationContext2) != null)
							{
								num3 = 10;
								continue;
							}
							goto default;
						case 13:
						case 24:
							FXhfLN64x5twIwt2hVg(userValidationContext2, false);
							num3 = 24;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d == 0)
							{
								num3 = 25;
							}
							continue;
						case 25:
							if (feX4fd6gHn32XQgNO3K(QcyTtP6TGCu9BTc5NJ0(user), Guid.Empty))
							{
								num3 = 7;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
								{
									num3 = 4;
								}
								continue;
							}
							goto case 20;
						case 9:
						case 18:
							_userSecurityProfileManager.ResetCountFailedLogon(user);
							num3 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
							{
								num3 = 1;
							}
							continue;
						case 20:
							ukuWpG6yoA43Q3kL4Gq(Locator.GetServiceNotNull<IExternalMembershipManager>(), userValidationContext2, QcyTtP6TGCu9BTc5NJ0(user));
							num3 = 21;
							continue;
						case 6:
							break;
						case 10:
							_membershipServiceEventHandler2.ValidationError(userValidationContext2);
							num3 = 6;
							continue;
						case 19:
							obj = null;
							goto IL_0491;
						case 22:
							if (user2 == null)
							{
								num3 = 23;
								continue;
							}
							goto case 5;
						case 14:
							BWtIPv6MtQXRF5U9iVY(_membershipServiceEventHandler2, userValidationContext2);
							num3 = 26;
							continue;
						case 7:
							user2 = (EleWise.ELMA.Security.Models.IUser)idB78a63NxCoHb1eEco(_userManager, TuaB1P68RXctZr8WpPP(SWnTaW6cgOtHvxZ1BUm(userValidationContext2)), uG6wHS6rltOF5K9kQw2(userValidationContext2));
							num3 = 22;
							continue;
						case 12:
							if (flag)
							{
								num3 = 2;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 19;
						case 17:
						case 23:
						case 27:
							if (flag)
							{
								num3 = 18;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c != 0)
								{
									num3 = 11;
								}
								continue;
							}
							goto case 29;
						case 5:
							Ly6mdQ6VTdA8YEepvUM(userValidationContext2, user2);
							num3 = 8;
							continue;
						case 29:
							SetFailedLogon(user);
							num3 = 3;
							continue;
						default:
							E8cpTm6Spd9CmX9Ys9j(_membershipServiceEventHandler, userValidationContext2);
							num3 = 12;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
							{
								num3 = 8;
							}
							continue;
						case 21:
							flag = MsbLf16bZj81vCaAkrB(userValidationContext2);
							num3 = 17;
							continue;
						case 2:
							obj = SWnTaW6cgOtHvxZ1BUm(userValidationContext2);
							goto IL_0491;
						case 11:
							break;
						case 28:
							{
								return result;
							}
							IL_0491:
							result = (IUser)obj;
							num3 = 12;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
							{
								num3 = 28;
							}
							continue;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
					{
						num4 = 2;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							Vckm3r6fGLUqMUgPnwq(Logger, E7HGXw69PX5tKKfq4U1(ex), ex);
							num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
							{
								num4 = 0;
							}
							continue;
						case 2:
							BWtIPv6MtQXRF5U9iVY(_membershipServiceEventHandler2, userValidationContext2);
							num4 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 1;
			case 2:
				return null;
			case 7:
				num2 = 9;
				continue;
			case 8:
				if (!i00Jef6I5g8IUx7cQ4p(_userSecurityProfileManager.Load(user)))
				{
					num2 = 11;
					continue;
				}
				goto case 12;
			case 1:
				return null;
			case 12:
				return null;
			case 11:
			{
				UserValidationContext userValidationContext = new UserValidationContext();
				FXhfLN64x5twIwt2hVg(userValidationContext, false);
				Ly6mdQ6VTdA8YEepvUM(userValidationContext, user);
				WO7kco6QQKLktFoQvcc(userValidationContext, password);
				userValidationContext2 = userValidationContext;
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
				{
					num2 = 4;
				}
				continue;
			}
			}
			IMembershipServiceEventHandler2 membershipServiceEventHandler = _membershipServiceEventHandler2;
			UserValidationContext userValidationContext3 = new UserValidationContext();
			BlkkDR6Eqost9mCdfmS(userValidationContext3, new Exception(string.Format((string)eiwLHq60gKlRBiOCZHI(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-731479136 ^ -731469732)), userNameOrEmail)));
			BWtIPv6MtQXRF5U9iVY(membershipServiceEventHandler, userValidationContext3);
			num2 = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da != 0)
			{
				num2 = 0;
			}
		}
	}

	public void SetPassword(IUser user, string password)
	{
		//Discarded unreachable code: IL_0071, IL_00a4, IL_00ea, IL_00f9
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (user != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 0:
				return;
			case 1:
				try
				{
					RrmcpB61nLyV2A5Kde7(_membershipServiceEventHandler, user, password);
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 != 0)
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
					int num4 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							Vckm3r6fGLUqMUgPnwq(Logger, E7HGXw69PX5tKKfq4U1(ex), ex);
							num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
							{
								num4 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
			}
		}
	}

	public long GetFailedLogon(string userName)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 3:
				user = GetUser(userName) as EleWise.ELMA.Security.Models.IUser;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (user != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				return 0L;
			default:
				return _userSecurityProfileManager.Load(user).CountFailedLogon;
			}
		}
	}

	public void CheckRequireChangePassword(object userId)
	{
		//Discarded unreachable code: IL_0077, IL_0086
		int num = 2;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (user == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				if (bk3D8G6z9wxJKLoD6fL(_userSecurityProfileManager.Load(user)))
				{
					num2 = 4;
					break;
				}
				return;
			case 0:
				return;
			case 2:
				user = GetUser(userId) as EleWise.ELMA.Security.Models.IUser;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				throw new RequireChangePasswordException(user);
			}
		}
	}

	private void SetFailedLogon(EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 3:
				return;
			default:
				_userSecurityProfileManager.FailedLogon(user);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (r6Pj0qlkn3NQuIvOrB7(Locator.GetServiceNotNull<SecuritySettingsModule>().Settings) <= 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal static object SWnTaW6cgOtHvxZ1BUm(object P_0)
	{
		return ((UserValidationContext)P_0).User;
	}

	internal static UserStatus Vs7h0p6GQ9r1gZTU1Sx(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Status;
	}

	internal static object YBknCZ6FOW25Tdgq1Cs(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object eiwLHq60gKlRBiOCZHI(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void BlkkDR6Eqost9mCdfmS(object P_0, object P_1)
	{
		((UserValidationContext)P_0).Error = (Exception)P_1;
	}

	internal static object Pj31w46DrIcWYOOqpH3(object P_0)
	{
		return ((UserValidationContext)P_0).Error;
	}

	internal static void BWtIPv6MtQXRF5U9iVY(object P_0, object P_1)
	{
		((IMembershipServiceEventHandler2)P_0).ValidationError((UserValidationContext)P_1);
	}

	internal static bool eUMhCY6OvwSnjxhhOmm()
	{
		return U9ilte6h60DuxhnvkMg == null;
	}

	internal static MembershipService HmdOoj6qpqDyxI2utpt()
	{
		return U9ilte6h60DuxhnvkMg;
	}

	internal static long J8sv7w6sOjRZLlEAFu5(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object Ns3YH56YTFfotPF1L0V(object P_0, object P_1)
	{
		return ((UserManager)P_0).LoadByLogin((string)P_1);
	}

	internal static bool i00Jef6I5g8IUx7cQ4p(object P_0)
	{
		return ((IUserSecurityProfile)P_0).DisallowLogon;
	}

	internal static void FXhfLN64x5twIwt2hVg(object P_0, bool P_1)
	{
		((UserValidationContext)P_0).Authorized = P_1;
	}

	internal static void Ly6mdQ6VTdA8YEepvUM(object P_0, object P_1)
	{
		((UserValidationContext)P_0).User = (IUser)P_1;
	}

	internal static void WO7kco6QQKLktFoQvcc(object P_0, object P_1)
	{
		((UserValidationContext)P_0).Password = (string)P_1;
	}

	internal static void k6MEJp6dG2OGrIM2c63(object P_0, object P_1)
	{
		((IMembershipServiceEventHandler)P_0).Validating((UserValidationContext)P_1);
	}

	internal static Guid QcyTtP6TGCu9BTc5NJ0(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).AuthProviderGuid;
	}

	internal static bool feX4fd6gHn32XQgNO3K(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object TuaB1P68RXctZr8WpPP(object P_0)
	{
		return ((IUser)P_0).UserName;
	}

	internal static object uG6wHS6rltOF5K9kQw2(object P_0)
	{
		return ((UserValidationContext)P_0).Password;
	}

	internal static object idB78a63NxCoHb1eEco(object P_0, object P_1, object P_2)
	{
		return ((UserManager)P_0).Login((string)P_1, (string)P_2);
	}

	internal static void ukuWpG6yoA43Q3kL4Gq(object P_0, object P_1, Guid authProviderGuid)
	{
		((IExternalMembershipManager)P_0).ValidateUser((UserValidationContext)P_1, authProviderGuid);
	}

	internal static bool MsbLf16bZj81vCaAkrB(object P_0)
	{
		return ((UserValidationContext)P_0).Authorized;
	}

	internal static void E8cpTm6Spd9CmX9Ys9j(object P_0, object P_1)
	{
		((IMembershipServiceEventHandler)P_0).Validated((UserValidationContext)P_1);
	}

	internal static object E7HGXw69PX5tKKfq4U1(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void Vckm3r6fGLUqMUgPnwq(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void RrmcpB61nLyV2A5Kde7(object P_0, object P_1, object P_2)
	{
		((IMembershipServiceEventHandler)P_0).SetPassword((IUser)P_1, (string)P_2);
	}

	internal static bool bk3D8G6z9wxJKLoD6fL(object P_0)
	{
		return ((IUserSecurityProfile)P_0).ForcedChangePassword;
	}

	internal static int r6Pj0qlkn3NQuIvOrB7(object P_0)
	{
		return ((SecuritySettings)P_0).CountLogonAttempts;
	}
}
