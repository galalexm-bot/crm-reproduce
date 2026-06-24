// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ITreeViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>
  /// Интерфейс представления, реализующего динамическое дерево
  /// </summary>
  internal interface ITreeViewItem : IDynamicViewItem, IViewItemWithPropertyParents
  {
    /// <summary>Идентификатор свойства с ключом</summary>
    Guid KeyUid { get; set; }

    /// <summary>
    /// Идентификатор свойства с ключом родительского элемента
    /// </summary>
    Guid ParentKeyUid { get; set; }
  }
}
