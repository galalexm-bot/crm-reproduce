using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Actions;

public abstract class DbAction : IDbAction
{
	private ITransformationProvider transform;

	private List<DbAction> subActions;

	private static readonly ILogger DbUpdateLog;

	private static DbAction KXkLEDWKZPfsMxJnbUQD;

	public List<DbAction> SubActions => subActions;

	public string LogMessage
	{
		[CompilerGenerated]
		get
		{
			return _003CLogMessage_003Ek__BackingField;
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
					_003CLogMessage_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected ITransformationProvider Transform => transform;

	public DbAction(ITransformationProvider transform)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.PushGlobal();
		subActions = new List<DbAction>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.transform = transform;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
			{
				num = 1;
			}
		}
	}

	public virtual void Check()
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_006f, IL_00f1, IL_0104, IL_0113
		int num = 2;
		int num2 = num;
		List<DbAction>.Enumerator enumerator = default(List<DbAction>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				enumerator = subActions.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_0073;
						}
						goto IL_009f;
						IL_0073:
						switch (num3)
						{
						case 1:
							break;
						default:
							goto IL_009f;
						case 2:
							return;
						}
						continue;
						IL_009f:
						WnfVyNWKVX76Lv0mjeHf(enumerator.Current);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num3 = 1;
						}
						goto IL_0073;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 0:
				return;
			}
		}
	}

	public virtual void Execute()
	{
		//Discarded unreachable code: IL_002f, IL_003e, IL_0049, IL_00cb, IL_00de, IL_00ed
		int num = 1;
		int num2 = num;
		List<DbAction>.Enumerator enumerator = default(List<DbAction>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = subActions.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 2;
						goto IL_004d;
					}
					goto IL_0063;
					IL_004d:
					switch (num3)
					{
					case 2:
						return;
					case 1:
						break;
					default:
						continue;
					}
					goto IL_0063;
					IL_0063:
					enumerator.Current.Execute();
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num3 = 0;
					}
					goto IL_004d;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	protected void WriteLogMessage()
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
				WriteLogMessage(LogMessage);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected void WriteLogMessage(string message)
	{
		//Discarded unreachable code: IL_007c
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
			case 2:
				return;
			case 1:
				if (o7C0t7WKSlCmkdfNtpgw(message))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				break;
			}
			wJy5l1WKibLXoEGuWkWe(DbUpdateLog, message);
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
			{
				num2 = 2;
			}
		}
	}

	static DbAction()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				SingletonReader.PushGlobal();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				DbUpdateLog = (ILogger)L7t495WKqoRqF2I5ogtu(Ond3RfWKRAisaeffIsbN(0x3CE17B75 ^ 0x3CE08B19));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool sI1RRtWKuFtXhXTW0P7r()
	{
		return KXkLEDWKZPfsMxJnbUQD == null;
	}

	internal static DbAction uUF1a0WKI8y5JMhLpocp()
	{
		return KXkLEDWKZPfsMxJnbUQD;
	}

	internal static void WnfVyNWKVX76Lv0mjeHf(object P_0)
	{
		((DbAction)P_0).Check();
	}

	internal static bool o7C0t7WKSlCmkdfNtpgw(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void wJy5l1WKibLXoEGuWkWe(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static object Ond3RfWKRAisaeffIsbN(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object L7t495WKqoRqF2I5ogtu(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
