// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Managers.IMetadataItemGroupUIManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.UI.Models;
using System;

namespace EleWise.ELMA.UI.Managers
{
  /// <summary>Интерфейс менеджера метаданных групп КИ</summary>
  internal interface IMetadataItemGroupUIManager : 
    IEntityManager<MetadataItemGroupUI, long>,
    IEntityManager<MetadataItemGroupUI>,
    IEntityManager
  {
    /// <summary>Создать группу</summary>
    /// <param name="typeUid">Уникальный идентификатор типа метаданных</param>
    /// <param name="moduleUid">Модуль</param>
    /// <param name="groupUid">Родительская группа</param>
    /// <param name="displayName">Отображаемое имя</param>
    /// <param name="name">Наименование</param>
    /// <returns>Группа</returns>
    MetadataItemGroupUI Create(
      Guid typeUid,
      Guid moduleUid,
      Guid groupUid,
      string displayName,
      string name);

    /// <summary>Редактировать группу</summary>
    /// <param name="uid">Идентификатор группы</param>
    /// <param name="typeUid">Уникальный идентификатор типа метаданных</param>
    /// <param name="moduleUid">Модуль</param>
    /// <param name="groupUid">Родительская группа</param>
    /// <param name="displayName">Отображаемое имя</param>
    /// <param name="name">Имя</param>
    /// <returns>Группа</returns>
    MetadataItemGroupUI Edit(
      Guid uid,
      Guid typeUid,
      Guid moduleUid,
      Guid groupUid,
      string displayName,
      string name);
  }
}
