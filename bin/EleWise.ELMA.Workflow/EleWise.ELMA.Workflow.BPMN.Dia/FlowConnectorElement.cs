using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;

[Serializable]
[Shape(typeof(FlowConnectorShape))]
public class FlowConnectorElement : ConnectorHV, IFlowConnector, IReplaceContextVar, ITemplateSetNameElement, ITemplateSetDescriptionElement, ITemplateSetConfirmElement, IElementWithNotification
{
	private EventTrigger? trigger;

	private bool? isDefault;

	private bool commentRequired;

	private bool isSignNeeded;

	private Guid signType;

	internal static FlowConnectorElement HB0ooWZyh3kQFZJT8bv9;

	public Condition Condition
	{
		[CompilerGenerated]
		get
		{
			return _003CCondition_003Ek__BackingField;
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
					_003CCondition_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public new bool OutputCancel
	{
		[CompilerGenerated]
		get
		{
			return _003COutputCancel_003Ek__BackingField;
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
					_003COutputCancel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
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

	public bool NoCheckOrganizationItem
	{
		[CompilerGenerated]
		get
		{
			return _003CNoCheckOrganizationItem_003Ek__BackingField;
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
					_003CNoCheckOrganizationItem_003Ek__BackingField = value;
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

	public new bool ValidateContextVariables
	{
		[CompilerGenerated]
		get
		{
			return _003CValidateContextVariables_003Ek__BackingField;
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
					_003CValidateContextVariables_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
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

	public bool EnableComment
	{
		[CompilerGenerated]
		get
		{
			return _003CEnableComment_003Ek__BackingField;
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
					_003CEnableComment_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
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

	public bool CommentRequired
	{
		get
		{
			return commentRequired;
		}
		set
		{
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					commentRequired = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					if (!EnableComment)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 2;
				case 0:
					return;
				case 4:
					if (value)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 2;
				case 1:
					EnableComment = true;
					num2 = 2;
					break;
				}
			}
		}
	}

	public bool IsDefault
	{
		get
		{
			int num = 2;
			int num2 = num;
			bool? flag = default(bool?);
			while (true)
			{
				switch (num2)
				{
				default:
					return false;
				case 1:
					if (flag.HasValue)
					{
						return flag.GetValueOrDefault();
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					flag = isDefault;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num2 = 1;
					}
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
				case 3:
					G40WZDZyzMkgvjGv5XOQ(this);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (value != isDefault)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 2:
					return;
				default:
					isDefault = value;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}
	}

	public Guid Status
	{
		[CompilerGenerated]
		get
		{
			return _003CStatus_003Ek__BackingField;
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
					_003CStatus_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
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

	public EventTrigger Trigger
	{
		get
		{
			//Discarded unreachable code: IL_0057
			int num = 2;
			int num2 = num;
			EventTrigger? eventTrigger = default(EventTrigger?);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (eventTrigger.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 3:
					return EventTrigger.None;
				default:
					return eventTrigger.GetValueOrDefault();
				case 2:
					eventTrigger = trigger;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_0035, IL_0044
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					case 4:
						UpdateDecorators();
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
						{
							num2 = 2;
						}
						continue;
					case 3:
						return;
					case 2:
						if (value == trigger)
						{
							num2 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					}
					break;
				}
				trigger = value;
				num = 4;
			}
		}
	}

	public IntermediateTimerSettings TimerSettings
	{
		[CompilerGenerated]
		get
		{
			return _003CTimerSettings_003Ek__BackingField;
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
					_003CTimerSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
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

	[DefaultValue(true)]
	public bool CurrentExecutor
	{
		[CompilerGenerated]
		get
		{
			return _003CCurrentExecutor_003Ek__BackingField;
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
					_003CCurrentExecutor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<Recipient> Recipients { get; set; }

	public Guid ContextExceptionVar
	{
		[CompilerGenerated]
		get
		{
			return _003CContextExceptionVar_003Ek__BackingField;
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
					_003CContextExceptionVar_003Ek__BackingField = value;
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

	public bool UseConfirmConnector
	{
		[CompilerGenerated]
		get
		{
			return _003CUseConfirmConnector_003Ek__BackingField;
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
					_003CUseConfirmConnector_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool FormingConfirmConnector
	{
		[CompilerGenerated]
		get
		{
			return _003CFormingConfirmConnector_003Ek__BackingField;
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
					_003CFormingConfirmConnector_003Ek__BackingField = value;
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

	public string ConfirmConnectorText
	{
		[CompilerGenerated]
		get
		{
			return _003CConfirmConnectorText_003Ek__BackingField;
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
					_003CConfirmConnectorText_003Ek__BackingField = value;
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

	[XmlIgnore]
	public string LocalizableConfirmConnectorText => (string)g1DEPEZmKv7iGwen1CVQ(ConfirmConnectorText);

	public ButtonStyle ColorConnectorButton
	{
		[CompilerGenerated]
		get
		{
			return _003CColorConnectorButton_003Ek__BackingField;
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
					_003CColorConnectorButton_003Ek__BackingField = value;
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

	public string ScriprEscalation
	{
		[CompilerGenerated]
		get
		{
			return _003CScriprEscalation_003Ek__BackingField;
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
					_003CScriprEscalation_003Ek__BackingField = value;
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

	public IntermediateTimerSettings TimerScriptEscalation
	{
		[CompilerGenerated]
		get
		{
			return _003CTimerScriptEscalation_003Ek__BackingField;
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
					_003CTimerScriptEscalation_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public string LocalizableTemplateName => (string)g1DEPEZmKv7iGwen1CVQ(TemplateName);

	public string DefaultDisplayName
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultDisplayName_003Ek__BackingField;
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
					_003CDefaultDisplayName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsSignNeeded
	{
		get
		{
			return isSignNeeded;
		}
		set
		{
			//Discarded unreachable code: IL_00e5, IL_0123, IL_0132, IL_0141, IL_0151, IL_0160, IL_0170
			int num = 8;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 8:
					if (!value)
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 6;
				case 4:
				case 5:
				case 12:
					isSignNeeded = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					if (!LnbK5vZmZY5sLw1h2tS8(SignType, ((EnumBase)EYllILZmOKl7YW9W5EKS()).Value))
					{
						num2 = 2;
						continue;
					}
					break;
				case 0:
					return;
				case 1:
					signType = PQ2jiaZmvOcEsEskUyT5(EYllILZmOKl7YW9W5EKS());
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					if (SignType == Guid.Empty)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 10;
				case 2:
				case 7:
				case 9:
					if (value)
					{
						num2 = 12;
						continue;
					}
					goto case 1;
				case 3:
				case 11:
					break;
				}
				signType = PQ2jiaZmvOcEsEskUyT5(EleWise.ELMA.Documents.Models.SignType.FullSign);
				num2 = 5;
			}
		}
	}

	public Guid SignType
	{
		get
		{
			return signType;
		}
		set
		{
			//Discarded unreachable code: IL_0047, IL_0056
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 3:
					signType = value;
					num2 = 4;
					break;
				case 2:
					return;
				default:
					isSignNeeded = aXA3iLZmYUPys6wAG9My(value, PQ2jiaZmvOcEsEskUyT5(EYllILZmOKl7YW9W5EKS()));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					if (LnbK5vZmZY5sLw1h2tS8(value, Guid.Empty))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FlowConnectorElement()
	{
		//Discarded unreachable code: IL_001a
		faIgDaZy4nUEmpx4ZNs6();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
			{
				Recipients = new List<Recipient>();
				int num2 = 3;
				num = num2;
				break;
			}
			case 3:
				CurrentExecutor = true;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				EnableComment = true;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	protected override void OnShapeChanged(NShape oldShape, NShape newShape)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UpdateDecorators();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				NpwNcUZm8HC1MtQ44wqH(this, oldShape, newShape);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void UpdateDecorators()
	{
		//Discarded unreachable code: IL_005e, IL_006d
		int num = 4;
		int num2 = num;
		IDecoratableShape decoratableShape = default(IDecoratableShape);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				rTktHLZmsR2fsL3oDUE8(decoratableShape, this);
				num2 = 2;
				break;
			case 4:
				decoratableShape = base.Shape as IDecoratableShape;
				num2 = 3;
				break;
			case 0:
				return;
			case 3:
				if (decoratableShape == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 2:
				return;
			}
		}
	}

	public void ReplaceContextVar(Dictionary<Guid, Guid> ReplaceContextVar)
	{
		Guid value = Guid.Empty;
		if (ReplaceContextVar.TryGetValue(ContextExceptionVar, out value))
		{
			ContextExceptionVar = value;
		}
		if (TimerSettings != null)
		{
			_ = TimerSettings.PropertyUid;
			if (ReplaceContextVar.TryGetValue(TimerSettings.PropertyUid, out value))
			{
				TimerSettings.PropertyUid = value;
			}
		}
		if (Condition == null || Condition.Table == null || Condition.Table.Items == null)
		{
			return;
		}
		foreach (ConditionTable.Item item in Condition.Table.Items)
		{
			if (ReplaceContextVar.TryGetValue(item.Operand1.PropertyUid, out value))
			{
				item.Operand1.PropertyUid = value;
			}
			if (ReplaceContextVar.TryGetValue(item.Operand2.PropertyUid, out value))
			{
				item.Operand2.PropertyUid = value;
			}
		}
	}

	internal static void faIgDaZy4nUEmpx4ZNs6()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool wFARQSZyE3RFIPO8CUR8()
	{
		return HB0ooWZyh3kQFZJT8bv9 == null;
	}

	internal static FlowConnectorElement A992PkZywIRvjOLf8Jj7()
	{
		return HB0ooWZyh3kQFZJT8bv9;
	}

	internal static void G40WZDZyzMkgvjGv5XOQ(object P_0)
	{
		((FlowConnectorElement)P_0).UpdateDecorators();
	}

	internal static object g1DEPEZmKv7iGwen1CVQ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object EYllILZmOKl7YW9W5EKS()
	{
		return EleWise.ELMA.Documents.Models.SignType.NotSign;
	}

	internal static bool LnbK5vZmZY5sLw1h2tS8(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid PQ2jiaZmvOcEsEskUyT5(object P_0)
	{
		return ((EnumBase)P_0).Value;
	}

	internal static bool aXA3iLZmYUPys6wAG9My(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void NpwNcUZm8HC1MtQ44wqH(object P_0, object P_1, object P_2)
	{
		((Element)P_0).OnShapeChanged((NShape)P_1, (NShape)P_2);
	}

	internal static void rTktHLZmsR2fsL3oDUE8(object P_0, object P_1)
	{
		((IDecoratableShape)P_0).UpdateDecorators((Element)P_1);
	}
}
