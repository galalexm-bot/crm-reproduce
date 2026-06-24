using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.BackgroundOperations;

[Serializable]
public class CallbackDelegate : ICallbackDelegate
{
	private static CallbackDelegate bjJ6OLWckNstuikM1eOC;

	public string[] ArgumentNames
	{
		[CompilerGenerated]
		get
		{
			return _003CArgumentNames_003Ek__BackingField;
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
					_003CArgumentNames_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
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

	public string DelegateSignature
	{
		[CompilerGenerated]
		get
		{
			return _003CDelegateSignature_003Ek__BackingField;
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
					_003CDelegateSignature_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
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

	public CallbackDelegate()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KS88AIWc2jkYJws5GZvB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				DelegateSignature = string.Empty;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num = 0;
				}
				break;
			default:
				ArgumentNames = new string[0];
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void KS88AIWc2jkYJws5GZvB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ROLWZ3Wcn7qSMxrFF8vw()
	{
		return bjJ6OLWckNstuikM1eOC == null;
	}

	internal static CallbackDelegate vEkvg3WcODyOgVSrcgmY()
	{
		return bjJ6OLWckNstuikM1eOC;
	}
}
