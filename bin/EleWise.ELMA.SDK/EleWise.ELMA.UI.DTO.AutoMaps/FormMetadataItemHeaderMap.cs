using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.DTO.Models;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.DTO.AutoMaps;

public class FormMetadataItemHeaderMap : EntityDTOMap<IFormMetadataItemHeader, FormMetadataItemHeaderDTO>
{
	internal static FormMetadataItemHeaderMap eMS2G7Jcr9NbVCxwjjv;

	protected override void InitMap(IMappingExpression<IFormMetadataItemHeader, FormMetadataItemHeaderDTO> map)
	{
		base.InitMap(map);
	}

	protected override void InitReverseMap(IMappingExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105223338));
		map.ForMember<long?>(Expression.Lambda<Func<IFormMetadataItemHeader, long?>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, long?>>)delegate(IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, long?> p)
		{
			p.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751152812));
		map.ForMember<DateTime>(Expression.Lambda<Func<IFormMetadataItemHeader, DateTime>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, DateTime>>)delegate(IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, DateTime> p)
		{
			p.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BB198A));
		map.ForMember<IFormMetadataItem>(Expression.Lambda<Func<IFormMetadataItemHeader, IFormMetadataItem>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, IFormMetadataItem>>)delegate(IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, IFormMetadataItem> p)
		{
			p.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3307346));
		map.ForMember<IFormMetadataItem>(Expression.Lambda<Func<IFormMetadataItemHeader, IFormMetadataItem>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, IFormMetadataItem>>)delegate(IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, IFormMetadataItem> p)
		{
			p.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542763735));
		map.ForMember<IFormMetadataItemGroup>(Expression.Lambda<Func<IFormMetadataItemHeader, IFormMetadataItemGroup>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, IFormMetadataItemGroup>>)delegate(IMemberConfigurationExpression<FormMetadataItemHeaderDTO, IFormMetadataItemHeader, IFormMetadataItemGroup> p)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(FormMetadataItemHeaderDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC385FE));
			p.MapFrom<IFormMetadataItemGroup>(Expression.Lambda<Func<FormMetadataItemHeaderDTO, IFormMetadataItemGroup>>(Expression.Condition(Expression.NotEqual(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant((long?)null, typeof(long?))), Expression.Call(Expression.Property(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(EntityManager<IFormMetadataItemGroup>).TypeHandle)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntityManager<IFormMetadataItemGroup>).TypeHandle), Expression.Convert(Expression.Property(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(long?).TypeHandle)), typeof(object))), Expression.Constant(null, typeof(IFormMetadataItemGroup))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	public FormMetadataItemHeaderMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		B07F0g9B2wnGLPBbapA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void B07F0g9B2wnGLPBbapA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool CrIdHeJzLpaAkvx58YR()
	{
		return eMS2G7Jcr9NbVCxwjjv == null;
	}

	internal static FormMetadataItemHeaderMap zysRGA9FqsOOayxhbvO()
	{
		return eMS2G7Jcr9NbVCxwjjv;
	}
}
