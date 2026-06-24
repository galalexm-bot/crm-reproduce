// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.ILastObjectProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Объект поддерживает запись истории последних объектов</summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface ILastObjectProvider
  {
    /// <summary>Идентификатор типа объекта</summary>
    Guid TypeUid { get; }

    /// <summary>Отображаемое имя</summary>
    string DisplayName { get; }

    /// <summary>Добавить информацию</summary>
    /// <param name="entity">Сущность</param>
    void AddInfo(IEntity<long> entity);

    /// <summary>Возможно добавление информации</summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    bool CanAdd(IEntity<long> entity);

    /// <summary>Удалить информацию</summary>
    /// <param name="entity">Сущность</param>
    void RemoveInfo(IEntity<long> entity);
  }
}
