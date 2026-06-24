using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component(Order = 100)]
public class RunScriptStatusWorkflowProcessTerminateAction : IStatusWorkflowProcessTerminateAction
{
	public static Guid UID;

	internal static RunScriptStatusWorkflowProcessTerminateAction o3jRnBNgE7HyUZOidWn;

	public string Name => (string)tlJFb8NztCJ6fZWLAiB(EP9ZvmNZHQoD0r8ZPe0(0x7AADECE0 ^ 0x7AAD6DE2));

	public Guid Uid => UID;

	public void Execute(IWorkflowInstance instance)
	{
		int num = 1;
		int num2 = num;
		IWorkflowScriptingService service = default(IWorkflowScriptingService);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				return;
			case 2:
				service.ExecuteScript(instance, (string)fB73GxdEGysl1toBCNs(b5sc2WdCMowu1rnHhOy(instance)));
				num2 = 4;
				break;
			case 1:
				if (string.IsNullOrEmpty((string)fB73GxdEGysl1toBCNs(instance.Process)))
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22e71f1d40564f3ab8f9ac9108d98dcb == 0)
					{
						num2 = 0;
					}
					break;
				}
				service = Locator.GetService<IWorkflowScriptingService>();
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 3:
				if (service == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public RunScriptStatusWorkflowProcessTerminateAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RZ9fhcdXxABbqT7UhEC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f679e84d83df40c6973457c358e7e4e4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static RunScriptStatusWorkflowProcessTerminateAction()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4244DF13 ^ 0x42445E35));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				RZ9fhcdXxABbqT7UhEC();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object EP9ZvmNZHQoD0r8ZPe0(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object tlJFb8NztCJ6fZWLAiB(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool TughLtN1ZkayRXQSDoR()
	{
		return o3jRnBNgE7HyUZOidWn == null;
	}

	internal static RunScriptStatusWorkflowProcessTerminateAction vX4GJUNIJKSvP02FMPc()
	{
		return o3jRnBNgE7HyUZOidWn;
	}

	internal static object fB73GxdEGysl1toBCNs(object P_0)
	{
		return ((IWorkflowProcess)P_0).StatusTerminateScript;
	}

	internal static object b5sc2WdCMowu1rnHhOy(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static void RZ9fhcdXxABbqT7UhEC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
