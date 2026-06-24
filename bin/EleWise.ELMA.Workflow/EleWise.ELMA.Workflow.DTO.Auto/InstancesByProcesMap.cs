using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.AutoMaps;

public class InstancesByProcesMap : BidirectionalMap<IWorkflowInstance, InstancesByProcesDTO>
{
	internal static InstancesByProcesMap gvivN8xwr6G9GPqYZS1;

	protected override void InitMap(IMappingExpression<IWorkflowInstance, InstancesByProcesDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(InstancesByProcesDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EE59C9));
		map.ForMember<Guid>(Expression.Lambda<Func<InstancesByProcesDTO, Guid>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IWorkflowInstance, InstancesByProcesDTO, Guid>>)delegate(IMemberConfigurationExpression<IWorkflowInstance, InstancesByProcesDTO, Guid> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(IWorkflowInstance), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1108950118));
			a.MapFrom<Guid>(Expression.Lambda<Func<IWorkflowInstance, Guid>>(Expression.Property(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	public InstancesByProcesMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool IHBSdQx4cTP1HZZfSna()
	{
		return gvivN8xwr6G9GPqYZS1 == null;
	}

	internal static InstancesByProcesMap qpkpiSxzruDoypBAoKv()
	{
		return gvivN8xwr6G9GPqYZS1;
	}
}
