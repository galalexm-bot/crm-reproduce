using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Exceptions;

[Serializable]
public class GlobalScriptModulePublishingException : Exception
{
	private static readonly string GlobalScriptModuleHeaderIdFieldName;

	private static readonly string ScriptCompileResultFieldName;

	internal static GlobalScriptModulePublishingException wGKS01bq4YMvT8uV0EIG;

	public ScriptCompileResult ScriptCompileResult
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptCompileResult_003Ek__BackingField;
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
					_003CScriptCompileResult_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long GlobalScriptModuleId
	{
		[CompilerGenerated]
		get
		{
			return _003CGlobalScriptModuleId_003Ek__BackingField;
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
					_003CGlobalScriptModuleId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private static string DefaultMessage => (string)AQDFA5bq0U63Ln8bDdTw(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x54896E82));

	public GlobalScriptModulePublishingException(Exception innerException)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(DefaultMessage, innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public GlobalScriptModulePublishingException(long caHeaderId, string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
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
			GlobalScriptModuleId = caHeaderId;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
			{
				num = 1;
			}
		}
	}

	public GlobalScriptModulePublishingException(long caHeaderId, Exception innerException)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		SingletonReader.JJCZtPuTvSt();
		base._002Ector((string)cNAsQabqAbZ949pqIjgG(), innerException);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				GlobalScriptModuleId = caHeaderId;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public GlobalScriptModulePublishingException(long caHeaderId, string message, Exception innerException)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		hFUsvMbq7TfriR8ahPwR();
		base._002Ector(message, innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
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
			GlobalScriptModuleId = caHeaderId;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
			{
				num = 0;
			}
		}
	}

	public GlobalScriptModulePublishingException(long caHeaderId, ScriptCompileResult scriptCompileResult)
	{
		//Discarded unreachable code: IL_005f, IL_0064
		hFUsvMbq7TfriR8ahPwR();
		base._002Ector((string)cEq5s6bqmfY34xGYrqdp(DefaultMessage, dxalh9bqx7B6JcFlRRRJ(-643786247 ^ -643763795), AQDFA5bq0U63Ln8bDdTw(dxalh9bqx7B6JcFlRRRJ(-1765851862 ^ -1765828798))));
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
				GlobalScriptModuleId = caHeaderId;
				num = 2;
				break;
			case 2:
				ScriptCompileResult = scriptCompileResult;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected GlobalScriptModulePublishingException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(info, context);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				ScriptCompileResult = (ScriptCompileResult)aKkEqibqyfJudOdMiKpL(info, ScriptCompileResultFieldName, typeof(ScriptCompileResult));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num = 0;
				}
				break;
			default:
				GlobalScriptModuleId = nthJwCbqMTl4PneZMRh8(info, GlobalScriptModuleHeaderIdFieldName);
				num = 2;
				break;
			case 2:
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
			case 2:
				wicVDkbqJRqWmwehPSfd(this, info, context);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				cZHTfDbqdF8qZJdx6r00(info, GlobalScriptModuleHeaderIdFieldName, GlobalScriptModuleId);
				num2 = 3;
				break;
			case 1:
				q5Pp7Bbq9MteOvhdUs2w(info, ScriptCompileResultFieldName, ScriptCompileResult);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	static GlobalScriptModulePublishingException()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					SingletonReader.JJCZtPuTvSt();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					GlobalScriptModuleHeaderIdFieldName = (string)dxalh9bqx7B6JcFlRRRJ(-105199646 ^ -105379952);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				}
				break;
			}
			ScriptCompileResultFieldName = (string)dxalh9bqx7B6JcFlRRRJ(0x1637C429 ^ 0x16376E8B);
			num = 3;
		}
	}

	internal static bool BvgQJgbq68vyaa0gOdIg()
	{
		return wGKS01bq4YMvT8uV0EIG == null;
	}

	internal static GlobalScriptModulePublishingException weRvYLbqHu3cerErQwgI()
	{
		return wGKS01bq4YMvT8uV0EIG;
	}

	internal static object cNAsQabqAbZ949pqIjgG()
	{
		return DefaultMessage;
	}

	internal static void hFUsvMbq7TfriR8ahPwR()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object dxalh9bqx7B6JcFlRRRJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object AQDFA5bq0U63Ln8bDdTw(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object cEq5s6bqmfY34xGYrqdp(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object aKkEqibqyfJudOdMiKpL(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static long nthJwCbqMTl4PneZMRh8(object P_0, object P_1)
	{
		return ((SerializationInfo)P_0).GetInt64((string)P_1);
	}

	internal static void wicVDkbqJRqWmwehPSfd(object P_0, object P_1, StreamingContext P_2)
	{
		((Exception)P_0).GetObjectData((SerializationInfo)P_1, P_2);
	}

	internal static void q5Pp7Bbq9MteOvhdUs2w(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static void cZHTfDbqdF8qZJdx6r00(object P_0, object P_1, long P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
