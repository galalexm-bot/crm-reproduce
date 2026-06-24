using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Serializable]
internal sealed class ThreadJoinCallInfo : AbstractCallInfo, IEmptyCallInfo
{
	private long managedThreadId;

	private string managedThreadName;

	private bool managedThreadIsBackground;

	private static ThreadJoinCallInfo HG18ubGzrR43tbNnMN4t;

	public override string CallType => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710320266);

	public override string Description => (string)QBT8poGzc0Bqovus2tym(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281589404), managedThreadId, managedThreadName, managedThreadIsBackground);

	public bool IsEmpty
	{
		[CompilerGenerated]
		get
		{
			return _003CIsEmpty_003Ek__BackingField;
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
					_003CIsEmpty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ThreadJoinCallInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ThreadJoinCallInfo(Thread thread)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_006e, IL_00e5, IL_0141, IL_0150
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 1:
			return;
		}
		try
		{
			managedThreadId = OUHXp5Gzjc3nkGIlWkyr(thread);
			int num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					managedThreadIsBackground = thread.IsBackground;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 1;
					}
					break;
				default:
					managedThreadName = (string)NAnl9fGzYHmmtcDjvqaS(thread);
					num2 = 2;
					break;
				}
			}
		}
		catch (ThreadStateException exception)
		{
			int num3 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
			{
				num3 = 0;
			}
			while (true)
			{
				switch (num3)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					((ILogger)LmYunUGzLfwbReWAshL2()).Error(Wr3FRSGzsLpbbHbqojHa(c7c7RaGzUtCNqwWYim8F(-475857671 ^ -475604555)), exception);
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num3 = 0;
					}
					break;
				}
			}
		}
	}

	protected override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal static bool mQSdrJGzgOuKAAxnifPD()
	{
		return HG18ubGzrR43tbNnMN4t == null;
	}

	internal static ThreadJoinCallInfo aZR8a5Gz5HbYwtZOl7Ai()
	{
		return HG18ubGzrR43tbNnMN4t;
	}

	internal static int OUHXp5Gzjc3nkGIlWkyr(object P_0)
	{
		return ((Thread)P_0).ManagedThreadId;
	}

	internal static object NAnl9fGzYHmmtcDjvqaS(object P_0)
	{
		return ((Thread)P_0).Name;
	}

	internal static object LmYunUGzLfwbReWAshL2()
	{
		return Logger.Log;
	}

	internal static object c7c7RaGzUtCNqwWYim8F(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Wr3FRSGzsLpbbHbqojHa(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object QBT8poGzc0Bqovus2tym(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}
}
