// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.LineAlignment
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Выравнивание в строке</summary>
  [DisplayName(typeof (__Resources_LineAlignment), "DisplayName")]
  [ShowInTypeTree(false)]
  [ShowInDesigner(false)]
  [MetadataType(typeof (EnumMetadata))]
  [Uid("fd854dfc-44d7-4232-9408-d193a30c7d6d")]
  public enum LineAlignment
  {
    /// <summary>По левому краю</summary>
    [Uid("4db80721-439d-469e-8afb-fb322e717df5"), DisplayName(typeof (__Resources_LineAlignment), "P_Left_DisplayName")] Left,
    /// <summary>По центру</summary>
    [DisplayName(typeof (__Resources_LineAlignment), "P_Center_DisplayName"), Uid("d0eb395e-3e22-429b-8be2-b8c2f5e6cf52")] Center,
    /// <summary>По правому краю</summary>
    [DisplayName(typeof (__Resources_LineAlignment), "P_Right_DisplayName"), Uid("dae9b88a-07b7-43cd-b4d0-9715ac047310")] Right,
  }
}
