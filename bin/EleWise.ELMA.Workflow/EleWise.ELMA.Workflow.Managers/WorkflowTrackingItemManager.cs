using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.Db;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowTrackingItemManager : EntityManager<IWorkflowTrackingItem, long>
{
	internal static WorkflowTrackingItemManager Og0AB4ul94sw2gCWMLn;

	public WorkflowDbStructure WorkflowDbStructure
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowDbStructure_003Ek__BackingField;
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
					_003CWorkflowDbStructure_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IWorkflowTrackingItem GetLastUnfinishedTracking(IWorkflowInstance instance, Guid elementUid)
	{
		int num = 7;
		int num2 = num;
		PropertyProjection val = default(PropertyProjection);
		PropertyProjection val2 = default(PropertyProjection);
		PropertyProjection val4 = default(PropertyProjection);
		PropertyProjection val3 = default(PropertyProjection);
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			default:
				return ((ICriteria)veHlBuuDiUkK1whRnSI(J8098FuuETshuZb4Ngq(a9eNi6ucqmRBZAYEJyW(a9eNi6ucqmRBZAYEJyW(a9eNi6ucqmRBZAYEJyW(base.Session.CreateCriteria<IWorkflowTrackingItem>(), Restrictions.Eq((IProjection)(object)val, (object)instance)), qdVo9yuPqSOyNSUZOEs(val2, elementUid)), NvGlXJuXSbh2xiG6wTq(val4)), OL5yiVud2nhRfQk5INd(val3)), 1)).List<IWorkflowTrackingItem>().FirstOrDefault();
			case 6:
				val = Projections.Property<IWorkflowTrackingItem>(Expression.Lambda<Func<IWorkflowTrackingItem, object>>((Expression)iALKP2ubHo7qASwU997(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 5;
				break;
			case 8:
				parameterExpression = (ParameterExpression)qjaC6TutJkWJBoQCdN0(XfsdFsu5WNEc9hFr6Al(typeof(IWorkflowTrackingItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651FED27));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				parameterExpression = (ParameterExpression)qjaC6TutJkWJBoQCdN0(typeof(IWorkflowTrackingItem), vZXNDEumbLaIcfY3voR(-63028171 ^ -63026289));
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				val4 = Projections.Property<IWorkflowTrackingItem>(Expression.Lambda<Func<IWorkflowTrackingItem, object>>((Expression)lwAbOWugRpndxMCSx65(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), XfsdFsu5WNEc9hFr6Al(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				num2 = 3;
				break;
			case 4:
				val3 = Projections.Property<IWorkflowTrackingItem>(Expression.Lambda<Func<IWorkflowTrackingItem, object>>((Expression)lwAbOWugRpndxMCSx65(iALKP2ubHo7qASwU997(parameterExpression, (MethodInfo)YZh9kVuB9wA7ujcmXvx((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), XfsdFsu5WNEc9hFr6Al(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				val2 = Projections.Property<IWorkflowTrackingItem>(Expression.Lambda<Func<IWorkflowTrackingItem, object>>(Expression.Convert((Expression)iALKP2ubHo7qASwU997(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), XfsdFsu5WNEc9hFr6Al(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				num2 = 8;
				break;
			case 3:
				parameterExpression = Expression.Parameter(XfsdFsu5WNEc9hFr6Al(typeof(IWorkflowTrackingItem).TypeHandle), (string)vZXNDEumbLaIcfY3voR(-351369538 ^ -351368956));
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				parameterExpression = Expression.Parameter(typeof(IWorkflowTrackingItem), (string)vZXNDEumbLaIcfY3voR(-2057730233 ^ -2057729795));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public WorkflowTrackingItemManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ytcCo1unJDLAuBLh9WZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool UQPIkpu0RKsX2YxY2hm()
	{
		return Og0AB4ul94sw2gCWMLn == null;
	}

	internal static WorkflowTrackingItemManager kW5VHSuyluqQGDaNomr()
	{
		return Og0AB4ul94sw2gCWMLn;
	}

	internal static object vZXNDEumbLaIcfY3voR(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object qjaC6TutJkWJBoQCdN0(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object iALKP2ubHo7qASwU997(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static Type XfsdFsu5WNEc9hFr6Al(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object lwAbOWugRpndxMCSx65(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object YZh9kVuB9wA7ujcmXvx(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object a9eNi6ucqmRBZAYEJyW(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object qdVo9yuPqSOyNSUZOEs(object P_0, object P_1)
	{
		return Restrictions.Eq((IProjection)P_0, P_1);
	}

	internal static object NvGlXJuXSbh2xiG6wTq(object P_0)
	{
		return Restrictions.IsNull((IProjection)P_0);
	}

	internal static object OL5yiVud2nhRfQk5INd(object P_0)
	{
		return Order.Desc((IProjection)P_0);
	}

	internal static object J8098FuuETshuZb4Ngq(object P_0, object P_1)
	{
		return ((ICriteria)P_0).AddOrder((Order)P_1);
	}

	internal static object veHlBuuDiUkK1whRnSI(object P_0, int P_1)
	{
		return ((ICriteria)P_0).SetMaxResults(P_1);
	}

	internal static void ytcCo1unJDLAuBLh9WZ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
