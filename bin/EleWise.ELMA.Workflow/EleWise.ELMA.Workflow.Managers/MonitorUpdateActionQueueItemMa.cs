using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class MonitorUpdateActionQueueItemManager : EntityManager<IMonitorUpdateActionQueueItem, long>
{
	internal static MonitorUpdateActionQueueItemManager UaBnmucZ0yXUGYmhJa6;

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
				case 1:
					_003CLockManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public new static MonitorUpdateActionQueueItemManager Instance => Locator.GetServiceNotNull<MonitorUpdateActionQueueItemManager>();

	public bool HasAction(IProcessHeader header, Guid action, IUser user)
	{
		return fnFVXact7Dh7Ql3x3e6(oAAyoxcmMWydyVo5aHa(((ICriteria)WkZJuMclLw0JBS7CZv6(WkZJuMclLw0JBS7CZv6(WkZJuMclLw0JBS7CZv6(WkZJuMclLw0JBS7CZv6(GpblQ1c8JZKeFrV7Q1h(this, null), WNqSUhcJF4HN0nZIeIj(Bl9RwPcsyxouvfDcPM5(0x1134D2C0 ^ 0x113480C0), action)), (header != null) ? WNqSUhcJF4HN0nZIeIj(Bl9RwPcsyxouvfDcPM5(0x5BCD23A0 ^ 0x5BCD6546), header) : BWvuf6c0G6tcrymWJeB(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x69063C81 ^ 0x69067A67))), (user != null) ? WNqSUhcJF4HN0nZIeIj(Bl9RwPcsyxouvfDcPM5(-1712492721 ^ -1712505157), user) : BWvuf6c0G6tcrymWJeB(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF405C0C))), WNqSUhcJF4HN0nZIeIj(Bl9RwPcsyxouvfDcPM5(0x213F6477 ^ 0x213F3669), false))).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)ix0QwncyxCx7o5dhVhG(Bl9RwPcsyxouvfDcPM5(0x46EA3D1 ^ 0x46EE557)) }))) > 0;
	}

	[Transaction]
	public virtual void OptimizeCacheActions()
	{
		//Discarded unreachable code: IL_022b, IL_023a, IL_0343, IL_04d5, IL_0505, IL_0524, IL_0550, IL_055f, IL_0581, IL_058f, IL_067f, IL_07c2, IL_07cc, IL_0938, IL_094b, IL_095a
		int num = 3;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		string sql3 = default(string);
		string sql2 = default(string);
		List<Tuple<Guid, long?, long?, long>> list = default(List<Tuple<Guid, long?, long?, long>>);
		IDataReader dataReader = default(IDataReader);
		long? item3 = default(long?);
		long item4 = default(long);
		long? item = default(long?);
		Guid item2 = default(Guid);
		List<Tuple<Guid, long?, long?, long>>.Enumerator enumerator = default(List<Tuple<Guid, long?, long?, long>>.Enumerator);
		Tuple<Guid, long?, long?, long> current = default(Tuple<Guid, long?, long?, long>);
		string sql = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text = default(string);
		long? num4 = default(long?);
		while (true)
		{
			switch (num2)
			{
			case 8:
				serviceNotNull.ExecuteNonQuery(sql3);
				num2 = 4;
				continue;
			case 4:
				sql2 = (string)ffk0VQcBJYQ1Cvm6rZb(Bl9RwPcsyxouvfDcPM5(-398691253 ^ -398711155), new object[6]
				{
					b8GdCZc5GGIRA4BVnur(aawcGicbu72L3SDV7xY(serviceNotNull), Bl9RwPcsyxouvfDcPM5(0x2269BD32 ^ 0x2269EF32)),
					b8GdCZc5GGIRA4BVnur(aawcGicbu72L3SDV7xY(serviceNotNull), Bl9RwPcsyxouvfDcPM5(-1542190822 ^ -1542172676)),
					b8GdCZc5GGIRA4BVnur(aawcGicbu72L3SDV7xY(serviceNotNull), Bl9RwPcsyxouvfDcPM5(0xDF4D1F8 ^ 0xDF4800C)),
					((Dialect)aawcGicbu72L3SDV7xY(serviceNotNull)).QuoteIfNeeded((string)Bl9RwPcsyxouvfDcPM5(-1514166050 ^ -1514148264)),
					b8GdCZc5GGIRA4BVnur(aawcGicbu72L3SDV7xY(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130119076)),
					serviceNotNull.Dialect.QuoteIfNeeded((string)Bl9RwPcsyxouvfDcPM5(-63028171 ^ -63039957))
				});
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				sql3 = (string)zag7KIcgFFXYmG8y3Zo(Bl9RwPcsyxouvfDcPM5(-1539486135 ^ -1539498885), b8GdCZc5GGIRA4BVnur(aawcGicbu72L3SDV7xY(serviceNotNull), Bl9RwPcsyxouvfDcPM5(0x1927DA93 ^ 0x19278819)), b8GdCZc5GGIRA4BVnur(aawcGicbu72L3SDV7xY(serviceNotNull), Bl9RwPcsyxouvfDcPM5(-539998957 ^ -540010739)), b8GdCZc5GGIRA4BVnur(aawcGicbu72L3SDV7xY(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790200444)));
				num2 = 8;
				continue;
			case 1:
				list = new List<Tuple<Guid, long?, long?, long>>();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
				{
					num2 = 9;
				}
				continue;
			case 9:
				dataReader = serviceNotNull.ExecuteQuery(sql2);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				try
				{
					while (true)
					{
						IL_04aa:
						int num6;
						if (!M0eqylcX79K5IOPehir(dataReader))
						{
							num6 = 8;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
							{
								num6 = 5;
							}
							goto IL_0249;
						}
						goto IL_028f;
						IL_028f:
						if (DJw0sFccQhU1klxr25n(dataReader, Bl9RwPcsyxouvfDcPM5(-2057730233 ^ -2057710265)) is DBNull)
						{
							continue;
						}
						num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
						{
							num6 = 0;
						}
						goto IL_0249;
						IL_0249:
						while (true)
						{
							switch (num6)
							{
							case 6:
								break;
							case 12:
								item3 = fnFVXact7Dh7Ql3x3e6(DJw0sFccQhU1klxr25n(dataReader, Bl9RwPcsyxouvfDcPM5(0x1AF6F1F2 ^ 0x1AF6B714)));
								num6 = 10;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
								{
									num6 = 5;
								}
								continue;
							case 3:
								if (!(DJw0sFccQhU1klxr25n(dataReader, Bl9RwPcsyxouvfDcPM5(0x13F63440 ^ 0x13F665B4)) is DBNull))
								{
									num6 = 9;
									continue;
								}
								goto case 13;
							case 1:
								item3 = null;
								num6 = 11;
								continue;
							case 11:
								if (DJw0sFccQhU1klxr25n(dataReader, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125912930)) is DBNull)
								{
									num6 = 14;
									continue;
								}
								goto case 12;
							case 4:
								item4 = fnFVXact7Dh7Ql3x3e6(DJw0sFccQhU1klxr25n(dataReader, Bl9RwPcsyxouvfDcPM5(-1108877388 ^ -1108898736)));
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
								{
									num6 = 1;
								}
								continue;
							case 9:
							{
								item = fnFVXact7Dh7Ql3x3e6(DJw0sFccQhU1klxr25n(dataReader, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D698E7)));
								int num7 = 13;
								num6 = num7;
								continue;
							}
							case 5:
								item2 = C13gUXcPVxjwtny2bX5(aawcGicbu72L3SDV7xY(serviceNotNull), DJw0sFccQhU1klxr25n(dataReader, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-43932417 ^ -43911425)));
								num6 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
								{
									num6 = 4;
								}
								continue;
							default:
								if (DJw0sFccQhU1klxr25n(dataReader, Bl9RwPcsyxouvfDcPM5(0x595C500A ^ 0x595C03EE)) is DBNull)
								{
									num6 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
									{
										num6 = 2;
									}
									continue;
								}
								goto case 5;
							case 13:
								list.Add(new Tuple<Guid, long?, long?, long>(item2, item3, item, item4));
								num6 = 7;
								continue;
							case 10:
							case 14:
								item = null;
								num6 = 3;
								continue;
							case 2:
							case 7:
								goto IL_04aa;
							case 8:
								goto end_IL_04aa;
							}
							break;
						}
						goto IL_028f;
						continue;
						end_IL_04aa:
						break;
					}
				}
				finally
				{
					int num8;
					if (dataReader == null)
					{
						num8 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
						{
							num8 = 0;
						}
						goto IL_0509;
					}
					goto IL_052e;
					IL_052e:
					dataReader.Dispose();
					num8 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
					{
						num8 = 0;
					}
					goto IL_0509;
					IL_0509:
					switch (num8)
					{
					default:
						goto end_IL_04e4;
					case 1:
						goto end_IL_04e4;
					case 2:
						break;
					case 0:
						goto end_IL_04e4;
					}
					goto IL_052e;
					end_IL_04e4:;
				}
				break;
			case 3:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 2;
				continue;
			case 7:
				try
				{
					while (true)
					{
						IL_07fc:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
							{
								num3 = 1;
							}
							goto IL_0593;
						}
						goto IL_071f;
						IL_071f:
						current = enumerator.Current;
						num3 = 6;
						goto IL_0593;
						IL_0593:
						while (true)
						{
							object obj4;
							object obj3;
							switch (num3)
							{
							case 2:
								sql = (string)ffk0VQcBJYQ1Cvm6rZb(Bl9RwPcsyxouvfDcPM5(0x157D5AF4 ^ 0x157D0E96), new object[5]
								{
									b8GdCZc5GGIRA4BVnur(aawcGicbu72L3SDV7xY(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105841976)),
									text2,
									text3,
									text4,
									text
								});
								num3 = 11;
								continue;
							case 7:
								num4 = current.Item3;
								num3 = 5;
								continue;
							case 3:
								obj4 = dsKIdycDYsJf39hgunL(Bl9RwPcsyxouvfDcPM5(-1386448964 ^ -1386470500), b8GdCZc5GGIRA4BVnur(serviceNotNull.Dialect, Bl9RwPcsyxouvfDcPM5(--1418337216 ^ 0x548A4A34)));
								goto IL_0900;
							case 11:
								serviceNotNull.ExecuteNonQuery(sql, new Dictionary<string, object> { 
								{
									SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB2DE1A),
									current.Item1
								} });
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
								{
									num3 = 0;
								}
								continue;
							case 9:
								text = (string)VSnhmWcutJ8Axqs9yCG(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E92515), b8GdCZc5GGIRA4BVnur(serviceNotNull.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF404B7E)), current.Item4);
								num3 = 2;
								continue;
							case 8:
								break;
							case 6:
								text2 = (string)VSnhmWcutJ8Axqs9yCG(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B7A5D6), b8GdCZc5GGIRA4BVnur(aawcGicbu72L3SDV7xY(serviceNotNull), Bl9RwPcsyxouvfDcPM5(-432000546 ^ -431987746)), Sw4deicd3o0smpQHXfr(serviceNotNull));
								num3 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
								{
									num3 = 10;
								}
								continue;
							case 12:
								obj3 = string.Format((string)Bl9RwPcsyxouvfDcPM5(0x1C663DA1 ^ 0x1C666981), b8GdCZc5GGIRA4BVnur(serviceNotNull.Dialect, Bl9RwPcsyxouvfDcPM5(0x37E97159 ^ 0x37E937BF)));
								goto IL_08ad;
							case 5:
							{
								if (!num4.HasValue)
								{
									num3 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
									{
										num3 = 3;
									}
									continue;
								}
								object format = Bl9RwPcsyxouvfDcPM5(-1214182792 ^ -1214161342);
								object arg = b8GdCZc5GGIRA4BVnur(aawcGicbu72L3SDV7xY(serviceNotNull), Bl9RwPcsyxouvfDcPM5(-684210684 ^ -684222480));
								num4 = current.Item3;
								obj4 = string.Format((string)format, arg, num4.Value);
								goto IL_0900;
							}
							default:
								goto IL_07fc;
							case 10:
								num4 = current.Item2;
								num3 = 4;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
								{
									num3 = 4;
								}
								continue;
							case 4:
								if (num4.HasValue)
								{
									num3 = 13;
									continue;
								}
								goto case 12;
							case 13:
							{
								object obj = Bl9RwPcsyxouvfDcPM5(0x628167BE ^ 0x62813384);
								object obj2 = b8GdCZc5GGIRA4BVnur(aawcGicbu72L3SDV7xY(serviceNotNull), Bl9RwPcsyxouvfDcPM5(-708128192 ^ -708143962));
								num4 = current.Item2;
								obj3 = VSnhmWcutJ8Axqs9yCG(obj, obj2, num4.Value);
								goto IL_08ad;
							}
							case 1:
								return;
								IL_0900:
								text4 = (string)obj4;
								num3 = 9;
								continue;
								IL_08ad:
								text3 = (string)obj3;
								num3 = 7;
								continue;
							}
							break;
						}
						goto IL_071f;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 6:
				return;
			case 5:
				break;
			}
			enumerator = list.GetEnumerator();
			num2 = 7;
		}
	}

	[Transaction]
	public virtual void ClearQueue()
	{
		int num = 3;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		string sql = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			default:
				serviceNotNull.ExecuteNonQuery(sql);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				sql = string.Format((string)Bl9RwPcsyxouvfDcPM5(-1214182792 ^ -1214167116), b8GdCZc5GGIRA4BVnur(aawcGicbu72L3SDV7xY(serviceNotNull), Bl9RwPcsyxouvfDcPM5(-1028861977 ^ -1028874899)));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 2;
				break;
			}
		}
	}

	public long GetActiveOperationCount()
	{
		return fnFVXact7Dh7Ql3x3e6(oAAyoxcmMWydyVo5aHa(((ICriteria)WkZJuMclLw0JBS7CZv6(GpblQ1c8JZKeFrV7Q1h(this, null), rZoSuWcnpxsboQCV29P(Restrictions.Eq((string)Bl9RwPcsyxouvfDcPM5(0xDF4D1F8 ^ 0xDF483E6), (object)false), BWvuf6c0G6tcrymWJeB(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E92347))))).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)ix0QwncyxCx7o5dhVhG(Bl9RwPcsyxouvfDcPM5(-2122743969 ^ -2122761767)) })));
	}

	public long[] GetTopElemets(int top)
	{
		//Discarded unreachable code: IL_003a, IL_0049, IL_0054, IL_00ed, IL_0100, IL_010f
		int num = 4;
		List<IMonitorUpdateActionQueueItem>.Enumerator enumerator = default(List<IMonitorUpdateActionQueueItem>.Enumerator);
		List<IMonitorUpdateActionQueueItem> source = default(List<IMonitorUpdateActionQueueItem>);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
								{
									num3 = 0;
								}
								goto IL_0058;
							}
							goto IL_006e;
							IL_006e:
							IMonitorUpdateActionQueueItem current = enumerator.Current;
							dBdHNdc9aGXgBZsjNF2(current, true);
							current.Save();
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
							{
								num3 = 1;
							}
							goto IL_0058;
							IL_0058:
							switch (num3)
							{
							case 2:
								goto IL_006e;
							case 1:
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 5;
				default:
					enumerator = source.Where(_003C_003Ec__DisplayClass10_._003CGetTopElemets_003Eb__4).ToList().GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					break;
				case 3:
					source = ((ICriteria)rENdcscfwMWgSkeN5NB(oUXLIWcLi3eTiMIpvSk(((ICriteria)WkZJuMclLw0JBS7CZv6(GpblQ1c8JZKeFrV7Q1h(this, null), rZoSuWcnpxsboQCV29P(WNqSUhcJF4HN0nZIeIj(Bl9RwPcsyxouvfDcPM5(-2122743969 ^ -2122764991), false), Restrictions.IsNull((string)Bl9RwPcsyxouvfDcPM5(0x75BAD659 ^ 0x75BA8447))))).Add((ICriterion)(object)Restrictions.Le(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-43932417 ^ -43913193), (object)DateTime.Now.AddSeconds(-10.0))), doI1REcHE82yxlVBkBi(Bl9RwPcsyxouvfDcPM5(0x7AC609FE ^ 0x7AC64F78))), top)).List<IMonitorUpdateActionQueueItem>().ToList();
					num2 = 2;
					continue;
				case 5:
					return _003C_003Ec__DisplayClass10_.result;
				case 2:
					_003C_003Ec__DisplayClass10_.result = (from i in source
						group i by new MonitorCacheItemGroup
						{
							ActionUid = i.ActionTypeUid,
							ProcessHeader = (IProcessHeader)_003C_003Ec.VKTvHyZ66k0LHyWHTOvt(i),
							User = i.User
						} into g
						select g.FirstOrDefault() into g
						where g != null
						select g.Id).ToArray();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
			num = 3;
		}
	}

	[Transaction]
	public virtual void ExecuteAction(IMonitorUpdateActionQueueItem item)
	{
		//Discarded unreachable code: IL_00bc, IL_011e, IL_013d, IL_014c, IL_0179, IL_0188, IL_0204, IL_0213
		int num = 2;
		int num2 = num;
		IDisposable @lock = default(IDisposable);
		IMonitorUpdateQueueAction monitorUpdateQueueAction = default(IMonitorUpdateQueueAction);
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		IDisposable disposable = default(IDisposable);
		string lockName = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 10:
				@lock = null;
				num2 = 11;
				continue;
			case 5:
				try
				{
					monitorUpdateQueueAction.DoAction((IProcessHeader)Uw2smEcWGTLXy4DvGoT(_003C_003Ec__DisplayClass11_.item), (IUser)rAFEdscjTPuGA08lXlk(_003C_003Ec__DisplayClass11_.item));
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						}
						_003C_003Ec__DisplayClass11_.item.Delete();
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					int num4;
					if (disposable == null)
					{
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
						{
							num4 = 0;
						}
						goto IL_0122;
					}
					goto IL_0157;
					IL_0157:
					Apv5uScRC1lAXQKaWg9(disposable);
					num4 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
					{
						num4 = 1;
					}
					goto IL_0122;
					IL_0122:
					switch (num4)
					{
					default:
						goto end_IL_00fd;
					case 0:
						goto end_IL_00fd;
					case 2:
						break;
					case 1:
						goto end_IL_00fd;
					}
					goto IL_0157;
					end_IL_00fd:;
				}
			default:
				disposable = @lock;
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
				{
					num2 = 4;
				}
				continue;
			case 7:
				return;
			case 8:
				return;
			case 4:
				if (LockForExecute(_003C_003Ec__DisplayClass11_.item))
				{
					monitorUpdateQueueAction = ComponentManager.Current.GetExtensionPoints<IMonitorUpdateQueueAction>().FirstOrDefault(_003C_003Ec__DisplayClass11_._003CExecuteAction_003Eb__0);
					num2 = 6;
					continue;
				}
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 1;
				}
				continue;
			case 6:
				if (monitorUpdateQueueAction == null)
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
					{
						num2 = 7;
					}
					continue;
				}
				break;
			case 11:
				if (!LockManager.TryLock(lockName, 1, out @lock))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				_003C_003Ec__DisplayClass11_.item = item;
				num2 = 4;
				continue;
			case 9:
				break;
			}
			lockName = (string)Bl9RwPcsyxouvfDcPM5(--1212129906 ^ 0x483FF776) + ((Uw2smEcWGTLXy4DvGoT(_003C_003Ec__DisplayClass11_.item) != null) ? _003C_003Ec__DisplayClass11_.item.ProcessHeader.Id.ToString() : "");
			num2 = 10;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
			{
				num2 = 4;
			}
		}
	}

	protected bool LockForExecute(IMonitorUpdateActionQueueItem item)
	{
		//Discarded unreachable code: IL_009f, IL_00ae, IL_0124, IL_0196, IL_01a5, IL_01b5, IL_01c4
		int num = 4;
		bool result = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					try
					{
						int num3 = SR.GetSetting(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xB7793C9 ^ 0xB77C6FB), 1);
						int num4 = 3;
						int num5 = num4;
						while (true)
						{
							switch (num5)
							{
							case 5:
								num3 = 1;
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
							case 4:
								((ISession)lgDbG4c6wc8uL1vrm88(this)).LockWithWait(item, num3);
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
								{
									num5 = 0;
								}
								continue;
							case 3:
								if (num3 > 0)
								{
									num5 = 4;
									continue;
								}
								goto case 5;
							default:
								Refresh(item);
								num5 = 2;
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					catch
					{
						int num6 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							case 2:
								result = false;
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
								{
									num6 = 0;
								}
								break;
							case 1:
								pXlBSacTsbEUdook9Z9(X8KcfgcqUqf1q3ocbxW(this), MGlqdrc3ohs8Bi4ooAl(Bl9RwPcsyxouvfDcPM5(-961162596 ^ -961181702), item.Id));
								num6 = 2;
								break;
							default:
								return result;
							case 0:
								return result;
							}
						}
					}
					goto case 1;
				case 1:
					return true;
				default:
					throw new ArgumentNullException((string)Bl9RwPcsyxouvfDcPM5(-1050383744 ^ -1050394714));
				case 3:
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					if (item != null)
					{
						break;
					}
					goto default;
				}
				break;
			}
			num = 3;
		}
	}

	public MonitorUpdateActionQueueItemManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool yJyRgZcvpZgTYX2UarK()
	{
		return UaBnmucZ0yXUGYmhJa6 == null;
	}

	internal static MonitorUpdateActionQueueItemManager chaBsgcYWlxtPEFpVJn()
	{
		return UaBnmucZ0yXUGYmhJa6;
	}

	internal static object GpblQ1c8JZKeFrV7Q1h(object P_0, object P_1)
	{
		return ((EntityManager<IMonitorUpdateActionQueueItem, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object Bl9RwPcsyxouvfDcPM5(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object WNqSUhcJF4HN0nZIeIj(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object WkZJuMclLw0JBS7CZv6(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object BWvuf6c0G6tcrymWJeB(object P_0)
	{
		return Restrictions.IsNull((string)P_0);
	}

	internal static object ix0QwncyxCx7o5dhVhG(object P_0)
	{
		return Projections.Count((string)P_0);
	}

	internal static object oAAyoxcmMWydyVo5aHa(object P_0)
	{
		return ((ICriteria)P_0).UniqueResult();
	}

	internal static long fnFVXact7Dh7Ql3x3e6(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object aawcGicbu72L3SDV7xY(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object b8GdCZc5GGIRA4BVnur(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object zag7KIcgFFXYmG8y3Zo(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object ffk0VQcBJYQ1Cvm6rZb(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object DJw0sFccQhU1klxr25n(object P_0, object P_1)
	{
		return ((IDataRecord)P_0)[(string)P_1];
	}

	internal static Guid C13gUXcPVxjwtny2bX5(object P_0, object P_1)
	{
		return ((Dialect)P_0).GetGuid(P_1);
	}

	internal static bool M0eqylcX79K5IOPehir(object P_0)
	{
		return ((IDataReader)P_0).Read();
	}

	internal static object Sw4deicd3o0smpQHXfr(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object VSnhmWcutJ8Axqs9yCG(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object dsKIdycDYsJf39hgunL(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object rZoSuWcnpxsboQCV29P(object P_0, object P_1)
	{
		return Restrictions.Or((ICriterion)P_0, (ICriterion)P_1);
	}

	internal static object doI1REcHE82yxlVBkBi(object P_0)
	{
		return Order.Asc((string)P_0);
	}

	internal static object oUXLIWcLi3eTiMIpvSk(object P_0, object P_1)
	{
		return ((ICriteria)P_0).AddOrder((Order)P_1);
	}

	internal static object rENdcscfwMWgSkeN5NB(object P_0, int P_1)
	{
		return ((ICriteria)P_0).SetMaxResults(P_1);
	}

	internal static void dBdHNdc9aGXgBZsjNF2(object P_0, bool value)
	{
		((IMonitorUpdateActionQueueItem)P_0).Executed = value;
	}

	internal static object Uw2smEcWGTLXy4DvGoT(object P_0)
	{
		return ((IMonitorUpdateActionQueueItem)P_0).ProcessHeader;
	}

	internal static object rAFEdscjTPuGA08lXlk(object P_0)
	{
		return ((IMonitorUpdateActionQueueItem)P_0).User;
	}

	internal static void Apv5uScRC1lAXQKaWg9(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object lgDbG4c6wc8uL1vrm88(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object X8KcfgcqUqf1q3ocbxW(object P_0)
	{
		return ((EntityManager<IMonitorUpdateActionQueueItem, long>)P_0).Logger;
	}

	internal static object MGlqdrc3ohs8Bi4ooAl(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static void pXlBSacTsbEUdook9Z9(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}
}
