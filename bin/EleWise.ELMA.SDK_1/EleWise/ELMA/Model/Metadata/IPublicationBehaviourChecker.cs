// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.IPublicationBehaviourChecker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Enums;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Базовый интерфейс для определения тип публикации объекта метаданных
  /// </summary>
  public interface IPublicationBehaviourChecker
  {
    /// <summary>Определить тип публикации</summary>
    /// <param name="action">Тип проверки</param>
    /// <param name="oldValue">Старое значение</param>
    /// <param name="newValue">Новое значение</param>
    /// <returns>Тип публикации</returns>
    PublicationType Check(CheckType action, object oldValue, object newValue);
  }
}
