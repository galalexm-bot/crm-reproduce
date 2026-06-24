using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.CodeAnalyzers;

public sealed class ServerEntityUsageAnalyzer : EntityUsageAnalyzer
{
	private static ServerEntityUsageAnalyzer TWoWWCfR9M33dER0sXrn;

	protected override bool CheckModule(IModuleSymbol module)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 1:
				if (module != null)
				{
					return wJTD2YfR59BObGsQeo9m(j0BPOUfRr9ZFgy3XnmDc(module), naYRdNfRgwJwrktIr7Qm(-1487388570 ^ -1487401498));
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ServerEntityUsageAnalyzer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KEyt5DfRjTKDpp7jXDQ1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object j0BPOUfRr9ZFgy3XnmDc(object P_0)
	{
		return ((ISymbol)P_0).get_Name();
	}

	internal static object naYRdNfRgwJwrktIr7Qm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool wJTD2YfR59BObGsQeo9m(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool n327kkfRdfRFHM1NfZ6P()
	{
		return TWoWWCfR9M33dER0sXrn == null;
	}

	internal static ServerEntityUsageAnalyzer itClvmfRluMbtCHYltRQ()
	{
		return TWoWWCfR9M33dER0sXrn;
	}

	internal static void KEyt5DfRjTKDpp7jXDQ1()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
