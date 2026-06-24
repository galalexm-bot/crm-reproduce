using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Gateways;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Gateways;

[Serializable]
[Shape(typeof(ExclusiveGatewayShape))]
[HintShape(typeof(ExclusiveGatewayHintShape))]
public class ExclusiveGatewayElement : GatewayElement
{
	[Component(Order = 100)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		private static ToolboxItem xEQc3SvdHc1XSXRHQHDB;

		public string Name => (string)senMJMvdW7Kmi4sC7E7K(V5PlClvd9GOHXpqaRtH0(0x13F63440 ^ 0x13F7692A));

		public Guid GroupUid => BPMNGroups.Gateways.UID;

		public Image Image => Resources.symb_gateway_xor;

		public Type ElementType => SfR6qIvdjlhedLM6sOaR(typeof(ExclusiveGatewayElement).TypeHandle);

		public string ElementIcon => (string)V5PlClvd9GOHXpqaRtH0(-1303601216 ^ -1303494032);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object V5PlClvd9GOHXpqaRtH0(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object senMJMvdW7Kmi4sC7E7K(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool pWbPPrvdLxvOvKqqjLI0()
		{
			return xEQc3SvdHc1XSXRHQHDB == null;
		}

		internal static ToolboxItem yrp8H9vdfj94lIq16ByU()
		{
			return xEQc3SvdHc1XSXRHQHDB;
		}

		internal static Type SfR6qIvdjlhedLM6sOaR(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}
	}

	private static ExclusiveGatewayElement NHVXsjZlYIKBAGiZf70O;

	public override void Validate(WorkflowProcessValidator validator)
	{
		//Discarded unreachable code: IL_00b5, IL_00c4
		int num = 9;
		int num2 = num;
		List<FlowConnectorElement> standardOutputFlows = default(List<FlowConnectorElement>);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 8:
				standardOutputFlows = base.StandardOutputFlows;
				num2 = 2;
				continue;
			case 9:
				base.Validate(validator);
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
				{
					num2 = 7;
				}
				continue;
			case 5:
				if (num3 <= 0)
				{
					num2 = 7;
					continue;
				}
				if (num3 <= 1)
				{
					return;
				}
				num2 = 6;
				continue;
			case 2:
				if (UiDsIbZlJywiOdc9628Y(standardOutputFlows) <= 1)
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			case 4:
				return;
			case 7:
				validator.Messages.Add((ProcessValidationMessage)s63a8JZlm4ynLNPXNNNr(base.ValidationHelper, zxFCKlZlyijs5v23PPW5(nME9HkZlljsRUZP4syYx(0x13F63440 ^ 0x13F4AC16), new object[1] { xbF1ElZl0XcZENMEaqZK(this) })));
				num2 = 3;
				continue;
			case 0:
				return;
			case 6:
				validator.Messages.Add(base.ValidationHelper.CreateValidationError((string)zxFCKlZlyijs5v23PPW5(nME9HkZlljsRUZP4syYx(0x5BCD23A0 ^ 0x5BCFBB46), new object[1] { xbF1ElZl0XcZENMEaqZK(this) })));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			case 1:
				break;
			}
			num3 = standardOutputFlows.Count((FlowConnectorElement f) => _003C_003Ec.TsuCJwvd3Dq8LH9JbShA(f));
			num2 = 5;
		}
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684329754) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF6487C)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F5299F) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393826394)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708255390));
		stringBuilder.Append(base.HtmlBody(element, contexts, orgStructVersion, subFolders, diagram, wp, gs));
		return stringBuilder.ToString();
	}

	public ExclusiveGatewayElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zMfDQ3ZltKK1hM0wg9ev();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static int UiDsIbZlJywiOdc9628Y(object P_0)
	{
		return ((List<FlowConnectorElement>)P_0).Count;
	}

	internal static object nME9HkZlljsRUZP4syYx(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object xbF1ElZl0XcZENMEaqZK(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object zxFCKlZlyijs5v23PPW5(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object s63a8JZlm4ynLNPXNNNr(object P_0, object P_1)
	{
		return ((ElementValidationHelper)P_0).CreateValidationError((string)P_1);
	}

	internal static bool JrO5NGZl8LCO4fl5806B()
	{
		return NHVXsjZlYIKBAGiZf70O == null;
	}

	internal static ExclusiveGatewayElement EFMKtyZlsjSUxdSRvpjb()
	{
		return NHVXsjZlYIKBAGiZf70O;
	}

	internal static void zMfDQ3ZltKK1hM0wg9ev()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
