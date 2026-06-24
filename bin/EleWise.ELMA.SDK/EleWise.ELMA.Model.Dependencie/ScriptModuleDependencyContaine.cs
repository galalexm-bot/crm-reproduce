using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies;

public sealed class ScriptModuleDependencyContainer : IDependencyContainer
{
	internal static ScriptModuleDependencyContainer VCxOHAhRB6Bv0enRnnch;

	public List<DataClassDependency> DataClassDependencies { get; }

	public List<EntityDependency> EntityDependencies { get; }

	public List<EnumDependency> EnumDependencies { get; }

	public ScriptModuleDependencyContainer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xykq7fhRbT1ZhbYQDnqd();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				EnumDependencies = new List<EnumDependency>();
				num = 3;
				break;
			case 2:
				DataClassDependencies = new List<DataClassDependency>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			default:
				EntityDependencies = new List<EntityDependency>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void xykq7fhRbT1ZhbYQDnqd()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool LYCecvhRWgUhNcDoDNXS()
	{
		return VCxOHAhRB6Bv0enRnnch == null;
	}

	internal static ScriptModuleDependencyContainer xYbvlUhRoZhqv71dbXCF()
	{
		return VCxOHAhRB6Bv0enRnnch;
	}
}
