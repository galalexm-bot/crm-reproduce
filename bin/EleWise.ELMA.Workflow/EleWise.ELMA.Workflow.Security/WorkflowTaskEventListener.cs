using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Workflow.Security;

[Component]
public class WorkflowTaskEventListener : PostFlushEventListener
{
	private readonly WorkflowInstanceManager workflowInstanceManager;

	internal static WorkflowTaskEventListener o9tPXayVl5t51JGqwBl;

	public WorkflowTaskEventListener(WorkflowInstanceManager workflowInstanceManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		eeB0sny78I98sUhV69T();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.workflowInstanceManager = workflowInstanceManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		//Discarded unreachable code: IL_0064, IL_0094
		int num = 1;
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (((IWorkflowBookmark)FKnUhCy2pmsTe0WbxNM(workflowTaskBase)).Instance == null)
					{
						return;
					}
					goto end_IL_0012;
				case 8:
					return;
				case 6:
					return;
				case 7:
					if (HasCurrentExecutorPermission((IWorkflowInstance)qpGxV2yoQ8jBlj5r1BC(FKnUhCy2pmsTe0WbxNM(workflowTaskBase))))
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 2:
					CreateMember(workflowTaskBase);
					num2 = 3;
					continue;
				case 1:
					workflowTaskBase = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IWorkflowTaskBase;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (workflowTaskBase.WorkflowBookmark == null)
					{
						num2 = 8;
						continue;
					}
					goto case 4;
				case 3:
					return;
				}
				if (workflowTaskBase != null)
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
					{
						num2 = 5;
					}
					continue;
				}
				return;
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		//Discarded unreachable code: IL_0091, IL_00d8, IL_00e7, IL_01bf, IL_01ce, IL_0251, IL_02eb, IL_02fa, IL_030a
		int num = 18;
		IWorkflowInstanceMember workflowInstanceMember = default(IWorkflowInstanceMember);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		IWorkflowInstance instance = default(IWorkflowInstance);
		ISet<IWorkflowInstanceMember> members = default(ISet<IWorkflowInstanceMember>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 9:
					return;
				case 19:
					workflowInstanceMember.Delete();
					num2 = 4;
					continue;
				case 4:
					CreateMember(_003C_003Ec__DisplayClass3_.task);
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 9;
					}
					continue;
				case 12:
					return;
				case 1:
					if (!HasCurrentExecutorPermission(instance))
					{
						num2 = 16;
						continue;
					}
					goto case 26;
				case 11:
					return;
				case 6:
					if (InTsgiyIobQTtWksjFg(workflowInstanceMember) != NJi9ORya2EBAEjKkug3(_003C_003Ec__DisplayClass3_.task))
					{
						num2 = 7;
						continue;
					}
					return;
				case 16:
					return;
				case 21:
					return;
				case 27:
					if (FKnUhCy2pmsTe0WbxNM(_003C_003Ec__DisplayClass3_.task) == null)
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 20;
				case 24:
					((ICollection<IWorkflowInstanceMember>)members).Remove(workflowInstanceMember);
					num = 13;
					break;
				case 7:
					((ICollection<IWorkflowInstanceMember>)members).Remove(workflowInstanceMember);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
					{
						num2 = 19;
					}
					continue;
				case 2:
					if (_003C_003Ec__DisplayClass3_.task == null)
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 8;
				case 18:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 17;
					continue;
				case 23:
					if (eyIj4hyiSjMwPCHACaA(_003C_003Ec__DisplayClass3_.task))
					{
						num = 3;
						break;
					}
					goto case 24;
				case 22:
					if (workflowInstanceMember != null)
					{
						num2 = 23;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					if (!eyIj4hyiSjMwPCHACaA(_003C_003Ec__DisplayClass3_.task))
					{
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 0:
					return;
				case 5:
					return;
				case 15:
					instance = _003C_003Ec__DisplayClass3_.task.WorkflowBookmark.Instance;
					num = 25;
					break;
				case 20:
					if (qpGxV2yoQ8jBlj5r1BC(FKnUhCy2pmsTe0WbxNM(_003C_003Ec__DisplayClass3_.task)) == null)
					{
						return;
					}
					num = 15;
					break;
				case 3:
					if (HasCurrentExecutorPermission(instance))
					{
						num = 6;
						break;
					}
					goto case 24;
				case 13:
					workflowInstanceMember.Delete();
					num2 = 11;
					continue;
				case 26:
					CreateMember(_003C_003Ec__DisplayClass3_.task);
					num = 21;
					break;
				case 17:
					_003C_003Ec__DisplayClass3_.task = gjmwAXyFPRqGAH07b1p(@event) as IWorkflowTaskBase;
					num2 = 2;
					continue;
				case 8:
					if (_003C_003Ec__DisplayClass3_.task.IsNew())
					{
						return;
					}
					num2 = 27;
					continue;
				case 14:
					workflowInstanceMember = ((IEnumerable<IWorkflowInstanceMember>)members).FirstOrDefault(_003C_003Ec__DisplayClass3_._003COnPostUpdate_003Eb__0);
					num2 = 22;
					continue;
				case 10:
					return;
				case 25:
					members = instance.Members;
					num2 = 14;
					continue;
				}
				break;
			}
		}
	}

	private void CreateMember(IWorkflowTaskBase task)
	{
		int num = 1;
		int num2 = num;
		IWorkflowInstanceMember @new = default(IWorkflowInstanceMember);
		while (true)
		{
			switch (num2)
			{
			default:
				zhjDTsyx4VJXseyVRkU(workflowInstanceManager, ((IWorkflowBookmark)FKnUhCy2pmsTe0WbxNM(task)).Instance, @new);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 1:
			{
				InstanceOf<IWorkflowInstanceMember> instanceOf = new InstanceOf<IWorkflowInstanceMember>();
				WEKGWxyrhiDYKaBxDNB(instanceOf.New, qpGxV2yoQ8jBlj5r1BC(task.WorkflowBookmark));
				instanceOf.New.Task = task;
				instanceOf.New.PermissionRole = xVxUOEye9ZNHK1kYPCe(WorkflowRoleTypes.CurrentExecutor);
				EQJXbMyNY7oHxmGeIYf(instanceOf.New, task.Executor);
				@new = instanceOf.New;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private bool HasCurrentExecutorPermission(IWorkflowInstance instance)
	{
		return ((IEnumerable<IProcessHeaderAccess>)((IWorkflowProcess)CIy8hDySEkOEiLgG0fn(instance)).Header.AccessSettings).Where((IProcessHeaderAccess s) => s.PermissionId == _003C_003Ec.o9JgQ8ZWCv3TvYHDo5Iu(WorkflowPermissionProvider.MyProcessesPermission)).Any(delegate(IProcessHeaderAccess p)
		{
			//Discarded unreachable code: IL_0035
			int num = 1;
			int num2 = num;
			Guid? permissionRole = default(Guid?);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return permissionRole.Value == WorkflowRoleTypes.CurrentExecutor.UID;
				case 4:
					return false;
				case 3:
					permissionRole = p.PermissionRole;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
					{
						num2 = 2;
					}
					break;
				default:
					if (!permissionRole.HasValue)
					{
						num2 = 4;
						break;
					}
					goto case 3;
				case 1:
					permissionRole = p.PermissionRole;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	internal static void eeB0sny78I98sUhV69T()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool Bst4xAyAO5wK27I5G2M()
	{
		return o9tPXayVl5t51JGqwBl == null;
	}

	internal static WorkflowTaskEventListener AqvXGZyGBCoiEkPuWbZ()
	{
		return o9tPXayVl5t51JGqwBl;
	}

	internal static object FKnUhCy2pmsTe0WbxNM(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object qpGxV2yoQ8jBlj5r1BC(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object gjmwAXyFPRqGAH07b1p(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static bool eyIj4hyiSjMwPCHACaA(object P_0)
	{
		return ((ITaskBase)P_0).IsActive();
	}

	internal static object InTsgiyIobQTtWksjFg(object P_0)
	{
		return ((IWorkflowInstanceMember)P_0).User;
	}

	internal static object NJi9ORya2EBAEjKkug3(object P_0)
	{
		return ((ITaskBase)P_0).Executor;
	}

	internal static void WEKGWxyrhiDYKaBxDNB(object P_0, object P_1)
	{
		((IWorkflowInstanceMember)P_0).Instance = (IWorkflowInstance)P_1;
	}

	internal static Guid xVxUOEye9ZNHK1kYPCe(object P_0)
	{
		return ((PermissionRoleType)P_0).UID;
	}

	internal static void EQJXbMyNY7oHxmGeIYf(object P_0, object P_1)
	{
		((IWorkflowInstanceMember)P_0).User = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void zhjDTsyx4VJXseyVRkU(object P_0, object P_1, object P_2)
	{
		((WorkflowInstanceManager)P_0).AddMember((IWorkflowInstance)P_1, (IWorkflowInstanceMember)P_2);
	}

	internal static object CIy8hDySEkOEiLgG0fn(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}
}
