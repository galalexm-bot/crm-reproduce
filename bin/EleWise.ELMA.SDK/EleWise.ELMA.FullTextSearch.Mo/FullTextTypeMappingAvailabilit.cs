using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.Model;

internal sealed class FullTextTypeMappingAvailability : IFullTextTypeMappingAvailability
{
	internal static FullTextTypeMappingAvailability mr7l3SGiOW2U2gk34FAr;

	public bool IsAvailable { get; }

	public IReadOnlyCollection<string> Errors { get; }

	private FullTextTypeMappingAvailability(params string[] errors)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sCGkDvGiPEAV5TO3vUqq();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				IsAvailable = errors.Length == 0;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				Errors = (IReadOnlyCollection<string>)(object)errors;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static FullTextTypeMappingAvailability Available()
	{
		return new FullTextTypeMappingAvailability();
	}

	internal static FullTextTypeMappingAvailability NotAvailable(params string[] errors)
	{
		return new FullTextTypeMappingAvailability(errors);
	}

	internal static void sCGkDvGiPEAV5TO3vUqq()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool qQ9fXuGi2xSgtyOqNGsg()
	{
		return mr7l3SGiOW2U2gk34FAr == null;
	}

	internal static FullTextTypeMappingAvailability PMsfIqGieripk3ZZjGDQ()
	{
		return mr7l3SGiOW2U2gk34FAr;
	}
}
