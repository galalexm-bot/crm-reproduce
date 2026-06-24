using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[BaseTypeRequired(typeof(Attribute))]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class BaseTypeRequiredAttribute : Attribute
{
	internal static BaseTypeRequiredAttribute YfGcZlff3F8W75KugYP9;

	[NotNull]
	public Type BaseType
	{
		[CompilerGenerated]
		get
		{
			return _003CBaseType_003Ek__BackingField;
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
					_003CBaseType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
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

	public BaseTypeRequiredAttribute([NotNull] Type baseType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FmsDMcffDN28esGhm5yU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
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
				BaseType = baseType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void FmsDMcffDN28esGhm5yU()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool J2IgaiffpKG5n6gdxENV()
	{
		return YfGcZlff3F8W75KugYP9 == null;
	}

	internal static BaseTypeRequiredAttribute vSH1wfffafJiFJNixdYg()
	{
		return YfGcZlff3F8W75KugYP9;
	}
}
