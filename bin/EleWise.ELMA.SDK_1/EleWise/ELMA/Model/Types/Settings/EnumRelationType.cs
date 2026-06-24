// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.EnumRelationType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Тип связи перечислений</summary>
  [MetadataType(typeof (EnumMetadata))]
  [Uid("0b9f4a56-fc45-43fe-b88b-fcc0b59fc15e")]
  [DefaultValueUid("386659e9-c682-47cc-af70-dd8b94ca0eac")]
  [DisplayName(typeof (__Resources_EnumRelationType), "DisplayName")]
  public enum EnumRelationType
  {
    /// <summary>Одиночная</summary>
    [Uid("1d491eba-23c2-4900-82a2-45ba13edcd1a"), DisplayName(typeof (__Resources_EnumRelationType), "P_One_DisplayName")] One,
    /// <summary>Список</summary>
    [Uid("a52f2632-6774-44d4-a1a1-ca60b7e95d49"), DisplayName(typeof (__Resources_EnumRelationType), "P_Many_DisplayName")] Many,
  }
}
