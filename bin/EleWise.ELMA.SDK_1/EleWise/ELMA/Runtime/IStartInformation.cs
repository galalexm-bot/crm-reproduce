// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.IStartInformation
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Runtime
{
  /// <summary>
  /// Информация об исполнении операции, выполняемой при запуске приложения
  /// </summary>
  public interface IStartInformation : IDisposable
  {
    /// <summary>Процент выполнения операции (0..100)</summary>
    double Percent { get; set; }

    /// <summary>Сообщение</summary>
    string Message { get; set; }

    /// <summary>Установить информацию</summary>
    /// <param name="percent">Процент (если текущий процент больше, то не изменяется)</param>
    /// <param name="message">Сообщение</param>
    void SetInfo(double percent, string message);

    /// <summary>Остановить выполнение операции на текущем проценте.</summary>
    void StopOperation();
  }
}
