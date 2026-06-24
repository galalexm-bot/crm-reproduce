// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Dynamic.IExtendedPropertiesContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Dynamic
{
  /// <summary>
  /// Интерфейс объекта, содержащего словарь дополнительных свойств
  /// </summary>
  public interface IExtendedPropertiesContainer
  {
    /// <summary>Получить словарь свойств расширения объекта</summary>
    IDictionary<string, object> ExtendedProperties { get; }
  }
}
