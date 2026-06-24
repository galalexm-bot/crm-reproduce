using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.BackgroundOperations;

[Serializable]
public abstract class BaseBackgroundOperationWithCallbacks : IBackgroundOperation, ISuccessCallbackInvokable, IErrorCallbackInvokable
{
	private static BaseBackgroundOperationWithCallbacks Ircp7XWcq5E2JG9EUGHF;

	public ICallbackDelegate SuccessCallback
	{
		[CompilerGenerated]
		get
		{
			return _003CSuccessCallback_003Ek__BackingField;
		}
		[CompilerGenerated]
		protected set
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
					_003CSuccessCallback_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ICallbackDelegate ErrorCallback
	{
		[CompilerGenerated]
		get
		{
			return _003CErrorCallback_003Ek__BackingField;
		}
		[CompilerGenerated]
		protected set
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
					_003CErrorCallback_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public BaseBackgroundOperationWithCallbacks()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OewIMRWcTyhRsUIcPXOM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				ErrorCallback = new CallbackDelegate();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			default:
				SuccessCallback = new CallbackDelegate();
				num = 2;
				break;
			}
		}
	}

	internal static void OewIMRWcTyhRsUIcPXOM()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool G8w0xCWcK73XJlhRkaua()
	{
		return Ircp7XWcq5E2JG9EUGHF == null;
	}

	internal static BaseBackgroundOperationWithCallbacks tUJF09WcXWax2xcjIFLx()
	{
		return Ircp7XWcq5E2JG9EUGHF;
	}
}
