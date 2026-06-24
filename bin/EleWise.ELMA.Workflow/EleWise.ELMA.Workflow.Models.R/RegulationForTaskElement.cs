using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.Regulation;

[Serializable]
public class RegulationForTaskElement
{
	private static RegulationForTaskElement S2ol1aOMQ2Y0B7HZTDid;

	public List<RegulationInputOutput> Inputs { get; set; }

	public List<RegulationInputOutput> Outputs { get; set; }

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return _003CDescription_003Ek__BackingField;
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
					_003CDescription_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
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

	public bool MergedFields
	{
		[CompilerGenerated]
		get
		{
			return _003CMergedFields_003Ek__BackingField;
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
					_003CMergedFields_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
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

	public RegulationForTaskElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GFOZrmOMMprLGeyk7mVy();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				Outputs = new List<RegulationInputOutput>();
				num = 2;
				break;
			case 1:
				Inputs = new List<RegulationInputOutput>();
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				Description = "";
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void GFOZrmOMMprLGeyk7mVy()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool LnrdNQOMps8BeH9PyFb7()
	{
		return S2ol1aOMQ2Y0B7HZTDid == null;
	}

	internal static RegulationForTaskElement rDFoUaOMCis4rvMFLRIK()
	{
		return S2ol1aOMQ2Y0B7HZTDid;
	}
}
