using System;
using System.Collections.Generic;
using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.AutoMaps;

[Component]
internal class AutoMapInitHandler : IInitHandler
{
	private readonly IEnumerable<IAutoMapConfigurator> configs;

	private static AutoMapInitHandler jbZi1Lh73of4a36MxfNP;

	public AutoMapInitHandler(IEnumerable<IAutoMapConfigurator> configs)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.configs = configs;
	}

	public void Init()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Mapper.Initialize((Action<IMapperConfigurationExpression>)delegate(IMapperConfigurationExpression cfg)
				{
					int num3 = 3;
					int num4 = num3;
					_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 2:
							_003C_003Ec__DisplayClass2_.cfg = cfg;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
							{
								num4 = 1;
							}
							break;
						case 0:
							return;
						case 3:
							_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
							num4 = 2;
							break;
						case 1:
							configs.ForEach(_003C_003Ec__DisplayClass2_._003CInit_003Eb__1);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void InitComplete()
	{
	}

	internal static bool nyXKohh7pfkN6yTfwf1Y()
	{
		return jbZi1Lh73of4a36MxfNP == null;
	}

	internal static AutoMapInitHandler k68CPSh7ajij0muZnfoi()
	{
		return jbZi1Lh73of4a36MxfNP;
	}
}
