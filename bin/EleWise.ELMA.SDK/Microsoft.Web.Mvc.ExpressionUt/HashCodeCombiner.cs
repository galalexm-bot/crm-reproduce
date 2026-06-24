using System;
using System.Collections;
using j3AmrhgkCleVTGdEwA;

namespace Microsoft.Web.Mvc.ExpressionUtil;

internal class HashCodeCombiner
{
	private long _combinedHash64;

	private static HashCodeCombiner V5e0ecooWE0W4sWghET;

	public int CombinedHash => _combinedHash64.GetHashCode();

	public void AddFingerprint(ExpressionFingerprint fingerprint)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				return;
			case 1:
				if (fingerprint == null)
				{
					AddInt32(0);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 0;
					}
				}
				break;
			default:
				koVIHGoGL6awLqFuU6g(fingerprint, this);
				num2 = 3;
				break;
			}
		}
	}

	public void AddEnumerable(IEnumerable e)
	{
		//Discarded unreachable code: IL_004c, IL_005b, IL_011f, IL_017c, IL_018b
		int num = 2;
		int num2 = num;
		IEnumerator enumerator = default(IEnumerator);
		object o = default(object);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 5:
				try
				{
					while (true)
					{
						IL_00e1:
						int num4;
						if (!kA7WuvoQ00J4T8lTAIp(enumerator))
						{
							num4 = 2;
							goto IL_006a;
						}
						goto IL_0088;
						IL_006a:
						while (true)
						{
							switch (num4)
							{
							case 1:
								break;
							case 3:
								AddObject(o);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
								{
									num4 = 0;
								}
								continue;
							default:
							{
								num3++;
								int num5 = 4;
								num4 = num5;
								continue;
							}
							case 4:
								goto IL_00e1;
							case 2:
								goto end_IL_00e1;
							}
							break;
						}
						goto IL_0088;
						IL_0088:
						o = AZM1bfof9ISPjVFjj2R(enumerator);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num4 = 3;
						}
						goto IL_006a;
						continue;
						end_IL_00e1:
						break;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							if (disposable != null)
							{
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
								{
									num6 = 0;
								}
								continue;
							}
							break;
						case 1:
							disposable.Dispose();
							num6 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num6 = 1;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
				}
				break;
			case 2:
				if (e != null)
				{
					num3 = 0;
					num2 = 6;
					continue;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				AddInt32(0);
				num2 = 4;
				continue;
			case 6:
				enumerator = (IEnumerator)w3PN6MoEriNOiprdXiq(e);
				num2 = 5;
				continue;
			case 3:
				return;
			}
			AddInt32(num3);
			num2 = 3;
		}
	}

	public void AddInt32(int i)
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
				_combinedHash64 = ((_combinedHash64 << 5) + _combinedHash64) ^ i;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void AddObject(object o)
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
				AddInt32(o?.GetHashCode() ?? 0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public HashCodeCombiner()
	{
		//Discarded unreachable code: IL_003b, IL_0040
		SingletonReader.JJCZtPuTvSt();
		_combinedHash64 = 5381L;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool S1jsrLoboVDDbjuwoOb()
	{
		return V5e0ecooWE0W4sWghET == null;
	}

	internal static HashCodeCombiner A3G0l5ohSXKStv7rMJQ()
	{
		return V5e0ecooWE0W4sWghET;
	}

	internal static void koVIHGoGL6awLqFuU6g(object P_0, object P_1)
	{
		((ExpressionFingerprint)P_0).AddToHashCodeCombiner((HashCodeCombiner)P_1);
	}

	internal static object w3PN6MoEriNOiprdXiq(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object AZM1bfof9ISPjVFjj2R(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool kA7WuvoQ00J4T8lTAIp(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}
}
