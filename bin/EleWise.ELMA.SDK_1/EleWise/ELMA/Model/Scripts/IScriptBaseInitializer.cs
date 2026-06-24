// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.IScriptBaseInitializer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>
  /// Интерфейс для инициализации базового класса модуля сценариев
  /// </summary>
  public interface IScriptBaseInitializer
  {
    void SetConsole(IScriptConsole console);

    void SetIsDebug(bool isDebug);
  }
}
