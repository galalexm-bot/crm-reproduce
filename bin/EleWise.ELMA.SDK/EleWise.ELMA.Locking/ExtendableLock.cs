using System;
using System.Threading;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Locking;

public class ExtendableLock : Lock
{
	private int extend;

	private Timer extendTimer;

	private readonly Action extendLockAction;

	private static ExtendableLock NuGaRChgCDhiYmjm0lQd;

	public virtual int ExtendCount => extend;

	public ExtendableLock(string name, TimeSpan ttl, Action extendLockAction, Action releaseLockAction)
	{
		//Discarded unreachable code: IL_002e, IL_0033, IL_009f, IL_00ae
		jSSuZFhgZswU0g1WgYf6();
		base._002Ector(name, ttl, releaseLockAction);
		int num = 5;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				if (extendLockAction == null)
				{
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num = 3;
					}
					break;
				}
				goto case 1;
			case 1:
				Start();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			case 3:
				return;
			case 4:
				this.extendLockAction = extendLockAction;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num = 0;
				}
				break;
			case 5:
				extend = 0;
				num = 4;
				break;
			}
		}
	}

	public override void Dispose()
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_00c5
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				return;
			case 2:
				if (base.Count == 1)
				{
					num2 = 5;
					break;
				}
				goto case 1;
			case 0:
				return;
			case 1:
			case 4:
				base.Dispose();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (extendTimer == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 9;
			case 7:
				extendTimer = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				extendTimer.Change(-1, -1);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 8;
				}
				break;
			case 3:
				if (disposed)
				{
					return;
				}
				num2 = 2;
				break;
			case 8:
				extendTimer.Dispose();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void Start()
	{
		int num = 1;
		int num2 = num;
		double num3 = default(double);
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			switch (num2)
			{
			case 3:
				extendTimer = new Timer(delegate
				{
					//Discarded unreachable code: IL_004a, IL_00c2, IL_011f, IL_012e
					switch (1)
					{
					case 1:
						try
						{
							int num4;
							if (extendLockAction != null)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
								{
									num4 = 0;
								}
								goto IL_004e;
							}
							goto IL_0064;
							IL_0064:
							extend++;
							num4 = 2;
							goto IL_004e;
							IL_004e:
							while (true)
							{
								switch (num4)
								{
								case 1:
									break;
								default:
									oZjXvEhguD5HHTaIljkp(extendLockAction);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
									{
										num4 = 1;
									}
									continue;
								case 2:
									return;
								}
								break;
							}
							goto IL_0064;
						}
						catch (Exception ex)
						{
							int num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									return;
								case 1:
									H7wxKHhgSCZlnW8Bksmx(Ai7vHdhgIY3btg1L39ii(), Q8MmpThgVDkKEL0G4q9Z(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138186070), Name), ex);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
									{
										num5 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						}
					case 0:
						break;
					}
				}, null, (int)num3, (int)num3);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				num3 = timeSpan.TotalMilliseconds / 2.0;
				num2 = 3;
				break;
			case 1:
				timeSpan = ttl;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void jSSuZFhgZswU0g1WgYf6()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool iDwJ2yhgvJO1j2IJxByd()
	{
		return NuGaRChgCDhiYmjm0lQd == null;
	}

	internal static ExtendableLock AauHYghg8oHnWpixopcf()
	{
		return NuGaRChgCDhiYmjm0lQd;
	}

	internal static void oZjXvEhguD5HHTaIljkp(object P_0)
	{
		P_0();
	}

	internal static object Ai7vHdhgIY3btg1L39ii()
	{
		return Logger.Log;
	}

	internal static object Q8MmpThgVDkKEL0G4q9Z(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void H7wxKHhgSCZlnW8Bksmx(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}
}
