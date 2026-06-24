// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IEntityModelHistoryItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Security;
using System;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>Интерфейс для элемента истории изменения сущностей</summary>
  public interface IEntityModelHistoryItem
  {
    /// <summary>Дата создания</summary>
    DateTime CreationDate { get; set; }

    /// <summary>Автор создания</summary>
    IUser CreationAuthor { get; set; }

    /// <summary>Тип объекта</summary>
    Guid ObjectTypeUid { get; set; }

    /// <summary>Уникальный идентификатор объекта</summary>
    Guid ObjectUid { get; set; }

    /// <summary>Идентификатор объекта в БД</summary>
    long ObjectId { get; set; }

    /// <summary>Тип действия</summary>
    Guid ActionTypeUid { get; set; }
  }
}
