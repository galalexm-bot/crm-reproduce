// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.PerformanceCategoryRegistrar
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Counters;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;

namespace EleWise.ELMA.Diagnostics
{
  /// <inheritdoc />
  [Service(Type = ComponentType.Server)]
  internal sealed class PerformanceCategoryRegistrar : IPerformanceCategoryRegistrar
  {
    /// <summary>
    /// Имя категории по умолчанию для счётчиков производительности ELMA
    /// </summary>
    public static readonly string DefaultCategoryName;
    private static readonly string CategoryHelp;
    private readonly IEnumerable<IPerformanceCounter> counters;
    private readonly ILogger logger;
    internal static PerformanceCategoryRegistrar YgyjUIGzTvVO1XBPLQ6I;

    /// <summary>Ctor</summary>
    /// <param name="counters">Счётчики производительности</param>
    /// <param name="logger">Логгер</param>
    public PerformanceCategoryRegistrar(IEnumerable<IPerformanceCounter> counters, ILogger logger)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.counters = counters;
      this.logger = logger;
    }

    /// <inheritdoc />
    public void CheckRegisterDefault()
    {
      switch (1)
      {
        case 1:
          try
          {
            IEnumerable<IPerformanceCounter> counters = this.counters;
            // ISSUE: reference to a compiler-generated field
            Func<IPerformanceCounter, IEnumerable<CounterCreationData>> func = PerformanceCategoryRegistrar.\u003C\u003Ec.\u003C\u003E9__5_0;
            Func<IPerformanceCounter, IEnumerable<CounterCreationData>> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              PerformanceCategoryRegistrar.\u003C\u003Ec.\u003C\u003E9__5_0 = selector = (Func<IPerformanceCounter, IEnumerable<CounterCreationData>>) (c => c.GetCreationData());
            }
            else
              goto label_29;
label_3:
            IEnumerable<CounterCreationData> counterCreationDatas = counters.SelectMany<IPerformanceCounter, CounterCreationData>(selector);
            int num1 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
              num1 = 0;
            bool flag;
            while (true)
            {
              switch (num1)
              {
                case 1:
                case 4:
                  if (!flag)
                  {
                    num1 = 8;
                    continue;
                  }
                  goto case 2;
                case 2:
                  this.CreateCategory(PerformanceCategoryRegistrar.DefaultCategoryName, PerformanceCategoryRegistrar.CategoryHelp, PerformanceCounterCategoryType.SingleInstance, counterCreationDatas);
                  num1 = 3;
                  continue;
                case 3:
                  goto label_18;
                case 5:
                  PerformanceCategoryRegistrar.dKUO9HGz20bHtlNabc0U((object) PerformanceCategoryRegistrar.DefaultCategoryName);
                  num1 = 6;
                  continue;
                case 6:
                  flag = true;
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 0;
                  continue;
                case 7:
                  // ISSUE: reference to a compiler-generated method
                  if (!counterCreationDatas.All<CounterCreationData>((Func<CounterCreationData, bool>) (c => PerformanceCounterCategory.CounterExists((string) PerformanceCategoryRegistrar.\u003C\u003Ec.yXrPGU8V34rFuPCrkx67((object) c), PerformanceCategoryRegistrar.DefaultCategoryName))))
                  {
                    num1 = 5;
                    continue;
                  }
                  goto case 1;
                case 8:
                  goto label_15;
                default:
                  int num2 = PerformanceCategoryRegistrar.UmiQ8lGzOdXmQC32t6Od((object) PerformanceCategoryRegistrar.DefaultCategoryName) ? 1 : 0;
                  flag = num2 == 0;
                  if (num2 == 0)
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 4;
                    continue;
                  }
                  goto case 7;
              }
            }
label_18:
            break;
label_15:
            break;
label_29:
            selector = func;
            goto label_3;
          }
          catch (Exception ex)
          {
            int num = 2;
            string fullPath;
            while (true)
            {
              switch (num)
              {
                case 1:
                case 4:
                  goto label_28;
                case 2:
                  if (!(ex is SecurityException))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                    continue;
                  }
                  goto case 5;
                case 3:
                case 6:
                  PerformanceCategoryRegistrar.SjGEXyGz17ZjTMWf47AV((object) this.logger, PerformanceCategoryRegistrar.tl2ARiGzN1Thdr5nUfJx(PerformanceCategoryRegistrar.P7J6qJGzP44TMd2LY7hY(-710283084 ^ -537863435 ^ 173869443)), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
                  continue;
                case 5:
                  fullPath = Path.GetFullPath(Path.Combine((string) PerformanceCategoryRegistrar.xC70ToGzev5Nh6woR3fU((object) AppDomain.CurrentDomain), (string) PerformanceCategoryRegistrar.P7J6qJGzP44TMd2LY7hY(647913418 ^ 647658884), (string) PerformanceCategoryRegistrar.P7J6qJGzP44TMd2LY7hY(-1852837372 ^ -1853108150), (string) PerformanceCategoryRegistrar.P7J6qJGzP44TMd2LY7hY(1051276242 - 990076387 ^ 60946361), (string) PerformanceCategoryRegistrar.P7J6qJGzP44TMd2LY7hY(-1426456882 ^ 2009939514 ^ -583998824), z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293433972)));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 7 : 7;
                  continue;
                case 7:
                  PerformanceCategoryRegistrar.SjGEXyGz17ZjTMWf47AV((object) this.logger, (object) EleWise.ELMA.SR.T((string) PerformanceCategoryRegistrar.P7J6qJGzP44TMd2LY7hY(1012087039 ^ 1012341315), (object) fullPath), (object) ex);
                  num = 4;
                  continue;
                default:
                  if (!(ex is UnauthorizedAccessException))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 6 : 0;
                    continue;
                  }
                  goto case 5;
              }
            }
label_28:
            throw;
          }
      }
    }

    /// <inheritdoc />
    public string GetMissingCountersFileName() => (string) PerformanceCategoryRegistrar.BlrUZhGzpAX9b9FXD7P3(PerformanceCategoryRegistrar.IS0XV0Gz3nOLaTb0KB3I(), PerformanceCategoryRegistrar.P7J6qJGzP44TMd2LY7hY(-87337865 ^ -87068615));

    /// <inheritdoc />
    public void CreateCategory(
      string categoryName,
      string categoryHelp,
      PerformanceCounterCategoryType categoryType,
      IEnumerable<CounterCreationData> allCreationData)
    {
      try
      {
        PerformanceCounterCategory.Create(categoryName, categoryHelp, categoryType, new CounterCreationDataCollection(allCreationData.ToArray<CounterCreationData>()));
      }
      catch (Exception ex)
      {
        switch (ex)
        {
          case SecurityException _:
          case UnauthorizedAccessException _:
            this.AppendToMissingFile(categoryName, categoryHelp, categoryType, allCreationData);
            break;
        }
        throw;
      }
    }

    /// <summary>Добавить данные к файлу о необходимых категориях</summary>
    /// <param name="categoryName">Имя категории</param>
    /// <param name="categoryHelp">Описание категории</param>
    /// <param name="categoryType">Тип категории</param>
    /// <param name="allCreationData">Данные счётчиков</param>
    private void AppendToMissingFile(
      string categoryName,
      string categoryHelp,
      PerformanceCounterCategoryType categoryType,
      IEnumerable<CounterCreationData> allCreationData)
    {
      try
      {
        string countersFileName = this.GetMissingCountersFileName();
        CategoriesInfo categoriesInfo = new CategoriesInfo();
        if (File.Exists(countersFileName))
          categoriesInfo = ClassSerializationHelper.DeserializeObjectByJsonNet<CategoriesInfo>(File.ReadAllText(countersFileName));
        categoriesInfo.Categories.Add(new CategoryInfo()
        {
          CategoryName = categoryName,
          CategoryHelp = categoryHelp,
          CountersData = allCreationData.Select<CounterCreationData, CounterInfo>(new Func<CounterCreationData, CounterInfo>(CounterInfo.From)).ToList<CounterInfo>()
        });
        string contents = ClassSerializationHelper.SerializeObjectByJsonNet((object) categoriesInfo);
        File.WriteAllText(countersFileName, contents);
      }
      catch (Exception ex)
      {
        this.logger.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406100017)), ex);
      }
    }

    static PerformanceCategoryRegistrar()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            PerformanceCategoryRegistrar.DefaultCategoryName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825373426);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          case 3:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = 2;
            continue;
          default:
            PerformanceCategoryRegistrar.CategoryHelp = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426349519));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static bool UmiQ8lGzOdXmQC32t6Od([In] object obj0) => PerformanceCounterCategory.Exists((string) obj0);

    internal static void dKUO9HGz20bHtlNabc0U([In] object obj0) => PerformanceCounterCategory.Delete((string) obj0);

    internal static object xC70ToGzev5Nh6woR3fU([In] object obj0) => (object) ((AppDomain) obj0).BaseDirectory;

    internal static object P7J6qJGzP44TMd2LY7hY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void SjGEXyGz17ZjTMWf47AV([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object tl2ARiGzN1Thdr5nUfJx([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool YypulbGzktU7TlYrwBnQ() => PerformanceCategoryRegistrar.YgyjUIGzTvVO1XBPLQ6I == null;

    internal static PerformanceCategoryRegistrar WTRjW3GznHlxNULc2bO5() => PerformanceCategoryRegistrar.YgyjUIGzTvVO1XBPLQ6I;

    internal static object IS0XV0Gz3nOLaTb0KB3I() => (object) IOExtensions.GetTempPath();

    internal static object BlrUZhGzpAX9b9FXD7P3([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);
  }
}
