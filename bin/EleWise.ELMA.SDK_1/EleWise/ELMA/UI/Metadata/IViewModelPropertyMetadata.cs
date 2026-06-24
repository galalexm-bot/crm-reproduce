// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.IViewModelPropertyMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Интерфейс свойства модели отображения</summary>
  public interface IViewModelPropertyMetadata : 
    IPropertyMetadata,
    INamedMetadata,
    IOrderedMetadata,
    IMetadata,
    IXsiType
  {
    /// <summary>Свойство используется только в клиентской части</summary>
    bool ClientOnly { get; set; }

    /// <summary>Входное</summary>
    bool Input { get; set; }

    /// <summary>Выходное</summary>
    bool Output { get; set; }

    /// <summary>Вычисляемое значение</summary>
    ComputedValue ComputedValue { get; set; }

    /// <summary>Список вычисляемых значений</summary>
    List<ComputedValue> ComputedValues { get; set; }
  }
}
