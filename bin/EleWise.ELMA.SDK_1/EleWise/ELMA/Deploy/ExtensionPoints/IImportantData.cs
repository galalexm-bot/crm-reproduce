// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ExtensionPoints.IImportantData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.ExtensionPoints
{
  /// <summary>Информация о важных данных для импорта</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IImportantData
  {
    /// <summary>Уникальный идентификатор</summary>
    Guid Uid { get; }

    /// <summary>Версии, в которых появляется реализация</summary>
    IEnumerable<Version> Versions { get; }

    /// <summary>
    /// Идентификатор модуля, в котором присутсвует реализация
    /// </summary>
    string Module { get; }
  }
}
