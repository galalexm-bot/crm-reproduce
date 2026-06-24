using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Service(EnableInterceptors = true)]
public class WorkflowQueueDbService
{
	public static class DbProcessingItem
	{
		public static class Fields
		{
			public const string itemId = "ItemId";

			public const string instanceId = "InstanceId";

			public const string executionUid = "ExecutionUid";

			public const string executionStart = "ExecutionStart";

			public const string serverConnectionUid = "ServerConnectionUid";
		}

		public const string tableName = "WorkflowQueueProcessingItem";
	}

	internal static class DbQueueItem
	{
		internal static class Fields
		{
			internal const string itemUid = "Uid";

			internal const string id = "Id";

			internal const string instance = "Instance";

			internal const string elementUid = "ElementUid";

			internal const string serverConnectionUid = "ServerConnectionUid";
		}

		internal const string tableName = "WorkflowQueueItem";
	}

	private readonly Queue<Guid> processingItemsToRemove;

	private IRuntimeApplication runtimeApplication;

	private static ITransformationProvider transformationProvider;

	private ICompositeClusterInformationService compositeClusterInformationService;

	internal static WorkflowQueueDbService CojHPLURFSVM0TRM4Pp;

	private IRuntimeApplication RuntimeApplication
	{
		get
		{
			int num = 2;
			int num2 = num;
			IRuntimeApplication runtimeApplication = default(IRuntimeApplication);
			IRuntimeApplication obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					runtimeApplication = (this.runtimeApplication = Locator.GetServiceNotNull<IRuntimeApplication>());
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = this.runtimeApplication;
					if (obj == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				default:
					obj = runtimeApplication;
					break;
				}
				break;
			}
			return obj;
		}
	}

	private static ITransformationProvider TransformationProvider
	{
		get
		{
			int num = 1;
			int num2 = num;
			ITransformationProvider obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = transformationProvider;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	private ICompositeClusterInformationService CompositeClusterInformationService
	{
		get
		{
			//Discarded unreachable code: IL_0076, IL_0085
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
					case 3:
						return compositeClusterInformationService;
					case 2:
						if (compositeClusterInformationService != null)
						{
							num2 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					}
					break;
				}
				compositeClusterInformationService = Locator.GetServiceNotNull<ICompositeClusterInformationService>();
				num = 3;
			}
		}
	}

	public virtual bool ReleaseWorkflowQueueItem(WorkflowQueueItemExecutionInfo itemInfo, DateTime? nextExecuteDate = null)
	{
		Contract.ArgumentNotNull(itemInfo, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-768800937 ^ -768864379));
		try
		{
			ITransformationProvider obj = TransformationProvider;
			string table = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A69B2FB);
			string[] array = new string[2];
			ParameterExpression parameterExpression = Expression.Parameter(typeof(IWorkflowQueueItem), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647794332));
			array[0] = InterfaceActivator.PropertyName(Expression.Lambda<Func<IWorkflowQueueItem, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
			parameterExpression = Expression.Parameter(typeof(IWorkflowQueueItem), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x687E70));
			array[1] = InterfaceActivator.PropertyName(Expression.Lambda<Func<IWorkflowQueueItem, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
			obj.Update(table, array, new object[2]
			{
				null,
				nextExecuteDate ?? DateTime.Now.AddHours(-1.0)
			}, string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495233518), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25692820)), TransformationProvider.ParameterSeparator), new Dictionary<string, object> { 
			{
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747EF2E4),
				itemInfo.ItemId
			} });
		}
		catch (Exception exception)
		{
			Logger.Log.Warn(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA406D8), itemInfo.ItemId), exception);
			return false;
		}
		return true;
	}

	public virtual bool TryInsertProcessingItem(WorkflowQueueItemExecutionInfo itemInfo)
	{
		//Discarded unreachable code: IL_011d, IL_0150, IL_01c8, IL_01d7
		switch (1)
		{
		case 1:
			try
			{
				rUAo1qUka0Ie1EpYqbI(FDuWa6U3oonKmGcIqRV(), nJEFV9UTerrAjTJ3X4A(-763667953 ^ -763635181), new string[5]
				{
					(string)nJEFV9UTerrAjTJ3X4A(0x70EBB9F3 ^ 0x70EAB08D),
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x548A06AA),
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x1842E991),
					(string)nJEFV9UTerrAjTJ3X4A(-1028861977 ^ -1028798899),
					(string)nJEFV9UTerrAjTJ3X4A(-1050383744 ^ -1050350890)
				}, new object[5]
				{
					ymDA6FUQyrlLbLpwT38(itemInfo),
					yvmufYUpGIiJUfRW6xR(itemInfo),
					d6mMweUCj417CYBuDIp(itemInfo),
					itemInfo.ExecutionStart,
					yWMO1lUMIXZYoKUxSYh(RuntimeApplication)
				});
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
			catch (Exception ex)
			{
				int num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
				{
					num2 = 2;
				}
				bool result = default(bool);
				while (true)
				{
					switch (num2)
					{
					case 2:
						tpWTY0UVrbjur3hgrPk(FFgtD0UUuU75Qx8fbSb(), nJEFV9UTerrAjTJ3X4A(-29981480 ^ -29913838), ex);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
						{
							num2 = 0;
						}
						break;
					default:
						result = false;
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						return result;
					}
				}
			}
			break;
		}
		return true;
	}

	public virtual bool TryDeleteProcessingItem(Guid executionUid)
	{
		//Discarded unreachable code: IL_0053, IL_0140, IL_01cc, IL_01db
		switch (1)
		{
		case 1:
			try
			{
				int num;
				if (J3Es9xUGfJN0tkKPAhC(p0BX9FUA87KlhQMA77Y(TransformationProvider)) == ConnectionState.Closed)
				{
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num = 1;
					}
					goto IL_0057;
				}
				goto IL_0086;
				IL_0086:
				((ITransformationProvider)FDuWa6U3oonKmGcIqRV()).ExecuteNonQuery(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1600060848 ^ -1600124840), MCtvhgUoM5scMCk5ZY4(UdXNesU2CKZbJPyTDfn(FDuWa6U3oonKmGcIqRV()), nJEFV9UTerrAjTJ3X4A(-135674354 ^ -135707118)), MCtvhgUoM5scMCk5ZY4(UdXNesU2CKZbJPyTDfn(FDuWa6U3oonKmGcIqRV()), nJEFV9UTerrAjTJ3X4A(-2111219045 ^ -2111286507)), yCFyLZUFS1HKstpd3rM(TransformationProvider)), new Dictionary<string, object> { 
				{
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4940763B ^ 0x49417C53),
					executionUid
				} });
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
				{
					num = 0;
				}
				goto IL_0057;
				IL_0057:
				while (true)
				{
					switch (num)
					{
					default:
						goto end_IL_0057;
					case 1:
						goto IL_006d;
					case 2:
						break;
					case 0:
						goto end_IL_0057;
					}
					goto IL_0086;
					IL_006d:
					transformationProvider = (ITransformationProvider)foX8gOU7vsVhdcDMFQc(FDuWa6U3oonKmGcIqRV());
					num = 2;
					continue;
					end_IL_0057:
					break;
				}
			}
			catch (Exception exception)
			{
				int num2 = 3;
				bool result = default(bool);
				while (true)
				{
					switch (num2)
					{
					case 1:
						result = false;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						Logger.Log.Error(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130035112), exception);
						num2 = 2;
						break;
					case 2:
						processingItemsToRemove.LockEnqueue(executionUid);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
						{
							num2 = 1;
						}
						break;
					default:
						return result;
					case 0:
						return result;
					}
				}
			}
			break;
		}
		return true;
	}

	public virtual IEnumerable<WorkflowQueueItemExecutionInfo> GetProcessingItems()
	{
		string sql = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683781780), TransformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E9F145), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D7C3EF)));
		List<WorkflowQueueItemExecutionInfo> list = new List<WorkflowQueueItemExecutionInfo>();
		using IDataReader dataReader = TransformationProvider.ExecuteQuery(sql);
		while (dataReader.Read())
		{
			list.Add(new WorkflowQueueItemExecutionInfo
			{
				ItemId = Convert.ToInt64(dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EB59AA)]),
				InstanceId = Convert.ToInt64(dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980570802)]),
				ExecutionUid = TransformationProvider.Dialect.GetGuid(dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD305CC2 ^ 0xD31554C)]),
				ExecutionStart = ((!(dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F5243F6)] is DBNull)) ? ((DateTime?)dataReader[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708060182)]) : null)
			});
		}
		return list;
	}

	public virtual bool TryDeleteWorkflowQueueItem(long queueItemId)
	{
		//Discarded unreachable code: IL_0048, IL_0157, IL_01ca, IL_01d9
		switch (1)
		{
		case 1:
			try
			{
				int num;
				if (J3Es9xUGfJN0tkKPAhC(p0BX9FUA87KlhQMA77Y(FDuWa6U3oonKmGcIqRV())) == ConnectionState.Closed)
				{
					num = 2;
					goto IL_004c;
				}
				goto IL_008b;
				IL_004c:
				while (true)
				{
					switch (num)
					{
					case 2:
						transformationProvider = (ITransformationProvider)foX8gOU7vsVhdcDMFQc(TransformationProvider);
						num = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
						{
							num = 0;
						}
						continue;
					case 1:
						goto end_IL_004c;
					}
					goto IL_008b;
					continue;
					end_IL_004c:
					break;
				}
				goto end_IL_002a;
				IL_008b:
				TransformationProvider.ExecuteNonQuery((string)rM0mG2Uik0VDr9vLKbW(nJEFV9UTerrAjTJ3X4A(-1303601216 ^ -1303538488), MCtvhgUoM5scMCk5ZY4(TransformationProvider.Dialect, nJEFV9UTerrAjTJ3X4A(0x1AF6F1F2 ^ 0x1AF686C4)), MCtvhgUoM5scMCk5ZY4(TransformationProvider.Dialect, nJEFV9UTerrAjTJ3X4A(0x157D5AF4 ^ 0x157D1C72)), ((ITransformationProvider)FDuWa6U3oonKmGcIqRV()).ParameterSeparator), new Dictionary<string, object> { 
				{
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F73F1C),
					queueItemId
				} });
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
				{
					num = 1;
				}
				goto IL_004c;
				end_IL_002a:;
			}
			catch (Exception ex)
			{
				int num2 = 2;
				bool result = default(bool);
				while (true)
				{
					switch (num2)
					{
					default:
						return result;
					case 0:
						return result;
					case 2:
						JVl2nQUIBo4RvE7tQXo(FFgtD0UUuU75Qx8fbSb(), nJEFV9UTerrAjTJ3X4A(-1539486135 ^ -1539553985), ex);
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						result = false;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
			break;
		}
		return true;
	}

	internal void ExecutePeriodicalWorks()
	{
		//Discarded unreachable code: IL_0047, IL_0063, IL_0072, IL_007d, IL_012c, IL_013b, IL_018a, IL_0199, IL_02d0, IL_0310, IL_031f, IL_032b, IL_033a, IL_0366, IL_03bd, IL_03cc
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				CallContextSessionOwner callContextSessionOwner = (CallContextSessionOwner)marMLAUaPqo5qVbEoJY();
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					break;
				default:
					try
					{
						Guid[] array = default(Guid[]);
						_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
						Dictionary<string, object> dictionary = default(Dictionary<string, object>);
						while (true)
						{
							int num2;
							if (!processingItemsToRemove.LockTryDequeue(out var result))
							{
								num2 = 11;
								goto IL_0081;
							}
							goto IL_016a;
							IL_0146:
							eErO78Ur7MQU1lKgmYU(this, result);
							num2 = 2;
							goto IL_0081;
							IL_016a:
							if (!(result != Guid.Empty))
							{
								num2 = 8;
								goto IL_0081;
							}
							goto IL_0146;
							IL_0081:
							while (true)
							{
								switch (num2)
								{
								case 5:
									return;
								case 9:
									return;
								case 2:
									break;
								case 1:
									if (array.Length == 0)
									{
										num2 = 9;
										continue;
									}
									goto case 4;
								case 7:
									_003C_003Ec__DisplayClass10_.n = 0;
									num2 = 3;
									continue;
								case 8:
								case 11:
									array = CompositeClusterInformationService.GetActiveConnectionUids().ToArray();
									num2 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
									{
										num2 = 1;
									}
									continue;
								case 10:
									goto IL_0146;
								case 4:
									_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
									num2 = 7;
									continue;
								default:
									goto IL_016a;
								case 3:
									dictionary = ((IEnumerable<Guid>)array).ToDictionary((Func<Guid, string>)_003C_003Ec__DisplayClass10_._003CExecutePeriodicalWorks_003Eb__0, (Func<Guid, object>)((Guid v) => v));
									num2 = 6;
									continue;
								case 6:
									((ITransformationProvider)FDuWa6U3oonKmGcIqRV()).ExecuteNonQuery((string)rM0mG2Uik0VDr9vLKbW(nJEFV9UTerrAjTJ3X4A(-10408775 ^ -10475757), ((Dialect)UdXNesU2CKZbJPyTDfn(FDuWa6U3oonKmGcIqRV())).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197745956)), ((ITransformationProvider)FDuWa6U3oonKmGcIqRV()).Dialect.QuoteIfNeeded((string)nJEFV9UTerrAjTJ3X4A(-1647793954 ^ -1647826808)), string.Join((string)nJEFV9UTerrAjTJ3X4A(-961162596 ^ -961197922), dictionary.Keys.Select((string k) => (string)_003C_003Ec.NhwqZ3Z247EY5s1ymho2(_003C_003Ec.dA5bkcZ2wd2nDGkBVUYy(_003C_003Ec.bQOKEOZ2Esur52hIClYS()), k)))), dictionary);
									num2 = 5;
									continue;
								}
								break;
							}
						}
					}
					finally
					{
						int num3;
						if (callContextSessionOwner == null)
						{
							num3 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
							{
								num3 = 2;
							}
							goto IL_02d4;
						}
						goto IL_02ea;
						IL_02ea:
						nH9FEmUedFV00mIVgOQ(callContextSessionOwner);
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
						{
							num3 = 0;
						}
						goto IL_02d4;
						IL_02d4:
						switch (num3)
						{
						default:
							goto end_IL_02af;
						case 1:
							break;
						case 2:
							goto end_IL_02af;
						case 0:
							goto end_IL_02af;
						}
						goto IL_02ea;
						end_IL_02af:;
					}
				}
				break;
			}
			catch (Exception exception)
			{
				int num4 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						return;
					}
					((ILogger)FFgtD0UUuU75Qx8fbSb()).Warn(nJEFV9UTerrAjTJ3X4A(0x1AF6F1F2 ^ 0x1AF7FA0C), exception);
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
					{
						num4 = 1;
					}
				}
			}
		}
	}

	public WorkflowQueueDbService()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		RIcEWjUNeGb9FBdQxRy();
		processingItemsToRemove = new Queue<Guid>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object FDuWa6U3oonKmGcIqRV()
	{
		return TransformationProvider;
	}

	internal static object nJEFV9UTerrAjTJ3X4A(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static long ymDA6FUQyrlLbLpwT38(object P_0)
	{
		return ((WorkflowQueueItemExecutionInfo)P_0).ItemId;
	}

	internal static long yvmufYUpGIiJUfRW6xR(object P_0)
	{
		return ((WorkflowQueueItemExecutionInfo)P_0).InstanceId;
	}

	internal static Guid d6mMweUCj417CYBuDIp(object P_0)
	{
		return ((WorkflowQueueItemExecutionInfo)P_0).ExecutionUid;
	}

	internal static Guid yWMO1lUMIXZYoKUxSYh(object P_0)
	{
		return ((IRuntimeApplication)P_0).ConnectionUid;
	}

	internal static int rUAo1qUka0Ie1EpYqbI(object P_0, object P_1, object P_2, object P_3)
	{
		return ((ITransformationProvider)P_0).Insert((string)P_1, (string[])P_2, (object[])P_3);
	}

	internal static object FFgtD0UUuU75Qx8fbSb()
	{
		return Logger.Log;
	}

	internal static void tpWTY0UVrbjur3hgrPk(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static bool qpcGxeU6Gb6u0Mm89q3()
	{
		return CojHPLURFSVM0TRM4Pp == null;
	}

	internal static WorkflowQueueDbService kZT5dwUqjxnsm0iqNYF()
	{
		return CojHPLURFSVM0TRM4Pp;
	}

	internal static object p0BX9FUA87KlhQMA77Y(object P_0)
	{
		return ((ITransformationProvider)P_0).Connection;
	}

	internal static ConnectionState J3Es9xUGfJN0tkKPAhC(object P_0)
	{
		return ((IDbConnection)P_0).State;
	}

	internal static object foX8gOU7vsVhdcDMFQc(object P_0)
	{
		return ((ITransformationProvider)P_0).CreateWithNewConnection();
	}

	internal static object UdXNesU2CKZbJPyTDfn(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object MCtvhgUoM5scMCk5ZY4(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object yCFyLZUFS1HKstpd3rM(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object rM0mG2Uik0VDr9vLKbW(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void JVl2nQUIBo4RvE7tQXo(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object marMLAUaPqo5qVbEoJY()
	{
		return CallContextSessionOwner.Create();
	}

	internal static bool eErO78Ur7MQU1lKgmYU(object P_0, Guid executionUid)
	{
		return ((WorkflowQueueDbService)P_0).TryDeleteProcessingItem(executionUid);
	}

	internal static void nH9FEmUedFV00mIVgOQ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void RIcEWjUNeGb9FBdQxRy()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
