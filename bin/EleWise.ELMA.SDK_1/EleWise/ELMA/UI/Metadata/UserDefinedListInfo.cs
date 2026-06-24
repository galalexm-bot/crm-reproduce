// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.UserDefinedListInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Информация о пользовательском списке</summary>
  [Serializable]
  public sealed class UserDefinedListInfo
  {
    internal static UserDefinedListInfo OssdfKBhm08Bkp6pktD3;

    /// <summary>ctor</summary>
    public UserDefinedListInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.GroupingProperties = new List<GroupingProperty>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 2;
            continue;
          case 2:
            this.AggregationProperties = new List<AggregationProperty>();
            num = 3;
            continue;
          case 3:
            this.IncludedProperties = new List<IncludedProperty>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    /// <summary>Уникальный идентификатор пользовательского списка</summary>
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
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

    /// <summary>Название пользовательского списка</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор типа свойства</summary>
    public Guid TypeUid
    {
      get => this.\u003CTypeUid\u003Ek__BackingField;
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
              this.\u003CTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор подтипа свойства</summary>
    public Guid SubTypeUid
    {
      get => this.\u003CSubTypeUid\u003Ek__BackingField;
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
              this.\u003CSubTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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

    /// <summary>Группировка</summary>
    public List<GroupingProperty> GroupingProperties { get; set; }

    /// <summary>Аггрегация</summary>
    public List<AggregationProperty> AggregationProperties { get; set; }

    /// <summary>Вложенные свойства</summary>
    public List<IncludedProperty> IncludedProperties { get; set; }

    /// <summary>EQL условие для заполнения выбранных значений</summary>
    public string ComputedEqlQuery
    {
      get => this.\u003CComputedEqlQuery\u003Ek__BackingField;
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
              this.\u003CComputedEqlQuery\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
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
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.UserDefinedListInfo.GroupingProperties" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeGroupingProperties() => UserDefinedListInfo.wT1VBUBhJZDtWLMJtJQs((object) this.GroupingProperties) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.UserDefinedListInfo.AggregationProperties" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeAggregationProperties() => UserDefinedListInfo.JcJxHABh9ZNtC9M9KOAQ((object) this.AggregationProperties) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.UserDefinedListInfo.IncludedProperties" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeIncludedProperties() => UserDefinedListInfo.hZYP8sBhdhujVoCiOyZy((object) this.IncludedProperties) != 0;

    internal static bool V44WstBhyUvJ1vlbJfeK() => UserDefinedListInfo.OssdfKBhm08Bkp6pktD3 == null;

    internal static UserDefinedListInfo NQhEhCBhMwacQC7mR8g7() => UserDefinedListInfo.OssdfKBhm08Bkp6pktD3;

    internal static int wT1VBUBhJZDtWLMJtJQs([In] object obj0) => ((List<GroupingProperty>) obj0).Count;

    internal static int JcJxHABh9ZNtC9M9KOAQ([In] object obj0) => ((List<AggregationProperty>) obj0).Count;

    internal static int hZYP8sBhdhujVoCiOyZy([In] object obj0) => ((List<IncludedProperty>) obj0).Count;
  }
}
