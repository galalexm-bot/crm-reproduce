using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Plugins;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Plugins;

[Serializable]
[HintShape(typeof(DocumentGenerationHintShape))]
[WebDiagrammerShape(typeof(WebDiagrammerCyanRectangleElementShape))]
[Shape(typeof(DocumentGenerationShape))]
public class DocumentChangePermissionsElement : BPMNFlowElement, IExceptionFlowSupported, IReplaceContextVar, IHintDrawElement
{
	[Component(Order = 100)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		private static ToolboxItem SNPGSBvXlR8ZrHHVLTSF;

		public string Name => (string)PjLOrwvXtxLfaDDBPvRY(L1t81tvXmDxqB0W7C3q1(0x56F860D7 ^ 0x56FAF3B1));

		public Guid GroupUid => PluginGroups.DocumentGeneration.UID;

		public Image Image => (Image)LywRtVvXbfexHRBxhpYt();

		public Type ElementType => Ddj5TyvX5ZtjHR3tq5t3(typeof(DocumentChangePermissionsElement).TypeHandle);

		public string ElementIcon => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351511618);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			siSUJMvXgURRucnSoxV7();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object L1t81tvXmDxqB0W7C3q1(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object PjLOrwvXtxLfaDDBPvRY(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool e3uaqZvX0MLLPs9XWgUH()
		{
			return SNPGSBvXlR8ZrHHVLTSF == null;
		}

		internal static ToolboxItem N2jkB1vXy8CCSf9lyUqV()
		{
			return SNPGSBvXlR8ZrHHVLTSF;
		}

		internal static object LywRtVvXbfexHRBxhpYt()
		{
			return Resources.docChangeAccess;
		}

		internal static Type Ddj5TyvX5ZtjHR3tq5t3(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void siSUJMvXgURRucnSoxV7()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static DocumentChangePermissionsElement vcHLBAZsjFGN2mqKOW47;

	public override string DefaultName => (string)dDmpAqZsqVP9Im5cyoTK(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4FD00585 ^ 0x4FD296E3));

	public List<DocumentChangePermissionsInfo> Actions { get; set; }

	public virtual EventTrigger[] SupportedTriggers => new EventTrigger[1] { EventTrigger.ErrorCatch };

	public override string ChapterName => (string)dDmpAqZsqVP9Im5cyoTK(QEd2VZZs3LHd8VvY6eoO(0x7381F16B ^ 0x7383622F));

	public Type[] GetAvaiableOutputElementTypes()
	{
		return HintDrawElementHelper.GetAvaiableOutputElementTypes<TaskElement>();
	}

	public override void Validate(WorkflowProcessValidator validator)
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
				base.Validate(validator);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null)
	{
		int num = 4;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			switch (num2)
			{
			case 2:
				mTHx6NZsUGxtFpXsfUXg(stringBuilder, QEd2VZZs3LHd8VvY6eoO(-261315199 ^ -261169473));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				mTHx6NZsUGxtFpXsfUXg(stringBuilder, QEd2VZZs3LHd8VvY6eoO(-261315199 ^ -261170787));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return stringBuilder.ToString();
			case 4:
				stringBuilder = new StringBuilder();
				num2 = 3;
				break;
			case 6:
				mTHx6NZsUGxtFpXsfUXg(stringBuilder, QEd2VZZs3LHd8VvY6eoO(-642713667 ^ -642689823));
				num2 = 5;
				break;
			case 3:
				mTHx6NZsUGxtFpXsfUXg(stringBuilder, YyFTBZZskAvXrkpokQk3(new object[5]
				{
					QEd2VZZs3LHd8VvY6eoO(-2002063381 ^ -2002217741),
					LPLAG2ZspLTrGALZcTOd(LeIXS7ZsQSb9Y6TqTrWl(LkJmKnZsT9Qd1VGAF74k(this)), "") ? sunrwXZsCoK0F7yZUDAN(this) : LkJmKnZsT9Qd1VGAF74k(this),
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F2FF0E),
					HkeMjmZsMCypvKioyB6a(this),
					QEd2VZZs3LHd8VvY6eoO(0x7AC609FE ^ 0x7AC472DA)
				}));
				num2 = 2;
				break;
			case 1:
				mTHx6NZsUGxtFpXsfUXg(stringBuilder, yTFCTAZs74pw4SE4Nn4y(D8Ocg2ZsVff0yTK9j0PM(QEd2VZZs3LHd8VvY6eoO(-865213812 ^ -865101552), HTMLUtility.MakeValidFileName(base.Uid.ToString()), QEd2VZZs3LHd8VvY6eoO(-683713632 ^ -683859888)), subFolders ? "" : x6Xo1VZsGSZuhHVK1Ak4(g0PEjIZsAFSboLCj6jUT(context).ToString(), QEd2VZZs3LHd8VvY6eoO(-1050383744 ^ -1050256766), "")));
				num2 = 6;
				break;
			}
		}
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		SwimlaneElement swimlane = GetSwimlane(diagram);
		if (swimlane != null && !string.IsNullOrEmpty(swimlane.Name))
		{
			string arg = HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077902508), swimlane.Uid.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135530996), "")), swimlane.Name);
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-682910880 ^ -683074898), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x73883B96)), arg));
		}
		if (!string.IsNullOrEmpty(element.Description))
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1303601216 ^ -1303452120) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF6E9C0)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197894486) + element.Description);
		}
		if (Actions.Count > 0)
		{
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6F0784), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x246EEF98 ^ 0x246C7D34))));
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x6A47A2));
			stringBuilder.Append(HTMLUtility.InsertRowToTable(new string[5]
			{
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34E8C37A)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7D1FE9)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135572006)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x3614BB17)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x3614BCF9))
			}, isBold: true, null));
			foreach (DocumentChangePermissionsInfo action in Actions)
			{
				stringBuilder.Append(HTMLUtility.InsertRowToTable(new string[5]
				{
					action.Name,
					GetEntityProperty(contexts, action.Documents),
					GetActionType(action.Action),
					GetPermissions(action.Permissions),
					GetRoles(contexts, action.Roles)
				}, isBold: false, null));
			}
		}
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386329352));
		return stringBuilder.ToString();
	}

	private string GetRoles(List<ProcessContext> contexts, List<DocumentChangePermissionsInfoRole> roles)
	{
		string text = string.Empty;
		foreach (DocumentChangePermissionsInfoRole role in roles)
		{
			if (role.Role == DocumentChangePermissionsInfo.RoleType.Author)
			{
				text = text + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56FAF4FF)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--296112178 ^ 0x11A46310);
			}
			if (role.Role == DocumentChangePermissionsInfo.RoleType.ContextVarUser || role.Role == DocumentChangePermissionsInfo.RoleType.ContextVarGroup || role.Role == DocumentChangePermissionsInfo.RoleType.ContextVarStructure)
			{
				text = text + GetEntityProperty(contexts, role.ObjectGuid) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980430642) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B5626E)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34E8C4B6);
			}
			if (role.Role == DocumentChangePermissionsInfo.RoleType.Structure)
			{
				string text2 = EntityManager<IOrganizationItem>.Instance.LoadOrNull(role.ObjectGuid).Name;
				text = text + text2 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651D8277) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-148495695 ^ -148588863)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431839812);
			}
			if (role.Role == DocumentChangePermissionsInfo.RoleType.Group)
			{
				string text3 = EntityManager<IUserGroup>.Instance.LoadOrNull(role.ObjectGuid).Name;
				text = text + text3 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135551260) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1002096714)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-148495695 ^ -148588845);
			}
		}
		return text;
	}

	private string GetActionType(DocumentChangePermissionsInfo.ActionType actionType)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (actionType != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return SR.T((string)QEd2VZZs3LHd8VvY6eoO(-667465279 ^ -667558575));
			default:
				return (string)dDmpAqZsqVP9Im5cyoTK(QEd2VZZs3LHd8VvY6eoO(0xF400DF8 ^ 0xF42995C));
			}
		}
	}

	private string GetPermissions(DocumentChangePermissionsInfo.PermissionType permissions)
	{
		//Discarded unreachable code: IL_00a7, IL_00b6
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (string)dDmpAqZsqVP9Im5cyoTK(QEd2VZZs3LHd8VvY6eoO(-980570076 ^ -980474736));
			default:
				return (string)dDmpAqZsqVP9Im5cyoTK(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386290518));
			case 1:
				{
					switch (permissions)
					{
					case DocumentChangePermissionsInfo.PermissionType.Load:
						break;
					case DocumentChangePermissionsInfo.PermissionType.Download:
						return (string)dDmpAqZsqVP9Im5cyoTK(QEd2VZZs3LHd8VvY6eoO(0x34EA50D4 ^ 0x34E8C41C));
					case DocumentChangePermissionsInfo.PermissionType.Edit:
						return (string)dDmpAqZsqVP9Im5cyoTK(QEd2VZZs3LHd8VvY6eoO(-2077784392 ^ -2077945244));
					case DocumentChangePermissionsInfo.PermissionType.Issue:
						return SR.T((string)QEd2VZZs3LHd8VvY6eoO(0x1145BED7 ^ 0x11472A2B));
					default:
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
						{
							num2 = 0;
						}
						goto end_IL_0012;
					}
					goto case 2;
				}
				end_IL_0012:
				break;
			}
		}
	}

	private string GetEntityProperty(List<ProcessContext> contexts, Guid fUid)
	{
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals0.fUid = fUid;
		foreach (ProcessContext context in contexts)
		{
			EntityPropertyMetadata entityPropertyMetadata = ((IEnumerable<EntityPropertyMetadata>)context.EntityProperties).FirstOrDefault((EntityPropertyMetadata p) => p.Uid == CS_0024_003C_003E8__locals0.fUid);
			if (entityPropertyMetadata == null)
			{
				foreach (TablePartMetadata item in (IEnumerable<TablePartMetadata>)context.EntityTableParts)
				{
					entityPropertyMetadata = GetPropertyRow(item, CS_0024_003C_003E8__locals0.fUid, context);
					if (entityPropertyMetadata != null)
					{
						return entityPropertyMetadata.DisplayName;
					}
				}
				continue;
			}
			return entityPropertyMetadata.DisplayName;
		}
		return null;
	}

	private EntityPropertyMetadata GetPropertyRow(TablePartMetadata tablePart, Guid uid, ProcessContext context)
	{
		int num = 2;
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				EntityPropertyMetadata entityPropertyMetadata;
				switch (num2)
				{
				case 3:
					_003C_003Ec__DisplayClass17_.context = context;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					goto end_IL_0012;
				case 4:
					_003C_003Ec__DisplayClass17_._003C_003E4__this = this;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
					{
						num2 = 3;
					}
					continue;
				default:
					entityPropertyMetadata = ((IEnumerable<EntityPropertyMetadata>)tablePart.EntityProperties).FirstOrDefault(_003C_003Ec__DisplayClass17_._003CGetPropertyRow_003Eb__0);
					if (entityPropertyMetadata != null)
					{
						break;
					}
					num2 = 5;
					continue;
				case 5:
					entityPropertyMetadata = ((IEnumerable<TablePartMetadata>)tablePart.EntityTableParts).Select(_003C_003Ec__DisplayClass17_._003CGetPropertyRow_003Eb__1).FirstOrDefault();
					break;
				}
				return entityPropertyMetadata;
				continue;
				end_IL_0012:
				break;
			}
			_003C_003Ec__DisplayClass17_.uid = uid;
			num = 4;
		}
	}

	public override string HtmlFooter()
	{
		StringBuilder stringBuilder = new StringBuilder();
		mTHx6NZsUGxtFpXsfUXg(stringBuilder, Ol4VSIZs2rYLVXlpnEYD(QEd2VZZs3LHd8VvY6eoO(-1895853023 ^ -1895962291), GetConnectorsLink()));
		mTHx6NZsUGxtFpXsfUXg(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A6BB84D));
		return stringBuilder.ToString();
	}

	public DocumentChangePermissionsElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		aWZNOMZsoAueNKlaqdEt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object dDmpAqZsqVP9Im5cyoTK(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool RpfBx9ZsRespBKG9avbg()
	{
		return vcHLBAZsjFGN2mqKOW47 == null;
	}

	internal static DocumentChangePermissionsElement XwHrc5Zs6PQJAdYx05Zs()
	{
		return vcHLBAZsjFGN2mqKOW47;
	}

	internal static object QEd2VZZs3LHd8VvY6eoO(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object LkJmKnZsT9Qd1VGAF74k(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object LeIXS7ZsQSb9Y6TqTrWl(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool LPLAG2ZspLTrGALZcTOd(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object sunrwXZsCoK0F7yZUDAN(object P_0)
	{
		return ((Element)P_0).DefaultName;
	}

	internal static Guid HkeMjmZsMCypvKioyB6a(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object YyFTBZZskAvXrkpokQk3(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object mTHx6NZsUGxtFpXsfUXg(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object D8Ocg2ZsVff0yTK9j0PM(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Guid g0PEjIZsAFSboLCj6jUT(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object x6Xo1VZsGSZuhHVK1Ak4(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object yTFCTAZs74pw4SE4Nn4y(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object Ol4VSIZs2rYLVXlpnEYD(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void aWZNOMZsoAueNKlaqdEt()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
