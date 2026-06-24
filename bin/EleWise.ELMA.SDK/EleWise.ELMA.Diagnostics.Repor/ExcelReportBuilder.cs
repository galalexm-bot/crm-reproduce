using System;
using System.Runtime.CompilerServices;
using Aspose.Cells;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Excel;

public class ExcelReportBuilder
{
	private Workbook _workbook;

	private ExcelStylesheet _styles;

	internal static ExcelReportBuilder xNohqTEEGwVavsDDq2qD;

	public Workbook Workbook => _workbook;

	public ExcelStylesheet Styles
	{
		get
		{
			return _styles;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (value == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_styles = value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				default:
					throw new ArgumentNullException((string)mNIBxBEEvAp58NppvYZg(0x26FFCB59 ^ 0x26FF822F));
				}
			}
		}
	}

	public Worksheet Worksheet
	{
		[CompilerGenerated]
		get
		{
			return _003CWorksheet_003Ek__BackingField;
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
					_003CWorksheet_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
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

	public bool ApplyCellFormat
	{
		[CompilerGenerated]
		get
		{
			return _003CApplyCellFormat_003Ek__BackingField;
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
					_003CApplyCellFormat_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public RowCollection Rows => Cells.get_Rows();

	public int RowIndex
	{
		[CompilerGenerated]
		get
		{
			return _003CRowIndex_003Ek__BackingField;
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
					_003CRowIndex_003Ek__BackingField = value;
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

	public Row Row => (Row)bAjvxcEEIV7naVegI3ye(b7tYgtEEu88rU5YYm76H(Cells), RowIndex);

	public ColumnCollection Columns
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (ColumnCollection)vHCIIvEESmgOObLaHXfk(bfC70xEEVSUEkSjgMVbN(Worksheet));
				case 1:
					CheckWorksheet();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Cells Cells
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					CheckWorksheet();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return (Cells)bfC70xEEVSUEkSjgMVbN(Worksheet);
				}
			}
		}
	}

	public ExcelReportBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		ikw9fEEEQgL9KBMJsjK7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				_workbook = new Workbook();
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num = 0;
				}
				break;
			case 2:
				ApplyCellFormat = true;
				num = 3;
				break;
			case 1:
				_styles = new ExcelStylesheet();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num = 2;
				}
				break;
			case 3:
				return;
			case 4:
				ii6kQPEEC1fE9sugZfxh(_workbook.get_Worksheets());
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public Worksheet AddWorksheet(string sheetName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Worksheet = (Worksheet)GvaeskEEZmO76cLMwRmB(jKQG5VEE8kuIUdtpJnHT(_workbook), sheetName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Worksheet;
			}
		}
	}

	public void NextRow()
	{
		int num = 1;
		int num2 = num;
		int rowIndex = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				RowIndex = rowIndex + 1;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				rowIndex = RowIndex;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void SetRowStyle(IExcelStyle style)
	{
		//Discarded unreachable code: IL_0032, IL_0041
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
			case 3:
				return;
			case 2:
				Row.SetStyle(style);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				if (style == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public void SetColumnsWidths(params int[] widths)
	{
		//Discarded unreachable code: IL_0066, IL_0075, IL_00a5
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 4:
				return;
			case 2:
			case 5:
				if (num3 >= widths.Length)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 7:
				num3++;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num2 = 2;
				}
				continue;
			case 3:
				num3 = 0;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 5;
				}
				continue;
			case 1:
				if (widths == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 6:
				break;
			}
			Columns.get_Item(num3).set_Width((double)widths[num3]);
			num2 = 7;
		}
	}

	public void SetRowHeight(int height)
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
				DLVIHTEEitiYjcxwqqYW(bAjvxcEEIV7naVegI3ye(Rows, RowIndex), height);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void SetValue(int columnIndex, object value, bool applyFormat = true)
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
				Cells.get_Item(RowIndex, columnIndex).SetValue(value, applyFormat);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void SetValues(params object[] values)
	{
		//Discarded unreachable code: IL_0045, IL_00c0, IL_00cf
		int num = 1;
		int num3 = default(int);
		while (true)
		{
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
					if (values == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 2:
				case 8:
					SetValue(num3, values[num3]);
					num = 4;
					break;
				case 5:
					num3 = 0;
					num2 = 6;
					continue;
				case 3:
				case 6:
					if (num3 < values.Length)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 7:
					return;
				case 4:
					num3++;
					num = 3;
					break;
				}
				break;
			}
		}
	}

	public void SetCellStyle(int columnIndex, IExcelStyle style)
	{
		//Discarded unreachable code: IL_0031
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 2:
				if (style == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 3:
				break;
			case 0:
				return;
			}
			((Cell)vqSjoyEER7KL4cmvo2gL(Cells, RowIndex, columnIndex)).SetStyle(style);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
			{
				num2 = 0;
			}
		}
	}

	public void RenderTable<TRow>(ExcelTable<TRow> table)
	{
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		if (table == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16363ACB));
		}
		ApplyCellFormat = false;
		RowIndex = 0;
		Worksheet.FreezePanes(1, 1, 1, 1);
		IExcelCellFormat[] array = new IExcelCellFormat[table.Columns.Count];
		table.Order();
		for (int i = 0; i < table.Columns.Count; i++)
		{
			ExcelTable<TRow>.IColumn column = table.Columns[i];
			Columns.get_Item(i).set_Width(column.Width);
			IExcelCellFormat excelCellFormat = column.Format;
			if (excelCellFormat == null)
			{
				excelCellFormat = ExcelCellFormat.GetDefaultFormat(column.ValueType);
			}
			array[i] = excelCellFormat;
			if (excelCellFormat != null)
			{
				Style style = Columns.get_Item(i).get_Style();
				excelCellFormat.ApplyFormat(style);
				Column obj = Columns.get_Item(i);
				StyleFlag val = new StyleFlag();
				val.set_NumberFormat(true);
				obj.ApplyStyle(style, val);
			}
			SetCellStyle(i, Styles.HeaderStyle);
			SetValue(i, column.Title);
		}
		if (table.Items != null)
		{
			foreach (TRow item in table.Items)
			{
				NextRow();
				for (int j = 0; j < table.Columns.Count; j++)
				{
					ExcelTable<TRow>.IColumn column2 = table.Columns[j];
					if (column2.ValueAccessor != null)
					{
						SetValue(j, column2.ValueAccessor(item), array[j] == null);
					}
				}
			}
		}
		Worksheet.get_AutoFilter().SetRange(0, 0, table.Columns.Count - 1);
	}

	private void CheckWorksheet()
	{
		//Discarded unreachable code: IL_006e, IL_007d
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (Worksheet != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				return;
			}
			break;
		}
		throw new InvalidOperationException(SR.T((string)mNIBxBEEvAp58NppvYZg(0x4785BC0D ^ 0x47818FE5)));
	}

	internal static void ikw9fEEEQgL9KBMJsjK7()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void ii6kQPEEC1fE9sugZfxh(object P_0)
	{
		((WorksheetCollection)P_0).Clear();
	}

	internal static bool rKpbSIEEEQ8VXlLDKGC1()
	{
		return xNohqTEEGwVavsDDq2qD == null;
	}

	internal static ExcelReportBuilder NdmZipEEfxhWqLbsn6yk()
	{
		return xNohqTEEGwVavsDDq2qD;
	}

	internal static object mNIBxBEEvAp58NppvYZg(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object jKQG5VEE8kuIUdtpJnHT(object P_0)
	{
		return ((Workbook)P_0).get_Worksheets();
	}

	internal static object GvaeskEEZmO76cLMwRmB(object P_0, object P_1)
	{
		return ((WorksheetCollection)P_0).Add((string)P_1);
	}

	internal static object b7tYgtEEu88rU5YYm76H(object P_0)
	{
		return ((Cells)P_0).get_Rows();
	}

	internal static object bAjvxcEEIV7naVegI3ye(object P_0, int P_1)
	{
		return ((RowCollection)P_0).get_Item(P_1);
	}

	internal static object bfC70xEEVSUEkSjgMVbN(object P_0)
	{
		return ((Worksheet)P_0).get_Cells();
	}

	internal static object vHCIIvEESmgOObLaHXfk(object P_0)
	{
		return ((Cells)P_0).get_Columns();
	}

	internal static void DLVIHTEEitiYjcxwqqYW(object P_0, double P_1)
	{
		((Row)P_0).set_Height(P_1);
	}

	internal static object vqSjoyEER7KL4cmvo2gL(object P_0, int P_1, int P_2)
	{
		return ((Cells)P_0).get_Item(P_1, P_2);
	}
}
