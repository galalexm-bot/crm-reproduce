// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.FindComponent.Models.CleanUIObjectsModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.UI.Services.FindComponent.Models
{
  /// <inheritdoc />
  internal sealed class CleanUIObjectsModel : ICleanUIObjectsModel
  {
    internal static CleanUIObjectsModel AhXq1XBBn3Ci7GZTXEyt;

    /// <inheritdoc />
    public Guid[] Modules
    {
      get => this.\u003CModules\u003Ek__BackingField;
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
              this.\u003CModules\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
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

    public CleanUIObjectsModel()
    {
      CleanUIObjectsModel.j7kfU6BBeA0Xg9YvIPeS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool REKiBxBBO0muO4InjLig() => CleanUIObjectsModel.AhXq1XBBn3Ci7GZTXEyt == null;

    internal static CleanUIObjectsModel TGC8SKBB283ifrFGeygy() => CleanUIObjectsModel.AhXq1XBBn3Ci7GZTXEyt;

    internal static void j7kfU6BBeA0Xg9YvIPeS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
