using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;
using EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints.ActivityNotificationRecipients.Implementations;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Models;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Diagrams.Activities.Helpers;

public static class ActivityExceptionFlowHelper
{
	private static ActivityExceptionFlowHelper vYLZtdwUWGfMelEk86F;

	public static FlowConnectorElement GetExceptionFlow(IWorkflowQueueItem queueItem, EventTrigger trigger)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass0_.queueItem = queueItem;
				num2 = 3;
				break;
			case 3:
				_003C_003Ec__DisplayClass0_.trigger = trigger;
				num2 = 6;
				break;
			case 2:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (((Diagram)hkq9WUwF68tRPAvoGrH(a17nMswofevKo5FLYbN(y4CoHMw2Y1QTjgHXlkj(_003C_003Ec__DisplayClass0_.queueItem)))).Elements.FirstOrDefault(_003C_003Ec__DisplayClass0_._003CGetExceptionFlow_003Eb__0) as IElementWithExceptionFlows).ExceptionOutputFlows.FirstOrDefault(_003C_003Ec__DisplayClass0_._003CGetExceptionFlow_003Eb__1);
			case 5:
				YqNZvYw7R5osLZ5xiBo(y4CoHMw2Y1QTjgHXlkj(_003C_003Ec__DisplayClass0_.queueItem), DRO1GswG4R1Nrj9wTTJ(-106528299 ^ -106454083));
				num2 = 4;
				break;
			case 6:
				YqNZvYw7R5osLZ5xiBo(_003C_003Ec__DisplayClass0_.queueItem, DRO1GswG4R1Nrj9wTTJ(0x6C7F14 ^ 0x6C88F6));
				num2 = 5;
				break;
			case 4:
				YqNZvYw7R5osLZ5xiBo(a17nMswofevKo5FLYbN(y4CoHMw2Y1QTjgHXlkj(_003C_003Ec__DisplayClass0_.queueItem)), DRO1GswG4R1Nrj9wTTJ(-2125897096 ^ -2125987544));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static FlowConnectorElement GetErrorExceptionFlow(IWorkflowQueueItem queueItem, Exception exception)
	{
		//Discarded unreachable code: IL_00c8, IL_00d7, IL_00e6, IL_01aa, IL_01b9, IL_01c9
		int num = 3;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		FlowConnectorElement exceptionFlow = default(FlowConnectorElement);
		bool flag = default(bool);
		IElementWithExceptionFlows elementWithExceptionFlows = default(IElementWithExceptionFlows);
		Exception ex = default(Exception);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass1_.queueItem = queueItem;
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
					{
						num2 = 1;
					}
					continue;
				case 18:
					YqNZvYw7R5osLZ5xiBo(_003C_003Ec__DisplayClass1_.queueItem, DRO1GswG4R1Nrj9wTTJ(0x1145BED7 ^ 0x11454935));
					num = 9;
					break;
				default:
					return exceptionFlow;
				case 1:
				case 7:
					return null;
				case 13:
					if (!flag)
					{
						num2 = 14;
						continue;
					}
					goto case 12;
				case 9:
					YqNZvYw7R5osLZ5xiBo(y4CoHMw2Y1QTjgHXlkj(_003C_003Ec__DisplayClass1_.queueItem), DRO1GswG4R1Nrj9wTTJ(0x350C0E8 ^ 0x351E280));
					num2 = 11;
					continue;
				case 14:
				case 17:
					flag = elementWithExceptionFlows.CanHandleException(ex);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					exceptionFlow = GetExceptionFlow(_003C_003Ec__DisplayClass1_.queueItem, EventTrigger.ErrorCatch);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
					{
						num2 = 8;
					}
					continue;
				case 4:
					ex = (Exception)R5tHoXwIAGXJclRpV2v(ex);
					num2 = 6;
					continue;
				case 3:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 2;
					continue;
				case 5:
					YqNZvYw7R5osLZ5xiBo(exception, DRO1GswG4R1Nrj9wTTJ(-351369538 ^ -351279818));
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
					{
						num2 = 19;
					}
					continue;
				case 11:
					YqNZvYw7R5osLZ5xiBo(a17nMswofevKo5FLYbN(y4CoHMw2Y1QTjgHXlkj(_003C_003Ec__DisplayClass1_.queueItem)), DRO1GswG4R1Nrj9wTTJ(-865213812 ^ -865304100));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
					{
						num2 = 5;
					}
					continue;
				case 19:
					elementWithExceptionFlows = ((IEnumerable<Element>)ncH30kwi4SoBxsfYaCt(hkq9WUwF68tRPAvoGrH(a17nMswofevKo5FLYbN(y4CoHMw2Y1QTjgHXlkj(_003C_003Ec__DisplayClass1_.queueItem))))).FirstOrDefault(_003C_003Ec__DisplayClass1_._003CGetErrorExceptionFlow_003Eb__0) as IElementWithExceptionFlows;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
					{
						num2 = 10;
					}
					continue;
				case 12:
				case 15:
					if (!flag)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 6:
					if (ex == null)
					{
						num2 = 15;
						continue;
					}
					goto case 13;
				case 16:
					ex = exception;
					num = 17;
					break;
				case 8:
					if (exceptionFlow == null)
					{
						num2 = 7;
						continue;
					}
					goto case 16;
				}
				break;
			}
		}
	}

	public static void SetExceptionFlowPropertyValue(IWorkflowInstance instance, IWorkflowQueueItem queueItem, Guid propertyUid)
	{
		//Discarded unreachable code: IL_0171, IL_0180, IL_0190, IL_019f, IL_01d2, IL_01e1, IL_027a, IL_028d, IL_02ad, IL_0312
		int num = 25;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		WorkflowInstanceContext context = default(WorkflowInstanceContext);
		ExceptionData exceptionData = default(ExceptionData);
		ScriptExecuteException ex2 = default(ScriptExecuteException);
		Exception ex = default(Exception);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 26:
					YqNZvYw7R5osLZ5xiBo(queueItem, DRO1GswG4R1Nrj9wTTJ(0x37F755F5 ^ 0x37F7A217));
					num2 = 23;
					continue;
				case 24:
					_003C_003Ec__DisplayClass2_.propertyUid = propertyUid;
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
					{
						num2 = 8;
					}
					continue;
				case 17:
					if (Yrbe6twrmVNKtRJAEIs(queueItem) == null)
					{
						goto end_IL_0012;
					}
					goto case 22;
				case 12:
					if (!((IEntityMetadata)VkMCaGwamAH9kdWi0a2(context.GetType(), true, true)).GetPropertiesAndTableParts().Any(_003C_003Ec__DisplayClass2_._003CSetExceptionFlowPropertyValue_003Eb__0))
					{
						num2 = 16;
						continue;
					}
					goto case 21;
				case 15:
				case 19:
					context.SetPropertyValue(_003C_003Ec__DisplayClass2_.propertyUid, exceptionData);
					num2 = 8;
					continue;
				case 27:
					if (ex2 == null)
					{
						num2 = 18;
						continue;
					}
					break;
				case 2:
					if (ex != null)
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 3;
				case 5:
				case 10:
					ex = (Exception)R5tHoXwIAGXJclRpV2v(ex);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 1;
					}
					continue;
				case 25:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 24;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
					{
						num2 = 5;
					}
					continue;
				case 8:
					return;
				case 16:
					return;
				case 23:
					context = instance.Context;
					num2 = 12;
					continue;
				default:
					exceptionData = (ExceptionData)Yrbe6twrmVNKtRJAEIs(queueItem);
					num2 = 7;
					continue;
				case 21:
					exceptionData = null;
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num2 = 17;
					}
					continue;
				case 1:
				case 4:
					if (!(ex is ScriptExecuteException))
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				case 7:
				case 11:
				case 14:
					if (exceptionData != null)
					{
						num2 = 19;
						continue;
					}
					goto case 6;
				case 13:
					ex = (Exception)KCs6CXweg22GXJsSywX(queueItem.LastExceptionData);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					exceptionData = new ExceptionData(0, (string)n1u0HMwSXPLUsH8pNeF(queueItem));
					num2 = 15;
					continue;
				case 3:
					ex2 = ex as ScriptExecuteException;
					num2 = 27;
					continue;
				case 22:
					if (KCs6CXweg22GXJsSywX(queueItem.LastExceptionData) != null)
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 7;
				case 9:
					YqNZvYw7R5osLZ5xiBo(instance, DRO1GswG4R1Nrj9wTTJ(0x69063C81 ^ 0x69066587));
					num2 = 24;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
					{
						num2 = 26;
					}
					continue;
				case 20:
					break;
				}
				exceptionData = new ExceptionData(HJxx0owN35fZhWBIDVp(ex2), (string)YsuBpPwx9flZw25ZXtw(ex2), ex2);
				num2 = 14;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
				{
					num2 = 14;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	public static void SendMessagesOnTimeout(NativeActivityContext context, IActivityWithExceptionFlowsImpl activity, IWorkflowInstance instance, FlowConnectorElement timeoutConnector)
	{
		int num = 5;
		int num2 = num;
		List<IUser> messageRecipients = default(List<IUser>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
			{
				IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
				EntityActionEventArgs entityActionEventArgs = new EntityActionEventArgs(null, instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398649463));
				entityActionEventArgs.ExtendedProperties[(string)DRO1GswG4R1Nrj9wTTJ(-801808857 ^ -801826647)] = su92bqw1ZKKi3mjcihX(instance);
				entityActionEventArgs.ExtendedProperties[(string)DRO1GswG4R1Nrj9wTTJ(-1108877388 ^ -1108895438)] = instance.Id;
				entityActionEventArgs.ExtendedProperties[(string)DRO1GswG4R1Nrj9wTTJ(0x1134D2C0 ^ 0x1135B6CE)] = NqK5OMwh7qlD6i19XL3(DRO1GswG4R1Nrj9wTTJ(0x74AB4717 ^ 0x74AA2337));
				entityActionEventArgs.ExtendedProperties[(string)DRO1GswG4R1Nrj9wTTJ(0x1134D2C0 ^ 0x11348CF8)] = a17nMswofevKo5FLYbN(instance);
				entityActionEventArgs.ExtendedProperties[(string)DRO1GswG4R1Nrj9wTTJ(-452127399 ^ -452169413)] = messageRecipients;
				juTNUHwEWykZUn6478g(serviceNotNull, entityActionEventArgs);
				num2 = 3;
				break;
			}
			default:
				YqNZvYw7R5osLZ5xiBo(timeoutConnector, DRO1GswG4R1Nrj9wTTJ(-1050383744 ^ -1050343138));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				messageRecipients = GetMessageRecipients(timeoutConnector, instance);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				Contract.ArgumentNotNull(context, (string)DRO1GswG4R1Nrj9wTTJ(0x34EA50D4 ^ 0x34EA6FE4));
				num2 = 4;
				break;
			case 4:
				YqNZvYw7R5osLZ5xiBo(instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6C2612));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void SendMessagesOnException(NativeActivityContext context, IActivityWithExceptionFlowsImpl activity, IWorkflowInstance instance, FlowConnectorElement exceptionConnector, string errorText)
	{
		int num = 1;
		int num2 = num;
		List<IUser> messageRecipients = default(List<IUser>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				messageRecipients = GetMessageRecipients(exceptionConnector, instance);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
			EntityActionEventArgs entityActionEventArgs = new EntityActionEventArgs(null, instance, (string)DRO1GswG4R1Nrj9wTTJ(-45832783 ^ -45760053));
			entityActionEventArgs.ExtendedProperties[(string)DRO1GswG4R1Nrj9wTTJ(-1542190822 ^ -1542172772)] = instance.Id;
			entityActionEventArgs.ExtendedProperties[(string)DRO1GswG4R1Nrj9wTTJ(-2057730233 ^ -2057715255)] = su92bqw1ZKKi3mjcihX(instance);
			entityActionEventArgs.ExtendedProperties[(string)DRO1GswG4R1Nrj9wTTJ(0x4943E3E4 ^ 0x494287EA)] = yuUcbMww6eSSErKCxPM(activity.Element);
			entityActionEventArgs.ExtendedProperties[(string)DRO1GswG4R1Nrj9wTTJ(-708128192 ^ -708146056)] = a17nMswofevKo5FLYbN(instance);
			entityActionEventArgs.ExtendedProperties[(string)DRO1GswG4R1Nrj9wTTJ(0x101D10F ^ 0x10160EF)] = errorText;
			entityActionEventArgs.ExtendedProperties[(string)DRO1GswG4R1Nrj9wTTJ(0x51EF0063 ^ 0x51EE6401)] = messageRecipients;
			juTNUHwEWykZUn6478g(serviceNotNull, entityActionEventArgs);
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
			{
				num2 = 0;
			}
		}
	}

	private static List<IUser> GetMessageRecipients(object connector, object instance)
	{
		Contract.ArgumentNotNull(connector, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684285246));
		Contract.ArgumentNotNull(instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x246EEF98 ^ 0x246EB69E));
		List<IUser> list = new List<IUser>();
		IEnumerable<IUser> recipients = Locator.GetServiceNotNull<BaseWorkflowActivityGetNotificationRecipientsImpl>().GetRecipients(new GetRecipientsParameters((IWorkflowInstance)instance, (IElementWithNotification)connector));
		list.AddRange(recipients);
		return (from u in list
			where u != null
			select u.CastAsRealType()).Distinct().ToList();
	}

	internal static object DRO1GswG4R1Nrj9wTTJ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void YqNZvYw7R5osLZ5xiBo(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object y4CoHMw2Y1QTjgHXlkj(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).Instance;
	}

	internal static object a17nMswofevKo5FLYbN(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object hkq9WUwF68tRPAvoGrH(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static bool asmUpswVgI7OeDc0MiK()
	{
		return vYLZtdwUWGfMelEk86F == null;
	}

	internal static ActivityExceptionFlowHelper VBrx9PwAJfBUt6CeEDw()
	{
		return vYLZtdwUWGfMelEk86F;
	}

	internal static object ncH30kwi4SoBxsfYaCt(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object R5tHoXwIAGXJclRpV2v(object P_0)
	{
		return ((Exception)P_0).InnerException;
	}

	internal static object VkMCaGwamAH9kdWi0a2(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object Yrbe6twrmVNKtRJAEIs(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).LastExceptionData;
	}

	internal static object KCs6CXweg22GXJsSywX(object P_0)
	{
		return ((ExceptionData)P_0).OriginalException;
	}

	internal static int HJxx0owN35fZhWBIDVp(object P_0)
	{
		return ((ScriptExecuteException)P_0).CodeException;
	}

	internal static object YsuBpPwx9flZw25ZXtw(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object n1u0HMwSXPLUsH8pNeF(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).LastError;
	}

	internal static object su92bqw1ZKKi3mjcihX(object P_0)
	{
		return ((IWorkflowInstance)P_0).Name;
	}

	internal static object NqK5OMwh7qlD6i19XL3(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void juTNUHwEWykZUn6478g(object P_0, object P_1)
	{
		((IEntityActionHandler)P_0).ActionExecuted((EntityActionEventArgs)P_1);
	}

	internal static object yuUcbMww6eSSErKCxPM(object P_0)
	{
		return ((IWorkflowElement)P_0).Name;
	}
}
