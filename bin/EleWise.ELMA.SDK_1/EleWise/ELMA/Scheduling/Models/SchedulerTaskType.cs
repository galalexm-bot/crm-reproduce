// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Models.SchedulerTaskType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Scheduling.Models
{
  /// <summary>Тип задачи планировщика</summary>
  [Uid("d416d85e-62d4-458d-8865-65c13e0bd288")]
  [DefaultValueUid("21f9b877-1ec4-4d7b-b88a-e2cb05433faf")]
  [DisplayName(typeof (__Resources_SchedulerTaskType), "DisplayName")]
  [MetadataType(typeof (EnumMetadata))]
  public enum SchedulerTaskType
  {
    /// <summary>Одиночная</summary>
    [DisplayName(typeof (__Resources_SchedulerTaskType), "P_Once_DisplayName"), Uid("21f9b877-1ec4-4d7b-b88a-e2cb05433faf")] Once,
    /// <summary>Периодическая</summary>
    [DisplayName(typeof (__Resources_SchedulerTaskType), "P_Periodic_DisplayName"), Uid("dc26eaf6-e879-4019-ba24-7982259f36bd")] Periodic,
  }
}
