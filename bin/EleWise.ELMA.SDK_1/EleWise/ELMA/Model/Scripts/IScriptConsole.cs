// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.IScriptConsole
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Консоль для сценариев</summary>
  public interface IScriptConsole
  {
    /// <summary>Вывести сообщение без перевода на новую строку</summary>
    /// <param name="message">Сообщение</param>
    void Write(string message);

    /// <summary>Вывести сообщение с переводом на новую строку</summary>
    /// <param name="message">Сообщение</param>
    void WriteLine(string message);
  }
}
