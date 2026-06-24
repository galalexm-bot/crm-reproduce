using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Audit;

[Uid("{9AA0C4B5-7883-41F8-A974-F6E34721DF98}")]
public class WorkflowMessageReceiveActionEventArgs : EntityActionEventArgs
{
	[Serializable]
	private class MessageReceiveInnerData
	{
		internal static object OjYe0xpaVh2wMldJymh;

		public string ElementName
		{
			[CompilerGenerated]
			get
			{
				return _003CElementName_003Ek__BackingField;
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
						_003CElementName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d != 0)
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

		public long MessageTypeId
		{
			[CompilerGenerated]
			get
			{
				return _003CMessageTypeId_003Ek__BackingField;
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
						_003CMessageTypeId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 == 0)
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

		public string ControlParameterValue
		{
			[CompilerGenerated]
			get
			{
				return _003CControlParameterValue_003Ek__BackingField;
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
						_003CControlParameterValue_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public MessageReceiveInnerData()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_476f57418da6445caf8a3854ac0b8f67 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool ydS02wpYaR9pNXyFYaj()
		{
			return OjYe0xpaVh2wMldJymh == null;
		}

		internal static MessageReceiveInnerData IfBu4tpvNqHbXnRqdmb()
		{
			return (MessageReceiveInnerData)OjYe0xpaVh2wMldJymh;
		}
	}

	internal static WorkflowMessageReceiveActionEventArgs STv0iK8PoSfwAnTcmQ1;

	public string ElementName
	{
		[CompilerGenerated]
		get
		{
			return _003CElementName_003Ek__BackingField;
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
					_003CElementName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_76260b548c684c6c95eb679c837b8945 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long MessageTypeId
	{
		[CompilerGenerated]
		get
		{
			return _003CMessageTypeId_003Ek__BackingField;
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
					_003CMessageTypeId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ControlParameterValue
	{
		[CompilerGenerated]
		get
		{
			return _003CControlParameterValue_003Ek__BackingField;
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
					_003CControlParameterValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected WorkflowMessageReceiveActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		gt18hg8TnWbdY3TWhpL();
		base._002Ector(entity, objectUid, actionUid);
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public WorkflowMessageReceiveActionEventArgs(IEntity entity, IEntity newEntity, Guid actionUid)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		gt18hg8TnWbdY3TWhpL();
		base._002Ector(entity, newEntity, actionUid);
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public new static WorkflowMessageReceiveActionEventArgs TryCreate(IEntity old, IEntity @new, Guid actionUid)
	{
		//Discarded unreachable code: IL_0039, IL_006c, IL_00c4, IL_00d3, IL_0101, IL_012b, IL_0163, IL_0172
		WorkflowMessageReceiveActionEventArgs result = default(WorkflowMessageReceiveActionEventArgs);
		switch (1)
		{
		case 1:
			try
			{
				WorkflowMessageReceiveActionEventArgs workflowMessageReceiveActionEventArgs = new WorkflowMessageReceiveActionEventArgs(old, @new, actionUid);
				int num = 4;
				while (true)
				{
					switch (num)
					{
					case 2:
					case 5:
						result = null;
						num = 3;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 == 0)
						{
							num = 2;
						}
						break;
					case 4:
						if (tw9LCi8c0Gcn9sxsjX1(workflowMessageReceiveActionEventArgs) == null)
						{
							num = 5;
							break;
						}
						goto case 1;
					case 1:
						if (workflowMessageReceiveActionEventArgs.Object != null)
						{
							num = 6;
							break;
						}
						goto case 2;
					case 6:
					case 7:
						result = workflowMessageReceiveActionEventArgs;
						num = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
						{
							num = 0;
						}
						break;
					default:
						return result;
					case 0:
						return result;
					case 3:
						return result;
					}
				}
			}
			catch
			{
				int num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8a653485701e45079b9af8815b59e5f3 != 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						result = null;
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
						{
							num2 = 0;
						}
						break;
					default:
						return result;
					case 0:
						return result;
					}
				}
			}
		default:
			return result;
		}
	}

	public override byte[] GetAdditionalData()
	{
		//Discarded unreachable code: IL_00c0, IL_011f, IL_0157, IL_0166
		int num = 3;
		int num2 = num;
		MessageReceiveInnerData messageReceiveInnerData = default(MessageReceiveInnerData);
		BinaryFormatter binaryFormatter = default(BinaryFormatter);
		byte[] result = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 3:
			{
				MessageReceiveInnerData messageReceiveInnerData2 = new MessageReceiveInnerData();
				Fc4ZRD8N4YArMbykpLZ(messageReceiveInnerData2, ElementName);
				messageReceiveInnerData2.MessageTypeId = MessageTypeId;
				b2YwfA8dLkYEOD8aH4c(messageReceiveInnerData2, ControlParameterValue);
				messageReceiveInnerData = messageReceiveInnerData2;
				num2 = 2;
				break;
			}
			case 2:
				binaryFormatter = new BinaryFormatter();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return result;
			default:
				memoryStream = (MemoryStream)BL0e6v8jKs6Apuuctd0();
				num2 = 4;
				break;
			case 4:
				try
				{
					KKPEmB8SIf4q6mm2KgC(binaryFormatter, memoryStream, messageReceiveInnerData);
					int num3 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 != 0)
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
						result = (byte[])Ri2l8y8kHAqsaRJ9Lhl(memoryStream);
						num3 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 == 0)
						{
							num3 = 0;
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								((IDisposable)memoryStream).Dispose();
								num4 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f != 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			}
		}
	}

	public override void SetAdditionalData(byte[] data)
	{
		//Discarded unreachable code: IL_0057, IL_0110, IL_0148, IL_0157
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				memoryStream = (MemoryStream)sOxVGj8bdUXU2TGu01K(data, false);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				MessageReceiveInnerData messageReceiveInnerData = (MessageReceiveInnerData)new BinaryFormatter().Deserialize(memoryStream);
				int num3 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3ccbd21470394457949c11be6f557154 != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 0:
						return;
					case 3:
						MessageTypeId = messageReceiveInnerData.MessageTypeId;
						num3 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc == 0)
						{
							num3 = 2;
						}
						break;
					case 2:
						ControlParameterValue = (string)RGmVVP8UMOg0KdXpZl1(messageReceiveInnerData);
						num3 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
						{
							num3 = 0;
						}
						break;
					case 1:
						ElementName = messageReceiveInnerData.ElementName;
						num3 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc == 0)
						{
							num3 = 3;
						}
						break;
					}
				}
			}
			finally
			{
				if (memoryStream != null)
				{
					int num4 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_520732c4e13f4c5b8eebfda6fa186589 != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							((IDisposable)memoryStream).Dispose();
							num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1fcd5b77d5534d528c98a4d02b302a40 == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	internal static bool g8Ic0c84a9bSDhGXfmb()
	{
		return STv0iK8PoSfwAnTcmQ1 == null;
	}

	internal static WorkflowMessageReceiveActionEventArgs zZmZJn89CRfIGjmNDJl()
	{
		return STv0iK8PoSfwAnTcmQ1;
	}

	internal static void gt18hg8TnWbdY3TWhpL()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object tw9LCi8c0Gcn9sxsjX1(object P_0)
	{
		return ((AuditEventArgs)P_0).Action;
	}

	internal static void Fc4ZRD8N4YArMbykpLZ(object P_0, object P_1)
	{
		((MessageReceiveInnerData)P_0).ElementName = (string)P_1;
	}

	internal static void b2YwfA8dLkYEOD8aH4c(object P_0, object P_1)
	{
		((MessageReceiveInnerData)P_0).ControlParameterValue = (string)P_1;
	}

	internal static object BL0e6v8jKs6Apuuctd0()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static void KKPEmB8SIf4q6mm2KgC(object P_0, object P_1, object P_2)
	{
		((BinaryFormatter)P_0).Serialize((Stream)P_1, P_2);
	}

	internal static object Ri2l8y8kHAqsaRJ9Lhl(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static object sOxVGj8bdUXU2TGu01K(object P_0, bool P_1)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, P_1);
	}

	internal static object RGmVVP8UMOg0KdXpZl1(object P_0)
	{
		return ((MessageReceiveInnerData)P_0).ControlParameterValue;
	}
}
