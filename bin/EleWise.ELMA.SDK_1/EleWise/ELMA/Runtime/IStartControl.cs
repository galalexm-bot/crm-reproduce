// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.IStartControl
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Runtime
{
  /// <summary>Интерфейс центра управления запуском сервера</summary>
  public interface IStartControl
  {
    /// <summary>Продолжить запуск сервера</summary>
    void Continue();

    /// <summary>Приостановить запуск сервера</summary>
    /// <param name="suspendReason">Код причины приостановки запуска сервера</param>
    void Suspend(StartStatus suspendReason);

    /// <summary>Приостановить запуск сервера</summary>
    /// <param name="suspendReason">Код причины приостановки запуска сервера</param>
    /// <param name="suspendMessage">Сообщение, поясняющее причину приостановки</param>
    void Suspend(StartStatus suspendReason, string suspendMessage);
  }
}
