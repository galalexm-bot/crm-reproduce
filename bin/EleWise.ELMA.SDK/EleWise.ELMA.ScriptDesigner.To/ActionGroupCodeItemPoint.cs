using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems;

[Serializable]
public class ActionGroupCodeItemPoint : ActionGroupBaseCodeItemPoint
{
	private static ActionGroupCodeItemPoint DQjJTyu0lHVjaqDJdLc;

	public List<ActionOverridesCodeItemPoint> Actions { get; set; }

	public List<ActionGroupBaseCodeItemPoint> ActionGroups { get; set; }

	public ActionGroupCodeItemPoint()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dlkQMnuMCmfPqJv8Wui();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ActionGroupCodeItemPoint(string name)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dlkQMnuMCmfPqJv8Wui();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Actions = new List<ActionOverridesCodeItemPoint>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				ActionGroups = new List<ActionGroupBaseCodeItemPoint>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			case 3:
				base.Name = name;
				num = 2;
				break;
			}
		}
	}

	internal static void dlkQMnuMCmfPqJv8Wui()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool MVq14QumPGHb5qqQcOO()
	{
		return DQjJTyu0lHVjaqDJdLc == null;
	}

	internal static ActionGroupCodeItemPoint C0YneAuywFyh45K8UnJ()
	{
		return DQjJTyu0lHVjaqDJdLc;
	}
}
