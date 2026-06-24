using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Workflow.Security;

[Component]
public class WorkflowInstanceEventListener : PostFlushEventListener
{
	internal static WorkflowInstanceEventListener LPriYm0IYGGT2kOe7TV;

	public override void OnPostInsert(PostInsertEvent @event)
	{
		//Discarded unreachable code: IL_003e, IL_0048, IL_0121, IL_0146, IL_0155, IL_0192, IL_01a1, IL_024a, IL_0259, IL_02db, IL_0390, IL_03c8, IL_03d7, IL_03f8, IL_0407
		int num = 2;
		int num2 = num;
		IEnumerator<IProcessHeaderAccess> enumerator = default(IEnumerator<IProcessHeaderAccess>);
		IProcessHeaderAccess current = default(IProcessHeaderAccess);
		Guid? permissionRole = default(Guid?);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			case 6:
				try
				{
					while (true)
					{
						IL_00f6:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 18;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
							{
								num3 = 21;
							}
							goto IL_004c;
						}
						goto IL_00d3;
						IL_00d3:
						current = enumerator.Current;
						num3 = 20;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
						{
							num3 = 17;
						}
						goto IL_004c;
						IL_004c:
						while (true)
						{
							switch (num3)
							{
							case 4:
								if (!H3eylL0wNcpYJery3uN(permissionRole.Value, r5TE0H0EtSn2pGBwvhk(WorkflowRoleTypes.Initiator)))
								{
									num3 = 3;
									continue;
								}
								goto case 5;
							case 16:
								break;
							case 2:
							case 3:
							case 7:
							case 11:
								goto IL_00f6;
							case 17:
								if (!permissionRole.HasValue)
								{
									num3 = 8;
									continue;
								}
								goto case 6;
							case 15:
								WorkflowInstanceManager.Instance.AddMember(workflowInstance, (IUserGroup)JDl9AD01KLDnKFsI1bS(current));
								num3 = 9;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
								{
									num3 = 7;
								}
								continue;
							case 20:
								permissionRole = current.PermissionRole;
								num3 = 17;
								continue;
							default:
								permissionRole = current.PermissionRole;
								num3 = 4;
								continue;
							case 6:
								permissionRole = current.PermissionRole;
								num3 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
								{
									num3 = 10;
								}
								continue;
							case 19:
								CreateMember(workflowInstance, (EleWise.ELMA.Security.Models.IUser)CrJfo704kOqeSCyHdMX(workflowInstance), WorkflowRoleTypes.ResponsibleForInstance.UID);
								num3 = 12;
								continue;
							case 18:
								WorkflowInstanceManager.Instance.AddMember(workflowInstance, current.OrganizationItemPosition);
								num3 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
								{
									num3 = 0;
								}
								continue;
							case 9:
							case 14:
								if (rVcQw00hb2m3cKnfOQr(current) == null)
								{
									num3 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
									{
										num3 = 4;
									}
									continue;
								}
								goto case 18;
							case 8:
								if (DA6yCg0xEAilaNsZXDL(current) != null)
								{
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
									{
										num3 = 13;
									}
									continue;
								}
								goto case 1;
							case 1:
								if (JDl9AD01KLDnKFsI1bS(current) == null)
								{
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
									{
										num3 = 14;
									}
									continue;
								}
								goto case 15;
							case 13:
								((WorkflowInstanceManager)MaxPdl0Sn9E1mgQm9Li()).AddMember(workflowInstance, (EleWise.ELMA.Security.Models.IUser)DA6yCg0xEAilaNsZXDL(current));
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
								{
									num3 = 1;
								}
								continue;
							case 5:
								CreateMember(workflowInstance, (EleWise.ELMA.Security.Models.IUser)Org3bv0z6nZy28ywWPN(workflowInstance), r5TE0H0EtSn2pGBwvhk(WorkflowRoleTypes.Initiator));
								num3 = 11;
								continue;
							case 10:
								if (!H3eylL0wNcpYJery3uN(permissionRole.Value, r5TE0H0EtSn2pGBwvhk(WorkflowRoleTypes.ResponsibleForInstance)))
								{
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 19;
							case 21:
								return;
							}
							break;
						}
						goto IL_00d3;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								Wk1WNiyKjNkR5cksePD(enumerator);
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
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
				}
			case 1:
				if (workflowInstance != null)
				{
					num2 = 5;
					break;
				}
				return;
			case 2:
				workflowInstance = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IWorkflowInstance;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			case 3:
				return;
			case 5:
				Locator.GetServiceNotNull<IPermissionManagmentService>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 0;
				}
				break;
			default:
				enumerator = ((IEnumerable<IProcessHeaderAccess>)((IProcessHeader)DFr35y0N0Q7V0tXcAKQ(ttvjlw0e2h6q56U6Nlb(workflowInstance))).AccessSettings).Where((IProcessHeaderAccess s) => _003C_003Ec.XaqTxeZWBoULeQ0Kpee9(_003C_003Ec.NlZCXRZWg9siN6fnlKBK(s), WorkflowPermissionProvider.MyProcessesPermission.Id)).GetEnumerator();
				num2 = 6;
				break;
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00f3
		int num = 5;
		IWorkflowInstanceMember workflowInstanceMember2 = default(IWorkflowInstanceMember);
		IWorkflowInstanceMember workflowInstanceMember = default(IWorkflowInstanceMember);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		IWorkflowInstanceMember @new = default(IWorkflowInstanceMember);
		IWorkflowInstanceMember new2 = default(IWorkflowInstanceMember);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					T3u7wMysako2L3coqRv(workflowInstanceMember2);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					if (((IEntity<long>)KFDk3lyOUPSkbMmgoUf(workflowInstanceMember)).Id != ((IEntity<long>)CrJfo704kOqeSCyHdMX(workflowInstance)).Id)
					{
						num2 = 11;
						continue;
					}
					goto case 14;
				case 1:
					BZCKUoy8mynVarPiCyp(@new);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					((ICollection<IWorkflowInstanceMember>)workflowInstance.Members).Remove(workflowInstanceMember2);
					num2 = 6;
					continue;
				default:
					workflowInstance.Members.Add(@new);
					num2 = 12;
					continue;
				case 15:
					if (workflowInstanceMember2 != null)
					{
						num2 = 18;
						continue;
					}
					return;
				case 4:
					if (workflowInstance != null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
						{
							num2 = 19;
						}
						continue;
					}
					return;
				case 17:
					((ICollection<IWorkflowInstanceMember>)workflowInstance.Members).Remove(workflowInstanceMember);
					num2 = 9;
					continue;
				case 9:
					workflowInstanceMember.Delete();
					num2 = 13;
					continue;
				case 12:
					return;
				case 5:
					workflowInstance = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IWorkflowInstance;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
					{
						num2 = 2;
					}
					continue;
				case 18:
					if (((IEntity<long>)KFDk3lyOUPSkbMmgoUf(workflowInstanceMember2)).Id == ((IEntity<long>)Org3bv0z6nZy28ywWPN(workflowInstance)).Id)
					{
						return;
					}
					num2 = 8;
					continue;
				case 7:
					workflowInstance.Members.Add(new2);
					num2 = 14;
					continue;
				case 13:
					BZCKUoy8mynVarPiCyp(new2);
					num = 7;
					break;
				case 11:
				{
					InstanceOf<IWorkflowInstanceMember> instanceOf2 = new InstanceOf<IWorkflowInstanceMember>();
					YQekBCyvMisRrXnsQrH(instanceOf2.New, a5U8VPyZTR9TiYBsSDH(workflowInstanceMember));
					instanceOf2.New.PermissionRole = workflowInstanceMember.PermissionRole;
					WFoHNkyYn095INPWy4K(instanceOf2.New, CrJfo704kOqeSCyHdMX(workflowInstance));
					new2 = instanceOf2.New;
					num = 17;
					break;
				}
				case 3:
					if (workflowInstanceMember != null)
					{
						num2 = 10;
						continue;
					}
					goto case 14;
				case 8:
				{
					InstanceOf<IWorkflowInstanceMember> instanceOf = new InstanceOf<IWorkflowInstanceMember>();
					YQekBCyvMisRrXnsQrH(instanceOf.New, workflowInstanceMember2.Instance);
					instanceOf.New.PermissionRole = workflowInstanceMember2.PermissionRole;
					WFoHNkyYn095INPWy4K(instanceOf.New, workflowInstance.Initiator);
					@new = instanceOf.New;
					num = 2;
					break;
				}
				case 16:
					return;
				case 19:
					workflowInstanceMember = ((IEnumerable<IWorkflowInstanceMember>)workflowInstance.Members).FirstOrDefault(delegate(IWorkflowInstanceMember m)
					{
						//Discarded unreachable code: IL_008f, IL_009e
						int num5 = 1;
						int num6 = num5;
						Guid? permissionRole2 = default(Guid?);
						while (true)
						{
							switch (num6)
							{
							default:
								if (!permissionRole2.HasValue)
								{
									num6 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
									{
										num6 = 4;
									}
									break;
								}
								goto case 2;
							case 1:
								permissionRole2 = m.PermissionRole;
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
								{
									num6 = 0;
								}
								break;
							case 2:
								permissionRole2 = m.PermissionRole;
								num6 = 3;
								break;
							case 3:
								return permissionRole2.Value == WorkflowRoleTypes.ResponsibleForInstance.UID;
							case 4:
								return false;
							}
						}
					});
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
					{
						num2 = 3;
					}
					continue;
				case 14:
					workflowInstanceMember2 = ((IEnumerable<IWorkflowInstanceMember>)workflowInstance.Members).FirstOrDefault(delegate(IWorkflowInstanceMember m)
					{
						//Discarded unreachable code: IL_004e
						int num3 = 2;
						int num4 = num3;
						Guid? permissionRole = default(Guid?);
						while (true)
						{
							switch (num4)
							{
							default:
								return _003C_003Ec.XaqTxeZWBoULeQ0Kpee9(permissionRole.Value, _003C_003Ec.iDy6rPZWcXWGXDwi6tMQ(WorkflowRoleTypes.Initiator));
							case 4:
								return false;
							case 2:
								permissionRole = m.PermissionRole;
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
								{
									num4 = 0;
								}
								break;
							case 3:
								permissionRole = m.PermissionRole;
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
								{
									num4 = 0;
								}
								break;
							case 1:
								if (!permissionRole.HasValue)
								{
									num4 = 4;
									break;
								}
								goto case 3;
							}
						}
					});
					num = 15;
					break;
				}
				break;
			}
		}
	}

	private void CreateMember(IWorkflowInstance instance, EleWise.ELMA.Security.Models.IUser user, Guid permissionRole)
	{
		int num = 1;
		int num2 = num;
		IWorkflowInstanceMember @new = default(IWorkflowInstanceMember);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				InstanceOf<IWorkflowInstanceMember> instanceOf = new InstanceOf<IWorkflowInstanceMember>();
				YQekBCyvMisRrXnsQrH(instanceOf.New, instance);
				instanceOf.New.PermissionRole = permissionRole;
				WFoHNkyYn095INPWy4K(instanceOf.New, user);
				@new = instanceOf.New;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
				XNI0WLyJmZbV2m9XIun(MaxPdl0Sn9E1mgQm9Li(), instance, @new);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public WorkflowInstanceEventListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OF5F7XylfAHdFwIKrE3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object ttvjlw0e2h6q56U6Nlb(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object DFr35y0N0Q7V0tXcAKQ(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object DA6yCg0xEAilaNsZXDL(object P_0)
	{
		return ((IProcessHeaderAccess)P_0).User;
	}

	internal static object MaxPdl0Sn9E1mgQm9Li()
	{
		return WorkflowInstanceManager.Instance;
	}

	internal static object JDl9AD01KLDnKFsI1bS(object P_0)
	{
		return ((IProcessHeaderAccess)P_0).Group;
	}

	internal static object rVcQw00hb2m3cKnfOQr(object P_0)
	{
		return ((IProcessHeaderAccess)P_0).OrganizationItemPosition;
	}

	internal static Guid r5TE0H0EtSn2pGBwvhk(object P_0)
	{
		return ((PermissionRoleType)P_0).UID;
	}

	internal static bool H3eylL0wNcpYJery3uN(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object CrJfo704kOqeSCyHdMX(object P_0)
	{
		return ((IWorkflowInstance)P_0).Responsible;
	}

	internal static object Org3bv0z6nZy28ywWPN(object P_0)
	{
		return ((IWorkflowInstance)P_0).Initiator;
	}

	internal static void Wk1WNiyKjNkR5cksePD(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool vFvkq30an2WEM4PDidT()
	{
		return LPriYm0IYGGT2kOe7TV == null;
	}

	internal static WorkflowInstanceEventListener VnefBJ0ro91TCYNwGC1()
	{
		return LPriYm0IYGGT2kOe7TV;
	}

	internal static object KFDk3lyOUPSkbMmgoUf(object P_0)
	{
		return ((IWorkflowInstanceMember)P_0).User;
	}

	internal static object a5U8VPyZTR9TiYBsSDH(object P_0)
	{
		return ((IWorkflowInstanceMember)P_0).Instance;
	}

	internal static void YQekBCyvMisRrXnsQrH(object P_0, object P_1)
	{
		((IWorkflowInstanceMember)P_0).Instance = (IWorkflowInstance)P_1;
	}

	internal static void WFoHNkyYn095INPWy4K(object P_0, object P_1)
	{
		((IWorkflowInstanceMember)P_0).User = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void BZCKUoy8mynVarPiCyp(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void T3u7wMysako2L3coqRv(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static void XNI0WLyJmZbV2m9XIun(object P_0, object P_1, object P_2)
	{
		((WorkflowInstanceManager)P_0).AddMember((IWorkflowInstance)P_1, (IWorkflowInstanceMember)P_2);
	}

	internal static void OF5F7XylfAHdFwIKrE3()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
