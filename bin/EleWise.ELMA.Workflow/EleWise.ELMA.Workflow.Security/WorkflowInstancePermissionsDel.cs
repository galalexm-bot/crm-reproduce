using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Security;

[Component]
public class WorkflowInstancePermissionsDelegate : IPermissionsDelegate
{
	private readonly WorkflowTaskBaseManager workflowTaskBaseManager;

	private readonly List<Guid> supportedPermissions;

	private static WorkflowInstancePermissionsDelegate XNx9hTy0ZI6Tb1d1lJR;

	public ISecurityService SecurityService
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
				case 1:
					_003CSecurityService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
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

	public WorkflowInstancePermissionsDelegate(WorkflowTaskBaseManager workflowTaskBaseManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				this.workflowTaskBaseManager = workflowTaskBaseManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
				{
					num = 0;
				}
				continue;
			}
			supportedPermissions = WorkflowPermissionProvider.GetPermissionUids().Union(new Guid[1] { at1vWeytlbAlKEVdUEW(CommonPermissions.View) }).ToList();
			num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
			{
				num = 1;
			}
		}
	}

	public bool CanCheckPermissions(Type type, Permission permission)
	{
		//Discarded unreachable code: IL_0078, IL_0087, IL_00ad, IL_00bc
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return supportedPermissions.Contains(at1vWeytlbAlKEVdUEW(permission));
			default:
				return false;
			case 1:
				if (!typeof(IWorkflowInstance).IsAssignableFrom(type))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 4:
				if (!lTutNEybPtEhO7rxnkA(permission, null))
				{
					num2 = 3;
					break;
				}
				goto case 1;
			}
		}
	}

	public bool HasPermission(EleWise.ELMA.Security.IUser user, Permission permission, object target, bool skipAdmin = false)
	{
		//Discarded unreachable code: IL_0084, IL_01ee
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		while (true)
		{
			switch (num2)
			{
			case 7:
				_003C_003Ec__DisplayClass8_.instance = target as IWorkflowInstance;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
				{
					num2 = 8;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass8_._003C_003E4__this = this;
				num2 = 7;
				break;
			default:
				_003C_003Ec__DisplayClass8_.user = user;
				num2 = 14;
				break;
			case 1:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
				{
					num2 = 0;
				}
				break;
			case 12:
				if (!zu6nFSy59qtPSJXJLqn(_003C_003Ec__DisplayClass8_.permission, null))
				{
					num2 = 3;
					break;
				}
				goto case 13;
			case 2:
				return ((IEnumerable<IWorkflowInstanceMember>)_003C_003Ec__DisplayClass8_.instance.Members).Any(_003C_003Ec__DisplayClass8_._003CHasPermission_003Eb__0);
			case 4:
				if (MLaEcPyBCvayM2Q2DqZ(SecurityService, _003C_003Ec__DisplayClass8_.user, WorkflowPermissionProvider.ProcessMonitor, ((IWorkflowProcess)O0aKKdyg3KjZHFhHkMa(_003C_003Ec__DisplayClass8_.instance)).Header, false))
				{
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 5;
			case 13:
				return false;
			case 3:
				if (supportedPermissions.Contains(at1vWeytlbAlKEVdUEW(_003C_003Ec__DisplayClass8_.permission)))
				{
					if (!(_003C_003Ec__DisplayClass8_.permission == CommonPermissions.View))
					{
						num2 = 11;
						break;
					}
					goto case 10;
				}
				num2 = 13;
				break;
			case 14:
				_003C_003Ec__DisplayClass8_.permission = permission;
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
				{
					num2 = 4;
				}
				break;
			case 10:
				if (!HasPermission(_003C_003Ec__DisplayClass8_.user, WorkflowPermissionProvider.MyProcessesPermission, _003C_003Ec__DisplayClass8_.instance))
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 9;
			case 8:
				if (_003C_003Ec__DisplayClass8_.instance != null)
				{
					num2 = 12;
					break;
				}
				goto case 13;
			case 5:
				return LkuNDCycYHi3VLHkMYb(SecurityService, _003C_003Ec__DisplayClass8_.user, WorkflowPermissionProvider.FullMonitorAccessPermission);
			case 9:
				return true;
			case 11:
				if (!zu6nFSy59qtPSJXJLqn(_003C_003Ec__DisplayClass8_.permission, WorkflowPermissionProvider.MyProcessesPermission))
				{
					return ((IEnumerable<IProcessHeaderAccess>)((IProcessHeader)riQ3YQyPuMqV0vDBml2(O0aKKdyg3KjZHFhHkMa(_003C_003Ec__DisplayClass8_.instance))).AccessSettings).Any(_003C_003Ec__DisplayClass8_._003CHasPermission_003Eb__1);
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	[ContextCache]
	protected virtual bool CheckRole(EleWise.ELMA.Security.IUser user, Permission permission, IWorkflowInstance instance, Guid roleUid)
	{
		//Discarded unreachable code: IL_01f4, IL_0203, IL_0213, IL_0222, IL_0308, IL_0328, IL_0380, IL_038f, IL_03c3, IL_03d2, IL_0439, IL_0448, IL_0458, IL_0467
		int num = 27;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		IProcessHeader permissionSubject = default(IProcessHeader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					if (!qdi0ZkydUbhgvQnWTP0(roleUid, CommonRoleTypes.User.Id))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 18;
				case 19:
					if (_003C_003Ec__DisplayClass9_.user == JsabkZynbFIhq7JhuDk(instance))
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
						{
							num2 = 15;
						}
						break;
					}
					goto case 2;
				case 23:
					return true;
				case 16:
				case 25:
					if (!qdi0ZkydUbhgvQnWTP0(roleUid, LcOojFyX05BB6m6LktS(WorkflowRoleTypes.Initiator)))
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 19;
				case 22:
					if (roleUid == LcOojFyX05BB6m6LktS(CommonRoleTypes.OrganizationItem))
					{
						num2 = 18;
						break;
					}
					goto IL_03bc;
				case 6:
					return true;
				case 13:
					if (!qdi0ZkydUbhgvQnWTP0(roleUid, WorkflowRoleTypes.ProcessCurator.Id))
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 18;
				case 14:
					return true;
				case 4:
				case 17:
					if (!qdi0ZkydUbhgvQnWTP0(roleUid, LcOojFyX05BB6m6LktS(WorkflowRoleTypes.ResponsibleForInstance)))
					{
						num2 = 13;
						break;
					}
					goto default;
				default:
					if (_003C_003Ec__DisplayClass9_.user == zWH0tGyHqA7Kl1qWwNS(instance))
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 13;
				case 18:
					if (SecurityService.HasPermission(_003C_003Ec__DisplayClass9_.user, permission, permissionSubject))
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto IL_03bc;
				case 11:
					if (!((IEnumerable<IWorkflowInstanceMember>)instance.Members).Any(_003C_003Ec__DisplayClass9_._003CCheckRole_003Eb__0))
					{
						num2 = 4;
						break;
					}
					goto case 14;
				case 24:
					if (!qdi0ZkydUbhgvQnWTP0(roleUid, LcOojFyX05BB6m6LktS(WorkflowRoleTypes.CurrentExecutor)))
					{
						num2 = 21;
						break;
					}
					goto case 5;
				case 15:
					return true;
				case 2:
					if (!(roleUid == WorkflowRoleTypes.ProcessInstanceMember.Id))
					{
						num2 = 17;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
						{
							num2 = 17;
						}
						break;
					}
					goto case 11;
				case 8:
					return true;
				case 20:
				case 21:
					if (!qdi0ZkydUbhgvQnWTP0(roleUid, WorkflowRoleTypes.DirectorsOfCurrentExecutor.Id))
					{
						goto end_IL_0012;
					}
					goto case 10;
				case 5:
					if (!dJXhj6yugcsKW19PSvR(workflowTaskBaseManager, (EleWise.ELMA.Security.Models.IUser)_003C_003Ec__DisplayClass9_.user, instance))
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
						{
							num2 = 20;
						}
						break;
					}
					goto case 8;
				case 27:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 26;
					break;
				case 9:
					permissionSubject = (IProcessHeader)riQ3YQyPuMqV0vDBml2(instance.Process);
					num2 = 22;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
					{
						num2 = 24;
					}
					break;
				case 26:
					_003C_003Ec__DisplayClass9_.user = user;
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
					{
						num2 = 5;
					}
					break;
				case 1:
					if (!qdi0ZkydUbhgvQnWTP0(roleUid, LcOojFyX05BB6m6LktS(CommonRoleTypes.Group)))
					{
						num2 = 22;
						break;
					}
					goto case 18;
				case 3:
					return true;
				case 10:
					if (!TFpnL6yDgdZARKSmE29(workflowTaskBaseManager, (EleWise.ELMA.Security.Models.IUser)_003C_003Ec__DisplayClass9_.user, instance))
					{
						num2 = 25;
						break;
					}
					goto case 23;
				case 7:
					{
						if (!qdi0ZkydUbhgvQnWTP0(roleUid, WorkflowRoleTypes.ProcessOwner.Id))
						{
							num2 = 12;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
							{
								num2 = 12;
							}
							break;
						}
						goto case 18;
					}
					IL_03bc:
					return false;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 16;
		}
	}

	internal static bool q0irt3yydw9LWQLdC9D()
	{
		return XNx9hTy0ZI6Tb1d1lJR == null;
	}

	internal static WorkflowInstancePermissionsDelegate VuHhLOym3mMQA18ElBE()
	{
		return XNx9hTy0ZI6Tb1d1lJR;
	}

	internal static Guid at1vWeytlbAlKEVdUEW(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static bool lTutNEybPtEhO7rxnkA(object P_0, object P_1)
	{
		return (Permission)P_0 != (Permission)P_1;
	}

	internal static bool zu6nFSy59qtPSJXJLqn(object P_0, object P_1)
	{
		return (Permission)P_0 == (Permission)P_1;
	}

	internal static object O0aKKdyg3KjZHFhHkMa(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static bool MLaEcPyBCvayM2Q2DqZ(object P_0, object P_1, object P_2, object P_3, bool P_4)
	{
		return ((ISecurityService)P_0).HasPermission((EleWise.ELMA.Security.IUser)P_1, (Permission)P_2, P_3, P_4);
	}

	internal static bool LkuNDCycYHi3VLHkMYb(object P_0, object P_1, object P_2)
	{
		return ((ISecurityService)P_0).HasPermission((EleWise.ELMA.Security.IUser)P_1, (Permission)P_2);
	}

	internal static object riQ3YQyPuMqV0vDBml2(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static Guid LcOojFyX05BB6m6LktS(object P_0)
	{
		return ((PermissionRoleType)P_0).Id;
	}

	internal static bool qdi0ZkydUbhgvQnWTP0(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool dJXhj6yugcsKW19PSvR(object P_0, object P_1, object P_2)
	{
		return ((WorkflowTaskBaseManager)P_0).HasUserActiveTasks((EleWise.ELMA.Security.Models.IUser)P_1, (IWorkflowInstance)P_2);
	}

	internal static bool TFpnL6yDgdZARKSmE29(object P_0, object P_1, object P_2)
	{
		return ((WorkflowTaskBaseManager)P_0).HasSubordinateUsersActiveTasks((EleWise.ELMA.Security.Models.IUser)P_1, (IWorkflowInstance)P_2);
	}

	internal static object JsabkZynbFIhq7JhuDk(object P_0)
	{
		return ((IWorkflowInstance)P_0).Initiator;
	}

	internal static object zWH0tGyHqA7Kl1qWwNS(object P_0)
	{
		return ((IWorkflowInstance)P_0).Responsible;
	}
}
