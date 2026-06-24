using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Events.Audit;

[Serializable]
public class AuditableEventArgs : AuditEventArgs
{
	private static AuditableEventArgs pYZjC3GL76HEooggow4m;

	public object Invoker
	{
		[CompilerGenerated]
		get
		{
			return _003CInvoker_003Ek__BackingField;
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
					_003CInvoker_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Type InvokerType
	{
		[CompilerGenerated]
		get
		{
			return _003CInvokerType_003Ek__BackingField;
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
					_003CInvokerType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
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

	public MethodInfo Method
	{
		[CompilerGenerated]
		get
		{
			return _003CMethod_003Ek__BackingField;
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
					_003CMethod_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
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

	public Dictionary<string, object> Params { get; set; }

	public object Result
	{
		[CompilerGenerated]
		get
		{
			return _003CResult_003Ek__BackingField;
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
					_003CResult_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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

	public override IDictionary<string, object> ExtendedProperties
	{
		get
		{
			IDictionary<string, object> extendedProperties = base.ExtendedProperties;
			extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AFB83E)] = Invoker;
			extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638667527)] = InvokerType;
			extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x638488E9)] = Method;
			extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A738AA5)] = Params;
			extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307C2659)] = Result;
			return extendedProperties;
		}
	}

	public AuditableEventArgs()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Params = new Dictionary<string, object>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool uauZYnGLxKTW97OEpfgS()
	{
		return pYZjC3GL76HEooggow4m == null;
	}

	internal static AuditableEventArgs IEbUBlGL0283sD5eFCUy()
	{
		return pYZjC3GL76HEooggow4m;
	}
}
