// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.IThreadSubPool
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Threading;

namespace EleWise.ELMA.Threading
{
  /// <summary>Интерфейс пула потоков</summary>
  public interface IThreadSubPool : IThreadPool
  {
    /// <summary>Поставить операцию в очередь</summary>
    /// <param name="task">Выполняемая операция</param>
    /// <param name="exceptionHandler">Обработчик ошибок</param>
    /// <param name="finallyHandler">Обработчик секции finally</param>
    void Queue(ThreadStart task, Action<Exception> exceptionHandler, Action finallyHandler);

    /// <summary>Поставить операцию в очередь</summary>
    /// <param name="task">Выполняемая операция</param>
    /// <param name="taskName">Имя операции</param>
    /// <param name="exceptionHandler">Обработчик ошибок</param>
    /// <param name="finallyHandler">Обработчик секции finally</param>
    void Queue(
      ThreadStart task,
      string taskName,
      Action<Exception> exceptionHandler,
      Action finallyHandler);
  }
}
