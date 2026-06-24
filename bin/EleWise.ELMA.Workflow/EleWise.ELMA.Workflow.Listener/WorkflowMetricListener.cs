using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.KPI.Common.Interfaces;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
public class WorkflowMetricListener : IEntityActionHandler, IEventHandler
{
	internal static WorkflowMetricListener shfNSSQBuyTNEmDASsy;

	public WorkflowProcessManager WorkflowProcessManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowProcessManager_003Ek__BackingField;
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
					_003CWorkflowProcessManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowInstanceContextService WorkflowInstanceContextService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowInstanceContextService_003Ek__BackingField;
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
					_003CWorkflowInstanceContextService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IInstanceMetricService InstanceMetricService
	{
		[CompilerGenerated]
		get
		{
			return _003CInstanceMetricService_003Ek__BackingField;
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
					_003CInstanceMetricService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public void ActionExecuted(EntityActionEventArgs e)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_0061
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					return;
				case 5:
					return;
				case 7:
					return;
				case 2:
					if (!IsTaskCompleteEvent(e))
					{
						goto end_IL_0012;
					}
					goto case 6;
				case 1:
					if (e == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
						{
							num2 = 0;
						}
						break;
					}
					if (!IsWorkflowInstanceCompleteEvent(e))
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 3;
				case 6:
					OnTaskCompleted(e);
					num2 = 5;
					break;
				case 3:
					OnProcessCompleted(e);
					num2 = 7;
					break;
				case 0:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	private void OnTaskCompleted(EntityActionEventArgs e)
	{
		//Discarded unreachable code: IL_012f, IL_013e, IL_01c6, IL_01d5, IL_0268, IL_0277, IL_02e0, IL_02f0, IL_02fa, IL_0400, IL_0463, IL_0476, IL_04d5, IL_04e4
		int num = 14;
		IWorkflowInstance instance = default(IWorkflowInstance);
		IWorkflowBookmark workflowBookmark = default(IWorkflowBookmark);
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		EntityMetadata entityMetadata = default(EntityMetadata);
		bool flag = default(bool);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		Guid? elementUid = default(Guid?);
		ProcessInstanceMetric processInstanceMetric = default(ProcessInstanceMetric);
		TimeSpan? time = default(TimeSpan?);
		Guid? selectedProcessTaskUid = default(Guid?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					instance = workflowBookmark.Instance;
					num = 12;
					break;
				case 13:
					if (workflowTaskBase == null)
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					workflowBookmark = (IWorkflowBookmark)uciAIMQdumdcBHYPg5S(workflowTaskBase);
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					if (RVcO1WQLgWc6SIYBppp(entityMetadata.Properties) > 0)
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					return;
				case 17:
					if (entityMetadata != null)
					{
						num2 = 2;
						continue;
					}
					return;
				case 7:
					if (instance.MetricValues != null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					return;
				case 12:
					entityMetadata = (EntityMetadata)ybJkdkQH0Tp8UOPdSG0(WorkflowInstanceContextService, V6aag0QnTrfa4d8BFfY(instance));
					num2 = 17;
					continue;
				case 4:
					flag = false;
					num2 = 10;
					continue;
				case 16:
					return;
				default:
					((Entity<long>)bfnTkUQRbhr0jUvc008(instance)).Save();
					num = 3;
					break;
				case 9:
					return;
				case 5:
					cOZSkQQDTEoZE3PrHE6(WorkflowInstanceContextService, nvWP0FQu34xx4oGEiWV(-801808857 ^ -801820001));
					num2 = 6;
					continue;
				case 11:
					if (!flag)
					{
						num2 = 15;
						continue;
					}
					goto default;
				case 3:
					return;
				case 15:
					return;
				case 1:
					try
					{
						while (true)
						{
							int num4;
							if (!enumerator.MoveNext())
							{
								int num3 = 13;
								num4 = num3;
								goto IL_01e4;
							}
							goto IL_039d;
							IL_01e4:
							while (true)
							{
								switch (num4)
								{
								case 4:
									elementUid = workflowBookmark.ElementUid;
									num4 = 11;
									continue;
								case 1:
								case 2:
								case 10:
									break;
								case 16:
									if (bbnlABQfjkIGCruTUTo(processInstanceMetric) == ProcessMetricComputationType.Time)
									{
										num4 = 2;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
										{
											num4 = 3;
										}
										continue;
									}
									break;
								case 3:
									if (bERfdwQ95KRuhdfmt9R(processInstanceMetric) == ProcessMetricTimeCalculationType.TaskExecutionTime)
									{
										num4 = 6;
										continue;
									}
									break;
								case 5:
									InstanceMetricService.UpdateWithExecutionTime(instance, processInstanceMetric, time);
									num4 = 12;
									continue;
								case 6:
									selectedProcessTaskUid = processInstanceMetric.SelectedProcessTaskUid;
									num4 = 4;
									continue;
								case 8:
									if (!processInstanceMetric.Active)
									{
										num4 = 2;
										continue;
									}
									goto case 16;
								case 11:
									if (selectedProcessTaskUid.HasValue != elementUid.HasValue)
									{
										num4 = 9;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
										{
											num4 = 9;
										}
										continue;
									}
									if (selectedProcessTaskUid.HasValue)
									{
										num4 = 17;
										continue;
									}
									goto case 7;
								case 12:
									MetricValueDataManager.Instance.DeactivateMetricTime(instance, NpbHO9QjcvyK0b0y6Sc(processInstanceMetric));
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
									{
										num4 = 0;
									}
									continue;
								case 14:
									goto IL_039d;
								default:
									flag = true;
									num4 = 10;
									continue;
								case 7:
								case 15:
									time = SubstractDates(instance, workflowTaskBase.CreationDate, workflowTaskBase.EndWorkDate, oQR9UUQWRhBb5N5MOIF(processInstanceMetric));
									num4 = 5;
									continue;
								case 17:
									if (selectedProcessTaskUid.GetValueOrDefault() == elementUid.GetValueOrDefault())
									{
										goto case 7;
									}
									goto case 9;
								case 9:
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
									{
										num4 = 1;
									}
									continue;
								case 13:
									goto end_IL_0249;
								}
								break;
							}
							continue;
							IL_039d:
							processInstanceMetric = (ProcessInstanceMetric)enumerator.Current;
							num4 = 8;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
							{
								num4 = 0;
							}
							goto IL_01e4;
							continue;
							end_IL_0249:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 11;
				case 8:
					if (workflowBookmark == null)
					{
						return;
					}
					num2 = 5;
					continue;
				case 14:
					workflowTaskBase = RYhFulQX5dcKaRu5V2f(e) as IWorkflowTaskBase;
					num2 = 13;
					continue;
				case 10:
					enumerator = entityMetadata.Properties.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private void OnProcessCompleted(EntityActionEventArgs e)
	{
		//Discarded unreachable code: IL_0102, IL_0164, IL_0173, IL_01c2, IL_01d1, IL_02a4, IL_037a, IL_0389, IL_045e, IL_0471, IL_0497, IL_04a7, IL_0597, IL_05f8, IL_06ac, IL_0718, IL_072b, IL_073a
		int num = 16;
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		bool flag = default(bool);
		EntityMetadata entityMetadata = default(EntityMetadata);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		ProcessInstanceMetric processInstanceMetric = default(ProcessInstanceMetric);
		TimeSpan? timeSpan = default(TimeSpan?);
		IUser executor = default(IUser);
		ProcessMetric processMetric = default(ProcessMetric);
		Guid? executorMetadataUid = default(Guid?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 17:
				case 18:
					workflowProcess = (IWorkflowProcess)k5kunpQQvIsCdV9yMBO(ibTqdjQTutn777uSYhd(workflowInstance.Process));
					num2 = 9;
					continue;
				case 6:
					return;
				case 8:
					cOZSkQQDTEoZE3PrHE6(WorkflowInstanceContextService, nvWP0FQu34xx4oGEiWV(-720457373 ^ -720445989));
					num2 = 24;
					continue;
				case 13:
					flag = false;
					num2 = 21;
					continue;
				default:
					if (RVcO1WQLgWc6SIYBppp(entityMetadata.Properties) <= 0)
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 2:
					obj = null;
					goto IL_077f;
				case 22:
					if (bfnTkUQRbhr0jUvc008(workflowInstance) != null)
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 17;
				case 14:
					if (entityMetadata == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto default;
				case 9:
					if (workflowProcess == null)
					{
						num2 = 2;
						continue;
					}
					obj = krOKyCQp9JK9x1ilXo2(WorkflowInstanceContextService, V6aag0QnTrfa4d8BFfY(workflowInstance));
					goto IL_077f;
				case 3:
					return;
				case 24:
					entityMetadata2 = (EntityMetadata)ybJkdkQH0Tp8UOPdSG0(WorkflowInstanceContextService, V6aag0QnTrfa4d8BFfY(workflowInstance));
					num2 = 19;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
					{
						num2 = 9;
					}
					continue;
				case 15:
					if (workflowInstance == null)
					{
						return;
					}
					num2 = 8;
					continue;
				case 20:
					if (RVcO1WQLgWc6SIYBppp(entityMetadata2.Properties) > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 17;
				case 21:
					enumerator = entityMetadata2.Properties.GetEnumerator();
					num = 23;
					break;
				case 11:
					z9aUO0QMuAXnSuqCB2l(kreuoQQCsVDIKqHlXmB(Locator.GetServiceNotNull<ISessionProvider>(), ""));
					num = 10;
					break;
				case 4:
					return;
				case 5:
					return;
				case 1:
					((Entity<long>)bfnTkUQRbhr0jUvc008(workflowInstance)).Save();
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
					{
						num2 = 4;
					}
					continue;
				case 7:
					if (flag)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 17;
				case 19:
					if (entityMetadata2 == null)
					{
						num2 = 17;
						continue;
					}
					goto case 20;
				case 23:
					try
					{
						while (true)
						{
							int num6;
							if (!enumerator.MoveNext())
							{
								num6 = 4;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
								{
									num6 = 5;
								}
								goto IL_02b2;
							}
							goto IL_0359;
							IL_0359:
							processInstanceMetric = (ProcessInstanceMetric)enumerator.Current;
							int num7 = 6;
							num6 = num7;
							goto IL_02b2;
							IL_02b2:
							while (true)
							{
								switch (num6)
								{
								case 3:
								case 8:
									break;
								case 1:
									timeSpan = SubstractDates(workflowInstance, workflowInstance.StartDate, workflowInstance.EndDate, oQR9UUQWRhBb5N5MOIF(processInstanceMetric));
									num6 = 9;
									continue;
								case 6:
									if (lkGNWeQ6lFr5Usyv0Ot(processInstanceMetric))
									{
										num6 = 7;
										continue;
									}
									break;
								default:
									flag = true;
									num6 = 3;
									continue;
								case 2:
									goto IL_0359;
								case 10:
									e5lX0ZQ3IiMkMVc9x5l(oT2LGhQq0x5bG5FliQi(), workflowInstance, NpbHO9QjcvyK0b0y6Sc(processInstanceMetric));
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
									{
										num6 = 0;
									}
									continue;
								case 9:
									((Entity<long>)bfnTkUQRbhr0jUvc008(workflowInstance)).SetPropertyValue(NpbHO9QjcvyK0b0y6Sc(processInstanceMetric), (object)timeSpan);
									num6 = 10;
									continue;
								case 7:
									if (bbnlABQfjkIGCruTUTo(processInstanceMetric) == ProcessMetricComputationType.Time)
									{
										num6 = 3;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
										{
											num6 = 4;
										}
										continue;
									}
									break;
								case 4:
									if (bERfdwQ95KRuhdfmt9R(processInstanceMetric) != 0)
									{
										num6 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
										{
											num6 = 8;
										}
										continue;
									}
									goto case 1;
								case 5:
									goto end_IL_02e8;
								}
								break;
							}
							continue;
							end_IL_02e8:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 7;
				case 16:
					workflowInstance = e.New as IWorkflowInstance;
					num2 = 15;
					continue;
				case 12:
					try
					{
						while (true)
						{
							IL_05a5:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 15;
								goto IL_04b5;
							}
							goto IL_057a;
							IL_04b5:
							while (true)
							{
								switch (num3)
								{
								case 15:
									return;
								case 17:
									executor = null;
									num3 = 6;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
									{
										num3 = 8;
									}
									continue;
								default:
									if (rGu9kFQ7T41XUprP6op(processMetric))
									{
										num3 = 7;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
										{
											num3 = 3;
										}
										continue;
									}
									goto case 14;
								case 16:
									if (yNYVoaQkubrfp9ZWMgt(processMetric))
									{
										int num4 = 12;
										num3 = num4;
										continue;
									}
									goto IL_05a5;
								case 12:
									if (!bu3fiCQU3cgC3p4sNYs(processMetric))
									{
										num3 = 2;
										continue;
									}
									goto case 17;
								case 10:
									break;
								case 1:
								case 2:
								case 9:
									goto IL_05a5;
								case 3:
								{
									object obj2 = bjtFDTQG6M0iBAn1SfO(workflowInstance);
									executorMetadataUid = processMetric.ExecutorMetadataUid;
									executor = ((Entity<long>)obj2).GetPropertyValue<IUser>(executorMetadataUid.Value);
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								case 11:
									if (executorMetadataUid.HasValue)
									{
										num3 = 6;
										continue;
									}
									goto default;
								case 6:
									executorMetadataUid = processMetric.ExecutorMetadataUid;
									num3 = 5;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
									{
										num3 = 1;
									}
									continue;
								case 5:
									if (!PybXnoQAHAPC4gMsQcs(executorMetadataUid.Value, Guid.Empty))
									{
										num3 = 13;
										continue;
									}
									goto case 3;
								case 8:
									if (p77FqAQVHf5QYcc69rL(processMetric))
									{
										num3 = 4;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto default;
								case 7:
									CalculateProcessMetricUsignFormula(workflowProcess, processMetric, executor);
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
									{
										num3 = 1;
									}
									continue;
								case 4:
									executorMetadataUid = processMetric.ExecutorMetadataUid;
									num3 = 11;
									continue;
								case 14:
									BR89EVQ27AZjXVKTkj0(workflowInstance, processMetric);
									num3 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
									{
										num3 = 9;
									}
									continue;
								}
								break;
							}
							goto IL_057a;
							IL_057a:
							processMetric = (ProcessMetric)enumerator.Current;
							num3 = 16;
							goto IL_04b5;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 10:
					{
						enumerator = entityMetadata.Properties.GetEnumerator();
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
						{
							num2 = 12;
						}
						continue;
					}
					IL_077f:
					entityMetadata = (EntityMetadata)obj;
					num2 = 14;
					continue;
				}
				break;
			}
		}
	}

	private void CalculateProcessMetricUsignFormula(IWorkflowProcess process, ProcessMetric metric, IUser executor = null)
	{
		int num = 2;
		ProcessMetricTaskRepeatAction formula = default(ProcessMetricTaskRepeatAction);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					return;
				case 1:
					switch (formula)
					{
					default:
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
						{
							num2 = 1;
						}
						goto end_IL_0012;
					case ProcessMetricTaskRepeatAction.Maximum:
						break;
					case ProcessMetricTaskRepeatAction.Sum:
						SetAggregateMetricValue(metric, process, (string)nvWP0FQu34xx4oGEiWV(-10408775 ^ -10363133), executor);
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
						{
							num2 = 4;
						}
						goto end_IL_0012;
					case ProcessMetricTaskRepeatAction.Minimum:
						SetAggregateMetricValue(metric, process, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351373968), executor);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
						{
							num2 = 0;
						}
						goto end_IL_0012;
					case ProcessMetricTaskRepeatAction.Average:
						SetAggregateMetricValue(metric, process, (string)nvWP0FQu34xx4oGEiWV(-1050383744 ^ -1050371772), executor);
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
						{
							num2 = 4;
						}
						goto end_IL_0012;
					}
					goto end_IL_0012_2;
				case 0:
					return;
				case 5:
					return;
				case 6:
					return;
				case 4:
					return;
				case 2:
					{
						formula = metric.Formula;
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
						{
							num2 = 1;
						}
						break;
					}
					end_IL_0012:
					break;
				}
				continue;
				end_IL_0012_2:
				break;
			}
			SetAggregateMetricValue(metric, process, (string)nvWP0FQu34xx4oGEiWV(-684210684 ^ -684247588), executor);
			num = 3;
		}
	}

	private void SetAggregateMetricValue(ProcessMetric metric, IWorkflowProcess process, string aggregateFunction, IUser executor = null)
	{
		//Discarded unreachable code: IL_023e, IL_024d, IL_0308, IL_0317, IL_0326, IL_0337, IL_0409, IL_0543, IL_061a, IL_0629, IL_06aa, IL_06de, IL_06ed, IL_06fc, IL_0807, IL_0816, IL_08e4, IL_09a3, IL_09b2
		int num = 43;
		ICriteria val2 = default(ICriteria);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		Guid? guid = default(Guid?);
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		Type type = default(Type);
		Pair<DateTime, DateTime> period = default(Pair<DateTime, DateTime>);
		IPeriodicityService serviceNotNull = default(IPeriodicityService);
		IPeriodicity periodicity = default(IPeriodicity);
		DetachedCriteria val3 = default(DetachedCriteria);
		WorkflowInstanceStatus[] array = default(WorkflowInstanceStatus[]);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		Type type2 = default(Type);
		object obj3 = default(object);
		object obj2 = default(object);
		EntityMetadata instanceMetricValuesMetadata = default(EntityMetadata);
		ISession val = default(ISession);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 30:
					yeD39apOsgvS2FSUk7U(val2, new IProjection[1] { (IProjection)sBvT79pvWIoA0vNjGc2(OnoguwQSqIq7NKbUGo9(propertyMetadata)) });
					num2 = 22;
					continue;
				case 38:
					if (!LerEdApKlF52shMleF0(aggregateFunction, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACC2E43)))
					{
						num2 = 12;
						continue;
					}
					goto case 7;
				case 61:
					guid = _003C_003Ec__DisplayClass16_.metric.PeriodicityUid;
					num2 = 34;
					continue;
				case 3:
					if (guid.HasValue)
					{
						num2 = 39;
						continue;
					}
					goto case 5;
				case 5:
					throw new Exception(SR.T((string)nvWP0FQu34xx4oGEiWV(-351369538 ^ -351373988), SR.T((string)pm4eUvQoNX8pNSodrZn(process)), _003C_003Ec__DisplayClass16_.metric.DisplayName));
				case 26:
					if (!RtaLWbQa7hmHx5Fyuh9(type, null))
					{
						num2 = 46;
						continue;
					}
					goto case 14;
				case 18:
					period = serviceNotNull.GetPeriod(periodicity, DateTime.Now);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
					{
						num2 = 8;
					}
					continue;
				case 40:
					BL5dB2QzF5NOT2Kk2pU(val2, mOwq3hQ47wVJ4jOUTWQ(nvWP0FQu34xx4oGEiWV(-1498811449 ^ -1498872167), val3));
					num2 = 38;
					continue;
				case 21:
					yeD39apOsgvS2FSUk7U(val2, new IProjection[1] { (IProjection)FQAVUopZjsstYmnkbT0(propertyMetadata.Name) });
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
					{
						num2 = 36;
					}
					continue;
				case 4:
					iiuGM9QxSNMyZWcfcS4(val3, nvWP0FQu34xx4oGEiWV(-539998957 ^ -540009031), nvWP0FQu34xx4oGEiWV(--1436248540 ^ 0x559B3020), (JoinType)0);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
					{
						num2 = 11;
					}
					continue;
				case 25:
					obj = null;
					goto IL_09eb;
				case 11:
					val3.Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -539971549), (ICollection)array));
					num2 = 58;
					continue;
				case 10:
					return;
				case 60:
					return;
				case 35:
					propertyMetadata2 = ((EntityMetadata)thKuMbQieWQ57H5rSZw(type2, true, true)).Properties.FirstOrDefault(_003C_003Ec__DisplayClass16_._003CSetAggregateMetricValue_003Eb__1);
					num2 = 55;
					continue;
				case 45:
					if (periodicity == null)
					{
						num = 53;
						break;
					}
					goto case 18;
				case 13:
				case 22:
				case 36:
				case 44:
				case 56:
					obj3 = zXnMYOp8TbVkpQWgEiM(val2);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
					{
						num2 = 1;
					}
					continue;
				case 23:
				case 31:
					FOTBX6pmJPvfHQ9xT6i(BScXZmpyVGGN0ycLGRJ(), _003C_003Ec__DisplayClass16_.metric, executor, obj2);
					num2 = 45;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
					{
						num2 = 60;
					}
					continue;
				case 12:
				case 28:
					if (LerEdApKlF52shMleF0(aggregateFunction, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F03618)))
					{
						num2 = 21;
						continue;
					}
					goto case 32;
				case 8:
					period.Second = period.Second.AddDays(1.0);
					num2 = 15;
					continue;
				case 63:
					val2.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)VXk7IPpY3gyo6RYolt4(OnoguwQSqIq7NKbUGo9(propertyMetadata)) });
					num2 = 29;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 56;
					}
					continue;
				case 2:
					if (instanceMetricValuesMetadata != null)
					{
						num2 = 35;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
						{
							num2 = 49;
						}
						continue;
					}
					goto case 25;
				case 37:
					j7gjQIQ1sLvOBiiDpUQ(val3, eOhiBiQEnhwi1HYIruS(nvWP0FQu34xx4oGEiWV(0x614CF569 ^ 0x614C002F), period.Second));
					num2 = 47;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 22;
					}
					continue;
				case 1:
					obj2 = jsLCCPpsP4s6s4nIykt(_003C_003Ec__DisplayClass16_.metric, obj3);
					num = 9;
					break;
				case 48:
					val3 = DetachedCriteria.For(type2);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num2 = 4;
					}
					continue;
				case 27:
					guid = _003C_003Ec__DisplayClass16_.metric.InstanceMetricUid;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
					{
						num2 = 2;
					}
					continue;
				case 39:
					if (propertyMetadata != null)
					{
						InterfaceActivator.Create<IWorkflowInstanceFilter>().ProcessHeader = (IProcessHeader)ibTqdjQTutn777uSYhd(process);
						num = 24;
					}
					else
					{
						num = 5;
					}
					break;
				case 15:
					j7gjQIQ1sLvOBiiDpUQ(val3, jx2BY0QhGiWDMAKiVYw(nvWP0FQu34xx4oGEiWV(-1214182792 ^ -1214120130), period.First));
					num2 = 29;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
					{
						num2 = 37;
					}
					continue;
				case 29:
					j7gjQIQ1sLvOBiiDpUQ(val3, Restrictions.Eq((string)OnoguwQSqIq7NKbUGo9(propertyMetadata2), (object)executor));
					num2 = 19;
					continue;
				case 55:
					type = JkMJKGQIcRWFpxIE6QA(WorkflowInstanceContextService, process);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
					{
						num2 = 26;
					}
					continue;
				case 54:
				case 62:
					if (!(aggregateFunction == SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720485701)))
					{
						num2 = 44;
						continue;
					}
					goto case 63;
				case 58:
					if (executor != null)
					{
						num2 = 50;
						continue;
					}
					goto case 19;
				case 34:
					if (!guid.HasValue)
					{
						num2 = 20;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 17;
				case 43:
					_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
					num = 42;
					break;
				case 32:
					if (!LerEdApKlF52shMleF0(aggregateFunction, nvWP0FQu34xx4oGEiWV(-63028171 ^ -62998533)))
					{
						num2 = 54;
						continue;
					}
					goto case 30;
				case 16:
				{
					IPeriodicityService periodicityService = serviceNotNull;
					guid = _003C_003Ec__DisplayClass16_.metric.PeriodicityUid;
					periodicity = periodicityService.Load(guid.Value);
					num2 = 23;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
					{
						num2 = 45;
					}
					continue;
				}
				case 50:
					if (propertyMetadata2 == null)
					{
						num = 59;
						break;
					}
					goto case 29;
				case 33:
					if (!CdtO2Yp0QEWj8BReI2o(_003C_003Ec__DisplayClass16_.metric))
					{
						num2 = 10;
						continue;
					}
					goto case 23;
				case 24:
					type2 = IZso9IQF91FLM606ghh(WorkflowInstanceContextService, process);
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
					{
						num2 = 35;
					}
					continue;
				default:
					val = (ISession)kreuoQQCsVDIKqHlXmB(Locator.GetServiceNotNull<ISessionProvider>(), "");
					num2 = 57;
					continue;
				case 6:
					array = new WorkflowInstanceStatus[2]
					{
						WorkflowInstanceStatus.Running,
						WorkflowInstanceStatus.Completed
					};
					num2 = 48;
					continue;
				case 19:
				case 59:
					if (_003C_003Ec__DisplayClass16_.metric.UsePeriodicity)
					{
						num = 61;
						break;
					}
					goto case 20;
				case 57:
					instanceMetricValuesMetadata = WorkflowInstanceContextService.GetInstanceMetricValuesMetadata(process);
					num2 = 2;
					continue;
				case 51:
					if (p77FqAQVHf5QYcc69rL(_003C_003Ec__DisplayClass16_.metric))
					{
						num = 23;
						break;
					}
					goto case 33;
				case 52:
					cOZSkQQDTEoZE3PrHE6(WorkflowInstanceContextService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657593699));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					yeD39apOsgvS2FSUk7U(val2, new IProjection[1] { (IProjection)Projections.Avg((string)OnoguwQSqIq7NKbUGo9(propertyMetadata)) });
					num2 = 13;
					continue;
				case 20:
				case 47:
				case 53:
					val3.SetProjection((IProjection)gvnWoqQw5Xu1ECJTfpe(nvWP0FQu34xx4oGEiWV(-14356676 ^ -14370922)));
					num2 = 30;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
					{
						num2 = 40;
					}
					continue;
				case 17:
					serviceNotNull = Locator.GetServiceNotNull<IPeriodicityService>();
					num2 = 16;
					continue;
				case 42:
					_003C_003Ec__DisplayClass16_.metric = metric;
					num2 = 52;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num2 = 2;
					}
					continue;
				case 14:
					throw new MetadataException((string)ix25gZQeXq8TSDCtZcs(nvWP0FQu34xx4oGEiWV(-1108877388 ^ -1108923620), new object[1] { CF01itQrOr6Q5xJaEp1(ibTqdjQTutn777uSYhd(process)) }));
				case 46:
					val2 = (ICriteria)gebI9VQN5gDPvERUTdr(val, type);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
					QWIy6kplXIXTUvSHvc1(mV9BiIpJxRlyH78T5uO(process), NpbHO9QjcvyK0b0y6Sc(_003C_003Ec__DisplayClass16_.metric), obj2);
					num2 = 41;
					continue;
				case 41:
					((Entity<long>)mV9BiIpJxRlyH78T5uO(process)).Save();
					num2 = 51;
					continue;
				case 49:
					{
						obj = instanceMetricValuesMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass16_._003CSetAggregateMetricValue_003Eb__0);
						goto IL_09eb;
					}
					IL_09eb:
					propertyMetadata = (PropertyMetadata)obj;
					num2 = 27;
					continue;
				}
				break;
			}
		}
	}

	private static object ConvertToBdType(object metric, object value)
	{
		//Discarded unreachable code: IL_00cc, IL_0122
		int num = 2;
		int num2 = num;
		ProcessMetricDataType processMetricDataType = default(ProcessMetricDataType);
		while (true)
		{
			switch (num2)
			{
			case 5:
			case 6:
				return Convert.ToInt32(value);
			case 4:
				return value;
			case 2:
				if (dPjUFeptbeu67N9nm2p(metric) == ProcessMetricComputationType.Time)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				processMetricDataType = Af2dJIp5SEeWllifDmP(metric);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
				{
					num2 = 3;
				}
				continue;
			case 3:
				if (processMetricDataType == ProcessMetricDataType.Integer)
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			case 1:
				if (value is TimeSpan)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				return new TimeSpan(PtLwCopbA1aqLjgPX1X(value));
			default:
				return value;
			case 7:
				break;
			}
			if (processMetricDataType == ProcessMetricDataType.TimeSpan)
			{
				break;
			}
			num2 = 4;
		}
		return new TimeSpan(Convert.ToInt64(value));
	}

	private static void LaunchScript(object workflowInstance, object metric)
	{
		//Discarded unreachable code: IL_003d, IL_004c
		int num = 5;
		int num2 = num;
		IWorkflowScriptingService service = default(IWorkflowScriptingService);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 6:
				Vedc7jpXDAKQ3dDr4t3(P9nMYhpcbFvIJdEtBYK(), ix25gZQeXq8TSDCtZcs(nvWP0FQu34xx4oGEiWV(-1712492721 ^ -1712481593), new object[2]
				{
					pm4eUvQoNX8pNSodrZn(((IProcessHeader)ibTqdjQTutn777uSYhd(V6aag0QnTrfa4d8BFfY(workflowInstance))).Published),
					RLALd3pP2fH8Y3YcwTK(metric)
				}));
				num2 = 3;
				break;
			case 3:
				return;
			case 4:
				service = Locator.GetService<IWorkflowScriptingService>();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				service.ExecuteScript((IWorkflowInstance)workflowInstance, (string)FoTOYOpgD3yw7TnNFpG(metric));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (service == null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (!tpR1gqpBhCwInqR1h8W(FoTOYOpgD3yw7TnNFpG(metric)))
				{
					num2 = 4;
					break;
				}
				goto case 6;
			}
		}
	}

	private bool IsWorkflowInstanceCompleteEvent(EntityActionEventArgs e)
	{
		//Discarded unreachable code: IL_0105, IL_0114, IL_0124, IL_0133
		int num = 1;
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		IWorkflowInstance workflowInstance2 = default(IWorkflowInstance);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (P6bpRRpnfnCyBGcnCXY(workflowInstance) == WorkflowInstanceStatus.Running)
					{
						num2 = 4;
						continue;
					}
					goto case 8;
				case 4:
					return P6bpRRpnfnCyBGcnCXY(workflowInstance2) == WorkflowInstanceStatus.Completed;
				case 8:
					return false;
				case 1:
					workflowInstance2 = RYhFulQX5dcKaRu5V2f(e) as IWorkflowInstance;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return false;
				case 5:
					if (workflowInstance != null)
					{
						num2 = 6;
						continue;
					}
					goto case 2;
				case 2:
					return false;
				case 6:
					if (!vL9ZutpD395weuuHVMh(((IAuditAction)Uy4RRtpu5NMMBp5xYs4(e)).Uid, DefaultEntityActions.UpdateGuid))
					{
						num2 = 8;
						continue;
					}
					goto case 7;
				}
				if (workflowInstance2 != null)
				{
					break;
				}
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
				{
					num2 = 0;
				}
			}
			workflowInstance = oiXqBqpdWQCY8aqdYu3(e) as IWorkflowInstance;
			num = 5;
		}
	}

	private bool IsTaskCompleteEvent(EntityActionEventArgs e)
	{
		//Discarded unreachable code: IL_0095, IL_00b5, IL_00c4
		int num = 3;
		int num2 = num;
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		IWorkflowTaskBase workflowTaskBase2 = default(IWorkflowTaskBase);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (!((EnumBase)PNr7tIpH9D3qEAiWIDL(workflowTaskBase) == (EnumBase)k6Iva9pfijhuoOOi97b()))
				{
					num2 = 4;
					continue;
				}
				goto case 1;
			case 7:
				if (workflowTaskBase != null)
				{
					num2 = 6;
					continue;
				}
				goto case 9;
			case 3:
				workflowTaskBase = oiXqBqpdWQCY8aqdYu3(e) as IWorkflowTaskBase;
				num2 = 2;
				continue;
			case 6:
				if (workflowTaskBase2 != null)
				{
					num2 = 5;
					continue;
				}
				goto case 9;
			case 9:
				return false;
			case 5:
				if (!vL9ZutpD395weuuHVMh(((IAuditAction)Uy4RRtpu5NMMBp5xYs4(e)).Uid, DefaultEntityActions.UpdateGuid))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 10;
			case 10:
				if (!qNInJfpLZvZG69RZMdX(PNr7tIpH9D3qEAiWIDL(workflowTaskBase), TaskBaseStatus.Read))
				{
					num2 = 8;
					continue;
				}
				goto case 1;
			case 2:
				workflowTaskBase2 = RYhFulQX5dcKaRu5V2f(e) as IWorkflowTaskBase;
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
				{
					num2 = 7;
				}
				continue;
			case 4:
				if (qNInJfpLZvZG69RZMdX(workflowTaskBase.Status, TaskBaseStatus.NewOrder))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				return qNInJfpLZvZG69RZMdX(PNr7tIpH9D3qEAiWIDL(workflowTaskBase2), TaskBaseStatus.Complete);
			}
			break;
		}
		return false;
	}

	private static TimeSpan? SubstractDates(object instance, DateTime? startDate, DateTime? endDate, bool useWorkCalendar)
	{
		if (!startDate.HasValue || !endDate.HasValue)
		{
			return null;
		}
		if (useWorkCalendar)
		{
			return Locator.GetServiceNotNull<IProductionCalendarService>().GetProductionSchedule(null, (IEntity)instance).EvalWorkTimeDifference(startDate.Value, endDate.Value);
		}
		return endDate - startDate;
	}

	public WorkflowMetricListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		t3f5Z2p95lOUmikoUig();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rDByZqQcyvV5avcoApT()
	{
		return shfNSSQBuyTNEmDASsy == null;
	}

	internal static WorkflowMetricListener cKc0CmQPLZOq7SbBOnt()
	{
		return shfNSSQBuyTNEmDASsy;
	}

	internal static object RYhFulQX5dcKaRu5V2f(object P_0)
	{
		return ((EntityActionEventArgs)P_0).New;
	}

	internal static object uciAIMQdumdcBHYPg5S(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object nvWP0FQu34xx4oGEiWV(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void cOZSkQQDTEoZE3PrHE6(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static object V6aag0QnTrfa4d8BFfY(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object ybJkdkQH0Tp8UOPdSG0(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceMetricValuesMetadata((IWorkflowProcess)P_1);
	}

	internal static int RVcO1WQLgWc6SIYBppp(object P_0)
	{
		return ((List<PropertyMetadata>)P_0).Count;
	}

	internal static ProcessMetricComputationType bbnlABQfjkIGCruTUTo(object P_0)
	{
		return ((ProcessInstanceMetric)P_0).Type;
	}

	internal static ProcessMetricTimeCalculationType bERfdwQ95KRuhdfmt9R(object P_0)
	{
		return ((ProcessInstanceMetric)P_0).TimeMetricCalculationType;
	}

	internal static bool oQR9UUQWRhBb5N5MOIF(object P_0)
	{
		return ((ProcessInstanceMetric)P_0).UseWorkCalendar;
	}

	internal static Guid NpbHO9QjcvyK0b0y6Sc(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object bfnTkUQRbhr0jUvc008(object P_0)
	{
		return ((IWorkflowInstance)P_0).MetricValues;
	}

	internal static bool lkGNWeQ6lFr5Usyv0Ot(object P_0)
	{
		return ((ProcessInstanceMetric)P_0).Active;
	}

	internal static object oT2LGhQq0x5bG5FliQi()
	{
		return MetricValueDataManager.Instance;
	}

	internal static void e5lX0ZQ3IiMkMVc9x5l(object P_0, object P_1, Guid metricUid)
	{
		((MetricValueDataManager)P_0).DeactivateMetricTime((IWorkflowInstance)P_1, metricUid);
	}

	internal static object ibTqdjQTutn777uSYhd(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object k5kunpQQvIsCdV9yMBO(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static object krOKyCQp9JK9x1ilXo2(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetProcessMetricValuesMetadata((IWorkflowProcess)P_1);
	}

	internal static object kreuoQQCsVDIKqHlXmB(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static void z9aUO0QMuAXnSuqCB2l(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static bool yNYVoaQkubrfp9ZWMgt(object P_0)
	{
		return ((ProcessMetric)P_0).Active;
	}

	internal static bool bu3fiCQU3cgC3p4sNYs(object P_0)
	{
		return ((ProcessMetric)P_0).CalculateAfterProcess;
	}

	internal static bool p77FqAQVHf5QYcc69rL(object P_0)
	{
		return ((ProcessMetric)P_0).IsPersonal;
	}

	internal static bool PybXnoQAHAPC4gMsQcs(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object bjtFDTQG6M0iBAn1SfO(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static bool rGu9kFQ7T41XUprP6op(object P_0)
	{
		return ((ProcessMetric)P_0).UseFormula;
	}

	internal static void BR89EVQ27AZjXVKTkj0(object P_0, object P_1)
	{
		LaunchScript(P_0, P_1);
	}

	internal static object pm4eUvQoNX8pNSodrZn(object P_0)
	{
		return ((IWorkflowProcess)P_0).Name;
	}

	internal static Type IZso9IQF91FLM606ghh(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceContextType((IWorkflowProcess)P_1);
	}

	internal static object thKuMbQieWQ57H5rSZw(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static Type JkMJKGQIcRWFpxIE6QA(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetFullInstanceMetricValuesType((IWorkflowProcess)P_1);
	}

	internal static bool RtaLWbQa7hmHx5Fyuh9(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object CF01itQrOr6Q5xJaEp1(object P_0)
	{
		return ((IProcessHeader)P_0).Name;
	}

	internal static object ix25gZQeXq8TSDCtZcs(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object gebI9VQN5gDPvERUTdr(object P_0, Type P_1)
	{
		return ((ISession)P_0).CreateCriteria(P_1);
	}

	internal static object iiuGM9QxSNMyZWcfcS4(object P_0, object P_1, object P_2, JoinType P_3)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return ((DetachedCriteria)P_0).CreateAlias((string)P_1, (string)P_2, P_3);
	}

	internal static object OnoguwQSqIq7NKbUGo9(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object j7gjQIQ1sLvOBiiDpUQ(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object jx2BY0QhGiWDMAKiVYw(object P_0, object P_1)
	{
		return Restrictions.Ge((string)P_0, P_1);
	}

	internal static object eOhiBiQEnhwi1HYIruS(object P_0, object P_1)
	{
		return Restrictions.Le((string)P_0, P_1);
	}

	internal static object gvnWoqQw5Xu1ECJTfpe(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object mOwq3hQ47wVJ4jOUTWQ(object P_0, object P_1)
	{
		return Subqueries.PropertyIn((string)P_0, (DetachedCriteria)P_1);
	}

	internal static object BL5dB2QzF5NOT2Kk2pU(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static bool LerEdApKlF52shMleF0(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object yeD39apOsgvS2FSUk7U(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static object FQAVUopZjsstYmnkbT0(object P_0)
	{
		return Projections.Sum((string)P_0);
	}

	internal static object sBvT79pvWIoA0vNjGc2(object P_0)
	{
		return Projections.Min((string)P_0);
	}

	internal static object VXk7IPpY3gyo6RYolt4(object P_0)
	{
		return Projections.Max((string)P_0);
	}

	internal static object zXnMYOp8TbVkpQWgEiM(object P_0)
	{
		return ((ICriteria)P_0).UniqueResult();
	}

	internal static object jsLCCPpsP4s6s4nIykt(object P_0, object P_1)
	{
		return ConvertToBdType(P_0, P_1);
	}

	internal static object mV9BiIpJxRlyH78T5uO(object P_0)
	{
		return ((IWorkflowProcess)P_0).MetricValues;
	}

	internal static void QWIy6kplXIXTUvSHvc1(object P_0, Guid P_1, object P_2)
	{
		((Entity<long>)P_0).SetPropertyValue(P_1, P_2);
	}

	internal static bool CdtO2Yp0QEWj8BReI2o(object P_0)
	{
		return ((ProcessMetric)P_0).UsePeriodicity;
	}

	internal static object BScXZmpyVGGN0ycLGRJ()
	{
		return ProcessMetricValueManager.Instance;
	}

	internal static void FOTBX6pmJPvfHQ9xT6i(object P_0, object P_1, object P_2, object P_3)
	{
		((ProcessMetricValueManager)P_0).MetricSave((ProcessMetric)P_1, (IUser)P_2, P_3);
	}

	internal static ProcessMetricComputationType dPjUFeptbeu67N9nm2p(object P_0)
	{
		return ((ProcessMetric)P_0).Type;
	}

	internal static long PtLwCopbA1aqLjgPX1X(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static ProcessMetricDataType Af2dJIp5SEeWllifDmP(object P_0)
	{
		return ((ProcessMetric)P_0).DataType;
	}

	internal static object FoTOYOpgD3yw7TnNFpG(object P_0)
	{
		return ((ProcessMetric)P_0).ScriptFunctionName;
	}

	internal static bool tpR1gqpBhCwInqR1h8W(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object P9nMYhpcbFvIJdEtBYK()
	{
		return Logger.Log;
	}

	internal static object RLALd3pP2fH8Y3YcwTK(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void Vedc7jpXDAKQ3dDr4t3(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object oiXqBqpdWQCY8aqdYu3(object P_0)
	{
		return ((EntityActionEventArgs)P_0).Old;
	}

	internal static object Uy4RRtpu5NMMBp5xYs4(object P_0)
	{
		return ((AuditEventArgs)P_0).Action;
	}

	internal static bool vL9ZutpD395weuuHVMh(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static WorkflowInstanceStatus P6bpRRpnfnCyBGcnCXY(object P_0)
	{
		return ((IWorkflowInstance)P_0).Status;
	}

	internal static object PNr7tIpH9D3qEAiWIDL(object P_0)
	{
		return ((ITaskBase)P_0).Status;
	}

	internal static bool qNInJfpLZvZG69RZMdX(object P_0, object P_1)
	{
		return (EnumBase)P_0 == (EnumBase)P_1;
	}

	internal static object k6Iva9pfijhuoOOi97b()
	{
		return TaskBaseStatus.InProgress;
	}

	internal static void t3f5Z2p95lOUmikoUig()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
