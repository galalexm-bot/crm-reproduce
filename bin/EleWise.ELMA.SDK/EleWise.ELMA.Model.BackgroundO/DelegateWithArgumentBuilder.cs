using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.BackgroundOperations;

public class DelegateWithArgumentBuilder<TContext, T>
{
	private ICallbackDelegate callbackDelegate;

	private static object nPC9LGWc4rMOUGYMwrw7;

	public DelegateWithArgumentBuilder(ICallbackDelegate callbackDelegate)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.callbackDelegate = callbackDelegate;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void DoNotHandle()
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
				callbackDelegate.DelegateSignature = string.Empty;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				callbackDelegate.ArgumentNames = new string[0];
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void CallFunc(Func<TContext, T, IBackgroundOperation> func)
	{
		CallDelegate(func);
	}

	public void CallMethod(Action<TContext, T> method)
	{
		CallDelegate(method);
	}

	private void CallDelegate(Delegate @delegate)
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					callbackDelegate.DelegateSignature = DelegateHelper.DelegateToString(@delegate);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					DelegateHelper.ThrowIfNotPublic(@delegate);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					callbackDelegate.ArgumentNames = DelegateHelper.GetDelegateArgumentNames(@delegate);
					num2 = 4;
					continue;
				case 3:
					break;
				case 4:
					return;
				}
				break;
			}
			DelegateHelper.ThrowIfAnonymousLambda(@delegate);
			num = 2;
		}
	}

	internal static bool Vl5Vq4Wc6s8PtUK9TvdI()
	{
		return nPC9LGWc4rMOUGYMwrw7 == null;
	}

	internal static object aAQ2LpWcH7caUkmuMC13()
	{
		return nPC9LGWc4rMOUGYMwrw7;
	}
}
