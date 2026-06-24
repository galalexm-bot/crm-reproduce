using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps;

internal class ComponentMetadataItemMap : EntityDTOMap<ComponentMetadataItem, ComponentMetadataItemDTO>
{
	internal static ComponentMetadataItemMap OLgHXJbjBF3ed473WDLn;

	protected override void InitMap(IMappingExpression<ComponentMetadataItem, ComponentMetadataItemDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(ComponentMetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099708119));
		map.ForMember<object>(Expression.Lambda<Func<ComponentMetadataItemDTO, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ComponentMetadataItem, ComponentMetadataItemDTO, object>>)delegate(IMemberConfigurationExpression<ComponentMetadataItem, ComponentMetadataItemDTO, object> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(ComponentMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875905023));
			a.MapFrom<object>(Expression.Lambda<Func<ComponentMetadataItem, object>>(Expression.Call(Expression.Constant(this, typeof(ComponentMetadataItemMap)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	private object CopyMetadataToDTO(object metadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(metadata is ComponentMetadata componentMetadata))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					break;
				}
				return Mapper.Map<ComponentMetadata, ComponentMetadataDTO>(componentMetadata, new ComponentMetadataDTO());
			default:
				return null;
			}
		}
	}

	public ComponentMetadataItemMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rKg4OEbjWayhbK8lRYWl()
	{
		return OLgHXJbjBF3ed473WDLn == null;
	}

	internal static ComponentMetadataItemMap UIspCdbjoQxiyL5Ru3lP()
	{
		return OLgHXJbjBF3ed473WDLn;
	}
}
