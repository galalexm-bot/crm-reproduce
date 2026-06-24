using System;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Actions;

public class ActionPermissionAttribute : Attribute
{
	private readonly Guid permissionId;

	private Permission permission;

	internal static ActionPermissionAttribute xBcPYOfwkOt370txWLXK;

	public Guid PermissionId => permissionId;

	public Permission Permission => permission;

	public ActionPermissionAttribute(Guid permissionId)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.permissionId = permissionId;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
			{
				num = 1;
			}
		}
	}

	public ActionPermissionAttribute(string permissionId)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vnkYDofw2gmx5RZmGORT();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.permissionId = emWr3jfwepUUlAtdrByw(permissionId);
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
			{
				num = 0;
			}
		}
	}

	public bool CheckPermissionCurrentUser()
	{
		int num = 1;
		int num2 = num;
		IPermissionManagmentService serviceNotNull2 = default(IPermissionManagmentService);
		while (true)
		{
			switch (num2)
			{
			case 1:
				serviceNotNull2 = Locator.GetServiceNotNull<IPermissionManagmentService>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
				permission = serviceNotNull2.GetPermission(permissionId);
				if (permission == null)
				{
					throw new InvalidOperationException(string.Concat(klKtodfw15P1gHIZffWC(o9MeYvfwPlqr67p8egSe(-1822890472 ^ -1822574494)), permissionId));
				}
				return FqVWsffwN0Orp4SIHNk9(serviceNotNull, permission);
			}
			}
		}
	}

	internal static bool tFVawBfwnIQKcHkM5vD1()
	{
		return xBcPYOfwkOt370txWLXK == null;
	}

	internal static ActionPermissionAttribute RKK9BsfwOGta6sydO1sw()
	{
		return xBcPYOfwkOt370txWLXK;
	}

	internal static void vnkYDofw2gmx5RZmGORT()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Guid emWr3jfwepUUlAtdrByw(object P_0)
	{
		return Guid.Parse((string)P_0);
	}

	internal static object o9MeYvfwPlqr67p8egSe(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object klKtodfw15P1gHIZffWC(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool FqVWsffwN0Orp4SIHNk9(object P_0, object P_1)
	{
		return ((ISecurityService)P_0).HasPermission((Permission)P_1);
	}
}
