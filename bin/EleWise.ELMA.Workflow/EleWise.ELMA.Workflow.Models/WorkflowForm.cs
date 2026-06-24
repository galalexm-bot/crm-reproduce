using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.DTO.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models;

[Serializable]
[Component]
public abstract class WorkflowForm : IXsiType
{
	private static WorkflowForm wMp88KOn3ahkOYt5kv3C;

	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid ParentFormUid
	{
		[CompilerGenerated]
		get
		{
			return _003CParentFormUid_003Ek__BackingField;
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
					_003CParentFormUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
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

	public string FormName
	{
		[CompilerGenerated]
		get
		{
			return _003CFormName_003Ek__BackingField;
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
					_003CFormName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
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

	public string FormDisplayName
	{
		[CompilerGenerated]
		get
		{
			return _003CFormDisplayName_003Ek__BackingField;
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
					_003CFormDisplayName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public abstract FormViewItem CreateFormViewItem(IWorkflowProcess process);

	internal abstract FormViewItem CreateFormViewItem(WorkflowProcessDTO process);

	public override string ToString()
	{
		return FormDisplayName;
	}

	protected WorkflowForm()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool SFBIIROnT8e6WOTmLcMy()
	{
		return wMp88KOn3ahkOYt5kv3C == null;
	}

	internal static WorkflowForm F1xu1EOnQPjVugLhPvmu()
	{
		return wMp88KOn3ahkOYt5kv3C;
	}
}
