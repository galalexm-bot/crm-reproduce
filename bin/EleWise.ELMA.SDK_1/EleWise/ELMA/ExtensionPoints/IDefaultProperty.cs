// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IDefaultProperty
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Свойство сущности по умолчанию (шаблон свойства)</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IDefaultProperty
  {
    /// <summary>Имя свойства (для текущей культуры)</summary>
    string Name { get; }

    /// <summary>Guid свойства</summary>
    Guid Uid { get; }

    /// <summary>
    /// Включена ли галочка использования данного свойства по умолчанию
    /// </summary>
    bool DefaultChecked { get; }

    /// <summary>Доступно ли свойство</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="allProperties">Список всех свойств и блоков (включая унаследованные)</param>
    /// <returns>True, если доступно</returns>
    bool IsAvailableFor(ClassMetadata classMetadata, List<IMetadata> allProperties = null);

    /// <summary>Инициализировать метаданные свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    void InitProperty(ClassMetadata classMetadata, PropertyMetadata propertyMetadata);
  }
}
