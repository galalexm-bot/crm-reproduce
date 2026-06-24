using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Models;

[Component]
public class WorkerListContainer : IXsiRoot
{
	internal static WorkerListContainer fa0496GBWadcTJNpZrE;

	public List<Worker> Workers { get; set; }

	public WorkerListContainer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		DWJ7a8GeUsbWEJipZKF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Workers = new List<Worker>();
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public WorkerListContainer(List<Worker> workers)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		Workers = workers;
	}

	internal static void DWJ7a8GeUsbWEJipZKF()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool w7udIaGus0k3HXIBv5g()
	{
		return fa0496GBWadcTJNpZrE == null;
	}

	internal static WorkerListContainer Lbn0qWGmgmYKabWnS4O()
	{
		return fa0496GBWadcTJNpZrE;
	}
}
