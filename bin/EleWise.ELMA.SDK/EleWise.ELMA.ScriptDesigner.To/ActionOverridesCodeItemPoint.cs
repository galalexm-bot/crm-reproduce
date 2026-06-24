using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.API;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems;

[Serializable]
public class ActionOverridesCodeItemPoint : ActionGroupBaseCodeItemPoint
{
	internal static ActionOverridesCodeItemPoint VGuQ2euJdIwdJLG6LDg;

	public int SelectedActionIndex
	{
		[CompilerGenerated]
		get
		{
			return _003CSelectedActionIndex_003Ek__BackingField;
		}
		[CompilerGenerated]
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
					_003CSelectedActionIndex_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
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

	public List<ActionCodeItemPoint> Actions { get; set; }

	public ActionOverridesCodeItemPoint()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
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

	public ActionOverridesCodeItemPoint(IGrouping<string, MethodInfo> grouping, string callPath)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		base.Name = grouping.Key;
		Actions = new List<ActionCodeItemPoint>();
		InitializeActions(grouping, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x745DD88), callPath.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123618220), "")));
		base.Description = grouping.First().GetFullComments();
		base.CallPath = callPath;
	}

	private void InitializeActions(IEnumerable<MethodInfo> grouping, string callPath)
	{
		IList<MethodInfo> list = (grouping as IList<MethodInfo>) ?? grouping.ToList();
		foreach (MethodInfo item2 in list)
		{
			int order = list.IndexOf(item2);
			ActionCodeItemPoint item = new ActionCodeItemPoint(item2, callPath, order);
			Actions.Add(item);
		}
	}

	internal static bool jn5Hm3u9PJ2vSnZMA9n()
	{
		return VGuQ2euJdIwdJLG6LDg == null;
	}

	internal static ActionOverridesCodeItemPoint bLTaqaudaWmgDLwj7TP()
	{
		return VGuQ2euJdIwdJLG6LDg;
	}
}
