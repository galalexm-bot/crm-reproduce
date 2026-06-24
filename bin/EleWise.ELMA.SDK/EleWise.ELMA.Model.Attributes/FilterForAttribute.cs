using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class FilterForAttribute : Attribute
{
	private Type entityType;

	internal static FilterForAttribute m526XOoZrynt1jym9h37;

	public Type EntityType => entityType;

	public FilterForAttribute(Type entityType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Jw9UcGoZjiT4xLHFR2Do();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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
			this.entityType = entityType;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
			{
				num = 1;
			}
		}
	}

	internal static void Jw9UcGoZjiT4xLHFR2Do()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool vW0hyDoZgwn6GSE4xOA4()
	{
		return m526XOoZrynt1jym9h37 == null;
	}

	internal static FilterForAttribute TPGXbxoZ5nkAN07St2v6()
	{
		return m526XOoZrynt1jym9h37;
	}
}
