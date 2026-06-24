// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.IInterceptorProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using NHibernate;

namespace EleWise.ELMA.Runtime.NH
{
  public interface IInterceptorProvider
  {
    IInterceptor GetInterceptor(ISessionFactory factory);
  }
}
