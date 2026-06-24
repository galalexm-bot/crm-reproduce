using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing.Impl;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security;

internal class InternalSecurityService : ComplexLicensedUnit<IInternalSecurityService>, IInternalSecurityService, ILicensedUnit, IWorkplaceLicenseInfoOwner, IConcurrentLicenseInfoOwner
{
	internal static InternalSecurityService toqAguXJa675SvFilSc;

	uint IWorkplaceLicenseInfoOwner.UsedLicenseCount => ActiveUnit.UsedLicenseCount;

	uint IConcurrentLicenseInfoOwner.UsedPrivilegeCount => ActiveUnit.UsedPrivilegeCount;

	public InternalSecurityService()
	{
		//Discarded unreachable code: IL_0039, IL_003e
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector((IInternalSecurityService)new InternalSecurityServiceExpress(), (IInternalSecurityService)new InternalSecurityServiceStandart(), (IInternalSecurityService)new InternalSecurityServiceOracle());
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	void IInternalSecurityService.CheckUserToAuthenticate([NotNull] EleWise.ELMA.Security.Models.IUser user, Func<bool> isAlreadyLoggedFunc, Func<int, bool> isCurrentPrivilegeFunc, Func<int> otherUsersCountFunc)
	{
		ActiveUnit.CheckUserToAuthenticate(user, isAlreadyLoggedFunc, isCurrentPrivilegeFunc, otherUsersCountFunc);
	}

	bool IInternalSecurityService.CanCreateNewUser()
	{
		return lRYVe6XhdJyVjBUU2da(ActiveUnit);
	}

	internal static bool vsBXGUXKkKxRvNGAIuq()
	{
		return toqAguXJa675SvFilSc == null;
	}

	internal static InternalSecurityService CYP6cxXtYnxI3BecoI6()
	{
		return toqAguXJa675SvFilSc;
	}

	internal static bool lRYVe6XhdJyVjBUU2da(object P_0)
	{
		return ((IInternalSecurityService)P_0).CanCreateNewUser();
	}
}
