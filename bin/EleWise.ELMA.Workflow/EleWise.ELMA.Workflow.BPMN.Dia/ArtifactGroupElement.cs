using System;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Artifacts;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Artifacts;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Serializable]
[Shape(typeof(ArtifactGroupElementShape))]
[HintShape(typeof(ArtifactGroupElementHintShape))]
public class ArtifactGroupElement : ArtefactElement
{
	[Component(Order = 300)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem dXhAhfvD7eCDFhs6dg41;

		public string Name => (string)FBi02HvDi8pBwTjgTOPi(BA4sV8vDFBrX3r7f8dyj(-682910880 ^ -683048634));

		public Guid GroupUid => BPMNGroups.Artefacts.UID;

		public Image Image => (Image)KKLyKAvDIM15fMnevVjX();

		public Type ElementType => typeof(ArtifactGroupElement);

		public string ElementIcon => (string)BA4sV8vDFBrX3r7f8dyj(0x56A753C9 ^ 0x56A58D31);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			aioQd5vDaDfWLonUm3Xe();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object BA4sV8vDFBrX3r7f8dyj(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object FBi02HvDi8pBwTjgTOPi(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool tQpeqfvD2OtVosCEHbAQ()
		{
			return dXhAhfvD7eCDFhs6dg41 == null;
		}

		internal static ToolboxItem xkv64AvDo4Y0xJWPRKvU()
		{
			return dXhAhfvD7eCDFhs6dg41;
		}

		internal static object KKLyKAvDIM15fMnevVjX()
		{
			return Resources.artefactGroup;
		}

		internal static void aioQd5vDaDfWLonUm3Xe()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static ArtifactGroupElement tyg0hTZmERTyQkp9WRbP;

	public override string DefaultName => (string)YFF98WZtKCGoMeXI2IMm(IvToGWZmzdT7tCQtcSVK(-11799394 ^ -11968636));

	public ArtifactGroupElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object IvToGWZmzdT7tCQtcSVK(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object YFF98WZtKCGoMeXI2IMm(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool rdsONtZmwscEWmGbXW4c()
	{
		return tyg0hTZmERTyQkp9WRbP == null;
	}

	internal static ArtifactGroupElement uOE1iJZm42wFxH0Y7s89()
	{
		return tyg0hTZmERTyQkp9WRbP;
	}
}
