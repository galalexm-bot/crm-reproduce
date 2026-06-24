// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ExtensionPoints.SDKStartExportRulesIgnore
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints
{
  /// <summary>
  /// Игнорирование сущностей TablePart при проверке наличия правил экспорта при старте системы
  /// </summary>
  [Component]
  public class SDKStartExportRulesIgnore : IStartExportRulesIgnore
  {
    internal static SDKStartExportRulesIgnore ukS18cEUaCUgaXKxIUWS;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entityMetadata"></param>
    /// <returns></returns>
    public bool IgnoreThisEntity(EntityMetadata entityMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (entityMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_6;
          case 3:
            goto label_7;
          default:
            if (!(entityMetadata is TablePartMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 3;
              continue;
            }
            goto label_6;
        }
      }
label_6:
      return true;
label_7:
      return false;
    }

    public SDKStartExportRulesIgnore()
    {
      SDKStartExportRulesIgnore.Ml7FZ5EUwr7IYs7hsDco();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool aN8R7SEUDkSLtHj9ybh0() => SDKStartExportRulesIgnore.ukS18cEUaCUgaXKxIUWS == null;

    internal static SDKStartExportRulesIgnore slOgImEUt4Efa2S7iGDV() => SDKStartExportRulesIgnore.ukS18cEUaCUgaXKxIUWS;

    internal static void Ml7FZ5EUwr7IYs7hsDco() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
