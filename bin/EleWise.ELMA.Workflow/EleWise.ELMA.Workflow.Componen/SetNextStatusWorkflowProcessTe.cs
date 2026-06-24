using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component(Order = 30)]
public class SetNextStatusWorkflowProcessTerminateAction : IStatusWorkflowProcessTerminateAction
{
	public static Guid UID;

	internal static SetNextStatusWorkflowProcessTerminateAction xhDisDOg6uvCUSOYA0IB;

	public string Name => (string)famfm3OgT7F3YLBhFqZV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708110116));

	public Guid Uid => UID;

	public void Execute(IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_00b8, IL_00c7
		int num = 5;
		int num2 = num;
		int num3 = default(int);
		DropDownListSettings dropDownListSettings = default(DropDownListSettings);
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			default:
				if (num3 >= W4TZGlOgVoZQbYlIHihM(FtWVJEOgU6Qy3pmm9wA6(dropDownListSettings)) - 1)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 9;
			case 6:
				_003C_003Ec__DisplayClass5_.currentValue = (DropDownItem)((Entity<long>)PHM2DgOgCBqItYpfvc2e(instance)).GetPropertyValue(instance.Process.StatusContextVar);
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 7:
				return;
			case 5:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				num3 = ((IEnumerable<DropDownItem>)FtWVJEOgU6Qy3pmm9wA6(dropDownListSettings)).TakeWhile(_003C_003Ec__DisplayClass5_._003CExecute_003Eb__0).Count();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				jlHF0rOgAfvZlBHjKy2q(PHM2DgOgCBqItYpfvc2e(instance), instance.Process.StatusContextVar, ((List<DropDownItem>)FtWVJEOgU6Qy3pmm9wA6(dropDownListSettings))[num3 + 1]);
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
				{
					num2 = 10;
				}
				break;
			case 10:
				return;
			case 3:
				if (FtWVJEOgU6Qy3pmm9wA6(dropDownListSettings) == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (!fxB50FOgpBhKSCXRV6Jb(((IWorkflowProcess)JS6c5aOgQyynYcXP2dJB(instance)).StatusContextVar, Guid.Empty))
				{
					dropDownListSettings = (DropDownListSettings)gsmQwVOgkT0wRs4eSETU(PHM2DgOgCBqItYpfvc2e(instance), gaDmqSOgMhJSJ2qw3Gyt(instance.Process));
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
					{
						num2 = 4;
					}
				}
				else
				{
					num2 = 7;
				}
				break;
			case 8:
				if (dropDownListSettings == null)
				{
					return;
				}
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public SetNextStatusWorkflowProcessTerminateAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uKBB1kOgGPAUCBbifQNR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static SetNextStatusWorkflowProcessTerminateAction()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)u6OtsqOg7YhOoV3BkCGd(0x8D5763A ^ 0x8D4BCE2));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				uKBB1kOgGPAUCBbifQNR();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object famfm3OgT7F3YLBhFqZV(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool oXety9OgqxcMcjYMj739()
	{
		return xhDisDOg6uvCUSOYA0IB == null;
	}

	internal static SetNextStatusWorkflowProcessTerminateAction BRlVPBOg3oimmgWlHNQy()
	{
		return xhDisDOg6uvCUSOYA0IB;
	}

	internal static object JS6c5aOgQyynYcXP2dJB(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static bool fxB50FOgpBhKSCXRV6Jb(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object PHM2DgOgCBqItYpfvc2e(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static Guid gaDmqSOgMhJSJ2qw3Gyt(object P_0)
	{
		return ((IWorkflowProcess)P_0).StatusContextVar;
	}

	internal static object gsmQwVOgkT0wRs4eSETU(object P_0, Guid P_1)
	{
		return ((Entity<long>)P_0).GetPropertySettings(P_1);
	}

	internal static object FtWVJEOgU6Qy3pmm9wA6(object P_0)
	{
		return ((DropDownListSettings)P_0).Items;
	}

	internal static int W4TZGlOgVoZQbYlIHihM(object P_0)
	{
		return ((List<DropDownItem>)P_0).Count;
	}

	internal static void jlHF0rOgAfvZlBHjKy2q(object P_0, Guid P_1, object P_2)
	{
		((Entity<long>)P_0).SetPropertyValue(P_1, P_2);
	}

	internal static void uKBB1kOgGPAUCBbifQNR()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object u6OtsqOg7YhOoV3BkCGd(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
