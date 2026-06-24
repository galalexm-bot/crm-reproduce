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
[Shape(typeof(ArtifactDataObjectShape))]
[HintShape(typeof(ArtifactDataObjectHintShape))]
public class ArtifactDataObjectElement : ArtefactTaskElement
{
	[Component(Order = 350)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem BOpLq8vDj4UDcJWjexte;

		public string Name => (string)PXXFaKvD3yFJtmetxvoS(jrs7h7vDqglPupPhZfDR(0x1EA50FCC ^ 0x1EA77FD4));

		public Guid GroupUid => BPMNGroups.Artefacts.UID;

		public Image Image => (Image)dmJyvWvDTPRRClOexESh();

		public Type ElementType => typeof(ArtifactDataObjectElement);

		public string ElementIcon => (string)jrs7h7vDqglPupPhZfDR(-63028171 ^ -63137109);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			lNfOaDvDQ97VIw05ZMHS();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object jrs7h7vDqglPupPhZfDR(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object PXXFaKvD3yFJtmetxvoS(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool h74n5SvDRuAX0lDN3xfY()
		{
			return BOpLq8vDj4UDcJWjexte == null;
		}

		internal static ToolboxItem q54ujpvD66aF3ZCBLc8g()
		{
			return BOpLq8vDj4UDcJWjexte;
		}

		internal static object dmJyvWvDTPRRClOexESh()
		{
			return Resources.dataObject;
		}

		internal static void lNfOaDvDQ97VIw05ZMHS()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static ArtifactDataObjectElement AUy184ZmFSNU9eMjKlFk;

	public override string DefaultName => (string)e1g4KbZmrUA3Lq2EcAe3(Uao1pJZmaVd1RfkfNv7b(0x595C500A ^ 0x595E2012));

	public ArtifactDataObjectElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RgZTD9Zmetx6PlLS7VYs();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Uao1pJZmaVd1RfkfNv7b(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object e1g4KbZmrUA3Lq2EcAe3(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool fB6dbCZmi41g5MHwH2n9()
	{
		return AUy184ZmFSNU9eMjKlFk == null;
	}

	internal static ArtifactDataObjectElement ETypOcZmIoQCHYATtWOK()
	{
		return AUy184ZmFSNU9eMjKlFk;
	}

	internal static void RgZTD9Zmetx6PlLS7VYs()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
