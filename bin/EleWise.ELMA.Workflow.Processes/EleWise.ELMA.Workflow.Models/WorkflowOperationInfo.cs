using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagrams;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models;

public class WorkflowOperationInfo
{
	private static WorkflowOperationInfo PgOjbCtN8apBll2Bfgm;

	public string ElementName
	{
		get
		{
			//Discarded unreachable code: IL_006c, IL_007b, IL_008c, IL_00c5, IL_00d4
			int num = 4;
			Element element = default(Element);
			while (true)
			{
				int num2 = num;
				object obj;
				while (true)
				{
					switch (num2)
					{
					case 3:
						if (rFEfrXtSJYBg9cjRjSW(ElementUid, Guid.Empty))
						{
							num2 = 5;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 == 0)
							{
								num2 = 5;
							}
							continue;
						}
						goto case 1;
					case 1:
						obj = null;
						break;
					case 2:
						if (element != null)
						{
							num2 = 6;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b54291e8d6924fb3b3fee419f778cbd9 == 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto default;
					default:
						return string.Empty;
					case 6:
						return (string)NK6dBWtbWAg0XvdE1jh(element);
					case 4:
						if (Instance != null)
						{
							num2 = 3;
							continue;
						}
						goto case 1;
					case 5:
						obj = ((IEnumerable<Element>)Eu4Mrktk7FHFuTwK4Ej(Instance.Process.Diagram)).FirstOrDefault((Element e) => fnlFV7tApdj15ZV23gI(uFr6oVtmwmluwV7Wo8t(e), ElementUid));
						break;
					}
					break;
				}
				element = (Element)obj;
				num = 2;
			}
		}
	}

	public Guid ElementUid
	{
		[CompilerGenerated]
		get
		{
			return _003CElementUid_003Ek__BackingField;
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
					_003CElementUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb != 0)
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

	public IWorkflowInstance Instance
	{
		[CompilerGenerated]
		get
		{
			return _003CInstance_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CInstance_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowOperationInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nXPAIvtUP1Em6HGVKLK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rFEfrXtSJYBg9cjRjSW(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object Eu4Mrktk7FHFuTwK4Ej(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object NK6dBWtbWAg0XvdE1jh(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static bool Il3cqstdps4wY3EIfhi()
	{
		return PgOjbCtN8apBll2Bfgm == null;
	}

	internal static WorkflowOperationInfo DP5WBmtjtRvmU0xckdk()
	{
		return PgOjbCtN8apBll2Bfgm;
	}

	internal static void nXPAIvtUP1Em6HGVKLK()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static Guid uFr6oVtmwmluwV7Wo8t(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static bool fnlFV7tApdj15ZV23gI(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
