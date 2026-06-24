using System;
using System.Text;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model;

public static class ValidationErrorHelper
{
	private static ValidationErrorHelper mBvmyvWg4578VyvswZQh;

	public static string GetMessage(params ValidationError[] validationErrors)
	{
		//Discarded unreachable code: IL_004d, IL_005c, IL_00fe, IL_010d, IL_011d, IL_012c
		int num = 1;
		int num2 = num;
		ValidationError[] array = default(ValidationError[]);
		int num3 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			switch (num2)
			{
			case 8:
			case 10:
				GetMessage(array[num3], stringBuilder);
				num2 = 6;
				break;
			case 9:
				num3 = 0;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				num3++;
				num2 = 3;
				break;
			case 1:
				if (validationErrors != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			case 7:
				return string.Empty;
			default:
				stringBuilder = new StringBuilder();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				return stringBuilder.ToString();
			case 5:
				array = validationErrors;
				num2 = 9;
				break;
			case 3:
			case 4:
				if (num3 < array.Length)
				{
					num2 = 10;
					break;
				}
				goto case 2;
			}
		}
	}

	private static void GetMessage(object validationError, object builder)
	{
		//Discarded unreachable code: IL_00aa, IL_00b9, IL_00c9, IL_01b7, IL_0210, IL_021f
		int num = 7;
		int num3 = default(int);
		ValidationError[] array = default(ValidationError[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 12:
				case 16:
					if (num3 < array.Length)
					{
						num2 = 3;
						continue;
					}
					return;
				case 14:
					return;
				case 2:
				case 8:
					if (zYxI2eWg0n1lZW2O9EFO(lILlcwWgxPj8LCJt0ypG(validationError), Guid.Empty))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 9;
				case 10:
					buv5QhWgM7ono1Op9ygE(builder, oE7P5ZWgduERdFA8cq4E(JtuFolWgJimRWLp0Ou1s(-1979251663 ^ -1979368903), JsOWPiWg92jcrf8SWuYr(validationError)));
					num2 = 9;
					continue;
				case 5:
					buv5QhWgM7ono1Op9ygE(builder, uwUfxEWgy74XOFX49Y9m(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3632CE8B), iYbC5bWgm9alL8GiwHt8(lILlcwWgxPj8LCJt0ypG(validationError))));
					num = 8;
					break;
				case 0:
					return;
				case 13:
					array = (ValidationError[])UPnxSHWgl6L3lDugdZLg(validationError);
					num = 11;
					break;
				case 7:
					if (q8waa3WgAxPJ2DoKfCme(((ValidationError)validationError).Message))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 4;
						}
						continue;
					}
					((StringBuilder)builder).AppendLine((string)rEwEKvWg7MB9dbnN4nUW(validationError));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 1;
					}
					continue;
				case 11:
					num3 = 0;
					num2 = 16;
					continue;
				case 1:
					if (!zYxI2eWg0n1lZW2O9EFO(lILlcwWgxPj8LCJt0ypG(validationError), Guid.Empty))
					{
						num2 = 2;
						continue;
					}
					goto case 5;
				case 3:
				case 15:
					X3oVVOWgrOQbCfBSJ0Wm(array[num3], builder);
					num2 = 4;
					continue;
				case 9:
					if (UPnxSHWgl6L3lDugdZLg(validationError) == null)
					{
						return;
					}
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 13;
					}
					continue;
				case 4:
					num3++;
					num2 = 12;
					continue;
				case 6:
					return;
				}
				break;
			}
		}
	}

	private static string GetElementTypeDisplayName(Guid elementTypeUid)
	{
		//Discarded unreachable code: IL_003d, IL_0087, IL_0096
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				return (string)JtuFolWgJimRWLp0Ou1s(-1886646897 ^ -1886506043);
			case 2:
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A35A7D);
			default:
				if (!bPHoLTWgg7PUPVQ0rom6(elementTypeUid, ValidationElementType.ViewItem))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 1;
			case 4:
				if (elementTypeUid == ValidationElementType.ComponentViewItem)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 3;
					}
					break;
				}
				if (!bPHoLTWgg7PUPVQ0rom6(elementTypeUid, ValidationElementType.ObjectFormViewItem))
				{
					if (!bPHoLTWgg7PUPVQ0rom6(elementTypeUid, ValidationElementType.Property))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
				num2 = 6;
				break;
			case 3:
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767864353);
			case 1:
				return (string)JtuFolWgJimRWLp0Ou1s(0x17ADCCD8 ^ 0x17AFF25E);
			case 5:
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4E45B3);
			}
		}
	}

	internal static bool D3uEpiWg6qgGbwDNvRyg()
	{
		return mBvmyvWg4578VyvswZQh == null;
	}

	internal static ValidationErrorHelper VBlZPVWgHFhe8ZJOCqFI()
	{
		return mBvmyvWg4578VyvswZQh;
	}

	internal static bool q8waa3WgAxPJ2DoKfCme(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object rEwEKvWg7MB9dbnN4nUW(object P_0)
	{
		return ((ValidationError)P_0).Message;
	}

	internal static Guid lILlcwWgxPj8LCJt0ypG(object P_0)
	{
		return ((ValidationError)P_0).ElementTypeUid;
	}

	internal static bool zYxI2eWg0n1lZW2O9EFO(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object iYbC5bWgm9alL8GiwHt8(Guid elementTypeUid)
	{
		return GetElementTypeDisplayName(elementTypeUid);
	}

	internal static object uwUfxEWgy74XOFX49Y9m(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object buv5QhWgM7ono1Op9ygE(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static object JtuFolWgJimRWLp0Ou1s(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid JsOWPiWg92jcrf8SWuYr(object P_0)
	{
		return ((ValidationError)P_0).ElementUid;
	}

	internal static object oE7P5ZWgduERdFA8cq4E(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object UPnxSHWgl6L3lDugdZLg(object P_0)
	{
		return ((ValidationError)P_0).InnerErrors;
	}

	internal static void X3oVVOWgrOQbCfBSJ0Wm(object P_0, object P_1)
	{
		GetMessage(P_0, P_1);
	}

	internal static bool bPHoLTWgg7PUPVQ0rom6(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
