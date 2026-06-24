using System;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Artifacts;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Serializable]
[HintShape(typeof(AnnotationHintShape))]
[Shape(typeof(AnnotationElementShape))]
public class AnnotationElement : ArtefactTaskElement
{
	[Component(Order = 300)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		private static ToolboxItem VLTjnUvD5MwSrZYYB6w3;

		public string Name => (string)IR6YKvvDP9trPahhSgHW(b4c9MCvDcTpf504Vsa7O(0x75BAD659 ^ 0x75B87D5D));

		public Guid GroupUid => BPMNGroups.Artefacts.UID;

		public Image Image => (Image)digOY5vDXjgdARyYH7dx();

		public Type ElementType => es5arKvDdYcl78cGrdMq(typeof(AnnotationElement).TypeHandle);

		public string ElementIcon => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11796548);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			YTAOI6vDuGycrM2TulT3();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object b4c9MCvDcTpf504Vsa7O(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object IR6YKvvDP9trPahhSgHW(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool KdLGj5vDgoPckJdd2M6M()
		{
			return VLTjnUvD5MwSrZYYB6w3 == null;
		}

		internal static ToolboxItem A0sXBjvDB1YomYI7EVdp()
		{
			return VLTjnUvD5MwSrZYYB6w3;
		}

		internal static object digOY5vDXjgdARyYH7dx()
		{
			return Resources.annotation;
		}

		internal static Type es5arKvDdYcl78cGrdMq(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void YTAOI6vDuGycrM2TulT3()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private static AnnotationElement qxyssPZmMYOK8BPeXEQh;

	public override string DefaultName => SR.T((string)dalgq8ZmVW3tubYN9RSq(0x34EA50D4 ^ 0x34E8FBD0));

	public AnnotationElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VIpJfdZmA4Hq1oh20sMp();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object dalgq8ZmVW3tubYN9RSq(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool IXxsrwZmk2JQcWRiu1JU()
	{
		return qxyssPZmMYOK8BPeXEQh == null;
	}

	internal static AnnotationElement vMOTVhZmUcj37K8AbuPP()
	{
		return qxyssPZmMYOK8BPeXEQh;
	}

	internal static void VIpJfdZmA4Hq1oh20sMp()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
