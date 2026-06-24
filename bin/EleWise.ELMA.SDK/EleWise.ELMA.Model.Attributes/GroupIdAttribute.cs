using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface)]
public class GroupIdAttribute : Attribute
{
	private long id;

	internal static GroupIdAttribute Bw10dbov4bpeATxUYy2D;

	public long Id => id;

	public GroupIdAttribute(long id)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		f636AwovADtvLjZbbbfy();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.id = id;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void f636AwovADtvLjZbbbfy()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool aQXSVjov6tHZQdXUbIBy()
	{
		return Bw10dbov4bpeATxUYy2D == null;
	}

	internal static GroupIdAttribute NSralQovHFM06Njej7Sk()
	{
		return Bw10dbov4bpeATxUYy2D;
	}
}
