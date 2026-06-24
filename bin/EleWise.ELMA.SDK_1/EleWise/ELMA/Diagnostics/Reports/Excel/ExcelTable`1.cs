// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.ExcelTable`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Diagnostics.Reports.Excel
{
  /// <summary>Таблица Excel</summary>
  /// <typeparam name="TRow">Тип строки</typeparam>
  public class ExcelTable<TRow>
  {
    private static object kfYvBnEEOqO4OhcRPYeh;

    /// <summary>Ctor</summary>
    public ExcelTable()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Columns = new List<ExcelTable<TRow>.IColumn>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Колонки</summary>
    public List<ExcelTable<TRow>.IColumn> Columns { get; set; }

    /// <summary>Номер фиксированной строки</summary>
    public int FixedRows
    {
      get => this.\u003CFixedRows\u003Ek__BackingField;
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
              this.\u003CFixedRows\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
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

    /// <summary>Номер фиксированной колонки</summary>
    public int FixedColumns
    {
      get => this.\u003CFixedColumns\u003Ek__BackingField;
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
              this.\u003CFixedColumns\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
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

    /// <summary>Элементы</summary>
    public IEnumerable<TRow> Items { get; set; }

    /// <summary>Добавить колонку</summary>
    /// <typeparam name="TValue">Тип значения</typeparam>
    /// <param name="title">Заголово</param>
    /// <param name="width">Ширина</param>
    /// <param name="valueAccessor">Функция доступа к данным</param>
    /// <param name="format">Формат</param>
    /// <returns></returns>
    public ExcelTable<TRow> AddColumn<TValue>(
      string title,
      double width,
      Func<TRow, TValue> valueAccessor,
      IExcelCellFormat format = null)
    {
      this.Columns.Add((ExcelTable<TRow>.IColumn) new ExcelTable<TRow>.Column<TValue>()
      {
        Title = title,
        Width = width,
        ValueAccessor = valueAccessor,
        Format = format
      });
      return this;
    }

    /// <summary>Добавить колонку</summary>
    /// <typeparam name="TValue">Тип значения</typeparam>
    /// <param name="order">Порядок</param>
    /// <param name="title">Заголовок</param>
    /// <param name="width">Ширина</param>
    /// <param name="valueAccessor">Функция доступа к данным</param>
    /// <param name="format">Формат</param>
    /// <returns></returns>
    public ExcelTable<TRow> AddColumn<TValue>(
      long order,
      string title,
      double width,
      Func<TRow, TValue> valueAccessor,
      IExcelCellFormat format = null)
    {
      this.Columns.Add((ExcelTable<TRow>.IColumn) new ExcelTable<TRow>.Column<TValue>()
      {
        Order = order,
        Title = title,
        Width = width,
        ValueAccessor = valueAccessor,
        Format = format
      });
      return this;
    }

    /// <summary>Выстроить порядок столбцов страницы по атрибуту Order</summary>
    public void Order()
    {
      int num = 2;
      IEnumerable<ExcelTable<TRow>.IOrderedColumn> source;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Columns = source.OrderBy<ExcelTable<TRow>.IOrderedColumn, long>((Func<ExcelTable<TRow>.IOrderedColumn, long>) (c => c.Order)).Cast<ExcelTable<TRow>.IColumn>().ToList<ExcelTable<TRow>.IColumn>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
            continue;
          case 2:
            source = this.Columns.CastOrNull<ExcelTable<TRow>.IOrderedColumn>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool UPmR1WEE2wkUvYP42RQV() => ExcelTable<TRow>.kfYvBnEEOqO4OhcRPYeh == null;

    internal static object xSWuLOEEeBbbBnSBUwt9() => ExcelTable<TRow>.kfYvBnEEOqO4OhcRPYeh;

    /// <summary>Интерфейс колонки таблицы</summary>
    public interface IColumn
    {
      /// <summary>Заголовок</summary>
      string Title { get; }

      /// <summary>Ширина</summary>
      double Width { get; }

      /// <summary>Функция доступа к данным</summary>
      Func<TRow, object> ValueAccessor { get; }

      /// <summary>Формат ячейки</summary>
      IExcelCellFormat Format { get; }

      /// <summary>Тип значения</summary>
      Type ValueType { get; }
    }

    public interface IOrderedColumn : ExcelTable<TRow>.IColumn
    {
      /// <summary>Порядоковый номер колонки</summary>
      long Order { get; set; }
    }

    /// <summary>Колонка таблицы</summary>
    /// <typeparam name="TValue">Тип значения</typeparam>
    public class Column<TValue> : ExcelTable<TRow>.IOrderedColumn, ExcelTable<TRow>.IColumn
    {
      internal static object E1G21d8iDMotBwupaJYV;

      /// <inheritdoc />
      public long Order
      {
        get => this.\u003COrder\u003Ek__BackingField;
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
                this.\u003COrder\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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

      /// <inheritdoc />
      public string Title
      {
        get => this.\u003CTitle\u003Ek__BackingField;
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
                this.\u003CTitle\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
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

      /// <inheritdoc />
      public double Width
      {
        get => this.\u003CWidth\u003Ek__BackingField;
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
                this.\u003CWidth\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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

      /// <inheritdoc />
      public Func<TRow, TValue> ValueAccessor { get; set; }

      /// <inheritdoc />
      public IExcelCellFormat Format
      {
        get => this.\u003CFormat\u003Ek__BackingField;
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
                this.\u003CFormat\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
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

      /// <inheritdoc />
      Func<TRow, object> ExcelTable<TRow>.IColumn.ValueAccessor => this.ValueAccessor == null ? (Func<TRow, object>) null : (Func<TRow, object>) (r => (object) this.ValueAccessor(r));

      /// <inheritdoc />
      public Type ValueType => typeof (TValue);

      public Column()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool qsOuQm8itYLlxUWo8dcO() => ExcelTable<TRow>.Column<TValue>.E1G21d8iDMotBwupaJYV == null;

      internal static object e2bVsw8iwscr13dZ3SCI() => ExcelTable<TRow>.Column<TValue>.E1G21d8iDMotBwupaJYV;
    }
  }
}
