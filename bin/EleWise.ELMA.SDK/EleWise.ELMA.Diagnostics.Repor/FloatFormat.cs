using System.Runtime.CompilerServices;
using Aspose.Cells;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Excel.Formats;

public class FloatFormat : ExcelCellFormat
{
	private static FloatFormat iDk8rHEEMG2jsjqGENuj;

	public static FloatFormat Default { get; private set; }

	public int DecimalCount
	{
		[CompilerGenerated]
		get
		{
			return _003CDecimalCount_003Ek__BackingField;
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
					_003CDecimalCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FloatFormat()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		syR3tcEEd1qjvOv3xbqS();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				DecimalCount = 2;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void ApplyFormat(Style style)
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
				style.set_Custom((string)oc2XPqEEl1TUQ0tOAyIx(this));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual string GetFormat()
	{
		//Discarded unreachable code: IL_006f, IL_007e
		int num = 8;
		string text = default(string);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return text;
				case 6:
					break;
				default:
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					if (DecimalCount > 0)
					{
						num2 = 4;
						continue;
					}
					goto case 3;
				case 4:
					text = (string)TcBJELEEgAybmEb9ovub(text, YfOg1bEErbaUrhRANULe(-583745292 ^ -583738832));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					num3++;
					num2 = 5;
					continue;
				case 8:
					text = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A17B83);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
				case 5:
					if (num3 >= DecimalCount)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					break;
				}
				break;
			}
			text = (string)TcBJELEEgAybmEb9ovub(text, YfOg1bEErbaUrhRANULe(-867826612 ^ -867820608));
			num = 2;
		}
	}

	static FloatFormat()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				TxghGDEE5LkBLoC77iii(new FloatFormat());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				syR3tcEEd1qjvOv3xbqS();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void syR3tcEEd1qjvOv3xbqS()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool oeZo3NEEJ2vs3FfqkUO4()
	{
		return iDk8rHEEMG2jsjqGENuj == null;
	}

	internal static FloatFormat x6A0PgEE9DYJbsiJ4DcB()
	{
		return iDk8rHEEMG2jsjqGENuj;
	}

	internal static object oc2XPqEEl1TUQ0tOAyIx(object P_0)
	{
		return ((FloatFormat)P_0).GetFormat();
	}

	internal static object YfOg1bEErbaUrhRANULe(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object TcBJELEEgAybmEb9ovub(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void TxghGDEE5LkBLoC77iii(object P_0)
	{
		Default = (FloatFormat)P_0;
	}
}
