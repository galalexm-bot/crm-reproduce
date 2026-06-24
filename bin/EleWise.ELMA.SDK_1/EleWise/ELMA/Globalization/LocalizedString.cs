// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.LocalizedString
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Globalization
{
  /// <summary>Хранилище локализованного значения типа String</summary>
  public class LocalizedString : Dictionary<int, string>
  {
    internal static LocalizedString rSBrONGfaxCMINxS3dgp;

    /// <summary>Значение по умолчанию</summary>
    [XmlElement("Default")]
    public string Default
    {
      get => this.\u003CDefault\u003Ek__BackingField;
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
              this.\u003CDefault\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
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

    public LocalizedString()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool NdmRYlGfDCpaYoRVGsLS() => LocalizedString.rSBrONGfaxCMINxS3dgp == null;

    internal static LocalizedString xiepRRGftCbvq1cJ0nY0() => LocalizedString.rSBrONGfaxCMINxS3dgp;
  }
}
