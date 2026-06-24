// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ExportHelper.ExportRuleType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Deploy.ExportHelper
{
  /// <summary>Правила экспорта свойств сущности</summary>
  public enum ExportRuleType
  {
    /// <summary>
    /// Экспортировать значение свойства / экспортировать сущность без проваливания внутрь
    /// </summary>
    Export,
    /// <summary>
    /// Не экспортировать значение свойства / не экспортировать значение сущности
    /// </summary>
    Ignore,
    /// <summary>
    /// Экспортировать значение свойства / экспортировать сущность проваливаясь вглубь
    /// </summary>
    ExportDeep,
  }
}
