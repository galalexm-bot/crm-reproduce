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
[HintShape(typeof(ParallelGatewayHintShape))]
[Shape(typeof(ParallelGatewayShape))]
public class ParallelGatewayElement : GatewayElement
{
	[Component(Order = 300)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem nD3mhdvuv0ZNrEfP6waG;

		public string Name => (string)exoaYEvuJDGWBJExweYt(EWx6qZvusGo8StRQO1v6(-105863102 ^ -105777788));

		public Guid GroupUid => BPMNGroups.Gateways.UID;

		public Image Image => Resources.symb_gateway_and;

		public Type ElementType => RayplrvuluhLKmv5lBin(typeof(ParallelGatewayElement).TypeHandle);

		public string ElementIcon => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965106511);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			BmGnEUvu0SptUyiMd4Vg();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object EWx6qZvusGo8StRQO1v6(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object exoaYEvuJDGWBJExweYt(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool nMnsB4vuYRZLAsAh4QRP()
		{
			return nD3mhdvuv0ZNrEfP6waG == null;
		}

		internal static ToolboxItem Gmj1Ufvu8s7F9kE2dtPU()
		{
			return nD3mhdvuv0ZNrEfP6waG;
		}

		internal static Type RayplrvuluhLKmv5lBin(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void BmGnEUvu0SptUyiMd4Vg()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static ParallelGatewayElement gAchInZlQASwy08RK7av;

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D4FBF1) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x738823EA)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -451974861) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801652219)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12D5B48));
		stringBuilder.Append(base.HtmlBody(element, contexts, orgStructVersion, subFolders, diagram, wp, gs));
		return stringBuilder.ToString();
	}

	public ParallelGatewayElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jC67bWZlMLsmC69Zvrl4();
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

	internal static void jC67bWZlMLsmC69Zvrl4()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool LYsQbaZlptGKUyHOUN9D()
	{
		return gAchInZlQASwy08RK7av == null;
	}

	internal static ParallelGatewayElement friHJcZlC6KZcSLh2hAe()
	{
		return gAchInZlQASwy08RK7av;
	}
}
