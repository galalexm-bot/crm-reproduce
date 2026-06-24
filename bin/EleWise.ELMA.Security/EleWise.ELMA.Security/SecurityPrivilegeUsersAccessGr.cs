using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security;

[Component]
public class SecurityPrivilegeUsersAccessGroup : IPrivilegeModuleAccessGroup
{
	internal static SecurityPrivilegeUsersAccessGroup gLjJCNlr6nl1G42Aile;

	public Guid ModuleUid => __ModuleInfo.UID;

	public Guid UserGroupUid => SecurityConstants.PrivilegeUsersGroupUid;

	public SecurityPrivilegeUsersAccessGroup()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool fBL495l3KkWDKsHpG7K()
	{
		return gLjJCNlr6nl1G42Aile == null;
	}

	internal static SecurityPrivilegeUsersAccessGroup M2WWZElyvSudxHmKLmX()
	{
		return gLjJCNlr6nl1G42Aile;
	}
}
