// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.JobStatus
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>Статус выполнения работы планировщика</summary>
  [MetadataType(typeof (EnumMetadata))]
  [DisplayName(typeof (__Resources_JobStatus), "DisplayName")]
  [Uid("cfaea77f-1cdc-40fa-954b-d43da508b05a")]
  public enum JobStatus
  {
    /// <summary>Ожидание запуска</summary>
    [Uid("d23bae26-8639-4e3f-b18f-bfaa733d467b"), DisplayName(typeof (__Resources_JobStatus), "P_Pending_DisplayName")] Pending,
    /// <summary>Задача в данный момент выполняется</summary>
    [DisplayName(typeof (__Resources_JobStatus), "P_Working_DisplayName"), Uid("c5c99a17-f4fe-46d5-87f0-ae565c5e0656")] Working,
    /// <summary>Успешное выполнение</summary>
    [Uid("298be857-2414-414e-9c8b-66491d359ea8"), DisplayName(typeof (__Resources_JobStatus), "P_Success_DisplayName")] Success,
    /// <summary>Выполнение с ошибками</summary>
    [Uid("41ce53c2-8838-422b-a277-f89c60421e43"), DisplayName(typeof (__Resources_JobStatus), "P_Errors_DisplayName")] Errors,
    /// <summary>Выполнение не прошло</summary>
    [DisplayName(typeof (__Resources_JobStatus), "P_Fail_DisplayName"), Uid("f570723b-048b-4c92-b1d2-f24ec50a8fcf")] Fail,
  }
}
