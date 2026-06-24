using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Serializable]
[WebDiagrammerShape(typeof(WebDiagrammerGrayRectangleElementShape))]
[TaskType(30, "Manual")]
[Shape(typeof(ManualTaskShape))]
[HintShape(typeof(ManualTaskHintShape))]
public class ManualTaskElement : TaskElement, IExceptionFlowSupported
{
	[Component(Order = 300)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		private static ToolboxItem GmY3OHvDSoQHgmnfNeBk;

		public string Name => SR.T((string)w0SxMKvDEClFV7vgXwKa(-25709590 ^ -25886118));

		public Guid GroupUid => BPMNGroups.Operations.UID;

		public Image Image => (Image)vluOCTvDwTIGaATpQpvE();

		public Type ElementType => QODGVIvD4cbhW1bG1JHu(typeof(ManualTaskElement).TypeHandle);

		public string ElementIcon => (string)w0SxMKvDEClFV7vgXwKa(0x65B7F624 ^ 0x65B5293C);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			XplNOpvDzeKIQE9Ugg54();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object w0SxMKvDEClFV7vgXwKa(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool WygPJNvD18IIHL1Gx0rG()
		{
			return GmY3OHvDSoQHgmnfNeBk == null;
		}

		internal static ToolboxItem auTyPFvDhEsIaTpH599H()
		{
			return GmY3OHvDSoQHgmnfNeBk;
		}

		internal static object vluOCTvDwTIGaATpQpvE()
		{
			return Resources.symb_manual_task;
		}

		internal static Type QODGVIvD4cbhW1bG1JHu(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void XplNOpvDzeKIQE9Ugg54()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private static ManualTaskElement zSvBJ2ZbtC18OP2QHaDy;

	public override string DefaultName => (string)aHShWRZbBdYHdIuAXv1H(xSyEpsZbgE31Tsiv39hD(0x651FE29D ^ 0x651D532D));

	public virtual EventTrigger[] SupportedTriggers => new EventTrigger[2]
	{
		EventTrigger.Timer,
		EventTrigger.Script
	};

	public override bool ExceptionOutputIsStandart => true;

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683841214) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747D5598)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46CDFBB) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1214182792 ^ -1214006328)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-961162596 ^ -961027650));
		stringBuilder.Append(base.HtmlBody(element, contexts, orgStructVersion, subFolders, diagram, (IWorkflowProcess)null, (GenerationSettings)null));
		return stringBuilder.ToString();
	}

	public ManualTaskElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QwKjMWZbcwRkCS5d36TY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object xSyEpsZbgE31Tsiv39hD(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object aHShWRZbBdYHdIuAXv1H(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool b4hfJKZbbUxheExNjf5q()
	{
		return zSvBJ2ZbtC18OP2QHaDy == null;
	}

	internal static ManualTaskElement Ul0xdQZb5a7Md9yYyOtO()
	{
		return zSvBJ2ZbtC18OP2QHaDy;
	}

	internal static void QwKjMWZbcwRkCS5d36TY()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
