// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TableRowEditMode
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Режим редактирования строки таблицы</summary>
  [DisplayName(typeof (__Resources_TableRowEditMode), "DisplayName")]
  [ShowInTypeTree(false)]
  [ShowInDesigner(false)]
  [MetadataType(typeof (EnumMetadata))]
  [Uid("02062d1b-10e3-4799-ad8d-9bceddba7b30")]
  public enum TableRowEditMode
  {
    /// <summary>Всплывающее окно</summary>
    [DisplayName(typeof (__Resources_TableRowEditMode), "P_PopUp_DisplayName"), Uid("d34e5976-a35f-47d3-9e3c-7daaebdf2e48")] PopUp,
    /// <summary>Таблица</summary>
    [DisplayName(typeof (__Resources_TableRowEditMode), "P_Table_DisplayName"), Uid("86785551-c2a9-4e07-af8f-96ca071da06a")] Table,
    /// <summary>Всплывающее окно и таблица</summary>
    [DisplayName(typeof (__Resources_TableRowEditMode), "P_PopUpAndTable_DisplayName"), Uid("eec44ace-368f-41cb-86fe-21a628fd0cbb")] PopUpAndTable,
  }
}
