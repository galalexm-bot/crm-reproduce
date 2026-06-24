using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component(Order = 100)]
public class ProcessContextTypeResolver : ITypeWrapperResolver
{
	public static Guid UID;

	private static ProcessContextTypeResolver GsFOo8OgsCkxppLVdHmw;

	public Guid Uid => UID;

	public string Caption => (string)Jl9Rs8OgyTAwtxvnBfnP(hpou1MOg0K5Cg9UPDeSE(-39189604 ^ -39073036));

	public object GetObjectInstance(string typeDescriptor)
	{
		//Discarded unreachable code: IL_008b, IL_009a, IL_017e
		int num = 8;
		int num2 = num;
		ProcessContextTypeDescriptor processContextTypeDescriptor = default(ProcessContextTypeDescriptor);
		IProcessHeader processHeader = default(IProcessHeader);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (processContextTypeDescriptor != null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 9;
			case 1:
				if (processHeader != null)
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 2;
			case 2:
				return null;
			case 6:
				if (RdOh5UOgbdZH1IJ20vcS(processHeader) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					type = GgdGBhOgBQE9vUHCjmK0(Locator.GetServiceNotNull<WorkflowInstanceContextService>(), RdOh5UOgbdZH1IJ20vcS(processHeader));
					num2 = 5;
				}
				break;
			default:
				throw new ArgumentNullException((string)Qn6BBEOggPow0L6IiR6N(hpou1MOg0K5Cg9UPDeSE(0x12F686A ^ 0x12EA1CE), new object[1] { Jl9Rs8OgyTAwtxvnBfnP(XO9uoNOg5WCYuggvrZdl(processHeader)) }));
			case 8:
				processContextTypeDescriptor = ClassSerializationHelper.DeserializeObjectByXml<ProcessContextTypeDescriptor>(typeDescriptor);
				num2 = 7;
				break;
			case 9:
				return null;
			case 4:
				processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)scMwhLOgmUV5IFlaLV5w()).LoadOrNull(qwbI8lOgtQFpV9sNeF5e(processContextTypeDescriptor));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (xIcnugOgc7OqwTX3KNS6(type, null))
				{
					num2 = 3;
					break;
				}
				return c1oyolOgPW28sDo7b4L3(type);
			case 3:
				return null;
			}
		}
	}

	public string GetObjectInstanceDescriptor(object property)
	{
		//Discarded unreachable code: IL_006e, IL_01f3
		int num = 2;
		int num2 = num;
		FilterForAttribute attribute = default(FilterForAttribute);
		IMetadata metadata = default(IMetadata);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (attribute == null)
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					metadata = (IMetadata)WArIy6Ogdmg1jD8XdmvE(bnVlJYOgXIeQCBfWoVO9(attribute), true, true);
					num2 = 3;
				}
				break;
			case 9:
				return null;
			case 6:
				attribute = AttributeHelper<FilterForAttribute>.GetAttribute(((Filter)property).GetType(), inherited: true);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				return null;
			case 7:
			{
				ProcessContextTypeDescriptor processContextTypeDescriptor = new ProcessContextTypeDescriptor();
				KZHO8vOgjIEqeLXSJ127(processContextTypeDescriptor, ((IEntity<long>)EraHPDOgWQUi4p8KHNHW(workflowProcess)).Id);
				return (string)dWypoxOgR90mkNkdUqCl(processContextTypeDescriptor, true);
			}
			case 2:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return null;
			case 3:
				_003C_003Ec__DisplayClass6_.contextDesc = EntityManager<ProcessContext>.Instance.LoadOrNull(metadata.Uid);
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
				{
					num2 = 9;
				}
				break;
			case 1:
				if (property != null)
				{
					num2 = 6;
					break;
				}
				goto case 9;
			default:
				if (workflowProcess != null)
				{
					num2 = 7;
					break;
				}
				goto case 8;
			case 10:
			{
				IEntityManager<IWorkflowProcess> instance = EntityManager<IWorkflowProcess>.Instance;
				ParameterExpression parameterExpression = (ParameterExpression)HJ7RmsOgudt9AXkiMLHS(typeof(IWorkflowProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EA5F6E));
				workflowProcess = instance.Find(Expression.Lambda<Func<IWorkflowProcess, bool>>((Expression)xV3d8XOg9uU9SdZZvW8k(iCqa9kOgnaMRyQqe52PE(parameterExpression, (MethodInfo)R3UhVTOgDqsCAP9CD8Ng((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), UCNwMUOgfm44VtE4ivGm(XlvCYkOgLHkYgbr1CxBt(_003C_003Ec__DisplayClass6_, BiodOKOgHJrjYFow7GVw(typeof(_003C_003Ec__DisplayClass6_0).TypeHandle)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public override string ToString()
	{
		return Caption;
	}

	public ProcessContextTypeResolver()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessContextTypeResolver()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)hpou1MOg0K5Cg9UPDeSE(0x8D5763A ^ 0x8D4BC76));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object hpou1MOg0K5Cg9UPDeSE(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Jl9Rs8OgyTAwtxvnBfnP(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool wVNUK2OgJHAVppVyMpW8()
	{
		return GsFOo8OgsCkxppLVdHmw == null;
	}

	internal static ProcessContextTypeResolver yFOEndOgll1jjE0fvC0m()
	{
		return GsFOo8OgsCkxppLVdHmw;
	}

	internal static object scMwhLOgmUV5IFlaLV5w()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static long qwbI8lOgtQFpV9sNeF5e(object P_0)
	{
		return ((ProcessContextTypeDescriptor)P_0).ProcessHeaderId;
	}

	internal static object RdOh5UOgbdZH1IJ20vcS(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static object XO9uoNOg5WCYuggvrZdl(object P_0)
	{
		return ((IProcessHeader)P_0).Name;
	}

	internal static object Qn6BBEOggPow0L6IiR6N(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static Type GgdGBhOgBQE9vUHCjmK0(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceContextFilterType((IWorkflowProcess)P_1);
	}

	internal static bool xIcnugOgc7OqwTX3KNS6(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object c1oyolOgPW28sDo7b4L3(Type P_0)
	{
		return InterfaceActivator.Create(P_0);
	}

	internal static Type bnVlJYOgXIeQCBfWoVO9(object P_0)
	{
		return ((FilterForAttribute)P_0).EntityType;
	}

	internal static object WArIy6Ogdmg1jD8XdmvE(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object HJ7RmsOgudt9AXkiMLHS(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object R3UhVTOgDqsCAP9CD8Ng(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object iCqa9kOgnaMRyQqe52PE(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static Type BiodOKOgHJrjYFow7GVw(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object XlvCYkOgLHkYgbr1CxBt(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object UCNwMUOgfm44VtE4ivGm(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object xV3d8XOg9uU9SdZZvW8k(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object EraHPDOgWQUi4p8KHNHW(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static void KZHO8vOgjIEqeLXSJ127(object P_0, long value)
	{
		((ProcessContextTypeDescriptor)P_0).ProcessHeaderId = value;
	}

	internal static object dWypoxOgR90mkNkdUqCl(object P_0, bool P_1)
	{
		return ClassSerializationHelper.SerializeObjectByXml(P_0, P_1);
	}
}
