using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ActorModel.Attributes;

[AttributeUsage(AttributeTargets.Interface)]
public sealed class FeatureFlagManagedAttribute : Attribute
{
	private static FeatureFlagManagedAttribute UBTNw8fDGeKDhONlSPx6;

	public string FeatureFlagName { get; }

	public bool DefaultEnabled { get; }

	public FeatureFlagManagedAttribute(string featureFlagName, bool defaultEnabled)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				DefaultEnabled = defaultEnabled;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			default:
				FeatureFlagName = featureFlagName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static bool L42LBffDEAugflCuQZbt()
	{
		return UBTNw8fDGeKDhONlSPx6 == null;
	}

	internal static FeatureFlagManagedAttribute KicjtgfDfFkvqxflBqEU()
	{
		return UBTNw8fDGeKDhONlSPx6;
	}
}
