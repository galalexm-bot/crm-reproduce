// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.AsposeCellsExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Excel
{
  public static class AsposeCellsExtension
  {
    private static AsposeCellsExtension rvquwNEGOOgOMmoKlcJn;

    public static Row SetForeground(this Row row, Color foregroundColor)
    {
      int num = 2;
      Style style;
      StyleFlag styleFlag;
      while (true)
      {
        switch (num)
        {
          case 1:
            styleFlag = new StyleFlag();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 3 : 0;
            continue;
          case 2:
            style = (Style) AsposeCellsExtension.SgCR7pEGP1WVqFnMmQfT((object) row);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
            continue;
          case 3:
            AsposeCellsExtension.qAuhePEG1V2mPBi0hcbP((object) style, (object) styleFlag, foregroundColor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
            continue;
          case 4:
            goto label_4;
          default:
            AsposeCellsExtension.bEfbcREGN4uuZ3j0ftYw((object) row, (object) style, (object) styleFlag);
            num = 4;
            continue;
        }
      }
label_4:
      return row;
    }

    public static Row SetFontColor(this Row row, Color fontColor)
    {
      int num = 4;
      Style style;
      StyleFlag styleFlag;
      while (true)
      {
        switch (num)
        {
          case 1:
            AsposeCellsExtension.bEfbcREGN4uuZ3j0ftYw((object) row, (object) style, (object) styleFlag);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          case 2:
            AsposeCellsExtension.dh6r2uEG3AWUCN8fNOoG((object) style, (object) styleFlag, fontColor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
            continue;
          case 3:
            styleFlag = new StyleFlag();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 2 : 2;
            continue;
          case 4:
            style = row.Style;
            num = 3;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return row;
    }

    public static Row SetFontSize(this Row row, int size)
    {
      int num = 3;
      StyleFlag styleFlag;
      Style style;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            styleFlag = new StyleFlag();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
            continue;
          case 3:
            style = (Style) AsposeCellsExtension.SgCR7pEGP1WVqFnMmQfT((object) row);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 2;
            continue;
          case 4:
            AsposeCellsExtension.bEfbcREGN4uuZ3j0ftYw((object) row, (object) style, (object) styleFlag);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
            continue;
          default:
            AsposeCellsExtension.Iu5BPMEGpSjHMi6SuubO((object) style, (object) styleFlag, size);
            num = 4;
            continue;
        }
      }
label_5:
      return row;
    }

    public static Row SetFontBold(this Row row, bool isBold)
    {
      int num = 2;
      Style style;
      StyleFlag flag;
      while (true)
      {
        switch (num)
        {
          case 1:
            flag = new StyleFlag();
            num = 3;
            continue;
          case 2:
            style = (Style) AsposeCellsExtension.SgCR7pEGP1WVqFnMmQfT((object) row);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 1;
            continue;
          case 3:
            AsposeCellsExtension.NwvL2GEGaVgB9Rcxbak6((object) style, (object) flag, isBold);
            num = 4;
            continue;
          case 4:
            row.ApplyStyle(style, flag);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return row;
    }

    public static Row SetStyle(this Row row, IExcelStyle style)
    {
      int num = 3;
      Style style1;
      StyleFlag styleFlag;
      while (true)
      {
        switch (num)
        {
          case 1:
            AsposeCellsExtension.bEfbcREGN4uuZ3j0ftYw((object) row, (object) style1, (object) styleFlag);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          case 3:
            if (style == null)
            {
              num = 2;
              continue;
            }
            goto case 6;
          case 4:
            style.Apply(style1, styleFlag);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
            continue;
          case 5:
            styleFlag = new StyleFlag();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 3 : 4;
            continue;
          case 6:
            style1 = (Style) AsposeCellsExtension.SgCR7pEGP1WVqFnMmQfT((object) row);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 4 : 5;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return row;
    }

    public static Cell SetForeground(this Cell cell, Color foregroundColor)
    {
      int num = 3;
      Style style;
      StyleFlag flag;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            flag = new StyleFlag();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 3:
            style = (Style) AsposeCellsExtension.wsEkljEGDc5LwTvGXNyM((object) cell);
            num = 2;
            continue;
          case 4:
            cell.SetStyle(style, flag);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
            continue;
          default:
            AsposeCellsExtension.qAuhePEG1V2mPBi0hcbP((object) style, (object) flag, foregroundColor);
            num = 4;
            continue;
        }
      }
label_2:
      return cell;
    }

    public static Cell SetFontColor(this Cell cell, Color fontColor)
    {
      int num = 4;
      Style style;
      StyleFlag styleFlag;
      while (true)
      {
        switch (num)
        {
          case 1:
            AsposeCellsExtension.dh6r2uEG3AWUCN8fNOoG((object) style, (object) styleFlag, fontColor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            styleFlag = new StyleFlag();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
            continue;
          case 4:
            style = (Style) AsposeCellsExtension.wsEkljEGDc5LwTvGXNyM((object) cell);
            num = 3;
            continue;
          default:
            AsposeCellsExtension.uUKgjwEGtN4cG5uYB3FX((object) cell, (object) style, (object) styleFlag);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:
      return cell;
    }

    public static Cell SetFontSize(this Cell cell, int size)
    {
      int num = 2;
      Style style;
      StyleFlag styleFlag;
      while (true)
      {
        switch (num)
        {
          case 1:
            styleFlag = new StyleFlag();
            num = 4;
            continue;
          case 2:
            style = cell.GetStyle();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_3;
          case 4:
            AsposeCellsExtension.Iu5BPMEGpSjHMi6SuubO((object) style, (object) styleFlag, size);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          default:
            AsposeCellsExtension.uUKgjwEGtN4cG5uYB3FX((object) cell, (object) style, (object) styleFlag);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 3 : 3;
            continue;
        }
      }
label_3:
      return cell;
    }

    public static Cell SetFontBold(this Cell cell, bool isBold)
    {
      int num = 1;
      StyleFlag styleFlag;
      Style style;
      while (true)
      {
        switch (num)
        {
          case 1:
            style = cell.GetStyle();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
            continue;
          case 2:
            AsposeCellsExtension.NwvL2GEGaVgB9Rcxbak6((object) style, (object) styleFlag, isBold);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 3;
            continue;
          case 3:
            AsposeCellsExtension.uUKgjwEGtN4cG5uYB3FX((object) cell, (object) style, (object) styleFlag);
            num = 4;
            continue;
          case 4:
            goto label_5;
          default:
            styleFlag = new StyleFlag();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 2;
            continue;
        }
      }
label_5:
      return cell;
    }

    public static Cell SetIndentLevel(this Cell cell, int level, TextAlignmentType alignment = TextAlignmentType.Left)
    {
      int num = 2;
      Style style;
      StyleFlag styleFlag;
      while (true)
      {
        switch (num)
        {
          case 1:
            styleFlag = new StyleFlag();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 5;
            continue;
          case 2:
            style = (Style) AsposeCellsExtension.wsEkljEGDc5LwTvGXNyM((object) cell);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
            continue;
          case 3:
            AsposeCellsExtension.Kr3nReEG4miUGR7nrglo((object) style, (object) styleFlag, TextAlignmentType.Left);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_4;
          case 5:
            AsposeCellsExtension.JO1HFnEGwN4aBspY4j4B((object) style, (object) styleFlag, level);
            num = 3;
            continue;
          default:
            AsposeCellsExtension.uUKgjwEGtN4cG5uYB3FX((object) cell, (object) style, (object) styleFlag);
            num = 4;
            continue;
        }
      }
label_4:
      return cell;
    }

    public static Cell SetStyle(this Cell cell, IExcelStyle style)
    {
      int num = 4;
      Style style1;
      StyleFlag styleFlag;
      while (true)
      {
        switch (num)
        {
          case 1:
            AsposeCellsExtension.vrfuWFEG6SKhoikJFQpX((object) style, (object) style1, (object) styleFlag);
            num = 5;
            continue;
          case 2:
            styleFlag = new StyleFlag();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
            continue;
          case 3:
            style1 = cell.GetStyle();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 2;
            continue;
          case 4:
            if (style != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 3;
              continue;
            }
            goto label_5;
          case 5:
            AsposeCellsExtension.uUKgjwEGtN4cG5uYB3FX((object) cell, (object) style1, (object) styleFlag);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return cell;
    }

    public static Cell SetValue(this Cell cell, object value, bool applyFormat = true)
    {
      int num = 22;
      while (true)
      {
        IExcelCellFormat excelCellFormat;
        Style style;
        CellValue cellValue;
        object obj1;
        object obj2;
        switch (num)
        {
          case 2:
            AsposeCellsExtension.bioQNgEGmiaQ7TWmAICm((object) excelCellFormat, (object) style);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 10 : 15;
            continue;
          case 3:
            obj1 = AsposeCellsExtension.Ir4ybjEGAWEGV86jaFpN((object) cellValue);
            goto label_35;
          case 4:
            if (excelCellFormat == null)
            {
              num = 17;
              continue;
            }
            goto case 6;
          case 5:
            goto label_28;
          case 6:
            if (excelCellFormat == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
              continue;
            }
            goto case 7;
          case 7:
            AsposeCellsExtension.KRBQBeEG0s4CNfg0Z1AW((object) excelCellFormat, (object) cell, AsposeCellsExtension.S1L4DHEGxnshRpveHpdh(value));
            num = 12;
            continue;
          case 8:
          case 9:
          case 11:
          case 16:
            goto label_22;
          case 10:
            obj1 = value;
            goto label_35;
          case 12:
            if (!applyFormat)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 16 : 5;
              continue;
            }
            goto case 23;
          case 13:
            cell.Value = AsposeCellsExtension.S1L4DHEGxnshRpveHpdh(value);
            num = 9;
            continue;
          case 14:
            if (cellValue != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 2 : 3;
              continue;
            }
            goto case 10;
          case 15:
            cell.SetStyle(style);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 3 : 11;
            continue;
          case 17:
            if (value != null)
            {
              num = 18;
              continue;
            }
            goto case 6;
          case 18:
            excelCellFormat = (IExcelCellFormat) AsposeCellsExtension.oxAqNUEG7fGXEwps4sEb(value.GetType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 6;
            continue;
          case 19:
            if (cellValue == null)
            {
              num = 20;
              continue;
            }
            obj2 = AsposeCellsExtension.ows1PbEGH7PdLA1v4q5O((object) cellValue);
            break;
          case 20:
            obj2 = (object) null;
            break;
          case 21:
            goto label_5;
          case 22:
            if (cell != null)
            {
              if (value == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 5;
                continue;
              }
              cellValue = value as CellValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 9 : 19;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 21 : 21;
            continue;
          case 23:
            style = (Style) AsposeCellsExtension.wsEkljEGDc5LwTvGXNyM((object) cell);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 2;
            continue;
          default:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 8 : 8;
              continue;
            }
            goto case 13;
        }
        excelCellFormat = (IExcelCellFormat) obj2;
        num = 14;
        continue;
label_35:
        value = obj1;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 4 : 4;
      }
label_5:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538776630));
label_22:
      return cell;
label_28:
      return cell;
    }

    private static object ProcessValue(object value)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 3:
              if (AsposeCellsExtension.aqM5kNEGMvAHc3RIaFHG((object) (string) value) <= 16000)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 0;
                continue;
              }
              goto label_9;
            case 4:
              if (!AsposeCellsExtension.tjoejsEGynxos53wcfe7(value.GetType(), typeof (string)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 5:
              goto label_5;
            default:
              goto label_10;
          }
        }
label_5:
        if (value != null)
          num1 = 4;
        else
          goto label_10;
      }
label_9:
      return AsposeCellsExtension.g566vtEGJegm6GZwoa1m((object) (string) value, 0, 16000);
label_10:
      return value;
    }

    internal static object SgCR7pEGP1WVqFnMmQfT([In] object obj0) => (object) ((Row) obj0).Style;

    internal static void qAuhePEG1V2mPBi0hcbP([In] object obj0, [In] object obj1, Color color) => ExcelStyleHelper.SetBackColor((Style) obj0, (StyleFlag) obj1, color);

    internal static void bEfbcREGN4uuZ3j0ftYw([In] object obj0, [In] object obj1, [In] object obj2) => ((Row) obj0).ApplyStyle((Style) obj1, (StyleFlag) obj2);

    internal static bool d4mdSlEG2en4AEQ6qM1M() => AsposeCellsExtension.rvquwNEGOOgOMmoKlcJn == null;

    internal static AsposeCellsExtension rONCQbEGer2cEGD3JTxI() => AsposeCellsExtension.rvquwNEGOOgOMmoKlcJn;

    internal static void dh6r2uEG3AWUCN8fNOoG([In] object obj0, [In] object obj1, Color color) => ExcelStyleHelper.SetFontColor((Style) obj0, (StyleFlag) obj1, color);

    internal static void Iu5BPMEGpSjHMi6SuubO([In] object obj0, [In] object obj1, int size) => ExcelStyleHelper.SetFontSize((Style) obj0, (StyleFlag) obj1, size);

    internal static void NwvL2GEGaVgB9Rcxbak6([In] object obj0, [In] object obj1, bool isBold) => ExcelStyleHelper.SetFontBold((Style) obj0, (StyleFlag) obj1, isBold);

    internal static object wsEkljEGDc5LwTvGXNyM([In] object obj0) => (object) ((Cell) obj0).GetStyle();

    internal static void uUKgjwEGtN4cG5uYB3FX([In] object obj0, [In] object obj1, [In] object obj2) => ((Cell) obj0).SetStyle((Style) obj1, (StyleFlag) obj2);

    internal static void JO1HFnEGwN4aBspY4j4B([In] object obj0, [In] object obj1, int level) => ExcelStyleHelper.SetIndentLevel((Style) obj0, (StyleFlag) obj1, level);

    internal static void Kr3nReEG4miUGR7nrglo(
      [In] object obj0,
      [In] object obj1,
      TextAlignmentType alignment)
    {
      ExcelStyleHelper.SetHorizontalAlignment((Style) obj0, (StyleFlag) obj1, alignment);
    }

    internal static void vrfuWFEG6SKhoikJFQpX([In] object obj0, [In] object obj1, [In] object obj2) => ((IExcelStyle) obj0).Apply((Style) obj1, (StyleFlag) obj2);

    internal static object ows1PbEGH7PdLA1v4q5O([In] object obj0) => (object) ((CellValue) obj0).Format;

    internal static object Ir4ybjEGAWEGV86jaFpN([In] object obj0) => ((CellValue) obj0).Value;

    internal static object oxAqNUEG7fGXEwps4sEb(Type valueType) => (object) ExcelCellFormat.GetDefaultFormat(valueType);

    internal static object S1L4DHEGxnshRpveHpdh([In] object obj0) => AsposeCellsExtension.ProcessValue(obj0);

    internal static void KRBQBeEG0s4CNfg0Z1AW([In] object obj0, [In] object obj1, [In] object obj2) => ((IExcelCellFormat) obj0).SetCellValue((Cell) obj1, obj2);

    internal static void bioQNgEGmiaQ7TWmAICm([In] object obj0, [In] object obj1) => ((IExcelCellFormat) obj0).ApplyFormat((Style) obj1);

    internal static bool tjoejsEGynxos53wcfe7([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static int aqM5kNEGMvAHc3RIaFHG([In] object obj0) => ((string) obj0).Length;

    internal static object g566vtEGJegm6GZwoa1m([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);
  }
}
