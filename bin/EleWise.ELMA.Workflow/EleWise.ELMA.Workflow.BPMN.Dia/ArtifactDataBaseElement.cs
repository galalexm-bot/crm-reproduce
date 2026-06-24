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
[Shape(typeof(ArtifactDataBaseShape))]
[HintShape(typeof(ArtifactDataBaseHintShape))]
public class ArtifactDataBaseElement : ArtefactTaskElement
{
	[Component(Order = 400)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem d3dE3avDD9mgCC735Eeh;

		public string Name => (string)VOXKbuvDLA1boosklYoo(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514289356));

		public Guid GroupUid => BPMNGroups.Artefacts.UID;

		public Image Image => (Image)cFoGagvDfNmmt36MXrVl();

		public Type ElementType => t8hmN6vD9V3Ac7LrUwPM(typeof(ArtifactDataBaseElement).TypeHandle);

		public string ElementIcon => (string)WwvaMOvDWkjjr2fFdUZe(0x4940763B ^ 0x4942A843);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
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

		internal static object VOXKbuvDLA1boosklYoo(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool iEkDyyvDnFBauucqYFDx()
		{
			return d3dE3avDD9mgCC735Eeh == null;
		}

		internal static ToolboxItem acSBRNvDHGCd4WKGDb69()
		{
			return d3dE3avDD9mgCC735Eeh;
		}

		internal static object cFoGagvDfNmmt36MXrVl()
		{
			return Resources.dataBase;
		}

		internal static Type t8hmN6vD9V3Ac7LrUwPM(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object WwvaMOvDWkjjr2fFdUZe(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	internal static ArtifactDataBaseElement ELyETSZmGZkPsqJkdhDt;

	public override string DefaultName => SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574499687));

	public ArtifactDataBaseElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UZStbBZmoOv4EyBjaDMd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool znJqypZm799Rc1eRRcy5()
	{
		return ELyETSZmGZkPsqJkdhDt == null;
	}

	internal static ArtifactDataBaseElement cCDj3mZm2E7bqKni65jn()
	{
		return ELyETSZmGZkPsqJkdhDt;
	}

	internal static void UZStbBZmoOv4EyBjaDMd()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
