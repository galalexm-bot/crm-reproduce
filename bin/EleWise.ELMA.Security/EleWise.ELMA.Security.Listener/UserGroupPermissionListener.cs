using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Listeners;

[Component]
internal class UserGroupPermissionListener : EntityEventsListener
{
	private static UserGroupPermissionListener qiITHoRhB7ZIDbHowEV;

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
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public GroupPermissionManager GroupPermissionManager
	{
		[CompilerGenerated]
		get
		{
			return _003CGroupPermissionManager_003Ek__BackingField;
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
					_003CGroupPermissionManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
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

	public override bool OnPreDelete(PreDeleteEvent @event)
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_00c5, IL_02b7, IL_02c6
		int num = 14;
		IUserGroup userGroup = default(IUserGroup);
		GroupPermission groupPermission = default(GroupPermission);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					if (@event == null)
					{
						num2 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d != 0)
						{
							num2 = 13;
						}
						break;
					}
					userGroup = jLv0mYRcRNUqoalQPTd(@event) as IUserGroup;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
					{
						num2 = 1;
					}
					break;
				default:
					return j8YIyvRY38yPoSM8PCO(this, @event);
				case 7:
					if (groupPermission == null)
					{
						num2 = 9;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 10;
				case 12:
					groupPermission = jLv0mYRcRNUqoalQPTd(@event) as GroupPermission;
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
					{
						num2 = 7;
					}
					break;
				case 4:
					throw new InvalidOperationException((string)SN6ygZRF9QhsllD0o94(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4177C82C ^ 0x41779A94), new object[2]
					{
						N7p7u8RGPS54AiBuYMW(WHKNEeR0nd8SwcpVVXg(groupPermission)),
						PermissionProvider.AccessManagmentPermission.Name
					}));
				case 2:
				case 9:
					ResetPermissionsCacheIfNeeded(jLv0mYRcRNUqoalQPTd(@event));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 != 0)
					{
						num2 = 0;
					}
					break;
				case 11:
					throw new InvalidOperationException((string)SN6ygZRF9QhsllD0o94(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A799728 ^ 0x4A79C542), new object[1] { N7p7u8RGPS54AiBuYMW(userGroup) }));
				case 13:
					return false;
				case 10:
					if (!uiXmEVRDG6s9U2bQ0St(XUiytqREDEQ8oLSP86n(WHKNEeR0nd8SwcpVVXg(groupPermission)), SecurityConstants.AdminGroupUid))
					{
						num2 = 2;
						break;
					}
					goto case 3;
				case 1:
					if (userGroup != null)
					{
						goto end_IL_0012;
					}
					goto case 12;
				case 8:
					if (!userGroup.IsSystem)
					{
						GroupPermissionManager.RemovePermission(userGroup);
						num2 = 12;
					}
					else
					{
						num2 = 11;
					}
					break;
				case 5:
					throw new InvalidOperationException((string)SN6ygZRF9QhsllD0o94(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2CFDCC80 ^ 0x2CFD9E38), new object[2]
					{
						N7p7u8RGPS54AiBuYMW(WHKNEeR0nd8SwcpVVXg(groupPermission)),
						CommonPermissions.AdminPermission.Name
					}));
				case 6:
					if (uiXmEVRDG6s9U2bQ0St(groupPermission.PermissionId, WWITGXRsyLt1q3ObmP0(PermissionProvider.AccessManagmentPermission)))
					{
						num2 = 4;
						break;
					}
					goto case 2;
				case 3:
					if (!uiXmEVRDG6s9U2bQ0St(FyrngvRM3pEFej9RrfD(groupPermission), WWITGXRsyLt1q3ObmP0(CommonPermissions.AdminPermission)))
					{
						num2 = 6;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		//Discarded unreachable code: IL_006f, IL_007e
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return false;
				case 3:
					return false;
				case 1:
					if (@event != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				}
				break;
			}
			ResetPermissionsCacheIfNeeded(jLv0mYRcRNUqoalQPTd(@event));
			num = 3;
		}
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (@event == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
					{
						num2 = 0;
					}
					break;
				}
				ResetPermissionsCacheIfNeeded(jLv0mYRcRNUqoalQPTd(@event));
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				return false;
			case 2:
				return false;
			}
		}
	}

	private void ResetPermissionsCacheIfNeeded(object entity)
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
			case 2:
				F0tymmRIWyYxDYaHXd5(SecurityService);
				num2 = 3;
				break;
			case 1:
				if (SecurityService != null)
				{
					if (!(entity is GroupPermission))
					{
						return;
					}
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 3:
				return;
			}
		}
	}

	public UserGroupPermissionListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HnqWNjR4R2Bp0JDAOJB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool gbIb2XROJBuq7dfgbqv()
	{
		return qiITHoRhB7ZIDbHowEV == null;
	}

	internal static UserGroupPermissionListener tW3qp2RqPE7IBaO1kwt()
	{
		return qiITHoRhB7ZIDbHowEV;
	}

	internal static object jLv0mYRcRNUqoalQPTd(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object N7p7u8RGPS54AiBuYMW(object P_0)
	{
		return ((IUserGroup)P_0).Name;
	}

	internal static object SN6ygZRF9QhsllD0o94(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object WHKNEeR0nd8SwcpVVXg(object P_0)
	{
		return ((GroupPermission)P_0).Group;
	}

	internal static Guid XUiytqREDEQ8oLSP86n(object P_0)
	{
		return ((IUserGroup)P_0).Uid;
	}

	internal static bool uiXmEVRDG6s9U2bQ0St(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid FyrngvRM3pEFej9RrfD(object P_0)
	{
		return ((GroupPermission)P_0).PermissionId;
	}

	internal static Guid WWITGXRsyLt1q3ObmP0(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static bool j8YIyvRY38yPoSM8PCO(object P_0, object P_1)
	{
		return ((EntityEventsListener)P_0).OnPreDelete((PreDeleteEvent)P_1);
	}

	internal static void F0tymmRIWyYxDYaHXd5(object P_0)
	{
		((SecurityService)P_0).ResetPermissionsCache();
	}

	internal static void HnqWNjR4R2Bp0JDAOJB()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
