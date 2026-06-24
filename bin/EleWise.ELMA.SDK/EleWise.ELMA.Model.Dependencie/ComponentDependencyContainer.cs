using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Dependencies;

public sealed class ComponentDependencyContainer : IDependencyContainer
{
	private static ComponentDependencyContainer teRXTmhi0FblPcMgdf19;

	public List<ComponentDependency> ComponentDependencies { get; }

	public List<FunctionDependency> FunctionDependencies { get; }

	public List<DataClassDependency> DataClassDependencies { get; }

	public List<EntityDependency> EntityDependencies { get; }

	public List<EnumDependency> EnumDependencies { get; }

	public ComponentDependencyContainer()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		hVrFmDhiMSWKOKfJVN6R();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 4:
				EnumDependencies = new List<EnumDependency>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				DataClassDependencies = new List<DataClassDependency>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num = 3;
				}
				break;
			case 3:
				EntityDependencies = new List<EntityDependency>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num = 4;
				}
				break;
			case 5:
				FunctionDependencies = new List<FunctionDependency>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				ComponentDependencies = new List<ComponentDependency>();
				num = 5;
				break;
			}
		}
	}

	internal static void hVrFmDhiMSWKOKfJVN6R()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool aUVI5DhimygyZK109iiI()
	{
		return teRXTmhi0FblPcMgdf19 == null;
	}

	internal static ComponentDependencyContainer z7F186hiyUGIjblOJUaW()
	{
		return teRXTmhi0FblPcMgdf19;
	}
}
