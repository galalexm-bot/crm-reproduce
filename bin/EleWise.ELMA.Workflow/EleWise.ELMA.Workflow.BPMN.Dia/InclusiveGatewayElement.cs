using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Gateways;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Gateways;

[Serializable]
[Shape(typeof(InclusiveGatewayShape))]
[HintShape(typeof(InclusiveGatewayHintShape))]
public class InclusiveGatewayElement : GatewayElement
{
	[Component(Order = 200)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem VkvyGtvdEpykyF8dnDSH;

		public string Name => (string)JKZNOUvuKJrUgQ4hvZ1W(kPMVu4vdz4TMEoeqJc9A(-768800937 ^ -768845119));

		public Guid GroupUid => BPMNGroups.Gateways.UID;

		public Image Image => Resources.symb_gateway_or;

		public Type ElementType => l8yj5hvuOnw57dc0G5db(typeof(InclusiveGatewayElement).TypeHandle);

		public string ElementIcon => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x5488C616);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			RpwaJjvuZSFgahAIuUEh();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object kPMVu4vdz4TMEoeqJc9A(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object JKZNOUvuKJrUgQ4hvZ1W(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool fUpY78vdwYEuPTKK9rLt()
		{
			return VkvyGtvdEpykyF8dnDSH == null;
		}

		internal static ToolboxItem o2hQS0vd4nTmlaIvb36R()
		{
			return VkvyGtvdEpykyF8dnDSH;
		}

		internal static Type l8yj5hvuOnw57dc0G5db(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void RpwaJjvuZSFgahAIuUEh()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static InclusiveGatewayElement myS8nRZl6MQwO0e7dCIV;

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C640F43) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B78149)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x62831BD4) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACE41A5)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45705581));
		stringBuilder.Append(base.HtmlBody(element, contexts, orgStructVersion, subFolders, diagram, wp, gs));
		return stringBuilder.ToString();
	}

	public InclusiveGatewayElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		i8FiLfZlTy9JIqRtyMad();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void i8FiLfZlTy9JIqRtyMad()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool wZkFZDZlqQTeiYiA0ppG()
	{
		return myS8nRZl6MQwO0e7dCIV == null;
	}

	internal static InclusiveGatewayElement RJiEfDZl3vlJIsfNkj5h()
	{
		return myS8nRZl6MQwO0e7dCIV;
	}
}
