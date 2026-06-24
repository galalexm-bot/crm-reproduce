using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using EleWise.ELMA.Workflow.Web.Extensions;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.API;

public static class ExecuteUserTaskStatusHelper
{
	internal static ExecuteUserTaskStatusHelper uO6SEbZHKTlEZy9KMRQ3;

	public static TypeSerializationDescriptorBuilder ApplyParametersDescriptor(this TypeSerializationDescriptorBuilder builder, bool needUnknownStatus = false, bool needExecutionToken = true, bool needStatus = true, string nextTaskIdDescription = null)
	{
		int num = 2;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					_003C_003Ec__DisplayClass0_.needExecutionToken = needExecutionToken;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					return builder;
				case 1:
					break;
				case 5:
					_003C_003Ec__DisplayClass0_.nextTaskIdDescription = nextTaskIdDescription;
					num2 = 3;
					continue;
				case 4:
					builder.If(needStatus, _003C_003Ec__DisplayClass0_._003CApplyParametersDescriptor_003Eb__0).If(_003C_003Ec__DisplayClass0_.needExecutionToken, delegate(TypeSerializationDescriptorBuilder b)
					{
						int num19 = 1;
						int num20 = num19;
						while (true)
						{
							switch (num20)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								b.ItemWithDescriptor((string)_003C_003Ec.KDQutjvq79YAdhNmcoMZ(0x1927DA93 ^ 0x19251215), delegate(TypeSerializationDescriptorBuilder i)
								{
									int num21 = 1;
									int num22 = num21;
									while (true)
									{
										switch (num22)
										{
										default:
											return;
										case 1:
											_003C_003Ec.XBYuCPvqIffdl3fGhl4M(_003C_003Ec.BkxEyRvqFNoD1NpEQ8GI(_003C_003Ec.AhWJSBvqo24W2FMIqX8k(i, SR.T((string)_003C_003Ec.KDQutjvq79YAdhNmcoMZ(-1965291699 ^ -1965099911))), null), _003C_003Ec.eCIGgivqiUW7Gur1WLaq(typeof(string).TypeHandle));
											num22 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
											{
												num22 = 0;
											}
											break;
										case 0:
											return;
										}
									}
								});
								num20 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
								{
									num20 = 0;
								}
								break;
							}
						}
					}).ItemWithDescriptor((string)j68L8hZHvDSKl16Uwsyp(-420003255 ^ -420117115), _003C_003Ec__DisplayClass0_._003CApplyParametersDescriptor_003Eb__2)
						.ItemWithDescriptor(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135593494), _003C_003Ec__DisplayClass0_._003CApplyParametersDescriptor_003Eb__3)
						.ItemWithDescriptor(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5BCD23A0 ^ 0x5BCFEBA6), delegate(TypeSerializationDescriptorBuilder i)
						{
							int num17 = 1;
							int num18 = num17;
							while (true)
							{
								switch (num18)
								{
								default:
									return;
								case 1:
									_003C_003Ec.XBYuCPvqIffdl3fGhl4M(_003C_003Ec.BkxEyRvqFNoD1NpEQ8GI(i.Description((string)_003C_003Ec.chaShUvqeRm3CqyUq10C(_003C_003Ec.KDQutjvq79YAdhNmcoMZ(0x5F800F5B ^ 0x5F82FB51), new object[4]
									{
										WorkflowInstanceStatus.Completed.ToString(),
										WorkflowInstanceStatus.Terminated.ToString(),
										_003C_003Ec.rwIDbdvqaIhfyKawWrks().ToString(),
										_003C_003Ec.M10NpHvqrJeVDRZMI344().ToString()
									})), null), _003C_003Ec.eCIGgivqiUW7Gur1WLaq(typeof(string).TypeHandle));
									num18 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
									{
										num18 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						})
						.ItemWithDescriptor((string)j68L8hZHvDSKl16Uwsyp(-720457373 ^ -720602811), delegate(TypeSerializationDescriptorBuilder i)
						{
							int num15 = 1;
							int num16 = num15;
							while (true)
							{
								switch (num16)
								{
								default:
									return;
								case 1:
									((TypeSerializationDescriptorBuilder)_003C_003Ec.BkxEyRvqFNoD1NpEQ8GI(i.Description((string)_003C_003Ec.hdT58Ovq27WWHnVRIHme(_003C_003Ec.KDQutjvq79YAdhNmcoMZ(-10408775 ^ -10233409))), null)).Type(typeof(string));
									num16 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
									{
										num16 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						})
						.ItemWithDescriptor((string)j68L8hZHvDSKl16Uwsyp(0x6C7F14 ^ 0x6EB752), delegate(TypeSerializationDescriptorBuilder co)
						{
							int num5 = 1;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									_003C_003Ec.BkxEyRvqFNoD1NpEQ8GI(co.IsArray(delegate(TypeSerializationDescriptorBuilder a)
									{
										int num7 = 1;
										int num8 = num7;
										while (true)
										{
											switch (num8)
											{
											default:
												return;
											case 0:
												return;
											case 1:
												a.ItemWithDescriptor((string)_003C_003Ec.KDQutjvq79YAdhNmcoMZ(0x628167BE ^ 0x62839286), delegate(TypeSerializationDescriptorBuilder i)
												{
													int num13 = 1;
													int num14 = num13;
													while (true)
													{
														switch (num14)
														{
														default:
															return;
														case 0:
															return;
														case 1:
															_003C_003Ec.XBYuCPvqIffdl3fGhl4M(_003C_003Ec.AhWJSBvqo24W2FMIqX8k(i, _003C_003Ec.hdT58Ovq27WWHnVRIHme(_003C_003Ec.KDQutjvq79YAdhNmcoMZ(-10408775 ^ -10233401))), _003C_003Ec.eCIGgivqiUW7Gur1WLaq(typeof(string).TypeHandle));
															num14 = 0;
															if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
															{
																num14 = 0;
															}
															break;
														}
													}
												}).ItemWithDescriptor((string)_003C_003Ec.KDQutjvq79YAdhNmcoMZ(0x74AB4717 ^ 0x74AA4EBD), delegate(TypeSerializationDescriptorBuilder i)
												{
													int num11 = 1;
													int num12 = num11;
													while (true)
													{
														switch (num12)
														{
														default:
															return;
														case 1:
															((TypeSerializationDescriptorBuilder)_003C_003Ec.BkxEyRvqFNoD1NpEQ8GI(_003C_003Ec.AhWJSBvqo24W2FMIqX8k(i, _003C_003Ec.hdT58Ovq27WWHnVRIHme(_003C_003Ec.KDQutjvq79YAdhNmcoMZ(0x63D6C913 ^ 0x63D4E85F))), null)).Type(_003C_003Ec.eCIGgivqiUW7Gur1WLaq(typeof(DateTime).TypeHandle));
															num12 = 0;
															if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
															{
																num12 = 0;
															}
															break;
														case 0:
															return;
														}
													}
												}).ItemWithDescriptor((string)_003C_003Ec.KDQutjvq79YAdhNmcoMZ(-14356676 ^ -14280096), delegate(TypeSerializationDescriptorBuilder i)
												{
													int num9 = 1;
													int num10 = num9;
													while (true)
													{
														switch (num10)
														{
														default:
															return;
														case 1:
															_003C_003Ec.XBYuCPvqIffdl3fGhl4M(i.Description((string)_003C_003Ec.hdT58Ovq27WWHnVRIHme(_003C_003Ec.KDQutjvq79YAdhNmcoMZ(-1430645277 ^ -1430724537))).Optional(), typeof(DateTime));
															num10 = 0;
															if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
															{
																num10 = 0;
															}
															break;
														case 0:
															return;
														}
													}
												});
												num8 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
												{
													num8 = 0;
												}
												break;
											}
										}
									}), null);
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
									{
										num6 = 0;
									}
									break;
								}
							}
						})
						.ItemWithDescriptor(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642629679), delegate(TypeSerializationDescriptorBuilder i)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 1:
									_003C_003Ec.XBYuCPvqIffdl3fGhl4M(i.Description((string)_003C_003Ec.KDQutjvq79YAdhNmcoMZ(--1756698829 ^ 0x68B7ED2B)).Optional(), _003C_003Ec.eCIGgivqiUW7Gur1WLaq(typeof(WebData).TypeHandle));
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
									{
										num4 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						});
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass0_.needUnknownStatus = needUnknownStatus;
			num = 5;
		}
	}

	internal static void Execute(string executionToken, Dictionary<string, object> result, TimeSpan? waitTime = null)
	{
		IWorkflowInstance workflowInstance = null;
		IWorkflowTaskBase workflowTaskBase;
		if (!Guid.TryParse(executionToken, out var result2) || ((workflowTaskBase = WorkflowTaskBaseManager.Instance.LoadOrNull(result2)) == null && (workflowInstance = WorkflowInstanceManager.Instance.LoadOrNull(result2)) == null))
		{
			result[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-865213812 ^ -865229748)] = WorkflowTaskBaseExtensions.ExecuteStatusEnum.Unknown.ToString();
			return;
		}
		if (workflowTaskBase != null)
		{
			Execute(workflowTaskBase, result, waitTime, needExecutionToken: false);
		}
		if (workflowInstance != null)
		{
			Execute(workflowInstance, null, result, waitTime, needExecutionToken: false);
		}
	}

	public static void Execute(IWorkflowTaskBase task, Dictionary<string, object> result, TimeSpan? waitTime = null, bool needExecutionToken = true, bool needStatus = true)
	{
		Execute(task.WorkflowBookmark.Instance, task, result, waitTime, needExecutionToken, needStatus);
	}

	private static void Execute(object instance, object task, Dictionary<string, object> result, TimeSpan? waitTime = null, bool needExecutionToken = true, bool needStatus = true)
	{
		_003C_003Ec__DisplayClass3_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.task = (IWorkflowTaskBase)task;
		CS_0024_003C_003E8__locals0.instance = (IWorkflowInstance)instance;
		IList<IWorkflowQueueItem> source = Locator.GetServiceNotNull<IWorkflowQueueService>().WaitWhileQueued(CS_0024_003C_003E8__locals0.instance, waitTime);
		if (source.Any((IWorkflowQueueItem queueItem) => queueItem.Attempt == 0))
		{
			if (needStatus)
			{
				result[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x246EEF98 ^ 0x246EA958)] = WorkflowTaskBaseExtensions.ExecuteStatusEnum.Executing.ToString();
			}
			if (needExecutionToken && CS_0024_003C_003E8__locals0.task != null)
			{
				result[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862246720)] = CS_0024_003C_003E8__locals0.task.Uid.ToString();
			}
			return;
		}
		if (needStatus)
		{
			if (CS_0024_003C_003E8__locals0.task != null && source.Any(delegate(IWorkflowQueueItem queueItem)
			{
				//Discarded unreachable code: IL_0050, IL_0086, IL_0095
				int num3 = 2;
				Guid guid2 = default(Guid);
				Guid? elementUid2 = default(Guid?);
				while (true)
				{
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 3:
							return false;
						case 6:
							return _003C_003Ec__DisplayClass3_0.yQea8Tvq42a6cEtNW59G(guid2, elementUid2.GetValueOrDefault());
						case 1:
							return false;
						case 2:
							if (queueItem.Attempt <= 0)
							{
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
								{
									num4 = 1;
								}
								continue;
							}
							break;
						default:
							goto end_IL_0012;
						case 4:
							if (elementUid2.HasValue)
							{
								num4 = 6;
								continue;
							}
							goto case 3;
						case 5:
							break;
						}
						guid2 = _003C_003Ec__DisplayClass3_0.fVwJ3nvqERyF0yOtNZJs(queueItem);
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
						{
							num4 = 0;
						}
						continue;
						end_IL_0012:
						break;
					}
					elementUid2 = ((IWorkflowBookmark)_003C_003Ec__DisplayClass3_0.i95KfPvqw55Z38gXn6dD(CS_0024_003C_003E8__locals0.task)).ElementUid;
					num3 = 4;
				}
			}))
			{
				result[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F82617)] = WorkflowTaskBaseExtensions.ExecuteStatusEnum.Error.ToString();
				result[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x6283AF18)] = source.First(delegate(IWorkflowQueueItem queueItem)
				{
					int num = 4;
					int num2 = num;
					Guid? elementUid = default(Guid?);
					Guid guid = default(Guid);
					while (true)
					{
						switch (num2)
						{
						case 2:
							elementUid = ((IWorkflowBookmark)_003C_003Ec__DisplayClass3_0.i95KfPvqw55Z38gXn6dD(CS_0024_003C_003E8__locals0.task)).ElementUid;
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
							{
								num2 = 0;
							}
							break;
						case 4:
							if (queueItem.Attempt <= 0)
							{
								return false;
							}
							num2 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
							{
								num2 = 3;
							}
							break;
						default:
							if (elementUid.HasValue)
							{
								return _003C_003Ec__DisplayClass3_0.yQea8Tvq42a6cEtNW59G(guid, elementUid.GetValueOrDefault());
							}
							num2 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
							{
								num2 = 0;
							}
							break;
						case 1:
							return false;
						case 3:
							guid = _003C_003Ec__DisplayClass3_0.fVwJ3nvqERyF0yOtNZJs(queueItem);
							num2 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
							{
								num2 = 1;
							}
							break;
						}
					}
				}).LastError;
			}
			else if (CS_0024_003C_003E8__locals0.task == null && source.Any((IWorkflowQueueItem queueItem) => _003C_003Ec.f1ETSRvqNAyKl45rJYrx(queueItem) > 0))
			{
				result[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516537046)] = WorkflowTaskBaseExtensions.ExecuteStatusEnum.Error.ToString();
			}
			else
			{
				result[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39172772)] = WorkflowTaskBaseExtensions.ExecuteStatusEnum.Executed.ToString();
			}
		}
		IList<IWorkflowTaskBase> list = WorkflowTaskBaseManager.Instance.FindMyActiveTasks(CS_0024_003C_003E8__locals0.instance, allowSubInstances: true);
		if (list.Count > 0)
		{
			IWorkflowTaskBase workflowTaskBase = list[0];
			result.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x595C500A ^ 0x595E97C6), workflowTaskBase.Id);
			ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(workflowTaskBase.CastAsRealType().GetType());
			result.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F59211), classMetadata.Uid);
		}
		else if (CS_0024_003C_003E8__locals0.instance.Status == WorkflowInstanceStatus.Running && needExecutionToken && CS_0024_003C_003E8__locals0.task != null)
		{
			result[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -30127010)] = CS_0024_003C_003E8__locals0.task.Uid.ToString();
		}
		result.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF619FE), CS_0024_003C_003E8__locals0.instance.Status.ToString());
		UserTaskElement userTaskElement = ((CS_0024_003C_003E8__locals0.task != null) ? (CS_0024_003C_003E8__locals0.task.GetElement() as UserTaskElement) : null);
		if (userTaskElement != null && userTaskElement.EndTaskMessage != null)
		{
			result.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10230625), userTaskElement.EndTaskMessage);
		}
		CS_0024_003C_003E8__locals0.currentExecutions = Locator.GetServiceNotNull<IWorkflowQueueService>().GetGlobalExecutions();
		result.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111073571), new SerializableList<object>(source.Select(delegate(IWorkflowQueueItem queueItem)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_1();
			CS_0024_003C_003E8__locals0.queueItem = queueItem;
			Element element = CS_0024_003C_003E8__locals0.queueItem.Instance.Process.Diagram.Elements.FirstOrDefault((Element e) => _003C_003Ec__DisplayClass3_1.jf4b5Gv3YDHNgJmq1XA8(e) == _003C_003Ec__DisplayClass3_1.femuEvv38wmC5cboD8fv(CS_0024_003C_003E8__locals0.queueItem));
			WorkflowQueueItemExecutionInfo workflowQueueItemExecutionInfo = CS_0024_003C_003E8__locals0.currentExecutions.FirstOrDefault((WorkflowQueueItemExecutionInfo ce) => _003C_003Ec__DisplayClass3_1.XWHoPov3sTpRwy4qleMF(ce) == CS_0024_003C_003E8__locals0.queueItem.Id);
			SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object> { 
			{
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B7EDF5),
				(element != null) ? element.Name : ""
			} };
			if (workflowQueueItemExecutionInfo != null && workflowQueueItemExecutionInfo.ExecutionStart.HasValue)
			{
				serializableDictionary.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1430645277 ^ -1430578103), workflowQueueItemExecutionInfo.ExecutionStart.Value);
			}
			if (workflowQueueItemExecutionInfo != null && CS_0024_003C_003E8__locals0.queueItem.NextExecuteDate.HasValue)
			{
				serializableDictionary.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12D9D36), CS_0024_003C_003E8__locals0.queueItem.NextExecuteDate.Value);
			}
			return serializableDictionary;
		})));
		WebData webData = (from p in ComponentManager.Current.GetExtensionPoints<IExecutedTaskInfoProvider>()
			select (WebData)_003C_003Ec__DisplayClass3_0.BbRmQHvqzo2JHZx5AgHH(p, CS_0024_003C_003E8__locals0.instance)).FirstOrDefault((WebData d) => d != null);
		if (webData != null)
		{
			result.Add(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37EBB935), webData);
		}
	}

	internal static object j68L8hZHvDSKl16Uwsyp(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool HJ38q4ZHOuccrQqSsTag()
	{
		return uO6SEbZHKTlEZy9KMRQ3 == null;
	}

	internal static ExecuteUserTaskStatusHelper yxAQcoZHZVBr96ccEFgQ()
	{
		return uO6SEbZHKTlEZy9KMRQ3;
	}
}
