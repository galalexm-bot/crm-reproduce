// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.IFormatTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Дополнительный интерфейс описания типа, позволяющий форматировать значения данного типа в строку
  /// </summary>
  public interface IFormatTypeDescriptor
  {
    /// <summary>Форматировать значение</summary>
    /// <param name="value">Значение</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Сформатированное значение</returns>
    string FormatValue(object value, PropertyMetadata propertyMetadata);

    /// <summary>Форматировать значение</summary>
    /// <param name="value">Значение</param>
    /// <param name="settings">Настройки свойства</param>
    /// <returns>Сформатированное значение</returns>
    string FormatValue(object value, TypeSettings settings);
  }
}
