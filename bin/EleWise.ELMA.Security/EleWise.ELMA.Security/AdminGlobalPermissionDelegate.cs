using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security;

[Component]
internal class AdminGlobalPermissionDelegate : IGlobalPermissionsDelegate
{
	private static AdminGlobalPermissionDelegate GTiiib5Pmkqin5IdRI1;

	public ISecurityService SecurityService => Locator.GetService<ISecurityService>();

	public bool HasPermission(IUser user, Permission permission, IEnumerable<Guid> userPermissionUids)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.user = user;
		if (permission == null || permission.AdminPermissions == null || permission.AdminPermissions.Length == 0)
		{
			return false;
		}
		return permission.AdminPermissions.Any((Permission p) => _003C_003Ec__DisplayClass2_0.jRjVRHpWDasgwDt8Zoti(CS_0024_003C_003E8__locals0._003C_003E4__this.SecurityService, CS_0024_003C_003E8__locals0.user, p));
	}

	public AdminGlobalPermissionDelegate()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Cmm40A5UNQy4PfWkEgR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void Cmm40A5UNQy4PfWkEgR()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool wWly0R5vbgmRKVXDBDq()
	{
		return GTiiib5Pmkqin5IdRI1 == null;
	}

	internal static AdminGlobalPermissionDelegate k0vYCf5CJeYU2Dm7lL3()
	{
		return GTiiib5Pmkqin5IdRI1;
	}
}
