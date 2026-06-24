using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps;

internal class DataClassMetadataItemMap : EntityDTOMap<DataClassMetadataItem, DataClassMetadataItemDTO>
{
	internal static DataClassMetadataItemMap wnxnVqb5jAcXEOLh9yAW;

	protected override void InitMap(IMappingExpression<DataClassMetadataItem, DataClassMetadataItemDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(DataClassMetadataItemDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE1281B1));
		map.ForMember<object>(Expression.Lambda<Func<DataClassMetadataItemDTO, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<DataClassMetadataItem, DataClassMetadataItemDTO, object>>)delegate(IMemberConfigurationExpression<DataClassMetadataItem, DataClassMetadataItemDTO, object> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(DataClassMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x363289CF));
			a.MapFrom<object>(Expression.Lambda<Func<DataClassMetadataItem, object>>(Expression.Call(Expression.Constant(this, typeof(DataClassMetadataItemMap)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression2 }));
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
			default:
				return null;
			case 1:
				if (metadata is DataClassMetadata dataClassMetadata)
				{
					return Mapper.Map<DataClassMetadata, DataClassMetadata>(dataClassMetadata, new DataClassMetadata());
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public DataClassMetadataItemMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		H68RbTb5Ul0P9BT4rPY5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool hIq2nob5YDJfKexh9d4I()
	{
		return wnxnVqb5jAcXEOLh9yAW == null;
	}

	internal static DataClassMetadataItemMap JfltqMb5Lwab492BET2l()
	{
		return wnxnVqb5jAcXEOLh9yAW;
	}

	internal static void H68RbTb5Ul0P9BT4rPY5()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
