// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.PropertyHandlers.IChangePropertyHandlerIgnoreProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using NHibernate.Event;
using System;

namespace EleWise.ELMA.Model.PropertyHandlers
{
  /// <summary>Определяет когда не нужно прописывать дату изменения</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IChangePropertyHandlerIgnoreProvider
  {
    /// <summary>Приминимо для заданного типа</summary>
    /// <param name="typeUid"></param>
    /// <returns></returns>
    bool CheckType(Guid typeUid);

    /// <summary>Условие игнорирования</summary>
    /// <param name="event"></param>
    /// <returns></returns>
    bool Ignore(PreUpdateEvent @event);
  }
}
