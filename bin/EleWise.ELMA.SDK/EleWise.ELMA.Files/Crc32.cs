using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Files;

public class Crc32 : HashAlgorithm
{
	public const uint DefaultSeed = uint.MaxValue;

	private static readonly uint[] CrcTable;

	private uint crcValue;

	private static Crc32 n5m0xtGkKEmCigmaVDUT;

	public uint CrcValue => (uint)((HashValue[0] << 24) | (HashValue[1] << 16) | (HashValue[2] << 8) | HashValue[3]);

	public override int HashSize => 32;

	public override void Initialize()
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
				crcValue = 0u;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void HashCore(byte[] buffer, int start, int length)
	{
		//Discarded unreachable code: IL_00d0, IL_00df, IL_00ee
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				crcValue ^= uint.MaxValue;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 2;
				}
				continue;
			default:
				if (--length >= 0)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			case 1:
				return;
			case 5:
			case 6:
				crcValue = CrcTable[(crcValue ^ buffer[start++]) & 0xFF] ^ (crcValue >> 8);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				break;
			}
			crcValue ^= uint.MaxValue;
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
			{
				num2 = 1;
			}
		}
	}

	protected override byte[] HashFinal()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return HashValue;
			case 1:
				HashValue = new byte[4]
				{
					(byte)((crcValue >> 24) & 0xFFu),
					(byte)((crcValue >> 16) & 0xFFu),
					(byte)((crcValue >> 8) & 0xFFu),
					(byte)(crcValue & 0xFFu)
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void HashBlock(byte[] buffer, int size)
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
				eDsBAPGkkbaTtN4ThikF(this, buffer, 0, size);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void HashBlock(byte[] buffer, int offset, int size)
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
				HashCore(buffer, offset, size);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public byte[] HashFinalBlock()
	{
		return (byte[])sndRUwGknSgT91MQPRvN(this);
	}

	public static uint GetCrcValue(string filePath)
	{
		//Discarded unreachable code: IL_00d1, IL_013a, IL_0177, IL_0186
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_2 = default(_003C_003Ec__DisplayClass13_0);
		_003C_003Ec__DisplayClass13_1 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_1);
		uint result = default(uint);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass13_2.filePath = filePath;
				num2 = 3;
				break;
			case 5:
				_003C_003Ec__DisplayClass13_2 = new _003C_003Ec__DisplayClass13_0();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 4;
				}
				break;
			default:
				_003C_003Ec__DisplayClass13_.crc32 = new Crc32();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				return result;
			case 1:
				try
				{
					wiPgPQGk26mF91mOjEwV(new Action(_003C_003Ec__DisplayClass13_._003CGetCrcValue_003Eb__0), EUFL9xGkO53nU9YcYOJm(1.0), 30);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return result;
						case 0:
							return result;
						case 1:
							result = hcq9gpGkeldAVkZUkiHi(_003C_003Ec__DisplayClass13_.crc32);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					if (_003C_003Ec__DisplayClass13_.crc32 != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								DvJH6UGkPqCNSUi0oopX(_003C_003Ec__DisplayClass13_.crc32);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 2:
				_003C_003Ec__DisplayClass13_.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass13_2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_1();
				num2 = 2;
				break;
			}
		}
	}

	public static uint GetCrcValue(Stream stream)
	{
		//Discarded unreachable code: IL_004f, IL_00ae, IL_00e6, IL_00f5
		int num = 2;
		int num2 = num;
		uint result = default(uint);
		Crc32 crc = default(Crc32);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 1:
				try
				{
					DJ3WmtGk1i3SLkHpCocy(crc, stream);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return result;
						case 0:
							return result;
						case 1:
							result = hcq9gpGkeldAVkZUkiHi(crc);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					if (crc != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								((IDisposable)crc).Dispose();
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 2:
				crc = new Crc32();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static bool CheckCrc(string filePath, uint crcValue)
	{
		return E2TRlyGkNDSqRJhMuWWl(filePath) == crcValue;
	}

	public Crc32()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hJMQhvGk3piq1X6UrFK9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Crc32()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				hJMQhvGk3piq1X6UrFK9();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			{
				uint[] array = new uint[256];
				ScBUuyGkpVx5OV7bbKff(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				CrcTable = array;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	internal static bool zJxOCyGkX8Cn1iYCyyqH()
	{
		return n5m0xtGkKEmCigmaVDUT == null;
	}

	internal static Crc32 XGsuqGGkTOxmw9LhVqus()
	{
		return n5m0xtGkKEmCigmaVDUT;
	}

	internal static void eDsBAPGkkbaTtN4ThikF(object P_0, object P_1, int P_2, int P_3)
	{
		((HashAlgorithm)P_0).HashCore((byte[])P_1, P_2, P_3);
	}

	internal static object sndRUwGknSgT91MQPRvN(object P_0)
	{
		return ((HashAlgorithm)P_0).HashFinal();
	}

	internal static TimeSpan EUFL9xGkO53nU9YcYOJm(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static void wiPgPQGk26mF91mOjEwV(object P_0, TimeSpan interval, int attemptCount)
	{
		ActionExtensions.ExecuteWithAttempts((Action)P_0, interval, attemptCount);
	}

	internal static uint hcq9gpGkeldAVkZUkiHi(object P_0)
	{
		return ((Crc32)P_0).CrcValue;
	}

	internal static void DvJH6UGkPqCNSUi0oopX(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object DJ3WmtGk1i3SLkHpCocy(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((Stream)P_1);
	}

	internal static uint E2TRlyGkNDSqRJhMuWWl(object P_0)
	{
		return GetCrcValue((string)P_0);
	}

	internal static void hJMQhvGk3piq1X6UrFK9()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void ScBUuyGkpVx5OV7bbKff(object P_0, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray((Array)P_0, P_1);
	}
}
