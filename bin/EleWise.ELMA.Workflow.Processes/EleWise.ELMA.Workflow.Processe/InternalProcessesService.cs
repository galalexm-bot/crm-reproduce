using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Processes;

internal class InternalProcessesService : ComplexLicensedUnit<IInternalProcessesService>, IInternalProcessesService, ILicensedUnit
{
	private static InternalProcessesService nCfIxahRmejneBg3JoM;

	public InternalProcessesService()
	{
		//Discarded unreachable code: IL_0039, IL_003e
		htXPQ6hWbLmSk8b07IN();
		base._002Ector((IInternalProcessesService)new InternalProcessesServiceExpress(), (IInternalProcessesService)new InternalProcessesServiceStandart(), (IInternalProcessesService)new InternalProcessesServiceOracle());
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1bd128a8000b4a92bbfa94dfdfc79104 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	void IInternalProcessesService.Check()
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
				GxyupChHtWeKZDE204I(ActiveUnit);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void htXPQ6hWbLmSk8b07IN()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool BbfTYCh0U2xB1w0aGPG()
	{
		return nCfIxahRmejneBg3JoM == null;
	}

	internal static InternalProcessesService pjkO5rhBaIkr7Uv8uBs()
	{
		return nCfIxahRmejneBg3JoM;
	}

	internal static void GxyupChHtWeKZDE204I(object P_0)
	{
		((IInternalProcessesService)P_0).Check();
	}
}
