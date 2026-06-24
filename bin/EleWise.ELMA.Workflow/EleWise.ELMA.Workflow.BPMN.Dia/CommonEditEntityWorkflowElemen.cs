using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;

[Serializable]
public abstract class CommonEditEntityWorkflowElement : BPMNFlowElement, IHintDrawElement, IExceptionFlowSupported, IElementWithView, IElementCheckPublicApplication, IConnectorSettingsExtensionElement, IElementWithOnePropertyMap, IElementWithPropertyMap, ITemplateSetNameElement, ITemplateSetDescriptionElement, ICommonEditEntityWorkflowElement
{
	internal static CommonEditEntityWorkflowElement U5K0ygZZCBVFUaeZCi5X;

	public string TemplateName
	{
		[CompilerGenerated]
		get
		{
			return _003CTemplateName_003Ek__BackingField;
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
					_003CTemplateName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool FormingTemplateDescription
	{
		[CompilerGenerated]
		get
		{
			return _003CFormingTemplateDescription_003Ek__BackingField;
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
					_003CFormingTemplateDescription_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
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

	public string Comment
	{
		[CompilerGenerated]
		get
		{
			return _003CComment_003Ek__BackingField;
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
					_003CComment_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
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

	public bool LimitByWorkLogTime
	{
		[CompilerGenerated]
		get
		{
			return _003CLimitByWorkLogTime_003Ek__BackingField;
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
					_003CLimitByWorkLogTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
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

	public WorkLogTimeOfExecution WorkLogTimeOfExecution
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkLogTimeOfExecution_003Ek__BackingField;
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
					_003CWorkLogTimeOfExecution_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
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

	public bool SelectDocumentForm
	{
		[CompilerGenerated]
		get
		{
			return _003CSelectDocumentForm_003Ek__BackingField;
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
					_003CSelectDocumentForm_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool FormingTemplateName
	{
		[CompilerGenerated]
		get
		{
			return _003CFormingTemplateName_003Ek__BackingField;
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
					_003CFormingTemplateName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
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

	public Guid DocumentFormUid
	{
		[CompilerGenerated]
		get
		{
			return _003CDocumentFormUid_003Ek__BackingField;
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
					_003CDocumentFormUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
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

	public List<Guid> DocumentVars { get; set; }

	public Guid DocumentType
	{
		[CompilerGenerated]
		get
		{
			return _003CDocumentType_003Ek__BackingField;
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
					_003CDocumentType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PropertyMap[] UsingPropertyMap => new PropertyMap[1] { Map };

	public bool DocumentTypeFromVar
	{
		[CompilerGenerated]
		get
		{
			return _003CDocumentTypeFromVar_003Ek__BackingField;
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
					_003CDocumentTypeFromVar_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid DocumentTypeVar
	{
		[CompilerGenerated]
		get
		{
			return _003CDocumentTypeVar_003Ek__BackingField;
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
					_003CDocumentTypeVar_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PropertyMap Map
	{
		[CompilerGenerated]
		get
		{
			return _003CMap_003Ek__BackingField;
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
					_003CMap_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
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

	public bool SilentModeVar
	{
		[CompilerGenerated]
		get
		{
			return _003CSilentModeVar_003Ek__BackingField;
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
					_003CSilentModeVar_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool LimitByTime
	{
		[CompilerGenerated]
		get
		{
			return _003CLimitByTime_003Ek__BackingField;
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
					_003CLimitByTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TimeOfExecution TimeOfExecution
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
				case 0:
					return;
				case 1:
					_003CTimeOfExecution_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public virtual bool MultipleMode => false;

	public bool DenyReassign
	{
		[CompilerGenerated]
		get
		{
			return _003CDenyReassign_003Ek__BackingField;
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
					_003CDenyReassign_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
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

	public bool DenyReplace
	{
		[CompilerGenerated]
		get
		{
			return _003CDenyReplace_003Ek__BackingField;
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
					_003CDenyReplace_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
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

	public override string ChapterName => SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514285706));

	public virtual EventTrigger[] SupportedTriggers => new EventTrigger[2]
	{
		EventTrigger.Timer,
		EventTrigger.Script
	};

	public FormView View
	{
		[CompilerGenerated]
		get
		{
			return _003CView_003Ek__BackingField;
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
					_003CView_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual bool CanCheckPublicApplicationCompatibility => true;

	IList<ConnectorSettingsExtension> IConnectorSettingsExtensionElement.ConnectorSettings
	{
		get
		{
			return ConnectorSettings;
		}
		set
		{
			ConnectorSettings = value.ToList();
		}
	}

	public List<ConnectorSettingsExtension> ConnectorSettings { get; set; }

	Guid ICommonEditEntityWorkflowElement.FormUid
	{
		get
		{
			return DocumentFormUid;
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
					DocumentFormUid = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
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

	bool ICommonEditEntityWorkflowElement.SelectForm
	{
		get
		{
			return SelectDocumentForm;
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
				case 0:
					return;
				case 1:
					SelectDocumentForm = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	List<Guid> ICommonEditEntityWorkflowElement.Vars
	{
		get
		{
			return DocumentVars;
		}
		set
		{
			DocumentVars = value;
		}
	}

	bool ICommonEditEntityWorkflowElement.TypeFromVar
	{
		get
		{
			return DocumentTypeFromVar;
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
				case 0:
					return;
				case 1:
					DocumentTypeFromVar = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	Guid ICommonEditEntityWorkflowElement.TypeVar
	{
		get
		{
			return DocumentTypeVar;
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
					DocumentTypeVar = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
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

	Guid ICommonEditEntityWorkflowElement.Type
	{
		get
		{
			return DocumentType;
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
				case 0:
					return;
				case 1:
					DocumentType = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CommonEditEntityWorkflowElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YgD9rbZZU4lEleK4PPoE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				TimeOfExecution = new TimeOfExecution();
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				ConnectorSettings = new List<ConnectorSettingsExtension>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
				{
					num = 4;
				}
				break;
			case 1:
				return;
			default:
				DocumentVars = new List<Guid>();
				num = 3;
				break;
			case 4:
				WorkLogTimeOfExecution = new WorkLogTimeOfExecution();
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void ReplaceContextVar(Dictionary<Guid, Guid> replaceContextVar)
	{
		_003C_003Ec__DisplayClass77_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass77_0();
		CS_0024_003C_003E8__locals0.replaceContextVar = replaceContextVar;
		base.ReplaceContextVar(CS_0024_003C_003E8__locals0.replaceContextVar);
		CS_0024_003C_003E8__locals0.newDocumentVars = new List<Guid>();
		DocumentVars.ForEach(delegate(Guid item)
		{
			int num = 1;
			int num2 = num;
			Guid valueOrDefault = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					valueOrDefault = CS_0024_003C_003E8__locals0.replaceContextVar.GetValueOrDefault(item, Guid.Empty);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					CS_0024_003C_003E8__locals0.newDocumentVars.Add(_003C_003Ec__DisplayClass77_0.J9OhlHvcHapmN1pcMRYg(valueOrDefault, Guid.Empty) ? valueOrDefault : item);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		});
		DocumentVars = CS_0024_003C_003E8__locals0.newDocumentVars;
		if (CS_0024_003C_003E8__locals0.replaceContextVar.TryGetValue(DocumentTypeVar, out var value))
		{
			DocumentTypeVar = value;
		}
		Map?.ReplaceContextVars(CS_0024_003C_003E8__locals0.replaceContextVar);
		if (CS_0024_003C_003E8__locals0.replaceContextVar.TryGetValue(WorkLogTimeOfExecution.PropertyUid, out value))
		{
			WorkLogTimeOfExecution.PropertyUid = value;
		}
		TimeOfExecution.ReplaceContextVars(CS_0024_003C_003E8__locals0.replaceContextVar);
	}

	public override string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null)
	{
		int num = 1;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return stringBuilder.ToString();
			case 6:
				ztiIs1ZZi6N4GycLM5Uy(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x6280C4E2));
				num2 = 5;
				break;
			case 1:
				stringBuilder = new StringBuilder();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				ztiIs1ZZi6N4GycLM5Uy(stringBuilder, pYUO6bZZV5daYvUxKvdU(-1638225214 ^ -1638346244));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				ztiIs1ZZi6N4GycLM5Uy(stringBuilder, pYUO6bZZV5daYvUxKvdU(-862330810 ^ -862217126));
				num2 = 3;
				break;
			default:
				ztiIs1ZZi6N4GycLM5Uy(stringBuilder, z5vNmrZZFVyhq2WIo1dm(new object[5]
				{
					pYUO6bZZV5daYvUxKvdU(-432000546 ^ -431863098),
					ODgWrdZZ7SNO78GaATi0(BLIsqTZZGHBmjJQUk9oa(Ej8A18ZZAuNhodKRfXpj(this)), "") ? hx2bhIZZ2HRSfybXSI4D(this) : Ej8A18ZZAuNhodKRfXpj(this),
					pYUO6bZZV5daYvUxKvdU(-1657582555 ^ -1657702775),
					hQ4cr7ZZooGVT5k4XNlg(this),
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10266723)
				}));
				num2 = 4;
				break;
			case 2:
				GJbCS8ZZx3BXvTCouitB(stringBuilder, Rwltd1ZZNuQdhstTdCXa(n4pO9OZZaEKAQhUiQccA(pYUO6bZZV5daYvUxKvdU(--1436248540 ^ 0x55991240), txQjugZZIGGfGVK0XvWk(hQ4cr7ZZooGVT5k4XNlg(this).ToString()), pYUO6bZZV5daYvUxKvdU(0x56A753C9 ^ 0x56A52839)), subFolders ? "" : cSIpmSZZekhkSB2o8wMS(UhOp54ZZr4XlWlQyFjlj(context).ToString(), pYUO6bZZV5daYvUxKvdU(-2125897096 ^ -2125770118), "")), Array.Empty<object>());
				num2 = 6;
				break;
			}
		}
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539343189) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x103A2CD)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56FA1CBD) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-961162596 ^ -961040666)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708255390));
		stringBuilder.Append(HtmlBodyInner(element, contexts, orgStructVersion, subFolders, diagram));
		List<IPropertyMetadata> properties = new List<IPropertyMetadata>();
		if (MetadataLoader.LoadMetadata(DocumentType) is EntityMetadata entityMetadata)
		{
			properties = entityMetadata.GetPropertiesAndTableParts().ToList();
		}
		if (Map == null || Map.Items.Count <= 0)
		{
			return stringBuilder.ToString();
		}
		stringBuilder.AppendFormat(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642610307), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498706133))));
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028861977 ^ -1028720241));
		stringBuilder.Append(HTMLUtility.InsertRowToTable(new string[3]
		{
			SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747D86C8)),
			SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197894238)),
			SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B717DD))
		}, isBold: true, null));
		foreach (PropertyMapItem item in Map.Items)
		{
			object property = GetProperty(properties, item.LeftPropertyUid);
			if (property == null)
			{
				continue;
			}
			object obj = null;
			int padding = 0;
			foreach (ProcessContext context in contexts)
			{
				obj = item.RightValue ?? ((object)ProcessDocumentationHelper.GetEntityProperty((IEnumerable<EntityPropertyMetadata>)context.EntityProperties, (IEnumerable<TablePartMetadata>)context.EntityTableParts, item.RightPropertyUid, ref padding)) ?? ((object)ProcessDocumentationHelper.GetTablePart((IEnumerable<TablePartMetadata>)context.EntityTableParts, item.RightPropertyUid, ref padding));
				if (obj != null)
				{
					break;
				}
			}
			ProcessDocumentationHelper.AppendPropertyRow(property, obj, stringBuilder, 0, padding);
		}
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351486982));
		return stringBuilder.ToString();
	}

	private object GetProperty(List<IPropertyMetadata> properties, Guid propertyUid)
	{
		_003C_003Ec__DisplayClass80_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass80_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		IPropertyMetadata propertyMetadata = properties.FirstOrDefault((IPropertyMetadata m) => _003C_003Ec__DisplayClass80_0.j7b1jDvcWfiTWMf0AND8(m.PropertyUid, CS_0024_003C_003E8__locals0.propertyUid));
		if (propertyMetadata == null)
		{
			foreach (TablePartMetadata item in properties.OfType<TablePartMetadata>())
			{
				List<IPropertyMetadata> list = item.Properties.Cast<IPropertyMetadata>().ToList();
				if (list.Count > 2)
				{
					list.RemoveRange(0, 2);
				}
				propertyMetadata = (IPropertyMetadata)GetProperty(list, CS_0024_003C_003E8__locals0.propertyUid);
				if (propertyMetadata != null)
				{
					return propertyMetadata;
				}
			}
			return propertyMetadata;
		}
		return propertyMetadata;
	}

	public override string HtmlFooter()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append((string)sbEZ1SZZ1xfCfSlmGeKw(pYUO6bZZV5daYvUxKvdU(0x42311138 ^ 0x42336C54), cCsANtZZScCrfEKLiKSS(this)));
		ztiIs1ZZi6N4GycLM5Uy(stringBuilder, pYUO6bZZV5daYvUxKvdU(-1498811449 ^ -1498706361));
		return stringBuilder.ToString();
	}

	public override void Validate(WorkflowProcessValidator validator)
	{
		//Discarded unreachable code: IL_00c6, IL_013e, IL_018b, IL_019a, IL_0323, IL_04d4, IL_052a, IL_0539, IL_0548, IL_0558, IL_0567
		int num = 10;
		ClassMetadata classMetadata = default(ClassMetadata);
		List<ClassMetadata> baseClasses = default(List<ClassMetadata>);
		_003C_003Ec__DisplayClass84_0 _003C_003Ec__DisplayClass84_ = default(_003C_003Ec__DisplayClass84_0);
		ClassMetadata classMetadata2 = default(ClassMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 24:
					if (classMetadata != null)
					{
						num2 = 8;
						continue;
					}
					goto case 33;
				case 35:
					base.ValidationHelper.ValidatePropertyExists(validator, QNf7FZZvJPsRKt6W4yWR(TimeOfExecution), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351471572), Ej8A18ZZAuNhodKRfXpj(this)), errorOnEmptyUid: true);
					num2 = 29;
					continue;
				case 27:
					baseClasses.Add(classMetadata);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
					return;
				case 21:
					if (TimeOfExecution == null)
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 23;
				case 1:
				case 4:
				case 7:
				case 30:
					if (!LimitByTime)
					{
						num = 11;
						break;
					}
					goto case 21;
				case 23:
					if (LS4DQiZvsEFRtfJ2YTDH(TimeOfExecution) == TimeSetType.ContextVar)
					{
						num = 35;
						break;
					}
					goto case 11;
				case 18:
					_003C_003Ec__DisplayClass84_.property = ((EntityMetadata)JVekDqZvZZse8edkEFKT(zVpGe6ZvO5nMY4SXjEKH(validator))).GetPropertiesAndTableParts().FirstOrDefault((IPropertyMetadata p) => ihWFrBZvmYCQURems22X(QneoaMZvtZjlYdVVDd0o(p), DocumentVars.First()));
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num2 = 20;
					}
					continue;
				case 32:
					if (!baseClasses.All(_003C_003Ec__DisplayClass84_._003CValidate_003Eb__3))
					{
						num2 = 30;
						continue;
					}
					goto case 5;
				case 22:
					_003C_003Ec__DisplayClass84_ = new _003C_003Ec__DisplayClass84_0();
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num2 = 18;
					}
					continue;
				case 26:
					if (WorkLogTimeOfExecution != null)
					{
						num2 = 2;
						continue;
					}
					goto case 6;
				case 10:
					base.Validate(validator);
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
					{
						num2 = 7;
					}
					continue;
				case 14:
					if (ihWFrBZvmYCQURems22X(DocumentFormUid, Guid.Empty))
					{
						num2 = 19;
						continue;
					}
					return;
				default:
					if (C7VfGuZvKnWYLLPGmbft(DocumentVars) <= 0)
					{
						num2 = 7;
						continue;
					}
					goto case 22;
				case 34:
					validator.Messages.Add(base.ValidationHelper.CreateValidationError(string.Format((string)DZbH8iZvYGmyRvqK0lIY(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x352BEFE)), Name, gbUkWtZv8d6lctMO1gxl(classMetadata), gbUkWtZv8d6lctMO1gxl(classMetadata2))));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
					{
						num2 = 4;
					}
					continue;
				case 15:
					HkliGyZvyrgldNsVExgC(base.ValidationHelper, validator, dBL2ibZv0iaSv2DYywYF(WorkLogTimeOfExecution), UGDvQDZZ43TPeUyXL523(pYUO6bZZV5daYvUxKvdU(-2122743969 ^ -2122645325), new object[1] { Ej8A18ZZAuNhodKRfXpj(this) }), true);
					num2 = 16;
					continue;
				case 33:
					validator.Messages.Add((ProcessValidationMessage)pw1L7PZZz2EKsHywpMHU(base.ValidationHelper, UGDvQDZZ43TPeUyXL523(pYUO6bZZV5daYvUxKvdU(0x3C1FFB55 ^ 0x3C1D8697), new object[1] { Name })));
					num2 = 12;
					continue;
				case 31:
					if (!SelectDocumentForm)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 14;
				case 2:
					if (EaITDkZvleLDuFNYb3U1(WorkLogTimeOfExecution) == TimeSetType.ContextVar)
					{
						num2 = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 12:
					return;
				case 8:
					baseClasses = MetadataLoader.GetBaseClasses(classMetadata, loadImplementation: false);
					num2 = 27;
					continue;
				case 11:
				case 13:
				case 36:
					if (LimitByWorkLogTime)
					{
						num2 = 26;
						continue;
					}
					goto case 6;
				case 19:
					validator.Messages.Add((ProcessValidationMessage)pw1L7PZZz2EKsHywpMHU(base.ValidationHelper, UGDvQDZZ43TPeUyXL523(pYUO6bZZV5daYvUxKvdU(0x75872B6 ^ 0x75AF3F4), new object[1] { Ej8A18ZZAuNhodKRfXpj(this) })));
					num2 = 25;
					continue;
				case 20:
					if (_003C_003Ec__DisplayClass84_.property == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 32;
				case 28:
					classMetadata = (ClassMetadata)VslUcEZZwOjSPrDtFoR9(yHqOAmZZEcZLnbc7tcvU(), DocumentType, false);
					num2 = 24;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
					{
						num2 = 22;
					}
					continue;
				case 3:
					return;
				case 25:
					return;
				case 9:
					if (l9aOOjZZhc4H79fxoqF1(DocumentType, Guid.Empty))
					{
						num2 = 28;
						continue;
					}
					goto case 1;
				case 5:
					classMetadata2 = (ClassMetadata)VslUcEZZwOjSPrDtFoR9(MetadataServiceContext.Service, dcI9PjZvvMmOXH0xiKmw(_003C_003Ec__DisplayClass84_.property), false);
					num2 = 34;
					continue;
				case 6:
					if (DocumentTypeFromVar)
					{
						num2 = 17;
						continue;
					}
					goto case 31;
				case 29:
					base.ValidationHelper.ValidateProperty(validator, QNf7FZZvJPsRKt6W4yWR(TimeOfExecution), delegate(IPropertyMetadata p)
					{
						//Discarded unreachable code: IL_002d, IL_003c
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 1:
								if (_003C_003Ec.a1IFvKvcM3W3ZgA4he9y(p.TypeUid, DateTimeDescriptor.UID))
								{
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
									{
										num4 = 0;
									}
									break;
								}
								goto case 2;
							case 2:
								return _003C_003Ec.a1IFvKvcM3W3ZgA4he9y(p.TypeUid, TimeSpanDescriptor.UID);
							default:
								return true;
							}
						}
					}, (string)UGDvQDZZ43TPeUyXL523(pYUO6bZZV5daYvUxKvdU(0x5BCD23A0 ^ 0x5BCF5C9C), new object[1] { Ej8A18ZZAuNhodKRfXpj(this) }));
					num2 = 36;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
					{
						num2 = 5;
					}
					continue;
				case 16:
					base.ValidationHelper.ValidateProperty(validator, dBL2ibZv0iaSv2DYywYF(WorkLogTimeOfExecution), delegate(IPropertyMetadata p)
					{
						int num5 = 1;
						int num6 = num5;
						while (true)
						{
							switch (num6)
							{
							case 1:
								if (_003C_003Ec.k1qHJKvckMA3N41NLC5D(p) == DateTimeDescriptor.UID)
								{
									return true;
								}
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
								{
									num6 = 0;
								}
								break;
							default:
								return _003C_003Ec.a1IFvKvcM3W3ZgA4he9y(_003C_003Ec.k1qHJKvckMA3N41NLC5D(p), TimeSpanDescriptor.UID);
							}
						}
					}, (string)UGDvQDZZ43TPeUyXL523(pYUO6bZZV5daYvUxKvdU(-2077784392 ^ -2077948372), new object[1] { Name }));
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	private string HtmlBodyInner(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		SwimlaneElement swimlane = GetSwimlane(diagram);
		if (swimlane != null && !string.IsNullOrEmpty(swimlane.Name))
		{
			string arg = HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA710602), swimlane.Uid.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125770118), "")), swimlane.Name);
			stringBuilder.AppendFormat(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776469200), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720621413)), arg));
		}
		if (!string.IsNullOrEmpty(base.Description))
		{
			stringBuilder.AppendFormat(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A6BBC25) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1109006452)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x49419F8E) + base.Description);
		}
		if (DocumentVars.Count > 0)
		{
			stringBuilder.AppendFormat(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495442148) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772778626)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF653C2));
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x103E767));
			stringBuilder.Append(HTMLUtility.InsertRowToTable(new string[3]
			{
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1360917337)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647665228)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x62831ADC))
			}, isBold: true, null));
			foreach (Guid documentVar in DocumentVars)
			{
				foreach (ProcessContext context in contexts)
				{
					_003C_003Ec__DisplayClass85_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass85_0();
					CS_0024_003C_003E8__locals0.guid1 = documentVar;
					foreach (EntityPropertyMetadata item in ((IEnumerable<EntityPropertyMetadata>)context.EntityProperties).Where((EntityPropertyMetadata p) => _003C_003Ec__DisplayClass85_0.GeIXoLvc7yCSbZJ4a6B4(p) == CS_0024_003C_003E8__locals0.guid1))
					{
						stringBuilder.Append(HTMLUtility.InsertRowToTable(new string[3]
						{
							(!string.IsNullOrWhiteSpace(item.DisplayName)) ? item.DisplayName : item.Name,
							item.Name,
							ProcessDocumentationHelper.GetPropertyType(item)
						}, isBold: false, null));
					}
				}
			}
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34E86D90));
		}
		return stringBuilder.ToString();
	}

	public Type[] GetAvaiableOutputElementTypes()
	{
		return HintDrawElementHelper.GetAvaiableOutputElementTypes<TaskElement>();
	}

	public virtual void CheckPublicApplicationCompatibility(EntityMetadata processContext, IEnumerable<IPropertyMetadata> properties, List<IPublicApplicationCompatibilityError> errors)
	{
		if (View != null)
		{
			View.CheckPublicApplicationCompatibility(processContext, properties, errors);
		}
	}

	internal static void YgD9rbZZU4lEleK4PPoE()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool FQUQ4sZZMVSwGcNvKQyE()
	{
		return U5K0ygZZCBVFUaeZCi5X == null;
	}

	internal static CommonEditEntityWorkflowElement Gl3u9aZZkkNhipBgQHv2()
	{
		return U5K0ygZZCBVFUaeZCi5X;
	}

	internal static object pYUO6bZZV5daYvUxKvdU(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Ej8A18ZZAuNhodKRfXpj(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object BLIsqTZZGHBmjJQUk9oa(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool ODgWrdZZ7SNO78GaATi0(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object hx2bhIZZ2HRSfybXSI4D(object P_0)
	{
		return ((Element)P_0).DefaultName;
	}

	internal static Guid hQ4cr7ZZooGVT5k4XNlg(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object z5vNmrZZFVyhq2WIo1dm(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object ztiIs1ZZi6N4GycLM5Uy(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object txQjugZZIGGfGVK0XvWk(object P_0)
	{
		return HTMLUtility.MakeValidFileName((string)P_0);
	}

	internal static object n4pO9OZZaEKAQhUiQccA(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Guid UhOp54ZZr4XlWlQyFjlj(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object cSIpmSZZekhkSB2o8wMS(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object Rwltd1ZZNuQdhstTdCXa(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object GJbCS8ZZx3BXvTCouitB(object P_0, object P_1, object P_2)
	{
		return ((StringBuilder)P_0).AppendFormat((string)P_1, (object[])P_2);
	}

	internal static object cCsANtZZScCrfEKLiKSS(object P_0)
	{
		return ((BPMNFlowElement)P_0).GetConnectorsLink();
	}

	internal static object sbEZ1SZZ1xfCfSlmGeKw(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool l9aOOjZZhc4H79fxoqF1(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object yHqOAmZZEcZLnbc7tcvU()
	{
		return MetadataServiceContext.Service;
	}

	internal static object VslUcEZZwOjSPrDtFoR9(object P_0, Guid P_1, bool P_2)
	{
		return ((IMetadataService)P_0).GetMetadata(P_1, P_2);
	}

	internal static object UGDvQDZZ43TPeUyXL523(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object pw1L7PZZz2EKsHywpMHU(object P_0, object P_1)
	{
		return ((ElementValidationHelper)P_0).CreateValidationError((string)P_1);
	}

	internal static int C7VfGuZvKnWYLLPGmbft(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static object zVpGe6ZvO5nMY4SXjEKH(object P_0)
	{
		return ((WorkflowProcessValidator)P_0).Process;
	}

	internal static object JVekDqZvZZse8edkEFKT(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Context;
	}

	internal static Guid dcI9PjZvvMmOXH0xiKmw(object P_0)
	{
		return ((IPropertyMetadata)P_0).SubTypeUid;
	}

	internal static object DZbH8iZvYGmyRvqK0lIY(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object gbUkWtZv8d6lctMO1gxl(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static TimeSetType LS4DQiZvsEFRtfJ2YTDH(object P_0)
	{
		return ((TimeOfExecution)P_0).ValueType;
	}

	internal static Guid QNf7FZZvJPsRKt6W4yWR(object P_0)
	{
		return ((TimeOfExecution)P_0).PropertyUid;
	}

	internal static TimeSetType EaITDkZvleLDuFNYb3U1(object P_0)
	{
		return ((WorkLogTimeOfExecution)P_0).ValueType;
	}

	internal static Guid dBL2ibZv0iaSv2DYywYF(object P_0)
	{
		return ((WorkLogTimeOfExecution)P_0).PropertyUid;
	}

	internal static void HkliGyZvyrgldNsVExgC(object P_0, object P_1, Guid propertyUid, object P_3, bool errorOnEmptyUid)
	{
		((ElementValidationHelper)P_0).ValidatePropertyExists((WorkflowProcessValidator)P_1, propertyUid, (string)P_3, errorOnEmptyUid);
	}

	internal static bool ihWFrBZvmYCQURems22X(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid QneoaMZvtZjlYdVVDd0o(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}
}
