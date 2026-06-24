using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Entities.EntityReferences;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models;

internal class ObservedContextProperty
{
	private static ObservedContextProperty Cf4nUTOPxJW9ZyA2q3Rr;

	public virtual Guid? Type { get; set; }

	public virtual Guid? SubType { get; set; }

	public virtual IProcessHeader ProcessHeader
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeader_003Ek__BackingField;
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
					_003CProcessHeader_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
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

	public virtual IWorkflowInstance WorkflowInstance
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowInstance_003Ek__BackingField;
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
					_003CWorkflowInstance_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
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

	public virtual long ContextId
	{
		[CompilerGenerated]
		get
		{
			return _003CContextId_003Ek__BackingField;
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
					_003CContextId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
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

	public virtual Guid? PropertyUid { get; set; }

	public virtual ReferenceOnEntity Object
	{
		[CompilerGenerated]
		get
		{
			return _003CObject_003Ek__BackingField;
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
					_003CObject_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
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

	public ObservedContextProperty()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		g6iYMPOPhe6BqCwlovpZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ayC1hmOPSWKeDjiESNbX()
	{
		return Cf4nUTOPxJW9ZyA2q3Rr == null;
	}

	internal static ObservedContextProperty L8BPSpOP1fh67io9ybh7()
	{
		return Cf4nUTOPxJW9ZyA2q3Rr;
	}

	internal static void g6iYMPOPhe6BqCwlovpZ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
