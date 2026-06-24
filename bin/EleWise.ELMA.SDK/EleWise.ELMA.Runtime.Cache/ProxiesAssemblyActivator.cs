using System;
using System.Collections.Generic;
using Autofac.Builder;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.Db;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Cache;

public class ProxiesAssemblyActivator : IDisposable
{
	private DbPreUpdater dbPreUpdater;

	private string cacheName;

	private Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>> interceptorsToRegister;

	internal static ProxiesAssemblyActivator DD8kA2WesEYppf5aRtis;

	public ProxiesAssemblyActivator(DbPreUpdater dbPreUpdater, string cacheName, Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>> interceptorsToRegister)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.dbPreUpdater = dbPreUpdater;
		this.cacheName = cacheName;
		this.interceptorsToRegister = interceptorsToRegister;
	}

	public void Dispose()
	{
		//Discarded unreachable code: IL_007d, IL_00d3, IL_00e2, IL_0121, IL_0130, IL_0171, IL_0199, IL_01b8, IL_01c7, IL_01f4, IL_0242, IL_027a, IL_02b2, IL_02c2, IL_02d1, IL_02dc, IL_03e3, IL_03f6, IL_0405, IL_0492, IL_04ca
		int num = 4;
		int num2 = num;
		int num4 = default(int);
		IStartInformation startInformation2 = default(IStartInformation);
		Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>>.Enumerator enumerator = default(Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>>.Enumerator);
		KeyValuePair<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>> current = default(KeyValuePair<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>>);
		int num7 = default(int);
		IStartInformation startInformation = default(IStartInformation);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 2:
				return;
			default:
				if (num4 <= 0)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				try
				{
					int num5;
					if (dbPreUpdater == null)
					{
						num5 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num5 = 1;
						}
						goto IL_0081;
					}
					goto IL_0410;
					IL_0410:
					startInformation2 = (IStartInformation)T2sD6UWPoPtWiVMV8Srj(8.0, IH0KU1WPWyQHRUgMY3pY(D9XWc7WPBP11lQ8Cvy5a(0x5DD55050 ^ 0x5DD75B28)));
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num5 = 0;
					}
					goto IL_0081;
					IL_0081:
					while (true)
					{
						switch (num5)
						{
						case 9:
							return;
						case 10:
							return;
						case 1:
							enumerator = interceptorsToRegister.GetEnumerator();
							num5 = 3;
							continue;
						case 8:
							startInformation2 = (IStartInformation)T2sD6UWPoPtWiVMV8Srj(97.0, SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE102275)));
							num5 = 2;
							continue;
						default:
							try
							{
								InterceptionRegistrationExtensions.LoadCache(interceptorsToRegister.Keys, ProxiesAssemblyCache.GetProxiesAssemblyCaches(cacheName));
								int num11 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
								{
									num11 = 0;
								}
								switch (num11)
								{
								case 0:
									break;
								}
							}
							finally
							{
								int num12;
								if (startInformation2 == null)
								{
									num12 = 2;
									goto IL_019d;
								}
								goto IL_01d2;
								IL_019d:
								switch (num12)
								{
								case 2:
									goto end_IL_0188;
								case 1:
									goto end_IL_0188;
								}
								goto IL_01d2;
								IL_01d2:
								uf9T1cWPbRqW6Fnmrvrq(startInformation2);
								num12 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
								{
									num12 = 1;
								}
								goto IL_019d;
								end_IL_0188:;
							}
							goto case 5;
						case 6:
							if (dbPreUpdater == null)
							{
								num5 = 9;
								continue;
							}
							goto case 8;
						case 2:
							try
							{
								ProxiesAssemblyCache.SaveProxiesAssemblyCaches(InterceptionRegistrationExtensions.SaveCache(), cacheName);
								int num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
								{
									num9 = 0;
								}
								switch (num9)
								{
								case 0:
									break;
								}
								return;
							}
							finally
							{
								if (startInformation2 != null)
								{
									int num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
									{
										num10 = 0;
									}
									while (true)
									{
										switch (num10)
										{
										default:
											uf9T1cWPbRqW6Fnmrvrq(startInformation2);
											num10 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
											{
												num10 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
						case 3:
							try
							{
								while (true)
								{
									int num6;
									if (!enumerator.MoveNext())
									{
										num6 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
										{
											num6 = 5;
										}
										goto IL_02e0;
									}
									goto IL_03a4;
									IL_03a4:
									current = enumerator.Current;
									num6 = 3;
									goto IL_02e0;
									IL_02e0:
									while (true)
									{
										switch (num6)
										{
										case 1:
											num7++;
											num6 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
											{
												num6 = 4;
											}
											continue;
										case 3:
											current.Value.EnableClassInterceptorsCacheable<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>();
											num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
											{
												num6 = 1;
											}
											continue;
										case 4:
											exUVmMWPG6I5cFkTCaJZ(nKIO8MWPh8isNe6MM7Dh(), (double)num7 * 100.0 / (double)num4);
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
											{
												num6 = 0;
											}
											continue;
										case 2:
											goto IL_03a4;
										case 5:
											goto end_IL_0349;
										}
										break;
									}
									continue;
									end_IL_0349:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
								{
									num8 = 0;
								}
								switch (num8)
								{
								case 0:
									break;
								}
							}
							goto case 6;
						case 4:
							break;
						case 5:
						case 7:
							num7 = 0;
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
							{
								num5 = 1;
							}
							continue;
						}
						break;
					}
					goto IL_0410;
				}
				finally
				{
					if (startInformation != null)
					{
						int num13 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num13 = 0;
						}
						while (true)
						{
							switch (num13)
							{
							default:
								uf9T1cWPbRqW6Fnmrvrq(startInformation);
								num13 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
								{
									num13 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 4:
			{
				Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>> dictionary = interceptorsToRegister;
				if (dictionary == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 1;
					}
					continue;
				}
				num3 = FVYVoIWPFhjYL0mSNbt9(dictionary);
				break;
			}
			case 1:
				startInformation = (IStartInformation)T2sD6UWPoPtWiVMV8Srj(100.0, IH0KU1WPWyQHRUgMY3pY(D9XWc7WPBP11lQ8Cvy5a(--1867379187 ^ 0x6F4FFAB1)));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 5;
				}
				continue;
			case 3:
				num3 = 0;
				break;
			}
			num4 = num3;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static int FVYVoIWPFhjYL0mSNbt9(object P_0)
	{
		return ((Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>>)P_0).Count;
	}

	internal static object D9XWc7WPBP11lQ8Cvy5a(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object IH0KU1WPWyQHRUgMY3pY(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object T2sD6UWPoPtWiVMV8Srj(double completePercent, object P_1)
	{
		return StartInformation.Operation(completePercent, (string)P_1);
	}

	internal static void uf9T1cWPbRqW6Fnmrvrq(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object nKIO8MWPh8isNe6MM7Dh()
	{
		return StartInformation.Current;
	}

	internal static void exUVmMWPG6I5cFkTCaJZ(object P_0, double value)
	{
		((IStartInformation)P_0).Percent = value;
	}

	internal static bool iIadErWecdEKS4D7VwnW()
	{
		return DD8kA2WesEYppf5aRtis == null;
	}

	internal static ProxiesAssemblyActivator GoErVFWezZ7KYCwJxdDU()
	{
		return DD8kA2WesEYppf5aRtis;
	}
}
