// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.ScheduleType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>Типа расписания</summary>
  [Serializable]
  public enum ScheduleType
  {
    /// <summary>Одиночный запуск</summary>
    Once,
    /// <summary>Ежедневно</summary>
    Daily,
    /// <summary>Еженедельно</summary>
    Weekly,
    /// <summary>Ежемесячно</summary>
    Monthly,
  }
}
