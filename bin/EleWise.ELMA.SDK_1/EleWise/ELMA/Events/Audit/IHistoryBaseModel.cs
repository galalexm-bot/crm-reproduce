// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IHistoryBaseModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Security;
using System;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>Модель элемента отображения истории работы с объектом</summary>
  public interface IHistoryBaseModel
  {
    /// <summary>Дата действия</summary>
    DateTime ActionDate { get; set; }

    /// <summary>Пользователь, выполнивший действие</summary>
    IUser ActionAuthor { get; set; }

    /// <summary>Тема (заголовок) действия</summary>
    string ActionTheme { get; set; }

    /// <summary>Тип действия, связанный с данным элементом</summary>
    IAuditAction AuditAction { get; set; }

    /// <summary>Объект действия, связанный с данным элементом</summary>
    IAuditObject AuditObject { get; set; }

    /// <summary>Оригинальное событие, связанное с данным элементом</summary>
    EntityActionEventArgs OriginalEvent { get; }

    /// <summary>
    /// Динамический объект, для хранения дополнительных данных отображения
    /// </summary>
    /// <remarks>
    /// Для обновления данных по событиям можно использовать точку расширения <see cref="T:EleWise.ELMA.Events.Audit.IHistoryModelEvaluator" />
    /// </remarks>
    object EventData { get; }
  }
}
