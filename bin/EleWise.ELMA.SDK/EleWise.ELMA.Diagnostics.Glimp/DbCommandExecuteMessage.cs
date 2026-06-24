using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Glimpse.Ado.Message;
using Glimpse.Core.Message;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Glimpse;

internal class DbCommandExecuteMessage : CommandExecutedMessage, ITimelineMessage, ITimedMessage, IMessage
{
	internal static DbCommandExecuteMessage VM5xHMEiSsM1pofg3fd8;

	public string EventName
	{
		[CompilerGenerated]
		get
		{
			return _003CEventName_003Ek__BackingField;
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
					_003CEventName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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

	public TimelineCategoryItem EventCategory
	{
		[CompilerGenerated]
		get
		{
			return _003CEventCategory_003Ek__BackingField;
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
					_003CEventCategory_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
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

	public string EventSubText
	{
		[CompilerGenerated]
		get
		{
			return _003CEventSubText_003Ek__BackingField;
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
					_003CEventSubText_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DbCommandExecuteMessage(Guid connectionId, Guid commandId, string commandText, IList<CommandExecutedParamater> parameters, bool hasTransaction)
	{
		SingletonReader.JJCZtPuTvSt();
		((CommandExecutedMessage)this)._002Ector(connectionId, commandId, commandText, parameters, hasTransaction, false);
	}

	internal static bool YwiEF1EiiGYruaFlq38N()
	{
		return VM5xHMEiSsM1pofg3fd8 == null;
	}

	internal static DbCommandExecuteMessage DSlPBKEiRctxj59wId2C()
	{
		return VM5xHMEiSsM1pofg3fd8;
	}
}
