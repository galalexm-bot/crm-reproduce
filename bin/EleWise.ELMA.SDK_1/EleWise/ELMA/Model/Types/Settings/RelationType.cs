// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.RelationType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Тип связи сущностей</summary>
  [DisplayName(typeof (__Resources_RelationType), "DisplayName")]
  [Uid("e8ad1e72-5c44-4225-a74c-f94c127fd87d")]
  [ShowInDesigner(false)]
  [MetadataType(typeof (EnumMetadata))]
  [ShowInTypeTree(false)]
  public enum RelationType
  {
    /// <summary>Одиночная (1-1 или N-1)</summary>
    [DisplayName(typeof (__Resources_RelationType), "P_OneToOne_DisplayName"), Uid("19d4a671-de00-4f40-bf34-62b2dfa7827f")] OneToOne,
    /// <summary>Множественная (1-N)</summary>
    [Uid("24cb6bb1-77b7-4ca1-aca3-17d5460d582f"), DisplayName(typeof (__Resources_RelationType), "P_OneToMany_DisplayName")] OneToMany,
    /// <summary>Многие-ко-многим</summary>
    [Uid("de89cdc4-8f00-4e8a-bb75-9dffa4725818"), DisplayName(typeof (__Resources_RelationType), "P_ManyToMany_DisplayName")] ManyToMany,
    /// <summary>Многие-ко-многим (инверсия)</summary>
    [Uid("5389ffbf-9b33-46c8-a2d7-618e034d70d9"), DisplayName(typeof (__Resources_RelationType), "P_ManyToManyInverse_DisplayName")] ManyToManyInverse,
  }
}
