// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.IApplication
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Modules
{
  /// <summary>Приложение</summary>
  public interface IApplication : IModule, ICompositeApplicationUnit, IApplicationUnit
  {
    /// <summary>Основной модуль</summary>
    IModule MainModule { get; }

    /// <summary>Получить список системных модулей (включая основной)</summary>
    IEnumerable<IModule> SystemModules { get; }
  }
}
