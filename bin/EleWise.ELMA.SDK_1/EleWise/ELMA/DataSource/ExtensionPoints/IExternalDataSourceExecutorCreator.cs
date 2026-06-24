// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.DataSource.ExtensionPoints.IExternalDataSourceExecutorCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.DataSource.ExtensionPoints
{
  /// <summary>
  /// Интерфейс создателя исполнителей внешних источников данных
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IExternalDataSourceExecutorCreator
  {
    /// <summary>Имя исполнителя</summary>
    string Name { get; }

    /// <summary>Идентификатор типа исполнителя</summary>
    Guid TypeUid { get; }

    /// <summary>Фабричный метод</summary>
    IExternalDataSourceExecutor Create(string connectionString);
  }
}
