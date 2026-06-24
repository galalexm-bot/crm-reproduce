// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.IEntityInstanceDefaultPermission
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using System;

namespace EleWise.ELMA.Security
{
  /// <summary>Права по умолчанию для объектов сущности</summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-813.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IEntityInstanceDefaultPermission
  {
    /// <summary>Тип сущности с привилегиями</summary>
    Type EntityType { get; }

    /// <summary>Создать привилегии</summary>
    /// <param name="entity">Сущность</param>
    void CreatePermissions(IEntity entity);
  }
}
