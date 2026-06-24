// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.IElmaThreadPool
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Threading;

namespace EleWise.ELMA.Threading
{
  /// <summary>Внутренний пул потоков ELMA</summary>
  public interface IElmaThreadPool
  {
    /// <summary>Поместить элемент в очередь на исполнение</summary>
    /// <param name="callback">Действие, которое необходимо выполнить</param>
    /// <exception cref="T:System.InvalidOperationException">Внутренний пул потоков ELMA не инициализирован</exception>
    /// <returns>Элемент очереди исполнения пула потоков</returns>
    IElmaThreadPoolWorkItem Push(ThreadStart callback);

    /// <summary>Поместить элемент в очередь на исполнение</summary>
    /// <param name="callback">Действие, которое необходимо выполнить</param>
    /// <param name="exceptionHandler">Обработчик ошибок</param>
    /// <param name="finallyHandler">Обработчик секции finally</param>
    /// <exception cref="T:System.InvalidOperationException">Внутренний пул потоков ELMA не инициализирован</exception>
    /// <returns>Элемент очереди исполнения пула потоков</returns>
    IElmaThreadPoolWorkItem Push(
      ThreadStart callback,
      Action<Exception> exceptionHandler,
      Action finallyHandler);
  }
}
