using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
public class ComponentOrderAttribute : Attribute
{
	private int order;

	private static ComponentOrderAttribute hTIMKRfZDumDDWwyWIT7;

	public int Order => order;

	public ComponentOrderAttribute(int order)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		aTf0SMfZ4Jc13CYWugEk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
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
			this.order = order;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
			{
				num = 0;
			}
		}
	}

	internal static void aTf0SMfZ4Jc13CYWugEk()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool W35Y0TfZtVwW9tvgra82()
	{
		return hTIMKRfZDumDDWwyWIT7 == null;
	}

	internal static ComponentOrderAttribute dwmSwWfZwhMH6wlkci2H()
	{
		return hTIMKRfZDumDDWwyWIT7;
	}
}
