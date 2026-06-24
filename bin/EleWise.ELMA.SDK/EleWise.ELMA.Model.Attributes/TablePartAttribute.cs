using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class TablePartAttribute : Attribute
{
	private Type tablePartType;

	private static TablePartAttribute UTd7DXoZkCJG9Z5rsYLl;

	public Type TablePartType => tablePartType;

	public TablePartAttribute(Type tablePartType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
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
			this.tablePartType = tablePartType;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool p2DBxSoZnjdTdcNaDqxF()
	{
		return UTd7DXoZkCJG9Z5rsYLl == null;
	}

	internal static TablePartAttribute JY2XkBoZOJVjtLyvwECS()
	{
		return UTd7DXoZkCJG9Z5rsYLl;
	}
}
