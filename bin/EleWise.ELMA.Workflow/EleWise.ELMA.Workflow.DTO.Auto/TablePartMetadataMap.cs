using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.AutoMaps;

public class TablePartMetadataMap : SimpleMap<TablePartMetadata, TablePartMetadata>
{
	internal static TablePartMetadataMap IHsGjCSUDJJ44S2tCUv;

	protected override void InitMap(IMappingExpression<TablePartMetadata, TablePartMetadata> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(TablePartMetadata), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x1926832D));
		map.ForMember<long>(Expression.Lambda<Func<TablePartMetadata, long>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(Entity<long>).TypeHandle)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TablePartMetadata, TablePartMetadata, long>>)delegate(IMemberConfigurationExpression<TablePartMetadata, TablePartMetadata, long> opt)
		{
			opt.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(TablePartMetadata), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772567324));
		map.ForMember<EntityMetadata>(Expression.Lambda<Func<TablePartMetadata, EntityMetadata>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TablePartMetadata, TablePartMetadata, EntityMetadata>>)delegate(IMemberConfigurationExpression<TablePartMetadata, TablePartMetadata, EntityMetadata> opt)
		{
			opt.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(TablePartMetadata), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6C70AE));
		map.ForMember<ISet<EntityPropertyMetadata>>(Expression.Lambda<Func<TablePartMetadata, ISet<EntityPropertyMetadata>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TablePartMetadata, TablePartMetadata, ISet<EntityPropertyMetadata>>>)delegate(IMemberConfigurationExpression<TablePartMetadata, TablePartMetadata, ISet<EntityPropertyMetadata>> opt)
		{
			opt.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(TablePartMetadata), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EA5F6E));
		map.ForMember<ISet<TablePartMetadata>>(Expression.Lambda<Func<TablePartMetadata, ISet<TablePartMetadata>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TablePartMetadata, TablePartMetadata, ISet<TablePartMetadata>>>)delegate(IMemberConfigurationExpression<TablePartMetadata, TablePartMetadata, ISet<TablePartMetadata>> opt)
		{
			opt.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(TablePartMetadata), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46EAC6B));
		map.ForMember<List<PropertyMetadata>>(Expression.Lambda<Func<TablePartMetadata, List<PropertyMetadata>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TablePartMetadata, TablePartMetadata, List<PropertyMetadata>>>)delegate(IMemberConfigurationExpression<TablePartMetadata, TablePartMetadata, List<PropertyMetadata>> opt)
		{
			opt.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(TablePartMetadata), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x42311E82));
		map.ForMember<List<TablePartMetadata>>(Expression.Lambda<Func<TablePartMetadata, List<TablePartMetadata>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TablePartMetadata, TablePartMetadata, List<TablePartMetadata>>>)delegate(IMemberConfigurationExpression<TablePartMetadata, TablePartMetadata, List<TablePartMetadata>> opt)
		{
			opt.Ignore();
		});
	}

	public TablePartMetadataMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MyaPCHSGCkKLMQbCKoV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void MyaPCHSGCkKLMQbCKoV()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool QKEZUuSV6ZfDcNMgc7R()
	{
		return IHsGjCSUDJJ44S2tCUv == null;
	}

	internal static TablePartMetadataMap QmSDLeSAvOHpo0pxgEw()
	{
		return IHsGjCSUDJJ44S2tCUv;
	}
}
