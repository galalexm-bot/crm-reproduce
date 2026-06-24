using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Threading;

public class BackgroundTask<T> : BackgroundTask
{
	private readonly Func<T> resultFactory;

	internal static object dDK14fBSjb6Ose8027GR;

	public T Result { get; protected set; }

	public BackgroundTask(Func<T> action, Type ownerType, string name, string description, bool useCallSessionOwner = true, bool handleExceptions = true)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(ownerType, name, description, useCallSessionOwner, handleExceptions);
		Contract.ArgumentNotNull(action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867131295));
		resultFactory = action;
	}

	protected override void ExecuteUserDelegate()
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
				Result = resultFactory();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool S3K8O8BSY4b5QfBc7OBf()
	{
		return dDK14fBSjb6Ose8027GR == null;
	}

	internal static object GspkDpBSL8e8UyC8EMTm()
	{
		return dDK14fBSjb6Ose8027GR;
	}
}
public class BackgroundTask
{
	private readonly Action action;

	private readonly Type ownerType;

	private readonly string name;

	private readonly string description;

	private readonly bool useCallSessionOwner;

	private readonly bool handleExceptions;

	private static BackgroundTask nflL6bBiJ5DPLd6fS1Km;

	public Exception ExecutionException
	{
		[CompilerGenerated]
		get
		{
			return _003CExecutionException_003Ek__BackingField;
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
					_003CExecutionException_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public BackgroundTask(Action action, Type ownerType, string name, string description, bool useCallSessionOwner = true, bool handleExceptions = true)
	{
		//Discarded unreachable code: IL_0032, IL_0037
		IjRXKaBil8DVLLNNVDIh();
		this._002Ector(ownerType, name, description, useCallSessionOwner, handleExceptions);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				if (action == null)
				{
					num = 2;
					break;
				}
				this.action = action;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				throw new ArgumentNullException((string)xpP9flBirW5vOPgri2IK(0x5DD55050 ^ 0x5DD449A4));
			case 0:
				return;
			}
		}
	}

	protected BackgroundTask(Type ownerType, string name, string description, bool useCallSessionOwner = true, bool handleExceptions = true)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IjRXKaBil8DVLLNNVDIh();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				this.useCallSessionOwner = useCallSessionOwner;
				num = 4;
				break;
			case 3:
				return;
			case 4:
				this.handleExceptions = handleExceptions;
				num = 3;
				break;
			case 5:
				this.name = name;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num = 0;
				}
				break;
			default:
				this.description = description;
				num = 2;
				break;
			case 1:
				this.ownerType = ownerType;
				num = 5;
				break;
			}
		}
	}

	public void Execute()
	{
		//Discarded unreachable code: IL_004f, IL_0092, IL_00ca, IL_00ed, IL_00fc, IL_0136, IL_0145, IL_0169, IL_0179, IL_01c0, IL_026d, IL_027c
		int num = 1;
		int num2 = num;
		CallContextSessionOwner callContextSessionOwner = default(CallContextSessionOwner);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				DiagnosticsManager.Instance.BackgroundTaskStart(name, ownerType, description);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				int num3;
				if (useCallSessionOwner)
				{
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num3 = 0;
					}
					goto IL_0053;
				}
				goto IL_0173;
				IL_017e:
				object obj = WyKHenBigkWNlkFDyo3k();
				goto IL_0183;
				IL_0053:
				while (true)
				{
					switch (num3)
					{
					case 4:
						return;
					case 1:
						try
						{
							OxoWGWBi5LeeoiUyIvpR(this);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						finally
						{
							int num5;
							if (callContextSessionOwner == null)
							{
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
								{
									num5 = 1;
								}
								goto IL_00ce;
							}
							goto IL_0114;
							IL_0114:
							callContextSessionOwner.Dispose();
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num5 = 0;
							}
							goto IL_00ce;
							IL_00ce:
							while (true)
							{
								switch (num5)
								{
								case 1:
									goto end_IL_00ce;
								default:
									goto IL_0107;
								case 3:
									break;
								case 2:
									goto end_IL_00ce;
								}
								goto IL_0114;
								IL_0107:
								callContextSessionOwner = null;
								num5 = 2;
								continue;
								end_IL_00ce:
								break;
							}
						}
						goto case 3;
					case 3:
						((DiagnosticsManager)GYuRIZBijuugk3oNhFbt()).BackgroundTaskEnd();
						num3 = 4;
						continue;
					case 2:
						break;
					default:
						goto IL_017e;
					}
					break;
				}
				goto IL_0173;
				IL_0173:
				obj = null;
				goto IL_0183;
				IL_0183:
				callContextSessionOwner = (CallContextSessionOwner)obj;
				num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num3 = 1;
				}
				goto IL_0053;
			}
			catch (Exception ex)
			{
				int num6 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num6 = 0;
				}
				while (true)
				{
					switch (num6)
					{
					case 3:
						return;
					case 1:
						throw;
					case 2:
						if (handleExceptions)
						{
							ExecutionException = ex;
							num6 = 3;
							break;
						}
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num6 = 1;
						}
						break;
					case 4:
						((DiagnosticsManager)GYuRIZBijuugk3oNhFbt()).BackgroundTaskError(ex);
						num6 = 2;
						break;
					default:
						Logger.Log.Error(YkSBO7BiY5XQyPE0GWOR(xpP9flBirW5vOPgri2IK(-1459557599 ^ -1459490331), description), ex);
						num6 = 4;
						break;
					}
				}
			}
		}
	}

	protected virtual void ExecuteUserDelegate()
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
				pp7ZbrBiLZAwdAtH54hI(action);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void IjRXKaBil8DVLLNNVDIh()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object xpP9flBirW5vOPgri2IK(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool gpNlO7Bi96Snfq0yMj0V()
	{
		return nflL6bBiJ5DPLd6fS1Km == null;
	}

	internal static BackgroundTask WVba9WBidYvCIZr6raFv()
	{
		return nflL6bBiJ5DPLd6fS1Km;
	}

	internal static object WyKHenBigkWNlkFDyo3k()
	{
		return CallContextSessionOwner.Create();
	}

	internal static void OxoWGWBi5LeeoiUyIvpR(object P_0)
	{
		((BackgroundTask)P_0).ExecuteUserDelegate();
	}

	internal static object GYuRIZBijuugk3oNhFbt()
	{
		return DiagnosticsManager.Instance;
	}

	internal static object YkSBO7BiY5XQyPE0GWOR(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void pp7ZbrBiLZAwdAtH54hI(object P_0)
	{
		P_0();
	}
}
