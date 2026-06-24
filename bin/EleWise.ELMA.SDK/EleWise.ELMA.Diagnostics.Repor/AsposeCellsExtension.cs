using System;
using System.Drawing;
using Aspose.Cells;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Excel;

public static class AsposeCellsExtension
{
	private static AsposeCellsExtension rvquwNEGOOgOMmoKlcJn;

	public static Row SetForeground(this Row row, Color foregroundColor)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		Style val = default(Style);
		StyleFlag val2 = default(StyleFlag);
		while (true)
		{
			switch (num2)
			{
			case 3:
				qAuhePEG1V2mPBi0hcbP(val, val2, foregroundColor);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				val2 = new StyleFlag();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return row;
			case 2:
				val = (Style)SgCR7pEGP1WVqFnMmQfT(row);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				bEfbcREGN4uuZ3j0ftYw(row, val, val2);
				num2 = 4;
				break;
			}
		}
	}

	public static Row SetFontColor(this Row row, Color fontColor)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		int num = 4;
		int num2 = num;
		Style style = default(Style);
		StyleFlag val = default(StyleFlag);
		while (true)
		{
			switch (num2)
			{
			case 2:
				dh6r2uEG3AWUCN8fNOoG(style, val, fontColor);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return row;
			case 3:
				val = new StyleFlag();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				bEfbcREGN4uuZ3j0ftYw(row, style, val);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				style = row.get_Style();
				num2 = 3;
				break;
			}
		}
	}

	public static Row SetFontSize(this Row row, int size)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		int num = 3;
		int num2 = num;
		StyleFlag val2 = default(StyleFlag);
		Style val = default(Style);
		while (true)
		{
			switch (num2)
			{
			case 2:
				val2 = new StyleFlag();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				val = (Style)SgCR7pEGP1WVqFnMmQfT(row);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				Iu5BPMEGpSjHMi6SuubO(val, val2, size);
				num2 = 4;
				break;
			case 1:
				return row;
			case 4:
				bEfbcREGN4uuZ3j0ftYw(row, val, val2);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static Row SetFontBold(this Row row, bool isBold)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		Style val = default(Style);
		StyleFlag val2 = default(StyleFlag);
		while (true)
		{
			switch (num2)
			{
			case 3:
				NwvL2GEGaVgB9Rcxbak6(val, val2, isBold);
				num2 = 4;
				break;
			case 4:
				row.ApplyStyle(val, val2);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				val2 = new StyleFlag();
				num2 = 3;
				break;
			case 2:
				val = (Style)SgCR7pEGP1WVqFnMmQfT(row);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return row;
			}
		}
	}

	public static Row SetStyle(this Row row, IExcelStyle style)
	{
		//Discarded unreachable code: IL_00b9
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		int num = 3;
		int num2 = num;
		Style val2 = default(Style);
		StyleFlag val = default(StyleFlag);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (style == null)
				{
					num2 = 2;
					break;
				}
				goto case 6;
			default:
				return row;
			case 6:
				val2 = (Style)SgCR7pEGP1WVqFnMmQfT(row);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				style.Apply(val2, val);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				bEfbcREGN4uuZ3j0ftYw(row, val2, val);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				val = new StyleFlag();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public static Cell SetForeground(this Cell cell, Color foregroundColor)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		int num = 3;
		int num2 = num;
		Style val = default(Style);
		StyleFlag val2 = default(StyleFlag);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return cell;
			default:
				qAuhePEG1V2mPBi0hcbP(val, val2, foregroundColor);
				num2 = 4;
				break;
			case 4:
				cell.SetStyle(val, val2);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				val2 = new StyleFlag();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				val = (Style)wsEkljEGDc5LwTvGXNyM(cell);
				num2 = 2;
				break;
			}
		}
	}

	public static Cell SetFontColor(this Cell cell, Color fontColor)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		int num = 4;
		int num2 = num;
		Style val = default(Style);
		StyleFlag val2 = default(StyleFlag);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return cell;
			case 4:
				val = (Style)wsEkljEGDc5LwTvGXNyM(cell);
				num2 = 3;
				break;
			case 3:
				val2 = new StyleFlag();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				uUKgjwEGtN4cG5uYB3FX(cell, val, val2);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				dh6r2uEG3AWUCN8fNOoG(val, val2, fontColor);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static Cell SetFontSize(this Cell cell, int size)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		Style style = default(Style);
		StyleFlag val = default(StyleFlag);
		while (true)
		{
			switch (num2)
			{
			default:
				uUKgjwEGtN4cG5uYB3FX(cell, style, val);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return cell;
			case 4:
				Iu5BPMEGpSjHMi6SuubO(style, val, size);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				style = cell.GetStyle();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				val = new StyleFlag();
				num2 = 4;
				break;
			}
		}
	}

	public static Cell SetFontBold(this Cell cell, bool isBold)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		StyleFlag val = default(StyleFlag);
		Style style = default(Style);
		while (true)
		{
			switch (num2)
			{
			default:
				val = new StyleFlag();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				uUKgjwEGtN4cG5uYB3FX(cell, style, val);
				num2 = 4;
				break;
			case 1:
				style = cell.GetStyle();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return cell;
			case 2:
				NwvL2GEGaVgB9Rcxbak6(style, val, isBold);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public static Cell SetIndentLevel(this Cell cell, int level, TextAlignmentType alignment = 7)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		Style val = default(Style);
		StyleFlag val2 = default(StyleFlag);
		while (true)
		{
			switch (num2)
			{
			case 5:
				JO1HFnEGwN4aBspY4j4B(val, val2, level);
				num2 = 3;
				break;
			case 1:
				val2 = new StyleFlag();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				return cell;
			case 2:
				val = (Style)wsEkljEGDc5LwTvGXNyM(cell);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 1;
				}
				break;
			default:
				uUKgjwEGtN4cG5uYB3FX(cell, val, val2);
				num2 = 4;
				break;
			case 3:
				Kr3nReEG4miUGR7nrglo(val, val2, (TextAlignmentType)7);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static Cell SetStyle(this Cell cell, IExcelStyle style)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		int num = 4;
		int num2 = num;
		Style style2 = default(Style);
		StyleFlag val = default(StyleFlag);
		while (true)
		{
			switch (num2)
			{
			case 1:
				vrfuWFEG6SKhoikJFQpX(style, style2, val);
				num2 = 5;
				break;
			case 3:
				style2 = cell.GetStyle();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				uUKgjwEGtN4cG5uYB3FX(cell, style2, val);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return cell;
			case 4:
				if (style != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			case 2:
				val = new StyleFlag();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static Cell SetValue(this Cell cell, object value, bool applyFormat = true)
	{
		//Discarded unreachable code: IL_017e, IL_018e, IL_01a9, IL_01b8, IL_01e8, IL_01f7, IL_0218, IL_0228, IL_0252, IL_0261
		int num = 22;
		int num2 = num;
		IExcelCellFormat excelCellFormat = default(IExcelCellFormat);
		Style val = default(Style);
		CellValue cellValue = default(CellValue);
		while (true)
		{
			object obj2;
			object obj;
			switch (num2)
			{
			case 7:
				KRBQBeEG0s4CNfg0Z1AW(excelCellFormat, cell, S1L4DHEGxnshRpveHpdh(value));
				num2 = 12;
				continue;
			case 15:
				cell.SetStyle(val);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 11;
				}
				continue;
			case 23:
				val = (Style)wsEkljEGDc5LwTvGXNyM(cell);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 2;
				}
				continue;
			case 21:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538776630));
			case 12:
				if (!applyFormat)
				{
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 23;
			case 18:
				excelCellFormat = (IExcelCellFormat)oxAqNUEG7fGXEwps4sEb(value.GetType());
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 6;
				}
				continue;
			case 2:
				bioQNgEGmiaQ7TWmAICm(excelCellFormat, val);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 15;
				}
				continue;
			case 20:
				obj2 = null;
				goto IL_0301;
			case 19:
				if (cellValue == null)
				{
					num2 = 20;
					continue;
				}
				obj2 = ows1PbEGH7PdLA1v4q5O(cellValue);
				goto IL_0301;
			case 22:
				if (cell != null)
				{
					if (value == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					cellValue = value as CellValue;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 19;
					}
				}
				else
				{
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 21;
					}
				}
				continue;
			case 4:
				if (excelCellFormat == null)
				{
					num2 = 17;
					continue;
				}
				goto case 6;
			case 10:
				obj = value;
				break;
			default:
				if (value == null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 8;
					}
					continue;
				}
				goto case 13;
			case 8:
			case 9:
			case 11:
			case 16:
				return cell;
			case 13:
				cell.set_Value(S1L4DHEGxnshRpveHpdh(value));
				num2 = 9;
				continue;
			case 6:
				if (excelCellFormat == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 7;
			case 14:
				if (cellValue != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 10;
			case 5:
				return cell;
			case 17:
				if (value != null)
				{
					num2 = 18;
					continue;
				}
				goto case 6;
			case 3:
				{
					obj = Ir4ybjEGAWEGV86jaFpN(cellValue);
					break;
				}
				IL_0301:
				excelCellFormat = (IExcelCellFormat)obj2;
				num2 = 14;
				continue;
			}
			value = obj;
			num2 = 4;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
			{
				num2 = 4;
			}
		}
	}

	private static object ProcessValue(object value)
	{
		//Discarded unreachable code: IL_006d, IL_007c, IL_008b
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (!tjoejsEGynxos53wcfe7(value.GetType(), typeof(string)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 5:
					if (value == null)
					{
						break;
					}
					goto end_IL_0012;
				case 3:
					if (aqM5kNEGMvAHc3RIaFHG((string)value) <= 16000)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 1:
					return g566vtEGJegm6GZwoa1m((string)value, 0, 16000);
				}
				return value;
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	internal static object SgCR7pEGP1WVqFnMmQfT(object P_0)
	{
		return ((Row)P_0).get_Style();
	}

	internal static void qAuhePEG1V2mPBi0hcbP(object P_0, object P_1, Color color)
	{
		ExcelStyleHelper.SetBackColor((Style)P_0, (StyleFlag)P_1, color);
	}

	internal static void bEfbcREGN4uuZ3j0ftYw(object P_0, object P_1, object P_2)
	{
		((Row)P_0).ApplyStyle((Style)P_1, (StyleFlag)P_2);
	}

	internal static bool d4mdSlEG2en4AEQ6qM1M()
	{
		return rvquwNEGOOgOMmoKlcJn == null;
	}

	internal static AsposeCellsExtension rONCQbEGer2cEGD3JTxI()
	{
		return rvquwNEGOOgOMmoKlcJn;
	}

	internal static void dh6r2uEG3AWUCN8fNOoG(object P_0, object P_1, Color color)
	{
		ExcelStyleHelper.SetFontColor((Style)P_0, (StyleFlag)P_1, color);
	}

	internal static void Iu5BPMEGpSjHMi6SuubO(object P_0, object P_1, int size)
	{
		ExcelStyleHelper.SetFontSize((Style)P_0, (StyleFlag)P_1, size);
	}

	internal static void NwvL2GEGaVgB9Rcxbak6(object P_0, object P_1, bool isBold)
	{
		ExcelStyleHelper.SetFontBold((Style)P_0, (StyleFlag)P_1, isBold);
	}

	internal static object wsEkljEGDc5LwTvGXNyM(object P_0)
	{
		return ((Cell)P_0).GetStyle();
	}

	internal static void uUKgjwEGtN4cG5uYB3FX(object P_0, object P_1, object P_2)
	{
		((Cell)P_0).SetStyle((Style)P_1, (StyleFlag)P_2);
	}

	internal static void JO1HFnEGwN4aBspY4j4B(object P_0, object P_1, int level)
	{
		ExcelStyleHelper.SetIndentLevel((Style)P_0, (StyleFlag)P_1, level);
	}

	internal static void Kr3nReEG4miUGR7nrglo(object P_0, object P_1, TextAlignmentType alignment)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		ExcelStyleHelper.SetHorizontalAlignment((Style)P_0, (StyleFlag)P_1, alignment);
	}

	internal static void vrfuWFEG6SKhoikJFQpX(object P_0, object P_1, object P_2)
	{
		((IExcelStyle)P_0).Apply((Style)P_1, (StyleFlag)P_2);
	}

	internal static object ows1PbEGH7PdLA1v4q5O(object P_0)
	{
		return ((CellValue)P_0).Format;
	}

	internal static object Ir4ybjEGAWEGV86jaFpN(object P_0)
	{
		return ((CellValue)P_0).Value;
	}

	internal static object oxAqNUEG7fGXEwps4sEb(Type valueType)
	{
		return ExcelCellFormat.GetDefaultFormat(valueType);
	}

	internal static object S1L4DHEGxnshRpveHpdh(object P_0)
	{
		return ProcessValue(P_0);
	}

	internal static void KRBQBeEG0s4CNfg0Z1AW(object P_0, object P_1, object P_2)
	{
		((IExcelCellFormat)P_0).SetCellValue((Cell)P_1, P_2);
	}

	internal static void bioQNgEGmiaQ7TWmAICm(object P_0, object P_1)
	{
		((IExcelCellFormat)P_0).ApplyFormat((Style)P_1);
	}

	internal static bool tjoejsEGynxos53wcfe7(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static int aqM5kNEGMvAHc3RIaFHG(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object g566vtEGJegm6GZwoa1m(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}
}
