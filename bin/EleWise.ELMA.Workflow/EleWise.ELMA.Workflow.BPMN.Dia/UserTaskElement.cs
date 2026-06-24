using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Validation;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Deploy;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using EleWise.ELMA.Workflow.Security;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Serializable]
[SupportedMarker(TaskMarker.Condition)]
[Shape(typeof(UserTaskShape))]
[WebDiagrammerShape(typeof(WebDiagrammerUserTaskShape))]
[SupportedMarker(TaskMarker.Loop)]
[HintShape(typeof(UserTaskHintShape))]
[TaskType(10, "User")]
public class UserTaskElement : TaskElement, IExceptionFlowSupported, IFormDependency, IElementWithFormConstructorView, IElementWithView, IElementCheckPublicApplication, ITemplateSetNameElement, ITemplateSetDescriptionElement, IConnectorSettingsExtensionElement
{
	[Component(Order = 100)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		private static ToolboxItem mhMyKevn2m42tPxbfhHw;

		public string Name => (string)aIPSqSvnIMGRrD1EiuPg(ehGfMfvniHmKGijCobFR(0x738ABA6E ^ 0x73880B10));

		public Guid GroupUid => BPMNGroups.Operations.UID;

		public Image Image => (Image)pXsOd4vnagkwGcdsBbok();

		public Type ElementType => YaNdEkvnrERHV10qEyKX(typeof(UserTaskElement).TypeHandle);

		public string ElementIcon => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614E2A53);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			hUqWY8vneyQyEe3A2YSu();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object ehGfMfvniHmKGijCobFR(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object aIPSqSvnIMGRrD1EiuPg(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool AmvRq9vnoBEH8a3y8a6d()
		{
			return mhMyKevn2m42tPxbfhHw == null;
		}

		internal static ToolboxItem jc6xBlvnFprYN4rZnbYB()
		{
			return mhMyKevn2m42tPxbfhHw;
		}

		internal static object pXsOd4vnagkwGcdsBbok()
		{
			return Resources.symb_task_user;
		}

		internal static Type YaNdEkvnrERHV10qEyKX(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void hUqWY8vneyQyEe3A2YSu()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private bool limitByTime;

	private bool limitByWorkLogTime;

	internal static UserTaskElement vO4wDvZ5BBoLjf2Xuxy0;

	public override string DefaultName => (string)kmGTnSZ5dhIZgWPVXjmC(jliLi4Z5XN95cZh5t5X1(-398691253 ^ -398563115));

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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
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
				case 0:
					return;
				case 1:
					_003CFormingTemplateName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
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
				case 0:
					return;
				case 1:
					_003CFormingTemplateDescription_003Ek__BackingField = value;
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long TaskHelpId
	{
		[CompilerGenerated]
		get
		{
			return _003CTaskHelpId_003Ek__BackingField;
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
					_003CTaskHelpId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
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

	public string EndTaskMessage
	{
		[CompilerGenerated]
		get
		{
			return _003CEndTaskMessage_003Ek__BackingField;
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
					_003CEndTaskMessage_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
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

	public Guid FormUid
	{
		[CompilerGenerated]
		get
		{
			return _003CFormUid_003Ek__BackingField;
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
					_003CFormUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
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
		get
		{
			return limitByTime;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					limitByTime = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					UpdateDecorators();
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}
	}

	public bool LimitByWorkLogTime
	{
		get
		{
			return limitByWorkLogTime;
		}
		set
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
					MNVnPAZ5udMoL9j47NE7(this);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					limitByWorkLogTime = value;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
					{
						num2 = 1;
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
				case 1:
					_003CTimeOfExecution_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
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
				case 0:
					return;
				case 1:
					_003CWorkLogTimeOfExecution_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual EventTrigger[] SupportedTriggers => new EventTrigger[2]
	{
		EventTrigger.Timer,
		EventTrigger.Script
	};

	public override bool OutputCancel => true;

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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
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
				case 0:
					return;
				case 1:
					_003CDenyReplace_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public UserTaskFormSettings FormSettings
	{
		[CompilerGenerated]
		get
		{
			return _003CFormSettings_003Ek__BackingField;
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
					_003CFormSettings_003Ek__BackingField = value;
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

	public virtual bool CanCheckPublicApplicationCompatibility => true;

	public virtual Guid MetadataUid => InterfaceActivator.UID<IWorkflowTask>(loadImplementation: false);

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

	public override bool ExceptionOutputIsStandart => true;

	protected override int MaxOutputFlowsCount => int.MaxValue;

	protected override SwimlaneType[] SupportedSwimlaneTypes => new SwimlaneType[3]
	{
		SwimlaneType.Static,
		SwimlaneType.Dynamic,
		SwimlaneType.DynamicScript
	};

	string IFormDependency.Name => (string)XQcO24Z5nXqIBRncAhbC(this);

	IList<Guid> IFormDependency.FormUids
	{
		get
		{
			List<Guid> list = new List<Guid>();
			if (FormUid != Guid.Empty)
			{
				list.Add(FormUid);
			}
			return list;
		}
	}

	public bool DefaultDependency
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultDependency_003Ek__BackingField;
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
					_003CDefaultDependency_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
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

	public UserTaskElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				FormSettings = new UserTaskFormSettings();
				num = 2;
				break;
			case 3:
				WorkLogTimeOfExecution = new WorkLogTimeOfExecution();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				ConnectorSettings = new List<ConnectorSettingsExtension>();
				num = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
				{
					num = 0;
				}
				break;
			case 1:
				TimeOfExecution = new TimeOfExecution();
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
				{
					num = 0;
				}
				break;
			case 4:
				return;
			}
		}
	}

	public override IEnumerable<Guid> GetVisiblePropertyUids()
	{
		return base.GetVisiblePropertyUids().Union((View != null) ? (from i in View.GetAllItems().OfType<PropertyViewItem>()
			select _003C_003Ec.f1tnZ3vnhHEISN6r9qR0(i)).ToArray() : new Guid[0]);
	}

	public virtual void CheckPublicApplicationCompatibility(EntityMetadata processContext, IEnumerable<IPropertyMetadata> properties, List<IPublicApplicationCompatibilityError> errors)
	{
		if (FormUid != Guid.Empty)
		{
			errors.Add(new PublicApplicationCompatibilityError
			{
				Message = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x4233A3F8))
			});
		}
		if (View != null)
		{
			View.CheckPublicApplicationCompatibility(processContext, properties, errors);
		}
	}

	public override void Validate(WorkflowProcessValidator validator)
	{
		//Discarded unreachable code: IL_008e, IL_009d, IL_00d8, IL_00e7, IL_0152, IL_01a7, IL_01b6, IL_01c6, IL_02a2, IL_02b1
		int num = 7;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					return;
				case 16:
					return;
				case 21:
					return;
				case 7:
					base.Validate(validator);
					num2 = 6;
					break;
				case 6:
					if (ubqNlpZ5Ddjy3cI8CfZH(Name))
					{
						num2 = 26;
						break;
					}
					goto case 8;
				case 25:
					zSF1eGZ593JyqT9F0XRj(base.ValidationHelper, validator, XU8sC8Z5LA5wgxYkX4SK(TimeOfExecution), BOnh4PZ5fniLHG0dCCwD(jliLi4Z5XN95cZh5t5X1(0x70EBB9F3 ^ 0x70E9C761), new object[1] { Name }), true);
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
					{
						num2 = 22;
					}
					break;
				case 10:
					base.ValidationHelper.ValidatePropertyExists(validator, gk2438Z5juCd93oAkmRf(WorkLogTimeOfExecution), (string)BOnh4PZ5fniLHG0dCCwD(jliLi4Z5XN95cZh5t5X1(-790221436 ^ -790343064), new object[1] { Name }), errorOnEmptyUid: true);
					num2 = 14;
					break;
				case 20:
					if (WorkLogTimeOfExecution == null)
					{
						num2 = 19;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
						{
							num2 = 24;
						}
						break;
					}
					goto case 19;
				case 19:
					if (PkmcgQZ5WE0UUYVa7xMr(WorkLogTimeOfExecution) == TimeSetType.ContextVar)
					{
						num2 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto default;
				case 1:
					validator.Messages.Add((ProcessValidationMessage)EOTCE6Z5piB7srxYMQP2(base.ValidationHelper, text));
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
				case 26:
					validator.Messages.Add(base.ValidationHelper.CreateValidationError((string)kmGTnSZ5dhIZgWPVXjmC(jliLi4Z5XN95cZh5t5X1(0x1AF6F1F2 ^ 0x1AF442FA))));
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
					{
						num2 = 6;
					}
					break;
				case 8:
					if (!ubqNlpZ5Ddjy3cI8CfZH(O7LXjpZ5HcVOaSrqHXNR(XQcO24Z5nXqIBRncAhbC(this))))
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 5:
					if (TimeOfExecution.ValueType == TimeSetType.ContextVar)
					{
						num2 = 25;
						break;
					}
					goto case 3;
				default:
					if (FormSettings == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
						{
							num2 = 12;
						}
						break;
					}
					goto case 13;
				case 23:
					if (text == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
				case 9:
					if (!LimitByWorkLogTime)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 20;
				case 11:
				case 17:
					if (LimitByTime)
					{
						num2 = 15;
						break;
					}
					goto case 3;
				case 15:
					if (TimeOfExecution == null)
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
						{
							num2 = 9;
						}
						break;
					}
					goto case 5;
				case 13:
					if (!PtEow8Z5RMdnJ4mBvsSy(FormSettings))
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
						{
							num2 = 12;
						}
						break;
					}
					goto case 18;
				case 18:
					text = (string)FrPuXPZ5Qdirc3cvQLBE(vJrMZmZ53iGjumux1LON(FZvNpMZ5quwuPUHe62dX(sJgu8lZ56Qf43EQRKyPw(validator))), hv6ySPZ5TQMmcSvkBPNh(FormSettings), false);
					num2 = 23;
					break;
				case 22:
					base.ValidationHelper.ValidateProperty(validator, XU8sC8Z5LA5wgxYkX4SK(TimeOfExecution), delegate(IPropertyMetadata p)
					{
						//Discarded unreachable code: IL_006f, IL_007e
						int num3 = 2;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 2:
								if (_003C_003Ec.xKZ31wvnw9jOEq4nw73l(_003C_003Ec.u96pVcvnEHGNRIuNYs0h(p), DateTimeDescriptor.UID))
								{
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
									{
										num4 = 1;
									}
									break;
								}
								goto default;
							default:
								return _003C_003Ec.xKZ31wvnw9jOEq4nw73l(_003C_003Ec.u96pVcvnEHGNRIuNYs0h(p), TimeSpanDescriptor.UID);
							case 1:
								return true;
							}
						}
					}, (string)BOnh4PZ5fniLHG0dCCwD(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772757402), new object[1] { XQcO24Z5nXqIBRncAhbC(this) }));
					num2 = 3;
					break;
				case 14:
					base.ValidationHelper.ValidateProperty(validator, gk2438Z5juCd93oAkmRf(WorkLogTimeOfExecution), delegate(IPropertyMetadata p)
					{
						int num5 = 1;
						int num6 = num5;
						while (true)
						{
							switch (num6)
							{
							default:
								return _003C_003Ec.xKZ31wvnw9jOEq4nw73l(_003C_003Ec.u96pVcvnEHGNRIuNYs0h(p), TimeSpanDescriptor.UID);
							case 1:
								if (_003C_003Ec.xKZ31wvnw9jOEq4nw73l(p.TypeUid, DateTimeDescriptor.UID))
								{
									return true;
								}
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
								{
									num6 = 0;
								}
								break;
							}
						}
					}, SR.T((string)jliLi4Z5XN95cZh5t5X1(0x69063C81 ^ 0x6904BC15), XQcO24Z5nXqIBRncAhbC(this)));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 17;
		}
	}

	public override void ReplaceContextVar(Dictionary<Guid, Guid> replaceContextVar)
	{
		base.ReplaceContextVar(replaceContextVar);
		TimeOfExecution.ReplaceContextVars(replaceContextVar);
		if (replaceContextVar.TryGetValue(WorkLogTimeOfExecution.PropertyUid, out var value))
		{
			WorkLogTimeOfExecution.PropertyUid = value;
		}
	}

	public override void ReplaceSignature(Dictionary<string, string> replaceNames)
	{
		if (View == null)
		{
			return;
		}
		View.OnLoadScriptName = CopyReplace(View.OnLoadScriptName, replaceNames);
		ReplaceSignatureRecursive(View.Items, replaceNames);
		foreach (ConnectorSettingsExtension connectorSetting in ConnectorSettings)
		{
			connectorSetting.ScriptName = CopyReplace(connectorSetting.ScriptName, replaceNames);
		}
	}

	private void ReplaceSignatureRecursive(ListViewItem items, Dictionary<string, string> replaceNames)
	{
		foreach (PropertyViewItem item in items.OfType<PropertyViewItem>())
		{
			if (item.Attributes != null)
			{
				item.Attributes.OnViewLoadScriptName = CopyReplace(item.Attributes.OnViewLoadScriptName, replaceNames);
				item.Attributes.OnChangeScriptName = CopyReplace(item.Attributes.OnChangeScriptName, replaceNames);
				if (item.Items.Any())
				{
					ReplaceSignatureRecursive(item.Items, replaceNames);
				}
			}
		}
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539343189) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x5599C7A4)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74A93B7D) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x6AC0B4)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1394019056));
		stringBuilder.Append(base.HtmlBody(element, contexts, orgStructVersion, subFolders, diagram, (IWorkflowProcess)null, (GenerationSettings)null));
		if (element is UserTaskElement userTaskElement && userTaskElement.LimitByTime)
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF427410) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F5E6C1)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56A753C9 ^ 0x56A56125));
			switch (userTaskElement.TimeOfExecution.ValueType)
			{
			case TimeSetType.ContextVar:
			{
				if (!(userTaskElement.TimeOfExecution.PropertyUid != Guid.Empty))
				{
					break;
				}
				_003C_003Ec__DisplayClass87_0 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass87_0();
				CS_0024_003C_003E8__locals1.propertyUid = userTaskElement.TimeOfExecution.PropertyUid;
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720625541));
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720623011) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431848870)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6FC882) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F44D93A ^ 0x2F466AD0)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386330800));
				foreach (ProcessContext context in contexts)
				{
					EntityPropertyMetadata entityPropertyMetadata = ((IEnumerable<EntityPropertyMetadata>)context.EntityProperties).FirstOrDefault((EntityPropertyMetadata p) => _003C_003Ec__DisplayClass87_0.keIKXbvHvqZcJe0dwQZr(_003C_003Ec__DisplayClass87_0.m1EjGGvHZeIqB4MflXOl(p), CS_0024_003C_003E8__locals1.propertyUid));
					if (entityPropertyMetadata != null)
					{
						stringBuilder.Append(string.IsNullOrWhiteSpace(entityPropertyMetadata.DisplayName) ? entityPropertyMetadata.Name : (HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C64024D), entityPropertyMetadata.Uid.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638360384), "")), entityPropertyMetadata.DisplayName) + (string.IsNullOrWhiteSpace(entityPropertyMetadata.Description) ? string.Empty : string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x69063C81 ^ 0x6904889F), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1002105000)), entityPropertyMetadata.Description)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050256990)));
						break;
					}
				}
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11966738));
				break;
			}
			case TimeSetType.ExactValue:
			{
				TimeSpan value = userTaskElement.TimeOfExecution.Value;
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF4C2D0) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1214182792 ^ -1214006788)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56A753C9 ^ 0x56A560EB) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x6283D3F6)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2269BD32 ^ 0x226B095E) + ((value.Days > 0) ? (value.Days + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7DCA15)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5BCD23A0 ^ 0x5BCC4B4E)) : "") + ((value.Hours > 0) ? (value.Hours + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--296112178 ^ 0x11A4E446)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C67554F)) : "") + ((value.Minutes > 0) ? (value.Minutes + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1600060848 ^ -1599883734))) : "") + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790356314));
				break;
			}
			}
			if (userTaskElement.TimeOfExecution.Recipients.Count > 0)
			{
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -420136031) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651D5619)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351488942));
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1896020679));
				foreach (Recipient recipient in userTaskElement.TimeOfExecution.Recipients)
				{
					if (recipient.TypeUid == WorkflowRoleTypes.Initiator.UID)
					{
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125770384) + WorkflowRoleTypes.Initiator.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D67AAB));
					}
					else if (recipient.TypeUid == WorkflowRoleTypes.ResponsibleForInstance.UID)
					{
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x43883D4B) + WorkflowRoleTypes.ResponsibleForInstance.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1430645277 ^ -1430771977));
					}
					else if (recipient.TypeUid == WorkflowRoleTypes.ProcessOwner.UID)
					{
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37EB4251) + WorkflowRoleTypes.ProcessOwner.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1214182792 ^ -1214039700));
					}
					else if (recipient.TypeUid == OrganizationItemDTO.MetadataUid)
					{
						IOrganizationItem organizationItem = OrganizationItemManager.Instance.LoadOrNull(recipient.RecipientId);
						if (organizationItem != null)
						{
							stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA710AE6) + organizationItem.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431881526));
						}
					}
				}
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862227914));
			}
		}
		FormView formView = ((element is IElementWithFormConstructorView elementWithFormConstructorView && elementWithFormConstructorView.FormUid != Guid.Empty && wp != null) ? wp.Forms.CreateFormViewItem(elementWithFormConstructorView.FormUid, wp, checkExists: false) : View);
		if (formView != null && formView.GetAllItems().OfType<PropertyViewItem>().Any())
		{
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37EBC589), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x246EEF98 ^ 0x246C5B66))));
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x19256FCB));
			stringBuilder.Append(HTMLUtility.InsertRowToTable(new string[4]
			{
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712334139)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F5C1BF)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x6283D20E)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077936814))
			}, isBold: true, null));
			using (IEnumerator<PropertyViewItem> enumerator3 = formView.GetAllItems().OfType<PropertyViewItem>().GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					_003C_003Ec__DisplayClass87_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass87_1();
					CS_0024_003C_003E8__locals0.item = enumerator3.Current;
					if (CS_0024_003C_003E8__locals0.item == null)
					{
						continue;
					}
					foreach (ProcessContext context2 in contexts)
					{
						NamedMetadata namedMetadata = ((IEnumerable<EntityPropertyMetadata>)context2.EntityProperties).FirstOrDefault((EntityPropertyMetadata p) => _003C_003Ec__DisplayClass87_1.RklmCDvHJW2TyjsmvP0L(p) == _003C_003Ec__DisplayClass87_1.YVe0t3vHlvwBPeLidSaF(CS_0024_003C_003E8__locals0.item));
						if (namedMetadata != null)
						{
							GenerateMetadataPropertyRow(namedMetadata, CS_0024_003C_003E8__locals0.item, context2, stringBuilder, 0, subFolders, string.Empty);
							break;
						}
						foreach (TablePartMetadata item in (IEnumerable<TablePartMetadata>)context2.EntityTableParts)
						{
							string style = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D4F15F);
							int paddingLeft = 0;
							namedMetadata = GetPropertyRow(item, CS_0024_003C_003E8__locals0.item, context2, ref paddingLeft);
							if (namedMetadata != null)
							{
								GenerateMetadataPropertyRow(namedMetadata, CS_0024_003C_003E8__locals0.item, context2, stringBuilder, paddingLeft, subFolders, style);
								break;
							}
						}
						if (namedMetadata != null)
						{
							break;
						}
					}
				}
			}
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574481015));
		}
		return stringBuilder.ToString();
	}

	private NamedMetadata GetPropertyRow(TablePartMetadata tablePart, PropertyViewItem item, ProcessContext context, ref int paddingLeft)
	{
		//Discarded unreachable code: IL_00bc, IL_00cb, IL_00dc, IL_00eb, IL_00f6, IL_014e, IL_015d, IL_01b4, IL_01ec, IL_01fb
		int num = 9;
		_003C_003Ec__DisplayClass88_0 _003C_003Ec__DisplayClass88_ = default(_003C_003Ec__DisplayClass88_0);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		IEnumerator<TablePartMetadata> enumerator = default(IEnumerator<TablePartMetadata>);
		TablePartMetadata current = default(TablePartMetadata);
		NamedMetadata propertyRow = default(NamedMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return tablePart;
				case 3:
					break;
				case 2:
					if (!(uy8y8tZ5CTlWC3qghgwX(tablePart) == _003C_003Ec__DisplayClass88_.item.PropertyUid))
					{
						entityPropertyMetadata = ((IEnumerable<EntityPropertyMetadata>)tablePart.EntityProperties).FirstOrDefault(_003C_003Ec__DisplayClass88_._003CGetPropertyRow_003Eb__0);
						num2 = 4;
						continue;
					}
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					try
					{
						while (true)
						{
							IL_0168:
							int num3;
							if (!CnY8AdZ5MG90L8r8FMev(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
								{
									num3 = 1;
								}
								goto IL_00fa;
							}
							goto IL_0118;
							IL_0118:
							current = enumerator.Current;
							num3 = 2;
							goto IL_00fa;
							IL_00fa:
							while (true)
							{
								switch (num3)
								{
								case 2:
									propertyRow = GetPropertyRow(current, _003C_003Ec__DisplayClass88_.item, context, ref paddingLeft);
									num3 = 3;
									continue;
								case 4:
									goto IL_0168;
								case 1:
									goto end_IL_0168;
								case 3:
									return propertyRow;
								}
								break;
							}
							goto IL_0118;
							continue;
							end_IL_0168:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									gRUbjnZ5k4vIbSBtykH9(enumerator);
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto default;
				case 8:
					_003C_003Ec__DisplayClass88_.item = item;
					num2 = 3;
					continue;
				default:
					return null;
				case 4:
					if (entityPropertyMetadata == null)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 6;
				case 9:
					_003C_003Ec__DisplayClass88_ = new _003C_003Ec__DisplayClass88_0();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 8;
					}
					continue;
				case 6:
					return entityPropertyMetadata;
				case 7:
					enumerator = ((IEnumerable<TablePartMetadata>)tablePart.EntityTableParts).GetEnumerator();
					num2 = 5;
					continue;
				}
				break;
			}
			paddingLeft += 20;
			num = 2;
		}
	}

	private void GenerateMetadataPropertyRow(NamedMetadata metadata, PropertyViewItem item, ProcessContext context, StringBuilder sb, int paddingLeft, bool subFolders, string style)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				text = (string)YGUMgdZ5UdkLMepY3bJm(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351486264), style);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				g3YSfkZ5i2oLMbAPCiDO(sb, HTMLUtility.InsertRowToTable(new string[4]
				{
					(string)cKWYQyZ5o427usjm51NU(string.Format((string)jliLi4Z5XN95cZh5t5X1(-1542190822 ^ -1542048010), tI8y5hZ5VxrvLnaKSfcP(metadata.Uid.ToString(), jliLi4Z5XN95cZh5t5X1(0x1EA50FCC ^ 0x1EA73FCE), "")), (!KpkRvSZ57wILAH4QWEm1(PCa7NnZ5GGDTHktLvWJN(RU2mODZ5AKwPDyyl27mP(item)))) ? PCa7NnZ5GGDTHktLvWJN(RU2mODZ5AKwPDyyl27mP(item)) : ((!KpkRvSZ57wILAH4QWEm1(metadata.DisplayName)) ? metadata.DisplayName : IuWZ84Z52plb8GmhWDwe(metadata))),
					metadata.Name,
					tsZXQ9Z5FZjFFNZwBDLZ(RU2mODZ5AKwPDyyl27mP(item)) ? ProcessDocumentationGenerator.OK : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F51728E),
					(string)(item.IsReadOnly() ? ProcessDocumentationGenerator.OK : jliLi4Z5XN95cZh5t5X1(0x246EEF98 ^ 0x246CD74A))
				}, isBold: false, new string[4]
				{
					(string)((paddingLeft > 0) ? YGUMgdZ5UdkLMepY3bJm(jliLi4Z5XN95cZh5t5X1(0x2ACCDD87 ^ 0x2ACEE567), paddingLeft) : style),
					(string)((paddingLeft > 0) ? YGUMgdZ5UdkLMepY3bJm(jliLi4Z5XN95cZh5t5X1(-790221436 ^ -790358684), paddingLeft) : style),
					text,
					text
				}));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool xXG5lMZ5cEwAcd8e2RRH()
	{
		return vO4wDvZ5BBoLjf2Xuxy0 == null;
	}

	internal static UserTaskElement U9TCRRZ5PKnvtZvBUsZP()
	{
		return vO4wDvZ5BBoLjf2Xuxy0;
	}

	internal static object jliLi4Z5XN95cZh5t5X1(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object kmGTnSZ5dhIZgWPVXjmC(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void MNVnPAZ5udMoL9j47NE7(object P_0)
	{
		((BPMNFlowElement)P_0).UpdateDecorators();
	}

	internal static bool ubqNlpZ5Ddjy3cI8CfZH(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object XQcO24Z5nXqIBRncAhbC(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object O7LXjpZ5HcVOaSrqHXNR(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static Guid XU8sC8Z5LA5wgxYkX4SK(object P_0)
	{
		return ((TimeOfExecution)P_0).PropertyUid;
	}

	internal static object BOnh4PZ5fniLHG0dCCwD(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void zSF1eGZ593JyqT9F0XRj(object P_0, object P_1, Guid propertyUid, object P_3, bool errorOnEmptyUid)
	{
		((ElementValidationHelper)P_0).ValidatePropertyExists((WorkflowProcessValidator)P_1, propertyUid, (string)P_3, errorOnEmptyUid);
	}

	internal static TimeSetType PkmcgQZ5WE0UUYVa7xMr(object P_0)
	{
		return ((WorkLogTimeOfExecution)P_0).ValueType;
	}

	internal static Guid gk2438Z5juCd93oAkmRf(object P_0)
	{
		return ((WorkLogTimeOfExecution)P_0).PropertyUid;
	}

	internal static bool PtEow8Z5RMdnJ4mBvsSy(object P_0)
	{
		return ((UserTaskFormSettings)P_0).UseCustomView;
	}

	internal static object sJgu8lZ56Qf43EQRKyPw(object P_0)
	{
		return ((WorkflowProcessValidator)P_0).Process;
	}

	internal static object FZvNpMZ5quwuPUHe62dX(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Context;
	}

	internal static object vJrMZmZ53iGjumux1LON(object P_0)
	{
		return WorkflowExportExtension.GetViewNamePrefix((ProcessContext)P_0);
	}

	internal static object hv6ySPZ5TQMmcSvkBPNh(object P_0)
	{
		return ((UserTaskFormSettings)P_0).CustomViewName;
	}

	internal static object FrPuXPZ5Qdirc3cvQLBE(object P_0, object P_1, bool P_2)
	{
		return ViewNameValidator.ValidateViewName((string)P_0, (string)P_1, P_2);
	}

	internal static object EOTCE6Z5piB7srxYMQP2(object P_0, object P_1)
	{
		return ((ElementValidationHelper)P_0).CreateValidationError((string)P_1);
	}

	internal static Guid uy8y8tZ5CTlWC3qghgwX(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyUid;
	}

	internal static bool CnY8AdZ5MG90L8r8FMev(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void gRUbjnZ5k4vIbSBtykH9(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object YGUMgdZ5UdkLMepY3bJm(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object tI8y5hZ5VxrvLnaKSfcP(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object RU2mODZ5AKwPDyyl27mP(object P_0)
	{
		return ((PropertyViewItem)P_0).Attributes;
	}

	internal static object PCa7NnZ5GGDTHktLvWJN(object P_0)
	{
		return ((ViewAttributes)P_0).LocalizableName;
	}

	internal static bool KpkRvSZ57wILAH4QWEm1(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object IuWZ84Z52plb8GmhWDwe(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object cKWYQyZ5o427usjm51NU(object P_0, object P_1)
	{
		return HTMLUtility.InsertHyperLink((string)P_0, (string)P_1);
	}

	internal static bool tsZXQ9Z5FZjFFNZwBDLZ(object P_0)
	{
		return ((ViewAttributes)P_0).Required;
	}

	internal static object g3YSfkZ5i2oLMbAPCiDO(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}
}
