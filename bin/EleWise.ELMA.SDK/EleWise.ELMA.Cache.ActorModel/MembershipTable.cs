using System;
using System.Collections.Generic;
using System.Linq;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Cache.ActorModel.Partitioning;

internal class MembershipTable
{
	private readonly SortedList<double, CacheEntry> nodes;

	private readonly double localNodeAngle;

	internal static MembershipTable MdMneafXLmxytmbrkKpW;

	public MembershipTable(string node)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				localNodeAngle = nodes.Keys[0];
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num = 2;
				}
				break;
			default:
				nodes = new SortedList<double, CacheEntry>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				AddNode(node);
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num = 3;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public (double start, double end)[] AddNode(string node)
	{
		int num = 3;
		int num2 = num;
		uint hash = default(uint);
		double num3 = default(double);
		CacheEntry value = default(CacheEntry);
		while (true)
		{
			switch (num2)
			{
			case 3:
				hash = lh1eWcfXcDqL1iOmgZgR(node);
				num2 = 2;
				continue;
			case 4:
				return null;
			case 2:
				num3 = O7EV5lfXzjrGj96IXbre(hash);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return FindPreviousNodeAngles(num3);
			case 5:
				nodes.Add(num3, value);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			if (!nodes.Keys.Contains(num3))
			{
				value = new CacheEntry(node, null, hash, num3, DateTime.MaxValue);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 3;
				}
			}
			else
			{
				num2 = 4;
			}
		}
	}

	public (double start, double end)[] RemoveNode(string node)
	{
		int num = 2;
		int num2 = num;
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num3 = O7EV5lfXzjrGj96IXbre(lh1eWcfXcDqL1iOmgZgR(node));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 1;
				}
				break;
			default:
			{
				(double start, double end)[] result = FindPreviousNodeAngles(num3);
				nodes.Remove(num3);
				return result;
			}
			case 1:
				if (!nodes.ContainsKey(num3))
				{
					return null;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public string FindNode(string key, byte replicaFactor, out string[] replicaNodes)
	{
		//Discarded unreachable code: IL_00cc, IL_015a, IL_01e1, IL_01f0, IL_0237, IL_0256, IL_0265, IL_0292
		int num = 4;
		int num8 = default(int);
		CacheEntry cacheEntry = default(CacheEntry);
		IEnumerator<KeyValuePair<double, CacheEntry>> enumerator = default(IEnumerator<KeyValuePair<double, CacheEntry>>);
		List<string> list = default(List<string>);
		int num9 = default(int);
		int num4 = default(int);
		KeyValuePair<double, CacheEntry> current = default(KeyValuePair<double, CacheEntry>);
		double num3 = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					break;
				case 13:
					if (replicaFactor > 0)
					{
						num2 = 7;
						continue;
					}
					goto case 1;
				case 9:
					num8 = nodes.IndexOfKey(cacheEntry.Angle);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 11;
					}
					continue;
				case 6:
					enumerator = nodes.GetEnumerator();
					num2 = 2;
					continue;
				case 7:
					list = new List<string>(replicaFactor);
					num2 = 9;
					continue;
				case 15:
				case 16:
					if (num9 >= replicaFactor)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 10:
					num4 = (num8 + num9 + 1) % nodes.Count;
					num2 = 12;
					continue;
				case 14:
					num9++;
					num2 = 16;
					continue;
				case 1:
					return (string)ryduJRfTBujvJg1TlpSe(cacheEntry);
				case 12:
					if (num4 != num8)
					{
						num2 = 5;
						continue;
					}
					goto default;
				case 2:
					try
					{
						while (true)
						{
							IL_01fb:
							int num5;
							if (!enumerator.MoveNext())
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
								{
									num5 = 0;
								}
								goto IL_0168;
							}
							goto IL_01b9;
							IL_01b9:
							current = enumerator.Current;
							num5 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
							{
								num5 = 2;
							}
							goto IL_0168;
							IL_0168:
							while (true)
							{
								switch (num5)
								{
								case 2:
									if (num3 <= current.Key)
									{
										int num6 = 4;
										num5 = num6;
										continue;
									}
									goto IL_01fb;
								case 4:
									cacheEntry = current.Value;
									num5 = 3;
									continue;
								case 5:
									goto IL_01b9;
								case 3:
									break;
								case 1:
									goto IL_01fb;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						int num7;
						if (enumerator == null)
						{
							num7 = 2;
							goto IL_023b;
						}
						goto IL_0270;
						IL_023b:
						switch (num7)
						{
						default:
							goto end_IL_0226;
						case 2:
							goto end_IL_0226;
						case 1:
							break;
						case 0:
							goto end_IL_0226;
						}
						goto IL_0270;
						IL_0270:
						Wj8MLEfTFqNcppEL3HvG(enumerator);
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num7 = 0;
						}
						goto IL_023b;
						end_IL_0226:;
					}
					goto case 13;
				default:
					replicaNodes = list.Distinct().ToArray();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					cacheEntry = nodes.Values[0];
					num2 = 6;
					continue;
				case 4:
					replicaNodes = new string[0];
					num2 = 3;
					continue;
				case 5:
					list.Add((string)ryduJRfTBujvJg1TlpSe(nodes.Values[num4]));
					num2 = 14;
					continue;
				case 3:
					num3 = O7EV5lfXzjrGj96IXbre(key.ToHash());
					num2 = 8;
					continue;
				}
				break;
			}
			num9 = 0;
			num = 15;
		}
	}

	public IList<CacheEntry> GetNodes()
	{
		return nodes.Values;
	}

	public IList<string> GetNodesAfterLocal(byte count)
	{
		List<string> list = new List<string>();
		if (nodes.Count == 1)
		{
			return list;
		}
		int num = nodes.IndexOfKey(localNodeAngle);
		for (int i = 0; i < count; i++)
		{
			int num2 = (num + i + 1) % nodes.Count;
			if (num2 == num)
			{
				break;
			}
			list.Add(nodes.Values[num2].Key);
		}
		return list.Distinct().ToList();
	}

	private (double start, double end)[] FindPreviousNodeAngles(double remoteNodeAngle)
	{
		//Discarded unreachable code: IL_0055, IL_0064
		int num = 5;
		int num2 = num;
		int num5 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		double num4 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (yTZ8NvfTWy4RhsfZtHIU(nodes) == 1)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 4;
					}
				}
				else
				{
					num5 = nodes.IndexOfKey(remoteNodeAngle);
					num2 = 10;
				}
				continue;
			case 6:
				if (num5 == yTZ8NvfTWy4RhsfZtHIU(nodes) - 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 12;
			case 7:
				if (num6 < 0)
				{
					num2 = 11;
					continue;
				}
				break;
			case 8:
				if (num3 - num5 != 1)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto default;
			case 9:
				if (num3 != 0)
				{
					num2 = 12;
					continue;
				}
				goto case 6;
			case 3:
				return new(double, double)[1] { (num4, remoteNodeAngle) };
			case 12:
				return null;
			case 11:
				num6 = yTZ8NvfTWy4RhsfZtHIU(nodes) - 1;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (!(remoteNodeAngle > num4))
				{
					return new(double, double)[2]
					{
						(num4, HashExtensions.MaxAngle),
						(0.0, remoteNodeAngle)
					};
				}
				num2 = 3;
				continue;
			case 10:
				num3 = nodes.IndexOfKey(localNodeAngle);
				num2 = 8;
				continue;
			default:
				num6 = num5 - 1;
				num2 = 7;
				continue;
			case 4:
				return null;
			case 1:
				break;
			}
			num4 = nodes.Keys[num6];
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
			{
				num2 = 1;
			}
		}
	}

	internal static bool bQkD1vfXUKQTNRlkdgIo()
	{
		return MdMneafXLmxytmbrkKpW == null;
	}

	internal static MembershipTable rbAhZ0fXsu4Gc5w1QOCP()
	{
		return MdMneafXLmxytmbrkKpW;
	}

	internal static uint lh1eWcfXcDqL1iOmgZgR(object P_0)
	{
		return ((string)P_0).ToHash();
	}

	internal static double O7EV5lfXzjrGj96IXbre(uint hash)
	{
		return hash.ToAngle();
	}

	internal static void Wj8MLEfTFqNcppEL3HvG(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object ryduJRfTBujvJg1TlpSe(object P_0)
	{
		return ((CacheEntry)P_0).Key;
	}

	internal static int yTZ8NvfTWy4RhsfZtHIU(object P_0)
	{
		return ((SortedList<double, CacheEntry>)P_0).Count;
	}
}
