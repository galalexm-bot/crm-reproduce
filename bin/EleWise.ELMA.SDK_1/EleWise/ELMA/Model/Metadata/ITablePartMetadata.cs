// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ITablePartMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata
{
  public interface ITablePartMetadata : 
    IPropertyMetadata,
    INamedMetadata,
    IOrderedMetadata,
    IMetadata,
    IXsiType
  {
    /// <summary>Имя Блока</summary>
    new string Name { get; set; }

    /// <summary>
    /// Uid свойства, содержащего ссылку на родительский объект блока
    /// </summary>
    Guid ParentPropertyUid { get; set; }

    /// <summary>Uid свойства, генерируемого для блока</summary>
    Guid TablePartPropertyUid { get; set; }

    List<PropertyMetadata> Properties { get; set; }

    /// <summary>Имя свойства, генерируемого для блока</summary>
    string TablePartPropertyName { get; set; }

    /// <summary>Имя сценария при загрузке формы элемента блока</summary>
    string OnViewLoadScriptName { get; set; }
  }
}
