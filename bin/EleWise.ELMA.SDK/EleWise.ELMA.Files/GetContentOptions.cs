using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Files;

public class GetContentOptions
{
	public static readonly GetContentOptions Default;

	public static readonly GetContentOptions NonSeekable;

	public static readonly GetContentOptions NonSeekableForAsync;

	internal static GetContentOptions E3V9xrGXvaCt0cpga9Bc;

	public bool ForAsync
	{
		[CompilerGenerated]
		get
		{
			return _003CForAsync_003Ek__BackingField;
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
					_003CForAsync_003Ek__BackingField = value;
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

	public bool Seekable
	{
		[CompilerGenerated]
		get
		{
			return _003CSeekable_003Ek__BackingField;
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
					_003CSeekable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public GetContentOptions()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				ForAsync = false;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num = 1;
				}
				break;
			case 1:
				Seekable = true;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	static GetContentOptions()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				NonSeekable = new GetContentOptions
				{
					Seekable = false
				};
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
			{
				GetContentOptions getContentOptions = new GetContentOptions();
				nqd3amGXIsEnZgAoSX6Z(getContentOptions, false);
				tCy62bGXVq2oYbyo3A9n(getContentOptions, true);
				NonSeekableForAsync = getContentOptions;
				num2 = 3;
				break;
			}
			case 3:
				return;
			default:
				Default = new GetContentOptions();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				I5UIRUGXuaVGOkJvnTMC();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool otOBbHGX8VSj2DoiGqR8()
	{
		return E3V9xrGXvaCt0cpga9Bc == null;
	}

	internal static GetContentOptions c36PLuGXZDUGY6Mw8Cge()
	{
		return E3V9xrGXvaCt0cpga9Bc;
	}

	internal static void I5UIRUGXuaVGOkJvnTMC()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void nqd3amGXIsEnZgAoSX6Z(object P_0, bool value)
	{
		((GetContentOptions)P_0).Seekable = value;
	}

	internal static void tCy62bGXVq2oYbyo3A9n(object P_0, bool value)
	{
		((GetContentOptions)P_0).ForAsync = value;
	}
}
