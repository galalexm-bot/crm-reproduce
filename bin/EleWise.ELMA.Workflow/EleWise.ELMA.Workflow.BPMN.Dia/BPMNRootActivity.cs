using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities;

public class BPMNRootActivity : WorkflowRootActivity
{
	[Component]
	public class Info : IWorkflowRootActivityInfo
	{
		internal static Info igTNALvHHPDSQE8KVRS1;

		public Type ActivityType => RH2K2DvH9Pblq9q6xi8a(typeof(BPMNRootActivity).TypeHandle);

		public Type DiagramType => RH2K2DvH9Pblq9q6xi8a(typeof(BPMNDiagram).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type RH2K2DvH9Pblq9q6xi8a(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool aNM8YxvHLXvrMV8Oomnr()
		{
			return igTNALvHHPDSQE8KVRS1 == null;
		}

		internal static Info I25KwxvHfiwFQhsKeUh2()
		{
			return igTNALvHHPDSQE8KVRS1;
		}
	}

	private static BPMNRootActivity b5UAGYZgvlVlM9OH29ra;

	protected override bool IsStartElement(FlowElement element)
	{
		return element is StartEventElement;
	}

	public BPMNRootActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Mhif5RZgsHiX4PmdPXeI();
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

	internal static bool QudMRQZgY3ExmN1ToOt9()
	{
		return b5UAGYZgvlVlM9OH29ra == null;
	}

	internal static BPMNRootActivity ymNR8TZg8XZ9aExHFrq8()
	{
		return b5UAGYZgvlVlM9OH29ra;
	}

	internal static void Mhif5RZgsHiX4PmdPXeI()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
