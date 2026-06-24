// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Services.IQualifiedTypeNameResolverService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.Metadata.Services
{
  /// <summary>Сервис получения имени типа</summary>
  public interface IQualifiedTypeNameResolverService
  {
    /// <summary>Получить имя типа</summary>
    /// <param name="type">Тип</param>
    /// <returns>Имя типа</returns>
    string GetQualifiedTypeName(Type type);

    /// <summary>Получить тип по имени</summary>
    /// <param name="qualifiedTypeName">Имя типа</param>
    /// <returns>Тип</returns>
    Type GetType(string qualifiedTypeName);
  }
}
