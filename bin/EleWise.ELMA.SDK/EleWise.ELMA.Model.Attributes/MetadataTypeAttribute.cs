using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface)]
public class MetadataTypeAttribute : Attribute
{
	private Type metadataType;

	private static MetadataTypeAttribute eSmsZHoVoTeGkrHk86tu;

	public Type MetadataType => metadataType;

	public MetadataTypeAttribute(Type metadataType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		R86ICloVGFrCO89oQa3O();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.metadataType = metadataType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void R86ICloVGFrCO89oQa3O()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool LXpwCUoVbjsiTS9nk3fO()
	{
		return eSmsZHoVoTeGkrHk86tu == null;
	}

	internal static MetadataTypeAttribute jN0p8voVhuEwCtos0myo()
	{
		return eSmsZHoVoTeGkrHk86tu;
	}
}
