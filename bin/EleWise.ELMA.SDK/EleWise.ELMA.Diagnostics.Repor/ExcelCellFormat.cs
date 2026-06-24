using System;
using Aspose.Cells;
using EleWise.ELMA.Diagnostics.Reports.Excel.Formats;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Reports.Excel;

public abstract class ExcelCellFormat : IExcelCellFormat
{
	internal static ExcelCellFormat tE8e7qEGi6UySDcRKWM3;

	public virtual void SetCellValue(Cell cell, object value)
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
				cell.set_Value(value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (value != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 0:
				return;
			}
		}
	}

	public virtual void ApplyFormat(Style style)
	{
	}

	public static IExcelCellFormat GetDefaultFormat(Type valueType)
	{
		//Discarded unreachable code: IL_003d, IL_006b, IL_007a
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return (IExcelCellFormat)GTjnS8EGkyyK0Qh6nhlH();
			default:
				return null;
			case 4:
				if (!VmfokPEGXGM165aul9e5(valueType, ALIFsSEGKYfh2Flq20kW(typeof(TimeSpan).TypeHandle)))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 2:
				return (IExcelCellFormat)yXsLLLEGTp5VjiFDe1MW();
			case 3:
				if (!(valueType == typeof(DateTime)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	protected ExcelCellFormat()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Cghp1iEGnNQX4b6YAUog();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool EOJAoOEGRpGAQHkZdMfy()
	{
		return tE8e7qEGi6UySDcRKWM3 == null;
	}

	internal static ExcelCellFormat YCLTJnEGqBfFiwsaiJhI()
	{
		return tE8e7qEGi6UySDcRKWM3;
	}

	internal static Type ALIFsSEGKYfh2Flq20kW(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool VmfokPEGXGM165aul9e5(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object yXsLLLEGTp5VjiFDe1MW()
	{
		return TimeSpanFormat.Default;
	}

	internal static object GTjnS8EGkyyK0Qh6nhlH()
	{
		return DateTimeFormat.Default;
	}

	internal static void Cghp1iEGnNQX4b6YAUog()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
