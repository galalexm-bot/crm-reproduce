using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Validation;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.DTO.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scripts;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Models;

[Serializable]
[ProcessValidator(typeof(BPMNProcessValidator))]
public class WorkflowProcessDTO : EntityDTO<long>, IMetadata, IXsiType
{
	[NonSerialized]
	private WorkflowProcessDTO parent;

	internal static WorkflowProcessDTO I1IbKZrzS4EVwuPq0UN;

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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual Guid ModuleUid
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleUid_003Ek__BackingField;
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
					_003CModuleUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
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

	[DefaultValue(false)]
	public virtual bool Internal
	{
		[CompilerGenerated]
		get
		{
			return _003CInternal_003Ek__BackingField;
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
					_003CInternal_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
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

	public MetadataAccessLevel AccessLevel
	{
		[CompilerGenerated]
		get
		{
			return _003CAccessLevel_003Ek__BackingField;
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
					_003CAccessLevel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ProcessHeaderDTO Header
	{
		[CompilerGenerated]
		get
		{
			return _003CHeader_003Ek__BackingField;
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
					_003CHeader_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
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

	public WorkflowDiagram Diagram
	{
		[CompilerGenerated]
		get
		{
			return _003CDiagram_003Ek__BackingField;
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
					_003CDiagram_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
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

	public ProcessContext Context
	{
		[CompilerGenerated]
		get
		{
			return _003CContext_003Ek__BackingField;
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
					_003CContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
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

	public ScriptModuleDTO ClientScriptModule
	{
		[CompilerGenerated]
		get
		{
			return _003CClientScriptModule_003Ek__BackingField;
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
					_003CClientScriptModule_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ScriptModuleDTO ScriptModule
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptModule_003Ek__BackingField;
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
					_003CScriptModule_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
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

	public long ParentId
	{
		[CompilerGenerated]
		get
		{
			return _003CParentId_003Ek__BackingField;
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
					_003CParentId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowProcessDTO Parent
	{
		get
		{
			//Discarded unreachable code: IL_0088, IL_0097
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (parent == null)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				case 3:
					if (ParentId > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				case 2:
					return parent;
				default:
					return parent;
				case 1:
					parent = (WorkflowProcessDTO)deUiCEeYZtI5ODhNFrc(Locator.GetServiceNotNull<IWorkflowProcessDTOManager>(), ParentId);
					num2 = 2;
					break;
				}
			}
		}
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
					parent = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ProcessContextViewScheme ContextViewScheme
	{
		[CompilerGenerated]
		get
		{
			return _003CContextViewScheme_003Ek__BackingField;
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
					_003CContextViewScheme_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
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

	public InstanceNamingScheme NamingScheme
	{
		[CompilerGenerated]
		get
		{
			return _003CNamingScheme_003Ek__BackingField;
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
					_003CNamingScheme_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
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

	public ProcessInstanceMetricsContainer InstanceMetrics
	{
		[CompilerGenerated]
		get
		{
			return _003CInstanceMetrics_003Ek__BackingField;
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
					_003CInstanceMetrics_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
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

	public ProcessMetricsContainer ProcessMetrics
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessMetrics_003Ek__BackingField;
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
					_003CProcessMetrics_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid StatusContextVar
	{
		[CompilerGenerated]
		get
		{
			return _003CStatusContextVar_003Ek__BackingField;
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
					_003CStatusContextVar_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool ShowWarningMetric
	{
		[CompilerGenerated]
		get
		{
			return _003CShowWarningMetric_003Ek__BackingField;
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
					_003CShowWarningMetric_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
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

	public bool ShowProblemMetric
	{
		[CompilerGenerated]
		get
		{
			return _003CShowProblemMetric_003Ek__BackingField;
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
					_003CShowProblemMetric_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool ShowGoodMetric
	{
		[CompilerGenerated]
		get
		{
			return _003CShowGoodMetric_003Ek__BackingField;
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
					_003CShowGoodMetric_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
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

	public ShowIndicatorMode ShowIndicatorMode
	{
		[CompilerGenerated]
		get
		{
			return _003CShowIndicatorMode_003Ek__BackingField;
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
					_003CShowIndicatorMode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ProcessRegulation Regulation
	{
		[CompilerGenerated]
		get
		{
			return _003CRegulation_003Ek__BackingField;
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
					_003CRegulation_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid StatusTerminateActionUid
	{
		[CompilerGenerated]
		get
		{
			return _003CStatusTerminateActionUid_003Ek__BackingField;
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
					_003CStatusTerminateActionUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string StatusTerminateScript
	{
		[CompilerGenerated]
		get
		{
			return _003CStatusTerminateScript_003Ek__BackingField;
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
					_003CStatusTerminateScript_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
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

	public WorkflowFormsContainer Forms
	{
		[CompilerGenerated]
		get
		{
			return _003CForms_003Ek__BackingField;
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
					_003CForms_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool? NoReassignAffectsUserReplace { get; set; }

	public WorkflowProcessDTO()
	{
		//Discarded unreachable code: IL_001e
		m6Wu89eZ56vZXFZhwgC();
		base._002Ector();
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				ContextViewScheme = new ProcessContextViewScheme();
				num2 = 3;
				break;
			case 4:
				Regulation = new ProcessRegulation();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				return;
			case 5:
				Header = new ProcessHeaderDTO();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				NamingScheme = new InstanceNamingScheme();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Forms = new WorkflowFormsContainer();
				num2 = 6;
				break;
			default:
				Context = new ProcessContext();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeModuleUid()
	{
		return kfliNyevAM2aWyvJMiv(ModuleUid, Guid.Empty);
	}

	public virtual void CopyIdsFrom([CanBeNull] WorkflowProcessDTO dto)
	{
		//Discarded unreachable code: IL_008a, IL_0099, IL_00e4, IL_00f3
		int num = 15;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (ProcessMetrics == null)
				{
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			case 6:
				if (Context != null)
				{
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 11;
			case 13:
				return;
			case 11:
				if (InstanceMetrics != null)
				{
					num2 = 16;
					break;
				}
				goto case 1;
			case 5:
			case 12:
				if (ScriptModule == null)
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			case 4:
			case 10:
				if (ClientScriptModule == null)
				{
					return;
				}
				num2 = 9;
				break;
			case 15:
				base.Id = dto?.Id ?? 0;
				num2 = 14;
				break;
			case 14:
				Uid = ((dto != null) ? hx3ovSes7KW6EO37cuX(dto) : HZLosCe87RgLRQlGdFG());
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
				{
					num2 = 6;
				}
				break;
			case 7:
				CopyContextIdsFrom(Context, (EntityMetadata)((dto != null) ? dvFDvpeJ0ASRqQTYPTr(dto) : null));
				num2 = 11;
				break;
			case 16:
				CopyContextIdsFrom(InstanceMetrics, dto?.InstanceMetrics);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
				{
					num2 = 1;
				}
				break;
			default:
				CopyContextIdsFrom(ProcessMetrics, (EntityMetadata)((dto != null) ? dao6evelSVa4YWlMxhU(dto) : null));
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				ScriptModule.Id = ((dto != null && VaJ7EOe0iD3E4mHCQOR(dto) != null) ? ((EntityDTO<long>)VaJ7EOe0iD3E4mHCQOR(dto)).Id : 0);
				num2 = 2;
				break;
			case 2:
				Jx8yrJemI83ZhfUMTJk(ScriptModule, (dto != null && dto.ScriptModule != null) ? clxRYfeyZBlTFhHSIfq(VaJ7EOe0iD3E4mHCQOR(dto)) : Guid.NewGuid());
				num2 = 10;
				break;
			case 9:
				ClientScriptModule.Id = ((dto != null && hcO5f3et1VCjxMxmThl(dto) != null) ? ((EntityDTO<long>)hcO5f3et1VCjxMxmThl(dto)).Id : 0);
				num2 = 8;
				break;
			case 8:
				Jx8yrJemI83ZhfUMTJk(ClientScriptModule, (dto != null && hcO5f3et1VCjxMxmThl(dto) != null) ? clxRYfeyZBlTFhHSIfq(hcO5f3et1VCjxMxmThl(dto)) : HZLosCe87RgLRQlGdFG());
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
				{
					num2 = 13;
				}
				break;
			}
		}
	}

	public override void CopyChanges(EntityDTO<long> saved)
	{
		Contract.ArgumentNotNull(saved, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x75924E8));
		Contract.CheckArgument(saved is WorkflowProcessDTO, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x628031D2));
		base.CopyChanges(saved);
		WorkflowProcessDTO workflowProcessDTO = (WorkflowProcessDTO)saved;
		if (Header != null)
		{
			Header.CopyChanges(workflowProcessDTO.Header);
		}
		if (Context != null)
		{
			Context.Id = workflowProcessDTO.Context.Id;
			for (int i = 0; i < Context.Properties.Count; i++)
			{
				Context.Properties[i].Id = workflowProcessDTO.Context.Properties[i].Id;
			}
		}
		if (InstanceMetrics != null)
		{
			InstanceMetrics.Id = workflowProcessDTO.InstanceMetrics.Id;
			for (int j = 0; j < InstanceMetrics.Properties.Count; j++)
			{
				InstanceMetrics.Properties[j].Id = workflowProcessDTO.InstanceMetrics.Properties[j].Id;
			}
		}
		if (ProcessMetrics != null)
		{
			ProcessMetrics.Id = workflowProcessDTO.ProcessMetrics.Id;
			for (int k = 0; k < ProcessMetrics.Properties.Count; k++)
			{
				ProcessMetrics.Properties[k].Id = workflowProcessDTO.ProcessMetrics.Properties[k].Id;
			}
		}
		if (ScriptModule != null && workflowProcessDTO != null && workflowProcessDTO.ScriptModule != null)
		{
			ScriptModule.Id = workflowProcessDTO.ScriptModule.Id;
		}
		if (ClientScriptModule != null && workflowProcessDTO != null && workflowProcessDTO.ClientScriptModule != null)
		{
			ClientScriptModule.Id = workflowProcessDTO.ClientScriptModule.Id;
		}
		Regulation = workflowProcessDTO.Regulation;
	}

	public virtual void InitNew()
	{
		//Discarded unreachable code: IL_00a6, IL_00b5
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					meOI2oebgFAD5sTjcRf(Context, Guid.NewGuid());
					num2 = 8;
					continue;
				case 10:
					Context.CreateAndCheckDefaultProperties();
					num2 = 3;
					continue;
				case 0:
					return;
				case 8:
					break;
				case 9:
					Regulation = new ProcessRegulation();
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					lVVa21eBYvY8u2Ekx6r(InstanceMetrics);
					num2 = 6;
					continue;
				case 7:
					Forms = new WorkflowFormsContainer();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (InstanceMetrics == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 1;
				case 5:
					Uid = Guid.NewGuid();
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
				case 6:
				{
					ScriptModuleDTO scriptModuleDTO = new ScriptModuleDTO();
					Jx8yrJemI83ZhfUMTJk(scriptModuleDTO, HZLosCe87RgLRQlGdFG());
					FNPT6Kec8DBcJ7ewrNx(scriptModuleDTO, ProcessScriptModuleType.UID);
					scriptModuleDTO.ObjectUid = Uid;
					ScriptModule = scriptModuleDTO;
					num2 = 9;
					continue;
				}
				}
				break;
			}
			t64cE1egEXRVUowjUut(Context, rTub0Qe5nUoYe9p0WBW(-495296780 ^ -495260050));
			num = 10;
		}
	}

	public void AfterLoad()
	{
		//Discarded unreachable code: IL_00bb, IL_00ca, IL_02b8, IL_02c7
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (!FKcfSxeDnMnUEbI1Xgk(lcjhvceuBn4eOEi7Ocu(ProcessMetrics)))
				{
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
					{
						num2 = 13;
					}
					continue;
				}
				break;
			case 10:
				if (!string.IsNullOrEmpty(InstanceMetrics.Name))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				goto case 9;
			case 11:
				IJvHqDennxEoYVk6CuT(InstanceMetrics, GetProcessTableName((string)lcjhvceuBn4eOEi7Ocu(Context), (string)rTub0Qe5nUoYe9p0WBW(0x12F686A ^ 0x12FC71A)));
				num2 = 4;
				continue;
			case 4:
				if (ProcessMetrics != null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			default:
				if (InstanceMetrics != null)
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
					{
						num2 = 12;
					}
					continue;
				}
				goto case 4;
			case 9:
				mMNFsjed2uYWqnUnJoQ(InstanceMetrics, GetProcessClassName((string)Wn0B1WeXBb8r78dCbJE(Context), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980607148)));
				num2 = 3;
				continue;
			case 1:
				SaJdvjePf2XgACt9lnU(Context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
				{
					num2 = 0;
				}
				continue;
			case 13:
				return;
			case 14:
				return;
			case 7:
				mMNFsjed2uYWqnUnJoQ(ProcessMetrics, GetProcessClassName((string)Wn0B1WeXBb8r78dCbJE(Context), (string)rTub0Qe5nUoYe9p0WBW(0x2ACCDD87 ^ 0x2ACC7299)));
				num2 = 5;
				continue;
			case 12:
				InstanceMetrics.CreateAndCheckDefaultProperties();
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num2 = 10;
				}
				continue;
			case 3:
			case 8:
				if (FKcfSxeDnMnUEbI1Xgk(lcjhvceuBn4eOEi7Ocu(InstanceMetrics)))
				{
					num2 = 11;
					continue;
				}
				goto case 4;
			case 2:
				if (FKcfSxeDnMnUEbI1Xgk(Wn0B1WeXBb8r78dCbJE(ProcessMetrics)))
				{
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
					{
						num2 = 7;
					}
					continue;
				}
				goto case 5;
			case 6:
				break;
			}
			IJvHqDennxEoYVk6CuT(ProcessMetrics, GetProcessTableName((string)lcjhvceuBn4eOEi7Ocu(Context), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74ABE809)));
			num2 = 4;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
			{
				num2 = 14;
			}
		}
	}

	private string GetProcessClassName(string contextName, string postfix = "_IM")
	{
		//Discarded unreachable code: IL_0070, IL_007f, IL_0128, IL_0137
		int num = 2;
		int num2 = num;
		string text = default(string);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				text = contextName.ToTranslitIdent("", 25) + postfix;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return text;
			default:
				text = (string)hTYMQaeLrAZofwWN57I(YjsVMYeHVG7jAq6j2sL(contextName, "", 25 - num3.ToString().Length), num3.ToString(), postfix);
				num2 = 4;
				break;
			case 4:
				num3++;
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
				{
					num2 = 3;
				}
				break;
			case 6:
			case 7:
			{
				if (!Locator.GetServiceNotNull<IProcessHeaderDTOManager>().CheckProcessClassName(Header.Id, bXGL7weffo5PkP3xQl9(Header), text, out var _))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 3;
			}
			case 1:
				num3 = 1;
				num2 = 6;
				break;
			}
		}
	}

	private string GetProcessTableName(string contextName, string postfix = "_IM")
	{
		//Discarded unreachable code: IL_00e3, IL_00f2
		int num = 3;
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					num3 = 1;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					text = (string)hTYMQaeLrAZofwWN57I(YjsVMYeHVG7jAq6j2sL(contextName, "", 25 - wsRqQteWw025hZB1U1d(num3.ToString())), num3.ToString(), postfix);
					num2 = 6;
					continue;
				case 5:
					return text;
				case 6:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
					{
						num2 = 1;
					}
					continue;
				default:
				{
					if (Locator.GetServiceNotNull<IProcessHeaderDTOManager>().CheckProcessTableName(Header.Id, bXGL7weffo5PkP3xQl9(Header), text, out var _))
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				}
				case 3:
					break;
				}
				break;
			}
			text = (string)CVY7MFe9Nkk3KM9Hg22(YjsVMYeHVG7jAq6j2sL(contextName, "", 25), postfix);
			num = 2;
		}
	}

	private void CopyContextIdsFrom(EntityMetadata target, EntityMetadata source)
	{
		//Discarded unreachable code: IL_004e, IL_005d, IL_009c, IL_00ed, IL_01ae, IL_01c1, IL_01d0, IL_0229, IL_0238, IL_02c3, IL_0355, IL_03ae, IL_03c1, IL_03d0
		int num = 2;
		List<PropertyMetadata>.Enumerator enumerator2 = default(List<PropertyMetadata>.Enumerator);
		_003C_003Ec__DisplayClass116_0 _003C_003Ec__DisplayClass116_2 = default(_003C_003Ec__DisplayClass116_0);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		_003C_003Ec__DisplayClass116_1 _003C_003Ec__DisplayClass116_ = default(_003C_003Ec__DisplayClass116_1);
		TablePartMetadata source2 = default(TablePartMetadata);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					try
					{
						while (true)
						{
							int num6;
							if (!enumerator2.MoveNext())
							{
								num6 = 6;
								goto IL_006c;
							}
							goto IL_00c7;
							IL_006c:
							while (true)
							{
								object obj2;
								switch (num6)
								{
								case 4:
									obj2 = null;
									goto IL_0137;
								case 1:
									if (source != null)
									{
										num6 = 3;
										continue;
									}
									goto case 4;
								case 2:
									break;
								default:
									goto IL_00c7;
								case 5:
									_003C_003Ec__DisplayClass116_2.p = enumerator2.Current;
									num6 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
									{
										num6 = 1;
									}
									continue;
								case 3:
									obj2 = source.Properties.FirstOrDefault(_003C_003Ec__DisplayClass116_2._003CCopyContextIdsFrom_003Eb__0);
									goto IL_0137;
								case 7:
								{
									_003C_003Ec__DisplayClass116_2.p.Id = propertyMetadata2?.Id ?? 0;
									int num7 = 2;
									num6 = num7;
									continue;
								}
								case 6:
									goto end_IL_00b1;
									IL_0137:
									propertyMetadata2 = (PropertyMetadata)obj2;
									num6 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
									{
										num6 = 4;
									}
									continue;
								}
								break;
							}
							continue;
							IL_00c7:
							_003C_003Ec__DisplayClass116_2 = new _003C_003Ec__DisplayClass116_0();
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
							{
								num6 = 5;
							}
							goto IL_006c;
							continue;
							end_IL_00b1:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 6;
				case 10:
					if (mkhI2leREqneMjcnQ7J(target) != null)
					{
						num2 = 3;
						continue;
					}
					return;
				case 9:
					enumerator2 = target.Properties.GetEnumerator();
					num2 = 4;
					continue;
				case 7:
					return;
				case 5:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 6;
								goto IL_0247;
							}
							goto IL_032e;
							IL_0247:
							while (true)
							{
								object obj;
								int num4;
								switch (num3)
								{
								case 2:
									break;
								case 1:
									_003C_003Ec__DisplayClass116_.tp.Properties.First(_003C_003Ec__DisplayClass116_._003CCopyContextIdsFrom_003Eb__1).SubTypeUid = target.Uid;
									num3 = 5;
									continue;
								case 3:
									CopyContextIdsFrom(_003C_003Ec__DisplayClass116_.tp, source2);
									num3 = 2;
									continue;
								case 5:
									if (source != null)
									{
										num3 = 5;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
										{
											num3 = 7;
										}
										continue;
									}
									goto case 8;
								case 4:
									_003C_003Ec__DisplayClass116_.tp = enumerator.Current;
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
									{
										num3 = 1;
									}
									continue;
								default:
									goto IL_032e;
								case 8:
									obj = null;
									goto IL_0372;
								case 7:
									obj = source.TableParts.FirstOrDefault(_003C_003Ec__DisplayClass116_._003CCopyContextIdsFrom_003Eb__2);
									goto IL_0372;
								case 6:
									goto end_IL_0275;
									IL_0372:
									source2 = (TablePartMetadata)obj;
									num4 = 3;
									num3 = num4;
									continue;
								}
								break;
							}
							continue;
							IL_032e:
							_003C_003Ec__DisplayClass116_ = new _003C_003Ec__DisplayClass116_1();
							num3 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
							{
								num3 = 0;
							}
							goto IL_0247;
							continue;
							end_IL_0275:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 10;
				case 6:
					enumerator = target.TableParts.GetEnumerator();
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num2 = 3;
					}
					continue;
				case 8:
					if (propertyMetadata == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					target.Id = source?.Id ?? 0;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					target.Uid = ((source != null) ? goL54XejJJiUx0hmuNR(source) : Guid.NewGuid());
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
					{
						num2 = 9;
					}
					continue;
				case 3:
					propertyMetadata = ((ClassMetadata)mkhI2leREqneMjcnQ7J(target)).Properties.Find((PropertyMetadata property) => (string)_003C_003Ec.o8v1CuZrtVeFQmLCeZ7B(property) == (string)_003C_003Ec.YI6FKhZrbF2exbErSssE(-1965291699 ^ -1965179943));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
			L91xvLe6o0GuSF9U0rm(propertyMetadata, goL54XejJJiUx0hmuNR(target));
			num = 7;
		}
	}

	public void ReplaceContextVar(Dictionary<Guid, Guid> ReplaceContextVar)
	{
		Guid value = Guid.Empty;
		if (ReplaceContextVar.TryGetValue(StatusContextVar, out value))
		{
			StatusContextVar = value;
		}
	}

	internal static void m6Wu89eZ56vZXFZhwgC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool vaRK3MeKw9GWxi5jlLX()
	{
		return I1IbKZrzS4EVwuPq0UN == null;
	}

	internal static WorkflowProcessDTO mT9oTreO5im1P7pNMCF()
	{
		return I1IbKZrzS4EVwuPq0UN;
	}

	internal static bool kfliNyevAM2aWyvJMiv(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object deUiCEeYZtI5ODhNFrc(object P_0, long id)
	{
		return ((IWorkflowProcessDTOManager)P_0).LoadOrNull(id);
	}

	internal static Guid HZLosCe87RgLRQlGdFG()
	{
		return Guid.NewGuid();
	}

	internal static Guid hx3ovSes7KW6EO37cuX(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Uid;
	}

	internal static object dvFDvpeJ0ASRqQTYPTr(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Context;
	}

	internal static object dao6evelSVa4YWlMxhU(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).ProcessMetrics;
	}

	internal static object VaJ7EOe0iD3E4mHCQOR(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).ScriptModule;
	}

	internal static Guid clxRYfeyZBlTFhHSIfq(object P_0)
	{
		return ((ScriptModuleDTO)P_0).Uid;
	}

	internal static void Jx8yrJemI83ZhfUMTJk(object P_0, Guid P_1)
	{
		((ScriptModuleDTO)P_0).Uid = P_1;
	}

	internal static object hcO5f3et1VCjxMxmThl(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).ClientScriptModule;
	}

	internal static void meOI2oebgFAD5sTjcRf(object P_0, Guid P_1)
	{
		((AbstractMetadata)P_0).Uid = P_1;
	}

	internal static object rTub0Qe5nUoYe9p0WBW(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void t64cE1egEXRVUowjUut(object P_0, object P_1)
	{
		((ClassMetadata)P_0).Namespace = (string)P_1;
	}

	internal static void lVVa21eBYvY8u2Ekx6r(object P_0)
	{
		((ProcessInstanceMetricsContainer)P_0).CreateAndCheckDefaultProperties();
	}

	internal static void FNPT6Kec8DBcJ7ewrNx(object P_0, Guid P_1)
	{
		((ScriptModuleDTO)P_0).ModuleTypeUid = P_1;
	}

	internal static void SaJdvjePf2XgACt9lnU(object P_0)
	{
		((ProcessContext)P_0).CreateAndCheckDefaultProperties();
	}

	internal static object Wn0B1WeXBb8r78dCbJE(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void mMNFsjed2uYWqnUnJoQ(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static object lcjhvceuBn4eOEi7Ocu(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static bool FKcfSxeDnMnUEbI1Xgk(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void IJvHqDennxEoYVk6CuT(object P_0, object P_1)
	{
		((EntityMetadata)P_0).TableName = (string)P_1;
	}

	internal static object YjsVMYeHVG7jAq6j2sL(object P_0, object P_1, int P_2)
	{
		return ((string)P_0).ToTranslitIdent((string)P_1, P_2);
	}

	internal static object hTYMQaeLrAZofwWN57I(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static long bXGL7weffo5PkP3xQl9(object P_0)
	{
		return ((ProcessHeaderDTO)P_0).ParentId;
	}

	internal static object CVY7MFe9Nkk3KM9Hg22(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int wsRqQteWw025hZB1U1d(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static Guid goL54XejJJiUx0hmuNR(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object mkhI2leREqneMjcnQ7J(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static void L91xvLe6o0GuSF9U0rm(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).SubTypeUid = P_1;
	}
}
