using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Mappers;

internal abstract class DefaultMapperConfigurator : IInternalMapperConfigurator
{
	protected static readonly Type DefaultMapperTypeInternal;

	private static DefaultMapperConfigurator cJcNHHhxEoSyiZLQgEmG;

	public abstract IEnumerable<IInternalMapperConfiguration> Init();

	protected DefaultMapperConfigurator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static DefaultMapperConfigurator()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				DefaultMapperTypeInternal = XQOaOrhxC4yWZ7WbtejT(typeof(DefaultDataClassBidirectionalMap<>).TypeHandle);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool T9GJD3hxfd1UyNYgVrKs()
	{
		return cJcNHHhxEoSyiZLQgEmG == null;
	}

	internal static DefaultMapperConfigurator RyohNyhxQMb2xEFsDcBk()
	{
		return cJcNHHhxEoSyiZLQgEmG;
	}

	internal static Type XQOaOrhxC4yWZ7WbtejT(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
