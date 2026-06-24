using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal sealed class ProcessEQLTemplateProvider : IEQLTemplateProvider
{
	private readonly WorkflowTaskBaseManager workflowTaskBaseManager;

	private readonly ViewModelDescriptor viewModelDescriptor;

	private static ProcessEQLTemplateProvider HVug1COliNHvJn6e0K9K;

	public ProcessEQLTemplateProvider(WorkflowTaskBaseManager workflowTaskBaseManager, ViewModelDescriptor viewModelDescriptor)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Hc4Qu9OlrUIAECfiJcbs();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.workflowTaskBaseManager = workflowTaskBaseManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
				{
					num = 0;
				}
				break;
			default:
				this.viewModelDescriptor = viewModelDescriptor;
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	public bool Check(Guid typeUid, Guid subTypeUid)
	{
		return typeUid == ProcessContext.ProcessContextUid;
	}

	public object GetObjectInfo(Guid typeUid, Guid subTypeUid, string model)
	{
		//Discarded unreachable code: IL_008d, IL_009c, IL_015b, IL_017b, IL_01ad, IL_0314, IL_036c, IL_03d3
		int num = 20;
		string text2 = default(string);
		ProcessContext processContext = default(ProcessContext);
		Type type = default(Type);
		Assembly assembly = default(Assembly);
		string text = default(string);
		ScriptModule scriptModule = default(ScriptModule);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		DataClassMetadata viewModelMetadata = default(DataClassMetadata);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 13:
				case 15:
					text2 = (string)pFBnGTO0ZYXkf8fVug56(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4FD00585 ^ 0x4FD1B207), VdfbFAO0KcLOoAhYFL9J(processContext), ccDw98O0OcSuHpxKXoZK(-949717965 ^ -949632113));
					num2 = 2;
					continue;
				case 16:
					type = BPtFFmO0vFjxR9loy7Rr(assembly, text);
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
					{
						num2 = 14;
					}
					continue;
				case 8:
					scriptModule = workflowProcess.ScriptModule;
					num2 = 3;
					continue;
				case 1:
					return DeserializeViewModelContext(model, viewModelMetadata, type);
				case 5:
				case 10:
					fPlIuvO0JL4CeLVBM8FJ(new EntityJsonSerializer(), model, fKiReuO0sYPkEfZ77Pxc(workflowInstance).GetType(), true);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 1;
					}
					continue;
				case 25:
					if (viewModelMetadata != null)
					{
						num2 = 17;
						continue;
					}
					goto case 18;
				case 12:
					workflowProcess = (IWorkflowProcess)klEWJFOlSp2A6klUOg15(workflowProcess);
					num2 = 23;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
					{
						num2 = 21;
					}
					continue;
				case 24:
					assembly = (Assembly)iono2WOlEo2GyDe99K86(kE9KoqOlhQKAwXgMRx70(scriptModule), false);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
					{
						num2 = 4;
					}
					continue;
				case 19:
					workflowInstance = (IWorkflowInstance)VTw928OleF5nI2mdP1FT(workflowTaskBase.WorkflowBookmark);
					num2 = 21;
					continue;
				case 26:
					text = (string)VEhMG5O08bwkraZcCWDf(new string[5]
					{
						(string)ccDw98O0OcSuHpxKXoZK(-961162596 ^ -961256162),
						processContext.Name,
						(string)ccDw98O0OcSuHpxKXoZK(-1638225214 ^ -1638195930),
						(string)VdfbFAO0KcLOoAhYFL9J(processContext),
						(string)ccDw98O0OcSuHpxKXoZK(0x56F860D7 ^ 0x56F9D72D)
					});
					num2 = 16;
					continue;
				case 20:
					break;
				default:
					scriptModule = (ScriptModule)dv5SgDOl1g28mCQSvnLW(klEWJFOlSp2A6klUOg15(workflowProcess));
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
					{
						num2 = 12;
					}
					continue;
				case 2:
					if (!HrIdVgO0YPgg3VbITwZq(BPtFFmO0vFjxR9loy7Rr(assembly, text2), null))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 26;
				case 11:
					processContext = (ProcessContext)yuQDYuOlxZRdMvdhA01e(workflowProcess);
					num2 = 22;
					continue;
				case 14:
					if (HrIdVgO0YPgg3VbITwZq(type, null))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				case 6:
					return workflowTaskBase;
				case 3:
				case 23:
					if (klEWJFOlSp2A6klUOg15(workflowProcess) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 24;
				case 9:
					assembly = (Assembly)MHWq4DOlzOt6nveR95rf(scriptModule.AssemblyRaw, VVhtQhOl4raWfdDbCmCv(scriptModule));
					num2 = 15;
					continue;
				case 18:
					obj = null;
					goto IL_040b;
				case 4:
					if (!MYiQOVOlwSdjkqTf5sMj(assembly, null))
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 9;
				case 21:
					workflowProcess = (IWorkflowProcess)bBl3jbOlNy3MWtbtDttj(workflowInstance);
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
					{
						num2 = 0;
					}
					continue;
				case 22:
					viewModelMetadata = processContext.ViewModelMetadata;
					num2 = 25;
					continue;
				case 17:
					{
						obj = viewModelMetadata.Properties.Find(delegate(PropertyMetadata property)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return (string)_003C_003Ec.bZR5CevOBLxGWTMXOTw4(property) == SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393869066);
								case 1:
									if (!_003C_003Ec.Ikh25bvOgqhe4htxf7GA(property))
									{
										return false;
									}
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						});
						goto IL_040b;
					}
					IL_040b:
					if (obj == null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 8;
				}
				break;
			}
			workflowTaskBase = workflowTaskBaseManager.Load(subTypeUid);
			num = 19;
		}
	}

	private object DeserializeViewModelContext(string model, DataClassMetadata viewModelContextMetadata, Type viewModelContextType)
	{
		int num = 5;
		int num2 = num;
		Dictionary<string, object> values = default(Dictionary<string, object>);
		ExpandoObject value = default(ExpandoObject);
		IActionExecutionParamModel actionExecutionParamModel = default(IActionExecutionParamModel);
		ClassMetadata metadata = default(ClassMetadata);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				values = new Dictionary<string, object> { 
				{
					(string)ccDw98O0OcSuHpxKXoZK(-683713632 ^ -683744322),
					value
				} };
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return actionExecutionParamModel.Parameter;
			case 5:
				actionExecutionParamModel = (IActionExecutionParamModel)I6YGhqO00F7oyKeMRvNN(AcbncMO0lRGCTWktheTA(typeof(ActionExecutionParamModel<>).TypeHandle).MakeGenericType(viewModelContextType));
				num2 = 4;
				break;
			case 4:
				metadata = new ClassMetadata();
				num2 = 3;
				break;
			case 3:
			{
				PropertyMetadata propertyMetadata2 = new PropertyMetadata();
				rU6wIdO0yOQtNQf808yS(propertyMetadata2, ccDw98O0OcSuHpxKXoZK(0x63D6C913 ^ 0x63D7710D));
				FqOBilO0m0NugFaXJT1f(propertyMetadata2, viewModelDescriptor.Uid);
				propertyMetadata2.SubTypeUid = m2wi8iO0tBWY6PvROPRE(viewModelContextMetadata);
				DataClassSettings dataClassSettings = new DataClassSettings();
				eBgBpQO0b2mtyGt8cFpb(dataClassSettings, RelationType.OneToOne);
				kRRt0NO052S8TEW6BD8X(propertyMetadata2, dataClassSettings);
				propertyMetadata = propertyMetadata2;
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
				{
					num2 = 6;
				}
				break;
			}
			case 6:
				value = new EntityJsonSerializer().DeserializeJson(model);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				viewModelDescriptor.Deserialize(actionExecutionParamModel, metadata, propertyMetadata, values);
				num2 = 2;
				break;
			}
		}
	}

	internal static void Hc4Qu9OlrUIAECfiJcbs()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool EjpgbpOlIul7AiNpBlDt()
	{
		return HVug1COliNHvJn6e0K9K == null;
	}

	internal static ProcessEQLTemplateProvider tF5dDkOlaVyLGB7gI4QZ()
	{
		return HVug1COliNHvJn6e0K9K;
	}

	internal static object VTw928OleF5nI2mdP1FT(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object bBl3jbOlNy3MWtbtDttj(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object yuQDYuOlxZRdMvdhA01e(object P_0)
	{
		return ((IWorkflowProcess)P_0).Context;
	}

	internal static object klEWJFOlSp2A6klUOg15(object P_0)
	{
		return ((IWorkflowProcess)P_0).Parent;
	}

	internal static object dv5SgDOl1g28mCQSvnLW(object P_0)
	{
		return ((IWorkflowProcess)P_0).ScriptModule;
	}

	internal static object kE9KoqOlhQKAwXgMRx70(object P_0)
	{
		return ((ScriptModule)P_0).AssemblyName;
	}

	internal static object iono2WOlEo2GyDe99K86(object P_0, bool P_1)
	{
		return ComponentManager.FindLoadedAssembly((string)P_0, P_1);
	}

	internal static bool MYiQOVOlwSdjkqTf5sMj(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object VVhtQhOl4raWfdDbCmCv(object P_0)
	{
		return ((ScriptModule)P_0).DebugRaw;
	}

	internal static object MHWq4DOlzOt6nveR95rf(object P_0, object P_1)
	{
		return ComponentManager.LoadAssembly((byte[])P_0, (byte[])P_1);
	}

	internal static object VdfbFAO0KcLOoAhYFL9J(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object ccDw98O0OcSuHpxKXoZK(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object pFBnGTO0ZYXkf8fVug56(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Type BPtFFmO0vFjxR9loy7Rr(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}

	internal static bool HrIdVgO0YPgg3VbITwZq(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object VEhMG5O08bwkraZcCWDf(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object fKiReuO0sYPkEfZ77Pxc(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static object fPlIuvO0JL4CeLVBM8FJ(object P_0, object P_1, Type P_2, bool P_3)
	{
		return ((EntityJsonSerializer)P_0).Deserialize((string)P_1, P_2, P_3);
	}

	internal static Type AcbncMO0lRGCTWktheTA(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object I6YGhqO00F7oyKeMRvNN(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void rU6wIdO0yOQtNQf808yS(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static void FqOBilO0m0NugFaXJT1f(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).TypeUid = P_1;
	}

	internal static Guid m2wi8iO0tBWY6PvROPRE(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void eBgBpQO0b2mtyGt8cFpb(object P_0, RelationType P_1)
	{
		((DataClassSettings)P_0).RelationType = P_1;
	}

	internal static void kRRt0NO052S8TEW6BD8X(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}
}
