// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.IUnitOfWork
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using NHibernate;
using System;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Единица работы http://martinfowler.com/eaaCatalog/unitOfWork.html
  /// </summary>
  public interface IUnitOfWork : IDisposable
  {
    /// <summary>
    /// Были ли произведены изменения в текущей еденице работы
    /// </summary>
    bool IsDirty { get; }

    /// <summary>Подтвердить изменения</summary>
    void Commit();

    /// <summary>Откат изменений</summary>
    void Rollback();

    /// <summary>Текущая сессия выполнения единицы работы</summary>
    ISession Session { get; }

    /// <summary>Уникальный идентификатор единицы работы</summary>
    Guid Uid { get; }
  }
}
