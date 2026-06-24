using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Extensions;

[Component]
public class ModuleContainerEvents : IModuleContainerEvents
{
	private static ModuleContainerEvents dZF5ErrZyh7t06h06iE;

	public void Activated()
	{
		((UserManager)fb0OR9ru7RTnF9tFouy()).NotifyChangeUserNames();
	}

	public void Terminating()
	{
	}

	public ModuleContainerEvents()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tOoWWUrmYP4hUUidukc();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object fb0OR9ru7RTnF9tFouy()
	{
		return UserManager.Instance;
	}

	internal static void tOoWWUrmYP4hUUidukc()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool NCVBE8rxyJxPSZXlDKs()
	{
		return dZF5ErrZyh7t06h06iE == null;
	}

	internal static ModuleContainerEvents DAragqrBo6iTAShLcBE()
	{
		return dZF5ErrZyh7t06h06iE;
	}
}
