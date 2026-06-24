using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Workflow.BPMN.Diagrams;
using EleWise.ELMA.Workflow.DTO.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.DTO.Models;

[Serializable]
public class BPMNProcessDTO : WorkflowProcessDTO
{
	private static BPMNProcessDTO Ab7m45O78GZ10cVlPITH;

	public List<ResponsibilityMatrixItemDTO> ResponsibilityMatrix { get; set; }

	public BPMNProcessDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				ResponsibilityMatrix = new List<ResponsibilityMatrixItemDTO>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static BPMNProcessDTO New(long groupId = 0L, WorkflowProcessDTO parentProcess = null)
	{
		//Discarded unreachable code: IL_00a1
		int num = 1;
		BPMNProcessDTO bPMNProcessDTO = default(BPMNProcessDTO);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					bPMNProcessDTO.NoReassignAffectsUserReplace = false;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					if (parentProcess != null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 4;
				case 4:
					ccP6lcO7mslIKc8mOqfQ(Dmvd3vO70ohhgOJCAbBM(bPMNProcessDTO), groupId);
					num2 = 6;
					continue;
				case 6:
				case 8:
					return bPMNProcessDTO;
				case 1:
					bPMNProcessDTO = new BPMNProcessDTO();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					bPMNProcessDTO.ParentId = parentProcess?.Id ?? 0;
					num2 = 5;
					continue;
				case 5:
					kfT5l0O7y2cJ7fISnPOe(Dmvd3vO70ohhgOJCAbBM(bPMNProcessDTO), (parentProcess != null) ? ((EntityDTO<long>)Dmvd3vO70ohhgOJCAbBM(parentProcess)).Id : 0);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num2 = 7;
					}
					continue;
				}
				break;
			}
			SlSQLGO7lKfuMOYF55Ou(bPMNProcessDTO);
			num = 3;
		}
	}

	public override void InitNew()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				base.Diagram = new BPMNDiagram();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				base.InitNew();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void CopyIdsFrom([CanBeNull] WorkflowProcessDTO dto)
	{
		//Discarded unreachable code: IL_004c, IL_005b, IL_0066, IL_011a, IL_012d, IL_013c
		int num = 5;
		int num2 = num;
		List<ResponsibilityMatrixItemDTO>.Enumerator enumerator = default(List<ResponsibilityMatrixItemDTO>.Enumerator);
		BPMNProcessDTO bPMNProcessDTO = default(BPMNProcessDTO);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 5:
				base.CopyIdsFrom(dto);
				num2 = 4;
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
							{
								num3 = 0;
							}
							goto IL_006a;
						}
						goto IL_00a6;
						IL_00a6:
						ResponsibilityMatrixItemDTO current = enumerator.Current;
						current.Id = 0L;
						vcbNAdO7tiZnSRkNtF0r(current, bPMNProcessDTO?.Id ?? 0);
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
						{
							num3 = 2;
						}
						goto IL_006a;
						IL_006a:
						switch (num3)
						{
						case 1:
							return;
						case 2:
							break;
						default:
							goto IL_00a6;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 2:
				enumerator = ResponsibilityMatrix.GetEnumerator();
				num2 = 3;
				break;
			default:
				if (ResponsibilityMatrix == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				bPMNProcessDTO = dto as BPMNProcessDTO;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool GS04eGO7s1I93gUsYtKH()
	{
		return Ab7m45O78GZ10cVlPITH == null;
	}

	internal static BPMNProcessDTO nTWSP7O7J86peowJRj3m()
	{
		return Ab7m45O78GZ10cVlPITH;
	}

	internal static void SlSQLGO7lKfuMOYF55Ou(object P_0)
	{
		((WorkflowProcessDTO)P_0).InitNew();
	}

	internal static object Dmvd3vO70ohhgOJCAbBM(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Header;
	}

	internal static void kfT5l0O7y2cJ7fISnPOe(object P_0, long value)
	{
		((ProcessHeaderDTO)P_0).ParentId = value;
	}

	internal static void ccP6lcO7mslIKc8mOqfQ(object P_0, long value)
	{
		((ProcessHeaderDTO)P_0).ParentGroupId = value;
	}

	internal static void vcbNAdO7tiZnSRkNtF0r(object P_0, long value)
	{
		((ResponsibilityMatrixItemDTO)P_0).BPMNProcessId = value;
	}
}
