using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Managers;

internal sealed class WorkflowTaskWithSubtasksTransformer : AliasToBeanResultTransformer
{
	private static WorkflowTaskWithSubtasksTransformer Rwx3WqPsCg09jY4Pkmi;

	public WorkflowTaskWithSubtasksTransformer()
	{
		//Discarded unreachable code: IL_0034, IL_0039
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector(typeof(MainTaskWithChild));
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override IList TransformList(IList collection)
	{
		//Discarded unreachable code: IL_002e, IL_003d, IL_0048, IL_0098, IL_00a7, IL_017a, IL_01ba, IL_01c9, IL_01d5, IL_01e4
		int num = 2;
		int num2 = num;
		IEnumerator<MainTaskWithChild> enumerator = default(IEnumerator<MainTaskWithChild>);
		IWorkflowTaskBase main = default(IWorkflowTaskBase);
		ITask task = default(ITask);
		HashSet<long> hashSet = default(HashSet<long>);
		List<IWorkflowTaskBase> list = default(List<IWorkflowTaskBase>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					while (true)
					{
						IL_013e:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
							{
								num3 = 2;
							}
							goto IL_004c;
						}
						goto IL_00e6;
						IL_00e6:
						MainTaskWithChild current = enumerator.Current;
						main = current.Main;
						task = (ITask)F4LcObP0sFyajmOWPm6(current);
						num3 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
						{
							num3 = 0;
						}
						goto IL_004c;
						IL_004c:
						while (true)
						{
							switch (num3)
							{
							case 6:
								if (!hashSet.Add(main.Id))
								{
									num3 = 3;
									continue;
								}
								goto case 5;
							case 3:
							case 7:
								if (task != null)
								{
									num3 = 4;
									continue;
								}
								goto IL_013e;
							case 5:
								list.Add(main);
								num3 = 7;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
								{
									num3 = 2;
								}
								continue;
							case 4:
								list.Add((IWorkflowTaskBase)task);
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								goto IL_013e;
							case 2:
								return list;
							}
							break;
						}
						goto IL_00e6;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 2;
						goto IL_017e;
					}
					goto IL_0194;
					IL_017e:
					switch (num4)
					{
					case 2:
						goto end_IL_0169;
					case 1:
						goto end_IL_0169;
					}
					goto IL_0194;
					IL_0194:
					qFrDqIPy9yOEcf8Uhud(enumerator);
					num4 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
					{
						num4 = 1;
					}
					goto IL_017e;
					end_IL_0169:;
				}
			default:
				return list;
			case 2:
			{
				IList source = base.TransformList(collection);
				hashSet = new HashSet<long>();
				list = new List<IWorkflowTaskBase>();
				enumerator = source.OfType<MainTaskWithChild>().GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	internal static bool oeIc7ePJ7harQ6sjje0()
	{
		return Rwx3WqPsCg09jY4Pkmi == null;
	}

	internal static WorkflowTaskWithSubtasksTransformer BrDu4cPlrC1TDHO4Aoo()
	{
		return Rwx3WqPsCg09jY4Pkmi;
	}

	internal static object F4LcObP0sFyajmOWPm6(object P_0)
	{
		return ((MainTaskWithChild)P_0).ChildTask;
	}

	internal static void qFrDqIPy9yOEcf8Uhud(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
