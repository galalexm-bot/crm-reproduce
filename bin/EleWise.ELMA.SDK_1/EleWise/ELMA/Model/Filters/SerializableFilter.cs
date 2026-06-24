// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Filters.SerializableFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Filters
{
  [Component]
  [XmlRoot("Filter")]
  public class SerializableFilter : IXsiRoot
  {
    private static SerializableFilter Bs99NZWY4P0EbtjhR3Yr;

    /// <summary>Тип фильтра</summary>
    [XmlElement("FilterType")]
    public string FilterType
    {
      get => this.\u003CFilterType\u003Ek__BackingField;
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
              this.\u003CFilterType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
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

    /// <summary>Тип</summary>
    [XmlElement("ResolverType")]
    public string ResolverType
    {
      get => this.\u003CResolverType\u003Ek__BackingField;
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
              this.\u003CResolverType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
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

    /// <summary>Свойства фильтра</summary>
    [XmlArray]
    public List<FilterProperty> Properties { get; set; }

    public SerializableFilter()
    {
      SerializableFilter.qGXCsnWYA6Usai2fMOaw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Properties = new List<FilterProperty>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    internal static bool aIfjXcWY6e64twQ9DPhA() => SerializableFilter.Bs99NZWY4P0EbtjhR3Yr == null;

    internal static SerializableFilter HaAjMIWYHZwm0vrlqene() => SerializableFilter.Bs99NZWY4P0EbtjhR3Yr;

    internal static void qGXCsnWYA6Usai2fMOaw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
