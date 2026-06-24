using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Diagrams.Activities;

public struct ActivityExecuteResult
{
	public Guid[] NextElementUids;

	private static object g48giWEOJ7oRJNnZsxc;

	public ActivityExecuteResult(Guid nextElementUid)
	{
		//Discarded unreachable code: IL_0005
		nsqHPeEY1BJ87Fd9wZR();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				NextElementUids = new Guid[1] { nextElementUid };
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public ActivityExecuteResult(Guid[] nextElementUids)
	{
		//Discarded unreachable code: IL_0005
		nsqHPeEY1BJ87Fd9wZR();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				NextElementUids = nextElementUids;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void nsqHPeEY1BJ87Fd9wZR()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool PpAoRFEZbDYtamidgtn()
	{
		return g48giWEOJ7oRJNnZsxc == null;
	}

	internal static object tKIkxHEv3sxQxZ2LltH()
	{
		return g48giWEOJ7oRJNnZsxc;
	}
}
