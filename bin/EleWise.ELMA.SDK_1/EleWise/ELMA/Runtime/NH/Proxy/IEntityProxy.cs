// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Proxy.IEntityProxy
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using NHibernate.Proxy;

namespace EleWise.ELMA.Runtime.NH.Proxy
{
  /// <summary>Интерфейс инициализации прокси сущности</summary>
  internal interface IEntityProxy : INHibernateProxy
  {
    /// <summary>Создание прокси</summary>
    /// <param name="lazyInitializer">Инициализатор</param>
    /// <returns>Прокси</returns>
    INHibernateProxy InitLazyInitializer(ILazyInitializer lazyInitializer);
  }
}
