using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class ShowInCatalogListAttribute : Attribute
{
	private bool needShow;

	private static ShowInCatalogListAttribute xVa9fbouAf6Kg6y1iSvA;

	public bool NeedShow => needShow;

	public ShowInCatalogListAttribute()
	{
		//Discarded unreachable code: IL_0036, IL_003b
		gfmIQ5ou0Xl9X4YtsP0O();
		needShow = true;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ShowInCatalogListAttribute(bool needShow)
	{
		//Discarded unreachable code: IL_0036, IL_003b
		gfmIQ5ou0Xl9X4YtsP0O();
		this.needShow = true;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.needShow = needShow;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
			{
				num = 1;
			}
		}
	}

	internal static void gfmIQ5ou0Xl9X4YtsP0O()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool bQgBlnou7u74Slw1hdkd()
	{
		return xVa9fbouAf6Kg6y1iSvA == null;
	}

	internal static ShowInCatalogListAttribute HQNMh5ouxjWduUWvZhYd()
	{
		return xVa9fbouAf6Kg6y1iSvA;
	}
}
