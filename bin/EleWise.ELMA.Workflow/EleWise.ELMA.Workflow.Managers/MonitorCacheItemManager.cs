using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class MonitorCacheItemManager : EntityManager<IMonitorCacheItem, long>
{
	private static MonitorCacheItemManager OkIg5PBWuF2traXBh1T;

	public ILockManager LockManager
	{
		[CompilerGenerated]
		get
		{
			return _003CLockManager_003Ek__BackingField;
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
					_003CLockManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public new static MonitorCacheItemManager Instance => Locator.GetServiceNotNull<MonitorCacheItemManager>();

	[Transaction]
	public virtual void ResolveMonitorCacheUpdate()
	{
		//Discarded unreachable code: IL_00af, IL_00f2, IL_0101, IL_010c, IL_0223, IL_0232, IL_0242, IL_02c0, IL_02f8, IL_03aa, IL_03ea, IL_03f9, IL_0405, IL_0414
		int num = 2;
		int num2 = num;
		IDisposable disposable = default(IDisposable);
		List<IMonitorUpdateQueueAction> source = default(List<IMonitorUpdateQueueAction>);
		IEnumerator<IGrouping<MonitorCacheItemGroup, IMonitorUpdateActionQueueItem>> enumerator = default(IEnumerator<IGrouping<MonitorCacheItemGroup, IMonitorUpdateActionQueueItem>>);
		IGrouping<MonitorCacheItemGroup, IMonitorUpdateActionQueueItem> current = default(IGrouping<MonitorCacheItemGroup, IMonitorUpdateActionQueueItem>);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		IMonitorUpdateQueueAction monitorUpdateQueueAction = default(IMonitorUpdateQueueAction);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				disposable = (IDisposable)g6FxWFBqFQ0kMJnMtlN(LockManager, oOcERlB61Gs5dJZ4KIW(-1600060848 ^ -1600041018));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				try
				{
					List<IMonitorUpdateActionQueueItem> list = ((ICriteria)IoYi29BpGtBdjBcr2ek(((ICriteria)rbuPrUBT4cGLuos5ID9(Q91o1VB3gRkhPi8E2hF(this), InterfaceActivator.TypeOf<IMonitorUpdateActionQueueItem>())).AddOrder((Order)CGMZBWBQqkwWO9QkK9N(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1361019545))), 10)).List<IMonitorUpdateActionQueueItem>().ToList();
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						case 2:
							source = ((ComponentManager)qJd17jBCloRHxW3OnMq()).GetExtensionPoints<IMonitorUpdateQueueAction>().ToList();
							num3 = 4;
							continue;
						default:
							try
							{
								while (true)
								{
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 9;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
										{
											num4 = 2;
										}
										goto IL_0110;
									}
									goto IL_01fb;
									IL_01fb:
									current = enumerator.Current;
									num4 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
									{
										num4 = 7;
									}
									goto IL_0110;
									IL_0110:
									while (true)
									{
										switch (num4)
										{
										case 4:
											_003C_003Ec__DisplayClass6_.item = current.LastOrDefault();
											num4 = 2;
											continue;
										case 2:
											if (_003C_003Ec__DisplayClass6_.item == null)
											{
												num4 = 3;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
												{
													num4 = 2;
												}
												continue;
											}
											goto case 5;
										case 5:
											monitorUpdateQueueAction = source.FirstOrDefault(_003C_003Ec__DisplayClass6_._003CResolveMonitorCacheUpdate_003Eb__2);
											num4 = 10;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
											{
												num4 = 5;
											}
											continue;
										case 7:
											_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
											num4 = 2;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
											{
												num4 = 4;
											}
											continue;
										case 1:
											goto IL_01fb;
										case 10:
											if (monitorUpdateQueueAction == null)
											{
												num4 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
												{
													num4 = 0;
												}
												continue;
											}
											goto case 8;
										case 8:
											monitorUpdateQueueAction.DoAction(_003C_003Ec__DisplayClass6_.item.ProcessHeader, _003C_003Ec__DisplayClass6_.item.User);
											num4 = 6;
											continue;
										case 9:
											goto end_IL_015e;
										}
										break;
									}
									continue;
									end_IL_015e:
									break;
								}
							}
							finally
							{
								if (enumerator != null)
								{
									int num5 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
									{
										num5 = 1;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											QN233tBMFCWWmq58knf(enumerator);
											num5 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
											{
												num5 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
							break;
						case 4:
							enumerator = list.GroupBy(delegate(IMonitorUpdateActionQueueItem i)
							{
								MonitorCacheItemGroup monitorCacheItemGroup = new MonitorCacheItemGroup();
								_003C_003Ec.p9lhS0Z6g1Oke39j31AG(monitorCacheItemGroup, i.ActionTypeUid);
								_003C_003Ec.GNoXKwZ6cYNoatG8Hdx6(monitorCacheItemGroup, _003C_003Ec.YRRFI9Z6BmIdCDjmcOBu(i));
								monitorCacheItemGroup.User = (IUser)_003C_003Ec.MCFLDGZ6PNyIHLD2gyiI(i);
								return monitorCacheItemGroup;
							}).GetEnumerator();
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							break;
						}
						list.ForEach(delegate(IMonitorUpdateActionQueueItem i)
						{
							_003C_003Ec.brCwsBZ6XmQ8PYisMWnv(i);
						});
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					int num6;
					if (disposable == null)
					{
						num6 = 2;
						goto IL_03ae;
					}
					goto IL_03c4;
					IL_03ae:
					switch (num6)
					{
					case 2:
						goto end_IL_0399;
					case 1:
						goto end_IL_0399;
					}
					goto IL_03c4;
					IL_03c4:
					QN233tBMFCWWmq58knf(disposable);
					num6 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num6 = 1;
					}
					goto IL_03ae;
					end_IL_0399:;
				}
			}
		}
	}

	[Transaction]
	public virtual void RecreateCache()
	{
		//Discarded unreachable code: IL_0047, IL_0056, IL_0061, IL_01db, IL_01ee, IL_01fd
		int num = 3;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		List<MonitorCacheProcessInfo>.Enumerator enumerator = default(List<MonitorCacheProcessInfo>.Enumerator);
		IProcessHeader processHeader = default(IProcessHeader);
		MonitorCacheProcessInfo current = default(MonitorCacheProcessInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 2;
				break;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							goto IL_0065;
						}
						goto IL_018c;
						IL_0065:
						while (true)
						{
							switch (num3)
							{
							default:
							{
								InstanceOf<IMonitorCacheItem> instanceOf = new InstanceOf<IMonitorCacheItem>();
								instanceOf.New.ProcessHeader = processHeader;
								instanceOf.New.CompletedInstanceCount = WpWGPjBimXFZOSAe6R4(current);
								eHAus9Baw8RbyAavrDy(instanceOf.New, Ouk7f1BIEgX6fm0NIN2(current));
								instanceOf.New.TerminatedInstanceCount = keAA3HBrFBlo8evmlAB(current);
								QxTffxBNvctsOigoG64(instanceOf.New, xeTA2BBekT1UFL8iOeX(current));
								hQj9shBS1JbL65hKxwt(instanceOf.New, sLJZIiBxQy6DdIbMvPw(current));
								rZANtOBhgEgyjLavx4N(instanceOf.New, g5D4uwB1uVAyE94qFhT(current));
								YZwQktBwGRAgJ2ajAlj(instanceOf.New, KjQbe3BEoqomhIufGNy(current));
								heviAZBzNYdeiR7coQr(instanceOf.New, kFHVZnB4t8sv460Ivtq(current));
								wlX4n6cKSSUHkDuiOE9(instanceOf.New);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
								{
									num3 = 1;
								}
								continue;
							}
							case 1:
								break;
							case 2:
								processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)iTAPS8Bo6Ru8yQ4Znmf()).Load(tXJQN5BFRGQM1ypdBx9(current));
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								goto IL_018c;
							case 4:
								return;
							}
							break;
						}
						continue;
						IL_018c:
						current = enumerator.Current;
						num3 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
						{
							num3 = 2;
						}
						goto IL_0065;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 2:
				serviceNotNull.ExecuteNonQuery(string.Format((string)oOcERlB61Gs5dJZ4KIW(0x651FE29D ^ 0x651FAF51), roNTIeBkOdkNixcTNc1(serviceNotNull.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-768800937 ^ -768783687))));
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
				{
					num2 = 4;
				}
				break;
			case 0:
				return;
			case 4:
				enumerator = ((IQuery)yvd4ACB2cQ4OAtp7x3H(f1gyoZB7Fp9EsM8lp4j(vnFLjHBVW8kalgp8bKq(((IQuery)vnFLjHBVW8kalgp8bKq(uBjsYJBUm7XpZ9qKs8p(base.Session, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-763667953 ^ -763685859)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895835107), new int[1] { 1 })).SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360647193), (IEnumerable)new int[1] { 2 }).SetParameterList((string)oOcERlB61Gs5dJZ4KIW(-1716458555 ^ -1716476485), (IEnumerable)new int[2] { 3, 4 }), oOcERlB61Gs5dJZ4KIW(0x614CF569 ^ 0x614CBBCD), ((IEnumerable<TaskBaseStatus>)yA0lUUBATvn1KMhYnSH()).Select((TaskBaseStatus s) => _003C_003Ec.fvwOrCZ6dpyoe3XrDjhU(s)).ToArray()), new AliasToBeanResultTransformer(E981FmBGjI8ZfwMStRV(typeof(MonitorCacheProcessInfo).TypeHandle))), false)).List<MonitorCacheProcessInfo>().ToList().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public CountProcessInfo GetCompleteInstanceCount(long processHeaderId, long? userId)
	{
		IQuery val = base.Session.GetNamedQuery((!userId.HasValue) ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057713571) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC64732)).SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x628128E2), 2).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25690982), processHeaderId)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(CountProcessInfo)));
		if (userId.HasValue)
		{
			val.SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56A753C9 ^ 0x56A71C5B), userId.Value);
		}
		CountProcessInfo countProcessInfo = val.CleanUpCache(cleanUpCache: false).List<CountProcessInfo>().FirstOrDefault();
		if (countProcessInfo == null)
		{
			return new CountProcessInfo();
		}
		return countProcessInfo;
	}

	public List<CountProcessInfo> GetCompleteInstanceCountByUsers(long processHeaderId, bool isEmulation)
	{
		return base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452109579)).SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25690954), 2).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x11349DB0), processHeaderId)
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712512845), isEmulation ? 1 : 0)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(CountProcessInfo)))
			.CleanUpCache(cleanUpCache: false)
			.List<CountProcessInfo>()
			.ToList();
	}

	public CountProcessInfo GetCurrentInstanceCount(long processHeaderId, long? userId)
	{
		IQuery val = base.Session.GetNamedQuery((!userId.HasValue) ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56A753C9 ^ 0x56A71CD3) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F67A8C)).SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x192795CF), 1).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EBF683), processHeaderId)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(CountProcessInfo)));
		if (userId.HasValue)
		{
			val.SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C667233), userId.Value);
		}
		CountProcessInfo countProcessInfo = val.CleanUpCache(cleanUpCache: false).List<CountProcessInfo>().FirstOrDefault();
		if (countProcessInfo == null)
		{
			return new CountProcessInfo();
		}
		return countProcessInfo;
	}

	public List<CountProcessInfo> GetCurrentInstanceCountByUsers(long processHeaderId, bool isEmulation)
	{
		return base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498825621)).SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386465056), 1).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x738AF51E), processHeaderId)
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -29963484), isEmulation ? 1 : 0)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(CountProcessInfo)))
			.CleanUpCache(cleanUpCache: false)
			.List<CountProcessInfo>()
			.ToList();
	}

	public CountProcessInfo GetTerminateInstanceCount(long processHeaderId, long? userId)
	{
		IQuery val = base.Session.GetNamedQuery((!userId.HasValue) ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657594807) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -540011259)).SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077767196), (IEnumerable)new int[2] { 3, 4 }).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6D3434), processHeaderId)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(CountProcessInfo)));
		if (userId.HasValue)
		{
			val.SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122764083), userId.Value);
		}
		CountProcessInfo countProcessInfo = val.CleanUpCache(cleanUpCache: false).List<CountProcessInfo>().FirstOrDefault();
		if (countProcessInfo == null)
		{
			return new CountProcessInfo();
		}
		return countProcessInfo;
	}

	public List<CountProcessInfo> GetTerminateInstanceCountByUsers(long processHeaderId, bool isEmulation)
	{
		return base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACC8D31)).SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B55791), (IEnumerable)new int[2] { 3, 4 }).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1361021807), processHeaderId)
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45815219), isEmulation ? 1 : 0)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(CountProcessInfo)))
			.CleanUpCache(cleanUpCache: false)
			.List<CountProcessInfo>()
			.ToList();
	}

	public CountProcessInfo GetActiveTaskCountByProcess(long processHeaderId, long? userId)
	{
		IQuery val = base.Session.GetNamedQuery((!userId.HasValue) ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x75823E8) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431988528)).SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22367060), (IEnumerable)((IEnumerable<TaskBaseStatus>)TaskBaseExtensions.ActiveTaskStatuses).Select((Func<TaskBaseStatus, Guid>)((TaskBaseStatus s) => s)).ToArray()).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F08AD2), processHeaderId)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(CountProcessInfo)));
		if (userId.HasValue)
		{
			val.SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF6BE60), userId.Value);
		}
		CountProcessInfo countProcessInfo = val.CleanUpCache(cleanUpCache: false).List<CountProcessInfo>().FirstOrDefault();
		if (countProcessInfo == null)
		{
			return new CountProcessInfo();
		}
		return countProcessInfo;
	}

	public List<CountProcessInfo> GetActiveTaskCountByProcessByUsers(long processHeaderId, bool isEmulation)
	{
		return base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x3616795D)).SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574622673), (IEnumerable)TaskBaseExtensions.ActiveTaskStatuses.Select((TaskBaseStatus s) => _003C_003Ec.fvwOrCZ6dpyoe3XrDjhU(s)).ToArray()).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4940763B ^ 0x4940394B), processHeaderId)
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135689742), isEmulation ? 1 : 0)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(CountProcessInfo)))
			.CleanUpCache(cleanUpCache: false)
			.List<CountProcessInfo>()
			.ToList();
	}

	public IEnumerable<IMonitorCacheItem> GetItems(IProcessHeader header, List<IUser> users)
	{
		ICriteria val = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667480281), (object)header));
		if (users != null)
		{
			List<List<IUser>> list = new List<List<IUser>>();
			if (users.Count < 1200)
			{
				list.Add(users);
			}
			else
			{
				List<IUser> list2 = new List<IUser>();
				foreach (IUser user in users)
				{
					if (list2.Count >= 1200)
					{
						List<IUser> list3 = new List<IUser>();
						list3.AddRange(list2);
						list.Add(list3);
						list2 = new List<IUser>();
					}
					list2.Add(user);
				}
				if (list2.Count > 0)
				{
					List<IUser> list4 = new List<IUser>();
					list4.AddRange(list2);
					list.Add(list4);
				}
			}
			List<AbstractCriterion> list5 = new List<AbstractCriterion>();
			foreach (List<IUser> item in list)
			{
				list5.Add(Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542170386), (ICollection)item));
			}
			val.Add((ICriterion)(object)NHibernateHelper.Or((IEnumerable<AbstractCriterion>)list5));
		}
		else
		{
			val.Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8D5763A ^ 0x8D527CE)));
		}
		return val.List<IMonitorCacheItem>();
	}

	public MonitorCacheItemManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Lo03PqcOKjMrvsmjgaX();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ObZxOfBjQ7p4Wwld9ep()
	{
		return OkIg5PBWuF2traXBh1T == null;
	}

	internal static MonitorCacheItemManager JXwTPVBRJlghwWu0F5h()
	{
		return OkIg5PBWuF2traXBh1T;
	}

	internal static object oOcERlB61Gs5dJZ4KIW(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object g6FxWFBqFQ0kMJnMtlN(object P_0, object P_1)
	{
		return ((ILockManager)P_0).Lock((string)P_1);
	}

	internal static object Q91o1VB3gRkhPi8E2hF(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object rbuPrUBT4cGLuos5ID9(object P_0, Type P_1)
	{
		return ((ISession)P_0).CreateCriteria(P_1);
	}

	internal static object CGMZBWBQqkwWO9QkK9N(object P_0)
	{
		return Order.Asc((string)P_0);
	}

	internal static object IoYi29BpGtBdjBcr2ek(object P_0, int P_1)
	{
		return ((ICriteria)P_0).SetMaxResults(P_1);
	}

	internal static object qJd17jBCloRHxW3OnMq()
	{
		return ComponentManager.Current;
	}

	internal static void QN233tBMFCWWmq58knf(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object roNTIeBkOdkNixcTNc1(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object uBjsYJBUm7XpZ9qKs8p(object P_0, object P_1)
	{
		return ((ISession)P_0).GetNamedQuery((string)P_1);
	}

	internal static object vnFLjHBVW8kalgp8bKq(object P_0, object P_1, object P_2)
	{
		return ((IQuery)P_0).SetParameterList((string)P_1, (IEnumerable)P_2);
	}

	internal static object yA0lUUBATvn1KMhYnSH()
	{
		return TaskBaseExtensions.ActiveTaskStatuses;
	}

	internal static Type E981FmBGjI8ZfwMStRV(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object f1gyoZB7Fp9EsM8lp4j(object P_0, object P_1)
	{
		return ((IQuery)P_0).SetResultTransformer((IResultTransformer)P_1);
	}

	internal static object yvd4ACB2cQ4OAtp7x3H(object P_0, bool P_1)
	{
		return ((IQuery)P_0).CleanUpCache(P_1);
	}

	internal static object iTAPS8Bo6Ru8yQ4Znmf()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static long tXJQN5BFRGQM1ypdBx9(object P_0)
	{
		return ((MonitorCacheProcessInfo)P_0).Id;
	}

	internal static long WpWGPjBimXFZOSAe6R4(object P_0)
	{
		return ((MonitorCacheProcessInfo)P_0).CompleteCount;
	}

	internal static long Ouk7f1BIEgX6fm0NIN2(object P_0)
	{
		return ((MonitorCacheProcessInfo)P_0).AvailableCount;
	}

	internal static void eHAus9Baw8RbyAavrDy(object P_0, long value)
	{
		((IMonitorCacheItem)P_0).CurrentInstanceCount = value;
	}

	internal static long keAA3HBrFBlo8evmlAB(object P_0)
	{
		return ((MonitorCacheProcessInfo)P_0).InterruptedCount;
	}

	internal static long xeTA2BBekT1UFL8iOeX(object P_0)
	{
		return ((MonitorCacheProcessInfo)P_0).AssignToMeCount;
	}

	internal static void QxTffxBNvctsOigoG64(object P_0, long value)
	{
		((IMonitorCacheItem)P_0).ActiveTasksCount = value;
	}

	internal static long sLJZIiBxQy6DdIbMvPw(object P_0)
	{
		return ((MonitorCacheProcessInfo)P_0).CompleteCountEml;
	}

	internal static void hQj9shBS1JbL65hKxwt(object P_0, long value)
	{
		((IMonitorCacheItem)P_0).CompletedInstanceEmlCount = value;
	}

	internal static long g5D4uwB1uVAyE94qFhT(object P_0)
	{
		return ((MonitorCacheProcessInfo)P_0).AvailableCountEml;
	}

	internal static void rZANtOBhgEgyjLavx4N(object P_0, long value)
	{
		((IMonitorCacheItem)P_0).CurrentInstanceEmlCount = value;
	}

	internal static long KjQbe3BEoqomhIufGNy(object P_0)
	{
		return ((MonitorCacheProcessInfo)P_0).InterruptedCountEml;
	}

	internal static void YZwQktBwGRAgJ2ajAlj(object P_0, long value)
	{
		((IMonitorCacheItem)P_0).TerminatedInstanceEmlCount = value;
	}

	internal static long kFHVZnB4t8sv460Ivtq(object P_0)
	{
		return ((MonitorCacheProcessInfo)P_0).AssignToMeCountEml;
	}

	internal static void heviAZBzNYdeiR7coQr(object P_0, long value)
	{
		((IMonitorCacheItem)P_0).ActiveTasksEmlCount = value;
	}

	internal static void wlX4n6cKSSUHkDuiOE9(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void Lo03PqcOKjMrvsmjgaX()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
