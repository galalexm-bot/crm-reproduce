using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;

[Serializable]
[HintShape(typeof(EndEventHintShape))]
[Shape(typeof(EndEventShape))]
public class EndEventElement : EventElement
{
	[Component(Order = 300)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		private static ToolboxItem OiPQhWvuyG48vpt7cZYk;

		public string Name => SR.T((string)dChrQ6vubyGST4HH2HXD(0x12F686A ^ 0x12DF43A));

		public Guid GroupUid => BPMNGroups.Events.UID;

		public Image Image => (Image)f4wuMUvu5rkrmRQ5kHyM();

		public Type ElementType => QS00j7vugGy82AmydAZ0(typeof(EndEventElement).TypeHandle);

		public string ElementIcon => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-106528299 ^ -106668043);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			m4LAKRvuBLsLoBQ1dS9b();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object dChrQ6vubyGST4HH2HXD(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool UZGLQ1vumWRA7YmPq5Yy()
		{
			return OiPQhWvuyG48vpt7cZYk == null;
		}

		internal static ToolboxItem WYhpWLvutvfcehYOhnws()
		{
			return OiPQhWvuyG48vpt7cZYk;
		}

		internal static object f4wuMUvu5rkrmRQ5kHyM()
		{
			return Resources.symb_event_end;
		}

		internal static Type QS00j7vugGy82AmydAZ0(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void m4LAKRvuBLsLoBQ1dS9b()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static EndEventElement HJCy49ZlksKoeyReiqiK;

	protected override int MinOutputFlowsCount => 0;

	protected override int MaxOutputFlowsCount => 0;

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56FA5235) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1002065066)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1394034088) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75BAD659 ^ 0x75B84A09)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398571671));
		stringBuilder.Append(base.HtmlBody(element, contexts, orgStructVersion, subFolders, diagram, (IWorkflowProcess)null, (GenerationSettings)null));
		return stringBuilder.ToString();
	}

	public EndEventElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uLwCiUZlA8KoYVEAcEPD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void uLwCiUZlA8KoYVEAcEPD()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool MOFTwkZlUv1doLqMADsB()
	{
		return HJCy49ZlksKoeyReiqiK == null;
	}

	internal static EndEventElement u3UVJLZlVOJNDEs3FeEi()
	{
		return HJCy49ZlksKoeyReiqiK;
	}
}
