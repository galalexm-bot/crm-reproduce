using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security;

[Component]
internal class UserModelMembershipEventHandler : IMembershipServiceEventHandler2, IMembershipServiceEventHandler, IEventHandler
{
	private readonly UserManager userManager;

	private readonly UserSecurityProfileManager userSecurityProfileManager;

	internal static UserModelMembershipEventHandler ds9abT6vVLnnOSxrh1k;

	public UserModelMembershipEventHandler(UserManager userManager, UserSecurityProfileManager userSecurityProfileManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fObBRG6oNEMCM1XG7Ue();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.userManager = userManager;
				num = 2;
				break;
			case 1:
				return;
			case 2:
				this.userSecurityProfileManager = userSecurityProfileManager;
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public void Validating([NotNull] UserValidationContext context)
	{
	}

	public void Validated(UserValidationContext context)
	{
		//Discarded unreachable code: IL_003d, IL_004c
		int num = 6;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				user = aBmcvD6KrnmYH4hU1Ax(context) as EleWise.ELMA.Security.Models.IUser;
				num2 = 4;
				break;
			case 5:
				if (uk3myD6JHmc4sAWx2Fb(context) != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 1:
				userSecurityProfileManager.ResetCountFailedLogon(user);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				if (context.Authorized)
				{
					num2 = 5;
					break;
				}
				return;
			case 3:
				return;
			case 4:
				if (user == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void SetPassword(IUser user, string password)
	{
		int num = 2;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 2:
				user2 = user as EleWise.ELMA.Security.Models.IUser;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
				{
					num2 = 1;
				}
				break;
			default:
				rSluRJ6t4GMhcsEMSc6(userManager, user2.Id, password);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return;
			case 1:
				if (user2 == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ValidationError(UserValidationContext context)
	{
	}

	internal static void fObBRG6oNEMCM1XG7Ue()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool XXOHTU6CxndtNeM3EfJ()
	{
		return ds9abT6vVLnnOSxrh1k == null;
	}

	internal static UserModelMembershipEventHandler uM14W26Ux37QQnYoLHK()
	{
		return ds9abT6vVLnnOSxrh1k;
	}

	internal static object uk3myD6JHmc4sAWx2Fb(object P_0)
	{
		return ((UserValidationContext)P_0).Error;
	}

	internal static object aBmcvD6KrnmYH4hU1Ax(object P_0)
	{
		return ((UserValidationContext)P_0).User;
	}

	internal static void rSluRJ6t4GMhcsEMSc6(object P_0, long userId, object P_2)
	{
		((UserManager)P_0).PasswordReset(userId, (string)P_2);
	}
}
