using System;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Events;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Listeners;

[Component]
internal class SecurityCacheSetIdPermissionEventHandler : ISecurityCacheSetIdEventHandler, IEventHandler
{
	private static SecurityCacheSetIdPermissionEventHandler bwqw2OHS1e3ygl4LpJ8;

	public SecurityService SecurityService
	{
		[CompilerGenerated]
		get
		{
			return _003CSecurityService_003Ek__BackingField;
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
					_003CSecurityService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public void PostCacheSet(SecurityCacheSetIdEventArgs args)
	{
		//Discarded unreachable code: IL_003d, IL_00bc
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 4:
				if (!args.FullUpdate)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				SecurityService.ResetPermissionsCache();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (SecurityService == null)
				{
					return;
				}
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				return;
			case 1:
				return;
			default:
				(from d in args.GroupAddUsers.Concat(args.GroupRemoveUsers).Concat(args.OrganizationItemAddUsers).Concat(args.OrganizationItemRemoveUsers)
					select d.Item2).ForEach(SecurityService.ResetPermissions4UserCache);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 != 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	public SecurityCacheSetIdPermissionEventHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LWBGHOH11GgevCePMS1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool JJAek4H9nrAsuty2KbG()
	{
		return bwqw2OHS1e3ygl4LpJ8 == null;
	}

	internal static SecurityCacheSetIdPermissionEventHandler B1U6HrHflPCyqbZSyT7()
	{
		return bwqw2OHS1e3ygl4LpJ8;
	}

	internal static void LWBGHOH11GgevCePMS1()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
