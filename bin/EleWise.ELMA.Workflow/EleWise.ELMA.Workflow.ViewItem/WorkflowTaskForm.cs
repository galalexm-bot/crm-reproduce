using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.ViewItems;

[Serializable]
public class WorkflowTaskForm : WorkflowForm, IFormViewItemTransformation
{
	internal static WorkflowTaskForm r3lwGtgaD1EZt2MHIHP;

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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
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

	public Guid TaskMetadataUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTaskMetadataUid_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CTaskMetadataUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override FormViewItem CreateFormViewItem(IWorkflowProcess process)
	{
		//Discarded unreachable code: IL_011c, IL_012b
		int num = 3;
		int num2 = num;
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		List<WorkflowForm> list = default(List<WorkflowForm>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862326732));
			case 7:
				workflowProcess = process;
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				workflowProcess = (IWorkflowProcess)VfB3gagx30wfmmAlf62(workflowProcess);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (workflowProcess == null)
				{
					num2 = 4;
					break;
				}
				goto case 5;
			case 3:
				if (process != null)
				{
					list = new List<WorkflowForm>();
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num2 = 7;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
					{
						num2 = 1;
					}
				}
				break;
			case 5:
				list.AddRange(((WorkflowFormsContainer)Dh2MPrgNUF8TFoHhj0e(workflowProcess)).Items);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return CreateFormViewItem(list, process, null);
			}
		}
	}

	internal override FormViewItem CreateFormViewItem(WorkflowProcessDTO process)
	{
		//Discarded unreachable code: IL_0061
		int num = 2;
		WorkflowProcessDTO workflowProcessDTO = default(WorkflowProcessDTO);
		List<WorkflowForm> list = default(List<WorkflowForm>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (process == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto end_IL_0012;
				case 1:
					throw new ArgumentNullException((string)p6S8Y0gSyJvoAfm7gx2(-790221436 ^ -790217226));
				default:
					if (workflowProcessDTO == null)
					{
						num2 = 4;
						continue;
					}
					break;
				case 3:
					workflowProcessDTO = (WorkflowProcessDTO)rwDUkxg11dWmEEdLoKk(workflowProcessDTO);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					workflowProcessDTO = process;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return CreateFormViewItem(list, null, process);
				case 5:
					break;
				}
				list.AddRange(workflowProcessDTO.Forms.Items);
				num2 = 3;
				continue;
				end_IL_0012:
				break;
			}
			list = new List<WorkflowForm>();
			num = 6;
		}
	}

	private FormViewItem CreateFormViewItem(List<WorkflowForm> allForms, IWorkflowProcess process, WorkflowProcessDTO processDto)
	{
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		Guid guid = ((TaskMetadataUid != Guid.Empty) ? TaskMetadataUid : InterfaceActivator.UID<IWorkflowTask>());
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(guid);
		CS_0024_003C_003E8__locals0.baseForm = null;
		if (base.ParentFormUid != Guid.Empty)
		{
			WorkflowForm workflowForm = allForms.FirstOrDefault((WorkflowForm i) => _003C_003Ec__DisplayClass10_0.uQmSU5ZRwHidxDKgk83s(i) == CS_0024_003C_003E8__locals0._003C_003E4__this.ParentFormUid);
			if (workflowForm != null)
			{
				if (process != null)
				{
					CS_0024_003C_003E8__locals0.baseForm = workflowForm.CreateFormViewItem(process);
				}
				else if (processDto != null)
				{
					CS_0024_003C_003E8__locals0.baseForm = workflowForm.CreateFormViewItem(processDto);
				}
			}
		}
		if (CS_0024_003C_003E8__locals0.baseForm == null)
		{
			CS_0024_003C_003E8__locals0.baseForm = entityMetadata.DefaultForms.GetForm(ViewType.Edit);
		}
		if (CS_0024_003C_003E8__locals0.baseForm == null)
		{
			throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B7BF96)));
		}
		FormViewItemTransformation cacheData = ContextCacheExtensions.GetCacheData(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x1019DF7), CS_0024_003C_003E8__locals0.baseForm.Uid, base.Uid, base.FormName, delegate
		{
			FormViewItemTransformation obj2 = new FormViewItemTransformation
			{
				Items = { (ViewItemTransformation)new ViewItemTransformationChange
				{
					Uid = CS_0024_003C_003E8__locals0.baseForm.Uid,
					PropertyName = (string)_003C_003Ec__DisplayClass10_0.BkJEZkZR4Zp5jAdB8ESh(0x5DB28AD2 ^ 0x5DB2CCAE),
					Value = CS_0024_003C_003E8__locals0._003C_003E4__this.Uid
				} }
			};
			List<ViewItemTransformation> items = obj2.Items;
			ViewItemTransformationChange obj3 = new ViewItemTransformationChange
			{
				Uid = CS_0024_003C_003E8__locals0._003C_003E4__this.Uid
			};
			_003C_003Ec__DisplayClass10_0.SF2CgSZRz9ki3AM6IbP0(obj3, _003C_003Ec__DisplayClass10_0.BkJEZkZR4Zp5jAdB8ESh(-452127399 ^ -452111401));
			_003C_003Ec__DisplayClass10_0.FNBmQ8Z6K0gZq8S4ZH4Q(obj3, CS_0024_003C_003E8__locals0._003C_003E4__this.FormName);
			items.Add(obj3);
			return obj2;
		});
		FormViewItem formViewItem = CS_0024_003C_003E8__locals0.baseForm.Transformate(cacheData);
		FormViewItem obj = ((Transformation != null) ? formViewItem.Transformate(Transformation) : formViewItem);
		obj.Uid = base.Uid;
		obj.Name = base.FormName;
		obj.DisplayName = base.FormDisplayName;
		obj.MetadataUid = guid;
		return obj;
	}

	public WorkflowTaskForm()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		x89URgghyhewg7ab4Hj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool iNiXZ3grDHSdx8HU48H()
	{
		return r3lwGtgaD1EZt2MHIHP == null;
	}

	internal static WorkflowTaskForm KBJB1QgeWlgfljwPy0f()
	{
		return r3lwGtgaD1EZt2MHIHP;
	}

	internal static object Dh2MPrgNUF8TFoHhj0e(object P_0)
	{
		return ((IWorkflowProcess)P_0).Forms;
	}

	internal static object VfB3gagx30wfmmAlf62(object P_0)
	{
		return ((IWorkflowProcess)P_0).Parent;
	}

	internal static object p6S8Y0gSyJvoAfm7gx2(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object rwDUkxg11dWmEEdLoKk(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Parent;
	}

	internal static void x89URgghyhewg7ab4Hj()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
