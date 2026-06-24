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
[HintShape(typeof(ArtifactDocumentHintShape))]
[Shape(typeof(ArtifactDocumentShape))]
public class ArtifactDocumentElement : ArtefactTaskElement
{
	[Component(Order = 550)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem ym8iuvvDpo6MEbhEFQOv;

		public string Name => (string)SCSpKGvDkyWEAFnwWf6k(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895963611));

		public Guid GroupUid => BPMNGroups.Artefacts.UID;

		public Image Image => (Image)DXtBwhvDU6elvwMVNLo3();

		public Type ElementType => t2n7vOvDVrWaoIDrtTjq(typeof(ArtifactDocumentElement).TypeHandle);

		public string ElementIcon => (string)luN5tBvDAREN2PQiJDmZ(0x614CF569 ^ 0x614E2BBB);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			ojyywRvDGh53QUagUeVs();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object SCSpKGvDkyWEAFnwWf6k(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool an709ZvDClCtRRrWGTWd()
		{
			return ym8iuvvDpo6MEbhEFQOv == null;
		}

		internal static ToolboxItem Xtw4hVvDMgdn4meP4kjA()
		{
			return ym8iuvvDpo6MEbhEFQOv;
		}

		internal static object DXtBwhvDU6elvwMVNLo3()
		{
			return Resources.artefactDocument;
		}

		internal static Type t2n7vOvDVrWaoIDrtTjq(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object luN5tBvDAREN2PQiJDmZ(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void ojyywRvDGh53QUagUeVs()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private static ArtifactDocumentElement NSILx4ZmN0ssVxSCg7Sa;

	public override string DefaultName => SR.T((string)aCvhEUZm1kb9JXpufXZ6(-1657582555 ^ -1657717727));

	public ArtifactDocumentElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bkmmfvZmhS82AQCfLWDm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object aCvhEUZm1kb9JXpufXZ6(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool gRvjcUZmxfM53DIuF1f6()
	{
		return NSILx4ZmN0ssVxSCg7Sa == null;
	}

	internal static ArtifactDocumentElement crGk8SZmS3PGyeV0kL4x()
	{
		return NSILx4ZmN0ssVxSCg7Sa;
	}

	internal static void bkmmfvZmhS82AQCfLWDm()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
