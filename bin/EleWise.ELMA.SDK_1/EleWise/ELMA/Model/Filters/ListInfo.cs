// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Filters.ListInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Filters
{
  /// <summary>Информация о коолекции в фильтре</summary>
  [XmlRoot("EntityListInfo")]
  public class ListInfo
  {
    internal static ListInfo dADZy4WYynrlqBf6gNsO;

    [XmlArray]
    public List<object> Objects { get; set; }

    [XmlElement("ListClass")]
    public string ListClass
    {
      get => this.\u003CListClass\u003Ek__BackingField;
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
              this.\u003CListClass\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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

    public ListInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Objects = new List<object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static bool YC9nMeWYMNkhgXxtfFXa() => ListInfo.dADZy4WYynrlqBf6gNsO == null;

    internal static ListInfo IMYWIbWYJh5ujVar3BcL() => ListInfo.dADZy4WYynrlqBf6gNsO;
  }
}
