using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Counters;
using EleWise.ELMA.Diagnostics.Events;
using EleWise.ELMA.Diagnostics.Statistics;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Serializable]
[DiagnosticEvents(StartEvent = typeof(IndexCallExecuteStartEvent), EndEvent = typeof(IndexCallExecuteEndEvent), ErrorEvent = typeof(IndexCallExecuteErrorEvent))]
public class IndexCallInfo : AbstractCallInfo, IEmptyCallInfo
{
	private static IndexCallInfo W0sImDEFai0jDUa5Mh2l;

	public Guid CommandId
	{
		[CompilerGenerated]
		get
		{
			return _003CCommandId_003Ek__BackingField;
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
					_003CCommandId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
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

	public Guid ConnectionId
	{
		[CompilerGenerated]
		get
		{
			return _003CConnectionId_003Ek__BackingField;
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
					_003CConnectionId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IndexCallsType Call
	{
		[CompilerGenerated]
		get
		{
			return _003CCall_003Ek__BackingField;
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
					_003CCall_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
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

	public bool IsCancel
	{
		[CompilerGenerated]
		get
		{
			return _003CIsCancel_003Ek__BackingField;
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
					_003CIsCancel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
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

	public override string CallType => (string)Vfcd64EF6pSf95ah75uA(-882126494 ^ -881854844);

	public override string Description
	{
		get
		{
			int num = 1;
			int num2 = num;
			IndexCallsType call = default(IndexCallsType);
			while (true)
			{
				switch (num2)
				{
				default:
					return call.ToString();
				case 1:
					call = Call;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

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
				case 1:
					_003CIsEmpty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
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

	public IndexCallInfo(IndexCallsType call)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		F1uLm0EFwS9YTfFSt0fS();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				CommandId = call.GetHashCode().ToString().GetDeterministicGuid();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				Call = call;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num = 1;
				}
				break;
			default:
				ConnectionId = call.GetHashCode().ToString().GetDeterministicGuid();
				num = 3;
				break;
			case 1:
				return;
			}
		}
	}

	public IndexCallInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		F1uLm0EFwS9YTfFSt0fS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
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
				ConnectionId = hwpHa3EF4Nqua3QUkqn2();
				num = 2;
				continue;
			}
			CommandId = Guid.NewGuid();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
			{
				num = 1;
			}
		}
	}

	public override void StartCall(CallContextInfo callContext)
	{
		//Discarded unreachable code: IL_0052, IL_0061, IL_0086, IL_0095
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				base.StartCall(callContext);
				num2 = 3;
				continue;
			case 1:
				return;
			case 3:
				if (base.IsPerfomed)
				{
					num2 = 5;
					continue;
				}
				return;
			case 7:
				return;
			case 2:
				if (!oI41iwEF7brLmTWs2SAn(XTlwOdEFAI1uMw5IwxxG()))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 5:
				if (!megarnEFHrGB4bIkhGty())
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 7;
					}
					continue;
				}
				goto case 2;
			case 6:
				return;
			}
			((DiagnosticsManager)XTlwOdEFAI1uMw5IwxxG()).GetCounter<IndexCallCounter>().Increment();
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
			{
				num2 = 6;
			}
		}
	}

	protected override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				P1rYydEFx0SEHZpmGCuq(info, Vfcd64EF6pSf95ah75uA(0x1DE3DD89 ^ 0x1DE7F59B), ConnectionId);
				num2 = 4;
				break;
			case 4:
				info.AddValue((string)Vfcd64EF6pSf95ah75uA(-882126494 ^ -881854132), Call);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				info.AddValue((string)Vfcd64EF6pSf95ah75uA(-951514650 ^ -951243238), CommandId);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			case 2:
				info.AddValue((string)Vfcd64EF6pSf95ah75uA(-1824388195 ^ -1824119897), IsCancel);
				num2 = 3;
				break;
			}
		}
	}

	internal static void F1uLm0EFwS9YTfFSt0fS()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool QCfU9yEFDxRfDjfXUdm2()
	{
		return W0sImDEFai0jDUa5Mh2l == null;
	}

	internal static IndexCallInfo MtCfDrEFtWM07XiXnZyM()
	{
		return W0sImDEFai0jDUa5Mh2l;
	}

	internal static Guid hwpHa3EF4Nqua3QUkqn2()
	{
		return Guid.NewGuid();
	}

	internal static object Vfcd64EF6pSf95ah75uA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool megarnEFHrGB4bIkhGty()
	{
		return DiagnosticsManager.Enabled;
	}

	internal static object XTlwOdEFAI1uMw5IwxxG()
	{
		return DiagnosticsManager.Instance;
	}

	internal static bool oI41iwEF7brLmTWs2SAn(object P_0)
	{
		return ((DiagnosticsManager)P_0).CountersEnabled;
	}

	internal static void P1rYydEFx0SEHZpmGCuq(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
