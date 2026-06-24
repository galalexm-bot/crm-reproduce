using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Tasks;

public class MessageSendActivity : TaskActivity<MessageSendElement>
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		private static object zX7NT3Wgncl5DpDB5J4;

		public Type ActivityType => eYwGaKWZQQ3BjlKcclL(typeof(MessageSendActivity).TypeHandle);

		public Type DiagramElementType => eYwGaKWZQQ3BjlKcclL(typeof(MessageSendElement).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			jqEUUmWzLhGFNptCykP();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type eYwGaKWZQQ3BjlKcclL(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void jqEUUmWzLhGFNptCykP()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}

		internal static bool MIshwGW1IFYO3fSDd8X()
		{
			return zX7NT3Wgncl5DpDB5J4 == null;
		}

		internal static Info CkiQXtWIIJbMuG4PUFx()
		{
			return (Info)zX7NT3Wgncl5DpDB5J4;
		}
	}

	internal static MessageSendActivity loehNwSRGAcrVyYqOQh;

	protected override void ExecuteTask(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_0072, IL_019b, IL_0232, IL_02a7, IL_02b6, IL_0368, IL_0420, IL_050a, IL_0519, IL_0524, IL_05e0, IL_0620, IL_062f, IL_063b, IL_0682, IL_0695, IL_06a4, IL_0707
		int num = 15;
		IWorkflowMessageType workflowMessageType = default(IWorkflowMessageType);
		Dictionary<string, object> dictionary = default(Dictionary<string, object>);
		IWorkflowInstance workflowInstance2 = default(IWorkflowInstance);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		List<MessageParamMap>.Enumerator enumerator = default(List<MessageParamMap>.Enumerator);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		IDictionary<string, object> dictionary2 = default(IDictionary<string, object>);
		IEnumerator<KeyValuePair<string, object>> enumerator2 = default(IEnumerator<KeyValuePair<string, object>>);
		IWorkflowMessageTypeParameter workflowMessageTypeParameter = default(IWorkflowMessageTypeParameter);
		ISerializableTypeDescriptor serializableTypeDescriptor = default(ISerializableTypeDescriptor);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		EntityMetadata metadata = default(EntityMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IMetadataService metadataService = default(IMetadataService);
		KeyValuePair<string, object> current = default(KeyValuePair<string, object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 2:
					obj = null;
					goto IL_07ca;
				case 17:
					Pv7KJjkFXs3YnZAWGwp(Locator.GetServiceNotNull<IWorkflowMessagingService>(), workflowMessageType, new WebData(dictionary));
					num2 = 18;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 == 0)
					{
						num2 = 16;
					}
					continue;
				case 5:
					RcsEq1S5PpHPsAaBM0p(this, context);
					num = 4;
					break;
				case 8:
					workflowInstance2 = egIE3okhE2bobwQU30p(dLK4YpS1acfQ3iftVip(workflowInstance), x2xwb7k3xtaRGfDVGr8(base.Element)) as IWorkflowInstance;
					num2 = 7;
					continue;
				case 14:
					x2Zi1lSia7qGyiej7mc(TnExcGSexKf3TK6uAHe(this), aJ2yUySW4weCu52Kloe(0x29336E79 ^ 0x29336E25));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1fcd5b77d5534d528c98a4d02b302a40 == 0)
					{
						num2 = 1;
					}
					continue;
				case 19:
					enumerator = base.Element.MessageParamMapping.GetEnumerator();
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 != 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					return;
				case 10:
					if (OoohDKSlXgQJ607uiFj(base.Element.UIDVariableInstance, Guid.Empty))
					{
						num = 8;
						break;
					}
					goto case 17;
				case 4:
					return;
				case 13:
					workflowInstance = (IWorkflowInstance)EPryWISge99NaBjwhMF(this, context);
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_91adcac8aa2043159a205c4a9f0e85fa != 0)
					{
						num2 = 11;
					}
					continue;
				case 9:
					if (workflowMessageType != null)
					{
						num2 = 13;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 5;
				case 15:
					RIgFySSHetZgJvjU8DM(context, aJ2yUySW4weCu52Kloe(--1059430085 ^ 0x3F259E8F));
					num2 = 14;
					continue;
				case 1:
					if (OoohDKSlXgQJ607uiFj(bVf1aHSuiDIVwxgElpy(base.Element), Guid.Empty))
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 11:
					dictionary = new Dictionary<string, object>();
					num2 = 12;
					continue;
				case 3:
					try
					{
						while (true)
						{
							IL_0454:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 11;
								goto IL_0240;
							}
							goto IL_0406;
							IL_02c8:
							int num4 = 12;
							goto IL_023c;
							IL_0406:
							_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
							num4 = 14;
							goto IL_023c;
							IL_023c:
							num3 = num4;
							goto IL_0240;
							IL_0240:
							while (true)
							{
								switch (num3)
								{
								case 20:
									if (dictionary2 == null)
									{
										goto IL_02c8;
									}
									goto case 18;
								case 2:
								case 12:
								case 16:
									if (_003C_003Ec__DisplayClass1_.map.Type == ConditionTable.OperandType.Value)
									{
										num3 = 10;
										continue;
									}
									goto IL_0454;
								case 18:
									enumerator2 = dictionary2.GetEnumerator();
									num3 = 15;
									continue;
								case 14:
									_003C_003Ec__DisplayClass1_.map = enumerator.Current;
									num3 = 7;
									continue;
								case 3:
									if (workflowMessageTypeParameter == null)
									{
										num3 = 9;
										continue;
									}
									goto case 4;
								case 7:
									workflowMessageTypeParameter = ((IEnumerable<IWorkflowMessageTypeParameter>)workflowMessageType.Parameters).FirstOrDefault(_003C_003Ec__DisplayClass1_._003CExecuteTask_003Eb__1);
									num3 = 3;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
									{
										num3 = 2;
									}
									continue;
								default:
									if (serializableTypeDescriptor == null)
									{
										num3 = 16;
										continue;
									}
									goto case 8;
								case 21:
									if (entityPropertyMetadata != null)
									{
										num3 = 0;
										if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 == 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto case 2;
								case 10:
									((IDictionary<string, object>)dictionary)[workflowMessageTypeParameter.Name] = ji58CRkoOI8EJC0Kmra(_003C_003Ec__DisplayClass1_.map);
									num3 = 6;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_76260b548c684c6c95eb679c837b8945 != 0)
									{
										num3 = 19;
									}
									continue;
								case 6:
									dictionary2 = serializableTypeDescriptor.Serialize(dLK4YpS1acfQ3iftVip(workflowInstance), metadata, entityPropertyMetadata);
									num3 = 7;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
									{
										num3 = 20;
									}
									continue;
								case 5:
									break;
								case 17:
									entityPropertyMetadata = entityMetadata.GetPropertiesAndTableParts().FirstOrDefault(_003C_003Ec__DisplayClass1_._003CExecuteTask_003Eb__2) as EntityPropertyMetadata;
									num3 = 21;
									continue;
								case 9:
								case 19:
									goto IL_0454;
								case 8:
									metadata = (EntityMetadata)wWbeAQSIWa18rjaOfPs(((WorkflowInstanceContext)dLK4YpS1acfQ3iftVip(workflowInstance)).CastAsRealType().GetType(), true, true);
									num3 = 6;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 != 0)
									{
										num3 = 6;
									}
									continue;
								case 1:
									serializableTypeDescriptor = metadataService.GetTypeDescriptor(ob4fpBkETSNeSvPfTPG(entityPropertyMetadata), cpKo7okCDkbTvHs8Avy(entityPropertyMetadata)) as ISerializableTypeDescriptor;
									num3 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 == 0)
									{
										num3 = 0;
									}
									continue;
								case 4:
									if (yiBaVfSZYBFPPDxLbOu(_003C_003Ec__DisplayClass1_.map) == ConditionTable.OperandType.Property)
									{
										num3 = 11;
										if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_48279d3d45e2437b9907d478ce5a47b1 != 0)
										{
											num3 = 13;
										}
										continue;
									}
									goto case 2;
								case 15:
									try
									{
										while (true)
										{
											int num5;
											if (!enumerator2.MoveNext())
											{
												num5 = 3;
												if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 == 0)
												{
													num5 = 3;
												}
												goto IL_0528;
											}
											goto IL_0568;
											IL_0568:
											current = enumerator2.Current;
											num5 = 0;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_58d62f4202494b18a0cc2631d85b3ead == 0)
											{
												num5 = 0;
											}
											goto IL_0528;
											IL_0528:
											while (true)
											{
												switch (num5)
												{
												case 1:
													break;
												case 2:
													goto IL_0568;
												default:
													((IDictionary<string, object>)dictionary)[(string)CKHeN5kX4oCrmCtixat(workflowMessageTypeParameter)] = current.Value;
													num5 = 0;
													if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 == 0)
													{
														num5 = 1;
													}
													continue;
												case 3:
													goto end_IL_0542;
												}
												break;
											}
											continue;
											end_IL_0542:
											break;
										}
									}
									finally
									{
										int num6;
										if (enumerator2 == null)
										{
											num6 = 1;
											if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8ed00be219534188ad23e215449e3f62 == 0)
											{
												num6 = 1;
											}
											goto IL_05e4;
										}
										goto IL_05fa;
										IL_05fa:
										enumerator2.Dispose();
										num6 = 2;
										if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
										{
											num6 = 0;
										}
										goto IL_05e4;
										IL_05e4:
										switch (num6)
										{
										case 1:
											goto end_IL_05bf;
										case 2:
											goto end_IL_05bf;
										}
										goto IL_05fa;
										end_IL_05bf:;
									}
									goto case 2;
								case 13:
									metadataService = (IMetadataService)XvkNhhSzdKoN1kD0PAp();
									num3 = 17;
									continue;
								case 11:
									goto end_IL_0454;
								}
								break;
							}
							goto IL_0406;
							continue;
							end_IL_0454:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc != 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 10;
				case 7:
					JTq3bbkxthJgd9x1UWT(Locator.GetServiceNotNull<IWorkflowMessagingService>(), workflowInstance2, workflowMessageType, new WebData(dictionary));
					num2 = 16;
					continue;
				case 12:
					entityMetadata = (EntityMetadata)wWbeAQSIWa18rjaOfPs(dLK4YpS1acfQ3iftVip(workflowInstance).GetType(), true, true);
					num2 = 19;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_520732c4e13f4c5b8eebfda6fa186589 == 0)
					{
						num2 = 5;
					}
					continue;
				case 16:
				case 18:
					RcsEq1S5PpHPsAaBM0p(this, context);
					num2 = 6;
					continue;
				default:
					{
						IEntityManager<IWorkflowMessageType> instance = EntityManager<IWorkflowMessageType>.Instance;
						ParameterExpression parameterExpression = Expression.Parameter(kTEiYoSf0b57q22H79w(typeof(IWorkflowMessageType).TypeHandle), (string)aJ2yUySW4weCu52Kloe(0x1C21F94 ^ 0x1C2729C));
						obj = instance.Find(Expression.Lambda<Func<IWorkflowMessageType, bool>>(Expression.Equal((Expression)SFX2V3SLAgdQjllrUFV(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)SFX2V3SLAgdQjllrUFV(Expression.Property((Expression)YYIIi8SJK6BOaguA8jA(this, kTEiYoSf0b57q22H79w(typeof(MessageSendActivity).TypeHandle)), (MethodInfo)xyiS6ISrUf8BEB34QQK((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(WorkflowActivity<MessageSendElement>).TypeHandle)), (MethodInfo)AbekTWS76P5gPHmpSOK((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), liftToNull: false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
						goto IL_07ca;
					}
					IL_07ca:
					workflowMessageType = (IWorkflowMessageType)obj;
					num2 = 9;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	public MessageSendActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yvZN1Gk8re5yQ9V8wZT();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object aJ2yUySW4weCu52Kloe(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void RIgFySSHetZgJvjU8DM(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object TnExcGSexKf3TK6uAHe(object P_0)
	{
		return ((WorkflowActivity)P_0).WorkflowRuntimeService;
	}

	internal static void x2Zi1lSia7qGyiej7mc(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static Guid bVf1aHSuiDIVwxgElpy(object P_0)
	{
		return ((MessageSendElement)P_0).UIDMessage;
	}

	internal static bool OoohDKSlXgQJ607uiFj(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Type kTEiYoSf0b57q22H79w(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object SFX2V3SLAgdQjllrUFV(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object YYIIi8SJK6BOaguA8jA(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object xyiS6ISrUf8BEB34QQK(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
	{
		return MethodBase.GetMethodFromHandle(P_0, P_1);
	}

	internal static object AbekTWS76P5gPHmpSOK(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static void RcsEq1S5PpHPsAaBM0p(object P_0, object P_1)
	{
		((WorkflowActivity)P_0).ContinueOnDefaultConnector((NativeActivityContext)P_1);
	}

	internal static object EPryWISge99NaBjwhMF(object P_0, object P_1)
	{
		return ((WorkflowActivity)P_0).GetInstance((NativeActivityContext)P_1);
	}

	internal static object dLK4YpS1acfQ3iftVip(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static object wWbeAQSIWa18rjaOfPs(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static ConditionTable.OperandType yiBaVfSZYBFPPDxLbOu(object P_0)
	{
		return ((MessageParamMap)P_0).Type;
	}

	internal static object XvkNhhSzdKoN1kD0PAp()
	{
		return MetadataServiceContext.Service;
	}

	internal static Guid ob4fpBkETSNeSvPfTPG(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid cpKo7okCDkbTvHs8Avy(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object CKHeN5kX4oCrmCtixat(object P_0)
	{
		return ((IWorkflowMessageTypeParameter)P_0).Name;
	}

	internal static object ji58CRkoOI8EJC0Kmra(object P_0)
	{
		return ((MessageParamMap)P_0).Value;
	}

	internal static Guid x2xwb7k3xtaRGfDVGr8(object P_0)
	{
		return ((MessageSendElement)P_0).UIDVariableInstance;
	}

	internal static object egIE3okhE2bobwQU30p(object P_0, Guid P_1)
	{
		return ((Entity<long>)P_0).GetPropertyValue(P_1);
	}

	internal static object JTq3bbkxthJgd9x1UWT(object P_0, object P_1, object P_2, object P_3)
	{
		return ((IWorkflowMessagingService)P_0).SendMessage((IWorkflowInstance)P_1, (IWorkflowMessageType)P_2, (WebData)P_3);
	}

	internal static object Pv7KJjkFXs3YnZAWGwp(object P_0, object P_1, object P_2)
	{
		return ((IWorkflowMessagingService)P_0).SendMessage((IWorkflowMessageType)P_1, (WebData)P_2);
	}

	internal static bool tSE9JkS0T8Uyk8pkUJK()
	{
		return loehNwSRGAcrVyYqOQh == null;
	}

	internal static MessageSendActivity v8fESCSBEBC8HuKUFJT()
	{
		return loehNwSRGAcrVyYqOQh;
	}

	internal static void yvZN1Gk8re5yQ9V8wZT()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
