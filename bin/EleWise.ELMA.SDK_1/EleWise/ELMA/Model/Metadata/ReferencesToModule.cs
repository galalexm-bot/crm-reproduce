// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ReferencesToModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Модель для добавления ссылки на модуль</summary>
  public class ReferencesToModule
  {
    internal static ReferencesToModule BAqj7AbaFDTCOtU8SSQd;

    /// <summary>Уникальный идентификатор модуля</summary>
    public Guid ModuleUid
    {
      get => this.\u003CModuleUid\u003Ek__BackingField;
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
              this.\u003CModuleUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
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
    /// Список уникальных идентификаторов модулей, от которых зависит текущий
    /// </summary>
    public List<LinkToModule> References { get; set; }

    public ReferencesToModule()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool sVivqVbaBvVTpmHEw2pC() => ReferencesToModule.BAqj7AbaFDTCOtU8SSQd == null;

    internal static ReferencesToModule wxfQUNbaW7H6JJF9rWOm() => ReferencesToModule.BAqj7AbaFDTCOtU8SSQd;
  }
}
