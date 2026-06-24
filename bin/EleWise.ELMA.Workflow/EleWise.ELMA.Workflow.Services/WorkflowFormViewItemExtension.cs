using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Component]
internal sealed class WorkflowFormViewItemExtension : IFormViewItemExtension
{
	private static Guid taskGuid;

	private static WorkflowFormViewItemExtension d9eBV7CRsX0j7WC1h5o;

	public bool Check(object entity)
	{
		return entity is IProcessHeader;
	}

	public FormViewItem GetFormViewItem(Guid formUid, object entity, bool checkExists)
	{
		//Discarded unreachable code: IL_0064, IL_0073
		int num = 1;
		int num2 = num;
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			switch (num2)
			{
			case 1:
				processHeader = entity as IProcessHeader;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (processHeader != null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 2:
				return null;
			case 3:
			{
				object obj = dQpqSSCT0UDiAT78HP8(jLBqohC3Fluix4eQvFP(processHeader.Current), formUid, processHeader.Current, false);
				ViewItem viewItem = ((IEnumerable<ViewItem>)OkMwMDCQObBfWI7CXsN(obj)).FirstOrDefault((ViewItem i) => _003C_003Ec.locypsZGgBarbENaekOP(_003C_003Ec.B6WYYEZG5LbvMTJins61(i), taskGuid));
				if (viewItem != null)
				{
					fuu0BCCpLvjvJfq4ykm(viewItem, true);
				}
				YN8cmaCCFQXmj8a8A6k(obj);
				return (FormViewItem)obj;
			}
			}
		}
	}

	public WorkflowFormViewItemExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowFormViewItemExtension()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				taskGuid = new Guid((string)c3gf0SCkUNe5qiO05Np(--1418337216 ^ 0x548AED26));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				KrbDCdCMnZHCTfMcjBO();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool sgCx2bC6BCyvWNH1OQn()
	{
		return d9eBV7CRsX0j7WC1h5o == null;
	}

	internal static WorkflowFormViewItemExtension Hht9hvCqjgmnZcxnfIF()
	{
		return d9eBV7CRsX0j7WC1h5o;
	}

	internal static object jLBqohC3Fluix4eQvFP(object P_0)
	{
		return ((IWorkflowProcess)P_0).Forms;
	}

	internal static object dQpqSSCT0UDiAT78HP8(object P_0, Guid formUid, object P_2, bool checkExists)
	{
		return ((WorkflowFormsContainer)P_0).CreateFormViewItem(formUid, (IWorkflowProcess)P_2, checkExists);
	}

	internal static object OkMwMDCQObBfWI7CXsN(object P_0)
	{
		return ((RootViewItem)P_0).Items;
	}

	internal static void fuu0BCCpLvjvJfq4ykm(object P_0, bool P_1)
	{
		((ViewItem)P_0).Hide = P_1;
	}

	internal static void YN8cmaCCFQXmj8a8A6k(object P_0)
	{
		((RootViewItem)P_0).RemoveHiddenViewItems();
	}

	internal static void KrbDCdCMnZHCTfMcjBO()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object c3gf0SCkUNe5qiO05Np(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
