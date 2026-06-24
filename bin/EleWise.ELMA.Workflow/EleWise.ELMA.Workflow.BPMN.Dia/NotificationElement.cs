using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Serializable]
[TaskType(40, "Notification")]
[WebDiagrammerShape(typeof(WebDiagrammerNotificationShape))]
[HintShape(typeof(NotificationHintShape))]
[SupportedMarker(TaskMarker.Condition)]
[Shape(typeof(NotificationShape))]
public class NotificationElement : NotificationBaseElement
{
	[Component(Order = 400)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem P0E3Bfvnta1CZLnc0rG9;

		public string Name => SR.T((string)BA2PvjvngUJ4uuc93uKm(-1647793954 ^ -1647699704));

		public Guid GroupUid => BPMNGroups.Operations.UID;

		public Image Image => Resources.sybm_notification;

		public Type ElementType => WJ5X4UvnBQOfCNW5sLhH(typeof(NotificationElement).TypeHandle);

		public string ElementIcon => (string)BA2PvjvngUJ4uuc93uKm(0x1145BED7 ^ 0x114761FF);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			fmtSC6vnck7S9nB48dGG();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object BA2PvjvngUJ4uuc93uKm(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool p2hf4AvnbfiOe6SB8d4y()
		{
			return P0E3Bfvnta1CZLnc0rG9 == null;
		}

		internal static ToolboxItem bcTlfrvn5pg9hiwoMqfJ()
		{
			return P0E3Bfvnta1CZLnc0rG9;
		}

		internal static Type WJ5X4UvnBQOfCNW5sLhH(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void fmtSC6vnck7S9nB48dGG()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	public new class DataSource
	{
		internal static DataSource CFlGNsvnPIdbRnVNLUqe;

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
					case 1:
						_003CContext_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
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
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
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
			ivfuqrvnuV5HXRCoh3yc();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool F1ui1kvnXgf0M2Dr2Cjd()
		{
			return CFlGNsvnPIdbRnVNLUqe == null;
		}

		internal static DataSource vSEpHNvndM5rc0pak8GN()
		{
			return CFlGNsvnPIdbRnVNLUqe;
		}

		internal static void ivfuqrvnuV5HXRCoh3yc()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private List<RecipientInfoForNotification> recipients;

	private static NotificationElement m8DgtJZbLKnYCD4nl3sd;

	public override string DefaultName => (string)yyMepkZbWfayJDhgrrSS(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C648C77));

	[DefaultValue(NotificationElementRecipientType.NotSet)]
	public NotificationElementRecipientType RecipientType
	{
		[CompilerGenerated]
		get
		{
			return _003CRecipientType_003Ek__BackingField;
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
					_003CRecipientType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
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

	[DefaultValue(null)]
	public Guid RecipientProperty
	{
		[CompilerGenerated]
		get
		{
			return _003CRecipientProperty_003Ek__BackingField;
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
					_003CRecipientProperty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
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

	public override List<RecipientInfoForNotification> Recipients
	{
		get
		{
			if (RecipientType == NotificationElementRecipientType.ContextVariable && !string.IsNullOrEmpty(base.NotificationTemplate.Subject))
			{
				ContextVarRecipientForNotification contextVarRecipientForNotification = new ContextVarRecipientForNotification();
				contextVarRecipientForNotification.RecipientValue = RecipientProperty;
				recipients.Add(contextVarRecipientForNotification);
				RecipientType = NotificationElementRecipientType.NotSet;
			}
			if (RecipientType == NotificationElementRecipientType.CurrentExecutor && !string.IsNullOrEmpty(base.NotificationTemplate.Subject))
			{
				CurrentUserRecipientForNotification item = new CurrentUserRecipientForNotification();
				recipients.Add(item);
				RecipientType = NotificationElementRecipientType.NotSet;
			}
			return recipients;
		}
		set
		{
			recipients = value;
		}
	}

	public NotificationElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		rU1UrEZbjxIOy0IQPM1E();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object yyMepkZbWfayJDhgrrSS(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool SJlIuBZbfJgrUMhUEcqo()
	{
		return m8DgtJZbLKnYCD4nl3sd == null;
	}

	internal static NotificationElement H8AZmEZb9xICqfyGlnsZ()
	{
		return m8DgtJZbLKnYCD4nl3sd;
	}

	internal static void rU1UrEZbjxIOy0IQPM1E()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
