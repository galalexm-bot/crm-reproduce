using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Exceptions;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.ChangeProcessVersion;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowInstanceMigrationItemManager : EntityManager<IWorkflowInstanceMigrationItem, long>
{
	internal static WorkflowInstanceMigrationItemManager EVOtyJQm2iL1ROX9HWP;

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
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public new static WorkflowInstanceMigrationItemManager Instance => Locator.GetServiceNotNull<WorkflowInstanceMigrationItemManager>();

	[Transaction]
	public virtual void ChangeStatus(IWorkflowInstanceMigrationItem item, WorkflowInstanceMigrationItemStatus status, string comment = null)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_0080
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					item.Save();
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c == 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					return;
				default:
					if (string.IsNullOrEmpty(comment))
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 2:
					return;
				case 1:
					if (item == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					item.Comment = comment;
					num2 = 6;
					break;
				case 5:
				case 6:
					item.Status = status;
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f679e84d83df40c6973457c358e7e4e4 == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	[Transaction]
	public virtual void Start(IWorkflowInstanceMigrationItem item)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				item.StartDate = JbQjRwQGlq5MHxTHwPe();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				cWmJ47QnRJLXq9unHGC(item);
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_37eee1d96f2f408eb3b01bde6c7d25e0 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				ChangeStatus(item, WorkflowInstanceMigrationItemStatus.Processed);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual bool TryChangeWorkflowInstanceVersion(IWorkflowInstanceMigrationItem item, IWorkflowInstance instance, IWorkflowProcess newProcess, ChangeProcessVersionActionData actionData)
	{
		//Discarded unreachable code: IL_00f9, IL_0108, IL_0113, IL_01cf, IL_01e2, IL_01f1, IL_023b, IL_024a, IL_0294, IL_031d, IL_032c
		switch (1)
		{
		case 1:
		{
			bool result = default(bool);
			try
			{
				int num;
				if (WorkflowInstanceChangingVersionHelper.DeleteStatuses.Contains(xIM9xmQyGYUdrUJDoXp(instance)))
				{
					num = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_94abcc9c95ac4ce4baec9537ccf1485a == 0)
					{
						num = 3;
					}
					goto IL_005d;
				}
				goto IL_00aa;
				IL_00aa:
				Dictionary<IWorkflowInstance, IWorkflowProcess> instanceUpdateVersionInfo = WorkflowInstanceManager.GetInstanceUpdateVersionInfo(instance, newProcess);
				actionData.Actions.Add(new ChangeProcessVersionUpdateInstanceStateAction(instance, newProcess));
				instanceUpdateVersionInfo.Remove(instance);
				Dictionary<IWorkflowInstance, IWorkflowProcess>.Enumerator enumerator = instanceUpdateVersionInfo.GetEnumerator();
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 == 0)
				{
					num = 5;
				}
				goto IL_005d;
				IL_005d:
				KeyValuePair<IWorkflowInstance, IWorkflowProcess> current = default(KeyValuePair<IWorkflowInstance, IWorkflowProcess>);
				while (true)
				{
					switch (num)
					{
					case 2:
						return result;
					case 7:
						ChangeStatus(item, WorkflowInstanceMigrationItemStatus.NewVersion);
						num = 4;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_25eedcea124a48258fd18106b7da9d93 == 0)
						{
							num = 4;
						}
						continue;
					case 1:
						break;
					case 5:
						try
						{
							while (true)
							{
								IL_0131:
								int num3;
								if (!enumerator.MoveNext())
								{
									num3 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
									{
										num3 = 0;
									}
									goto IL_0117;
								}
								goto IL_0180;
								IL_0180:
								current = enumerator.Current;
								num3 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1fcd5b77d5534d528c98a4d02b302a40 == 0)
								{
									num3 = 3;
								}
								goto IL_0117;
								IL_0117:
								while (true)
								{
									switch (num3)
									{
									case 2:
										goto IL_0131;
									case 3:
										actionData.Actions.Add(new ChangeProcessVersionUpdateInstanceStateAction(current.Key, current.Value));
										num3 = 2;
										continue;
									case 1:
										goto IL_0180;
									case 0:
										break;
									}
									break;
								}
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f2221527565f4c919b1fed8e8c54e4f7 == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						goto default;
					default:
						r6f7jIQOZbvWUx7YZKG(WorkflowInstanceManager, actionData);
						num = 7;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd == 0)
						{
							num = 3;
						}
						continue;
					case 6:
						ChangeStatus(item, WorkflowInstanceMigrationItemStatus.OtherError);
						num = 3;
						continue;
					case 3:
					{
						result = false;
						int num2 = 2;
						num = num2;
						continue;
					}
					case 4:
						goto end_IL_005d;
					}
					goto IL_00aa;
					continue;
					end_IL_005d:
					break;
				}
			}
			catch (TargetInvocationException ex)
			{
				int num5;
				if (JE40gjQ6HmYd43ZnoeG(ex) is WorkflowInstanceLockException)
				{
					num5 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 == 0)
					{
						num5 = 1;
					}
					goto IL_0298;
				}
				goto IL_02cf;
				IL_02cf:
				ChangeStatus(item, WorkflowInstanceMigrationItemStatus.OtherError);
				num5 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb != 0)
				{
					num5 = 1;
				}
				goto IL_0298;
				IL_0298:
				while (true)
				{
					switch (num5)
					{
					case 3:
						return result;
					case 2:
						result = false;
						num5 = 3;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 == 0)
						{
							num5 = 1;
						}
						continue;
					case 1:
						item.Status = WorkflowInstanceMigrationItemStatus.Work;
						num5 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c8901ad9999948b380523446821824e3 == 0)
						{
							num5 = 0;
						}
						continue;
					}
					break;
				}
				goto IL_02cf;
			}
			break;
		}
		}
		return true;
	}

	public WorkflowInstanceMigrationItemManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ti5TMmQRuMcai1pPI1c();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool zE8jSEQAhDdkUUso2b9()
	{
		return EVOtyJQm2iL1ROX9HWP == null;
	}

	internal static WorkflowInstanceMigrationItemManager lfKqOWQp7kXteBY9PH8()
	{
		return EVOtyJQm2iL1ROX9HWP;
	}

	internal static DateTime JbQjRwQGlq5MHxTHwPe()
	{
		return DateTime.Now;
	}

	internal static void cWmJ47QnRJLXq9unHGC(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static WorkflowInstanceStatus xIM9xmQyGYUdrUJDoXp(object P_0)
	{
		return ((IWorkflowInstance)P_0).Status;
	}

	internal static void r6f7jIQOZbvWUx7YZKG(object P_0, object P_1)
	{
		((WorkflowInstanceManager)P_0).ChangeProcessVersion((ChangeProcessVersionActionData)P_1);
	}

	internal static object JE40gjQ6HmYd43ZnoeG(object P_0)
	{
		return ((Exception)P_0).InnerException;
	}

	internal static void Ti5TMmQRuMcai1pPI1c()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
