using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
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
[WebDiagrammerShape(typeof(WebDiagrammerCyanRectangleElementShape))]
[HintShape(typeof(DocumentGenerationHintShape))]
[Shape(typeof(DocumentGenerationShape))]
public class DocumentMovementElement : BPMNFlowElement, IExceptionFlowSupported, IReplaceContextVar, IHintDrawElement
{
	[Component(Order = 100)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem cdjuGIvPav1uclXfftEA;

		public string Name => (string)vuvx14vPxD8VapGMuFhN(yuVXyUvPNAWYeI9sKU0Z(-10408775 ^ -10240313));

		public Guid GroupUid => PluginGroups.DocumentGeneration.UID;

		public Image Image => (Image)GE2USwvPSfRU3HLWgFaY();

		public Type ElementType => b8cwdfvP1ThKTG4EwSXa(typeof(DocumentMovementElement).TypeHandle);

		public string ElementIcon => (string)yuVXyUvPNAWYeI9sKU0Z(-772614310 ^ -772797568);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			wi4MOpvPhgnqKyFPx1qT();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object yuVXyUvPNAWYeI9sKU0Z(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object vuvx14vPxD8VapGMuFhN(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool NtGdslvPrumnXqED7iyd()
		{
			return cdjuGIvPav1uclXfftEA == null;
		}

		internal static ToolboxItem tdDYf4vPem3HJISA9O2M()
		{
			return cdjuGIvPav1uclXfftEA;
		}

		internal static object GE2USwvPSfRU3HLWgFaY()
		{
			return Resources.docMovement;
		}

		internal static Type b8cwdfvP1ThKTG4EwSXa(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void wi4MOpvPhgnqKyFPx1qT()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static DocumentMovementElement I8JMa6ZsykIJ3muvYjgT;

	public override string DefaultName => (string)Q5577UZsbt0Ar1n2JBxl(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772782812));

	public List<DocumentMovementInfo> Actions { get; set; }

	public virtual EventTrigger[] SupportedTriggers => new EventTrigger[1] { EventTrigger.ErrorCatch };

	public override string ChapterName => (string)Q5577UZsbt0Ar1n2JBxl(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-43932417 ^ -43829317));

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
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null)
	{
		int num = 6;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num2 = num;
			StringBuilder stringBuilder2;
			object[] obj;
			object obj2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					jWi4JgZsdcG3qboK8jLu(stringBuilder, gdZgr3ZsPmiaB2u6Pthr(-1028861977 ^ -1028738053));
					num2 = 3;
					break;
				case 2:
					jWi4JgZsdcG3qboK8jLu(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD305CC2 ^ 0xD3227FC));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					stringBuilder = new StringBuilder();
					num2 = 5;
					break;
				case 3:
					return stringBuilder.ToString();
				case 4:
					stringBuilder.Append((string)gdZgr3ZsPmiaB2u6Pthr(0x17F0C5A2 ^ 0x17F166FE));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					stringBuilder2 = stringBuilder;
					obj = new object[5]
					{
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x157D5AF4 ^ 0x157F21EC),
						null,
						null,
						null,
						null
					};
					obj2 = (mglpd5ZsBI03DuiECLAR(Vmjv9nZsgo2vDVhsd0uu(NQAVp0Zs55lH4J0pZ0hr(this)), "") ? lvg4Q8ZscGMUN8LuB4g2(this) : NQAVp0Zs55lH4J0pZ0hr(this));
					goto end_IL_0012;
				default:
					jWi4JgZsdcG3qboK8jLu(stringBuilder, hKDjr8ZsLjYYOXhIYxoK(nFVwkrZsD3vDOx1W3dXy(gdZgr3ZsPmiaB2u6Pthr(0x7381F16B ^ 0x73838AF7), QpSjFOZsu8xcxtWXGGdK(base.Uid.ToString()), gdZgr3ZsPmiaB2u6Pthr(--1212129906 ^ 0x483DD982)), subFolders ? "" : rFWxi8ZsH8rp4eQW0WNX(Iu9ln1ZsnJ6CoNHTNorP(context).ToString(), gdZgr3ZsPmiaB2u6Pthr(0x3C1FFB55 ^ 0x3C1DCB57), "")));
					num2 = 4;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			obj[1] = obj2;
			obj[2] = gdZgr3ZsPmiaB2u6Pthr(0x4FD00585 ^ 0x4FD23F29);
			obj[3] = UpK8I8ZsXbFCifsOHteW(this);
			obj[4] = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x42336A1C);
			stringBuilder2.Append(string.Concat(obj));
			num = 2;
		}
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		SwimlaneElement swimlane = GetSwimlane(diagram);
		if (swimlane != null && !string.IsNullOrEmpty(swimlane.Name))
		{
			string arg = HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x438831AF), swimlane.Uid.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776448772), "")), swimlane.Name);
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1896016401), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x595C500A ^ 0x595ED1F2)), arg));
		}
		if (!string.IsNullOrEmpty(element.Description))
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651D9B75) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720598693)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720581367) + element.Description);
		}
		if (Actions.Count > 0)
		{
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5BCD23A0 ^ 0x5BCF5F60), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386289904))));
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-763667953 ^ -763794329));
			stringBuilder.Append(HTMLUtility.InsertRowToTable(new string[4]
			{
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B564E4)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74A9D5F1)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x10343FB)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935144871))
			}, isBold: true, null));
			foreach (DocumentMovementInfo action in Actions)
			{
				stringBuilder.Append(HTMLUtility.InsertRowToTable(new string[4]
				{
					action.Name,
					GetFolder(contexts, action),
					GetEntityProperty(contexts, action.Document),
					action.InheritRights ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45730163) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495399482)
				}, isBold: false, null));
			}
		}
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542048674));
		return stringBuilder.ToString();
	}

	private string GetFolder(List<ProcessContext> contexts, DocumentMovementInfo action)
	{
		if (action.FolderType == DocumentMovementInfo.Folder.folderId)
		{
			if (action.FolderId.HasValue && action.FolderId > 0)
			{
				IFolder folder = EntityManager<IFolder>.Instance.LoadOrNull(action.FolderId.Value);
				if (folder != null)
				{
					return folder.Name;
				}
				return string.Empty;
			}
			return string.Empty;
		}
		return GetEntityProperty(contexts, action.FolderGuid);
	}

	private string GetEntityProperty(List<ProcessContext> contexts, Guid uid)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals0.uid = uid;
		foreach (ProcessContext context in contexts)
		{
			EntityPropertyMetadata entityPropertyMetadata = ((IEnumerable<EntityPropertyMetadata>)context.EntityProperties).FirstOrDefault((EntityPropertyMetadata p) => _003C_003Ec__DisplayClass14_0.oFd55lvXOurUce6u1FH2(_003C_003Ec__DisplayClass14_0.SmWNRTvXKywr4xlgk4yq(p), CS_0024_003C_003E8__locals0.uid));
			if (entityPropertyMetadata == null)
			{
				foreach (TablePartMetadata item in (IEnumerable<TablePartMetadata>)context.EntityTableParts)
				{
					entityPropertyMetadata = GetPropertyRow(item, CS_0024_003C_003E8__locals0.uid, context);
					if (entityPropertyMetadata != null)
					{
						return entityPropertyMetadata.DisplayName;
					}
				}
				continue;
			}
			return entityPropertyMetadata.DisplayName;
		}
		return string.Empty;
	}

	private EntityPropertyMetadata GetPropertyRow(TablePartMetadata tablePart, Guid uid, ProcessContext context)
	{
		int num = 5;
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				EntityPropertyMetadata entityPropertyMetadata;
				switch (num2)
				{
				case 5:
					_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
					num2 = 4;
					continue;
				case 3:
					_003C_003Ec__DisplayClass15_._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					goto end_IL_0012;
				default:
					_003C_003Ec__DisplayClass15_.context = context;
					num2 = 2;
					continue;
				case 2:
					entityPropertyMetadata = ((IEnumerable<EntityPropertyMetadata>)tablePart.EntityProperties).FirstOrDefault(_003C_003Ec__DisplayClass15_._003CGetPropertyRow_003Eb__0);
					if (entityPropertyMetadata == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					entityPropertyMetadata = ((IEnumerable<TablePartMetadata>)tablePart.EntityTableParts).Select(_003C_003Ec__DisplayClass15_._003CGetPropertyRow_003Eb__1).FirstOrDefault();
					break;
				}
				return entityPropertyMetadata;
				continue;
				end_IL_0012:
				break;
			}
			_003C_003Ec__DisplayClass15_.uid = uid;
			num = 3;
		}
	}

	public override string HtmlFooter()
	{
		StringBuilder stringBuilder = new StringBuilder();
		jWi4JgZsdcG3qboK8jLu(stringBuilder, wMWZxVZs9gidgr0q9NYY(gdZgr3ZsPmiaB2u6Pthr(-14356676 ^ -14249392), xa7U4jZsfGC4NQSF21S0(this)));
		jWi4JgZsdcG3qboK8jLu(stringBuilder, gdZgr3ZsPmiaB2u6Pthr(-961162596 ^ -961040612));
		return stringBuilder.ToString();
	}

	public DocumentMovementElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vFBUJwZsWgiwHPvGG7Qi();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Q5577UZsbt0Ar1n2JBxl(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool KSsQEOZsmOyDUiJgXifd()
	{
		return I8JMa6ZsykIJ3muvYjgT == null;
	}

	internal static DocumentMovementElement jndsYaZst5YrDhL2dWeS()
	{
		return I8JMa6ZsykIJ3muvYjgT;
	}

	internal static object NQAVp0Zs55lH4J0pZ0hr(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object Vmjv9nZsgo2vDVhsd0uu(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool mglpd5ZsBI03DuiECLAR(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object lvg4Q8ZscGMUN8LuB4g2(object P_0)
	{
		return ((Element)P_0).DefaultName;
	}

	internal static object gdZgr3ZsPmiaB2u6Pthr(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid UpK8I8ZsXbFCifsOHteW(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object jWi4JgZsdcG3qboK8jLu(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object QpSjFOZsu8xcxtWXGGdK(object P_0)
	{
		return HTMLUtility.MakeValidFileName((string)P_0);
	}

	internal static object nFVwkrZsD3vDOx1W3dXy(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Guid Iu9ln1ZsnJ6CoNHTNorP(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object rFWxi8ZsH8rp4eQW0WNX(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object hKDjr8ZsLjYYOXhIYxoK(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object xa7U4jZsfGC4NQSF21S0(object P_0)
	{
		return ((BPMNFlowElement)P_0).GetConnectorsLink();
	}

	internal static object wMWZxVZs9gidgr0q9NYY(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void vFBUJwZsWgiwHPvGG7Qi()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
