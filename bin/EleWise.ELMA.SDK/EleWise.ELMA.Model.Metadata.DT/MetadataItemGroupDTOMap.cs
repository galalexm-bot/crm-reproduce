using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps;

public class MetadataItemGroupDTOMap : EntityDTOMap<IMetadataItemGroup, MetadataItemGroupDTO>
{
	internal static MetadataItemGroupDTOMap c4tQqBbjqtOVjiaeJvwu;

	protected override void InitMap(IMappingExpression<IMetadataItemGroup, MetadataItemGroupDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(MetadataItemGroupDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889656670));
		map.ForMember<long>(Expression.Lambda<Func<MetadataItemGroupDTO, long>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IMetadataItemGroup, MetadataItemGroupDTO, long>>)delegate(IMemberConfigurationExpression<IMetadataItemGroup, MetadataItemGroupDTO, long> o)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(IMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824357451));
			o.MapFrom<long>(Expression.Lambda<Func<IMetadataItemGroup, long>>(Expression.Condition(Expression.NotEqual(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant((long?)null, typeof(long?))), Expression.Property(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(long?).TypeHandle)), Expression.Constant(-1L, typeof(long))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	protected override void InitReverseMap(IMappingExpression<MetadataItemGroupDTO, IMetadataItemGroup> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103CE997));
		map.ForMember<IMetadataItemGroup>(Expression.Lambda<Func<IMetadataItemGroup, IMetadataItemGroup>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<MetadataItemGroupDTO, IMetadataItemGroup, IMetadataItemGroup>>)delegate(IMemberConfigurationExpression<MetadataItemGroupDTO, IMetadataItemGroup, IMetadataItemGroup> o)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(MetadataItemGroupDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867791772));
			o.MapFrom<IMetadataItemGroup>(Expression.Lambda<Func<MetadataItemGroupDTO, IMetadataItemGroup>>(Expression.Condition(Expression.GreaterThan(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(0L, typeof(long))), Expression.Call(Expression.Property(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(EntityManager<IMetadataItemGroup>).TypeHandle)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntityManager<IMetadataItemGroup>).TypeHandle), Expression.Convert(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object))), Expression.Constant(null, typeof(IMetadataItemGroup))), new ParameterExpression[1] { parameterExpression2 }));
		});
		parameterExpression = Expression.Parameter(typeof(IMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97906508));
		map.ForMember<ISet<IMetadataItemGroup>>(Expression.Lambda<Func<IMetadataItemGroup, ISet<IMetadataItemGroup>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<MetadataItemGroupDTO, IMetadataItemGroup, ISet<IMetadataItemGroup>>>)delegate(IMemberConfigurationExpression<MetadataItemGroupDTO, IMetadataItemGroup, ISet<IMetadataItemGroup>> a)
		{
			a.Ignore();
		});
	}

	public MetadataItemGroupDTOMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CQM1H6bjTUMheY15978M();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void CQM1H6bjTUMheY15978M()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Eyi8SxbjKGAnPfruJbX3()
	{
		return c4tQqBbjqtOVjiaeJvwu == null;
	}

	internal static MetadataItemGroupDTOMap QaFtxMbjXDwOQa5dg1hO()
	{
		return c4tQqBbjqtOVjiaeJvwu;
	}
}
