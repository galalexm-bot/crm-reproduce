using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
public class TaskBaseMonitorListener : EntityEventsListener
{
	private static readonly string StatusPropertyName;

	private static readonly string ExecutorPropertyName;

	internal static TaskBaseMonitorListener uNIhRZakcKtZrMUFbyS;

	public override void OnPostInsert(PostInsertEvent @event)
	{
		int num = 3;
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					IMonitorCacheUpdateService serviceNotNull = Locator.GetServiceNotNull<IMonitorCacheUpdateService>();
					kviH5CaG6OVR6xyIW2Q(serviceNotNull, lI1WXxap510HplMa4k7(((IWorkflowBookmark)okuJu8aAnHTsWGZyAoa(workflowTaskBase)).Instance.Process), BaseWorkflowConstants.RecalcTaskOfInstanceCountGuid);
					MItL9GayrtyJ9A6w9eG(serviceNotNull, ((IWorkflowInstance)PXSobBantfYoMpEtuvQ(workflowTaskBase.WorkflowBookmark)).Process.Header, BaseWorkflowConstants.RecalcTaskOfInstanceCountGuid, workflowTaskBase.Executor);
					num2 = 4;
					continue;
				}
				case 3:
					break;
				default:
					if (okuJu8aAnHTsWGZyAoa(workflowTaskBase) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e != 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 4:
					return;
				case 2:
					if (workflowTaskBase == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			workflowTaskBase = BbmKmUamwkDp899TnhG(@event) as IWorkflowTaskBase;
			num = 2;
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00ac, IL_00dd, IL_00ec, IL_017d, IL_018c, IL_019c, IL_01ab, IL_0278, IL_02a8
		int num = 2;
		int num2 = num;
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		int num3 = default(int);
		IMonitorCacheUpdateService serviceNotNull = default(IMonitorCacheUpdateService);
		IUser user = default(IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 17:
				if (@event.get_OldState() == null)
				{
					num2 = 10;
					break;
				}
				goto case 20;
			case 9:
				if (okuJu8aAnHTsWGZyAoa(workflowTaskBase) == null)
				{
					num2 = 8;
					break;
				}
				goto case 7;
			case 10:
				return;
			case 0:
				return;
			case 3:
				return;
			case 4:
				return;
			case 8:
				return;
			case 16:
				return;
			case 19:
				return;
			case 21:
				num3 = Array.IndexOf((string[])f9AAxca6l8GWHtsBCQb(RfGv1EaOZ67Raaysejx(@event)), StatusPropertyName);
				num2 = 18;
				break;
			case 22:
				MItL9GayrtyJ9A6w9eG(serviceNotNull, lI1WXxap510HplMa4k7(YKZTpxaBuf5qqiMLOnD(PXSobBantfYoMpEtuvQ(okuJu8aAnHTsWGZyAoa(workflowTaskBase)))), BaseWorkflowConstants.RecalcTaskOfInstanceCountGuid, KQLMmnaWMGZBHXGnoNW(workflowTaskBase));
				num2 = 23;
				break;
			case 15:
				if (num3 < 0)
				{
					num2 = 19;
					break;
				}
				goto case 12;
			case 13:
				kviH5CaG6OVR6xyIW2Q(serviceNotNull, lI1WXxap510HplMa4k7(YKZTpxaBuf5qqiMLOnD(((IWorkflowBookmark)okuJu8aAnHTsWGZyAoa(workflowTaskBase)).Instance)), BaseWorkflowConstants.RecalcTaskOfInstanceCountGuid);
				num2 = 7;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5158ff5e06d54ab9b6f7b04c47b15f73 != 0)
				{
					num2 = 22;
				}
				break;
			case 12:
				user = (IUser)((object[])EWlJu7aHQQB6PfCsEt8(@event))[num3];
				num2 = 14;
				break;
			case 11:
				MItL9GayrtyJ9A6w9eG(serviceNotNull, lI1WXxap510HplMa4k7(YKZTpxaBuf5qqiMLOnD(PXSobBantfYoMpEtuvQ(workflowTaskBase.WorkflowBookmark))), BaseWorkflowConstants.RecalcTaskOfInstanceCountGuid, KQLMmnaWMGZBHXGnoNW(workflowTaskBase));
				num2 = 4;
				break;
			case 23:
				num3 = Array.IndexOf((string[])f9AAxca6l8GWHtsBCQb(((AbstractPostDatabaseOperationEvent)@event).get_Persister()), ExecutorPropertyName);
				num2 = 15;
				break;
			case 6:
				MItL9GayrtyJ9A6w9eG(serviceNotNull, lI1WXxap510HplMa4k7(((IWorkflowBookmark)okuJu8aAnHTsWGZyAoa(workflowTaskBase)).Instance.Process), BaseWorkflowConstants.RecalcTaskOfInstanceCountGuid, user);
				num2 = 11;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				serviceNotNull = Locator.GetServiceNotNull<IMonitorCacheUpdateService>();
				num2 = 21;
				break;
			case 1:
				if (workflowTaskBase == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 17;
			case 18:
				if (num3 >= 0)
				{
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 23;
			case 2:
				workflowTaskBase = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IWorkflowTaskBase;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bd008fca9c464e14859870d0f9208652 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (!vENrnXa0UsXxNFfE9pX((TaskBaseStatus)@event.get_OldState()[num3], XPIVlWaR3havkTHsWHl(workflowTaskBase)))
				{
					num2 = 13;
					break;
				}
				goto case 23;
			case 14:
				if (vENrnXa0UsXxNFfE9pX(user, KQLMmnaWMGZBHXGnoNW(workflowTaskBase)))
				{
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 != 0)
					{
						num2 = 16;
					}
					break;
				}
				goto case 6;
			case 20:
				if (RfGv1EaOZ67Raaysejx(@event) == null)
				{
					num2 = 3;
					break;
				}
				goto case 9;
			}
		}
	}

	public TaskBaseMonitorListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EWXSntaenmLjGAnPpBO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TaskBaseMonitorListener()
	{
		int num = 5;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 4:
				parameterExpression = (ParameterExpression)LPQhj2alpWiPSq4gRaU(vYahEhaiXtwmll3oSDN(typeof(ITaskBase).TypeHandle), fQ8u1fauLIHAnZJxubM(-416187968 ^ -416194800));
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				parameterExpression = (ParameterExpression)LPQhj2alpWiPSq4gRaU(typeof(ITaskBase), fQ8u1fauLIHAnZJxubM(-351702578 ^ -351709410));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				EWXSntaenmLjGAnPpBO();
				num2 = 4;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				StatusPropertyName = LinqUtils.NameOf(Expression.Lambda<Func<ITaskBase, object>>((Expression)yKTGY4aLOalJLyjO4aF(parameterExpression, (MethodInfo)QvCHitafCqDvjwPZaJa((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 3;
				continue;
			}
			ExecutorPropertyName = LinqUtils.NameOf(Expression.Lambda<Func<ITaskBase, object>>(Expression.Property(parameterExpression, (MethodInfo)QvCHitafCqDvjwPZaJa((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
			num2 = 1;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
			{
				num2 = 1;
			}
		}
	}

	internal static object BbmKmUamwkDp899TnhG(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object okuJu8aAnHTsWGZyAoa(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object lI1WXxap510HplMa4k7(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static void kviH5CaG6OVR6xyIW2Q(object P_0, object P_1, Guid P_2)
	{
		((IMonitorCacheUpdateService)P_0).InvokeAction((IProcessHeader)P_1, P_2);
	}

	internal static object PXSobBantfYoMpEtuvQ(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static void MItL9GayrtyJ9A6w9eG(object P_0, object P_1, Guid P_2, object P_3)
	{
		((IMonitorCacheUpdateService)P_0).InvokeAction((IProcessHeader)P_1, P_2, (IUser)P_3);
	}

	internal static bool xF1ZqoabDLtcuP9dJuW()
	{
		return uNIhRZakcKtZrMUFbyS == null;
	}

	internal static TaskBaseMonitorListener hHkMBmaUERL3jugn4sQ()
	{
		return uNIhRZakcKtZrMUFbyS;
	}

	internal static object RfGv1EaOZ67Raaysejx(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Persister();
	}

	internal static object f9AAxca6l8GWHtsBCQb(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyNames();
	}

	internal static object XPIVlWaR3havkTHsWHl(object P_0)
	{
		return ((ITaskBase)P_0).Status;
	}

	internal static bool vENrnXa0UsXxNFfE9pX(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static object YKZTpxaBuf5qqiMLOnD(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object KQLMmnaWMGZBHXGnoNW(object P_0)
	{
		return ((ITaskBase)P_0).Executor;
	}

	internal static object EWlJu7aHQQB6PfCsEt8(object P_0)
	{
		return ((PostUpdateEvent)P_0).get_OldState();
	}

	internal static void EWXSntaenmLjGAnPpBO()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static Type vYahEhaiXtwmll3oSDN(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object fQ8u1fauLIHAnZJxubM(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object LPQhj2alpWiPSq4gRaU(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object QvCHitafCqDvjwPZaJa(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object yKTGY4aLOalJLyjO4aF(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}
}
