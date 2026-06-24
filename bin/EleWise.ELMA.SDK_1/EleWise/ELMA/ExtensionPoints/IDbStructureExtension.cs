// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IDbStructureExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Db;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для преобразования базы данных (с помощью XML-файла структуры)
  /// </summary>
  [ExtensionPoint(ComponentType.Server, ForceRegister = true)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IDbStructureExtension
  {
    /// <summary>
    /// Uid провайдера, для которого предназначается расширение (соответсвует <see cref="P:EleWise.ELMA.IProvider.Uid" />)
    /// </summary>
    /// <remarks>
    /// Если равен Guid.Empty, то применяется для всех провайдеров
    /// </remarks>
    Guid ProviderUid { get; }

    /// <summary>Структура</summary>
    DbStructure Structure { get; }

    /// <summary>Версия структуры</summary>
    Version Version { get; }

    /// <summary>
    /// Родительский преобразователь (для провайдеров конкретных СУБД)
    /// </summary>
    Type Parent { get; }

    /// <summary>
    /// Ссылки на преобразователи БД, от которых зависит данный преобразователь
    /// </summary>
    Type[] References { get; }
  }
}
