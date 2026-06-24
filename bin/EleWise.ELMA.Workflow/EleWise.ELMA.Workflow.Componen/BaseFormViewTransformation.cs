using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component(Order = int.MaxValue)]
public class BaseFormViewTransformation : IElementWithViewTransformation
{
	private static BaseFormViewTransformation Fi9N3mO8zTYecqFpIpVB;

	public virtual bool AcceptableElement(IElementWithView element)
	{
		return true;
	}

	public virtual FormView GetFormView(IElementWithView element, IWorkflowTaskBase task)
	{
		return (FormView)WouGjOOsZCRtJy2J8TRw(element);
	}

	public BaseFormViewTransformation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dAcHu6OsvvSSaILgiQoC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object WouGjOOsZCRtJy2J8TRw(object P_0)
	{
		return ((IElementWithView)P_0).View;
	}

	internal static void dAcHu6OsvvSSaILgiQoC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool RFwRVkOsKf5HdBKXXUQ1()
	{
		return Fi9N3mO8zTYecqFpIpVB == null;
	}

	internal static BaseFormViewTransformation dYUp8FOsOGiEZvRfIIo2()
	{
		return Fi9N3mO8zTYecqFpIpVB;
	}
}
