using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class ContractAnnotationAttribute : Attribute
{
	private static ContractAnnotationAttribute UvfRApffqquLgpruHaGy;

	public string Contract
	{
		[CompilerGenerated]
		get
		{
			return _003CContract_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CContract_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool ForceFullStates
	{
		[CompilerGenerated]
		get
		{
			return _003CForceFullStates_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CForceFullStates_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
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

	public ContractAnnotationAttribute([NotNull] string contract)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		PvxCHeffTGwgiRoAP9aA();
		this._002Ector(contract, forceFullStates: false);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Contract = contract;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			default:
				ForceFullStates = forceFullStates;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	internal static void PvxCHeffTGwgiRoAP9aA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool fBXXFBffKyDQoIlluDDA()
	{
		return UvfRApffqquLgpruHaGy == null;
	}

	internal static ContractAnnotationAttribute gDpwg2ffX5Ds1NnswSCd()
	{
		return UvfRApffqquLgpruHaGy;
	}
}
