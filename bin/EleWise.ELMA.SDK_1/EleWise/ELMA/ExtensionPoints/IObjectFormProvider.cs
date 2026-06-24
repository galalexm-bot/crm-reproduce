// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IObjectFormProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Интерфейс провайдера форм</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IObjectFormProvider
  {
    /// <summary>Проверка типа</summary>
    /// <param name="typeUid">Уникальный идентификатор типа объекта</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа объекта</param>
    /// <returns><c>True</c>, если реализация провайдера подходит</returns>
    bool Check(Guid typeUid, Guid subTypeUid);

    /// <summary>Получить информацию об объекте</summary>
    /// <param name="typeUid">Уникальный идентификатор типа</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <param name="model">Модель в сериализованном виде</param>
    /// <returns>(Объект, Метаданные объекта)</returns>
    (object, ClassMetadata) GetObjectInfo(Guid typeUid, Guid subTypeUid, string model);

    /// <summary>Получить форму по типу</summary>
    /// <param name="obj">Объект</param>
    /// <param name="viewType">Тип формы</param>
    /// <returns>Форма</returns>
    FormViewItem GetFormByType(object obj, ViewType viewType);

    /// <summary>Получить форму по уникальному идентификатору</summary>
    /// <param name="obj">Объект</param>
    /// <param name="formUid">Уникальный идентификатор формы</param>
    /// <returns>Форма</returns>
    FormViewItem GetFormByUid(object obj, Guid formUid);

    /// <summary>Инициализировать объект</summary>
    /// <param name="obj">Объект</param>
    /// <param name="viewType">Тип формы</param>
    /// <param name="arguments">Аргументы</param>
    void InitObject(object obj, ViewType viewType, IDictionary<string, object> arguments);
  }
}
