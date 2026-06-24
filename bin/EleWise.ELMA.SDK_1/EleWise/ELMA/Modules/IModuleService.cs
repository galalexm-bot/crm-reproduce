// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.IModuleService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Modules
{
  /// <summary>Работу с модулями</summary>
  public interface IModuleService
  {
    /// <summary>Получить список включенных модулей</summary>
    /// <returns></returns>
    IEnumerable<IWebModuleUnit> GetEnabledModules();

    /// <summary>Получить список включенных модулей</summary>
    /// <returns></returns>
    IWebModuleUnit GetModuleByType(Type type);

    /// <summary>Получить список установленных модулей</summary>
    /// <returns></returns>
    IEnumerable<IWebModuleUnit> GetInstalledModules();
  }
}
