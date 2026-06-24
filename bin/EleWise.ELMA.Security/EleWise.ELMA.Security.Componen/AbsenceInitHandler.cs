using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Components;

[Component]
public class AbsenceInitHandler : IModuleContainerEvents
{
	private static AbsenceInitHandler HH1EOX9ZMjrUAwuegdQ;

	public void Activated()
	{
		((AbsenceManager)y73QAT9ud7EBRUA6tHZ()).InitAbsenceCache();
	}

	public void Terminating()
	{
	}

	public AbsenceInitHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Jpc6HY9m8g099Smm37e();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object y73QAT9ud7EBRUA6tHZ()
	{
		return AbsenceManager.Instance;
	}

	internal static void Jpc6HY9m8g099Smm37e()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool HHrCLa9xdJmi4RNeELV()
	{
		return HH1EOX9ZMjrUAwuegdQ == null;
	}

	internal static AbsenceInitHandler hEfDEQ9BulA9h2ovmgl()
	{
		return HH1EOX9ZMjrUAwuegdQ;
	}
}
