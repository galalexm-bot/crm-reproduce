using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Diagrams;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Diagrams.Elements;

[Serializable]
public abstract class FlowElement : ValidatableElement2D, IWorkflowElement
{
	private static FlowElement gqIwFWhGXThxB15k3lG;

	[XmlIgnore]
	public List<Connector> OutputFlows => base.OutputConnectors.Where((Connector c) => c is IFlowConnector).ToList();

	[XmlIgnore]
	public List<Connector> InputFlows => base.InputConnectors.Where((Connector c) => c is IFlowConnector).ToList();

	protected FlowElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Hwxqb3hoDKXyt28wxEG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[SpecialName]
	Guid IWorkflowElement.get_Uid()
	{
		return MeMTfqhFOLXhhHykyYV(this);
	}

	internal static void Hwxqb3hoDKXyt28wxEG()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool FZJnhTh7vVfONpRKhVB()
	{
		return gqIwFWhGXThxB15k3lG == null;
	}

	internal static FlowElement bu5auRh2uMYHxweMcKc()
	{
		return gqIwFWhGXThxB15k3lG;
	}

	internal static Guid MeMTfqhFOLXhhHykyYV(object P_0)
	{
		return ((Element)P_0).Uid;
	}
}
