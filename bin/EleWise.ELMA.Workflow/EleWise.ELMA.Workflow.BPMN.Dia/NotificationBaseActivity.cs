using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Notifications.Impl.TemplateGenerator;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Diagrams.Activities.Helpers;
using EleWise.ELMA.Workflow.Exceptions;
using EleWise.ELMA.Workflow.Models;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Tasks;

public abstract class NotificationBaseActivity : TaskActivity<NotificationBaseElement>
{
	protected List<Exception> Exceptions;

	internal static NotificationBaseActivity sHLZX3ZdbDiXeYsw0Dqs;

	protected override void ExecuteTask(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_00f8, IL_0107, IL_0139, IL_0148, IL_0158, IL_0167, IL_01a4, IL_0394, IL_03a3, IL_03d1, IL_03e0, IL_03eb, IL_04ab, IL_04be, IL_0516, IL_0525, IL_0556, IL_0565, IL_05af, IL_05be
		int num = 3;
		int num2 = num;
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		FlowConnectorElement flowConnectorElement = default(FlowConnectorElement);
		CompositeExceptionForProcesses compositeExceptionForProcesses = default(CompositeExceptionForProcesses);
		List<Exception>.Enumerator enumerator = default(List<Exception>.Enumerator);
		Exception current = default(Exception);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				workflowInstance = (IWorkflowInstance)ScVqa5ZdBvQYDi3G2wF2(this, context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				Exceptions = new List<Exception>();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			try
			{
				TaskMarker taskMarker = oQ3C48ZdcW4twJMir3ay(base.Element);
				int num3 = 2;
				while (true)
				{
					switch (num3)
					{
					case 1:
						return;
					case 3:
						return;
					case 4:
						return;
					case 8:
						return;
					case 2:
						if (taskMarker != 0)
						{
							int num4 = 7;
							num3 = num4;
							continue;
						}
						goto case 5;
					default:
						if (!ConditionHelper.Evaluate(base.Element.Condition, workflowInstance))
						{
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
							{
								num3 = 3;
							}
							continue;
						}
						break;
					case 5:
						oWQOo4ZdPRwpCIuGRRVd(this, context);
						num3 = 8;
						continue;
					case 7:
						if (taskMarker != TaskMarker.Condition)
						{
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto default;
					case 6:
						break;
					}
					oWQOo4ZdPRwpCIuGRRVd(this, context);
					num3 = 4;
				}
			}
			catch (Exception item)
			{
				int num5 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
				{
					num5 = 1;
				}
				while (true)
				{
					switch (num5)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						Exceptions.Add(item);
						num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
						{
							num5 = 0;
						}
						break;
					}
				}
			}
			finally
			{
				int num7;
				if (Eo4dMtZdXCrXpU0l3c9b(Exceptions) <= 0)
				{
					int num6 = 8;
					num7 = num6;
					goto IL_0209;
				}
				goto IL_0570;
				IL_0209:
				while (true)
				{
					switch (num7)
					{
					case 18:
					{
						List<object> recipients = GetRecipients(workflowInstance);
						_003C_003Ec__DisplayClass0_.getRecipientsExceptionType = oDXFDWZd9HdZHaLCDO17(typeof(GetRecipientsException).TypeHandle);
						if (recipients.Any())
						{
							num7 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
							{
								num7 = 3;
							}
							continue;
						}
						goto case 4;
					}
					case 11:
						CD1HrjZdLeOAFB0GU2Yr(Ai5WNDZdDSiRMioxdeHC(workflowInstance), bQAamTZdnocxceA28e0g(flowConnectorElement), new ExceptionData(0, (string)HvpKCeZdHYuofJK6f3AO(compositeExceptionForProcesses), compositeExceptionForProcesses));
						num7 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
						{
							num7 = 5;
						}
						continue;
					case 17:
						throw Exceptions.Last(_003C_003Ec__DisplayClass0_._003CExecuteTask_003Eb__2);
					case 8:
						zpxtUCZdW320lhBCwERL(workflowInstance);
						num7 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
						{
							num7 = 14;
						}
						continue;
					default:
						_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
						num7 = 18;
						continue;
					case 15:
						if (flowConnectorElement != null)
						{
							num7 = 11;
							continue;
						}
						goto default;
					case 1:
						xjeIydZdfvJ7ZouJ7Bqk(this, context, flowConnectorElement);
						num7 = 9;
						continue;
					case 16:
						enumerator = Exceptions.GetEnumerator();
						num7 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
						{
							num7 = 4;
						}
						continue;
					case 5:
						workflowInstance.Save();
						num7 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
						{
							num7 = 1;
						}
						continue;
					case 2:
						goto end_IL_0209;
					case 7:
						compositeExceptionForProcesses = new CompositeExceptionForProcesses
						{
							Exceptions = Exceptions
						};
						num7 = 16;
						continue;
					case 12:
						try
						{
							while (true)
							{
								IL_0459:
								int num8;
								if (!enumerator.MoveNext())
								{
									num8 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
									{
										num8 = 1;
									}
									goto IL_03ef;
								}
								goto IL_0409;
								IL_0409:
								current = enumerator.Current;
								num8 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
								{
									num8 = 2;
								}
								goto IL_03ef;
								IL_03ef:
								while (true)
								{
									switch (num8)
									{
									case 2:
										OmQxo7ZdurqXiuA0BrF5(uY4h4KZddwM6apXfylRp(), current.Message, current);
										num8 = 3;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
										{
											num8 = 1;
										}
										continue;
									case 3:
										goto IL_0459;
									case 1:
										goto end_IL_0459;
									}
									break;
								}
								goto IL_0409;
								continue;
								end_IL_0459:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num9 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
							{
								num9 = 0;
							}
							switch (num9)
							{
							case 0:
								break;
							}
						}
						goto case 15;
					case 3:
						if (Exceptions.All(_003C_003Ec__DisplayClass0_._003CExecuteTask_003Eb__1))
						{
							num7 = 4;
							continue;
						}
						goto case 17;
					case 10:
						ContinueOnDefaultConnector(context);
						num7 = 2;
						continue;
					case 4:
						zpxtUCZdW320lhBCwERL(workflowInstance);
						num7 = 10;
						continue;
					case 9:
						goto end_IL_0209;
					case 14:
						ContinueOnDefaultConnector(context);
						num7 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num7 = 10;
						}
						continue;
					case 6:
						break;
					case 13:
						goto end_IL_0209;
					}
					goto IL_0570;
					continue;
					end_IL_0209:
					break;
				}
				goto end_IL_01e6;
				IL_0570:
				flowConnectorElement = base.Element.ExceptionOutputFlows.FirstOrDefault((FlowConnectorElement e) => _003C_003Ec.YfpXKSvfwgDfG6qAVyZZ(e) == EventTrigger.ErrorCatch);
				num7 = 7;
				goto IL_0209;
				end_IL_01e6:;
			}
		}
	}

	protected List<object> GetRecipients(IWorkflowInstance instance)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		List<object> list = new List<object>();
		CS_0024_003C_003E8__locals0.currentUserRecipientForNotificationType = typeof(CurrentUserRecipientForNotification);
		foreach (RecipientInfoForNotification item2 in base.Element.Recipients.Where((RecipientInfoForNotification a) => _003C_003Ec__DisplayClass1_0.MP4DTUv9sJBpucBi6vVb(a.GetType(), CS_0024_003C_003E8__locals0.currentUserRecipientForNotificationType)))
		{
			try
			{
				list.AddRange(item2.GetRecipients(instance));
			}
			catch (Exception item)
			{
				Exceptions.Add(item);
			}
		}
		return list;
	}

	protected virtual void ExecuteNotificationTask(NativeActivityContext context)
	{
	}

	protected IEnumerable<IUser> GetExecutor(NativeActivityContext context)
	{
		List<IUser> list = new List<IUser>();
		if (base.Element.Recipients.FirstOrDefault((RecipientInfoForNotification a) => _003C_003Ec.vqHDvyvfzdaZBMOu7VuN(a.GetType(), _003C_003Ec.Svg9Fvvf4M9vg9MFJT7t(typeof(CurrentUserRecipientForNotification).TypeHandle))) != null)
		{
			IUser[] swimlaneExecutors = GetSwimlaneExecutors(context);
			list.AddRange(swimlaneExecutors);
		}
		return list;
	}

	protected List<BinaryFile> GetFiles(IWorkflowInstance instance)
	{
		List<BinaryFile> list = new List<BinaryFile>();
		if (base.Element.AttachmentProperties == null || base.Element.AttachmentProperties.Length == 0)
		{
			return list;
		}
		if (!(MetadataLoader.LoadMetadata(instance.Context.GetType()) is ClassMetadata classMetadata))
		{
			return list;
		}
		List<PropertyMetadata> properties = classMetadata.Properties;
		if (properties == null || properties.Count == 0)
		{
			return list;
		}
		Guid[] attachmentProperties = base.Element.AttachmentProperties;
		for (int i = 0; i < attachmentProperties.Length; i++)
		{
			_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
			CS_0024_003C_003E8__locals0.attachmentGuid = attachmentProperties[i];
			if (!properties.Exists((PropertyMetadata p) => _003C_003Ec__DisplayClass5_0.jLDYT9v9m1Dg9LfxhT7f(_003C_003Ec__DisplayClass5_0.rW22Ljv9y6RnBxJcDk4A(p), CS_0024_003C_003E8__locals0.attachmentGuid)))
			{
				continue;
			}
			object propertyValue = instance.Context.GetPropertyValue(CS_0024_003C_003E8__locals0.attachmentGuid);
			if (propertyValue == null)
			{
				continue;
			}
			if (propertyValue is IEnumerable<IEntity> source)
			{
				list.AddRange(source.SelectMany((IEntity a) => GetFilesFromVariable(a)));
			}
			else
			{
				list.AddRange(GetFilesFromVariable(propertyValue));
			}
		}
		return list;
	}

	private List<BinaryFile> GetFilesFromVariable(object attachment)
	{
		List<BinaryFile> list = new List<BinaryFile>();
		if (attachment is BinaryFile item)
		{
			list.Add(item);
			return list;
		}
		if (attachment is IDocumentAttachment documentAttachment)
		{
			IEnumerable<BinaryFile> source = from ver in (IEnumerable<IDocumentVersion>)documentAttachment.Document.Versions
				where ver.Status == DocumentVersionStatus.Current
				select (BinaryFile)_003C_003Ec.bWlqkOv9KPcRbUQGhdma(ver);
			list.AddRange(source.ToList());
			return list;
		}
		if (attachment is IFile file)
		{
			IEnumerable<BinaryFile> source2 = from ver in (IEnumerable<IDocumentVersion>)file.Versions
				where _003C_003Ec.y6xcdHv9OVSucY1XJBGt(ver) == DocumentVersionStatus.Current
				select (BinaryFile)_003C_003Ec.bWlqkOv9KPcRbUQGhdma(ver);
			list.AddRange(source2.ToList());
			return list;
		}
		if (attachment is IDocument document)
		{
			IEnumerable<BinaryFile> source3 = from ver in (IEnumerable<IDocumentVersion>)document.Versions
				where _003C_003Ec.y6xcdHv9OVSucY1XJBGt(ver) == DocumentVersionStatus.Current
				select (BinaryFile)_003C_003Ec.bWlqkOv9KPcRbUQGhdma(ver);
			list.AddRange(source3.ToList());
			return list;
		}
		if (attachment is IAttachment attachment2 && attachment2.File != null)
		{
			list.Add(attachment2.File);
		}
		return list;
	}

	protected string Generate(string template, object dataSource, int offset, TemplateRenderMode renderMode = TemplateRenderMode.Default)
	{
		NotificationTemplateGenerator notificationTemplateGenerator = new NotificationTemplateGenerator(template, null, renderMode);
		((IGeneratorProvider)AraBhGZdjvDA5PKgCgIL(notificationTemplateGenerator)).TemplateTimeZoneOffset = offset;
		return (string)JGunhGZdR1F2E7pq2Mcb(notificationTemplateGenerator, dataSource);
	}

	protected NotificationBaseActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sohlawZd6mgLBYFvWpmL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object ScVqa5ZdBvQYDi3G2wF2(object P_0, object P_1)
	{
		return ((WorkflowActivity)P_0).GetInstance((NativeActivityContext)P_1);
	}

	internal static TaskMarker oQ3C48ZdcW4twJMir3ay(object P_0)
	{
		return ((TaskElement)P_0).Marker;
	}

	internal static void oWQOo4ZdPRwpCIuGRRVd(object P_0, object P_1)
	{
		((NotificationBaseActivity)P_0).ExecuteNotificationTask((NativeActivityContext)P_1);
	}

	internal static int Eo4dMtZdXCrXpU0l3c9b(object P_0)
	{
		return ((List<Exception>)P_0).Count;
	}

	internal static object uY4h4KZddwM6apXfylRp()
	{
		return Logger.Log;
	}

	internal static void OmQxo7ZdurqXiuA0BrF5(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object Ai5WNDZdDSiRMioxdeHC(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static Guid bQAamTZdnocxceA28e0g(object P_0)
	{
		return ((FlowConnectorElement)P_0).ContextExceptionVar;
	}

	internal static object HvpKCeZdHYuofJK6f3AO(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void CD1HrjZdLeOAFB0GU2Yr(object P_0, Guid P_1, object P_2)
	{
		((Entity<long>)P_0).SetPropertyValue(P_1, P_2);
	}

	internal static void xjeIydZdfvJ7ZouJ7Bqk(object P_0, object P_1, object P_2)
	{
		((WorkflowActivity)P_0).ContinueOnConnector((NativeActivityContext)P_1, (Connector)P_2);
	}

	internal static Type oDXFDWZd9HdZHaLCDO17(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void zpxtUCZdW320lhBCwERL(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static bool WI9BFaZd5eJNvKeDyCIU()
	{
		return sHLZX3ZdbDiXeYsw0Dqs == null;
	}

	internal static NotificationBaseActivity gWmmAVZdg4tfyNJXPB0O()
	{
		return sHLZX3ZdbDiXeYsw0Dqs;
	}

	internal static object AraBhGZdjvDA5PKgCgIL(object P_0)
	{
		return ((GeneratorBase)P_0).Provider;
	}

	internal static object JGunhGZdR1F2E7pq2Mcb(object P_0, object P_1)
	{
		return ((TextGenerator)P_0).Generate(P_1);
	}

	internal static void sohlawZd6mgLBYFvWpmL()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
