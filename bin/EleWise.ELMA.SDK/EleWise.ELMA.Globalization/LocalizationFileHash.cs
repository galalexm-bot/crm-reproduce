using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Globalization;

[Serializable]
public class LocalizationFileHash
{
	private static LocalizationFileHash WppoFqGhEQbLkg73jL8C;

	public string FileName
	{
		[CompilerGenerated]
		get
		{
			return _003CFileName_003Ek__BackingField;
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
					_003CFileName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public byte[] Hash
	{
		[CompilerGenerated]
		get
		{
			return _003CHash_003Ek__BackingField;
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
					_003CHash_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
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

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_00a2, IL_00b1, IL_00d0, IL_00df
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 1:
				if (this == obj)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 1;
					}
					break;
				}
				if (!aqQ9pAGhCFYwoKgAVJMZ(obj.GetType(), typeof(LocalizationFileHash)))
				{
					num2 = 4;
					break;
				}
				goto case 5;
			case 2:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				return true;
			case 5:
				return false;
			case 4:
				return Equals((LocalizationFileHash)obj);
			}
		}
	}

	public bool Equals(LocalizationFileHash other)
	{
		//Discarded unreachable code: IL_008a, IL_0099, IL_0152, IL_0161, IL_0171
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (other != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 12;
			case 5:
			case 10:
				if (other.Hash == null)
				{
					num2 = 11;
					break;
				}
				goto default;
			case 11:
				if (Hash == null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 9:
				if (hjRbNRGhvCiQFpZ8uZ2Y(other) != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto IL_01a6;
			case 4:
				if (FileName == null)
				{
					num2 = 10;
					break;
				}
				goto case 9;
			case 3:
				return true;
			case 12:
				return false;
			case 1:
				if (this != other)
				{
					if (hjRbNRGhvCiQFpZ8uZ2Y(other) == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 9;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (rlWywjGhZetuneAvCW1C(other) != null)
				{
					num2 = 8;
					break;
				}
				return false;
			case 8:
				return ((IEnumerable<byte>)rlWywjGhZetuneAvCW1C(other)).SequenceEqual(Hash);
			case 7:
				return true;
			case 6:
				{
					if (TCPkJmGh8jDrLvmKOmdG(hjRbNRGhvCiQFpZ8uZ2Y(other), FileName, StringComparison.OrdinalIgnoreCase))
					{
						num2 = 5;
						break;
					}
					goto IL_01a6;
				}
				IL_01a6:
				return false;
			}
		}
	}

	protected static int ByteArrayHashCode(byte[] bytes)
	{
		//Discarded unreachable code: IL_004d, IL_00e4, IL_00f3
		int num = 1;
		byte obj = default(byte);
		byte[] array = default(byte[]);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					obj = array[num4];
					num = 7;
					break;
				case 1:
					if (bytes != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 2:
				case 10:
					if (num4 >= array.Length)
					{
						num2 = 4;
						continue;
					}
					goto case 9;
				case 5:
					return 0;
				default:
					num3 = 17;
					num2 = 8;
					continue;
				case 6:
					num4 = 0;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					array = bytes;
					num = 6;
					break;
				case 7:
					num3 = num3 * 31 + EqualityComparer<byte>.Default.GetHashCode(obj);
					num2 = 3;
					continue;
				case 3:
					num4++;
					num2 = 10;
					continue;
				case 4:
					return num3;
				}
				break;
			}
		}
	}

	public override int GetHashCode()
	{
		//Discarded unreachable code: IL_0061
		int num = 1;
		int num2 = num;
		int hashCode;
		ArrayEqualityComparer<byte> arrayEqualityComparer = default(ArrayEqualityComparer<byte>);
		while (true)
		{
			switch (num2)
			{
			default:
				if (FileName == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 2;
					}
					continue;
				}
				hashCode = FileName.GetHashCode();
				break;
			case 2:
				hashCode = typeof(string).GetHashCode();
				break;
			case 1:
				arrayEqualityComparer = new ArrayEqualityComparer<byte>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				continue;
			}
			break;
		}
		return (hashCode * 384) ^ ((Hash != null) ? arrayEqualityComparer.GetHashCode(Hash) : Yti6hqGhuZGE8uRDIusO(typeof(byte[]).TypeHandle).GetHashCode());
	}

	public LocalizationFileHash()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yMK9IKGhI01TyAfCyBBT();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool wBwDfZGhfksNOfo0pZrs()
	{
		return WppoFqGhEQbLkg73jL8C == null;
	}

	internal static LocalizationFileHash nyK2wcGhQ46wgtJGXSRh()
	{
		return WppoFqGhEQbLkg73jL8C;
	}

	internal static bool aqQ9pAGhCFYwoKgAVJMZ(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object hjRbNRGhvCiQFpZ8uZ2Y(object P_0)
	{
		return ((LocalizationFileHash)P_0).FileName;
	}

	internal static bool TCPkJmGh8jDrLvmKOmdG(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static object rlWywjGhZetuneAvCW1C(object P_0)
	{
		return ((LocalizationFileHash)P_0).Hash;
	}

	internal static Type Yti6hqGhuZGE8uRDIusO(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void yMK9IKGhI01TyAfCyBBT()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
