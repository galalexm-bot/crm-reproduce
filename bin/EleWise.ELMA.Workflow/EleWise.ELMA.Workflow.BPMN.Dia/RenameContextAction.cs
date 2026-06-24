using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Artifacts;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;

[Component(Order = 200)]
internal sealed class RenameContextAction : IBPMNElementContextAction
{
	internal static RenameContextAction mUi6RvZOd7OxA2Ok676t;

	public Guid ActionUid => new Guid((string)ua0oOXZOnM3TnpryolaP(-1895853023 ^ -1895962985));

	public string Text => (string)UKdOflZOHdw4JgSbBimt(ua0oOXZOnM3TnpryolaP(0x12F686A ^ 0x12D1B68));

	public string Image => (string)ua0oOXZOnM3TnpryolaP(-2002063381 ^ -2002215733);

	public bool IsSupported(Type type)
	{
		//Discarded unreachable code: IL_003d, IL_010f, IL_011e
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return VOI74sZOLDnMqUpdsu7A(typeof(ArtefactElement).TypeHandle).IsAssignableFrom(type);
			case 2:
			case 5:
				return true;
			default:
				if (!VOI74sZOLDnMqUpdsu7A(typeof(SubProcessElement).TypeHandle).IsAssignableFrom(type))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 6:
				if (typeof(TaskElement).IsAssignableFrom(type))
				{
					num2 = 5;
					break;
				}
				goto case 3;
			case 1:
				if (typeof(CommonEditEntityWorkflowElement).IsAssignableFrom(type))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			case 3:
				if (!VOI74sZOLDnMqUpdsu7A(typeof(SwimlaneElement).TypeHandle).IsAssignableFrom(type))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public RenameContextAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
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

	internal static object ua0oOXZOnM3TnpryolaP(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool rjr80NZOuQvDX9Fjx3Ts()
	{
		return mUi6RvZOd7OxA2Ok676t == null;
	}

	internal static RenameContextAction Ap1IYUZODFY9lDOmeh7T()
	{
		return mUi6RvZOd7OxA2Ok676t;
	}

	internal static object UKdOflZOHdw4JgSbBimt(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static Type VOI74sZOLDnMqUpdsu7A(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
