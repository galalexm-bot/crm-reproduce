// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.Models.WebDataFactory
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ServiceModel.Web;

namespace EleWise.ELMA.Common.Models
{
  /// <summary>Фабрика WebData нужной версии (согласно заголовкам)</summary>
  internal static class WebDataFactory
  {
    /// <summary>Создать WebData</summary>
    /// <param name="dicObj">Словарь</param>
    /// <returns>WebData</returns>
    public static WebData Create(IDictionary<string, object> dicObj)
    {
      if (WebOperationContext.Current != null)
      {
        string a = WebOperationContext.Current.IncomingRequest.Headers.Get(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921415677));
        if (!string.IsNullOrWhiteSpace(a) && string.Equals(a, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822639874), StringComparison.InvariantCultureIgnoreCase))
          return (WebData) new EleWise.ELMA.Common.Models.API.WebData(dicObj);
      }
      return new WebData(dicObj);
    }

    /// <summary>Создать WebData из сущности</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="propertyFilter">Фильтр свойства</param>
    /// <param name="tablePartFilter">Фильтр блока</param>
    /// <returns>WebData</returns>
    [Obsolete("Метод устарел", true)]
    public static WebData CreateFromEntity(
      IEntity entity,
      Func<PropertyMetadata, bool> propertyFilter,
      Func<TablePartMetadata, bool> tablePartFilter)
    {
      return WebDataFactory.CreateFromEntity(entity, propertyFilter, (Func<ITablePartMetadata, bool>) (m => tablePartFilter((TablePartMetadata) m)));
    }

    /// <summary>Создать WebData из сущности</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="settings">Настройки сериализации</param>
    /// <param name="propertyFilter">Фильтр свойства</param>
    /// <param name="tablePartFilter">Фильтр блока</param>
    /// <returns>WebData</returns>
    [Obsolete("Метод устарел", true)]
    public static WebData CreateFromEntity(
      IEntity entity,
      EntitySerializationSettings settings,
      Func<PropertyMetadata, bool> propertyFilter,
      Func<TablePartMetadata, bool> tablePartFilter)
    {
      return WebDataFactory.CreateFromEntity(entity, settings, propertyFilter, (Func<ITablePartMetadata, bool>) (m => tablePartFilter((TablePartMetadata) m)));
    }

    /// <summary>Создать WebData из сущности</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="propertyFilter">Фильтр свойства</param>
    /// <param name="tablePartFilter">Фильтр блока</param>
    /// <returns>WebData</returns>
    public static WebData CreateFromEntity(
      IEntity entity,
      Func<PropertyMetadata, bool> propertyFilter = null,
      Func<ITablePartMetadata, bool> tablePartFilter = null)
    {
      IDictionary<string, object> dicObj = WebData.DictionaryFromEntity(entity, propertyFilter, tablePartFilter);
      return dicObj == null ? (WebData) null : WebDataFactory.Create(dicObj);
    }

    /// <summary>Создать WebData из сущности</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="settings">Настройки сериализации</param>
    /// <param name="propertyFilter">Фильтр свойства</param>
    /// <param name="tablePartFilter">Фильтр блока</param>
    /// <returns>WebData</returns>
    public static WebData CreateFromEntity(
      IEntity entity,
      EntitySerializationSettings settings,
      Func<PropertyMetadata, bool> propertyFilter = null,
      Func<ITablePartMetadata, bool> tablePartFilter = null)
    {
      IDictionary<string, object> dicObj = WebData.DictionaryFromEntity(entity, settings, propertyFilter, tablePartFilter);
      return dicObj == null ? (WebData) null : WebDataFactory.Create(dicObj);
    }
  }
}
