// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ComponentExportSetting
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Конфигурация экспорта компонентов</summary>
  [Serializable]
  public class ComponentExportSetting
  {
    internal static ComponentExportSetting N6OC0GE5EG8oPC9N06XL;

    /// <summary>Ctor</summary>
    public ComponentExportSetting()
    {
      ComponentExportSetting.UlcwJ4E5C2XDsU43LWbK();
      // ISSUE: reference to a compiler-generated field
      this.\u003CComponentsIds\u003Ek__BackingField = new List<Guid>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Идентификаторы метаданных компонентов с флагом переноса перечислений
    /// </summary>
    public List<Guid> ComponentsIds { get; set; }

    internal static void UlcwJ4E5C2XDsU43LWbK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool MKdbcfE5fasCoZSnwwXl() => ComponentExportSetting.N6OC0GE5EG8oPC9N06XL == null;

    internal static ComponentExportSetting cwVcXfE5QfnLuR5Snvy8() => ComponentExportSetting.N6OC0GE5EG8oPC9N06XL;
  }
}
