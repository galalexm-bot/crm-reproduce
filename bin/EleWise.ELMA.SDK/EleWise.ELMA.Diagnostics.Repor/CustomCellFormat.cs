using System;
using Aspose.Cells;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Excel.Formats;

public class CustomCellFormat : ExcelCellFormat
{
	private Action<Cell, object> _setValueAction;

	internal static CustomCellFormat oktsivEfFgAavvMfJj0g;

	public CustomCellFormat(Action<Cell, object> setValueAction)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		if (setValueAction == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87072693));
		}
		_setValueAction = setValueAction;
	}

	public override void SetCellValue(Cell cell, object value)
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
				_setValueAction(cell, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool OR6R7TEfB5LU5XRxnmsA()
	{
		return oktsivEfFgAavvMfJj0g == null;
	}

	internal static CustomCellFormat wFfiyoEfWey458lAMKVX()
	{
		return oktsivEfFgAavvMfJj0g;
	}
}
