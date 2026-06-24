using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagrams;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models;

public class WorkflowMessageBookmarkInfo
{
	private static WorkflowMessageBookmarkInfo Cvbp79qng5HgRdHsa1r;

	public long Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
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
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b == 0)
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
				case 1:
					_003CInstance_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2d82a778b0ee4fc0915a368d2259a8f3 == 0)
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
				case 0:
					return;
				case 1:
					_003CElementUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DateTime? CreationDate { get; set; }

	public IWorkflowMessageType MessageType
	{
		[CompilerGenerated]
		get
		{
			return _003CMessageType_003Ek__BackingField;
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
					_003CMessageType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ControlParameterValue
	{
		[CompilerGenerated]
		get
		{
			return _003CControlParameterValue_003Ek__BackingField;
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
					_003CControlParameterValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_91adcac8aa2043159a205c4a9f0e85fa != 0)
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

	public string ElementName
	{
		get
		{
			//Discarded unreachable code: IL_0039, IL_0048, IL_0059
			int num = 4;
			int num2 = num;
			Element element = default(Element);
			while (true)
			{
				object obj;
				switch (num2)
				{
				default:
					obj = null;
					break;
				case 4:
					if (Instance == null)
					{
						num2 = 3;
						continue;
					}
					goto case 5;
				case 5:
					if (!LfAAsNq69pbZO7Gn3mO(ElementUid, Guid.Empty))
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bce36a95fd341dfb7b4178ccc0544f2 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = ((IEnumerable<Element>)fvnwdDqBYPQTSru2C4H(rkV0I1q0tyT6LQgi8Uc(TE7OnaqReAAMiRiTNVN(Instance)))).FirstOrDefault((Element e) => JZaBgoqewSIg7NIVx2T(e.Uid, ElementUid));
					break;
				case 2:
					if (element == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					return (string)AWqVn2qW9GODi8D2DMD(element);
				case 1:
					return string.Empty;
				}
				element = (Element)obj;
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 == 0)
				{
					num2 = 2;
				}
			}
		}
	}

	public WorkflowMessageBookmarkInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RwphEcqHgUYsCouEyVA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Md2TCcqyi22tvSe2kNM()
	{
		return Cvbp79qng5HgRdHsa1r == null;
	}

	internal static WorkflowMessageBookmarkInfo a30sy8qOyZw0RrJ7ZFE()
	{
		return Cvbp79qng5HgRdHsa1r;
	}

	internal static bool LfAAsNq69pbZO7Gn3mO(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object TE7OnaqReAAMiRiTNVN(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object rkV0I1q0tyT6LQgi8Uc(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static object fvnwdDqBYPQTSru2C4H(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object AWqVn2qW9GODi8D2DMD(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static void RwphEcqHgUYsCouEyVA()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool JZaBgoqewSIg7NIVx2T(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
