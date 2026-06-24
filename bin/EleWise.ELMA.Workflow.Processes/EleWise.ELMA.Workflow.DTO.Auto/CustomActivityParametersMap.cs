using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Models;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.AutoMaps;

public class CustomActivityParametersMap : SimpleMap<CustomActivityParameters, CustomActivityParameters>
{
	internal static CustomActivityParametersMap NrPiau4MkBLPlFmdTe3;

	protected override void InitMap(IMappingExpression<CustomActivityParameters, CustomActivityParameters> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(CustomActivityParameters), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x587702A0 ^ 0x587732BA));
		map.ForMember<ISet<EntityPropertyMetadata>>(Expression.Lambda<Func<CustomActivityParameters, ISet<EntityPropertyMetadata>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<CustomActivityParameters, CustomActivityParameters, ISet<EntityPropertyMetadata>>>)delegate(IMemberConfigurationExpression<CustomActivityParameters, CustomActivityParameters, ISet<EntityPropertyMetadata>> opt)
		{
			opt.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(CustomActivityParameters), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1952076060 ^ -1952080130));
		map.ForMember<ISet<TablePartMetadata>>(Expression.Lambda<Func<CustomActivityParameters, ISet<TablePartMetadata>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<CustomActivityParameters, CustomActivityParameters, ISet<TablePartMetadata>>>)delegate(IMemberConfigurationExpression<CustomActivityParameters, CustomActivityParameters, ISet<TablePartMetadata>> opt)
		{
			opt.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(CustomActivityParameters), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-30505303 ^ -30493005));
		map.ForMember<List<PropertyMetadata>>(Expression.Lambda<Func<CustomActivityParameters, List<PropertyMetadata>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<CustomActivityParameters, CustomActivityParameters, List<PropertyMetadata>>>)delegate(IMemberConfigurationExpression<CustomActivityParameters, CustomActivityParameters, List<PropertyMetadata>> opt)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(CustomActivityParameters), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x138E9AEB ^ 0x138EF745));
			opt.MapFrom<List<PropertyMetadata>>(Expression.Lambda<Func<CustomActivityParameters, List<PropertyMetadata>>>(Expression.Call(Expression.Constant(this, typeof(CustomActivityParametersMap)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	private List<PropertyMetadata> ConvertProperties(List<PropertyMetadata> src)
	{
		if (src == null)
		{
			return null;
		}
		List<PropertyMetadata> list = new List<PropertyMetadata>();
		foreach (PropertyMetadata item2 in src)
		{
			if (item2 is EntityPropertyMetadata entityPropertyMetadata)
			{
				EntityPropertyMetadata item = Mapper.Map<EntityPropertyMetadata, EntityPropertyMetadata>(entityPropertyMetadata, new EntityPropertyMetadata());
				list.Add(item);
			}
		}
		return list;
	}

	public CustomActivityParametersMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SjSGx14vF7ADdm6ekB5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void SjSGx14vF7ADdm6ekB5()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool BDHDqT4axlULanntVNb()
	{
		return NrPiau4MkBLPlFmdTe3 == null;
	}

	internal static CustomActivityParametersMap lKVGbd4YA9h9uFg39hH()
	{
		return NrPiau4MkBLPlFmdTe3;
	}
}
