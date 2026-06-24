using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;

[Component(Order = int.MaxValue)]
internal sealed class RemoveElementContextAction : IBPMNElementContextAction
{
	internal static RemoveElementContextAction WejLsfZOBNJP7WEN5pkX;

	public Guid ActionUid => new Guid((string)sQneuIZOX2P0PfXkOXpr(0x157D5AF4 ^ 0x157F28AE));

	public string Text => SR.Delete;

	public string Image => (string)sQneuIZOX2P0PfXkOXpr(0x74AB4717 ^ 0x74A935B1);

	public bool IsSupported(Type type)
	{
		return typeof(Element).IsAssignableFrom(type);
	}

	public RemoveElementContextAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object sQneuIZOX2P0PfXkOXpr(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool wK16ZGZOcNIen9jjPMs3()
	{
		return WejLsfZOBNJP7WEN5pkX == null;
	}

	internal static RemoveElementContextAction d7njssZOPcik5QgIDsCe()
	{
		return WejLsfZOBNJP7WEN5pkX;
	}
}
