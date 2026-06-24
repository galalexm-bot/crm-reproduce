using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Tasks;

public abstract class TaskActivity<TElement> : BPMNActivity<TElement>, IActivityNotificationRecipients where TElement : BPMNFlowElement
{
	private IEnumerable<IDenyReplaceExecutorExtention> denyReplaceExecutorExtentions;

	private static object i1Wr4tZdqpaRyqVldTop;

	private IEnumerable<IDenyReplaceExecutorExtention> DenyReplaceExecutorExtentions => denyReplaceExecutorExtentions ?? (denyReplaceExecutorExtentions = ComponentManager.Current.GetExtensionPoints<IDenyReplaceExecutorExtention>());

	protected sealed override void Execute(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_0076, IL_00ae, IL_00ee, IL_00fd, IL_0109, IL_0118
		int num = 2;
		int num2 = num;
		ActivityExecutionContextHelper.IItemSetter itemSetter = default(ActivityExecutionContextHelper.IItemSetter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				itemSetter = ActivityExecutionContextHelper.SetElement(base.Element);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					ExecuteTask(context);
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					int num4;
					if (itemSetter == null)
					{
						num4 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
						{
							num4 = 2;
						}
						goto IL_00b2;
					}
					goto IL_00c8;
					IL_00c8:
					itemSetter.Dispose();
					num4 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num4 = 1;
					}
					goto IL_00b2;
					IL_00b2:
					switch (num4)
					{
					case 2:
						goto end_IL_008d;
					case 1:
						goto end_IL_008d;
					}
					goto IL_00c8;
					end_IL_008d:;
				}
			case 0:
				return;
			}
		}
	}

	protected virtual void ExecuteTask(NativeActivityContext context)
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
				ContinueOnDefaultConnector(context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual IUser ReplacementUser<T>(T entity, Expression<Func<T, object>> expr, IUser user) where T : IEntity
	{
		_003C_003Ec__DisplayClass5_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0<T>();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.swimlane = GetSwimlane();
		bool denyReplacementInTask = DenyReplaceExecutorExtentions.Any((IDenyReplaceExecutorExtention p) => p.DenyReplace(CS_0024_003C_003E8__locals0._003C_003E4__this.Element, CS_0024_003C_003E8__locals0.swimlane));
		return ReplacementManager.GetReplacementUser(entity, expr, user, CS_0024_003C_003E8__locals0.swimlane != null && CS_0024_003C_003E8__locals0.swimlane.DenyReplacement, denyReplacementInTask);
	}

	protected bool AssignExecutor(ITaskBase task, IUser executor, ICollection<IUser> executorsTasks, bool isAvailableReAssign = true)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.task = task;
		IUser user;
		if (!isAvailableReAssign)
		{
			user = executor;
		}
		else
		{
			ITaskBase task2 = CS_0024_003C_003E8__locals0.task;
			ParameterExpression parameterExpression = Expression.Parameter(typeof(ITaskBase), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -29910794));
			user = ReplacementUser(task2, Expression.Lambda<Func<ITaskBase, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), executor);
		}
		IUser user2 = user;
		if (executor != null && user2.Id != executor.Id)
		{
			CS_0024_003C_003E8__locals0.task.ExecutorReplaced = executor;
		}
		CS_0024_003C_003E8__locals0.task.Executor = user2;
		if (executorsTasks.Any((IUser m) => m.Id == CS_0024_003C_003E8__locals0.task.Executor.Id))
		{
			CS_0024_003C_003E8__locals0.task.Delete();
			return false;
		}
		executorsTasks.Add(CS_0024_003C_003E8__locals0.task.Executor);
		return true;
	}

	protected IUser GetCurrentExecutor(ITaskBase task, FlowConnectorElement connector)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_00ae, IL_00bd
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (task.IsEmulation)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				return task.Executor;
			default:
				return task.ExecutorIsEmulation;
			case 1:
				return null;
			case 2:
				if (!connector.CurrentExecutor)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	protected TaskActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool pBClONZd3G0jlJ3icYyB()
	{
		return i1Wr4tZdqpaRyqVldTop == null;
	}

	internal static object vRnl2BZdT2rFf5MvUTc6()
	{
		return i1Wr4tZdqpaRyqVldTop;
	}
}
