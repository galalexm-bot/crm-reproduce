using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class ExternalDataSourceExecutorConnectionException : Exception
{
	protected const string ExecutorNameKey = "ExecutorName";

	internal static ExternalDataSourceExecutorConnectionException fvGTDUGgLgXbPcFhwgcG;

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
				case 0:
					return;
				case 1:
					_003CExecutorName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ExternalDataSourceExecutorConnectionException(string executorName, Exception innerException)
	{
		//Discarded unreachable code: IL_004a, IL_004f
		EotPHrGgc08F8UhwQE0d();
		base._002Ector(SR.T((string)m16OsnGgzgGvBsalM6r2(-1852837372 ^ -1853103074), executorName), innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
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
			ExecutorName = executorName;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
			{
				num = 0;
			}
		}
	}

	public ExternalDataSourceExecutorConnectionException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		EotPHrGgc08F8UhwQE0d();
		base._002Ector(info, context);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
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
				ExecutorName = (string)N3UpvOG5Fo3dngtL2dls(info, m16OsnGgzgGvBsalM6r2(0x1637C429 ^ 0x1633D2A1));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
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
				base.GetObjectData(info, context);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				GJTG5cG5BerLIDg4S6Sd(info, m16OsnGgzgGvBsalM6r2(0x6DC147B0 ^ 0x6DC55138), ExecutorName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool rUWiuFGgU7u4ga4YlfSn()
	{
		return fvGTDUGgLgXbPcFhwgcG == null;
	}

	internal static ExternalDataSourceExecutorConnectionException jbmsPBGgsAc1vQEyXWLw()
	{
		return fvGTDUGgLgXbPcFhwgcG;
	}

	internal static void EotPHrGgc08F8UhwQE0d()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object m16OsnGgzgGvBsalM6r2(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object N3UpvOG5Fo3dngtL2dls(object P_0, object P_1)
	{
		return ((SerializationInfo)P_0).GetString((string)P_1);
	}

	internal static void GJTG5cG5BerLIDg4S6Sd(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
[Serializable]
public class ExternalDataSourceExecutorConnectionStringException : Exception
{
	protected const string ExecutorNameKey = "ExecutorName";

	private static ExternalDataSourceExecutorConnectionStringException QcUeToG5WYiuvxKN4rDy;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
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

	public ExternalDataSourceExecutorConnectionStringException(string executorName, Exception innerException)
	{
		//Discarded unreachable code: IL_004b, IL_0050
		kUSLAYG5hOfnYbZkTagB();
		base._002Ector(SR.T((string)HarFDYG5G7tfNjVD3n9i(--1360331293 ^ 0x511114B9), executorName), innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
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
			ExecutorName = executorName;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
			{
				num = 1;
			}
		}
	}

	public ExternalDataSourceExecutorConnectionStringException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		kUSLAYG5hOfnYbZkTagB();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
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
				ExecutorName = (string)bi7IekG5EC6HJ2sJLI55(info, HarFDYG5G7tfNjVD3n9i(-234299632 ^ -234042984));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
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
			case 2:
				return;
			default:
				info.AddValue((string)HarFDYG5G7tfNjVD3n9i(-643786247 ^ -643526799), ExecutorName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				nX91AdG5f2Ky8MfviG4B(this, info, context);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool SeN7d6G5our9CBowDwdZ()
	{
		return QcUeToG5WYiuvxKN4rDy == null;
	}

	internal static ExternalDataSourceExecutorConnectionStringException bsu5sSG5bw9mCLo1WtAZ()
	{
		return QcUeToG5WYiuvxKN4rDy;
	}

	internal static void kUSLAYG5hOfnYbZkTagB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object HarFDYG5G7tfNjVD3n9i(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object bi7IekG5EC6HJ2sJLI55(object P_0, object P_1)
	{
		return ((SerializationInfo)P_0).GetString((string)P_1);
	}

	internal static void nX91AdG5f2Ky8MfviG4B(object P_0, object P_1, StreamingContext P_2)
	{
		((Exception)P_0).GetObjectData((SerializationInfo)P_1, P_2);
	}
}
