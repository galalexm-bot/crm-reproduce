// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Events.IEntityHistoryEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Dynamic;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Security;
using System;

namespace EleWise.ELMA.Model.Events
{
  /// <summary>
  /// Параметры события для действия с сущностью, используются для отображения истории.
  /// Наследник обязан иметь конструктор с параметрами <see cref="T:EleWise.ELMA.Model.Entities.IEntity" /> - сущность (может быть null), <see cref="T:System.Guid" /> - объект действия, <see cref="T:System.Guid" /> - тип действия.
  /// Также он обязан быть помечен аттрибутом <see cref="T:EleWise.ELMA.Model.Attributes.UidAttribute" /> с уникальным идентификатором
  /// </summary>
  [ExtensionPoint(false, ComponentType.All, ServiceScope.Application)]
  public interface IEntityHistoryEventArgs : 
    IAuditEventArgs,
    IAuditEventHolder,
    IExtendedPropertiesContainer
  {
    /// <summary>Время генерации события, задается в конструкторе</summary>
    DateTime ActionDate { get; set; }

    /// <summary>
    /// Уникальный идентификатор единицы работы, в которой было сгенерировано данное событие.
    /// Для новых событий равно <c><see cref="F:System.Guid.Empty" /></c>
    /// </summary>
    Guid UnitOfWorkUid { get; set; }

    /// <summary>Пользователь, запустивший событие</summary>
    IUser ActionAuthor { get; set; }

    /// <summary>Получить дополнительные данные для сохранения в БД</summary>
    /// <returns>Массив байт с данными</returns>
    /// <remarks>Например, можно сериализовать некоторые параметры при помощи <see cref="T:EleWise.ELMA.Serialization.ClassSerializationHelper" /></remarks>
    byte[] GetAdditionalData();

    /// <summary>Восстановить значения из дополнительных данных БД</summary>
    /// <param name="data">Массив байт с дополнительными данными</param>
    /// <remarks>Например, можно десериализовать некоторые параметры при помощи <see cref="T:EleWise.ELMA.Serialization.ClassSerializationHelper" /></remarks>
    void SetAdditionalData(byte[] data);
  }
}
