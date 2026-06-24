using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Exceptions;

[Serializable]
public class CustomActivityPublishingException : Exception
{
	private static readonly string CustomActivityHeaderIdFieldName;

	private static readonly string ScriptCompileResultFieldName;

	internal static CustomActivityPublishingException wwLfsGxz2ePqLgNedUs;

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
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long CustomActivityId
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomActivityId_003Ek__BackingField;
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
					_003CCustomActivityId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd != 0)
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

	private static string DefaultMessage => (string)OGpqAhFhbWKvCUXLtoD(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-361150192 ^ -361138058));

	public CustomActivityPublishingException(Exception innerException)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector(DefaultMessage, innerException);
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c8901ad9999948b380523446821824e3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public CustomActivityPublishingException(long caHeaderId, string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		it2UNLFXT9XI3vvsLZG();
		base._002Ector(message);
		int num = 1;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 == 0)
		{
			num = 1;
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
				CustomActivityId = caHeaderId;
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public CustomActivityPublishingException(long caHeaderId, Exception innerException)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		it2UNLFXT9XI3vvsLZG();
		base._002Ector((string)xEaNUKFoC0q2VmIZGxN(), innerException);
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 == 0)
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
			CustomActivityId = caHeaderId;
			num = 1;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2d82a778b0ee4fc0915a368d2259a8f3 != 0)
			{
				num = 0;
			}
		}
	}

	public CustomActivityPublishingException(long caHeaderId, string message, Exception innerException)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		it2UNLFXT9XI3vvsLZG();
		base._002Ector(message, innerException);
		int num = 1;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 == 0)
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
				CustomActivityId = caHeaderId;
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e45b9499c327415a9efec43f507582e4 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public CustomActivityPublishingException(long caHeaderId, ScriptCompileResult scriptCompileResult)
	{
		//Discarded unreachable code: IL_0060, IL_0065
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector((string)yWPPmfFxTl7xSfnC0b8(xEaNUKFoC0q2VmIZGxN(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680549150 ^ -680542662), OGpqAhFhbWKvCUXLtoD(dLFeFaF3nOG03uLRRSL(--230863782 ^ 0xDC2828A))));
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				ScriptCompileResult = scriptCompileResult;
				num = 2;
				continue;
			}
			CustomActivityId = caHeaderId;
			num = 1;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 == 0)
			{
				num = 0;
			}
		}
	}

	protected CustomActivityPublishingException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		it2UNLFXT9XI3vvsLZG();
		base._002Ector(info, context);
		int num = 1;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9f9823be58b94730af510f3472045ea6 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				ScriptCompileResult = (ScriptCompileResult)l8EUQGF89anwvJXQs45(info, ScriptCompileResultFieldName, nkpJtjFF9VaLtAhXFtN(typeof(ScriptCompileResult).TypeHandle));
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 != 0)
				{
					num = 0;
				}
				break;
			default:
				CustomActivityId = NcPKsEFwmg7anUNFk7S(info, CustomActivityHeaderIdFieldName);
				num = 2;
				break;
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
			case 1:
				WDXUDsFsO76XaWeesW1(info, ScriptCompileResultFieldName, ScriptCompileResult);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				info.AddValue(CustomActivityHeaderIdFieldName, CustomActivityId);
				num2 = 3;
				break;
			case 2:
				JjcfWoFtNifyUREoqIo(this, info, context);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	static CustomActivityPublishingException()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				CustomActivityHeaderIdFieldName = (string)dLFeFaF3nOG03uLRRSL(0x532DFB0A ^ 0x532DCADA);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 3:
				it2UNLFXT9XI3vvsLZG();
				num2 = 2;
				break;
			default:
				ScriptCompileResultFieldName = (string)dLFeFaF3nOG03uLRRSL(-402075023 ^ -402071439);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool yiqdtVFETT2VJKNnxRx()
	{
		return wwLfsGxz2ePqLgNedUs == null;
	}

	internal static CustomActivityPublishingException YlqxqSFCglpNpTs4fa8()
	{
		return wwLfsGxz2ePqLgNedUs;
	}

	internal static void it2UNLFXT9XI3vvsLZG()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object xEaNUKFoC0q2VmIZGxN()
	{
		return DefaultMessage;
	}

	internal static object dLFeFaF3nOG03uLRRSL(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object OGpqAhFhbWKvCUXLtoD(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object yWPPmfFxTl7xSfnC0b8(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Type nkpJtjFF9VaLtAhXFtN(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object l8EUQGF89anwvJXQs45(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static long NcPKsEFwmg7anUNFk7S(object P_0, object P_1)
	{
		return ((SerializationInfo)P_0).GetInt64((string)P_1);
	}

	internal static void JjcfWoFtNifyUREoqIo(object P_0, object P_1, StreamingContext P_2)
	{
		((Exception)P_0).GetObjectData((SerializationInfo)P_1, P_2);
	}

	internal static void WDXUDsFsO76XaWeesW1(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
