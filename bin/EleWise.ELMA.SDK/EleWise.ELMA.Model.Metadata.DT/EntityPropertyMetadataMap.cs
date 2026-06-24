using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.DTO.AutoMaps;

public class EntityPropertyMetadataMap : EntityPropertyMetadataMap<EntityPropertyMetadata, EntityPropertyMetadata>
{
	private static EntityPropertyMetadataMap y3a1DKbjCrrNcUB1c2Uc;

	public EntityPropertyMetadataMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Mrudw3bjvAmyCodVQLHx()
	{
		return y3a1DKbjCrrNcUB1c2Uc == null;
	}

	internal static EntityPropertyMetadataMap eIoqQWbj8lWbKN1vqLCJ()
	{
		return y3a1DKbjCrrNcUB1c2Uc;
	}
}
public class EntityPropertyMetadataMap<TSource, TTarget> : SimpleMap<TSource, TTarget> where TSource : EntityPropertyMetadata where TTarget : EntityPropertyMetadata
{
	private static object zgG4BhbjZl50oSOtFmKp;

	protected override void InitMap(IMappingExpression<TSource, TTarget> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(TTarget), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A8714));
		map.ForMember<long>(Expression.Lambda<Func<TTarget, long>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(Entity<long>).TypeHandle)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TSource, TTarget, long>>)delegate(IMemberConfigurationExpression<TSource, TTarget, long> opt)
		{
			opt.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(TTarget), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643821103));
		map.ForMember<EntityMetadata>(Expression.Lambda<Func<TTarget, EntityMetadata>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TSource, TTarget, EntityMetadata>>)delegate(IMemberConfigurationExpression<TSource, TTarget, EntityMetadata> opt)
		{
			opt.Ignore();
		});
	}

	public EntityPropertyMetadataMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool vhP905bju8437sRmenPo()
	{
		return zgG4BhbjZl50oSOtFmKp == null;
	}

	internal static object BWyOUfbjIaLHeCaLnVt2()
	{
		return zgG4BhbjZl50oSOtFmKp;
	}
}
