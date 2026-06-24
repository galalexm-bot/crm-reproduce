// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.IHiddenSchedulerJob
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Scheduling
{
  /// <summary>
  /// Скрытая работа планировщика.
  /// Можно управлять её отображаением в перечне запланированных работ.
  /// </summary>
  public interface IHiddenSchedulerJob
  {
    /// <summary>
    /// Признак скрытой задачи планировщика.
    /// Такие задачи не отображаются в списке запланированных заданий планировщика.
    /// </summary>
    bool Hidden { get; }
  }
}
