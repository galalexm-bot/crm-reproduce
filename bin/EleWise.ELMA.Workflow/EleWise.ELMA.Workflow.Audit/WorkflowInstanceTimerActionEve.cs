using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Audit;

[Uid("3FCF4517-4422-4EE4-99D5-4E0FC6D6A828")]
public class WorkflowInstanceTimerActionEventArgs : EntityActionEventArgs
{
	[Serializable]
	private class InnerData
	{
		internal static object zbwotovWZBWopcyKyEcQ;

		public DateTime _onceExecuteTime
		{
			[CompilerGenerated]
			get
			{
				return _003C_onceExecuteTime_003Ek__BackingField;
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
						_003C_onceExecuteTime_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string _timerName
		{
			[CompilerGenerated]
			get
			{
				return _003C_timerName_003Ek__BackingField;
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
						_003C_timerName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
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

		public InnerData()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool jxXSlbvWvorhGDDBtE8N()
		{
			return zbwotovWZBWopcyKyEcQ == null;
		}

		internal static InnerData RMKLNHvWY7CQbRYYHrTf()
		{
			return (InnerData)zbwotovWZBWopcyKyEcQ;
		}
	}

	private sealed class DeserializationFixBinder : SerializationBinder
	{
		internal static object iea6cgvW8Tc03ZgpPHuH;

		public override Type BindToType(string assemblyName, string typeName)
		{
			//Discarded unreachable code: IL_0090, IL_009f
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!(typeName == (string)N0jIJrvWl9QEKZyalLdM(0x69063C81 ^ 0x6904E359)))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return tCasTRvW0GNmssiyMl8B(typeof(InnerData).TypeHandle);
				default:
					return DEvepavWme3wQS059YGI(Ylg8O6vWySgKgJ9Gi3RS(N0jIJrvWl9QEKZyalLdM(0x1C7F6FED ^ 0x1C7D8F87), typeName, assemblyName));
				}
			}
		}

		public DeserializationFixBinder()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			dwMRHEvWtXA8c7BsX6AG();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object N0jIJrvWl9QEKZyalLdM(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static Type tCasTRvW0GNmssiyMl8B(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object Ylg8O6vWySgKgJ9Gi3RS(object P_0, object P_1, object P_2)
		{
			return string.Format((string)P_0, P_1, P_2);
		}

		internal static Type DEvepavWme3wQS059YGI(object P_0)
		{
			return ReflectionType.GetType((string)P_0);
		}

		internal static bool X0mLDavWs7mkLvdVsnOL()
		{
			return iea6cgvW8Tc03ZgpPHuH == null;
		}

		internal static DeserializationFixBinder lU2oikvWJwkiM31WGXx6()
		{
			return (DeserializationFixBinder)iea6cgvW8Tc03ZgpPHuH;
		}

		internal static void dwMRHEvWtXA8c7BsX6AG()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static WorkflowInstanceTimerActionEventArgs iOgrFWZD76ichtPWUn8v;

	public DateTime OnceExecuteTime
	{
		[CompilerGenerated]
		get
		{
			return _003COnceExecuteTime_003Ek__BackingField;
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
					_003COnceExecuteTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
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

	public string TimerName
	{
		[CompilerGenerated]
		get
		{
			return _003CTimerName_003Ek__BackingField;
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
					_003CTimerName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
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

	protected WorkflowInstanceTimerActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector(entity, objectUid, actionUid);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public WorkflowInstanceTimerActionEventArgs(IEntity entity, IEntity newEntity, Guid actionUid)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector(entity, newEntity, actionUid);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public new static WorkflowInstanceTimerActionEventArgs TryCreate(IEntity old, IEntity @new, Guid actionUid)
	{
		//Discarded unreachable code: IL_0039, IL_0068, IL_0092, IL_00a1, IL_0108, IL_0140, IL_014f
		WorkflowInstanceTimerActionEventArgs result = default(WorkflowInstanceTimerActionEventArgs);
		switch (1)
		{
		case 1:
			try
			{
				WorkflowInstanceTimerActionEventArgs workflowInstanceTimerActionEventArgs = new WorkflowInstanceTimerActionEventArgs(old, @new, actionUid);
				int num = 6;
				while (true)
				{
					switch (num)
					{
					default:
						result = workflowInstanceTimerActionEventArgs;
						num = 3;
						break;
					case 1:
					case 4:
						result = null;
						num = 2;
						break;
					case 6:
						if (workflowInstanceTimerActionEventArgs.Action == null)
						{
							num = 4;
							break;
						}
						goto case 5;
					case 5:
						if (FnlH7dZDF05cFmD0j0Yi(workflowInstanceTimerActionEventArgs) == null)
						{
							num = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
							{
								num = 1;
							}
							break;
						}
						goto default;
					case 2:
						return result;
					case 3:
						return result;
					}
				}
			}
			catch
			{
				int num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return result;
					}
					result = null;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
					{
						num2 = 0;
					}
				}
			}
		default:
			return result;
		}
	}

	public override byte[] GetAdditionalData()
	{
		//Discarded unreachable code: IL_0056, IL_00a5, IL_00c4, IL_00d3, IL_0100, IL_010f
		int num = 4;
		int num2 = num;
		BinaryFormatter binaryFormatter = default(BinaryFormatter);
		MemoryStream memoryStream = default(MemoryStream);
		InnerData innerData = default(InnerData);
		byte[] result = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					YBgKQZZDrY68oRZprLYO(binaryFormatter, memoryStream, innerData);
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return result;
						}
						result = (byte[])ni6mZMZDeTdBvOhwlfDY(memoryStream);
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					int num4;
					if (memoryStream == null)
					{
						num4 = 2;
						goto IL_00a9;
					}
					goto IL_00de;
					IL_00a9:
					switch (num4)
					{
					default:
						goto end_IL_0094;
					case 2:
						goto end_IL_0094;
					case 1:
						break;
					case 0:
						goto end_IL_0094;
					}
					goto IL_00de;
					IL_00de:
					P393OKZDNNpFuKWmlgPS(memoryStream);
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
					{
						num4 = 0;
					}
					goto IL_00a9;
					end_IL_0094:;
				}
			case 4:
			{
				InnerData innerData2 = new InnerData();
				QrHIrkZDiGcgjvXh1C1u(innerData2, OnceExecuteTime);
				PEqpX7ZDI8Usxnu9PyXQ(innerData2, TimerName);
				innerData = innerData2;
				num2 = 3;
				break;
			}
			case 3:
				binaryFormatter = new BinaryFormatter();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return result;
			default:
				memoryStream = (MemoryStream)g4hULTZDayxPbcJHwT9w();
				num2 = 2;
				break;
			}
		}
	}

	public override void SetAdditionalData(byte[] data)
	{
		//Discarded unreachable code: IL_0098, IL_00a7, IL_00d7, IL_011b, IL_0153, IL_018b, IL_019a, IL_01c5, IL_023b, IL_0273, IL_02a3, IL_02b2, IL_02be, IL_02cd, IL_02dd
		int num = 2;
		int num2 = num;
		InnerData innerData = default(InnerData);
		MemoryStream memoryStream2 = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			default:
				OnceExecuteTime = TBkkfhZDhvsrjP3ni6a2(innerData);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				TimerName = innerData._timerName;
				num2 = 6;
				break;
			case 2:
				innerData = null;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			case 6:
				return;
			case 1:
				try
				{
					MemoryStream memoryStream = (MemoryStream)iQ5XbpZDxOLy5HcDUAuu(data, false);
					int num3 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 1:
						try
						{
							innerData = (InnerData)WC4b6ZZDSCKOjJtFkPIh(new BinaryFormatter(), memoryStream);
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						finally
						{
							if (memoryStream != null)
							{
								int num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
								{
									num5 = 1;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										P393OKZDNNpFuKWmlgPS(memoryStream);
										num5 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
										{
											num5 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						break;
					case 0:
						break;
					}
				}
				catch (SerializationException)
				{
					int num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							memoryStream2 = (MemoryStream)iQ5XbpZDxOLy5HcDUAuu(data, false);
							num6 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
							{
								num6 = 0;
							}
							continue;
						case 2:
							try
							{
								BinaryFormatter binaryFormatter = new BinaryFormatter();
								ldBXYbZD1KubqpbBPMQE(binaryFormatter, new DeserializationFixBinder());
								innerData = (InnerData)WC4b6ZZDSCKOjJtFkPIh(binaryFormatter, memoryStream2);
								int num7 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
								{
									num7 = 0;
								}
								switch (num7)
								{
								case 0:
									break;
								}
							}
							finally
							{
								int num8;
								if (memoryStream2 == null)
								{
									num8 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
									{
										num8 = 1;
									}
									goto IL_0277;
								}
								goto IL_028d;
								IL_028d:
								P393OKZDNNpFuKWmlgPS(memoryStream2);
								num8 = 2;
								goto IL_0277;
								IL_0277:
								switch (num8)
								{
								case 1:
									goto end_IL_0252;
								case 2:
									goto end_IL_0252;
								}
								goto IL_028d;
								end_IL_0252:;
							}
							break;
						case 1:
							break;
						}
						break;
					}
				}
				goto case 3;
			case 3:
				if (innerData == null)
				{
					num2 = 4;
					break;
				}
				goto default;
			}
		}
	}

	internal static bool PsgoT8ZD2y934Pk3qyBR()
	{
		return iOgrFWZD76ichtPWUn8v == null;
	}

	internal static WorkflowInstanceTimerActionEventArgs QErFE2ZDo4NfHOdWU8iE()
	{
		return iOgrFWZD76ichtPWUn8v;
	}

	internal static object FnlH7dZDF05cFmD0j0Yi(object P_0)
	{
		return ((AuditEventArgs)P_0).Object;
	}

	internal static void QrHIrkZDiGcgjvXh1C1u(object P_0, DateTime value)
	{
		((InnerData)P_0)._onceExecuteTime = value;
	}

	internal static void PEqpX7ZDI8Usxnu9PyXQ(object P_0, object P_1)
	{
		((InnerData)P_0)._timerName = (string)P_1;
	}

	internal static object g4hULTZDayxPbcJHwT9w()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static void YBgKQZZDrY68oRZprLYO(object P_0, object P_1, object P_2)
	{
		((BinaryFormatter)P_0).Serialize((Stream)P_1, P_2);
	}

	internal static object ni6mZMZDeTdBvOhwlfDY(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void P393OKZDNNpFuKWmlgPS(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object iQ5XbpZDxOLy5HcDUAuu(object P_0, bool P_1)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, P_1);
	}

	internal static object WC4b6ZZDSCKOjJtFkPIh(object P_0, object P_1)
	{
		return ((BinaryFormatter)P_0).Deserialize((Stream)P_1);
	}

	internal static void ldBXYbZD1KubqpbBPMQE(object P_0, object P_1)
	{
		((BinaryFormatter)P_0).Binder = (SerializationBinder)P_1;
	}

	internal static DateTime TBkkfhZDhvsrjP3ni6a2(object P_0)
	{
		return ((InnerData)P_0)._onceExecuteTime;
	}
}
