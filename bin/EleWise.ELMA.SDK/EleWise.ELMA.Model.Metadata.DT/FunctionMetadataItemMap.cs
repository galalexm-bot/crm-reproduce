using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps;

internal class FunctionMetadataItemMap : EntityDTOMap<FunctionMetadataItem, FunctionMetadataItemDTO>
{
	private static FunctionMetadataItemMap n8JSRKbjEEyyPGdEtWtV;

	protected override void InitMap(IMappingExpression<FunctionMetadataItem, FunctionMetadataItemDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(FunctionMetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289675756));
		map.ForMember<object>(Expression.Lambda<Func<FunctionMetadataItemDTO, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<FunctionMetadataItem, FunctionMetadataItemDTO, object>>)delegate(IMemberConfigurationExpression<FunctionMetadataItem, FunctionMetadataItemDTO, object> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(FunctionMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4787C6A3));
			a.MapFrom<object>(Expression.Lambda<Func<FunctionMetadataItem, object>>(Expression.Call(Expression.Constant(this, typeof(FunctionMetadataItemMap)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	private object CopyMetadataToDTO(object metadata)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		FunctionMetadata functionMetadata = default(FunctionMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				return Mapper.Map<FunctionMetadata, FunctionMetadataDTO>(functionMetadata, new FunctionMetadataDTO());
			case 2:
				if ((functionMetadata = metadata as FunctionMetadata) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public FunctionMetadataItemMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool WVjaRQbjfJG60j07b8pk()
	{
		return n8JSRKbjEEyyPGdEtWtV == null;
	}

	internal static FunctionMetadataItemMap ittCmXbjQxehfAOPvadd()
	{
		return n8JSRKbjEEyyPGdEtWtV;
	}
}
