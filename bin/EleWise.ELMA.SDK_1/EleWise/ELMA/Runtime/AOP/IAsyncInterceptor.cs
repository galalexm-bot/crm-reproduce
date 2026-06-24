// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.AOP.IAsyncInterceptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Castle.DynamicProxy;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.AOP
{
  /// <summary>Асинхронный перехватчик</summary>
  public interface IAsyncInterceptor : IInterceptor
  {
    /// <summary>Асинхронно выполнить перехват метода</summary>
    /// <param name="invocation">Сведения о вызове асинхронного метода</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task InterceptAsync(IInvocationAsync invocation, CancellationToken cancellationToken);
  }
}
