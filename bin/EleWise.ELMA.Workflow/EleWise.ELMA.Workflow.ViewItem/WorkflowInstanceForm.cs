using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.ViewItems;

[Serializable]
public class WorkflowInstanceForm : WorkflowForm, IFormViewItemTransformation
{
	private static WorkflowInstanceForm tsPScA5MmGQ7iAl5paV;

	public FormViewItemTransformation Transformation
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformation_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CTransformation_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public override FormViewItem CreateFormViewItem(IWorkflowProcess process)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_0096
		int num = 6;
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		List<WorkflowForm> list = default(List<WorkflowForm>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 7:
					goto end_IL_0012;
				case 2:
				case 3:
					if (workflowProcess != null)
					{
						num2 = 7;
						continue;
					}
					break;
				case 1:
					workflowProcess = process;
					num2 = 2;
					continue;
				case 8:
					workflowProcess = workflowProcess.Parent;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					throw new ArgumentNullException((string)B090o85VlVA0xa8y3SD(0x141C968 ^ 0x141D91A));
				case 6:
					if (process != null)
					{
						list = new List<WorkflowForm>();
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
						{
							num2 = 5;
						}
					}
					continue;
				}
				return CreateFormViewItem(list, process, null);
				continue;
				end_IL_0012:
				break;
			}
			list.AddRange(((WorkflowFormsContainer)VbPMEN5AsGAstMDepm9(workflowProcess)).Items);
			num = 8;
		}
	}

	internal override FormViewItem CreateFormViewItem(WorkflowProcessDTO process)
	{
		//Discarded unreachable code: IL_0082, IL_0091, IL_00a1
		int num = 1;
		int num2 = num;
		List<WorkflowForm> list = default(List<WorkflowForm>);
		WorkflowProcessDTO workflowProcessDTO = default(WorkflowProcessDTO);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 6:
				list.AddRange(((WorkflowFormsContainer)YeHTHw5GYD6tj0vtm5f(workflowProcessDTO)).Items);
				num2 = 7;
				break;
			case 1:
				if (process == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					list = new List<WorkflowForm>();
					num2 = 8;
				}
				break;
			case 8:
				workflowProcessDTO = process;
				num2 = 5;
				break;
			case 3:
				return CreateFormViewItem(list, null, process);
			case 7:
				workflowProcessDTO = (WorkflowProcessDTO)vsHxE757G0B7OmOq8K3(workflowProcessDTO);
				num2 = 4;
				break;
			default:
				throw new ArgumentNullException((string)B090o85VlVA0xa8y3SD(0x56F860D7 ^ 0x56F870A5));
			case 4:
			case 5:
				if (workflowProcessDTO != null)
				{
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	private FormViewItem CreateFormViewItem(List<WorkflowForm> allForms, IWorkflowProcess process, WorkflowProcessDTO processDto)
	{
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(typeof(IWorkflowInstance));
		FormViewItem formViewItem = null;
		if (base.ParentFormUid != Guid.Empty)
		{
			WorkflowForm workflowForm = allForms.FirstOrDefault((WorkflowForm i) => A0j8CP5oiBZ1wl1ExY0(bsCW6n5234omOsMVP5j(i), base.ParentFormUid));
			if (workflowForm != null)
			{
				if (process != null)
				{
					formViewItem = workflowForm.CreateFormViewItem(process);
				}
				else if (processDto != null)
				{
					formViewItem = workflowForm.CreateFormViewItem(processDto);
				}
			}
		}
		if (formViewItem == null)
		{
			formViewItem = entityMetadata.DefaultForms.GetForm(ViewType.Create);
		}
		if (formViewItem == null)
		{
			throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720439087)));
		}
		FormViewItem formViewItem2 = (FormViewItem)formViewItem.Clone();
		formViewItem2.Uid = base.Uid;
		formViewItem2.Name = base.FormName;
		FormViewItem obj = ((Transformation != null) ? formViewItem2.Transformate(Transformation) : formViewItem2);
		obj.Uid = base.Uid;
		obj.Name = base.FormName;
		obj.DisplayName = base.FormDisplayName;
		obj.MetadataUid = InterfaceActivator.UID<IWorkflowInstance>();
		return obj;
	}

	public WorkflowInstanceForm()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ouA4aE5kQhjxUBcinXQ()
	{
		return tsPScA5MmGQ7iAl5paV == null;
	}

	internal static WorkflowInstanceForm HKgIUZ5UlEldaGsJPdj()
	{
		return tsPScA5MmGQ7iAl5paV;
	}

	internal static object B090o85VlVA0xa8y3SD(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VbPMEN5AsGAstMDepm9(object P_0)
	{
		return ((IWorkflowProcess)P_0).Forms;
	}

	internal static object YeHTHw5GYD6tj0vtm5f(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Forms;
	}

	internal static object vsHxE757G0B7OmOq8K3(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Parent;
	}

	internal static Guid bsCW6n5234omOsMVP5j(object P_0)
	{
		return ((WorkflowForm)P_0).Uid;
	}

	internal static bool A0j8CP5oiBZ1wl1ExY0(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
