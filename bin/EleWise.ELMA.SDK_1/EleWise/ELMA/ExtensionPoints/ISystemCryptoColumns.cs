// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.ISystemCryptoColumns
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using System.Collections.Generic;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Колонки, которые не могут участвовать в шифровании</summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface ISystemCryptoColumns
  {
    /// <summary>Проверка примменимости</summary>
    /// <param name="metadata"></param>
    /// <returns></returns>
    bool CheckMetadata(IMetadata metadata);

    /// <summary>Свойства</summary>
    IEnumerable<string> PropertyNames { get; }
  }
}
