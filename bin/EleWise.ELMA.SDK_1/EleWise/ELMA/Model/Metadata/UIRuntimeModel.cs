// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.UIRuntimeModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Runtime модель КИ</summary>
  [DataContract]
  public sealed class UIRuntimeModel
  {
    internal static UIRuntimeModel Uwidlhb3ehEjtgHJC9qA;

    /// <summary>Ctor</summary>
    public UIRuntimeModel()
    {
      UIRuntimeModel.p9Oamrb3NiFkqtM2f4Wu();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.RuntimeModules = new List<ItemRuntimeModel>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Список модулей в Runtime</summary>
    [DataMember]
    public List<ItemRuntimeModel> RuntimeModules { get; set; }

    internal static void p9Oamrb3NiFkqtM2f4Wu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool IVvJdlb3P8rsRSBQfj8O() => UIRuntimeModel.Uwidlhb3ehEjtgHJC9qA == null;

    internal static UIRuntimeModel OFiuLFb31ectAekFjAPq() => UIRuntimeModel.Uwidlhb3ehEjtgHJC9qA;
  }
}
