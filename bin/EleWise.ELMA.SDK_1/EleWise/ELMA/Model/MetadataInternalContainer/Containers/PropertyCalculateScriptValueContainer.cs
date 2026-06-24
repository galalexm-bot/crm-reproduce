// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertyCalculateScriptValueContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers
{
  /// <summary>
  /// Контейнер хранения данных свойства вычисляемых по сценарию
  /// </summary>
  internal class PropertyCalculateScriptValueContainer : IPropertyDefaultValueContainer
  {
    private IPropertyValueContainer propertyValueContainer;
    internal static PropertyCalculateScriptValueContainer KPD3iKhob0rnGt8is4Wc;

    /// <summary>Установить сценарий</summary>
    /// <param name="scriptType">Сценарий</param>
    internal void SetScriptType(Type scriptType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.propertyValueContainer = (IPropertyValueContainer) Activator.CreateInstance(scriptType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => this.propertyValueContainer;

    public PropertyCalculateScriptValueContainer()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool LGMiGuhohdqyH6xVC6v4() => PropertyCalculateScriptValueContainer.KPD3iKhob0rnGt8is4Wc == null;

    internal static PropertyCalculateScriptValueContainer M3WEXEhoG4jMn3782AyR() => PropertyCalculateScriptValueContainer.KPD3iKhob0rnGt8is4Wc;
  }
}
