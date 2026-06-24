using AutoMapper;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.AutoMaps;

[Component]
public class SimpleMap<TSource, TDestination> : IAutoMapConfigurator
{
	internal static object LOF7wch7MfBZWi1sljZb;

	protected virtual void InitMap(IMapperConfigurationExpression configuration)
	{
		int num = 1;
		int num2 = num;
		IMappingExpression<TSource, TDestination> map = default(IMappingExpression<TSource, TDestination>);
		while (true)
		{
			switch (num2)
			{
			default:
				InitMap(map);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 1:
				map = ((IProfileExpression)configuration).CreateMap<TSource, TDestination>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void InitMap(IMappingExpression<TSource, TDestination> map)
	{
	}

	public void Configure(IMapperConfigurationExpression configuration)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				InitMap(configuration);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public SimpleMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool s0YCrJh7JkFOwWrCeWi3()
	{
		return LOF7wch7MfBZWi1sljZb == null;
	}

	internal static object FyqeFCh79s5lV2fuPSfN()
	{
		return LOF7wch7MfBZWi1sljZb;
	}
}
