using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

public abstract class NotificationBaseElement : TaskElement, IReplaceContextVar, IExceptionFlowSupported
{
	public class DataSource
	{
		private static DataSource Kp6LPBvDrWElep1cgQHZ;

		public object Context
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
					case 0:
						return;
					case 1:
						_003CContext_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public IWorkflowInstance Instance
		{
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
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
						_003CInstance_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
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

		public DataSource()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			VcI09XvDx2nK9EY4T7ed();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool F74y2WvDeBm1eE7FpgAI()
		{
			return Kp6LPBvDrWElep1cgQHZ == null;
		}

		internal static DataSource SSnFwnvDNhZ1yrXmOsOE()
		{
			return Kp6LPBvDrWElep1cgQHZ;
		}

		internal static void VcI09XvDx2nK9EY4T7ed()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static NotificationBaseElement U0ZOtfZtuo99Kk6XwPS6;

	public MessageTemplate NotificationTemplate
	{
		[CompilerGenerated]
		get
		{
			return _003CNotificationTemplate_003Ek__BackingField;
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
					_003CNotificationTemplate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual List<RecipientInfoForNotification> Recipients { get; set; }

	public Guid[] AttachmentProperties
	{
		[CompilerGenerated]
		get
		{
			return _003CAttachmentProperties_003Ek__BackingField;
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
					_003CAttachmentProperties_003Ek__BackingField = value;
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

	public bool AttachmentsBySingleFile
	{
		[CompilerGenerated]
		get
		{
			return _003CAttachmentsBySingleFile_003Ek__BackingField;
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
					_003CAttachmentsBySingleFile_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
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

	public virtual EventTrigger[] SupportedTriggers => new EventTrigger[1] { EventTrigger.ErrorCatch };

	protected override bool QueueExecutionTimeoutSupported => true;

	public NotificationBaseElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mg8lJ5ZtHkFHW2uXWnRi();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				NotificationTemplate = new MessageTemplate();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
				{
					num = 0;
				}
				break;
			default:
				Recipients = new List<RecipientInfoForNotification>();
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override void Validate(WorkflowProcessValidator validator)
	{
		//Discarded unreachable code: IL_01aa, IL_0217
		int num = 9;
		string subject = default(string);
		MessageTemplate notificationTemplate = default(MessageTemplate);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 14:
					subject = notificationTemplate.Subject;
					num = 11;
					break;
				case 7:
					y0EfvtZt6n7TEGqgJ3kf(validator, this, YvZgTmZtTNw8r2CqrOP8(notificationTemplate), IgPdVbZtj3krCB4hIWKd(nq0rrFZtWWrr5NWDgIIw(-351369538 ^ -351524058), new object[1] { text }));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
					{
						num2 = 10;
					}
					continue;
				case 5:
					y0EfvtZt6n7TEGqgJ3kf(validator, this, W1IaeHZt3q5Qou8iGYQI(notificationTemplate), IgPdVbZtj3krCB4hIWKd(nq0rrFZtWWrr5NWDgIIw(0x350C0E8 ^ 0x3526DEA), new object[1] { text }));
					num2 = 7;
					continue;
				default:
					validator.Messages.Add((ProcessValidationMessage)GeBqvjZtRnldXTJ7mGkN(base.ValidationHelper, IgPdVbZtj3krCB4hIWKd(nq0rrFZtWWrr5NWDgIIw(-25709590 ^ -25880476), new object[2]
					{
						text,
						SR.T((string)nq0rrFZtWWrr5NWDgIIw(0x5F800F5B ^ 0x5F82A4AD))
					})));
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					y0EfvtZt6n7TEGqgJ3kf(validator, this, FrxsQGZtqLni3NjmiSth(notificationTemplate), IgPdVbZtj3krCB4hIWKd(nq0rrFZtWWrr5NWDgIIw(-720457373 ^ -720626205), new object[1] { text }));
					num = 5;
					break;
				case 6:
					return;
				case 10:
					if (Recipients.Count != 0)
					{
						num2 = 6;
						continue;
					}
					goto case 12;
				case 3:
					notificationTemplate = NotificationTemplate;
					num2 = 14;
					continue;
				case 1:
					return;
				case 9:
					base.Validate(validator);
					num2 = 8;
					continue;
				case 8:
					if (!VpppufZtf7pXkCAHeXUh(jRCefoZtLGkDccgkK8TR(this)))
					{
						num2 = 4;
						continue;
					}
					obj = wNAUGIZt9VtdaKUeESZA(this);
					goto IL_02dc;
				case 4:
					obj = Name;
					goto IL_02dc;
				case 11:
					if (VpppufZtf7pXkCAHeXUh(subject))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 13;
				case 12:
					validator.Messages.Add(base.ValidationHelper.CreateValidationError(SR.T((string)nq0rrFZtWWrr5NWDgIIw(-1638225214 ^ -1638398762), text)));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					{
						y0EfvtZt6n7TEGqgJ3kf(validator, this, subject, IgPdVbZtj3krCB4hIWKd(nq0rrFZtWWrr5NWDgIIw(--1418337216 ^ 0x5488B7C2), new object[1] { text }));
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					IL_02dc:
					text = (string)obj;
					num = 3;
					break;
				}
				break;
			}
		}
	}

	public override void ReplaceContextVar(Dictionary<Guid, Guid> ReplaceContextVars)
	{
		Guid value = Guid.Empty;
		List<RecipientInfoForNotification> list = new List<RecipientInfoForNotification>();
		foreach (RecipientInfoForNotification recipient in Recipients)
		{
			if (recipient is ContextVarRecipientForNotification contextVarRecipientForNotification)
			{
				if (ReplaceContextVars.TryGetValue((Guid)contextVarRecipientForNotification.RecipientValue, out value))
				{
					list.Add(new ContextVarRecipientForNotification
					{
						RecipientValue = value
					});
				}
				else
				{
					list.Add(recipient);
				}
			}
		}
		Recipients = list;
		List<Guid> list2 = new List<Guid>();
		if (AttachmentProperties == null)
		{
			return;
		}
		Guid[] attachmentProperties = AttachmentProperties;
		foreach (Guid guid in attachmentProperties)
		{
			Guid value2 = Guid.Empty;
			if (ReplaceContextVars.TryGetValue(guid, out value2))
			{
				list2.Add(value2);
			}
			else
			{
				list2.Add(guid);
			}
		}
		AttachmentProperties = list2.ToArray();
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22492910) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF42A380)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213D181D) + element.DefaultName + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46C90F3));
		stringBuilder.Append(base.HtmlBody(element, contexts, orgStructVersion, subFolders, diagram, (IWorkflowProcess)null, (GenerationSettings)null));
		return stringBuilder.ToString();
	}

	internal static void mg8lJ5ZtHkFHW2uXWnRi()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool ctn9KPZtDJe5C7DK77Lg()
	{
		return U0ZOtfZtuo99Kk6XwPS6 == null;
	}

	internal static NotificationBaseElement S1ywxMZtnfEjnhEATjuU()
	{
		return U0ZOtfZtuo99Kk6XwPS6;
	}

	internal static object jRCefoZtLGkDccgkK8TR(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static bool VpppufZtf7pXkCAHeXUh(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object wNAUGIZt9VtdaKUeESZA(object P_0)
	{
		return ((Element)P_0).DefaultName;
	}

	internal static object nq0rrFZtWWrr5NWDgIIw(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object IgPdVbZtj3krCB4hIWKd(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object GeBqvjZtRnldXTJ7mGkN(object P_0, object P_1)
	{
		return ((ElementValidationHelper)P_0).CreateValidationError((string)P_1);
	}

	internal static void y0EfvtZt6n7TEGqgJ3kf(object P_0, object P_1, object P_2, object P_3)
	{
		((WorkflowProcessValidator)P_0).ValidateTemplate(P_1, (string)P_2, (string)P_3);
	}

	internal static object FrxsQGZtqLni3NjmiSth(object P_0)
	{
		return ((MessageTemplate)P_0).FullMessage;
	}

	internal static object W1IaeHZt3q5Qou8iGYQI(object P_0)
	{
		return ((MessageTemplate)P_0).ShortMessage;
	}

	internal static object YvZgTmZtTNw8r2CqrOP8(object P_0)
	{
		return ((MessageTemplate)P_0).URL;
	}
}
