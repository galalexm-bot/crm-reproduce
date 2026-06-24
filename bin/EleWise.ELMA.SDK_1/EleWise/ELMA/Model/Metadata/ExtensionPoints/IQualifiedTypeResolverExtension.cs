// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ExtensionPoints.IQualifiedTypeResolverExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для <see cref="T:EleWise.ELMA.Model.Metadata.Services.IQualifiedTypeNameResolverService" />
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IQualifiedTypeResolverExtension
  {
    /// <summary>Уникальный идентификатор реализации</summary>
    Guid Uid { get; }

    /// <summary>Проверить тип на возможность обработки компонентом</summary>
    /// <param name="type">Тип</param>
    /// <returns><see langword="true" />, если тип можно обработать данной реализацией точки расширения</returns>
    bool CheckType(Type type);

    /// <summary>Получить данные для имени типа</summary>
    /// <param name="type">Тип</param>
    /// <returns>Данные для имени типа</returns>
    IEnumerable<byte> GetQualifiedTypeData(Type type);

    /// <summary>Получить тип по данным имени типа</summary>
    /// <param name="data">Данные имени типа</param>
    /// <returns>Тип</returns>
    Type GetType(IEnumerable<byte> data);
  }
}
