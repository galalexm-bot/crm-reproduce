// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.IGlimpseMessagesMaker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Diagnostics.Glimpse
{
  /// <summary>
  /// Интерфейс точки расширения, предназначенной для генерации сообщений в Glimpse
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IGlimpseMessagesMaker
  {
    /// <summary>
    /// Проверить, можно ли использовать данный обработчик для указанного события
    /// </summary>
    /// <param name="event">Событие</param>
    /// <returns></returns>
    bool IsAvailable(DiagnosticsEvent @event);

    /// <summary>Сгенерировать сообщения в Glimpse для события</summary>
    /// <param name="event">Событие</param>
    /// <returns></returns>
    object[] MakeMessages(DiagnosticsEvent @event);
  }
}
