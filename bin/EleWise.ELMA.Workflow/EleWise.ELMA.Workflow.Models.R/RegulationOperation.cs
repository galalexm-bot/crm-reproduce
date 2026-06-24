using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagrams;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.Regulation;

public class RegulationOperation
{
	internal static RegulationOperation MPJLSGOkBAncATMoNZxX;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
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

	public string GroupName
	{
		[CompilerGenerated]
		get
		{
			return _003CGroupName_003Ek__BackingField;
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
					_003CGroupName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
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

	public List<RegulationInputOutput> Inputs { get; set; }

	public List<RegulationInputOutput> ExternalInputs { get; set; }

	public List<RegulationInputOutput> InternalInputs { get; set; }

	public List<RegulationInputOutput> ExternalOutputs { get; set; }

	public List<RegulationInputOutput> InternalOutputs { get; set; }

	public List<RegulationInputOutput> Outputs { get; set; }

	public string Executor
	{
		[CompilerGenerated]
		get
		{
			return _003CExecutor_003Ek__BackingField;
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
					_003CExecutor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
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
				case 0:
					return;
				case 1:
					_003CDescription_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long Number
	{
		[CompilerGenerated]
		get
		{
			return _003CNumber_003Ek__BackingField;
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
					_003CNumber_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
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

	public string TimeOfExecution
	{
		[CompilerGenerated]
		get
		{
			return _003CTimeOfExecution_003Ek__BackingField;
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
					_003CTimeOfExecution_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
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

	public List<Connector> Connectors { get; set; }

	public List<string> FlowsConnectors { get; set; }

	public List<long> NumbersOfEndElement { get; set; }

	public List<Element> Artifacts { get; set; }

	public List<string> NumbersOfArtifact { get; set; }

	public RegulationOperation()
	{
		//Discarded unreachable code: IL_001a
		b9AleGOkXirn0fwGGQNS();
		base._002Ector();
		int num = 5;
		while (true)
		{
			int num2;
			switch (num)
			{
			case 5:
				Name = "";
				num = 15;
				break;
			case 2:
				FlowsConnectors = new List<string>();
				num = 14;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
				{
					num = 7;
				}
				break;
			case 3:
				Outputs = new List<RegulationInputOutput>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
				{
					num = 0;
				}
				break;
			case 11:
				InternalInputs = new List<RegulationInputOutput>();
				num = 10;
				break;
			case 7:
				Inputs = new List<RegulationInputOutput>();
				num = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
				{
					num = 5;
				}
				break;
			case 4:
				TimeOfExecution = "";
				num = 7;
				break;
			case 6:
				Artifacts = new List<Element>();
				num = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
				{
					num = 5;
				}
				break;
			default:
				Number = 0L;
				num = 2;
				break;
			case 13:
				Connectors = new List<Connector>();
				num = 6;
				break;
			case 10:
				ExternalOutputs = new List<RegulationInputOutput>();
				num = 12;
				break;
			case 12:
				InternalOutputs = new List<RegulationInputOutput>();
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
				{
					num = 3;
				}
				break;
			case 9:
				ExternalInputs = new List<RegulationInputOutput>();
				num = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
				{
					num = 2;
				}
				break;
			case 15:
				GroupName = "";
				num2 = 4;
				goto IL_001f;
			case 1:
				return;
			case 14:
				NumbersOfEndElement = new List<long>();
				num2 = 13;
				goto IL_001f;
			case 8:
				{
					NumbersOfArtifact = new List<string>();
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
					{
						num = 1;
					}
					break;
				}
				IL_001f:
				num = num2;
				break;
			}
		}
	}

	internal static void b9AleGOkXirn0fwGGQNS()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool k1oNpOOkcDapxs3guaL6()
	{
		return MPJLSGOkBAncATMoNZxX == null;
	}

	internal static RegulationOperation g47LsLOkPRa4HeF1cfIc()
	{
		return MPJLSGOkBAncATMoNZxX;
	}
}
