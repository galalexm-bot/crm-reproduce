// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IBuildHubsAssemblyService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Services
{
  /// <summary>Сервис построения сборки с хабами</summary>
  internal interface IBuildHubsAssemblyService
  {
    /// <summary>Построить сборки хабов SignalR</summary>
    /// <returns>
    /// Массив RAW сборок хабов SignalR:
    /// 1) Подписанная сборка с хабами (при условии наличия реализаций хабов в подписанных сборках решения)
    /// 2) Не подписанная сборка с хабами
    /// </returns>
    byte[][] BuildAssemblies();
  }
}
