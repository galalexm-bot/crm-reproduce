using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.DTO.Models;
using EleWise.ELMA.UI.Models;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.DTO.AutoMaps;

public class FormMetadataItemGroupMap : EntityDTOMap<IFormMetadataItemGroup, FormMetadataItemGroupDTO>
{
	private static FormMetadataItemGroupMap Fo16XkJYGrpPN2GscYq;

	protected override void InitMap(IMappingExpression<IFormMetadataItemGroup, FormMetadataItemGroupDTO> map)
	{
		base.InitMap(map);
	}

	protected override void InitReverseMap(IMappingExpression<FormMetadataItemGroupDTO, IFormMetadataItemGroup> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IFormMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AB084C));
		map.ForMember<ISet<IFormMetadataItemHeader>>(Expression.Lambda<Func<IFormMetadataItemGroup, ISet<IFormMetadataItemHeader>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<FormMetadataItemGroupDTO, IFormMetadataItemGroup, ISet<IFormMetadataItemHeader>>>)delegate(IMemberConfigurationExpression<FormMetadataItemGroupDTO, IFormMetadataItemGroup, ISet<IFormMetadataItemHeader>> a)
		{
			a.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2026B6EB));
		map.ForMember<ISet<IFormMetadataItemGroup>>(Expression.Lambda<Func<IFormMetadataItemGroup, ISet<IFormMetadataItemGroup>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<FormMetadataItemGroupDTO, IFormMetadataItemGroup, ISet<IFormMetadataItemGroup>>>)delegate(IMemberConfigurationExpression<FormMetadataItemGroupDTO, IFormMetadataItemGroup, ISet<IFormMetadataItemGroup>> a)
		{
			a.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561118784));
		map.ForMember<IFormMetadataItemGroup>(Expression.Lambda<Func<IFormMetadataItemGroup, IFormMetadataItemGroup>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<FormMetadataItemGroupDTO, IFormMetadataItemGroup, IFormMetadataItemGroup>>)delegate(IMemberConfigurationExpression<FormMetadataItemGroupDTO, IFormMetadataItemGroup, IFormMetadataItemGroup> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(FormMetadataItemGroupDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A7555F9));
			a.MapFrom<IFormMetadataItemGroup>(Expression.Lambda<Func<FormMetadataItemGroupDTO, IFormMetadataItemGroup>>(Expression.Call(Expression.Property(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(EntityManager<IFormMetadataItemGroup>).TypeHandle)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntityManager<IFormMetadataItemGroup>).TypeHandle), Expression.Convert(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	public FormMetadataItemGroupMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xZSssBJsFae5A11BE59();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void xZSssBJsFae5A11BE59()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool KT7gj1JLVARXA72goFm()
	{
		return Fo16XkJYGrpPN2GscYq == null;
	}

	internal static FormMetadataItemGroupMap yW0A48JUBf0Cyh7Oyia()
	{
		return Fo16XkJYGrpPN2GscYq;
	}
}
