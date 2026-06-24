using AutoMapper;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.AutoMaps;

public class BidirectionalMap<TSource, TDestination> : SimpleMap<TSource, TDestination>
{
	private static object gCM1yuh7ApFx4whI1qov;

	protected sealed override void InitMap(IMapperConfigurationExpression configuration)
	{
		int num = 2;
		IMappingExpression<TDestination, TSource> map = default(IMappingExpression<TDestination, TSource>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					base.InitMap(configuration);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					map = ((IProfileExpression)configuration).CreateMap<TDestination, TSource>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				}
				break;
			}
			InitReverseMap(map);
			num = 3;
		}
	}

	protected virtual void InitReverseMap(IMappingExpression<TDestination, TSource> map)
	{
	}

	public BidirectionalMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Wtr3TFh778aZYlrBf0O4()
	{
		return gCM1yuh7ApFx4whI1qov == null;
	}

	internal static object B7ttKyh7x5xaJuiY826B()
	{
		return gCM1yuh7ApFx4whI1qov;
	}
}
