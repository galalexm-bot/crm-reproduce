using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class EntityAttribute : Attribute
{
	private string tableName;

	private static EntityAttribute rQgxqJoVEasDQDnPHtJF;

	public string TableName => tableName;

	public EntityAttribute(string tableName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nH2tFhoVCsRgIuZQ1NIE();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.tableName = tableName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void nH2tFhoVCsRgIuZQ1NIE()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool pce8LCoVfljNhdM6ZLne()
	{
		return rQgxqJoVEasDQDnPHtJF == null;
	}

	internal static EntityAttribute eLAHSxoVQxAoqj5Fj3re()
	{
		return rQgxqJoVEasDQDnPHtJF;
	}
}
