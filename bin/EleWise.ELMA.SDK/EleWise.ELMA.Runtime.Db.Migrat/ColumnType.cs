using System.Data;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework;

public class ColumnType
{
	internal static ColumnType YwHnGXW2o4ftYd8idWOm;

	public DbType DataType
	{
		[CompilerGenerated]
		get
		{
			return _003CDataType_003Ek__BackingField;
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
					_003CDataType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int? Length { get; set; }

	public int? Scale { get; set; }

	public ColumnType(DbType dataType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
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
			DataType = dataType;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
			{
				num = 1;
			}
		}
	}

	public ColumnType(DbType dataType, int length)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		AEsg4bW2GY4vF98d7Wvc();
		this._002Ector(dataType);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Length = length;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ColumnType(DbType dataType, int length, int scale)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		AEsg4bW2GY4vF98d7Wvc();
		this._002Ector(dataType, length);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
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
			Scale = scale;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
			{
				num = 1;
			}
		}
	}

	public static implicit operator ColumnType(DbType type)
	{
		return new ColumnType(type);
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_008c, IL_00b8, IL_00c7, IL_0100
		int num = 1;
		string text2 = default(string);
		int? num3 = default(int?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				string text;
				switch (num2)
				{
				case 4:
					return ((string)yEw5ZHW2EsQhEMMdR3P9(0x17ADCCD8 ^ 0x17AD1E32)).FormatWith(DataType, text2);
				case 8:
					num3 = Length;
					num2 = 6;
					continue;
				case 3:
					text = string.Empty;
					goto IL_01b8;
				case 5:
					num3 = Scale;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					text = ((string)yEw5ZHW2EsQhEMMdR3P9(-35995181 ^ -36125085)).FormatWith(Length);
					goto IL_01b8;
				default:
					if (num3.HasValue)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 8;
				case 2:
					if (!num3.HasValue)
					{
						num = 8;
						break;
					}
					text = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345290118).FormatWith(Length, Scale);
					goto IL_01b8;
				case 6:
					if (num3.HasValue)
					{
						num = 7;
						break;
					}
					goto case 3;
				case 1:
					{
						num3 = Length;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					IL_01b8:
					text2 = text;
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	internal static bool E8PRBOW2baHjaUSZoJgA()
	{
		return YwHnGXW2o4ftYd8idWOm == null;
	}

	internal static ColumnType tNSrvOW2hL1n0wmk2boJ()
	{
		return YwHnGXW2o4ftYd8idWOm;
	}

	internal static void AEsg4bW2GY4vF98d7Wvc()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object yEw5ZHW2EsQhEMMdR3P9(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
