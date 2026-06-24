using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Service]
public class RunWithSoftDeletableService
{
	private readonly IContextBoundVariableService contextBoundVariableService;

	private static RunWithSoftDeletableService Kdr4WmBxudohnC55sXaI;

	public bool Turned
	{
		get
		{
			bool value;
			return contextBoundVariableService.TryGetValue<bool>((string)nkQillBxSiMfyDnY30ZH(0x53FA00CE ^ 0x53FB5F2E), out value) && value;
		}
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
				case 1:
					BbD69HBxifP1ZkYO78DZ(contextBoundVariableService, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411152307), value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public RunWithSoftDeletableService(IContextBoundVariableService contextBoundVariableService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
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
			this.contextBoundVariableService = contextBoundVariableService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
			{
				num = 0;
			}
		}
	}

	internal static bool cq3WFuBxIGeJAE6H40eV()
	{
		return Kdr4WmBxudohnC55sXaI == null;
	}

	internal static RunWithSoftDeletableService ONygK3BxVyXEO5scOsFO()
	{
		return Kdr4WmBxudohnC55sXaI;
	}

	internal static object nkQillBxSiMfyDnY30ZH(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void BbD69HBxifP1ZkYO78DZ(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}
}
