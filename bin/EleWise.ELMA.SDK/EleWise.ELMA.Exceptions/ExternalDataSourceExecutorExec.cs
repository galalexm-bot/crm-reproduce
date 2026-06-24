using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class ExternalDataSourceExecutorExecuteException : Exception
{
	protected const string ExecutorNameKey = "ExecutorName";

	private static ExternalDataSourceExecutorExecuteException UgE8xyG5QR4UrnGEH1Sf;

	public string ExecutorName
	{
		[CompilerGenerated]
		get
		{
			return _003CExecutorName_003Ek__BackingField;
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
					_003CExecutorName_003Ek__BackingField = value;
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
	}

	public ExternalDataSourceExecutorExecuteException(string executorName, Exception innerException)
	{
		//Discarded unreachable code: IL_004a, IL_004f
		aVoYe2G58ZDmuARpdLkx();
		base._002Ector(SR.T((string)xDBb1gG5ZA1TRVbGWqS3(-740338220 ^ -740605196), executorName), innerException);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
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
				ExecutorName = executorName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public ExternalDataSourceExecutorExecuteException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		aVoYe2G58ZDmuARpdLkx();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
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
			ExecutorName = info.GetString((string)xDBb1gG5ZA1TRVbGWqS3(-787452571 ^ -787186707));
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
			{
				num = 1;
			}
		}
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.GetObjectData(info, context);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				LHbU5WG5uBxsGMCnKs7c(info, xDBb1gG5ZA1TRVbGWqS3(0xE1229CF ^ 0xE163F47), ExecutorName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool HqQ6cDG5CAm8cQw89Jsj()
	{
		return UgE8xyG5QR4UrnGEH1Sf == null;
	}

	internal static ExternalDataSourceExecutorExecuteException jh2IXAG5vjx2bG7n6JEq()
	{
		return UgE8xyG5QR4UrnGEH1Sf;
	}

	internal static void aVoYe2G58ZDmuARpdLkx()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object xDBb1gG5ZA1TRVbGWqS3(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void LHbU5WG5uBxsGMCnKs7c(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
