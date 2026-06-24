using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

[Serializable]
public class Location
{
	private static Location FAuZ7HhPfq3ueTbU2r1J;

	public string FilePath
	{
		[CompilerGenerated]
		get
		{
			return _003CFilePath_003Ek__BackingField;
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
					_003CFilePath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

	public int Character
	{
		[CompilerGenerated]
		get
		{
			return _003CCharacter_003Ek__BackingField;
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
					_003CCharacter_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int Line
	{
		[CompilerGenerated]
		get
		{
			return _003CLine_003Ek__BackingField;
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
					_003CLine_003Ek__BackingField = value;
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

	public override string ToString()
	{
		return (string)yCsB8ehP8I7GMsFpp0BR(new object[6]
		{
			FilePath,
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606654806),
			Line,
			MIF0yyhPvHxyAAdJ2mMf(-1317790512 ^ -1317777888),
			Character,
			MIF0yyhPvHxyAAdJ2mMf(--1867379187 ^ 0x6F4EAC61)
		});
	}

	public Location()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wOdTNAhPZfL5vrXJZdr2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool BcNXM6hPQ26gD2cuxbxI()
	{
		return FAuZ7HhPfq3ueTbU2r1J == null;
	}

	internal static Location xE0psWhPCa71n16GXjCJ()
	{
		return FAuZ7HhPfq3ueTbU2r1J;
	}

	internal static object MIF0yyhPvHxyAAdJ2mMf(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object yCsB8ehP8I7GMsFpp0BR(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static void wOdTNAhPZfL5vrXJZdr2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
