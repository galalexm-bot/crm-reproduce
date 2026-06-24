using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.KPI.Common.Code;
using EleWise.ELMA.KPI.Common.Interfaces;
using EleWise.ELMA.KPI.Common.Scales;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.ProcessMetricExtensions;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal class WorkflowMetricValueChangedListener : EntityEventsListener
{
	private readonly IEnumerable<IProcessMetricSaveValue> processMetricSaveValuePoints;

	private static WorkflowMetricValueChangedListener EZXhNCT7gmdTaXycdsc;

	public IMemoryCacheService MemoryCacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CMemoryCacheService_003Ek__BackingField;
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
					_003CMemoryCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowMetricValueChangedListener(IEnumerable<IProcessMetricSaveValue> processMetricSaveValuePoints)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		this.processMetricSaveValuePoints = processMetricSaveValuePoints;
	}

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				CheckInstanceMetrics(gAThHMTFEUs9ytwUbkB(@event));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num2 = 2;
				}
				break;
			default:
				return DSFhLETiV1KlOZiKpnk(this, @event);
			case 1:
				SyncronizeProcessMetrics(gAThHMTFEUs9ytwUbkB(@event));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				CheckProcessMetrics(((AbstractPreDatabaseOperationEvent)@event).get_Entity());
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				CheckInstanceMetrics(gAThHMTFEUs9ytwUbkB(@event));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return base.OnPreUpdate(@event);
			case 1:
				SyncronizeProcessMetrics(gAThHMTFEUs9ytwUbkB(@event));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				CheckProcessMetrics(gAThHMTFEUs9ytwUbkB(@event));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void SyncronizeProcessMetrics(object entity)
	{
		//Discarded unreachable code: IL_00aa, IL_012e, IL_013d, IL_0187, IL_0196, IL_01c1, IL_024a, IL_02a4, IL_02b3, IL_02fe, IL_0311, IL_0320, IL_0352
		int num = 7;
		long? headerIdByFullMetadataUid = default(long?);
		IWorkflowProcess published = default(IWorkflowProcess);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		IMetadata metadata = default(IMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		ProcessMetric processMetric = default(ProcessMetric);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				default:
					return;
				case 11:
					if (headerIdByFullMetadataUid.HasValue)
					{
						num2 = 8;
						continue;
					}
					return;
				case 0:
					return;
				case 8:
					published = ProcessHeaderManager.Instance.Load(headerIdByFullMetadataUid.Value).Published;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					return;
				case 14:
					workflowInstance = (IWorkflowInstance)VCtravTx8TJKIloXBdv(entity);
					num2 = 12;
					continue;
				case 7:
					metadata = (IMetadata)XGt38cTIN7H7GgUsRQh(entity.GetType(), true, true);
					num2 = 6;
					continue;
				case 13:
					return;
				case 9:
					headerIdByFullMetadataUid = ((WorkflowInstanceContextService)cQ2OHmTa3T6tQqC4vdc()).GetHeaderIdByFullMetadataUid(oIDJ69TrUUtmiQYGjc3(metadata));
					num2 = 11;
					continue;
				case 15:
					if (TjJgA2TNq6CCMJHpOsV(entityMetadata.Properties) <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 14;
				case 12:
					enumerator = entityMetadata.Properties.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					if (published == null)
					{
						num2 = 5;
						continue;
					}
					obj = B7UlCpTeTkrvTl6WjYO(cQ2OHmTa3T6tQqC4vdc(), published);
					break;
				case 10:
					return;
				case 6:
					if (!(metadata is ProcessMetricsContainer))
					{
						return;
					}
					goto end_IL_0012;
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
								{
									num3 = 0;
								}
								goto IL_01cf;
							}
							goto IL_0258;
							IL_0258:
							processMetric = (ProcessMetric)enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
							{
								num3 = 1;
							}
							goto IL_01cf;
							IL_01cf:
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									if (!y9cOp9TSVlNZ8tkbaiZ(processMetric))
									{
										num3 = 2;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
										{
											num3 = 5;
										}
										continue;
									}
									goto case 4;
								case 2:
								case 5:
								case 6:
									break;
								case 3:
									goto IL_0258;
								case 4:
									if (TrySavePersonalPeriodicMetric(published, workflowInstance, processMetric))
									{
										int num4 = 6;
										num3 = num4;
										continue;
									}
									goto case 7;
								case 7:
									ExtensionSynchronize(published, processMetric);
									num3 = 2;
									continue;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 3:
					if (entityMetadata == null)
					{
						return;
					}
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
					{
						num2 = 6;
					}
					continue;
				case 5:
					obj = null;
					break;
				}
				entityMetadata = (EntityMetadata)obj;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
				{
					num2 = 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	private bool TrySavePersonalPeriodicMetric(IWorkflowProcess process, IWorkflowInstance workflowInstance, ProcessMetric processMetric)
	{
		//Discarded unreachable code: IL_0085, IL_00f9, IL_0150, IL_01f0, IL_02ce, IL_02ee
		int num = 8;
		IUser user = default(IUser);
		double result = default(double);
		Guid? guid = default(Guid?);
		bool flag = default(bool);
		object obj2 = default(object);
		bool flag2 = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				int num3;
				switch (num2)
				{
				case 6:
					V6jLBsQONXMOA5fDd0S(TGS10ZQKEmRiSVH5yjU(), processMetric, user, result);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
				{
					object obj = oEDXFpTwfUPR3VRbdfC(workflowInstance);
					guid = processMetric.ExecutorMetadataUid;
					user = ((Entity<long>)obj).GetPropertyValue<IUser>(guid.Value);
					num2 = 16;
					continue;
				}
				case 14:
					if (!flag)
					{
						num2 = 17;
						continue;
					}
					goto case 24;
				case 5:
					if (guid.HasValue)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 22;
				case 4:
					guid = processMetric.PeriodicityUid;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
					{
						num2 = 3;
					}
					continue;
				case 20:
					obj2 = alENOXTzlN3kf0lnVQZ(process.MetricValues, wKmajBT4qfuDbnZKOme(processMetric));
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
					{
						num2 = 18;
					}
					continue;
				case 12:
					guid = processMetric.ExecutorMetadataUid;
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
					{
						num2 = 19;
					}
					continue;
				default:
					user = null;
					num2 = 15;
					continue;
				case 15:
					if (!(flag || flag2))
					{
						num2 = 20;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 14;
				case 19:
					num4 = (zbkN9KThb61O3oVyxu8(guid.Value, Guid.Empty) ? 1 : 0);
					goto IL_033b;
				case 8:
					if (bgKoHpT1IVDng8kNhAM(processMetric))
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto IL_033a;
				case 1:
					if (guid.HasValue)
					{
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto IL_033a;
				case 2:
					return true;
				case 21:
				case 23:
					return false;
				case 18:
					if (obj2 == null)
					{
						num2 = 21;
						continue;
					}
					goto case 9;
				case 3:
					goto end_IL_0012;
				case 16:
				case 17:
					if (user != null)
					{
						num2 = 19;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 21;
				case 24:
					if (workflowInstance != null)
					{
						num2 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 16;
				case 9:
					if (double.TryParse(obj2.ToString(), out result))
					{
						num2 = 6;
						continue;
					}
					goto case 21;
				case 11:
					num3 = (zbkN9KThb61O3oVyxu8(guid.Value, Guid.Empty) ? 1 : 0);
					break;
				case 7:
					guid = processMetric.ExecutorMetadataUid;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					if (!tSjXENTESmenKwCWo5m(processMetric))
					{
						num2 = 22;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 4;
				case 22:
					{
						num3 = 0;
						break;
					}
					IL_033a:
					num4 = 0;
					goto IL_033b;
					IL_033b:
					flag = (byte)num4 != 0;
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 7;
					}
					continue;
				}
				flag2 = (byte)num3 != 0;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			guid = processMetric.PeriodicityUid;
			num = 11;
		}
	}

	private void ExtensionSynchronize(IWorkflowProcess process, ProcessMetric processMetric)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_00a2, IL_00ac, IL_013a, IL_0172, IL_0181
		int num = 2;
		int num2 = num;
		IEnumerator<IProcessMetricSaveValue> enumerator = default(IEnumerator<IProcessMetricSaveValue>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 4:
				return;
			case 2:
				if (processMetricSaveValuePoints == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				enumerator = processMetricSaveValuePoints.GetEnumerator();
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!OXmTh2QZZuR49OJ7cQb(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
							{
								num3 = 0;
							}
							goto IL_00b0;
						}
						goto IL_00ec;
						IL_00ec:
						enumerator.Current.Synchronize(process, processMetric);
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
						{
							num3 = 1;
						}
						goto IL_00b0;
						IL_00b0:
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							break;
						case 2:
							goto IL_00ec;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								rPlqotQvGrR3eomgXCl(enumerator);
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			}
		}
	}

	private void CheckInstanceMetrics(object entity)
	{
		//Discarded unreachable code: IL_003d, IL_004c, IL_00a2, IL_00b1
		int num = 5;
		int num2 = num;
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				workflowInstance = GetWorkflowInstance(entity);
				num2 = 2;
				break;
			case 5:
				if (!(XGt38cTIN7H7GgUsRQh(entity.GetType(), true, true) is ProcessInstanceMetricsContainer))
				{
					num2 = 4;
					break;
				}
				goto case 1;
			case 4:
				return;
			case 6:
				return;
			default:
				CheckForCrititcalInstanceMetrics(workflowInstance);
				num2 = 6;
				break;
			case 2:
				if (workflowInstance == null)
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	private void CheckProcessMetrics(object entity)
	{
		//Discarded unreachable code: IL_009f, IL_00ae, IL_00dc, IL_00eb
		int num = 7;
		int num2 = num;
		IProcessHeader processHeader = default(IProcessHeader);
		IMetadata metadata = default(IMetadata);
		long? headerIdByFullMetadataUid = default(long?);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				if (JU1WDkQ8PL8s4l3W2aX(processHeader) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			case 3:
				CheckForCrititcalProcessMetrics(processHeader.Published);
				num2 = 9;
				break;
			case 7:
				metadata = (IMetadata)XGt38cTIN7H7GgUsRQh(entity.GetType(), true, true);
				num2 = 6;
				break;
			case 0:
				return;
			case 1:
				processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)BO5oxmQYjBqDr21dmW0()).Load(headerIdByFullMetadataUid.Value);
				num2 = 5;
				break;
			case 2:
				return;
			case 9:
				return;
			case 8:
				return;
			case 4:
				if (!headerIdByFullMetadataUid.HasValue)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				if (metadata is ProcessMetricsContainer)
				{
					headerIdByFullMetadataUid = ((WorkflowInstanceContextService)cQ2OHmTa3T6tQqC4vdc()).GetHeaderIdByFullMetadataUid(oIDJ69TrUUtmiQYGjc3(metadata));
					num2 = 4;
					break;
				}
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
				{
					num2 = 8;
				}
				break;
			}
		}
	}

	private void CheckForCrititcalProcessMetrics(IWorkflowProcess process)
	{
		//Discarded unreachable code: IL_00bf
		int num = 1;
		int num2 = num;
		EntityMetadata processMetricValuesMetadata = default(EntityMetadata);
		List<ProcessMetric> metrics = default(List<ProcessMetric>);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 5:
				return;
			default:
				if (processMetricValuesMetadata == null)
				{
					num2 = 4;
					break;
				}
				goto case 7;
			case 2:
				process.HasWarningMetric = CheckMetrics(metrics, h43YaDQJiAXovw4HQPU(process), ScaleStatus.Normal);
				num2 = 5;
				break;
			case 3:
				metrics = processMetricValuesMetadata.Properties.Cast<ProcessMetric>().ToList();
				num2 = 6;
				break;
			case 7:
				if (TjJgA2TNq6CCMJHpOsV(processMetricValuesMetadata.Properties) <= 0)
				{
					return;
				}
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				NLaHSfQsXbaHVoIHoZX(process, CheckMetrics(metrics, process.MetricValues, ScaleStatus.Critical));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				processMetricValuesMetadata = ((WorkflowInstanceContextService)cQ2OHmTa3T6tQqC4vdc()).GetProcessMetricValuesMetadata(process);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void CheckForCrititcalInstanceMetrics(IWorkflowInstance workflowInstance)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_00e6, IL_00f5, IL_0128, IL_0137, IL_01b5
		int num = 2;
		EntityMetadata instanceMetricValuesMetadata = default(EntityMetadata);
		List<ProcessInstanceMetric> list = default(List<ProcessInstanceMetric>);
		IWorkflowProcess process = default(IWorkflowProcess);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IWorkflowProcess workflowProcess;
				switch (num2)
				{
				case 3:
					if (TjJgA2TNq6CCMJHpOsV(instanceMetricValuesMetadata.Properties) != 0)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
						{
							num2 = 6;
						}
						continue;
					}
					return;
				case 4:
					workflowInstance.HasProblemMetric = CheckMetrics(list, mFCa2MQyDB1yQ65jKmd(workflowInstance), ScaleStatus.Critical);
					num2 = 13;
					continue;
				case 2:
					if (workflowInstance != null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 13:
					LYCTL8QmqlAZEmqlsOl(workflowInstance, CheckMetrics(list, mFCa2MQyDB1yQ65jKmd(workflowInstance), ScaleStatus.Normal));
					num2 = 10;
					continue;
				case 7:
					return;
				case 1:
					if (JU1WDkQ8PL8s4l3W2aX(((IWorkflowProcess)FF3wkBQlQFLTyVZniQL(workflowInstance)).Header) != null)
					{
						num2 = 11;
						continue;
					}
					goto case 12;
				case 9:
					return;
				case 5:
					if (instanceMetricValuesMetadata != null)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 12:
					workflowProcess = ((IWorkflowProcess)FF3wkBQlQFLTyVZniQL(workflowInstance)).Header.PublishedEmulation;
					goto IL_01ca;
				case 11:
					workflowProcess = ((IProcessHeader)Sup8HGQ0bIqi2MMlZXU(FF3wkBQlQFLTyVZniQL(workflowInstance))).Published;
					goto IL_01ca;
				case 8:
					return;
				case 6:
					list = (from ProcessInstanceMetric pim in instanceMetricValuesMetadata.Properties
						where pim.CheckForIndication
						select pim).ToList();
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					{
						SEiBeBQteEWtroQ3PHR(workflowInstance, list.Any() && AllMetricsIsGood(list, mFCa2MQyDB1yQ65jKmd(workflowInstance)));
						num2 = 9;
						continue;
					}
					IL_01ca:
					process = workflowProcess;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			instanceMetricValuesMetadata = ((WorkflowInstanceContextService)cQ2OHmTa3T6tQqC4vdc()).GetInstanceMetricValuesMetadata(process);
			num = 5;
		}
	}

	private bool CheckMetrics(IEnumerable<EntityPropertyMetadata> metrics, object metricValues, ScaleStatus scaleStatus)
	{
		Type type = metricValues.GetType();
		foreach (EntityPropertyMetadata metric in metrics)
		{
			IScaleUser scaleUser = metric as IScaleUser;
			IScaleParamsWithPlanValue scaleParamsWithPlanValue = metric as IScaleParamsWithPlanValue;
			if (scaleUser != null && scaleParamsWithPlanValue != null && scaleUser.CanUseScale())
			{
				PropertyInfo reflectionProperty = type.GetReflectionProperty(metric.Name);
				object metricValue = ((reflectionProperty != null) ? reflectionProperty.GetValue(metricValues, null) : null);
				if (GetScaleStatus(scaleUser, scaleParamsWithPlanValue, metricValue) == scaleStatus)
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool AllMetricsIsGood(IEnumerable<EntityPropertyMetadata> metrics, object metricValues)
	{
		Type type = metricValues.GetType();
		foreach (EntityPropertyMetadata metric in metrics)
		{
			IScaleUser scaleUser = metric as IScaleUser;
			IScaleParamsWithPlanValue scaleParamsWithPlanValue = metric as IScaleParamsWithPlanValue;
			if (scaleUser != null && scaleParamsWithPlanValue != null && scaleUser.CanUseScale())
			{
				PropertyInfo reflectionProperty = type.GetReflectionProperty(metric.Name);
				object metricValue = ((reflectionProperty != null) ? reflectionProperty.GetValue(metricValues, null) : null);
				if (GetScaleStatus(scaleUser, scaleParamsWithPlanValue, metricValue) != ScaleStatus.Good)
				{
					return false;
				}
			}
		}
		return true;
	}

	internal static IWorkflowInstance GetWorkflowInstance(object entity)
	{
		int num = 2;
		int num2 = num;
		PropertyInfo property = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 2:
				property = entity.GetType().GetProperty((string)HtlDc2QbEWPakip1Ddj(--1418337216 ^ 0x548A436A));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (!(property == null))
				{
					return VoXRdiQ5b0UGdoyMjsV(property, entity, null) as IWorkflowInstance;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static ScaleStatus GetScaleStatus(object scaleUser, object scaleParams, object metricValue)
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_0073, IL_0093, IL_0103, IL_0112
		int num = 1;
		int num2 = num;
		IIndicatorScale scale = default(IIndicatorScale);
		ScaleStatus result = default(ScaleStatus);
		while (true)
		{
			switch (num2)
			{
			case 9:
				if (scaleParams == null)
				{
					num2 = 4;
					break;
				}
				scale = ((IScaleUser)scaleUser).GetScale();
				num2 = 6;
				break;
			case 3:
				result = scale.GetStatus((IScaleParamsWithPlanValue)scaleParams, TimeSpanToDouble.Convert((TimeSpan)metricValue));
				num2 = 11;
				break;
			case 5:
				return ScaleStatus.Unavailable;
			case 7:
				result = ScaleStatus.Unavailable;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return ScaleStatus.Unavailable;
			case 11:
			case 12:
				return result;
			case 6:
				if (scale != null)
				{
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 5;
			case 2:
				if (!(metricValue is TimeSpan))
				{
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 3;
			case 1:
				if (scaleUser == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 9;
			case 8:
			case 10:
				result = scale.GetStatus((IScaleParamsWithPlanValue)scaleParams, sQgAZ4QgbZjcYDO0cjq(metricValue));
				num2 = 12;
				break;
			}
		}
	}

	internal static bool oQ1TElT2ngdFuKoUADf()
	{
		return EZXhNCT7gmdTaXycdsc == null;
	}

	internal static WorkflowMetricValueChangedListener IaeNrFTo1voxE8tq6Rg()
	{
		return EZXhNCT7gmdTaXycdsc;
	}

	internal static object gAThHMTFEUs9ytwUbkB(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static bool DSFhLETiV1KlOZiKpnk(object P_0, object P_1)
	{
		return ((EntityEventsListener)P_0).OnPreInsert((PreInsertEvent)P_1);
	}

	internal static object XGt38cTIN7H7GgUsRQh(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object cQ2OHmTa3T6tQqC4vdc()
	{
		return WorkflowInstanceContextService.Instance;
	}

	internal static Guid oIDJ69TrUUtmiQYGjc3(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static object B7UlCpTeTkrvTl6WjYO(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetProcessMetricValuesMetadata((IWorkflowProcess)P_1);
	}

	internal static int TjJgA2TNq6CCMJHpOsV(object P_0)
	{
		return ((List<PropertyMetadata>)P_0).Count;
	}

	internal static object VCtravTx8TJKIloXBdv(object P_0)
	{
		return GetWorkflowInstance(P_0);
	}

	internal static bool y9cOp9TSVlNZ8tkbaiZ(object P_0)
	{
		return ((ProcessMetric)P_0).Active;
	}

	internal static bool bgKoHpT1IVDng8kNhAM(object P_0)
	{
		return ((ProcessMetric)P_0).IsPersonal;
	}

	internal static bool zbkN9KThb61O3oVyxu8(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool tSjXENTESmenKwCWo5m(object P_0)
	{
		return ((ProcessMetric)P_0).UsePeriodicity;
	}

	internal static object oEDXFpTwfUPR3VRbdfC(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static Guid wKmajBT4qfuDbnZKOme(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object alENOXTzlN3kf0lnVQZ(object P_0, Guid P_1)
	{
		return ((Entity<long>)P_0).GetPropertyValue(P_1);
	}

	internal static object TGS10ZQKEmRiSVH5yjU()
	{
		return ProcessMetricValueManager.Instance;
	}

	internal static void V6jLBsQONXMOA5fDd0S(object P_0, object P_1, object P_2, object P_3)
	{
		((ProcessMetricValueManager)P_0).MetricSave((ProcessMetric)P_1, (IUser)P_2, P_3);
	}

	internal static bool OXmTh2QZZuR49OJ7cQb(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void rPlqotQvGrR3eomgXCl(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object BO5oxmQYjBqDr21dmW0()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static object JU1WDkQ8PL8s4l3W2aX(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static void NLaHSfQsXbaHVoIHoZX(object P_0, bool value)
	{
		((IWorkflowProcess)P_0).HasProblemMetric = value;
	}

	internal static object h43YaDQJiAXovw4HQPU(object P_0)
	{
		return ((IWorkflowProcess)P_0).MetricValues;
	}

	internal static object FF3wkBQlQFLTyVZniQL(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object Sup8HGQ0bIqi2MMlZXU(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object mFCa2MQyDB1yQ65jKmd(object P_0)
	{
		return ((IWorkflowInstance)P_0).MetricValues;
	}

	internal static void LYCTL8QmqlAZEmqlsOl(object P_0, bool value)
	{
		((IWorkflowInstance)P_0).HasWarningMetric = value;
	}

	internal static void SEiBeBQteEWtroQ3PHR(object P_0, bool value)
	{
		((IWorkflowInstance)P_0).AllMetricsIsGood = value;
	}

	internal static object HtlDc2QbEWPakip1Ddj(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VoXRdiQ5b0UGdoyMjsV(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static double sQgAZ4QgbZjcYDO0cjq(object P_0)
	{
		return Convert.ToDouble(P_0);
	}
}
