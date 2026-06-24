using System;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;

[Serializable]
[HintShape(typeof(HSwimlaneHintShape))]
[Shape(typeof(HSwimlaneShape))]
[WebDiagrammerShape(typeof(WebDiagrammerHSwimlaneElementShape))]
public class HSwimlaneElement : SwimlaneElement
{
	[Component(Order = 200)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem e7VY2WvPY2DFJD4JZ5oI;

		public string Name => (string)AwShkLvPJCaK0ITRMOub(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -539844905));

		public Guid GroupUid => BPMNGroups.Swimlanes.UID;

		public Image Image => (Image)FbwpTkvPlSkudYwP9uQX();

		public Type ElementType => FCvrPTvP0khJ4Vytl6GP(typeof(HSwimlaneElement).TypeHandle);

		public string ElementIcon => (string)HtmX2uvPyg5FomZmYFXR(-961162596 ^ -961083016);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object AwShkLvPJCaK0ITRMOub(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool f93jxovP8QMcNrlslc7i()
		{
			return e7VY2WvPY2DFJD4JZ5oI == null;
		}

		internal static ToolboxItem k8ci7SvPsA7dJMTyxJej()
		{
			return e7VY2WvPY2DFJD4JZ5oI;
		}

		internal static object FbwpTkvPlSkudYwP9uQX()
		{
			return Resources.symb_swimline_hor;
		}

		internal static Type FCvrPTvP0khJ4Vytl6GP(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object HtmX2uvPyg5FomZmYFXR(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	private static HSwimlaneElement EfTRQ1ZYlbIPGZ7f2Nx0;

	public HSwimlaneElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vGnyeEZYmhJ3SDrRh3PE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void vGnyeEZYmhJ3SDrRh3PE()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool jYdCD8ZY0UpQ5as8AiEE()
	{
		return EfTRQ1ZYlbIPGZ7f2Nx0 == null;
	}

	internal static HSwimlaneElement YJTIsNZYy9q6xRAhqYdZ()
	{
		return EfTRQ1ZYlbIPGZ7f2Nx0;
	}
}
