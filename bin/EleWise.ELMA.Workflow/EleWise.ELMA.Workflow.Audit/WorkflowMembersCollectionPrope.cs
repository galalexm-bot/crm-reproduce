using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Common.Audit;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Audit;

[Component]
internal sealed class WorkflowMembersCollectionPropertyHistoryProcessing : IEntityCollectionPropertyHistoryProcessing
{
	private readonly Guid membersPropertyGuid;

	private static WorkflowMembersCollectionPropertyHistoryProcessing LhrUP4ZDEmyb0mhUjohn;

	public WorkflowMembersCollectionPropertyHistoryProcessing()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
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
			{
				ParameterExpression parameterExpression = (ParameterExpression)Ut66bLZnOgJVuPUC0db5(T7OMWvZDzF2jXWn8dtyc(typeof(IWorkflowInstance).TypeHandle), klZwAMZnKm8WuwyQb4Nl(-801808857 ^ -801775371));
				membersPropertyGuid = InterfaceActivator.PropertyUid(Expression.Lambda<Func<IWorkflowInstance, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	public bool CanProcessing(EntityMetadata ownerMetadata, PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return NmHDmGZnZpTDNwQV2O1b(propertyMetadata.Uid, membersPropertyGuid);
			default:
				return false;
			case 1:
				if (propertyMetadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public bool NeedProcessing(EntityMetadata ownerMetadata, PropertyMetadata propertyMetadata)
	{
		return false;
	}

	internal static Type T7OMWvZDzF2jXWn8dtyc(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object klZwAMZnKm8WuwyQb4Nl(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Ut66bLZnOgJVuPUC0db5(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static bool SNcyMlZDwCyGq2T9JvSk()
	{
		return LhrUP4ZDEmyb0mhUjohn == null;
	}

	internal static WorkflowMembersCollectionPropertyHistoryProcessing hYwaKOZD4gA9joXAeqEE()
	{
		return LhrUP4ZDEmyb0mhUjohn;
	}

	internal static bool NmHDmGZnZpTDNwQV2O1b(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
