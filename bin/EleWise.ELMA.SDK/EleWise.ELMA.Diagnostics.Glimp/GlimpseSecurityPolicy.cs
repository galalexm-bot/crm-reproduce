using Glimpse.Core.Extensibility;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Glimpse;

public class GlimpseSecurityPolicy : IRuntimePolicy
{
	internal static GlimpseSecurityPolicy rmZteuERoBQyu641A2q5;

	public RuntimeEvent ExecuteOn => (RuntimeEvent)40;

	public RuntimePolicy Execute(IRuntimePolicyContext policyContext)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!GlimpseHelper.AllowCurrentUser())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return (RuntimePolicy)60;
			default:
				return (RuntimePolicy)1;
			}
		}
	}

	public GlimpseSecurityPolicy()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		a37jThERGTXh43yn6jOX();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Je27qZERbcgqWBJusljw()
	{
		return rmZteuERoBQyu641A2q5 == null;
	}

	internal static GlimpseSecurityPolicy mYYJ7CERhkOD3k97Ffbh()
	{
		return rmZteuERoBQyu641A2q5;
	}

	internal static void a37jThERGTXh43yn6jOX()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
