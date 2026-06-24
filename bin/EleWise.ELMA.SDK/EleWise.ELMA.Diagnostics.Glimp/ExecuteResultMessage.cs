using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Glimpse.Core.Message;
using Glimpse.Mvc.Message;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Glimpse;

internal class ExecuteResultMessage : BaseMessage, IExecutionMessage, ISourceMessage, IChildActionMessage, IActionMessage, IMessage, ITimelineMessage, ITimedMessage, IInvokeActionResultMessage
{
	internal static ExecuteResultMessage HLgM6qEibsixcL6v1vTJ;

	public Type ExecutedType
	{
		[CompilerGenerated]
		get
		{
			return _003CExecutedType_003Ek__BackingField;
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
					_003CExecutedType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
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

	public MethodInfo ExecutedMethod
	{
		[CompilerGenerated]
		get
		{
			return _003CExecutedMethod_003Ek__BackingField;
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
					_003CExecutedMethod_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
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

	public string ControllerName
	{
		[CompilerGenerated]
		get
		{
			return _003CControllerName_003Ek__BackingField;
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
					_003CControllerName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
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

	public string ActionName
	{
		[CompilerGenerated]
		get
		{
			return _003CActionName_003Ek__BackingField;
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
					_003CActionName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
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

	public bool IsChildAction
	{
		[CompilerGenerated]
		get
		{
			return _003CIsChildAction_003Ek__BackingField;
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
					_003CIsChildAction_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ExecuteResultMessage()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GqPVdGEiE2ftDBfHxZZJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool M1mXpJEih3G6t80FgG2G()
	{
		return HLgM6qEibsixcL6v1vTJ == null;
	}

	internal static ExecuteResultMessage ADD755EiGot24VBymJam()
	{
		return HLgM6qEibsixcL6v1vTJ;
	}

	internal static void GqPVdGEiE2ftDBfHxZZJ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
