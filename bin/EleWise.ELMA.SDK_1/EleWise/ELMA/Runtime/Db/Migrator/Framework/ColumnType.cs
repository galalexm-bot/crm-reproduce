// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Framework.ColumnType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Data;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework
{
  /// <summary>Тип столбца таблицы</summary>
  public class ColumnType
  {
    internal static ColumnType YwHnGXW2o4ftYd8idWOm;

    public ColumnType(DbType dataType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.DataType = dataType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public ColumnType(DbType dataType, int length)
    {
      ColumnType.AEsg4bW2GY4vF98d7Wvc();
      // ISSUE: explicit constructor call
      this.\u002Ector(dataType);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Length = new int?(length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public ColumnType(DbType dataType, int length, int scale)
    {
      ColumnType.AEsg4bW2GY4vF98d7Wvc();
      // ISSUE: explicit constructor call
      this.\u002Ector(dataType, length);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Scale = new int?(scale);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип данных</summary>
    public DbType DataType
    {
      get => this.\u003CDataType\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CDataType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Размер</summary>
    public int? Length { get; set; }

    /// <summary>Точность</summary>
    public int? Scale { get; set; }

    /// <summary>Приведение типов DbType -&gt; ColumnType</summary>
    /// <param name="type">Тип колонки, заданный в виде DbType</param>
    /// <returns>Объект ColumnType, соответствующий заданному типу DbType</returns>
    public static implicit operator ColumnType(DbType type) => new ColumnType(type);

    public override string ToString()
    {
      int num1 = 1;
      string str1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          int? nullable;
          string str2;
          switch (num2)
          {
            case 1:
              nullable = this.Length;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            case 2:
              if (nullable.HasValue)
              {
                str2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345290118).FormatWith((object) this.Length, (object) this.Scale);
                break;
              }
              goto label_11;
            case 3:
              str2 = string.Empty;
              break;
            case 4:
              goto label_3;
            case 5:
              nullable = this.Scale;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 2;
              continue;
            case 6:
              if (!nullable.HasValue)
                goto case 3;
              else
                goto label_13;
            case 7:
              str2 = ((string) ColumnType.yEw5ZHW2EsQhEMMdR3P9(-35995181 ^ -36125085)).FormatWith((object) this.Length);
              break;
            case 8:
              nullable = this.Length;
              num2 = 6;
              continue;
            default:
              if (nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 5 : 5;
                continue;
              }
              goto case 8;
          }
          str1 = str2;
          num2 = 4;
        }
label_11:
        num1 = 8;
        continue;
label_13:
        num1 = 7;
      }
label_3:
      return ((string) ColumnType.yEw5ZHW2EsQhEMMdR3P9(~-397266137 ^ 397221426)).FormatWith((object) this.DataType, (object) str1);
    }

    internal static bool E8PRBOW2baHjaUSZoJgA() => ColumnType.YwHnGXW2o4ftYd8idWOm == null;

    internal static ColumnType tNSrvOW2hL1n0wmk2boJ() => ColumnType.YwHnGXW2o4ftYd8idWOm;

    internal static void AEsg4bW2GY4vF98d7Wvc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object yEw5ZHW2EsQhEMMdR3P9(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
