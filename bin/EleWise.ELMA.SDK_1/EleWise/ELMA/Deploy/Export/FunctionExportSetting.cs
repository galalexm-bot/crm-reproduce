// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.FunctionExportSetting
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Конфигурация экспорта функций</summary>
  [Serializable]
  public class FunctionExportSetting
  {
    private static FunctionExportSetting vvDYhVE5ve5LrQ5KTrKx;

    /// <summary>Ctor</summary>
    public FunctionExportSetting()
    {
      FunctionExportSetting.UACcdNE5ul215edZFrFg();
      // ISSUE: reference to a compiler-generated field
      this.\u003CFunctionsIds\u003Ek__BackingField = new List<Guid>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Идентификаторы метаданных функций с флагом переноса перечислений
    /// </summary>
    public List<Guid> FunctionsIds { get; set; }

    internal static void UACcdNE5ul215edZFrFg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool C5x9YRE58iRHdWQrouLi() => FunctionExportSetting.vvDYhVE5ve5LrQ5KTrKx == null;

    internal static FunctionExportSetting cvKf5KE5Zf8XEb2cog6k() => FunctionExportSetting.vvDYhVE5ve5LrQ5KTrKx;
  }
}
