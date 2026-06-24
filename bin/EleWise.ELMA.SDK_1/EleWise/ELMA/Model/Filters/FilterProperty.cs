// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Filters.FilterProperty
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Filters
{
  /// <summary>Информация о свойстве фильтра</summary>
  [XmlInclude(typeof (ListInfo))]
  [XmlInclude(typeof (QueryParametersListInfo))]
  [XmlRoot("FilterProperty")]
  public class FilterProperty
  {
    internal static FilterProperty kCC9OUWY7FwTONv0a9JU;

    [XmlElement("Uid")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
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

    [XmlElement("Value")]
    public object Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
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
              this.\u003CValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
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

    public FilterProperty()
    {
      FilterProperty.k0OHsCWYm9qfuDcA3MEO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Bg1CcHWYxsg6GuvKHwkx() => FilterProperty.kCC9OUWY7FwTONv0a9JU == null;

    internal static FilterProperty sv4OTeWY0NAct0GZrNpp() => FilterProperty.kCC9OUWY7FwTONv0a9JU;

    internal static void k0OHsCWYm9qfuDcA3MEO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
