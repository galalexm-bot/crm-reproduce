using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Components;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
public class WorkflowInstanceMonitorListener : EntityEventsListener
{
	private static readonly string StatusPropertyName;

	internal static WorkflowInstanceMonitorListener a68K1iYodpSB0GgEruM;

	public IMonitorCacheUpdateService MonitorCacheUpdateService
	{
		[CompilerGenerated]
		get
		{
			return _003CMonitorCacheUpdateService_003Ek__BackingField;
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
					_003CMonitorCacheUpdateService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 != 0)
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

	public IUnitOfWorkManager UnitOfWorkManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUnitOfWorkManager_003Ek__BackingField;
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
					_003CUnitOfWorkManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
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

	public ProcessHeaderManager ProcessHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeaderManager_003Ek__BackingField;
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
					_003CProcessHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5581cf8fc5c14768be6f13345a9a04e1 != 0)
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

	private void RecalcMonitors()
	{
		//Discarded unreachable code: IL_00ab, IL_00b5, IL_0184, IL_0197, IL_01a6
		int num = 4;
		int num2 = num;
		List<IProcessHeader> value = default(List<IProcessHeader>);
		List<IProcessHeader>.Enumerator enumerator = default(List<IProcessHeader>.Enumerator);
		IProcessHeader current = default(IProcessHeader);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				value = value.Distinct().ToList();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 1:
				enumerator = value.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_aaa603dc29cf4b6d80fd77debf189b8d != 0)
				{
					num2 = 5;
				}
				break;
			case 0:
				return;
			case 5:
				try
				{
					while (true)
					{
						IL_0116:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bd008fca9c464e14859870d0f9208652 == 0)
							{
								num3 = 0;
							}
							goto IL_00b9;
						}
						goto IL_00d7;
						IL_00d7:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22e71f1d40564f3ab8f9ac9108d98dcb == 0)
						{
							num3 = 1;
						}
						goto IL_00b9;
						IL_00b9:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 3:
								break;
							case 4:
								EskF08YFhfBwSqxZ177(MonitorCacheUpdateService, current, RecalcTasksOfInstanceCountMonitorUpdateQueueAction.UID);
								num3 = 2;
								continue;
							case 2:
								goto IL_0116;
							case 1:
								EskF08YFhfBwSqxZ177(MonitorCacheUpdateService, current, RecalcCurrentInstanceCountMonitorUpdateQueueAction.UID);
								num3 = 4;
								continue;
							}
							break;
						}
						goto IL_00d7;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 4:
				if (ContextVars.TryGetValue<List<IProcessHeader>>("EleWise.ELMA.Workflow.Listeners.WorkflowInstanceMonitorListener", out value))
				{
					NNeH14YxGicAwQdRF2R("EleWise.ELMA.Workflow.Listeners.WorkflowInstanceMonitorListener");
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
					{
						num2 = 2;
					}
				}
				break;
			}
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		//Discarded unreachable code: IL_0068, IL_0077, IL_00f6, IL_0105
		int num = 9;
		List<IProcessHeader> value = default(List<IProcessHeader>);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (ContextVars.TryGetValue<List<IProcessHeader>>("EleWise.ELMA.Workflow.Listeners.WorkflowInstanceMonitorListener", out value))
					{
						goto end_IL_0012;
					}
					goto default;
				default:
					value = new List<IProcessHeader>();
					num2 = 7;
					break;
				case 1:
				case 2:
					bGSThFYtmTmyFg8eToY(UnitOfWorkManager, (Action)delegate
					{
						RecalcMonitors();
					});
					num2 = 4;
					break;
				case 9:
					workflowInstance = AxqjsdY8626O4hsZcgh(@event) as IWorkflowInstance;
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 != 0)
					{
						num2 = 6;
					}
					break;
				case 3:
					ContextVars.Set("EleWise.ELMA.Workflow.Listeners.WorkflowInstanceMonitorListener", value);
					num2 = 2;
					break;
				case 8:
					if (workflowInstance == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_91adcac8aa2043159a205c4a9f0e85fa != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 6;
				case 4:
					return;
				case 5:
				case 7:
					value.Add((IProcessHeader)yBA1JdYw4JcFfVqO04j(workflowInstance.Process));
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_766d50e1f7cc46f1bc746fe53086708c != 0)
					{
						num2 = 1;
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

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		//Discarded unreachable code: IL_01c4, IL_027a, IL_0289, IL_0299, IL_0403, IL_0412
		int num = 21;
		bool flag = default(bool);
		IMonitorCacheUpdateService serviceNotNull = default(IMonitorCacheUpdateService);
		WorkflowInstanceStatus workflowInstanceStatus = default(WorkflowInstanceStatus);
		int num3 = default(int);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					flag = true;
					num2 = 19;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 == 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					serviceNotNull = Locator.GetServiceNotNull<IMonitorCacheUpdateService>();
					num2 = 7;
					continue;
				case 23:
					workflowInstanceStatus = (WorkflowInstanceStatus)((object[])qM2nRZY2cvwOXpFMa3Q(@event))[num3];
					num = 17;
					break;
				case 16:
					num3 = Array.IndexOf((string[])h8DYNrYQCDQQ4HRlHT2(k5wB14Yq4O8iM3xUJsn(@event)), StatusPropertyName);
					num2 = 27;
					continue;
				case 2:
					if (k5wB14Yq4O8iM3xUJsn(@event) == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 16;
				case 21:
					workflowInstance = VVPmpKYs7DE9nXqJ0pv(@event) as IWorkflowInstance;
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 == 0)
					{
						num2 = 20;
					}
					continue;
				case 26:
					if (workflowInstanceStatus != WorkflowInstanceStatus.Aborted)
					{
						num2 = 12;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_25eedcea124a48258fd18106b7da9d93 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 24;
				case 12:
					if (workflowInstanceStatus == WorkflowInstanceStatus.Terminated)
					{
						num2 = 13;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 == 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 10;
				case 27:
					if (num3 < 0)
					{
						num2 = 4;
						continue;
					}
					goto case 23;
				case 17:
					if (workflowInstanceStatus != workflowInstance.Status)
					{
						num2 = 5;
						continue;
					}
					goto default;
				case 22:
					flag = true;
					num = 10;
					break;
				case 11:
					if (DBtYDsYV5pfQEfjA20b(workflowInstance) != WorkflowInstanceStatus.Aborted)
					{
						num = 30;
						break;
					}
					goto case 24;
				case 6:
					EskF08YFhfBwSqxZ177(serviceNotNull, yBA1JdYw4JcFfVqO04j(SDIq39YDD0Ry5KA1VBH(workflowInstance)), RecalcTasksOfInstanceCountMonitorUpdateQueueAction.UID);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c5274b5f82c74d1e8e92ea099532df1e != 0)
					{
						num2 = 1;
					}
					continue;
				case 28:
					serviceNotNull.InvokeAction((IProcessHeader)yBA1JdYw4JcFfVqO04j(SDIq39YDD0Ry5KA1VBH(workflowInstance)), RecalcCompleteInstanceCountMonitorUpdateQueueAction.UID);
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc != 0)
					{
						num2 = 3;
					}
					continue;
				case 10:
					if (DBtYDsYV5pfQEfjA20b(workflowInstance) != WorkflowInstanceStatus.Completed)
					{
						num2 = 3;
						continue;
					}
					goto case 28;
				case 14:
					if (DBtYDsYV5pfQEfjA20b(workflowInstance) != WorkflowInstanceStatus.Running)
					{
						num2 = 14;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 13;
				case 7:
					flag = false;
					num2 = 14;
					continue;
				case 25:
					flag = true;
					num2 = 11;
					continue;
				case 29:
					if (qM2nRZY2cvwOXpFMa3Q(@event) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 13:
					serviceNotNull.InvokeAction((IProcessHeader)yBA1JdYw4JcFfVqO04j(SDIq39YDD0Ry5KA1VBH(workflowInstance)), RecalcCurrentInstanceCountMonitorUpdateQueueAction.UID);
					num = 25;
					break;
				case 30:
					if (DBtYDsYV5pfQEfjA20b(workflowInstance) != WorkflowInstanceStatus.Terminated)
					{
						num2 = 26;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 24;
				case 3:
					if (workflowInstanceStatus == WorkflowInstanceStatus.Completed)
					{
						num2 = 28;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 19;
				case 24:
					EskF08YFhfBwSqxZ177(serviceNotNull, ((IWorkflowProcess)SDIq39YDD0Ry5KA1VBH(workflowInstance)).Header, RecalcTerminateInstanceCountMonitorUpdateQueueAction.UID);
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e45b9499c327415a9efec43f507582e4 != 0)
					{
						num2 = 22;
					}
					continue;
				case 20:
					if (workflowInstance != null)
					{
						num2 = 29;
						continue;
					}
					goto default;
				case 19:
					if (!flag)
					{
						num2 = 4;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 != 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 6;
				case 15:
					if (workflowInstanceStatus == WorkflowInstanceStatus.Running)
					{
						num2 = 13;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 11;
				default:
					return false;
				}
				break;
			}
		}
	}

	public WorkflowInstanceMonitorListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oB6bMHYK1kLdgAoyQ0j();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowInstanceMonitorListener()
	{
		int num = 1;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				oB6bMHYK1kLdgAoyQ0j();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1fcd5b77d5534d528c98a4d02b302a40 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				StatusPropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstance, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), kua9ScYMMBaGQ1b2mcg(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				num2 = 3;
				break;
			default:
				parameterExpression = (ParameterExpression)vwCGGMYYrGhQW43aTp5(kua9ScYMMBaGQ1b2mcg(typeof(IWorkflowInstance).TypeHandle), wgXPJSYaUkEOPViMTWi(-1941486619 ^ -1941478091));
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool xuvdD1Y3yMUbW12AKut()
	{
		return a68K1iYodpSB0GgEruM == null;
	}

	internal static WorkflowInstanceMonitorListener aowZJhYhknhLd9GmxBd()
	{
		return a68K1iYodpSB0GgEruM;
	}

	internal static void NNeH14YxGicAwQdRF2R(object P_0)
	{
		ContextVars.Remove((string)P_0);
	}

	internal static void EskF08YFhfBwSqxZ177(object P_0, object P_1, Guid P_2)
	{
		((IMonitorCacheUpdateService)P_0).InvokeAction((IProcessHeader)P_1, P_2);
	}

	internal static object AxqjsdY8626O4hsZcgh(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object yBA1JdYw4JcFfVqO04j(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static void bGSThFYtmTmyFg8eToY(object P_0, object P_1)
	{
		((IUnitOfWorkManager)P_0).RegisterPreCommitAction((Action)P_1);
	}

	internal static object VVPmpKYs7DE9nXqJ0pv(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object qM2nRZY2cvwOXpFMa3Q(object P_0)
	{
		return ((PreUpdateEvent)P_0).get_OldState();
	}

	internal static object k5wB14Yq4O8iM3xUJsn(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Persister();
	}

	internal static object h8DYNrYQCDQQ4HRlHT2(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyNames();
	}

	internal static WorkflowInstanceStatus DBtYDsYV5pfQEfjA20b(object P_0)
	{
		return ((IWorkflowInstance)P_0).Status;
	}

	internal static object SDIq39YDD0Ry5KA1VBH(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static void oB6bMHYK1kLdgAoyQ0j()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static Type kua9ScYMMBaGQ1b2mcg(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object wgXPJSYaUkEOPViMTWi(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object vwCGGMYYrGhQW43aTp5(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}
}
