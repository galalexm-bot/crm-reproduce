using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Actions;

[Serializable]
[DataContract]
public struct ActionCheckResult
{
	private static object XSeoDRftyLqor6TUYmWn;

	public static ActionCheckResult True => new ActionCheckResult(result: true, null);

	[DataMember]
	public bool Result
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
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

	[DataMember]
	public string ErrorMessage
	{
		[CompilerGenerated]
		get
		{
			return _003CErrorMessage_003Ek__BackingField;
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
					_003CErrorMessage_003Ek__BackingField = value;
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

	public static ActionCheckResult False(string errorMessage)
	{
		return new ActionCheckResult(result: false, errorMessage);
	}

	public ActionCheckResult(bool result, string errorMessage)
	{
		//Discarded unreachable code: IL_0005
		SingletonReader.JJCZtPuTvSt();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 3:
				Result = result;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num = 1;
				}
				break;
			default:
				this = default(ActionCheckResult);
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num = 1;
				}
				break;
			case 1:
				ErrorMessage = errorMessage;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public static implicit operator bool(ActionCheckResult actionCheckResult)
	{
		return actionCheckResult.Result;
	}

	internal static bool GJJO1NftMR463jFVQjd6()
	{
		return XSeoDRftyLqor6TUYmWn == null;
	}

	internal static object TwouRKftJLLkitnNWtu0()
	{
		return XSeoDRftyLqor6TUYmWn;
	}
}
