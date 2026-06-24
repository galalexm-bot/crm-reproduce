using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

public class UserCryptoProfileManager : EntityManager<IUserCryptoProfile, long>
{
	internal static UserCryptoProfileManager ztymMiEstCDJqLWYl14;

	[NotNull]
	public new static UserCryptoProfileManager Instance => Locator.GetServiceNotNull<UserCryptoProfileManager>();

	public IUserCryptoProfile GetUserCryptoProfile(EleWise.ELMA.Security.Models.IUser user)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass2_.user = user;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				ParameterExpression parameterExpression = Expression.Parameter(JqpIXAE4yXbPuGWwkGi(typeof(IUserCryptoProfile).TypeHandle), (string)zKYFlWEVJlqsXYSYPTv(-724676315 ^ -724665719));
				return ((AbstractNHEntityManager<IUserCryptoProfile, long>)this).Find(Expression.Lambda<Func<IUserCryptoProfile, bool>>(Expression.Equal((Expression)d4Nsl9EdOMggb5HkRKC(d4Nsl9EdOMggb5HkRKC(parameterExpression, (MethodInfo)mlsOrwEQ2FU4yJ71qx5((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)mlsOrwEQ2FU4yJ71qx5((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)d4Nsl9EdOMggb5HkRKC(QMTbRhE8Y35xl1DpDlV(x1jZNiETnxWf9i1NOJD(_003C_003Ec__DisplayClass2_, JqpIXAE4yXbPuGWwkGi(typeof(_003C_003Ec__DisplayClass2_0).TypeHandle)), XIEDgIEgg5paQT4S4HL((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)mlsOrwEQ2FU4yJ71qx5((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), liftToNull: false, (MethodInfo)mlsOrwEQ2FU4yJ71qx5((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
			}
			case 2:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void SetCurrentUserAuthCryptoProviderUid(Guid uid)
	{
		int num = 2;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser currentUser = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				SetUserAuthCryptoProviderUid(currentUser, uid);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				currentUser = ((IAuthenticationService)wOWrywErLqOVNdXIdYk(this)).GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void SetUserAuthCryptoProviderUid(EleWise.ELMA.Security.Models.IUser user, Guid uid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				UpdateUserProfile(user, _003C_003Ec__DisplayClass4_._003CSetUserAuthCryptoProviderUid_003Eb__0);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass4_.uid = uid;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public Guid GetCurrentUserAuthCryptoProviderUid()
	{
		int num = 1;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser currentUser = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				return GetUserAuthCryptoProviderUid(currentUser);
			case 1:
				currentUser = ((IAuthenticationService)wOWrywErLqOVNdXIdYk(this)).GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Guid GetUserAuthCryptoProviderUid(EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_0064, IL_0073
		int num = 3;
		int num2 = num;
		Guid? authCryptoProviderGuid = default(Guid?);
		IUserCryptoProfile userCryptoProfile = default(IUserCryptoProfile);
		while (true)
		{
			switch (num2)
			{
			default:
				authCryptoProviderGuid = userCryptoProfile.AuthCryptoProviderGuid;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				if (userCryptoProfile == null)
				{
					num2 = 6;
					break;
				}
				goto default;
			case 1:
				return authCryptoProviderGuid.Value;
			case 6:
			case 7:
				return Guid.Empty;
			case 3:
				if (user == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					userCryptoProfile = GetUserCryptoProfile(user);
					num2 = 5;
				}
				break;
			case 4:
				if (authCryptoProviderGuid.HasValue)
				{
					authCryptoProviderGuid = userCryptoProfile.AuthCryptoProviderGuid;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf != 0)
					{
						num2 = 1;
					}
				}
				break;
			case 2:
				return Guid.Empty;
			}
		}
	}

	[Transaction]
	public virtual void SetUserAuthDigitalSignatureTypeUid(EleWise.ELMA.Security.Models.IUser user, Guid uid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				UpdateUserProfile(user, _003C_003Ec__DisplayClass7_._003CSetUserAuthDigitalSignatureTypeUid_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass7_.uid = uid;
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public Guid GetUserAuthDigitalSignatureTypeUid(EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_0068, IL_008d, IL_009c
		int num = 4;
		int num2 = num;
		Guid? authDigitalSignatureTypeGuid = default(Guid?);
		IUserCryptoProfile userCryptoProfile = default(IUserCryptoProfile);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (authDigitalSignatureTypeGuid.HasValue)
				{
					num2 = 5;
					break;
				}
				goto case 1;
			case 4:
				if (user != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 7;
			case 7:
				return Guid.Empty;
			case 3:
				userCryptoProfile = GetUserCryptoProfile(user);
				num2 = 6;
				break;
			case 9:
				authDigitalSignatureTypeGuid = userCryptoProfile.AuthDigitalSignatureTypeGuid;
				num2 = 2;
				break;
			default:
				return authDigitalSignatureTypeGuid.Value;
			case 1:
			case 8:
				return Guid.Empty;
			case 5:
				authDigitalSignatureTypeGuid = userCryptoProfile.AuthDigitalSignatureTypeGuid;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (userCryptoProfile == null)
				{
					num2 = 8;
					break;
				}
				goto case 9;
			}
		}
	}

	[Transaction]
	public virtual void UpdateUserProfile(EleWise.ELMA.Security.Models.IUser user, Action<IUserCryptoProfile> action)
	{
		if (user != null)
		{
			IUserCryptoProfile userCryptoProfile = GetUserCryptoProfile(user) ?? Create();
			userCryptoProfile.User = user;
			action?.Invoke(userCryptoProfile);
			userCryptoProfile.Save();
		}
	}

	public UserCryptoProfileManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WPMH7tE37VvY8UNnP0e();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type JqpIXAE4yXbPuGWwkGi(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object zKYFlWEVJlqsXYSYPTv(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object mlsOrwEQ2FU4yJ71qx5(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object d4Nsl9EdOMggb5HkRKC(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object x1jZNiETnxWf9i1NOJD(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object XIEDgIEgg5paQT4S4HL(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object QMTbRhE8Y35xl1DpDlV(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static bool y8VijoEYyBEhtLJDhsZ()
	{
		return ztymMiEstCDJqLWYl14 == null;
	}

	internal static UserCryptoProfileManager HeshKkEI00jRMGqorUX()
	{
		return ztymMiEstCDJqLWYl14;
	}

	internal static object wOWrywErLqOVNdXIdYk(object P_0)
	{
		return ((EntityManager<IUserCryptoProfile, long>)P_0).AuthenticationService;
	}

	internal static void WPMH7tE37VvY8UNnP0e()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
