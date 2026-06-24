// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Models.SchedulerTaskStatus
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Scheduling.Models
{
  /// <summary>Статус задачи планировщика</summary>
  [DefaultValueUid("fdd26016-cca3-442a-b2f7-b0b091e34e94")]
  [DisplayName(typeof (__Resources_SchedulerTaskStatus), "DisplayName")]
  [MetadataType(typeof (EnumMetadata))]
  [Uid("742e4058-85b4-4412-98d2-b80cc8f0aa3e")]
  public enum SchedulerTaskStatus
  {
    /// <summary>Активна</summary>
    [Uid("fdd26016-cca3-442a-b2f7-b0b091e34e94"), DisplayName(typeof (__Resources_SchedulerTaskStatus), "P_Enabled_DisplayName")] Enabled,
    /// <summary>Не активна</summary>
    [DisplayName(typeof (__Resources_SchedulerTaskStatus), "P_Disabled_DisplayName"), Uid("ff6fb316-cc09-47e2-aa1c-ee8b36f66a94")] Disabled,
    /// <summary>Закрыта</summary>
    [Uid("1616e67a-1d33-463e-b55b-b3b8499a65c5"), DisplayName(typeof (__Resources_SchedulerTaskStatus), "P_Closed_DisplayName")] Closed,
  }
}
