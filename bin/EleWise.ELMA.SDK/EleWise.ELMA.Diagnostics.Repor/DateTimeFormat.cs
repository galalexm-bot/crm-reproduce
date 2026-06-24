using System;
using System.Runtime.CompilerServices;
using Aspose.Cells;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Excel.Formats;

public class DateTimeFormat : ExcelCellFormat
{
	private static DateTimeFormat bnwa1hEfoLKjn8NuwPoA;

	public static DateTimeFormat Default { get; private set; }

	public bool ShowTime
	{
		[CompilerGenerated]
		get
		{
			return _003CShowTime_003Ek__BackingField;
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
					_003CShowTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DateTimeFormat()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ydp9BxEfGrpFDtahSrky();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
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
			ShowTime = true;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
			{
				num = 1;
			}
		}
	}

	public override void SetCellValue(Cell cell, object value)
	{
		//Discarded unreachable code: IL_0090
		int num = 5;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (PIShbqEffPfMXDLogRJP(value.GetType(), NYUlWCEfExv3mP2CVJWs(typeof(DateTime).TypeHandle)))
				{
					num2 = 3;
					break;
				}
				dateTime = (DateTime)value;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (value == null)
				{
					num2 = 4;
					break;
				}
				goto case 2;
			case 3:
				return;
			case 4:
				return;
			case 0:
				return;
			case 1:
				Ue7kTrEfCaqmaZxnfC9g(cell, ShowTime ? dateTime.ToString((string)XleEdbEfQH0gkbTHP2SF(0x4EDCBA32 ^ 0x4EDC4DB2)) : dateTime.ToShortDateString());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static DateTimeFormat()
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
				sQbyVrEfvekjURQNBWxt(new DateTimeFormat());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				Ydp9BxEfGrpFDtahSrky();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void Ydp9BxEfGrpFDtahSrky()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool o5ukfnEfbZq2ipMNniuQ()
	{
		return bnwa1hEfoLKjn8NuwPoA == null;
	}

	internal static DateTimeFormat WDxHoBEfhyhuH5htxE8F()
	{
		return bnwa1hEfoLKjn8NuwPoA;
	}

	internal static Type NYUlWCEfExv3mP2CVJWs(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool PIShbqEffPfMXDLogRJP(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object XleEdbEfQH0gkbTHP2SF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Ue7kTrEfCaqmaZxnfC9g(object P_0, object P_1)
	{
		((Cell)P_0).set_Value(P_1);
	}

	internal static void sQbyVrEfvekjURQNBWxt(object P_0)
	{
		Default = (DateTimeFormat)P_0;
	}
}
