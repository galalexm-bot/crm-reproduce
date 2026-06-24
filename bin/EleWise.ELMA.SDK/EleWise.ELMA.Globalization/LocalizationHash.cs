using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Globalization;

[Serializable]
public class LocalizationHash
{
	private static LocalizationHash tgxTY0GbcDsOlund7ZDb;

	public string Local
	{
		[CompilerGenerated]
		get
		{
			return _003CLocal_003Ek__BackingField;
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
					_003CLocal_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
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

	public List<LocalizationFileHash> FileHashes { get; set; }

	public LocalizationHash()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			FileHashes = new List<LocalizationFileHash>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
			{
				num = 1;
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_00ad, IL_00bc
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 3:
				if (this == obj)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 2;
					}
					break;
				}
				if (!npAGJ5GhBmoYpipg8fph(obj.GetType(), typeof(LocalizationHash)))
				{
					return Equals((LocalizationHash)obj);
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (obj != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 1:
				return false;
			case 2:
				return true;
			}
		}
	}

	public bool Equals(LocalizationHash other)
	{
		//Discarded unreachable code: IL_00a2, IL_00f4, IL_0103, IL_0113, IL_015f, IL_016e, IL_01dd
		int num = 2;
		ArrayEqualityComparer<LocalizationFileHash> arrayEqualityComparer = default(ArrayEqualityComparer<LocalizationFileHash>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return apdXaUGhhLVWQvcqGwli(arrayEqualityComparer, kkN6XcGhb4nRxKslguL8(other.FileHashes), FileHashes.ToArray());
				case 8:
					return false;
				case 5:
					return true;
				case 9:
				case 10:
					return false;
				default:
					if (osHg3vGhWnB72aiR5hfP(other) != null)
					{
						num = 7;
						break;
					}
					goto case 4;
				case 2:
					if (other == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 1;
						}
					}
					else if (this != other)
					{
						arrayEqualityComparer = new ArrayEqualityComparer<LocalizationFileHash>();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 11;
					}
					continue;
				case 11:
					return true;
				case 1:
					return false;
				case 14:
					if (FileHashes == null)
					{
						num2 = 8;
						continue;
					}
					goto case 3;
				case 4:
					if (Local != null)
					{
						num2 = 6;
						continue;
					}
					goto case 13;
				case 12:
					if (other.FileHashes != null)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 8;
				case 16:
					if (FileHashes == null)
					{
						num = 5;
						break;
					}
					goto case 12;
				case 15:
					if (!f334NeGhoqWGK11Li3pA(other.Local, Local, StringComparison.OrdinalIgnoreCase))
					{
						num2 = 10;
						continue;
					}
					goto case 13;
				case 6:
				case 7:
					if (osHg3vGhWnB72aiR5hfP(other) == null)
					{
						num2 = 9;
						continue;
					}
					goto case 15;
				case 13:
					if (other.FileHashes == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 12;
				}
				break;
			}
		}
	}

	public override int GetHashCode()
	{
		//Discarded unreachable code: IL_005d
		int num = 2;
		int num2 = num;
		ArrayEqualityComparer<LocalizationFileHash> arrayEqualityComparer = default(ArrayEqualityComparer<LocalizationFileHash>);
		int hashCode;
		while (true)
		{
			switch (num2)
			{
			case 2:
				arrayEqualityComparer = new ArrayEqualityComparer<LocalizationFileHash>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				hashCode = MQI909GhGah9i44RA9F5(typeof(string).TypeHandle).GetHashCode();
				break;
			case 1:
				if (Local == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				hashCode = Local.GetHashCode();
				break;
			}
			break;
		}
		return (hashCode * 347) ^ ((FileHashes != null) ? arrayEqualityComparer.GetHashCode((LocalizationFileHash[])kkN6XcGhb4nRxKslguL8(FileHashes)) : MQI909GhGah9i44RA9F5(typeof(List<LocalizationFileHash>).TypeHandle).GetHashCode());
	}

	internal static bool peGJnCGbzYUnQ2jx4Maj()
	{
		return tgxTY0GbcDsOlund7ZDb == null;
	}

	internal static LocalizationHash NVOa6EGhFaaICZPwVm3y()
	{
		return tgxTY0GbcDsOlund7ZDb;
	}

	internal static bool npAGJ5GhBmoYpipg8fph(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object osHg3vGhWnB72aiR5hfP(object P_0)
	{
		return ((LocalizationHash)P_0).Local;
	}

	internal static bool f334NeGhoqWGK11Li3pA(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static object kkN6XcGhb4nRxKslguL8(object P_0)
	{
		return ((List<LocalizationFileHash>)P_0).ToArray();
	}

	internal static bool apdXaUGhhLVWQvcqGwli(object P_0, object P_1, object P_2)
	{
		return ((ArrayEqualityComparer<LocalizationFileHash>)P_0).Equals((LocalizationFileHash[])P_1, (LocalizationFileHash[])P_2);
	}

	internal static Type MQI909GhGah9i44RA9F5(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
