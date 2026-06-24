// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.IUnitOfWorkManagerRollback
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>Расширение фабрики единицы работ</summary>
  public interface IUnitOfWorkManagerRollback
  {
    /// <summary>
    /// Зарегистрировать действие, которое нужно выполнить после отката транзакции
    /// </summary>
    /// <param name="action">Действие</param>
    void RegisterRollbackAction(Action action);
  }
}
