using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies;

public sealed class DependencyAnalysisResult
{
	internal static DependencyAnalysisResult SDuP4PhiJA3HaJ49I6Mn;

	public List<EnumDependency> EnumDependencies { get; set; }

	public List<EntityDependency> EntityDependencies { get; set; }

	public List<DataClassDependency> DataClassDependencies { get; set; }

	public List<FunctionDependency> FunctionDependencies { get; set; }

	public List<ComponentDependency> ComponentDependencies { get; set; }

	public DependencyAnalysisResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tRQY6xhilGZGxYu6C3YC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				EntityDependencies = new List<EntityDependency>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num = 1;
				}
				break;
			case 5:
				return;
			case 1:
				DataClassDependencies = new List<DataClassDependency>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				FunctionDependencies = new List<FunctionDependency>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num = 3;
				}
				break;
			case 3:
				ComponentDependencies = new List<ComponentDependency>();
				num = 5;
				break;
			default:
				EnumDependencies = new List<EnumDependency>();
				num = 4;
				break;
			}
		}
	}

	internal static void tRQY6xhilGZGxYu6C3YC()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool iSoKtVhi9l0Y5jY8pCcJ()
	{
		return SDuP4PhiJA3HaJ49I6Mn == null;
	}

	internal static DependencyAnalysisResult StJJ3OhidWPklrQQhnOc()
	{
		return SDuP4PhiJA3HaJ49I6Mn;
	}
}
