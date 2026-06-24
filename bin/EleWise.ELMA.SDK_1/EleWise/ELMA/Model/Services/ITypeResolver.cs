// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.ITypeResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>
  /// Позволяет находить типы, которые не зарегистрированы в <see cref="T:IMetadataRuntimeService" />
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface ITypeResolver
  {
    /// <summary>
    /// Получить тип по уникальному идентификатору. В случае, если не найден, возвращается null.
    /// </summary>
    /// <param name="uid">Уникальный идентификатор типа</param>
    /// <returns>Тип или null</returns>
    Type GetTypeByUid(Guid uid);
  }
}
