using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
public sealed class PublicApiObsoleteAttribute : Attribute
{
	private readonly string message;

	private readonly bool throwError;

	private static PublicApiObsoleteAttribute SL1m8GoCFc1NPfxGtwFN;

	public string Message => message;

	public bool ThrowError => throwError;

	public PublicApiObsoleteAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nHjDWWoCoxcu7VvoQxNP();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				message = null;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			default:
				throwError = false;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public PublicApiObsoleteAttribute(string message)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
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
				this.message = message;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				throwError = false;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public PublicApiObsoleteAttribute(string message, bool throwError)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nHjDWWoCoxcu7VvoQxNP();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				this.throwError = throwError;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.message = message;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void nHjDWWoCoxcu7VvoQxNP()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool bHd8wBoCBZ8YxgAx5GPC()
	{
		return SL1m8GoCFc1NPfxGtwFN == null;
	}

	internal static PublicApiObsoleteAttribute AYW3UGoCWtrSpbevbMpD()
	{
		return SL1m8GoCFc1NPfxGtwFN;
	}
}
