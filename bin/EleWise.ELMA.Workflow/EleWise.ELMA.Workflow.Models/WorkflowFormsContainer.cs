using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

[Serializable]
[XmlExport]
public class WorkflowFormsContainer : ISerializable
{
	[NonSerialized]
	private string serializedState;

	private List<WorkflowForm> items;

	private static readonly FieldInfo[] serializedFields;

	internal static WorkflowFormsContainer m2LyeaODglRcu5RJTR2n;

	public List<WorkflowForm> Items
	{
		get
		{
			CheckInitialized();
			return items;
		}
		set
		{
			items = value ?? new List<WorkflowForm>();
		}
	}

	public bool IsEmpty
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return jOTBsQODXqW7LqXtEwxV(items) == 0;
				case 1:
					CheckInitialized();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowFormsContainer()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		e9icR2ODPfEVrm5RkPnv();
		items = new List<WorkflowForm>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public virtual FormViewItem CreateFormViewItem(Guid formUid, IWorkflowProcess process, bool checkExists)
	{
		//Discarded unreachable code: IL_0179, IL_019f, IL_01d0, IL_01df
		int num = 13;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		List<WorkflowForm> list = default(List<WorkflowForm>);
		WorkflowForm workflowForm = default(WorkflowForm);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
					num2 = 12;
					continue;
				case 15:
					throw new ArgumentNullException((string)yIOAM3ODdJe5vaIVglaq(-1716629332 ^ -1716633378));
				default:
					list = new List<WorkflowForm>();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					if (!checkExists)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 7;
				case 12:
					_003C_003Ec__DisplayClass6_.formUid = formUid;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
					if (workflowForm != null)
					{
						num2 = 4;
						continue;
					}
					goto case 9;
				case 5:
					if (process != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 15;
				case 10:
					workflowForm = list.FirstOrDefault(_003C_003Ec__DisplayClass6_._003CCreateFormViewItem_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
					{
						num2 = 2;
					}
					continue;
				case 14:
					list.AddRange(((WorkflowFormsContainer)boDDLLODuulBSRZM27fC(workflowProcess)).Items);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
					{
						num2 = 11;
					}
					continue;
				case 11:
					workflowProcess = (IWorkflowProcess)q7WqHtODDkKyfIH8gDOL(workflowProcess);
					num = 8;
					break;
				case 1:
					workflowProcess = process;
					num2 = 3;
					continue;
				case 3:
				case 8:
					if (workflowProcess == null)
					{
						num = 10;
						break;
					}
					goto case 14;
				case 7:
					throw new ObjectNotFoundException(SR.T((string)yIOAM3ODdJe5vaIVglaq(0x6C7F14 ^ 0x6D9D80), ((IProcessHeader)aEhAvbODnkJU72YcrPWT(process)).Name, phaO3WODHWpLteYGasST(process)), _003C_003Ec__DisplayClass6_.formUid);
				case 6:
					return null;
				case 4:
					return workflowForm.CastAsRealType().CreateFormViewItem(process);
				}
				break;
			}
		}
	}

	private void CheckInitialized()
	{
		//Discarded unreachable code: IL_0076, IL_00dc, IL_00eb, IL_017b
		int num = 7;
		int num3 = default(int);
		FieldInfo[] array = default(FieldInfo[]);
		WorkflowFormsContainer workflowFormsContainer = default(WorkflowFormsContainer);
		FieldInfo fieldInfo = default(FieldInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					num3 = 0;
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 8;
					}
					break;
				case 10:
				case 12:
					serializedState = null;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
					{
						num2 = 9;
					}
					break;
				case 1:
					array = serializedFields;
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num2 = 6;
					}
					break;
				default:
					if (workflowFormsContainer == null)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 5:
				case 8:
					if (num3 < array.Length)
					{
						num2 = 2;
						break;
					}
					goto case 10;
				case 4:
					NWN4OeODfBnPKwURYprY(fieldInfo, this, DsbY1MODLJwdYwwiUBy9(fieldInfo, workflowFormsContainer));
					num2 = 13;
					break;
				case 9:
					return;
				case 2:
				case 3:
					fieldInfo = array[num3];
					num2 = 4;
					break;
				case 6:
					return;
				case 7:
					if (serializedState != null)
					{
						workflowFormsContainer = ClassSerializationHelper.DeserializeObjectByXml<WorkflowFormsContainer>(serializedState);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 6;
					}
					break;
				case 13:
					num3++;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
					{
						num2 = 5;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 10;
		}
	}

	public static WorkflowFormsContainer DeserializeByXml(string xml)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (fIMrvlOD9YnqLDi6yZPh(xml))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
					{
						num2 = 0;
					}
					break;
				}
				return new WorkflowFormsContainer
				{
					serializedState = xml
				};
			default:
				return null;
			}
		}
	}

	public WorkflowFormsContainer(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		e9icR2ODPfEVrm5RkPnv();
		items = new List<WorkflowForm>();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				serializedState = (string)yIFY9wODWvn0Ax3n6Xbr(info, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498935015));
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
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
				info.AddValue((string)yIOAM3ODdJe5vaIVglaq(-790221436 ^ -790114470), DIP8pRODji3Fju9msPDI(this, true));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	static WorkflowFormsContainer()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
				{
					num2 = 0;
				}
				continue;
			}
			serializedFields = (from f in Db23qVODR7N7mLPasSbk(typeof(WorkflowFormsContainer).TypeHandle).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where !_003C_003Ec.iHXtZhvYUQg93LevCBlk(f, _003C_003Ec.Lx87WWvYkqXyyMt6CKOc(typeof(NonSerializedAttribute).TypeHandle), true)
				select f).ToArray();
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
			{
				num2 = 2;
			}
		}
	}

	internal static void e9icR2ODPfEVrm5RkPnv()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool IElt71ODBH7X2NeT816t()
	{
		return m2LyeaODglRcu5RJTR2n == null;
	}

	internal static WorkflowFormsContainer AVe9irODcYq1kWq6ZHJM()
	{
		return m2LyeaODglRcu5RJTR2n;
	}

	internal static int jOTBsQODXqW7LqXtEwxV(object P_0)
	{
		return ((List<WorkflowForm>)P_0).Count;
	}

	internal static object yIOAM3ODdJe5vaIVglaq(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object boDDLLODuulBSRZM27fC(object P_0)
	{
		return ((IWorkflowProcess)P_0).Forms;
	}

	internal static object q7WqHtODDkKyfIH8gDOL(object P_0)
	{
		return ((IWorkflowProcess)P_0).Parent;
	}

	internal static object aEhAvbODnkJU72YcrPWT(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static long phaO3WODHWpLteYGasST(object P_0)
	{
		return ((IWorkflowProcess)P_0).VersionNumber;
	}

	internal static object DsbY1MODLJwdYwwiUBy9(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}

	internal static void NWN4OeODfBnPKwURYprY(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static bool fIMrvlOD9YnqLDi6yZPh(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object yIFY9wODWvn0Ax3n6Xbr(object P_0, object P_1)
	{
		return ((SerializationInfo)P_0).GetString((string)P_1);
	}

	internal static object DIP8pRODji3Fju9msPDI(object P_0, bool P_1)
	{
		return ClassSerializationHelper.SerializeObjectByXml(P_0, P_1);
	}

	internal static Type Db23qVODR7N7mLPasSbk(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
