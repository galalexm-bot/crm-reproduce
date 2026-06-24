// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.ISchedulerJobDb
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>Запланированная работа планировщика, хранящаяся в БД</summary>
  internal interface ISchedulerJobDb : ISchedulerJob
  {
    /// <summary>Задача планировщика</summary>
    ISchedulerTask SchedulerTask { get; set; }

    /// <summary>Обновить работу из БД</summary>
    void Refresh();
  }
}
