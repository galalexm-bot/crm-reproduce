// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.IPropertyMapService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Mappings
{
  /// <summary>Сервис для маппинга свойств</summary>
  public interface IPropertyMapService
  {
    /// <summary>
    /// Скопировать значения из <paramref name="objLeft" /> в <paramref name="objRight" /> в соответствии с картой <paramref name="map" />
    /// </summary>
    /// <param name="objLeft">Объект-источник</param>
    /// <param name="objRight">Целевой объект</param>
    /// <param name="map">Карта свойств</param>
    void Map(object objLeft, object objRight, PropertyMap map);

    /// <summary>Выполнить маппинг свойства</summary>
    /// <param name="objRight">Целевой объект</param>
    /// <param name="rightPropMd">Метаданные целевого свойства</param>
    /// <param name="leftValue">Значение свойства-источника</param>
    /// <param name="leftPropMetadata">Метаданные свойства-источника</param>
    void MapProperty(
      object objRight,
      PropertyMetadata rightPropMd,
      object leftValue,
      PropertyMetadata leftPropMetadata);

    /// <summary>Выполнить маппинг блока</summary>
    /// <param name="objLeft">Объект-источник</param>
    /// <param name="objRight">Целевой объект</param>
    /// <param name="leftTp">Метаданные блока-источника</param>
    /// <param name="rightTp">Метаданные целевого блока</param>
    /// <param name="map">Карта свойств</param>
    void MapTablePart(
      object objLeft,
      object objRight,
      TablePartMetadata leftTp,
      TablePartMetadata rightTp,
      PropertyMap map);
  }
}
