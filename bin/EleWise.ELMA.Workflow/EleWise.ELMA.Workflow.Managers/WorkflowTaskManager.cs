using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class WorkflowTaskManager : TaskBaseManager<IWorkflowTask>
{
	private static WorkflowTaskManager FX3mLDjG9lxnbEtqFUi;

	public WorkflowInstanceManager WorkflowInstanceManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowInstanceManager_003Ek__BackingField;
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
					_003CWorkflowInstanceManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Transaction]
	[ActionMethod("e49a86f0-5c45-4db1-945a-6d0e20bde148")]
	public override IWorkflowTask StartWork(long taskId, bool alertCoexecuters = true, ICommentActionModel actionModel = null)
	{
		int num = 2;
		int num2 = num;
		IWorkflowTask task = default(IWorkflowTask);
		while (true)
		{
			switch (num2)
			{
			case 2:
				task = Load(taskId);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return base.StartWork(taskId, alertCoexecuters, actionModel);
			case 1:
				Assign(task);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void Assign(IWorkflowTask task)
	{
		//Discarded unreachable code: IL_009e, IL_00a8, IL_0145, IL_0158, IL_0167
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		List<IWorkflowTaskBase>.Enumerator enumerator = default(List<IWorkflowTaskBase>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 1:
				BDcIMKjaSMAyqhE05VY(SpoAJ9jIB6t5HpV8bW6(), (IWorkflowTaskBase)_003C_003Ec__DisplayClass5_.task);
				num2 = 5;
				break;
			case 5:
				return;
			case 4:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass5_.task = task;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
							{
								num3 = 0;
							}
							goto IL_00ac;
						}
						goto IL_00e8;
						IL_00e8:
						IWorkflowTaskBase current = enumerator.Current;
						K885GNjFyyvJqfL1pNl(current, TaskBaseStatus.WasClosed);
						jtxff4jiSUFVcUKIopJ(current);
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
						{
							num3 = 1;
						}
						goto IL_00ac;
						IL_00ac:
						switch (num3)
						{
						case 1:
							continue;
						case 2:
							goto IL_00e8;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			default:
				enumerator = Locator.GetServiceNotNull<WorkflowTaskBaseManager>().GetTasks((IWorkflowBookmark)CnIGtSjotxP4wEsRLn0((IWorkflowTaskBase)_003C_003Ec__DisplayClass5_.task)).Where(_003C_003Ec__DisplayClass5_._003CAssign_003Eb__0)
					.ToList()
					.GetEnumerator();
				num2 = 2;
				break;
			}
		}
	}

	public WorkflowTaskManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool TgtjyYj7wqIALI7vnWm()
	{
		return FX3mLDjG9lxnbEtqFUi == null;
	}

	internal static WorkflowTaskManager FV7YfTj2ay3tyxhXUt0()
	{
		return FX3mLDjG9lxnbEtqFUi;
	}

	internal static object CnIGtSjotxP4wEsRLn0(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static void K885GNjFyyvJqfL1pNl(object P_0, object P_1)
	{
		((ITaskBase)P_0).Status = (TaskBaseStatus)P_1;
	}

	internal static void jtxff4jiSUFVcUKIopJ(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object SpoAJ9jIB6t5HpV8bW6()
	{
		return WorkflowTaskBaseManager.Instance;
	}

	internal static void BDcIMKjaSMAyqhE05VY(object P_0, object P_1)
	{
		((WorkflowTaskBaseManager)P_0).SaveSwimlaneExecutor((IWorkflowTaskBase)P_1);
	}
}
