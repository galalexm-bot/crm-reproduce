// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.PropertyHandlerInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Информация об обработчике свойства</summary>
  [Serializable]
  public class PropertyHandlerInfo
  {
    private static PropertyHandlerInfo JkDYtXbHj12MaNbLawRa;

    /// <summary>Уникальный идентификатор обработчика</summary>
    public Guid HandlerUid
    {
      get => this.\u003CHandlerUid\u003Ek__BackingField;
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
              this.\u003CHandlerUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
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

    public PropertyHandlerInfo()
    {
      PropertyHandlerInfo.X2FTkHbHUrpIFkSgGbrV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool VjBJxIbHYx0BtGG8CWWR() => PropertyHandlerInfo.JkDYtXbHj12MaNbLawRa == null;

    internal static PropertyHandlerInfo bdRqZAbHLtpZs4of0Grp() => PropertyHandlerInfo.JkDYtXbHj12MaNbLawRa;

    internal static void X2FTkHbHUrpIFkSgGbrV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
