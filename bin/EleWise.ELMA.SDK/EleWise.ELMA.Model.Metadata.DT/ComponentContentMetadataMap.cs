using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps;

internal class ComponentContentMetadataMap : EntityDTOMap<ComponentContentMetadata, ComponentContentMetadataDTO>
{
	internal static ComponentContentMetadataMap skGJRNb5DMKLxUbg70j6;

	protected override void InitMap(IMappingExpression<ComponentContentMetadata, ComponentContentMetadataDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(ComponentContentMetadataDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A73889));
		map.ForMember<ComponentContextMetadata>(Expression.Lambda<Func<ComponentContentMetadataDTO, ComponentContextMetadata>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ComponentContentMetadata, ComponentContentMetadataDTO, ComponentContextMetadata>>)delegate(IMemberConfigurationExpression<ComponentContentMetadata, ComponentContentMetadataDTO, ComponentContextMetadata> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(ComponentContentMetadata), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629723252));
			a.MapFrom<ComponentContextMetadata>(Expression.Lambda<Func<ComponentContentMetadata, ComponentContextMetadata>>(Expression.Call(Expression.Constant(this, typeof(ComponentContentMetadataMap)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	protected virtual ComponentContextMetadata CopyContextToDTO(ComponentContextMetadata context)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (context != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return null;
			default:
				return Mapper.Map<ComponentContextMetadata, ComponentContextMetadata>(context, new ComponentContextMetadata());
			}
		}
	}

	public ComponentContentMetadataMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		t6srCeb54q0cyCsUByUl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool cWAQl4b5tAecxVBCt2TX()
	{
		return skGJRNb5DMKLxUbg70j6 == null;
	}

	internal static ComponentContentMetadataMap gaj2WNb5w2g5KcgDq2tK()
	{
		return skGJRNb5DMKLxUbg70j6;
	}

	internal static void t6srCeb54q0cyCsUByUl()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
