// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.IPropertyMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Types.Settings;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Интерфейс метаданных свойства класса</summary>
  public interface IPropertyMetadata : INamedMetadata, IOrderedMetadata, IMetadata, IXsiType
  {
    /// <summary>Имя свойства</summary>
    new string Name { get; set; }

    /// <summary>Uid свойства</summary>
    Guid PropertyUid { get; set; }

    /// <summary>Uid типа свойства</summary>
    Guid TypeUid { get; set; }

    /// <summary>Uid подтипа свойства</summary>
    Guid SubTypeUid { get; set; }

    /// <summary>Настройки свойства</summary>
    TypeSettings Settings { get; set; }

    /// <summary>Обязательно для заполнения</summary>
    bool Required { get; set; }

    /// <summary>Тип, в котором объявлено данное свойство</summary>
    Type DeclaringType { get; set; }

    /// <summary>Имя сценария при изменении значения</summary>
    string OnChangeScriptName { get; set; }
  }
}
