using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal sealed class WorkflowMessageBookmarkListener : EntityEventsListener
{
	private static readonly string StatusPropertyName;

	private static WorkflowMessageBookmarkListener CKjHjpaKYA5EFIcVubT;

	public WorkflowMessageBookmarkManager WorkflowMessageBookmarkManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowMessageBookmarkManager_003Ek__BackingField;
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
					_003CWorkflowMessageBookmarkManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 == 0)
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

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		//Discarded unreachable code: IL_0087, IL_0096, IL_00a1, IL_0124, IL_015c, IL_016b, IL_01c1, IL_0291, IL_02a0
		int num = 11;
		IEnumerator<IWorkflowMessageBookmark> enumerator = default(IEnumerator<IWorkflowMessageBookmark>);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		WorkflowInstanceStatus workflowInstanceStatus = default(WorkflowInstanceStatus);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (jvFDASavxVedsGdoo43(@event) == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ae8403b9a8240c5b9d009904e9a6779 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto default;
				case 2:
					try
					{
						while (true)
						{
							int num4;
							if (!jlJnQHac5lAgb55WEP0(enumerator))
							{
								num4 = 2;
								goto IL_00a5;
							}
							goto IL_00d1;
							IL_00a5:
							switch (num4)
							{
							case 1:
								goto IL_00d1;
							case 2:
								goto end_IL_00bb;
							}
							continue;
							IL_00d1:
							IWorkflowMessageBookmark current = enumerator.Current;
							current.Status = WorkflowMessageBookmarkStatus.Terminated;
							oOrJWpaTfU5PvFLXOiK(current);
							num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 == 0)
							{
								num4 = 0;
							}
							goto IL_00a5;
							continue;
							end_IL_00bb:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num5 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_908b32727d48459090dc901d67456a14 == 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									enumerator.Dispose();
									num5 = 1;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c8901ad9999948b380523446821824e3 == 0)
									{
										num5 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					break;
				case 3:
					enumerator = WorkflowMessageBookmarkManager.GetAwaitingMessageBookmarks(workflowInstance).GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 != 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					if (workflowInstanceStatus != lBDIfja9mhtWmVY2rwQ(workflowInstance))
					{
						num2 = 4;
						continue;
					}
					break;
				case 11:
					workflowInstance = dWM5iKaYboDYvVvyoUq(@event) as IWorkflowInstance;
					num2 = 10;
					continue;
				default:
					if (w7Tjg6aPTaks7AijkNB(@event) == null)
					{
						num2 = 11;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_98890646a18d4a91b352a4ea5d1be319 != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 12;
				case 4:
					if (lBDIfja9mhtWmVY2rwQ(workflowInstance) != WorkflowInstanceStatus.Aborted)
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5158ff5e06d54ab9b6f7b04c47b15f73 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 15;
				case 10:
					if (workflowInstance == null)
					{
						break;
					}
					goto end_IL_0012;
				case 5:
					if (num3 >= 0)
					{
						num2 = 14;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd == 0)
						{
							num2 = 8;
						}
						continue;
					}
					break;
				case 1:
					if (lBDIfja9mhtWmVY2rwQ(workflowInstance) == WorkflowInstanceStatus.Terminated)
					{
						num2 = 13;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 != 0)
						{
							num2 = 15;
						}
						continue;
					}
					break;
				case 15:
					if (workflowInstanceStatus == WorkflowInstanceStatus.Running)
					{
						num2 = 3;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 12:
					num3 = Array.IndexOf((string[])fhvLL5a4hnygwKdFBMB(w7Tjg6aPTaks7AijkNB(@event)), StatusPropertyName);
					num2 = 5;
					continue;
				case 14:
					workflowInstanceStatus = (WorkflowInstanceStatus)((object[])jvFDASavxVedsGdoo43(@event))[num3];
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
					{
						num2 = 3;
					}
					continue;
				case 8:
				case 9:
				case 13:
					break;
				}
				return false;
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public WorkflowMessageBookmarkListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gkdHq6aNrgTxKgSvNFg();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_98890646a18d4a91b352a4ea5d1be319 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowMessageBookmarkListener()
	{
		int num = 1;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 2:
				StatusPropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstance, object>>(Expression.Convert((Expression)g6jC5VaSnMNu0Rrk18e(parameterExpression, (MethodInfo)H7h6s0aj7A9YE4IjsBY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return;
			default:
				parameterExpression = Expression.Parameter(typeof(IWorkflowInstance), (string)cAdesaadrqmATKUnGF4(-437373675 ^ -437382203));
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				gkdHq6aNrgTxKgSvNFg();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool D0LR6uaMRZfIRaxuLxC()
	{
		return CKjHjpaKYA5EFIcVubT == null;
	}

	internal static WorkflowMessageBookmarkListener e88I7jaaIlg8X87qhcs()
	{
		return CKjHjpaKYA5EFIcVubT;
	}

	internal static object dWM5iKaYboDYvVvyoUq(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object jvFDASavxVedsGdoo43(object P_0)
	{
		return ((PreUpdateEvent)P_0).get_OldState();
	}

	internal static object w7Tjg6aPTaks7AijkNB(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Persister();
	}

	internal static object fhvLL5a4hnygwKdFBMB(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyNames();
	}

	internal static WorkflowInstanceStatus lBDIfja9mhtWmVY2rwQ(object P_0)
	{
		return ((IWorkflowInstance)P_0).Status;
	}

	internal static void oOrJWpaTfU5PvFLXOiK(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static bool jlJnQHac5lAgb55WEP0(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void gkdHq6aNrgTxKgSvNFg()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object cAdesaadrqmATKUnGF4(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object H7h6s0aj7A9YE4IjsBY(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object g6jC5VaSnMNu0Rrk18e(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}
}
