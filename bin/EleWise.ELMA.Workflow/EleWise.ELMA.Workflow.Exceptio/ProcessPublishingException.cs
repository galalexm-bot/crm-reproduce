using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Exceptions;

[Serializable]
public class ProcessPublishingException : Exception
{
	internal static ProcessPublishingException N21w31aE3Xn8TGTG6Iw;

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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long ProcessHeaderId
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeaderId_003Ek__BackingField;
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
					_003CProcessHeaderId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private static string DefaultMessage => (string)wyTRMArYsx32YNThPDU(Utb0Z0rOX760qYGEjvQ(-1214182792 ^ -1214226802));

	public ProcessPublishingException(Exception innerException)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		Hwv66Maz3rmCMG2MY6x();
		base._002Ector(DefaultMessage, innerException);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ProcessPublishingException(long processHeaderId, string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		Hwv66Maz3rmCMG2MY6x();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
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
			ProcessHeaderId = processHeaderId;
			num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
			{
				num = 1;
			}
		}
	}

	public ProcessPublishingException(long processHeaderId, Exception innerException)
	{
		//Discarded unreachable code: IL_004b, IL_0050
		Hwv66Maz3rmCMG2MY6x();
		base._002Ector((string)ceH4jNrv00yK1nwIx4s(oQX3AwrK2S4vbCyJktI(), Utb0Z0rOX760qYGEjvQ(0x37F755F5 ^ 0x37F6017F), r57AlZrZqwrF5pIWV4o(innerException)), innerException);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
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
			ProcessHeaderId = processHeaderId;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
			{
				num = 1;
			}
		}
	}

	public ProcessPublishingException(long processHeaderId, string message, Exception innerException)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector(message, innerException);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
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
				ProcessHeaderId = processHeaderId;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ProcessPublishingException(long processHeaderId, ScriptCompileResult scriptCompileResult)
	{
		//Discarded unreachable code: IL_0059, IL_005e
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector((string)ceH4jNrv00yK1nwIx4s(oQX3AwrK2S4vbCyJktI(), Utb0Z0rOX760qYGEjvQ(0x69063C81 ^ 0x6907680B), wyTRMArYsx32YNThPDU(Utb0Z0rOX760qYGEjvQ(-1393899982 ^ -1393847648))));
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				ScriptCompileResult = scriptCompileResult;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 1:
				ProcessHeaderId = processHeaderId;
				num = 2;
				break;
			}
		}
	}

	protected ProcessPublishingException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		Hwv66Maz3rmCMG2MY6x();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				ScriptCompileResult = (ScriptCompileResult)JsPaAbr87wCGc7N0HY4(info, Utb0Z0rOX760qYGEjvQ(-862330810 ^ -862407542), typeof(ScriptCompileResult));
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
				{
					num = 1;
				}
				break;
			case 1:
				ProcessHeaderId = Hlkregrsh9sxjQyGNW6(info, Utb0Z0rOX760qYGEjvQ(-720457373 ^ -720437741));
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
				{
					num = 2;
				}
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
			default:
				return;
			case 1:
				N0d1cGrlhFgbYxOyLjh(info, Utb0Z0rOX760qYGEjvQ(-1600060848 ^ -1600104804), ScriptCompileResult);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				i5uxobr0LndqPD2YkKU(info, Utb0Z0rOX760qYGEjvQ(-1516552726 ^ -1516539238), ProcessHeaderId);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				s407R0rJun33EMZQ4gB(this, info, context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void Hwv66Maz3rmCMG2MY6x()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool b4xmSdawtf4cJj9gqNL()
	{
		return N21w31aE3Xn8TGTG6Iw == null;
	}

	internal static ProcessPublishingException V9w0FPa4f0SIuAmBx67()
	{
		return N21w31aE3Xn8TGTG6Iw;
	}

	internal static object oQX3AwrK2S4vbCyJktI()
	{
		return DefaultMessage;
	}

	internal static object Utb0Z0rOX760qYGEjvQ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object r57AlZrZqwrF5pIWV4o(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object ceH4jNrv00yK1nwIx4s(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object wyTRMArYsx32YNThPDU(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object JsPaAbr87wCGc7N0HY4(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static long Hlkregrsh9sxjQyGNW6(object P_0, object P_1)
	{
		return ((SerializationInfo)P_0).GetInt64((string)P_1);
	}

	internal static void s407R0rJun33EMZQ4gB(object P_0, object P_1, StreamingContext P_2)
	{
		((Exception)P_0).GetObjectData((SerializationInfo)P_1, P_2);
	}

	internal static void N0d1cGrlhFgbYxOyLjh(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static void i5uxobr0LndqPD2YkKU(object P_0, object P_1, long P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
