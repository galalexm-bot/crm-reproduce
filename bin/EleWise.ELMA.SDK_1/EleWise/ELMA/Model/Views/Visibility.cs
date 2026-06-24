// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Visibility
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Видимость элемента</summary>
  [Uid("c9f10bdc-93bb-45ad-831a-1ff2e63a3ef9")]
  [ShowInTypeTree(false)]
  [DisplayName(typeof (__Resources_Visibility), "DisplayName")]
  [MetadataType(typeof (EnumMetadata))]
  [ShowInDesigner(false)]
  public enum Visibility
  {
    /// <summary>Скрывать</summary>
    [Uid("1ce934fc-c569-4706-846b-51e682a94db2"), DisplayName(typeof (__Resources_Visibility), "P_Hidden_DisplayName")] Hidden,
    /// <summary>Показывать</summary>
    [Uid("2b843113-9bf3-42db-b2b7-21259c06ca2b"), DisplayName(typeof (__Resources_Visibility), "P_Visible_DisplayName")] Visible,
    /// <summary>Скрывать всегда</summary>
    [DisplayName(typeof (__Resources_Visibility), "P_ForceHidden_DisplayName"), Uid("44422b3f-ab49-4d2f-852a-0b4815feb1a3")] ForceHidden,
  }
}
