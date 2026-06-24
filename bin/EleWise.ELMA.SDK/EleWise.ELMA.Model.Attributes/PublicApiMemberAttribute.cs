using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
public class PublicApiMemberAttribute : Attribute
{
	internal static PublicApiMemberAttribute Ly5NAnoQyMFeCUjPKZ6x;

	public string ProxyClassName
	{
		[CompilerGenerated]
		get
		{
			return _003CProxyClassName_003Ek__BackingField;
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
					_003CProxyClassName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
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

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return _003CDescription_003Ek__BackingField;
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
					_003CDescription_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ExampleCode
	{
		[CompilerGenerated]
		get
		{
			return _003CExampleCode_003Ek__BackingField;
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
					_003CExampleCode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PublicApiMemberAttribute(string proxyClassName, string description, string exampleCode)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fYetq9oQ9OYG92NTxGE3();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				ProxyClassName = proxyClassName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				Description = (string)l0bg1SoQdJPBB1F4Wc8P(description);
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num = 2;
				}
				break;
			case 3:
				ExampleCode = (string)l0bg1SoQdJPBB1F4Wc8P(exampleCode);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public PublicApiMemberAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fYetq9oQ9OYG92NTxGE3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool hOkbl9oQMgsRZv5pVim9()
	{
		return Ly5NAnoQyMFeCUjPKZ6x == null;
	}

	internal static PublicApiMemberAttribute b42QBZoQJMwfWMMMyWJC()
	{
		return Ly5NAnoQyMFeCUjPKZ6x;
	}

	internal static void fYetq9oQ9OYG92NTxGE3()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object l0bg1SoQdJPBB1F4Wc8P(object P_0)
	{
		return SR.T((string)P_0);
	}
}
