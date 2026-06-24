using System;
using System.Collections.Generic;
using System.Data;
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
[DiagnosticEvents(StartEvent = typeof(SqlCommandExecuteStartEvent), EndEvent = typeof(SqlCommandExecuteEndEvent), ErrorEvent = typeof(SqlCommandExecuteErrorEvent))]
public class SqlQueryInfo : AbstractCallInfo, IEmptyCallInfo
{
	[Serializable]
	public class CommandParamater : ISerializable
	{
		private static CommandParamater fmgDpf8SEZpID4mNLVhQ;

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
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
						_003CName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public object Value
		{
			[CompilerGenerated]
			get
			{
				return _003CValue_003Ek__BackingField;
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
						_003CValue_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
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

		public string Type
		{
			[CompilerGenerated]
			get
			{
				return _003CType_003Ek__BackingField;
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
						_003CType_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public int Size
		{
			[CompilerGenerated]
			get
			{
				return _003CSize_003Ek__BackingField;
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
						_003CSize_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			//Discarded unreachable code: IL_0084, IL_0134
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					a5AN5B8S8mNfSmQAhDPj(info, xSp5v18SvodFqkRxqurN(0x463A0F3C ^ 0x463AA968), Value.ToString());
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 1;
					}
					break;
				case 7:
					a5AN5B8S8mNfSmQAhDPj(info, xSp5v18SvodFqkRxqurN(0x5F3078B6 ^ 0x5F304050), Type);
					num2 = 4;
					break;
				default:
					if (!e2KQTn8SC7SCfGmIo1p4(Type))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 4;
				case 9:
					a5AN5B8S8mNfSmQAhDPj(info, xSp5v18SvodFqkRxqurN(0x57A5235E ^ 0x57A5509E), Name);
					num2 = 5;
					break;
				case 8:
					return;
				case 2:
					if (e2KQTn8SC7SCfGmIo1p4(Name))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 9;
				case 4:
					K1KwMK8SZXJ861HwPBcB(info, xSp5v18SvodFqkRxqurN(-1633514411 ^ -1633649847), Size);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
				case 5:
					if (Value == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 6;
				}
			}
		}

		public CommandParamater()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			Vw5JNm8Suy6IrKYfL60Q();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool VjRerM8SfwnhIBOmocOW()
		{
			return fmgDpf8SEZpID4mNLVhQ == null;
		}

		internal static CommandParamater Lvrg5g8SQ8eQTReO37hJ()
		{
			return fmgDpf8SEZpID4mNLVhQ;
		}

		internal static bool e2KQTn8SC7SCfGmIo1p4(object P_0)
		{
			return ((string)P_0).IsNullOrEmpty();
		}

		internal static object xSp5v18SvodFqkRxqurN(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void a5AN5B8S8mNfSmQAhDPj(object P_0, object P_1, object P_2)
		{
			((SerializationInfo)P_0).AddValue((string)P_1, P_2);
		}

		internal static void K1KwMK8SZXJ861HwPBcB(object P_0, object P_1, int P_2)
		{
			((SerializationInfo)P_0).AddValue((string)P_1, P_2);
		}

		internal static void Vw5JNm8Suy6IrKYfL60Q()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	internal static SqlQueryInfo cwNl4qEWr0tQJvTqiJfY;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
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
				case 1:
					_003CConnectionId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
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

	public string Sql
	{
		[CompilerGenerated]
		get
		{
			return _003CSql_003Ek__BackingField;
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
					_003CSql_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IList<CommandParamater> Paramaters { get; set; }

	public long? RowsAffected { get; set; }

	public override string CallType => (string)MgOJtCEWUEhsNIENkSqG(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307AB4EF), IsPrepare ? H9QCMoEWLvDLdtqcyavm(0x17ADCCD8 ^ 0x17A9E790) : "");

	public override string Description => Sql;

	public TimeSpan ReadTime
	{
		[CompilerGenerated]
		get
		{
			return _003CReadTime_003Ek__BackingField;
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
					_003CReadTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsPrepare
	{
		[CompilerGenerated]
		get
		{
			return _003CIsPrepare_003Ek__BackingField;
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
					_003CIsPrepare_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
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
				case 0:
					return;
				case 1:
					_003CIsEmpty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public SqlQueryInfo(IDbCommand command)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QbYdSaEWjaHuiwQIsTDe();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
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
			SetDbCommand(command);
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
			{
				num = 0;
			}
		}
	}

	public SqlQueryInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QbYdSaEWjaHuiwQIsTDe();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				CommandId = Guid.NewGuid();
				num = 3;
				break;
			case 1:
				return;
			case 3:
				ConnectionId = Nk4F6dEWYZVDPdN1vIAS();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num = 0;
				}
				break;
			default:
				Paramaters = new List<CommandParamater>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void SetDbCommand(IDbCommand command)
	{
		//Discarded unreachable code: IL_006a, IL_0079, IL_008a, IL_0099
		int num = 8;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				ConnectionId = Nk4F6dEWYZVDPdN1vIAS();
				num2 = 5;
				break;
			case 2:
				return;
			case 9:
				Paramaters = ((IDataParameterCollection)aylKfkEWzlZlyDnr470g(command)).AsQueryInfoCommandParamaters();
				num2 = 2;
				break;
			case 11:
				return;
			case 7:
				CommandId = VD3XpvEWsS6Nf2KElV4l(command.GetHashCode().ToString());
				num2 = 12;
				break;
			case 3:
				ConnectionId = Nk4F6dEWYZVDPdN1vIAS();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 10;
				}
				break;
			case 12:
				if (QmFOJlEWcIk4RXrVvrlr(command) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				ConnectionId = VD3XpvEWsS6Nf2KElV4l(command.Connection.GetHashCode().ToString());
				num2 = 4;
				break;
			case 1:
				CommandId = Nk4F6dEWYZVDPdN1vIAS();
				num2 = 6;
				break;
			case 4:
			case 10:
				Sql = command.CommandText;
				num2 = 9;
				break;
			case 8:
				if (command != null)
				{
					num2 = 7;
					break;
				}
				goto case 1;
			case 5:
				Paramaters = new List<CommandParamater>();
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 11;
				}
				break;
			}
		}
	}

	public override void StartCall(CallContextInfo callContext)
	{
		//Discarded unreachable code: IL_007a, IL_0089, IL_00be, IL_00cd
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				base.StartCall(callContext);
				num2 = 2;
				continue;
			case 7:
				if (DiagnosticsManager.Enabled)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 1:
				return;
			case 2:
				if (!base.IsPerfomed)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 4:
				return;
			case 5:
				wYbksbEoW9MT3rqLT88F(DiagnosticsManager.Instance.GetCounter<DatabaseQueriesCounter>());
				num2 = 6;
				continue;
			default:
				if (!TOR2tZEoBtM6JLMlwIo1(WajqjrEoFJyiK7GXYa6u()))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 5;
			case 6:
				return;
			case 8:
				break;
			}
			if (IsPrepare)
			{
				break;
			}
			num2 = 7;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
			{
				num2 = 4;
			}
		}
	}

	protected override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_00be, IL_00cd, IL_017e, IL_018d
		int num = 7;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837935137), IsPrepare);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 10;
				}
				break;
			case 8:
				if (Paramaters == null)
				{
					num2 = 9;
					break;
				}
				goto case 1;
			case 5:
				info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398931456), Paramaters);
				num2 = 3;
				break;
			default:
				HKBAqyEoopAF946ll8uw(info, H9QCMoEWLvDLdtqcyavm(-740338220 ^ -740590012), ReadTime);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
			case 3:
			case 9:
				HKBAqyEoopAF946ll8uw(info, H9QCMoEWLvDLdtqcyavm(-606654180 ^ -606922136), RowsAffected);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (Ct3gOFEobCGaK3Mk73ks(Paramaters) <= 0)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 7:
				HKBAqyEoopAF946ll8uw(info, H9QCMoEWLvDLdtqcyavm(-787452571 ^ -787199335), CommandId);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 6;
				}
				break;
			case 10:
				return;
			case 6:
				HKBAqyEoopAF946ll8uw(info, H9QCMoEWLvDLdtqcyavm(0x1ECE530A ^ 0x1ECA7B18), ConnectionId);
				num2 = 8;
				break;
			}
		}
	}

	internal static void QbYdSaEWjaHuiwQIsTDe()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool dMoVmOEWgAm2RZbUKlRi()
	{
		return cwNl4qEWr0tQJvTqiJfY == null;
	}

	internal static SqlQueryInfo AtbvZYEW5wfIcGir7N5I()
	{
		return cwNl4qEWr0tQJvTqiJfY;
	}

	internal static Guid Nk4F6dEWYZVDPdN1vIAS()
	{
		return Guid.NewGuid();
	}

	internal static object H9QCMoEWLvDLdtqcyavm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object MgOJtCEWUEhsNIENkSqG(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static Guid VD3XpvEWsS6Nf2KElV4l(object P_0)
	{
		return ((string)P_0).GetDeterministicGuid();
	}

	internal static object QmFOJlEWcIk4RXrVvrlr(object P_0)
	{
		return ((IDbCommand)P_0).Connection;
	}

	internal static object aylKfkEWzlZlyDnr470g(object P_0)
	{
		return ((IDbCommand)P_0).Parameters;
	}

	internal static object WajqjrEoFJyiK7GXYa6u()
	{
		return DiagnosticsManager.Instance;
	}

	internal static bool TOR2tZEoBtM6JLMlwIo1(object P_0)
	{
		return ((DiagnosticsManager)P_0).CountersEnabled;
	}

	internal static void wYbksbEoW9MT3rqLT88F(object P_0)
	{
		((Delta64Counter)P_0).Increment();
	}

	internal static void HKBAqyEoopAF946ll8uw(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static int Ct3gOFEobCGaK3Mk73ks(object P_0)
	{
		return ((ICollection<CommandParamater>)P_0).Count;
	}
}
