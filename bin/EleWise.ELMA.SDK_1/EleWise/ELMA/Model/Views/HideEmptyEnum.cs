// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.HideEmptyEnum
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>
  /// Перечисление для настройки скрытия пустого элемента формы
  /// </summary>
  public enum HideEmptyEnum
  {
    /// <summary>Наследовать настройку от родительского элемента формы</summary>
    [XmlEnum("inherit")] Inherit,
    /// <summary>Показывать пустой элемент формы</summary>
    [XmlEnum("false")] ShowEmpty,
    /// <summary>Скрывать пустой элменет формы</summary>
    [XmlEnum("true")] HideEmpty,
  }
}
