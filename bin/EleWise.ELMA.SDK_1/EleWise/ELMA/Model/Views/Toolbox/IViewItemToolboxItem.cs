// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbox.IViewItemToolboxItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using System;
using System.Drawing;

namespace EleWise.ELMA.Model.Views.Toolbox
{
  /// <summary>Элемент представления в панели инструментов</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IViewItemToolboxItem
  {
    /// <summary>Имя элемента</summary>
    string Name { get; }

    /// <summary>Uid группы элементов в панели инструментов</summary>
    Guid GroupUid { get; }

    /// <summary>
    /// Иконка для отображения элементов в панели инструментов
    /// </summary>
    Image Image { get; }

    /// <summary>Создать новый элемент представления</summary>
    /// <returns></returns>
    ViewItem CreateViewItem();

    bool IsAvailable(IMetadata metadata);
  }
}
