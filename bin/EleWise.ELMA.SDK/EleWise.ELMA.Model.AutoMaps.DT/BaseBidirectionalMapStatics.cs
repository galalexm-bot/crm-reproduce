using System.Collections.Generic;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.Converters;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.InstanceCreators;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;

internal static class BaseBidirectionalMapStatics
{
	internal static BaseBidirectionalMapStatics RlPWKFh0bhUeRg3NSfR0;

	internal static List<IInstanceCreator> InstanceCreators { get; }

	internal static List<ITypeConverter> TypeConverters { get; }

	static BaseBidirectionalMapStatics()
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					InstanceCreators = new List<IInstanceCreator>
					{
						new EntityInstanceCreator(),
						new DefaultInstanceCreator()
					};
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					TypeConverters = new List<ITypeConverter>
					{
						new EnumToInt32Converter(),
						new EnumToInt64Converter()
					};
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					break;
				}
				break;
			}
			Jan2qbh0Eps5pMuoV1AK();
			num = 2;
		}
	}

	internal static void Jan2qbh0Eps5pMuoV1AK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool GUXb4Mh0hmVRnq12G0hS()
	{
		return RlPWKFh0bhUeRg3NSfR0 == null;
	}

	internal static BaseBidirectionalMapStatics YiVFfMh0GB7fNshn3fCX()
	{
		return RlPWKFh0bhUeRg3NSfR0;
	}
}
