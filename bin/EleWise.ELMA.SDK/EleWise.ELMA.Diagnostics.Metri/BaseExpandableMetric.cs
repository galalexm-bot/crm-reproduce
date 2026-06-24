using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics;

public abstract class BaseExpandableMetric : IExpandableMetric, IMetric
{
	private List<IMetric> additionalParameters;

	private readonly ReaderWriterLockSlim rwLock;

	private static BaseExpandableMetric Eii6X9E8RW85aFymXqI4;

	public abstract Guid Uid { get; }

	public IEnumerable<IMetric> AdditionalParameters
	{
		get
		{
			rwLock.EnterReadLock();
			try
			{
				return additionalParameters;
			}
			finally
			{
				rwLock.ExitReadLock();
			}
		}
	}

	public void AddAdditionalParameters(IMetric metric)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				additionalParameters.Add(metric);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				continue;
			}
			additionalParameters = additionalParameters.OrderBy((IMetric s) => _003C_003Ec.AvpSZq8KhX4xpMZKVObA(s)).ToList();
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
			{
				num2 = 2;
			}
		}
	}

	public virtual void Merge(IMetric metric)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_0072, IL_00db, IL_0143, IL_022b, IL_0280, IL_02a1, IL_02b4, IL_032c, IL_033b, IL_0390, IL_03c7, IL_03d6, IL_052a, IL_056a, IL_059c, IL_05af, IL_05be, IL_05ef, IL_0651, IL_0689, IL_069c, IL_06ab
		int num = 7;
		int num2 = num;
		IExpandableMetric expandableMetric = default(IExpandableMetric);
		List<IMetric> list = default(List<IMetric>);
		IMetric current = default(IMetric);
		IMetric current2 = default(IMetric);
		int num8 = default(int);
		Guid guid = default(Guid);
		bool flag2 = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 7:
				expandableMetric = metric as IExpandableMetric;
				num2 = 6;
				break;
			case 2:
				return;
			case 5:
				list = new List<IMetric>();
				num2 = 3;
				break;
			case 6:
				if (expandableMetric != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 3:
				try
				{
					List<IMetric>.Enumerator enumerator = additionalParameters.GetEnumerator();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							HoYKpnE828n0KVVQ5Xgi(rwLock);
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num3 = 2;
							}
							break;
						case 1:
							try
							{
								IEnumerator<IMetric> enumerator2 = expandableMetric.AdditionalParameters.GetEnumerator();
								int num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num6 = 0;
								}
								switch (num6)
								{
								default:
									try
									{
										bool flag = enumerator.MoveNext();
										int num7 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
										{
											num7 = 1;
										}
										while (true)
										{
											int num9;
											switch (num7)
											{
											case 6:
												list.Add(current);
												num7 = 11;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
												{
													num7 = 11;
												}
												continue;
											case 14:
												current = enumerator2.Current;
												num7 = 3;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
												{
													num7 = 10;
												}
												continue;
											case 20:
												list.Add(current2);
												num7 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
												{
													num7 = 0;
												}
												continue;
											case 22:
												if (num8 >= 0)
												{
													num7 = 24;
													continue;
												}
												goto case 17;
											case 10:
												guid = blAc6cE8kId2btyjQQ68(current2);
												num7 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
												{
													num7 = 27;
												}
												continue;
											case 26:
												flag = enumerator.MoveNext();
												num7 = 23;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
												{
													num7 = 23;
												}
												continue;
											default:
												flag = enumerator.MoveNext();
												num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
												{
													num7 = 19;
												}
												continue;
											case 1:
												flag2 = bDqJlZE8T9sQ4XxMo7Rt(enumerator2);
												num7 = 18;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
												{
													num7 = 0;
												}
												continue;
											case 29:
												current2 = enumerator.Current;
												num7 = 14;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
												{
													num7 = 10;
												}
												continue;
											case 2:
												flag = enumerator.MoveNext();
												num7 = 16;
												continue;
											case 3:
												if (flag)
												{
													num9 = 9;
													goto IL_0179;
												}
												goto case 5;
											case 27:
												num8 = guid.CompareTo(blAc6cE8kId2btyjQQ68(current));
												num7 = 22;
												continue;
											case 13:
											case 28:
												list.Add(enumerator.Current);
												num7 = 11;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
												{
													num7 = 26;
												}
												continue;
											case 17:
												list.Add(current2);
												num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
												{
													num7 = 0;
												}
												continue;
											case 30:
												clF0E7E8n4QoDehQt0yD(current2, current);
												num7 = 20;
												continue;
											case 8:
											case 12:
											case 18:
											case 19:
											case 23:
											case 25:
												if (!(flag || flag2))
												{
													num7 = 21;
													continue;
												}
												goto case 3;
											case 16:
												flag2 = enumerator2.MoveNext();
												num7 = 8;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
												{
													num7 = 8;
												}
												continue;
											case 5:
												list.Add(enumerator2.Current);
												num7 = 4;
												continue;
											case 9:
											case 15:
												if (!flag2)
												{
													num9 = 13;
													goto IL_0179;
												}
												goto case 29;
											case 11:
												flag2 = bDqJlZE8T9sQ4XxMo7Rt(enumerator2);
												num7 = 12;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
												{
													num7 = 5;
												}
												continue;
											case 7:
											case 24:
												if (num8 == 0)
												{
													num7 = 30;
													continue;
												}
												goto case 6;
											case 4:
												flag2 = enumerator2.MoveNext();
												num7 = 25;
												continue;
											case 21:
												break;
												IL_0179:
												num7 = num9;
												continue;
											}
											break;
										}
									}
									finally
									{
										int num10;
										if (enumerator2 == null)
										{
											num10 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
											{
												num10 = 0;
											}
											goto IL_052e;
										}
										goto IL_0544;
										IL_0544:
										D0OSiXE8OPuhjAfrlPSD(enumerator2);
										num10 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
										{
											num10 = 1;
										}
										goto IL_052e;
										IL_052e:
										switch (num10)
										{
										default:
											goto end_IL_0509;
										case 2:
											break;
										case 0:
											goto end_IL_0509;
										case 1:
											goto end_IL_0509;
										}
										goto IL_0544;
										end_IL_0509:;
									}
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num11 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
								{
									num11 = 0;
								}
								switch (num11)
								{
								case 0:
									break;
								}
							}
							goto default;
						case 2:
							try
							{
								U8R6LhE8eYh9ajRNiRDH(additionalParameters);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
								{
									num4 = 1;
								}
								while (true)
								{
									switch (num4)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										additionalParameters = list;
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
										{
											num4 = 0;
										}
										break;
									}
								}
							}
							finally
							{
								Tj3jpGE8Puv8DAYxWQn0(rwLock);
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								case 0:
									break;
								}
							}
						}
					}
				}
				finally
				{
					rwLock.ExitUpgradeableReadLock();
					int num12 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num12 = 0;
					}
					switch (num12)
					{
					case 0:
						break;
					}
				}
			case 4:
				return;
			case 1:
				if (!k8K4IJE8XU4ekh0L5t80(rwLock, 50))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	protected BaseExpandableMetric()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		aMV3CxE81IKLP3Fx4etQ();
		additionalParameters = new List<IMetric>();
		rwLock = new ReaderWriterLockSlim();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool zOjxwNE8qeNNedPhKMGi()
	{
		return Eii6X9E8RW85aFymXqI4 == null;
	}

	internal static BaseExpandableMetric QRHagOE8KYct3qSjYOy3()
	{
		return Eii6X9E8RW85aFymXqI4;
	}

	internal static bool k8K4IJE8XU4ekh0L5t80(object P_0, int P_1)
	{
		return ((ReaderWriterLockSlim)P_0).TryEnterUpgradeableReadLock(P_1);
	}

	internal static bool bDqJlZE8T9sQ4XxMo7Rt(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static Guid blAc6cE8kId2btyjQQ68(object P_0)
	{
		return ((IMetric)P_0).Uid;
	}

	internal static void clF0E7E8n4QoDehQt0yD(object P_0, object P_1)
	{
		((IMetric)P_0).Merge((IMetric)P_1);
	}

	internal static void D0OSiXE8OPuhjAfrlPSD(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void HoYKpnE828n0KVVQ5Xgi(object P_0)
	{
		((ReaderWriterLockSlim)P_0).EnterWriteLock();
	}

	internal static void U8R6LhE8eYh9ajRNiRDH(object P_0)
	{
		((List<IMetric>)P_0).Clear();
	}

	internal static void Tj3jpGE8Puv8DAYxWQn0(object P_0)
	{
		((ReaderWriterLockSlim)P_0).ExitWriteLock();
	}

	internal static void aMV3CxE81IKLP3Fx4etQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
