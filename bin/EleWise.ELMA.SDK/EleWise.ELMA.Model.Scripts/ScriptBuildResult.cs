using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts;

[Serializable]
public class ScriptBuildResult : ScriptCompileResult
{
	private static ScriptBuildResult toYkYhbixeKZ1VenuiGs;

	public byte[] AssemblyRaw
	{
		[CompilerGenerated]
		get
		{
			return _003CAssemblyRaw_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CAssemblyRaw_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public byte[] DebugRaw
	{
		[CompilerGenerated]
		get
		{
			return _003CDebugRaw_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CDebugRaw_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ScriptBuildResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		G6dwgFbiyw5SMJLjUyHE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool cAq1v6bi0kd1R8RJ2IEV()
	{
		return toYkYhbixeKZ1VenuiGs == null;
	}

	internal static ScriptBuildResult KYTN9nbimkmaOZB13tK8()
	{
		return toYkYhbixeKZ1VenuiGs;
	}

	internal static void G6dwgFbiyw5SMJLjUyHE()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
