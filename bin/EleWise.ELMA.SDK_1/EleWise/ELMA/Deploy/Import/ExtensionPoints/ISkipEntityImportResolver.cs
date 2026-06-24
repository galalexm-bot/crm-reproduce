// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.ISkipEntityImportResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  [ExtensionPoint(ComponentType.All)]
  public interface ISkipEntityImportResolver
  {
    /// <summary>Поддерживается ли тип сущности</summary>
    bool IsSupported(Guid typeGuid);

    /// <summary>Пропускать сохранение сущности или нет</summary>
    /// <param name="propValues"></param>
    /// <param name="serviceData"></param>
    /// <returns></returns>
    bool IsSkip(Dictionary<string, object> propValues, Dictionary<string, string> serviceData);
  }
}
