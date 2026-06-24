// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IHistoryModelEvaluator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Точка расширения, позволяет добавить дополнительные данные в объект отображения истории
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IHistoryModelEvaluator
  {
    /// <summary>Обработать модель отображения истории</summary>
    /// <param name="historyModel">Модель элемента истории объекта</param>
    void Evaluate(IHistoryBaseModel historyModel);
  }
}
