// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.FetchOptions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>Параметры выборки</summary>
  [DataContract]
  [Serializable]
  public sealed class FetchOptions : IEquatable<FetchOptions>
  {
    private int firstResult;
    private int maxResults;
    private ListSortDirection sortDirection;
    private string sortExpression;
    private List<FetchOptionsSortDescriptor> sortDescriptors;
    internal static FetchOptions ocF3WohTcM8axpnHbmUx;

    /// <summary>Ctor</summary>
    public FetchOptions()
    {
      FetchOptions.WLoE6HhkBUlGXxa0156L();
      this.maxResults = 20;
      this.sortDescriptors = new List<FetchOptionsSortDescriptor>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="firstResult">Индекс первого элемента</param>
    /// <param name="maxResults">Количество результатов</param>
    public FetchOptions(int firstResult, int maxResults)
    {
      FetchOptions.WLoE6HhkBUlGXxa0156L();
      this.maxResults = 20;
      this.sortDescriptors = new List<FetchOptionsSortDescriptor>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.maxResults = maxResults;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
            continue;
          case 2:
            this.firstResult = firstResult;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Ctor</summary>
    /// <param name="firstResult">Индекс первого элемента</param>
    /// <param name="maxResults">Количество результатов</param>
    /// <param name="sortDirection">Направление сортировки</param>
    /// <param name="sortExpression">Выражение сортировки</param>
    public FetchOptions(
      int firstResult,
      int maxResults,
      ListSortDirection sortDirection,
      string sortExpression)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.maxResults = 20;
      this.sortDescriptors = new List<FetchOptionsSortDescriptor>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.sortDirection = sortDirection;
            num = 4;
            continue;
          case 2:
            this.maxResults = maxResults;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.sortExpression = sortExpression;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 3 : 3;
            continue;
          default:
            this.firstResult = firstResult;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="firstResult">Индекс первого элемента</param>
    /// <param name="maxResults">Количество результатов</param>
    /// <param name="sortExpression">Выражение сортировки</param>
    /// <remarks>Пример выражения сортировки: Subject desc</remarks>
    public FetchOptions(int firstResult, int maxResults, string sortExpression)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.maxResults = 20;
      this.sortDescriptors = new List<FetchOptionsSortDescriptor>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_15;
          case 2:
            if (FetchOptions.gU6Nl1hkbtqc8t5cJjsq((object) sortExpression, FetchOptions.qR4bbAhko3rb2V0vQZTs(-2092274397 << 4 ^ 883268640), StringComparison.OrdinalIgnoreCase))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 4 : 4;
              continue;
            }
            if (!FetchOptions.gU6Nl1hkbtqc8t5cJjsq((object) sortExpression, FetchOptions.qR4bbAhko3rb2V0vQZTs(1514961705 ^ 1515140407), StringComparison.OrdinalIgnoreCase))
            {
              this.sortExpression = sortExpression;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 6 : 1;
              continue;
            }
            num = 9;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.sortDirection = ListSortDirection.Descending;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 3 : 8;
            continue;
          case 5:
            this.firstResult = firstResult;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          case 6:
            goto label_4;
          case 7:
            goto label_2;
          case 8:
            this.sortExpression = sortExpression.Remove(FetchOptions.K7gr4AhkhlovZc2kuHKL((object) sortExpression) - 5);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 1;
            continue;
          case 9:
            this.sortExpression = (string) FetchOptions.t9usB9hkGD2K8RsJOctq((object) sortExpression, FetchOptions.K7gr4AhkhlovZc2kuHKL((object) sortExpression) - 4);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 3 : 3;
            continue;
          case 10:
            if (FetchOptions.FL1almhkWhXCjglPqggX((object) sortExpression))
            {
              num = 7;
              continue;
            }
            goto case 2;
          default:
            this.maxResults = maxResults;
            num = 10;
            continue;
        }
      }
label_15:
      return;
label_3:
      return;
label_4:
      return;
label_2:;
    }

    /// <summary>Выбрать все записи</summary>
    public static FetchOptions All => new FetchOptions(0, 0, ListSortDirection.Ascending, (string) null);

    /// <summary>Выбрать первую запись</summary>
    public static FetchOptions First => new FetchOptions(0, 1);

    /// <summary>Индекс первого элемента</summary>
    [DataMember]
    public int FirstResult
    {
      get => this.firstResult;
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
              this.firstResult = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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

    /// <summary>Количество результатов</summary>
    [DataMember]
    public int MaxResults
    {
      get => this.maxResults;
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
              this.maxResults = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
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

    /// <summary>
    /// Cписок описателей сортировки (для множественной сортировки)
    /// </summary>
    [DataMember]
    public List<FetchOptionsSortDescriptor> SortDescriptors
    {
      get => this.sortDescriptors;
      set => this.sortDescriptors = value;
    }

    /// <summary>Выражение сортировки (имя свойства)</summary>
    [DataMember]
    public string SortExpression
    {
      get => this.sortExpression;
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
              this.sortExpression = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
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

    /// <summary>Направление сортировки</summary>
    [DataMember]
    public ListSortDirection SortDirection
    {
      get => this.sortDirection;
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
              this.sortDirection = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
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

    /// <summary>
    /// Столбцы которые будут присутствовать в результирующей выборке
    /// </summary>
    [DataMember]
    public List<string> SelectColumns { get; set; }

    /// <summary>
    /// Ссылки, коллекции (1-n, n-m) которые должны быть загружены SQL запросом через join
    /// используется для устранения проблемы "1+n select"
    /// </summary>
    [DataMember]
    public List<string> FetchRelations { get; set; }

    /// <summary>
    /// Уникальный ключ запроса (чтобы можно было менять критерию точками расширения)
    /// </summary>
    [DataMember]
    public string QueryKey
    {
      get => this.\u003CQueryKey\u003Ek__BackingField;
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
              this.\u003CQueryKey\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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

    /// <summary>
    /// Выбирает только те колонки, которые определены в SelectColumns
    /// </summary>
    [DataMember]
    public bool UseProjections
    {
      get => this.\u003CUseProjections\u003Ek__BackingField;
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
              this.\u003CUseProjections\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

    /// <summary>
    /// Предписывает использовать частичную выборку для всех ассоциаций, найденных при построении проекции
    /// (см. параметр <see cref="P:EleWise.ELMA.Model.Common.FetchOptions.UseProjections" />). Тем не менее, ассоциации,
    /// указанные в <see cref="P:EleWise.ELMA.Model.Common.FetchOptions.FetchRelations" /> , будут в любом случае "жадно" загружены (Eager fetching).
    /// </summary>
    [DataMember]
    public bool UsePartialFetching
    {
      get => this.\u003CUsePartialFetching\u003Ek__BackingField;
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
              this.\u003CUsePartialFetching\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
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

    /// <summary>
    /// Выключить сортировку по "папкам" для иерархических справочников по умолчанию
    /// </summary>
    [DataMember]
    internal bool DisableDefaultGroupSorting
    {
      get => this.\u003CDisableDefaultGroupSorting\u003Ek__BackingField;
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
              this.\u003CDisableDefaultGroupSorting\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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

    public override bool Equals(object obj)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((object) this == obj)
            {
              num = 4;
              continue;
            }
            if (!(obj.GetType() != FetchOptions.THbhslhkEwEcHApiBSk6((object) this)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          case 3:
            goto label_7;
          case 4:
            goto label_9;
          case 5:
            goto label_4;
          default:
            goto label_8;
        }
      }
label_4:
      return false;
label_7:
      return false;
label_8:
      return this.Equals((FetchOptions) obj);
label_9:
      return true;
    }

    private bool SortDescriptorsSequenceEqual(
      List<FetchOptionsSortDescriptor> sortDescriptorsObj,
      List<FetchOptionsSortDescriptor> otherSortDescriptorsObj)
    {
      if (sortDescriptorsObj == otherSortDescriptorsObj)
        return true;
      if (sortDescriptorsObj == null || otherSortDescriptorsObj == null)
        return false;
      return sortDescriptorsObj.SequenceEqual<FetchOptionsSortDescriptor>((IEnumerable<FetchOptionsSortDescriptor>) otherSortDescriptorsObj) || sortDescriptorsObj.Equals((object) otherSortDescriptorsObj);
    }

    public bool Equals(FetchOptions other)
    {
      int num = 7;
      while (true)
      {
        switch (num)
        {
          case 2:
            goto label_6;
          case 3:
            if (!FetchOptions.utXdVmhkQClJOfXKgCUo((object) this.SelectColumns, (object) other.SelectColumns))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
              continue;
            }
            goto case 13;
          case 4:
            if (this.sortDirection == other.sortDirection)
            {
              num = 11;
              continue;
            }
            goto label_3;
          case 6:
            goto label_11;
          case 7:
            if ((object) other == null)
            {
              num = 6;
              continue;
            }
            if ((object) this != (object) other)
            {
              if (this.firstResult == other.firstResult)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 12 : 9;
                continue;
              }
              goto label_3;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 2;
              continue;
            }
          case 8:
            if (!string.Equals(this.QueryKey, (string) FetchOptions.RT6Kk7hkC8OR887ruHnH((object) other), StringComparison.InvariantCultureIgnoreCase))
            {
              num = 5;
              continue;
            }
            goto case 10;
          case 9:
            goto label_2;
          case 10:
            if (this.UseProjections == FetchOptions.L2f6A5hkvjr8u326ZNXI((object) other))
            {
              num = 9;
              continue;
            }
            goto label_3;
          case 11:
            if (FetchOptions.UN9l9ChkffK2RALTHF0q((object) this.sortExpression, (object) other.sortExpression, StringComparison.InvariantCultureIgnoreCase))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 14 : 14;
              continue;
            }
            goto label_3;
          case 12:
            if (this.maxResults == other.maxResults)
            {
              num = 4;
              continue;
            }
            goto label_3;
          case 13:
            if (FetchOptions.utXdVmhkQClJOfXKgCUo((object) this.FetchRelations, (object) other.FetchRelations))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 2 : 8;
              continue;
            }
            goto label_3;
          case 14:
            if (!this.SortDescriptorsSequenceEqual(this.SortDescriptors, other.SortDescriptors))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          default:
            goto label_3;
        }
      }
label_2:
      return this.UsePartialFetching == other.UsePartialFetching;
label_3:
      return false;
label_6:
      return true;
label_11:
      return false;
    }

    public override int GetHashCode()
    {
      int num1 = ((((((int) ((ListSortDirection) ((this.firstResult * 397 ^ this.maxResults) * 397) ^ this.sortDirection) * 397 ^ (this.sortExpression != null ? FetchOptions.sbEfBmhkZaOaxhJD11ml(FetchOptions.BZ7ox9hk8c2jLPfjgBxA(), (object) this.sortExpression) : 0)) * 397 ^ (this.SortDescriptors != null ? this.SelectColumns.GetHashCode() : 0)) * 397 ^ (this.SelectColumns != null ? this.SelectColumns.GetHashCode() : 0)) * 397 ^ (this.FetchRelations == null ? 0 : this.FetchRelations.GetHashCode())) * 397 ^ (this.QueryKey != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(this.QueryKey) : 0)) * 397;
      bool flag = this.UseProjections;
      int hashCode1 = flag.GetHashCode();
      int num2 = (num1 ^ hashCode1) * 397;
      flag = this.UsePartialFetching;
      int hashCode2 = flag.GetHashCode();
      return num2 ^ hashCode2;
    }

    public static bool operator ==(FetchOptions left, FetchOptions right) => object.Equals((object) left, (object) right);

    public static bool operator !=(FetchOptions left, FetchOptions right) => !object.Equals((object) left, (object) right);

    internal static void WLoE6HhkBUlGXxa0156L() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool HDJVHihTzNSDe21HvsqB() => (object) FetchOptions.ocF3WohTcM8axpnHbmUx == null;

    internal static FetchOptions orpdINhkFO2UFhsh1Av0() => FetchOptions.ocF3WohTcM8axpnHbmUx;

    internal static bool FL1almhkWhXCjglPqggX([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object qR4bbAhko3rb2V0vQZTs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool gU6Nl1hkbtqc8t5cJjsq([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).EndsWith((string) obj1, obj2);

    internal static int K7gr4AhkhlovZc2kuHKL([In] object obj0) => ((string) obj0).Length;

    internal static object t9usB9hkGD2K8RsJOctq([In] object obj0, [In] int obj1) => (object) ((string) obj0).Remove(obj1);

    internal static Type THbhslhkEwEcHApiBSk6([In] object obj0) => obj0.GetType();

    internal static bool UN9l9ChkffK2RALTHF0q([In] object obj0, [In] object obj1, [In] StringComparison obj2) => string.Equals((string) obj0, (string) obj1, obj2);

    internal static bool utXdVmhkQClJOfXKgCUo([In] object obj0, [In] object obj1) => object.Equals(obj0, obj1);

    internal static object RT6Kk7hkC8OR887ruHnH([In] object obj0) => (object) ((FetchOptions) obj0).QueryKey;

    internal static bool L2f6A5hkvjr8u326ZNXI([In] object obj0) => ((FetchOptions) obj0).UseProjections;

    internal static object BZ7ox9hk8c2jLPfjgBxA() => (object) StringComparer.InvariantCultureIgnoreCase;

    internal static int sbEfBmhkZaOaxhJD11ml([In] object obj0, [In] object obj1) => ((StringComparer) obj0).GetHashCode((string) obj1);
  }
}
