using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.AutoMaps;

public class ProcessGroupMap : EntityDTOMap<IProcessGroup, ProcessGroupDTO>
{
	internal static ProcessGroupMap SqCV0ESHERq0i3NqUTX;

	protected override void InitMap(IMappingExpression<IProcessGroup, ProcessGroupDTO> map)
	{
		base.InitMap(map);
	}

	protected override void InitReverseMap(IMappingExpression<ProcessGroupDTO, IProcessGroup> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IProcessGroup), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393921898));
		map.ForMember<ISet<IProcessHeader>>(Expression.Lambda<Func<IProcessGroup, ISet<IProcessHeader>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ProcessGroupDTO, IProcessGroup, ISet<IProcessHeader>>>)delegate(IMemberConfigurationExpression<ProcessGroupDTO, IProcessGroup, ISet<IProcessHeader>> a)
		{
			a.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IProcessGroup), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x11346464));
		map.ForMember<ISet<IProcessGroup>>(Expression.Lambda<Func<IProcessGroup, ISet<IProcessGroup>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ProcessGroupDTO, IProcessGroup, ISet<IProcessGroup>>>)delegate(IMemberConfigurationExpression<ProcessGroupDTO, IProcessGroup, ISet<IProcessGroup>> a)
		{
			a.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IProcessGroup), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122724869));
		map.ForMember<IProcessGroup>(Expression.Lambda<Func<IProcessGroup, IProcessGroup>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ProcessGroupDTO, IProcessGroup, IProcessGroup>>)delegate(IMemberConfigurationExpression<ProcessGroupDTO, IProcessGroup, IProcessGroup> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(ProcessGroupDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683802102));
			a.MapFrom<IProcessGroup>(Expression.Lambda<Func<ProcessGroupDTO, IProcessGroup>>(Expression.Call(Expression.Property(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(EntityManager<IProcessGroup>).TypeHandle)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntityManager<IProcessGroup>).TypeHandle), Expression.Convert(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	public ProcessGroupMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kcCPbKS9GTFdamtB0Iy();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void kcCPbKS9GTFdamtB0Iy()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool uIDchOSL5x5kwc69hV3()
	{
		return SqCV0ESHERq0i3NqUTX == null;
	}

	internal static ProcessGroupMap JtIZTkSfqfra1I257WF()
	{
		return SqCV0ESHERq0i3NqUTX;
	}
}
