// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.PackageChangesStatus
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.API.Models
{
  /// <summary>Статус формирования кэша изменений для пользователя</summary>
  [MetadataType(typeof (EnumMetadata))]
  [Uid("b312e8c7-5241-4c59-8219-ab701956c065")]
  [DisplayName(typeof (__Resources_PackageChangesStatus), "DisplayName")]
  public enum PackageChangesStatus
  {
    /// <summary>Новый</summary>
    [DisplayName(typeof (__Resources_PackageChangesStatus), "P_New_DisplayName"), Uid("30346b54-7362-4f92-90dc-4714a8744051")] New,
    /// <summary>Завершено</summary>
    [DisplayName(typeof (__Resources_PackageChangesStatus), "P_Completed_DisplayName"), Uid("fe913b0d-d588-4798-a201-2ab664bc5450")] Completed,
  }
}
