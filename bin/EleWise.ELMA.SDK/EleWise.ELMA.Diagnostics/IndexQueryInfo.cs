using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Counters;
using EleWise.ELMA.Diagnostics.Events;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Serializable]
[DiagnosticEvents(StartEvent = typeof(IndexQueryExecuteStartEvent), EndEvent = typeof(IndexQueryExecuteEndEvent), ErrorEvent = typeof(IndexQueryExecuteErrorEvent))]
public class IndexQueryInfo : AbstractCallInfo, IEmptyCallInfo
{
	internal static IndexQueryInfo HaJ5x4EFgF24pqoivJyi;

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
				case 0:
					return;
				case 1:
					_003CCommandId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					break;
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
				case 1:
					_003CConnectionId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
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

	public string Query
	{
		[CompilerGenerated]
		get
		{
			return _003CQuery_003Ek__BackingField;
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
					_003CQuery_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override string CallType => (string)VMy3FxEFcstkjNiTDm4M(--1418440330 ^ 0x548F86D4);

	public override string Description => Query;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
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

	public IndexQueryInfo(string query)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_0128, IL_0137
		OXqdj1EFY6jtXRhFUpnw();
		base._002Ector();
		int num = 4;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
		{
			num = 5;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				return;
			case 7:
				Query = query;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				ConnectionId = pFDOguEFUbj6Z3QeoGcg();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 4:
				CommandId = vO47J1EFs7LIhim7Wt7Z(query.GetHashCode().ToString());
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num = 6;
				}
				break;
			case 3:
				CommandId = pFDOguEFUbj6Z3QeoGcg();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num = 1;
				}
				break;
			case 5:
				if (!pu2fVsEFLw6a2ak860UO(query))
				{
					num = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num = 2;
					}
					break;
				}
				goto case 3;
			case 6:
				ConnectionId = vO47J1EFs7LIhim7Wt7Z(query.GetHashCode().ToString());
				num = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num = 5;
				}
				break;
			}
		}
	}

	public IndexQueryInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OXqdj1EFY6jtXRhFUpnw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				CommandId = Guid.NewGuid();
				num = 2;
				break;
			case 2:
				ConnectionId = pFDOguEFUbj6Z3QeoGcg();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public override void StartCall(CallContextInfo callContext)
	{
		//Discarded unreachable code: IL_0098, IL_00a7
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					rF8byPEBBjh6voUdbxAv(DiagnosticsManager.Instance.GetCounter<IndexQueriesCounter>());
					num2 = 3;
					break;
				case 3:
					return;
				case 4:
					return;
				default:
					if (!DiagnosticsManager.Enabled)
					{
						return;
					}
					goto end_IL_0012;
				case 5:
					if (!ErNA1fEBFRjTvXJWw51W(raSle8EFziVfAT2CSKUf()))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 6;
				case 1:
					if (!base.IsPerfomed)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					base.StartCall(callContext);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	protected override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int num = 2;
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
				rkOCq8EBWxZ7UDlb0dQs(info, VMy3FxEFcstkjNiTDm4M(-309639236 ^ -309370816), CommandId);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				rkOCq8EBWxZ7UDlb0dQs(info, VMy3FxEFcstkjNiTDm4M(-475857671 ^ -475605781), ConnectionId);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void OXqdj1EFY6jtXRhFUpnw()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool pu2fVsEFLw6a2ak860UO(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static Guid pFDOguEFUbj6Z3QeoGcg()
	{
		return Guid.NewGuid();
	}

	internal static Guid vO47J1EFs7LIhim7Wt7Z(object P_0)
	{
		return ((string)P_0).GetDeterministicGuid();
	}

	internal static bool u7liWjEF5QiiWUexiMqt()
	{
		return HaJ5x4EFgF24pqoivJyi == null;
	}

	internal static IndexQueryInfo j5juHrEFjQvUGXv9YA78()
	{
		return HaJ5x4EFgF24pqoivJyi;
	}

	internal static object VMy3FxEFcstkjNiTDm4M(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object raSle8EFziVfAT2CSKUf()
	{
		return DiagnosticsManager.Instance;
	}

	internal static bool ErNA1fEBFRjTvXJWw51W(object P_0)
	{
		return ((DiagnosticsManager)P_0).CountersEnabled;
	}

	internal static void rF8byPEBBjh6voUdbxAv(object P_0)
	{
		((Delta64Counter)P_0).Increment();
	}

	internal static void rkOCq8EBWxZ7UDlb0dQs(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
