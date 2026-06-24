using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class OverrideExtensibleClassPropertyAttribute : Attribute
{
	private string propertyValue;

	private static OverrideExtensibleClassPropertyAttribute Vx9lWpoQBvMt2DMWGan2;

	public string PropertyValue => propertyValue;

	public OverrideExtensibleClassPropertyAttribute(string value)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jCxNG6oQbSD2TjcuP1lL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
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
			propertyValue = value;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
			{
				num = 1;
			}
		}
	}

	internal static void jCxNG6oQbSD2TjcuP1lL()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool T1YH25oQW3hyZm817rma()
	{
		return Vx9lWpoQBvMt2DMWGan2 == null;
	}

	internal static OverrideExtensibleClassPropertyAttribute HfiAeLoQoGOrOASsLqpt()
	{
		return Vx9lWpoQBvMt2DMWGan2;
	}
}
