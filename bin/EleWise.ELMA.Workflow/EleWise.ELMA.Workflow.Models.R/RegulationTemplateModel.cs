using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Workflow.DTO.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.Regulation;

public class RegulationTemplateModel
{
	private static RegulationTemplateModel bZlvwiOkt5O5xsvHB5Lt;

	public string ProcessName
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessName_003Ek__BackingField;
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
					_003CProcessName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string DateNow
	{
		[CompilerGenerated]
		get
		{
			return _003CDateNow_003Ek__BackingField;
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
					_003CDateNow_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Year
	{
		[CompilerGenerated]
		get
		{
			return _003CYear_003Ek__BackingField;
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
					_003CYear_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string OwnerProcess
	{
		[CompilerGenerated]
		get
		{
			return _003COwnerProcess_003Ek__BackingField;
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
					_003COwnerProcess_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<Image> ImagesDiagram { get; set; }

	public string PostOwner
	{
		[CompilerGenerated]
		get
		{
			return _003CPostOwner_003Ek__BackingField;
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
					_003CPostOwner_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
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

	public bool Landscape
	{
		[CompilerGenerated]
		get
		{
			return _003CLandscape_003Ek__BackingField;
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
					_003CLandscape_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<RegulationNormativeRef> ExternalNormativeRefs { get; set; }

	public List<RegulationNormativeRef> InternalNormativeRefs { get; set; }

	public List<RegulationTerm> Terms { get; set; }

	public List<RegulationInputOutput> Inputs { get; set; }

	public List<RegulationInputOutput> ExternalInputs { get; set; }

	public List<RegulationInputOutput> InternalInputs { get; set; }

	public List<RegulationInputOutput> Outputs { get; set; }

	public List<RegulationInputOutput> ExternalOutputs { get; set; }

	public List<RegulationInputOutput> InternalOutputs { get; set; }

	public List<RegulationCondition> StartConditions { get; set; }

	public List<RegulationCondition> FinishConditions { get; set; }

	public List<RegulationResource> Resources { get; set; }

	public Dictionary<string, List<RegulationResource>> ResourcesByType { get; set; }

	public RegulationHeaderProperties HeaderProperties
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderProperties_003Ek__BackingField;
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
					_003CHeaderProperties_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<ResponsibilityMatrixStr> ResponsibilityMatrix { get; set; }

	public List<RegulationOperation> Operations { get; set; }

	public List<RegulationOperation> Gateways { get; set; }

	public List<RegulationOperation> SubProccess { get; set; }

	public RegulationTemplateDTO Template
	{
		[CompilerGenerated]
		get
		{
			return _003CTemplate_003Ek__BackingField;
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
					_003CTemplate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
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

	public Dictionary<long, string> NumbersElements { get; set; }

	public RegulationTemplateModel()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		DoGQKmOkgC4WQaFc7JjN();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Gateways = new List<RegulationOperation>();
				num = 3;
				break;
			case 3:
				SubProccess = new List<RegulationOperation>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				Operations = new List<RegulationOperation>();
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void DoGQKmOkgC4WQaFc7JjN()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool nObNr0OkbxeSVLP4KRbu()
	{
		return bZlvwiOkt5O5xsvHB5Lt == null;
	}

	internal static RegulationTemplateModel MO0fbiOk5pPPwkIdkWPQ()
	{
		return bZlvwiOkt5O5xsvHB5Lt;
	}
}
