using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Artifacts;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;

[Component(Order = 1500)]
internal sealed class RunEmulationContextAction : IBPMNElementContextAction
{
	internal static RunEmulationContextAction v0XwQjZOfjal4RHGpxQB;

	public Guid ActionUid => new Guid((string)nfVXXiZOjhPOf7xP7Lxb(0x7AC609FE ^ 0x7AC47ACE));

	public string Text => SR.T((string)nfVXXiZOjhPOf7xP7Lxb(-148495695 ^ -148614707));

	public string Image => (string)nfVXXiZOjhPOf7xP7Lxb(-801808857 ^ -801690221);

	public bool IsSupported(Type type)
	{
		//Discarded unreachable code: IL_0064, IL_0073, IL_0099, IL_00a8
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (!typeof(Element2D).IsAssignableFrom(type))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto default;
				case 1:
					return !avKkSuZORVD2ymnY60Gq(typeof(ArtefactElement).TypeHandle).IsAssignableFrom(type);
				case 2:
				case 4:
					return false;
				default:
					if (avKkSuZORVD2ymnY60Gq(typeof(SwimlaneElement).TypeHandle).IsAssignableFrom(type))
					{
						goto end_IL_0012;
					}
					goto case 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public RunEmulationContextAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object nfVXXiZOjhPOf7xP7Lxb(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool ntC0YpZO9gFugBCsEQ12()
	{
		return v0XwQjZOfjal4RHGpxQB == null;
	}

	internal static RunEmulationContextAction zpLcCnZOWnt6TAG45xD6()
	{
		return v0XwQjZOfjal4RHGpxQB;
	}

	internal static Type avKkSuZORVD2ymnY60Gq(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
