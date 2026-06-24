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
[WebDiagrammerShape(typeof(WebDiagrammerVSwimlaneElementShape))]
[HintShape(typeof(VSwimlaneHintShape))]
[Shape(typeof(VSwimlaneShape))]
public class VSwimlaneElement : SwimlaneElement
{
	[Component(Order = 100)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		private static ToolboxItem L6TP41vPHfvV2BFGhtbm;

		public string Name => SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028861977 ^ -1028778981));

		public Guid GroupUid => BPMNGroups.Swimlanes.UID;

		public Image Image => Resources.symb_swimline_vert;

		public Type ElementType => Dvv5envP9dHGKoFJBlgC(typeof(VSwimlaneElement).TypeHandle);

		public string ElementIcon => (string)wUjB1tvPWrQnBgwpdGny(0x5DB28AD2 ^ 0x5DB056CA);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			kJmIo3vPjrn6O5Q5smi3();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool JdTEExvPLYngl1n4miH0()
		{
			return L6TP41vPHfvV2BFGhtbm == null;
		}

		internal static ToolboxItem aMIlGUvPfxaUJlxFd66p()
		{
			return L6TP41vPHfvV2BFGhtbm;
		}

		internal static Type Dvv5envP9dHGKoFJBlgC(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object wUjB1tvPWrQnBgwpdGny(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void kJmIo3vPjrn6O5Q5smi3()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private static VSwimlaneElement iyUX0qZYIDVkv7UfqVhG;

	public VSwimlaneElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		i6U9grZYefgxnmiTQ7MY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void i6U9grZYefgxnmiTQ7MY()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool nIZr29ZYalnlqI8sFCfP()
	{
		return iyUX0qZYIDVkv7UfqVhG == null;
	}

	internal static VSwimlaneElement kmK7sEZYrFjnSupuvpwr()
	{
		return iyUX0qZYIDVkv7UfqVhG;
	}
}
