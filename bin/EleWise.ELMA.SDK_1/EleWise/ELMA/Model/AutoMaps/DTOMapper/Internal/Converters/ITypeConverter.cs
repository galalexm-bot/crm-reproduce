// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.Converters.ITypeConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.Converters
{
  /// <summary>Конвертер типов</summary>
  public interface ITypeConverter
  {
    /// <summary>Тип</summary>
    Type Type { get; }

    /// <summary>Можно ли сконвертировать в тип</summary>
    /// <param name="type">Тип</param>
    /// <returns><c>true</c>, если можно сконвертировать в тип</returns>
    bool CanConvertTo(Type type);

    /// <summary>Конвертировать значение в тип</summary>
    /// <param name="value">Значение</param>
    /// <param name="destinationType">Тип-назначение</param>
    /// <returns>Сконвертированное значение</returns>
    object ConvertTo(object value, Type destinationType);
  }
}
