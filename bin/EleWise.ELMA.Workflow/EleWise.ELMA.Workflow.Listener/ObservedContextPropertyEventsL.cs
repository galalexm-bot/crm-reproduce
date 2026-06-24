using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Constants;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Collection;
using NHibernate.Engine;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal class ObservedContextPropertyEventsListener : EntityEventsListener
{
	internal static ObservedContextPropertyEventsListener ChaGsaRUAJNygAoFWCM;

	public IEnumerable<IWorkflowContextPropertyObserver> Observers { get; set; }

	public override void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
	{
		//Discarded unreachable code: IL_021a, IL_0250, IL_0260, IL_026a, IL_03e1, IL_0421, IL_0430, IL_0440, IL_044f, IL_045a, IL_04ba, IL_05e6, IL_05f5, IL_069b, IL_07b1, IL_07e9, IL_07f8, IL_0808, IL_083e, IL_084d, IL_085c, IL_087d
		int num = 2;
		IList<IEntity<long>> list2 = default(IList<IEntity<long>>);
		IList<IEntity<long>> list = default(IList<IEntity<long>>);
		BulkDeleteArg orAdd = default(BulkDeleteArg);
		long id = default(long);
		IWorkflowInstanceContext workflowInstanceContext = default(IWorkflowInstanceContext);
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		string text = default(string);
		IEnumerator<IEntity<long>> enumerator = default(IEnumerator<IEntity<long>>);
		Dictionary<string, object> dictionary = default(Dictionary<string, object>);
		IEntity<long> current2 = default(IEntity<long>);
		IEntity<long> current = default(IEntity<long>);
		DataRow dataRow = default(DataRow);
		DataTable orAdd2 = default(DataTable);
		EntityMetadata entityMetadata = default(EntityMetadata);
		EntitySettings entitySettings = default(EntitySettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object list3;
				switch (num2)
				{
				case 15:
					if (buuonWR1h7BXpZ4lb9s(list2) <= 0)
					{
						num2 = 21;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 13;
				case 8:
					return;
				case 13:
					if (list.Count != 0)
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 22;
				case 23:
					return;
				case 18:
					return;
				case 22:
					orAdd.Clauses.Add(new BulkDeleteArg.Clause
					{
						Values = new Dictionary<string, object>
						{
							{
								SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -29965762),
								id
							},
							{
								(string)sPBJDdRhNvFXV50KL2b(-1647793954 ^ -1647790010),
								vHdiUbREef2cIrdNx1c(workflowInstanceContext)
							},
							{
								SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB2EF5C),
								Y1t5SqRwFIRj3jmJLcC(_003C_003Ec__DisplayClass4_.propMd)
							}
						}
					});
					num2 = 21;
					continue;
				case 12:
					_003C_003Ec__DisplayClass4_.propMd = (PropertyMetadata)NKLNBnRi6i8UAupGvJm(workflowInstanceContext.CastAsRealType().GetType(), text, false);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
					{
						num2 = 17;
					}
					continue;
				case 9:
				case 19:
				case 25:
					enumerator = list2.Except(list).GetEnumerator();
					num2 = 29;
					continue;
				case 20:
					return;
				default:
					goto end_IL_0012;
				case 29:
					try
					{
						while (true)
						{
							int num5;
							if (!F18kGaR47fqw5wTRZID(enumerator))
							{
								num5 = 2;
								goto IL_026e;
							}
							goto IL_03a8;
							IL_026e:
							while (true)
							{
								switch (num5)
								{
								case 4:
									break;
								default:
									orAdd.Clauses.Add(new BulkDeleteArg.Clause
									{
										Values = dictionary
									});
									num5 = 4;
									continue;
								case 3:
									dictionary.Add(ObservedContextPropertyConsts.Fields.ObjectOI, current2.Id);
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
									{
										num5 = 0;
									}
									continue;
								case 5:
									dictionary = new Dictionary<string, object>
									{
										{
											(string)sPBJDdRhNvFXV50KL2b(-790221436 ^ -790205598),
											id
										},
										{
											SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4940763B ^ 0x494066A3),
											vHdiUbREef2cIrdNx1c(workflowInstanceContext)
										},
										{
											(string)sPBJDdRhNvFXV50KL2b(0x2269BD32 ^ 0x2269D8BC),
											_003C_003Ec__DisplayClass4_.propMd.Uid
										}
									};
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
									{
										num5 = 1;
									}
									continue;
								case 1:
									if (current2 != null)
									{
										num5 = 3;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
										{
											num5 = 3;
										}
										continue;
									}
									goto default;
								case 6:
									goto IL_03a8;
								case 2:
									goto end_IL_0294;
								}
								break;
							}
							continue;
							IL_03a8:
							current2 = enumerator.Current;
							num5 = 5;
							goto IL_026e;
							continue;
							end_IL_0294:
							break;
						}
					}
					finally
					{
						int num6;
						if (enumerator == null)
						{
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
							{
								num6 = 1;
							}
							goto IL_03e5;
						}
						goto IL_03fb;
						IL_03fb:
						HFsNiGRz89ZOSraYQ1X(enumerator);
						num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
						{
							num6 = 0;
						}
						goto IL_03e5;
						IL_03e5:
						switch (num6)
						{
						default:
							goto end_IL_03c0;
						case 2:
							break;
						case 1:
							goto end_IL_03c0;
						case 0:
							goto end_IL_03c0;
						}
						goto IL_03fb;
						end_IL_03c0:;
					}
					break;
				case 3:
					try
					{
						while (true)
						{
							IL_06a5:
							int num3;
							if (!F18kGaR47fqw5wTRZID(enumerator))
							{
								num3 = 13;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
								{
									num3 = 1;
								}
								goto IL_045e;
							}
							goto IL_04bf;
							IL_04bf:
							current = enumerator.Current;
							num3 = 3;
							goto IL_045e;
							IL_045e:
							while (true)
							{
								object obj;
								switch (num3)
								{
								case 13:
									return;
								case 1:
									obj = null;
									goto IL_0737;
								case 11:
									break;
								case 5:
									rjIk7k6Z5fHqXFKck2Q(dataRow, sPBJDdRhNvFXV50KL2b(-720457373 ^ -720448275), _003C_003Ec__DisplayClass4_.propMd.Uid);
									num3 = 17;
									continue;
								case 8:
								case 9:
									((DataRowCollection)rCVtqT6sunT1I5wTBMS(orAdd2)).Add(dataRow);
									num3 = 15;
									continue;
								case 6:
									rjIk7k6Z5fHqXFKck2Q(dataRow, sPBJDdRhNvFXV50KL2b(-2077784392 ^ -2077769634), id);
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
									{
										num3 = 0;
									}
									continue;
								case 3:
									if (current != null)
									{
										num3 = 7;
										continue;
									}
									goto case 1;
								case 16:
									if (current != null)
									{
										num3 = 10;
										continue;
									}
									goto case 14;
								case 2:
									dataRow[(string)sPBJDdRhNvFXV50KL2b(0x2269BD32 ^ 0x226902D2)] = aXQ02x6vxaa784gmpQj(_003C_003Ec__DisplayClass4_.propMd);
									num3 = 15;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
									{
										num3 = 18;
									}
									continue;
								default:
									dataRow = (DataRow)N1WIDO6Ot8NMGqMpUBI(orAdd2);
									num3 = 6;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
									{
										num3 = 6;
									}
									continue;
								case 12:
									rjIk7k6Z5fHqXFKck2Q(dataRow, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x42314992), ((IEntity<long>)PMVMZuRrxJ6oAK89TOi(workflowInstanceContext)).Id);
									num3 = 5;
									continue;
								case 10:
									rjIk7k6Z5fHqXFKck2Q(dataRow, ObservedContextPropertyConsts.Fields.ObjectOI, current.Id);
									num3 = 8;
									continue;
								case 18:
									rjIk7k6Z5fHqXFKck2Q(dataRow, sPBJDdRhNvFXV50KL2b(0x51EF0063 ^ 0x51EFBF8F), kcYEjq6YP10QJoZ6Zh4(_003C_003Ec__DisplayClass4_.propMd));
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
									{
										num3 = 4;
									}
									continue;
								case 15:
									goto IL_06a5;
								case 14:
									rjIk7k6Z5fHqXFKck2Q(dataRow, ObservedContextPropertyConsts.Fields.ObjectOI, DBNull.Value);
									num3 = 9;
									continue;
								case 4:
									rjIk7k6Z5fHqXFKck2Q(dataRow, sPBJDdRhNvFXV50KL2b(-2122743969 ^ -2122747961), vHdiUbREef2cIrdNx1c(workflowInstanceContext));
									num3 = 9;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
									{
										num3 = 12;
									}
									continue;
								case 7:
									obj = (EntityMetadata)jCKH546KTFkUQYKcXeX(current.CastAsRealType().GetType(), false, true);
									goto IL_0737;
								case 17:
									{
										dataRow[ObservedContextPropertyConsts.Fields.ObjectTU] = ((entityMetadata != null) ? qATOsp68JtshXZi3D3r(entityMetadata) : Guid.Empty);
										num3 = 16;
										continue;
									}
									IL_0737:
									entityMetadata = (EntityMetadata)obj;
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							}
							goto IL_04bf;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									enumerator.Dispose();
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
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
				case 1:
					workflowInstanceContext = (IWorkflowInstanceContext)IxDXDmR71J4IWOAwe7t(IsPh7yRGvBrZTd0gmNc(@event));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
					{
						num2 = 14;
					}
					continue;
				case 14:
					if (workflowInstanceContext != null)
					{
						num2 = 11;
						continue;
					}
					return;
				case 2:
					_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					if (entitySettings == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
						{
							num2 = 4;
						}
					}
					else if (TaXBLYRaqpUEbsRA3ie(entitySettings) != 0)
					{
						if (Observers.FirstOrDefault(_003C_003Ec__DisplayClass4_._003COnPreUpdateCollection_003Eb__0) == null)
						{
							return;
						}
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 18;
					}
					continue;
				case 24:
					return;
				case 11:
					if (((IPersistentCollection)yLHnULR2yy66PRFx4Ua(@event)).get_Role() != null)
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 4:
					return;
				case 26:
					enumerator = list.Except(list2).GetEnumerator();
					num2 = 3;
					continue;
				case 17:
					if (_003C_003Ec__DisplayClass4_.propMd != null)
					{
						entitySettings = Uw0DbmRIgsLXFdWuZrc(_003C_003Ec__DisplayClass4_.propMd) as EntitySettings;
						num2 = 7;
					}
					else
					{
						num2 = 23;
					}
					continue;
				case 6:
					return;
				case 5:
					text = (string)sI01tTRFG1hgEwdxQdM(RVBnslRodLADll9FqgU(((AbstractCollectionEvent)@event).get_Collection()), ((string)RVBnslRodLADll9FqgU(yLHnULR2yy66PRFx4Ua(@event))).LastIndexOf('.') + 1);
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
					{
						num2 = 1;
					}
					continue;
				case 16:
				{
					CollectionEntry collectionEntry = ((IPersistenceContext)BN1VypRxe4uYLx1ajSB(FDbhAeRN6yjDMRtcyh8(@event))).GetCollectionEntry((IPersistentCollection)yLHnULR2yy66PRFx4Ua(@event));
					list = (yLHnULR2yy66PRFx4Ua(@event) as IEnumerable).CastToListOrNull<IEntity<long>>() ?? new List<IEntity<long>>();
					list3 = (go9WnJRSMbfuCAequ1W(collectionEntry) as IEnumerable).CastToListOrNull<IEntity<long>>();
					if (list3 != null)
					{
						goto IL_09da;
					}
					num2 = 28;
					continue;
				}
				case 28:
					list3 = new List<IEntity<long>>();
					goto IL_09da;
				case 27:
					orAdd = ContextVars.GetOrAdd(ObjectStartableByRouteConstant.DeleteKey, () => new BulkDeleteArg
					{
						TableName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028861977 ^ -1028871169)
					});
					num2 = 15;
					continue;
				case 10:
				case 21:
					break;
					IL_09da:
					list2 = (IList<IEntity<long>>)list3;
					num2 = 27;
					continue;
				}
				orAdd2 = ContextVars.GetOrAdd(ObjectStartableByRouteConstant.InsertKey, delegate
				{
					DataTable dataTable = new DataTable((string)_003C_003Ec.jlYcWfZUUwfQDmQUuE08(-29981480 ^ -29957952));
					_003C_003Ec.aSJGROZUAlw5cuu7uQOQ(dataTable.Columns, _003C_003Ec.jlYcWfZUUwfQDmQUuE08(-2057730233 ^ -2057715295), _003C_003Ec.mjIcLmZUVAo4b9NOKTx9(typeof(long).TypeHandle));
					((DataColumnCollection)_003C_003Ec.Bc6iYGZUGWkJK1H2Oaas(dataTable)).Add((string)_003C_003Ec.jlYcWfZUUwfQDmQUuE08(0x75BAD659 ^ 0x75BA69B9), _003C_003Ec.mjIcLmZUVAo4b9NOKTx9(typeof(Guid).TypeHandle));
					_003C_003Ec.aSJGROZUAlw5cuu7uQOQ(_003C_003Ec.Bc6iYGZUGWkJK1H2Oaas(dataTable), _003C_003Ec.jlYcWfZUUwfQDmQUuE08(0x141C968 ^ 0x1417684), _003C_003Ec.mjIcLmZUVAo4b9NOKTx9(typeof(Guid).TypeHandle));
					_003C_003Ec.aSJGROZUAlw5cuu7uQOQ(_003C_003Ec.Bc6iYGZUGWkJK1H2Oaas(dataTable), _003C_003Ec.jlYcWfZUUwfQDmQUuE08(-105863102 ^ -105858854), _003C_003Ec.mjIcLmZUVAo4b9NOKTx9(typeof(long).TypeHandle));
					_003C_003Ec.aSJGROZUAlw5cuu7uQOQ(dataTable.Columns, _003C_003Ec.jlYcWfZUUwfQDmQUuE08(0x141C968 ^ 0x14191C2), _003C_003Ec.mjIcLmZUVAo4b9NOKTx9(typeof(long).TypeHandle));
					_003C_003Ec.aSJGROZUAlw5cuu7uQOQ(_003C_003Ec.Bc6iYGZUGWkJK1H2Oaas(dataTable), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667472817), _003C_003Ec.mjIcLmZUVAo4b9NOKTx9(typeof(Guid).TypeHandle));
					_003C_003Ec.aSJGROZUAlw5cuu7uQOQ(_003C_003Ec.Bc6iYGZUGWkJK1H2Oaas(dataTable), ObservedContextPropertyConsts.Fields.ObjectOI, _003C_003Ec.mjIcLmZUVAo4b9NOKTx9(typeof(long).TypeHandle));
					_003C_003Ec.aSJGROZUAlw5cuu7uQOQ(_003C_003Ec.Bc6iYGZUGWkJK1H2Oaas(dataTable), ObservedContextPropertyConsts.Fields.ObjectTU, typeof(Guid));
					return dataTable;
				});
				num2 = 26;
				continue;
				end_IL_0012:
				break;
			}
			id = ((IWorkflowProcess)aIj3kRRe8kYmn0jnUmo(PMVMZuRrxJ6oAK89TOi(workflowInstanceContext))).Header.Id;
			num = 16;
		}
	}

	public ObservedContextPropertyEventsListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cNXtce6Jwwkx3kkaMAG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object IsPh7yRGvBrZTd0gmNc(object P_0)
	{
		return ((AbstractCollectionEvent)P_0).get_AffectedOwnerOrNull();
	}

	internal static object IxDXDmR71J4IWOAwe7t(object P_0)
	{
		return ObservedContextPropertyListener.GetContext(P_0);
	}

	internal static object yLHnULR2yy66PRFx4Ua(object P_0)
	{
		return ((AbstractCollectionEvent)P_0).get_Collection();
	}

	internal static object RVBnslRodLADll9FqgU(object P_0)
	{
		return ((IPersistentCollection)P_0).get_Role();
	}

	internal static object sI01tTRFG1hgEwdxQdM(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object NKLNBnRi6i8UAupGvJm(Type P_0, object P_1, bool P_2)
	{
		return InterfaceActivator.LoadPropertyMetadata(P_0, (string)P_1, P_2);
	}

	internal static object Uw0DbmRIgsLXFdWuZrc(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static RelationType TaXBLYRaqpUEbsRA3ie(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static object PMVMZuRrxJ6oAK89TOi(object P_0)
	{
		return ((IWorkflowInstanceContext)P_0).WorkflowInstance;
	}

	internal static object aIj3kRRe8kYmn0jnUmo(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object FDbhAeRN6yjDMRtcyh8(object P_0)
	{
		return ((AbstractEvent)P_0).get_Session();
	}

	internal static object BN1VypRxe4uYLx1ajSB(object P_0)
	{
		return ((ISessionImplementor)P_0).get_PersistenceContext();
	}

	internal static object go9WnJRSMbfuCAequ1W(object P_0)
	{
		return ((CollectionEntry)P_0).get_Snapshot();
	}

	internal static int buuonWR1h7BXpZ4lb9s(object P_0)
	{
		return ((ICollection<IEntity<long>>)P_0).Count;
	}

	internal static object sPBJDdRhNvFXV50KL2b(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object vHdiUbREef2cIrdNx1c(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static Guid Y1t5SqRwFIRj3jmJLcC(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool F18kGaR47fqw5wTRZID(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void HFsNiGRz89ZOSraYQ1X(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object jCKH546KTFkUQYKcXeX(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object N1WIDO6Ot8NMGqMpUBI(object P_0)
	{
		return ((DataTable)P_0).NewRow();
	}

	internal static void rjIk7k6Z5fHqXFKck2Q(object P_0, object P_1, object P_2)
	{
		((DataRow)P_0)[(string)P_1] = P_2;
	}

	internal static Guid aXQ02x6vxaa784gmpQj(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid kcYEjq6YP10QJoZ6Zh4(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static Guid qATOsp68JtshXZi3D3r(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static object rCVtqT6sunT1I5wTBMS(object P_0)
	{
		return ((DataTable)P_0).Rows;
	}

	internal static bool jh3WmDRVfgr6Bx9XqaF()
	{
		return ChaGsaRUAJNygAoFWCM == null;
	}

	internal static ObservedContextPropertyEventsListener cY8t50RAPBy2htXNYp6()
	{
		return ChaGsaRUAJNygAoFWCM;
	}

	internal static void cNXtce6Jwwkx3kkaMAG()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
